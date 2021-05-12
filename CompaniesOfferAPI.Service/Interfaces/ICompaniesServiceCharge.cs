using CompaniesOfferAPI.Util.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CompaniesOfferAPI.Service
{
    public interface ICompaniesServiceCharge
    {
        Task<RX2GoAPIResponse> GetRX2GoServiceCharge(RX2APIRequest request);
        Task<FedXAPIResponse> GetFedXServiceCharge(FedXAPIRequest request);
        Task<PremierAPIResponse> GetPremierServiceCharge(PremierAPIRequest request);
    }
}
