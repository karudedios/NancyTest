using Nancy.ModelBinding;
using NancyTest.DAL.Extensions;
using NancyTest.DAL.Models;
using System.Collections.Generic;

namespace NancyTest
{
    using Nancy;

    public class IndexModule : NancyModule
    {
        public IndexModule()
        {
            Get["/"] = Get["/Home"] = Get["/Home/{name?}"] = parameters =>
                Negotiate
                    .WithStatusCode(HttpStatusCode.OK)
                    .WithView("index")
                    .WithModel(new { Name = parameters.name.Value ?? "Guest" });

            Put["/"] = _params =>
               this.Bind<List<tempModel>>().Count == 0 ? new { Message = "Failure", Status = 0 } : new { Message = "Successful", Status = 1 };
        }
    }

    public class tempModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
    }
}