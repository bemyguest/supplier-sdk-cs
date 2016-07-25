/*
 * BeMyGuestSuppliersAPIV1.PCL
 *
 * This file was automatically generated for BeMyGuest by APIMATIC v2.0 ( https://apimatic.io ) on 07/25/2016
 */
using System;
using BeMyGuestSuppliersAPIV1.PCL.Controllers;
using BeMyGuestSuppliersAPIV1.PCL.Http.Client;

namespace BeMyGuestSuppliersAPIV1.PCL
{
    public partial class BeMyGuestSuppliersAPIV1Client
    {

        /// <summary>
        /// Singleton access to Client controller
        /// </summary>
        public APIController Client
        {
            get
            {
                return APIController.Instance;
            }
        }

        /// <summary>
        /// The shared http client to use for all API calls
        /// </summary>
        public IHttpClient SharedHttpClient
        {
            get
            {
                return BaseController.ClientInstance;
            }
            set
            {
                BaseController.ClientInstance = value;
            }        
        }
        
        /// <summary>
        /// Default constructor
        /// </summary>
        public BeMyGuestSuppliersAPIV1Client() { }

        /// <summary>
        /// Client initialization constructor
        /// </summary>
        public BeMyGuestSuppliersAPIV1Client(string xAuthorization)
        {
            Configuration.XAuthorization = xAuthorization;
        }
    }
}