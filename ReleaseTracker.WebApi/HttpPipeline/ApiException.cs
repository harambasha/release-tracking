using System;
using System.Net;

namespace ReleaseTracker.WebApi.HttpPipeline
{
    [Serializable]
    public class ApiException : Exception
    {
        private readonly HttpStatusCode _statusCode;

        public ApiException(string message)
            : this(HttpStatusCode.InternalServerError, message)
        {
        }

        public ApiException(HttpStatusCode statusCode)
            : this(statusCode, statusCode.ToString())
        {
        }

        public ApiException(HttpStatusCode statusCode, string message)
            : base(message)
        {
            _statusCode = statusCode;
        }

        public HttpStatusCode StatusCode
        {
            get { return _statusCode; }
        }
    }
}