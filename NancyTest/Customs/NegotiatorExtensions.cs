using Nancy;
using Nancy.Extensions;
using Nancy.Responses.Negotiation;

namespace NancyTest.DAL.Extensions
{
    public static class NegotiatorExtensions
    {
        public static Negotiator WithAjaxRequest(this Negotiator self, Request request)
        {
            var keepGoing = (request.IsAjaxRequest());
            if (keepGoing) return self;

            if (keepGoing)
                throw new NotProperRequestException("Full Postback request expected");
            throw  new NotProperRequestException("Ajax Request expected");
        }

        public static Negotiator AsResponseType(this Negotiator self, string type)
        {
            return type == ResponseType.JSON
                ? self.AsJSON()
                : (type == ResponseType.XML
                    ? self.AsXML()
                    : self
                );
        }

        public static Negotiator AsJSON(this Negotiator self)
        {
            return self
                .WithAllowedMediaRange(MediaRange.FromString("application/json"))
                .WithContentType("application/json");
        }

        public static Negotiator AsXML(this Negotiator self)
        {
            return self
                .WithAllowedMediaRange(MediaRange.FromString("application/xml"))
                .WithContentType("application/xml");
        }
    }

    public static class ResponseType
    {
        public static string Empty = "empty";
        public static string JSON = "json";
        public static string XML = "xml";
    }
}