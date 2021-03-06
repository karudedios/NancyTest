﻿using System.Configuration;
using System.Linq;
using Nancy.Bootstrapper;
using Nancy.ErrorHandling;
using Nancy.TinyIoc;
using Nancy.ViewEngines;
using NancyTest.Customs;
using NancyTest.DAL.Implementation;
using NancyTest.DAL.Implementation.Abstract;

namespace NancyTest
{
    using Nancy;

    public class Bootstrapper : DefaultNancyBootstrapper
    {
        // The bootstrapper enables you to reconfigure the composition of the framework,
        // by overriding the various methods and properties.
        // For more information https://github.com/NancyFx/Nancy/wiki/Bootstrapper

        protected override void ApplicationStartup(TinyIoCContainer container, IPipelines pipelines)
        {
            CustomStatusCode.AddCode(400);
            CustomStatusCode.AddCode(401);
            CustomStatusCode.AddCode(404);
            CustomStatusCode.AddCode(500);

            CustomStatusCode.AllowIISErrors = true;

            base.ApplicationStartup(container, pipelines);
            container.Register<IProvider>(new Provider());

            Conventions.ViewLocationConventions.Clear();
            Conventions.ViewLocationConventions.Add((viewName, model, context) => string.Concat("Layout/", viewName));
            Conventions.ViewLocationConventions.Add((viewName, model, context) => string.Concat("Codes/", viewName));
            Conventions.ViewLocationConventions.Add((viewName, model, context) => string.Concat(context.ModuleName, "/", viewName));

            //pipelines.OnError += (ctx, err) => HandleExceptions(err, ctx); ;
        }

        /*private static Response HandleExceptions(Exception ex, NancyContext ctx)
        {
            var result = new Response
            {
                  ReasonPhrase = ex.Message
                , StatusCode = (ex is NotImplementedException)
                    ? HttpStatusCode.NotImplemented
                    : (ex is UnauthorizedAccessException)
                        ? HttpStatusCode.Unauthorized
                        : (ex is ArgumentException || ex is NotProperRequestException)
                            ? HttpStatusCode.BadRequest
                            : HttpStatusCode.InternalServerError
            };

            return result;
        }*/
    }
}