using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Data.Entity;

namespace AdWorks
{
    class Address
    {
        public int AddressId { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public StateProvince StateProvinceId { get; set; }
        public string PostalCode { get; set; }
        public Point MyProperty { get; set; }
        public string Rowguid { get; set; }
        public DateTime Datum { get; set; }


    }
}
