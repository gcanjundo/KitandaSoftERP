using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Domain.Shared.ValueObject
{
    public class Address
    {
        public string BuildingNumber { get; set; }
        public string StreetName { get; set; }
        public string AddressDetail { get; set; } 
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Province { get; set; }
        public string  Country { get; set; }

    }
}
