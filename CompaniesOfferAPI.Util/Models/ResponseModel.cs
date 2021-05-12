using System;
using System.Collections.Generic;
using System.Text;

namespace CompaniesOfferAPI.Util.Models
{
    public class RX2GoAPIResponse
    {
        public decimal total { get; set; }
    }

    public class FedXAPIResponse
    {
        public decimal amount { get; set; }
    }

    public class PremierAPIResponse
    {
        public decimal quote { get; set; }
    }
}
