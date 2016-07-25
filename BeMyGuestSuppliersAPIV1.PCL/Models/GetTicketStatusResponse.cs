/*
 * BeMyGuestSuppliersAPIV1.PCL
 *
 * This file was automatically generated for BeMyGuest by APIMATIC v2.0 ( https://apimatic.io ) on 07/25/2016
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

using BeMyGuestSuppliersAPIV1.PCL;

namespace BeMyGuestSuppliersAPIV1.PCL.Models
{
    public class GetTicketStatusResponse : BaseResponse 
    {
        // These fields hold the values for the public properties.
        private List<Ticket> date;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("date")]
        public List<Ticket> Date 
        { 
            get 
            {
                return this.date; 
            } 
            set 
            {
                this.date = value;
                onPropertyChanged("Date");
            }
        }
    }
} 