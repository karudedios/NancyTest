using System;

namespace NancyTest.DAL.Extensions
{
    public class NotProperRequestException : Exception
    {
        public NotProperRequestException(string Message) : base(Message) { }
        public NotProperRequestException(string Message, Exception innerException) : base(Message, innerException) { }
    }
}