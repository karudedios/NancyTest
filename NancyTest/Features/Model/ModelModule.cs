using Nancy;
using Nancy.ModelBinding;
using NancyTest.DAL.Extensions;
using NancyTest.DAL.Implementation.Abstract;

namespace NancyTest.Features.Model
{
    public class ModelModule : NancyModule
    {
        public ModelModule(IProvider provider)
        {
            Get["/Add"] = parameters =>
                Negotiate
                    .WithView("Add");

            Put["/Add"]
                = parameters =>
                    Negotiate
                        .WithModel(provider.Add(this.Bind<DAL.Models.Model>()))
                        .AsJSON();
        }
    }
}