using CompaniesOfferAPI.Util.Dtos;

namespace CompaniesOfferAPI.Service
{
    public interface ICompanyServiceCharge
    {
        RX2GoAPIResponse GetRX2GoServiceCharge(RX2APIRequest request);
        FedXAPIResponse GetFedXServiceCharge(FedXAPIRequest request);
        PremierAPIResponse GetPremierServiceCharge(PremierAPIRequest request);
    }
}
