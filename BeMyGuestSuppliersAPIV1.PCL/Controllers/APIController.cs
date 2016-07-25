/*
 * BeMyGuestSuppliersAPIV1.PCL
 *
 * This file was automatically generated for BeMyGuest by APIMATIC v2.0 ( https://apimatic.io ) on 07/25/2016
 */
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeMyGuestSuppliersAPIV1.PCL;
using BeMyGuestSuppliersAPIV1.PCL.Http.Request;
using BeMyGuestSuppliersAPIV1.PCL.Http.Response;
using BeMyGuestSuppliersAPIV1.PCL.Http.Client;
using BeMyGuestSuppliersAPIV1.PCL.Models;

namespace BeMyGuestSuppliersAPIV1.PCL.Controllers
{
    public partial class APIController: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static APIController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static APIController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new APIController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// A Config object has the following attributes:
        /// + `timezone` - Our sever timezone
        /// + `now` - Our server timestamp
        /// + `version` - Current version is "1.0"
        /// + `serverUrl` - Main API URL
        /// + user - All important userdata for provided API key
        ///     + `name` - Name / Company / Organization
        ///     + `email` - E-Mail Address
        ///     + `uuid` - Unique ID
        ///     + `defaultPagination` - Default Pagination value (per page), between 1-100
        ///     + `defaultCurrencyUuid` - Default currency UUID for /products (if not specified)
        ///     + `defaultCurrencyCode` - Default currency code for /products (if not specified)
        ///     + `defaultLanguageUuid` - Default language UUID  /products (if not specified)
        ///     + `defaultLanguageCode` - Default language code  /products (if not specified)
        /// + `products` - A list of supplier products
        ///     + `productTypes` - A list of prodcut types bellonging to this product
        /// + `languages` - A list of supported languages.
        /// + `currencies` - An array of supported currencies.
        /// + `barcodeTypes` - An array of supported barcode types.
        /// </summary>
        /// <return>Returns the RetrieveConfigResponse response from the API call</return>
        public RetrieveConfigResponse RetrieveConfig()
        {
            Task<RetrieveConfigResponse> t = RetrieveConfigAsync();
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// A Config object has the following attributes:
        /// + `timezone` - Our sever timezone
        /// + `now` - Our server timestamp
        /// + `version` - Current version is "1.0"
        /// + `serverUrl` - Main API URL
        /// + user - All important userdata for provided API key
        ///     + `name` - Name / Company / Organization
        ///     + `email` - E-Mail Address
        ///     + `uuid` - Unique ID
        ///     + `defaultPagination` - Default Pagination value (per page), between 1-100
        ///     + `defaultCurrencyUuid` - Default currency UUID for /products (if not specified)
        ///     + `defaultCurrencyCode` - Default currency code for /products (if not specified)
        ///     + `defaultLanguageUuid` - Default language UUID  /products (if not specified)
        ///     + `defaultLanguageCode` - Default language code  /products (if not specified)
        /// + `products` - A list of supplier products
        ///     + `productTypes` - A list of prodcut types bellonging to this product
        /// + `languages` - A list of supported languages.
        /// + `currencies` - An array of supported currencies.
        /// + `barcodeTypes` - An array of supported barcode types.
        /// </summary>
        /// <return>Returns the RetrieveConfigResponse response from the API call</return>
        public async Task<RetrieveConfigResponse> RetrieveConfigAsync()
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/v1/suppliers/config");


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "BeMyGuest.Suppliers.SDK.v1" },
                { "accept", "application/json" }
            };
            _headers.Add("X-Authorization", Configuration.XAuthorization);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<RetrieveConfigResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// ## Add Tickets BatchPlease remember that with all update tickets status requests you need to providea proper Content-Type header.`Content-Type: application/json`Example JSON request:        {          "ticketsBatchName" : "1 DAY ADULT TAB 6M (PEAK)",          "ticketsBatchReference" : "USS1DADTAB6MA0210004",          "ticketsOrderReference" : "1609871",          "ticketsOrderDate" : "2016-01-12",          "ticketsPerPerson" : 1,          "productTypesUuid": [            "3016c3cf-d483-5e81-ad55-ba362670e2e2"          ],          "currencyUuid": "0a1f8d35-3b6f-54ac-8421-131f340b6334",          "barcodeTypeUuid": "a87e1e6f-c4f0-5655-b0b6-05e066bdb51b",          "adultsAllowed" : true,          "childrenAllowed" : true,          "seniorsAllowed" : true,          "validFrom" : "2016-01-15",          "validTo" : "2016-06-15",          "pricePerTicket" : 67.00,          "tickets": [            {              "value" : "100040100100005022",              "status" : "unused"            },            {              "value" : "100040100100005023",              "status" : "unused"            },            {              "value" : "100040100100005024",              "status" : "unused"            }          ]        }A response object has the following attributes:+ `ticketsBatchName` - name of the inserted ticket batch+ `ticketsBatchReference` - reference of the inserted ticket batch+ `ticketsOrderReference` - tickets order reference+ `ticketsOrderDate` - date - tickets order date+ `ticketsPerPerson` - integer+ `productTypesUuid` - array - all attached product types to this batch+ `currencyUuid` - string+ `barcodeTypeUuid` - string+ `adultsAllowed` - bool - batch validity for adults bookings - true|false+ `childrenAllowed` - bool - batch validity for children bookings - true|false+ `validFrom` - string - valid from date for the batch+ `validTo` - string - valid to date for the batch+ `pricePerTicket` - number - price per ticket+ `tickets` - array - list of all tickets that have been added to the batch with their number and statusesExample JSON response:        {          "data": {            "ticketsBatchName": "1 DAY ADULT TAB 6M (PEAK)",            "ticketsBatchReference": "USS1DADTAB6MA0210004",            "ticketsOrderReference": "1609871",            "ticketsOrderDate": "2016-01-12",            "ticketsPerPerson": 1,            "productTypesUuid": [              "3016c3cf-d483-5e81-ad55-ba362670e2e2"            ],            "currencyUuid": "0a1f8d35-3b6f-54ac-8421-131f340b6334",            "barcodeTypeUuid": "a87e1e6f-c4f0-5655-b0b6-05e066bdb51b",            "adultsAllowed": true,            "childrenAllowed": true,            "validFrom": "2016-01-15",            "validTo": "2016-06-15",            "pricePerTicket": 67,            "tickets": {              "data": [                {                  "value": "100040100100005022",                  "status": "unused",                  "usedAt": null                },                {                  "value": "100040100100005023",                  "status": "unused",                  "usedAt": null                },                {                  "value": "100040100100005024",                  "status": "unused",                  "usedAt": null                }              ]            }          }        }## Update Tickets StatusPlease remember that with all update tickets status requests you need to providea proper Content-Type header.`Content-Type: application/json`Example JSON request:        {          "data": [            {              "value" : "100040100100005022",              "status" : "used"            },           {              "value" : "0041018110401587837",                "status" : "unused"            }          ]        }A response object has the following attributes:+ `value` - value of ticket number+ `status` - unused / used / invalid - status of the ticket after the update+ `usedAt` - null / dateExample JSON response:        {          "data": [            {              "value": "100040100100005022",              "status": "used",              "usedAt": "2016-07-25 11:47:23"            },            {              "value": "0041018110401587837",              "status": "unused",              "usedAt": null            }          ]        }
        /// </summary>
        /// <param name="data">Required parameter: Example: </param>
        /// <return>Returns the AddTicketsBatchResponse response from the API call</return>
        public AddTicketsBatchResponse AddTicketsBatch(AddTicketsBatchRequest data)
        {
            Task<AddTicketsBatchResponse> t = AddTicketsBatchAsync(data);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// ## Add Tickets BatchPlease remember that with all update tickets status requests you need to providea proper Content-Type header.`Content-Type: application/json`Example JSON request:        {          "ticketsBatchName" : "1 DAY ADULT TAB 6M (PEAK)",          "ticketsBatchReference" : "USS1DADTAB6MA0210004",          "ticketsOrderReference" : "1609871",          "ticketsOrderDate" : "2016-01-12",          "ticketsPerPerson" : 1,          "productTypesUuid": [            "3016c3cf-d483-5e81-ad55-ba362670e2e2"          ],          "currencyUuid": "0a1f8d35-3b6f-54ac-8421-131f340b6334",          "barcodeTypeUuid": "a87e1e6f-c4f0-5655-b0b6-05e066bdb51b",          "adultsAllowed" : true,          "childrenAllowed" : true,          "seniorsAllowed" : true,          "validFrom" : "2016-01-15",          "validTo" : "2016-06-15",          "pricePerTicket" : 67.00,          "tickets": [            {              "value" : "100040100100005022",              "status" : "unused"            },            {              "value" : "100040100100005023",              "status" : "unused"            },            {              "value" : "100040100100005024",              "status" : "unused"            }          ]        }A response object has the following attributes:+ `ticketsBatchName` - name of the inserted ticket batch+ `ticketsBatchReference` - reference of the inserted ticket batch+ `ticketsOrderReference` - tickets order reference+ `ticketsOrderDate` - date - tickets order date+ `ticketsPerPerson` - integer+ `productTypesUuid` - array - all attached product types to this batch+ `currencyUuid` - string+ `barcodeTypeUuid` - string+ `adultsAllowed` - bool - batch validity for adults bookings - true|false+ `childrenAllowed` - bool - batch validity for children bookings - true|false+ `validFrom` - string - valid from date for the batch+ `validTo` - string - valid to date for the batch+ `pricePerTicket` - number - price per ticket+ `tickets` - array - list of all tickets that have been added to the batch with their number and statusesExample JSON response:        {          "data": {            "ticketsBatchName": "1 DAY ADULT TAB 6M (PEAK)",            "ticketsBatchReference": "USS1DADTAB6MA0210004",            "ticketsOrderReference": "1609871",            "ticketsOrderDate": "2016-01-12",            "ticketsPerPerson": 1,            "productTypesUuid": [              "3016c3cf-d483-5e81-ad55-ba362670e2e2"            ],            "currencyUuid": "0a1f8d35-3b6f-54ac-8421-131f340b6334",            "barcodeTypeUuid": "a87e1e6f-c4f0-5655-b0b6-05e066bdb51b",            "adultsAllowed": true,            "childrenAllowed": true,            "validFrom": "2016-01-15",            "validTo": "2016-06-15",            "pricePerTicket": 67,            "tickets": {              "data": [                {                  "value": "100040100100005022",                  "status": "unused",                  "usedAt": null                },                {                  "value": "100040100100005023",                  "status": "unused",                  "usedAt": null                },                {                  "value": "100040100100005024",                  "status": "unused",                  "usedAt": null                }              ]            }          }        }## Update Tickets StatusPlease remember that with all update tickets status requests you need to providea proper Content-Type header.`Content-Type: application/json`Example JSON request:        {          "data": [            {              "value" : "100040100100005022",              "status" : "used"            },           {              "value" : "0041018110401587837",                "status" : "unused"            }          ]        }A response object has the following attributes:+ `value` - value of ticket number+ `status` - unused / used / invalid - status of the ticket after the update+ `usedAt` - null / dateExample JSON response:        {          "data": [            {              "value": "100040100100005022",              "status": "used",              "usedAt": "2016-07-25 11:47:23"            },            {              "value": "0041018110401587837",              "status": "unused",              "usedAt": null            }          ]        }
        /// </summary>
        /// <param name="data">Required parameter: Example: </param>
        /// <return>Returns the AddTicketsBatchResponse response from the API call</return>
        public async Task<AddTicketsBatchResponse> AddTicketsBatchAsync(AddTicketsBatchRequest data)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/v1/suppliers/tickets");


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "BeMyGuest.Suppliers.SDK.v1" },
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" }
            };
            _headers.Add("X-Authorization", Configuration.XAuthorization);

            //append body params
            var _body = APIHelper.JsonSerialize(data);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.PostBody(_queryUrl, _headers, _body);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<AddTicketsBatchResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Update statuses for all the provided tickets
        /// </summary>
        /// <param name="data">Required parameter: Example: </param>
        /// <return>Returns the UpdateTicketsStatusResponse response from the API call</return>
        public UpdateTicketsStatusResponse UpdateTicketsStatus(UpdateTicketsStatusRequest data)
        {
            Task<UpdateTicketsStatusResponse> t = UpdateTicketsStatusAsync(data);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// Update statuses for all the provided tickets
        /// </summary>
        /// <param name="data">Required parameter: Example: </param>
        /// <return>Returns the UpdateTicketsStatusResponse response from the API call</return>
        public async Task<UpdateTicketsStatusResponse> UpdateTicketsStatusAsync(UpdateTicketsStatusRequest data)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/v1/suppliers/tickets");


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "BeMyGuest.Suppliers.SDK.v1" },
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" }
            };
            _headers.Add("X-Authorization", Configuration.XAuthorization);

            //append body params
            var _body = APIHelper.JsonSerialize(data);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.PutBody(_queryUrl, _headers, _body);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<UpdateTicketsStatusResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Get status for specific ticket number.##ResponseA response object has the following attributes:+ `value` - value of ticket number+ `status` - unused / used / invalid - current status of the ticket+ `usedAt` - null / date
        /// </summary>
        /// <param name="ticketNumber">Required parameter: Example: </param>
        /// <return>Returns the GetTicketStatusResponse response from the API call</return>
        public GetTicketStatusResponse GetTicketStatus(string ticketNumber)
        {
            Task<GetTicketStatusResponse> t = GetTicketStatusAsync(ticketNumber);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// Get status for specific ticket number.##ResponseA response object has the following attributes:+ `value` - value of ticket number+ `status` - unused / used / invalid - current status of the ticket+ `usedAt` - null / date
        /// </summary>
        /// <param name="ticketNumber">Required parameter: Example: </param>
        /// <return>Returns the GetTicketStatusResponse response from the API call</return>
        public async Task<GetTicketStatusResponse> GetTicketStatusAsync(string ticketNumber)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/v1/suppliers/tickets/{ticket_number}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "ticket_number", ticketNumber }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "BeMyGuest.Suppliers.SDK.v1" },
                { "accept", "application/json" }
            };
            _headers.Add("X-Authorization", Configuration.XAuthorization);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<GetTicketStatusResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

    }
} 