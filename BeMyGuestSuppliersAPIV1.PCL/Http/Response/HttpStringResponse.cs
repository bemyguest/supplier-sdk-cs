using System;
using System.Collections.Generic;

namespace BeMyGuestSuppliersAPIV1.PCL.Http.Response
{
    public class HttpStringResponse : HttpResponse
    {
        /// <summary>
        /// Raw string body of the http response
        /// </summary>
        public string Body { get; set; }
    }
}
