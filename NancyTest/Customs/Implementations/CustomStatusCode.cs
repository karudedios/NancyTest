using System;
using System.Collections.Generic;
using System.Linq;
using Nancy;
using Nancy.ErrorHandling;
using Nancy.Extensions;
using Nancy.ViewEngines;

namespace NancyTest.Customs
{
    public class CustomStatusCode : IStatusCodeHandler
    {
        private static IEnumerable<int> _checks = new List<int>();

        public static IEnumerable<int> Checks { get { return _checks; } }

        private readonly IViewRenderer _viewRenderer;
        public static bool AllowIISErrors { get; set; }

        public CustomStatusCode(IViewRenderer viewRenderer)
        {
            _viewRenderer = viewRenderer;
        }

        public bool HandlesStatusCode(HttpStatusCode statusCode, NancyContext context)
        {
            return (_checks.Any(x => x == (int)statusCode)) || (!AllowIISErrors && statusCode.IsError());
        }

        public static void AddCode(int code)
        {
            AddCode(new List<int>() { code });
        }
        public static void AddCode(IEnumerable<int> code)
        {
            _checks = _checks.Union(code);
        }

        public static void RemoveCode(int code)
        {
            RemoveCode(new List<int>() { code });
        }
        public static void RemoveCode(IEnumerable<int> code)
        {
            _checks = _checks.Except(code);
        }

        public static void Disable()
        {
            _checks = new List<int>();
        }

        public void Handle(HttpStatusCode statusCode, NancyContext context)
        {
            try
            {
                var response = _viewRenderer.RenderView(context, (_checks.Any(x => x == (int)statusCode) ? (int)statusCode : 500) + ".cshtml", context.GetExceptionDetails());
                response.StatusCode = statusCode;
                context.Response = response;
            }
            catch (Exception)
            {

                RemoveCode((int)statusCode);
                context.Response.StatusCode = statusCode;
            }
        }
    }
}
