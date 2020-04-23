using Newtonsoft.Json;
using System;
using System.Net.Http;

namespace PetOwner.Infrastructure.WebAccess
{
    class WebApiException : Exception
    {
        public HttpResponseMessage Response { get; set; }
        public object RequestObjectContent { get; set; }

        public WebApiException(HttpResponseMessage response, object requestObjectContent = null)
        {
            Response = response;
            RequestObjectContent = requestObjectContent;
        }

        public override string ToString()
        {
            return
                $"StatusCode: {Response.StatusCode}" + Environment.NewLine +
                $"ReasonPhrase: {Response.ReasonPhrase}" + Environment.NewLine +
                $"RequestUri: {Response.RequestMessage.RequestUri}" + Environment.NewLine +
                $"RequestObjectContent: {JsonConvert.SerializeObject(RequestObjectContent)}" + Environment.NewLine +
                $"Exception Details: {base.ToString()} ";
        }
    }
}
