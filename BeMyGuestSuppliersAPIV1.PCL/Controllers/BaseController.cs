/*
 * BeMyGuestSuppliersAPIV1.PCL
 *
 * This file was automatically generated for BeMyGuest by APIMATIC v2.0 ( https://apimatic.io ) on 07/25/2016
 */
using System;
using BeMyGuestSuppliersAPIV1.PCL;
using BeMyGuestSuppliersAPIV1.PCL.Http.Client;
using BeMyGuestSuppliersAPIV1.PCL.Http.Response;

namespace BeMyGuestSuppliersAPIV1.PCL.Controllers
{
    public partial class BaseController
    {
        #region shared http client instance
        private static object syncObject = new object();
        private static IHttpClient clientInstance = null;

        public static IHttpClient ClientInstance
        {
            get
            {
                lock(syncObject)
                {
                    if(null == clientInstance)
                    {
                        clientInstance = new UnirestClient();
                    }
                    return clientInstance;
                }
            }
            set
            {
                lock (syncObject)
                {
                    if (value is IHttpClient)
                    {
                        clientInstance = value;
                    }
                }
            }
        }
        #endregion shared http client instance

        /// <summary>
        /// Validates the response against HTTP errors defined at the API level
        /// </summary>
        /// <param name="_response">The response recieved</param>
        /// <param name="_context">Context of the request and the recieved response</param>
        internal void ValidateResponse(HttpResponse _response, HttpContext _context)
        {
            if (_response.StatusCode == 400)
                throw new APIException(@"Wrong Arguments", _context);

            else if (_response.StatusCode == 401)
                throw new APIException(@"Unauthorized", _context);

            else if (_response.StatusCode == 403)
                throw new APIException(@"Forbidden", _context);

            else if (_response.StatusCode == 404)
                throw new APIException(@"Resource Not Found", _context);

            else if (_response.StatusCode == 405)
                throw new APIException(@"Method Not Allowed", _context);

            else if (_response.StatusCode == 410)
                throw new APIException(@"Resource No Longer Available", _context);

            else if ((_response.StatusCode < 200) || (_response.StatusCode > 206)) //[200,206] = HTTP OK
                throw new APIException(@"HTTP Response Not OK", _context);
        }
    }
} 