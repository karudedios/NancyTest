using System.Configuration;
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
        protected override void ApplicationStartup(TinyIoCContainer container, IPipelines pipelines)
        {
            CustomStatusCode.AddCode (
                    Properties.Settings.Default.ErrorCodes
                    .Split(',')
                    .Select(int.Parse)
                );

            CustomStatusCode.AllowIISErrors = true;
            base.ApplicationStartup(container, pipelines);
            container.Register<IProvider>(new Provider());

            Conventions.ViewLocationConventions.Clear();
            Conventions.ViewLocationConventions.Add((viewName, model, context) => string.Concat("Layout/", viewName));
            Conventions.ViewLocationConventions.Add((viewName, model, context) => string.Concat("Features/Errors/", viewName));
            Conventions.ViewLocationConventions.Add((viewName, model, context) => string.Concat("Features/" + context.ModuleName, "/", viewName));
        }
    }
}