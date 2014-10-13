using Nancy.ModelBinding;
using NancyTest.DAL.Extensions;
using NancyTest.DAL.Implementation.Abstract;
using NancyTest.DAL.Models;
using System.Collections.Generic;
using System.Linq;

namespace NancyTest.Search
{
    using Nancy;

    public class SearchModule : NancyModule
    {
        private readonly IEnumerable<Model> _values;

        public SearchModule(IProvider provider)
        {
            _values = provider.GetAll();

            Get["/Search/{name?}"] = parameters =>
                Negotiate
                    .WithView("Search")
                    .WithModel((string)parameters.name);


              Get["/GetByName/{name}/{resultType?}"]
            = Get["/GetByName/{name?}/"] = parameters =>
                Negotiate
                    .AsResponseType((string) parameters.resultType ?? ResponseType.JSON)
                    .WithModel(_values.Search((string) parameters.name).ToArray());
        }
    }
}