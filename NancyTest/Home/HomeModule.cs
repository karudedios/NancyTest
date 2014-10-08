using Nancy.ModelBinding;
using NancyTest.DAL.Extensions;
using NancyTest.DAL.Models;
using System.Collections.Generic;

namespace NancyTest
{
    using Nancy;

    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = Get["/Home"] = Get["/Home/{name?}"] = parameters =>
                Negotiate
                    .WithStatusCode(HttpStatusCode.OK)
                    .WithView("index")
                    .WithModel(new { Name = parameters.name.Value ?? "Guest" });

            Get["/Home/RedirectToSearch"] = x => Response.AsRedirect("/Search/");
        }
    }
}