using CompaniesOfferAPI.Util.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CompaniesOfferAPI.Service
{
    public interface ICompaniesServiceCharge
    {
        RX2GoAPIResponse GetRX2GoServiceCharge(RX2APIRequest request);
        FedXAPIResponse GetFedXServiceCharge(FedXAPIRequest request);
        PremierAPIResponse GetPremierServiceCharge(PremierAPIRequest request);
    }
}
