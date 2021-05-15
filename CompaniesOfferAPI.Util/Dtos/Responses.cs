using System;
using System.Collections.Generic;
using System.Text;

namespace CompaniesOfferAPI.Util.Dtos
{
    public class RX2GoAPIResponse
    {
        public decimal Total { get; set; }
    }

    public class FedXAPIResponse
    {
        public decimal Amount { get; set; }
    }

    public class PremierAPIResponse
    {
        public decimal Quote { get; set; }
    }
}
