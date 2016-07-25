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
    public class TicketsBatch : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private bool adultsAllowed;
        private Guid barcodeTypeUuid;
        private bool childrenAllowed;
        private Guid currencyUuid;
        private int pricePerTicket;
        private Guid productTypesUuid;
        private List<Ticket> tickets;
        private string ticketsBatchName;
        private string ticketsBatchReference;
        private string ticketsOrderDate;
        private int ticketsPerPerson;
        private string validFrom;
        private string validTo;
        private string ticketsOrderReference;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("adultsAllowed")]
        public bool AdultsAllowed 
        { 
            get 
            {
                return this.adultsAllowed; 
            } 
            set 
            {
                this.adultsAllowed = value;
                onPropertyChanged("AdultsAllowed");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("barcodeTypeUuid")]
        public Guid BarcodeTypeUuid 
        { 
            get 
            {
                return this.barcodeTypeUuid; 
            } 
            set 
            {
                this.barcodeTypeUuid = value;
                onPropertyChanged("BarcodeTypeUuid");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("childrenAllowed")]
        public bool ChildrenAllowed 
        { 
            get 
            {
                return this.childrenAllowed; 
            } 
            set 
            {
                this.childrenAllowed = value;
                onPropertyChanged("ChildrenAllowed");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("currencyUuid")]
        public Guid CurrencyUuid 
        { 
            get 
            {
                return this.currencyUuid; 
            } 
            set 
            {
                this.currencyUuid = value;
                onPropertyChanged("CurrencyUuid");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("pricePerTicket")]
        public int PricePerTicket 
        { 
            get 
            {
                return this.pricePerTicket; 
            } 
            set 
            {
                this.pricePerTicket = value;
                onPropertyChanged("PricePerTicket");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("productTypesUuid")]
        public Guid ProductTypesUuid 
        { 
            get 
            {
                return this.productTypesUuid; 
            } 
            set 
            {
                this.productTypesUuid = value;
                onPropertyChanged("ProductTypesUuid");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("tickets")]
        public List<Ticket> Tickets 
        { 
            get 
            {
                return this.tickets; 
            } 
            set 
            {
                this.tickets = value;
                onPropertyChanged("Tickets");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("ticketsBatchName")]
        public string TicketsBatchName 
        { 
            get 
            {
                return this.ticketsBatchName; 
            } 
            set 
            {
                this.ticketsBatchName = value;
                onPropertyChanged("TicketsBatchName");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("ticketsBatchReference")]
        public string TicketsBatchReference 
        { 
            get 
            {
                return this.ticketsBatchReference; 
            } 
            set 
            {
                this.ticketsBatchReference = value;
                onPropertyChanged("TicketsBatchReference");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("ticketsOrderDate")]
        public string TicketsOrderDate 
        { 
            get 
            {
                return this.ticketsOrderDate; 
            } 
            set 
            {
                this.ticketsOrderDate = value;
                onPropertyChanged("TicketsOrderDate");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("ticketsPerPerson")]
        public int TicketsPerPerson 
        { 
            get 
            {
                return this.ticketsPerPerson; 
            } 
            set 
            {
                this.ticketsPerPerson = value;
                onPropertyChanged("TicketsPerPerson");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("validFrom")]
        public string ValidFrom 
        { 
            get 
            {
                return this.validFrom; 
            } 
            set 
            {
                this.validFrom = value;
                onPropertyChanged("ValidFrom");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("validTo")]
        public string ValidTo 
        { 
            get 
            {
                return this.validTo; 
            } 
            set 
            {
                this.validTo = value;
                onPropertyChanged("ValidTo");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("ticketsOrderReference")]
        public string TicketsOrderReference 
        { 
            get 
            {
                return this.ticketsOrderReference; 
            } 
            set 
            {
                this.ticketsOrderReference = value;
                onPropertyChanged("TicketsOrderReference");
            }
        }

        /// <summary>
        /// Property changed event for observer pattern
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Raises event when a property is changed
        /// </summary>
        /// <param name="propertyName">Name of the changed property</param>
        protected void onPropertyChanged(String propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
} 