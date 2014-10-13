using Nancy;

namespace NancyTest.Customs
{
    public static class NancyHttpStatusCodeExtension
    {
        public static bool IsError(this HttpStatusCode self)
        {
            return ((int) self) > 400 && ((int) self) < 599;
        }
    }
}