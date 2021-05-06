﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace CompaniesOfferAPI.Common.Models
{
    public class API1Request
    {
        public string contactaddress { get; set; }
        public string warehouseaddress { get; set; }
        public int[] packagedimensions { get; set; }
    }

    public class API2Request
    {
        public string consignee { get; set; }
        public string consignor { get; set; }
        public int[] cartons { get; set; }
    }

    public class API3Request
    {
        public string source { get; set; }
        public string destination { get; set; }
        public string packages { get; set; }

        [IgnoreDataMember]
        public int[] packagedimensions {
            get => packages.Split(',').Select(n => int.Parse(n)).ToArray();
        }
    }

    public class OfferRequest
    {
        public string Source { get; set; }
        public string Destination { get; set; }
        public int[] Carton { get; set; }
    }
}
