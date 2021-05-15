using AutoMapper;
using CompaniesOfferAPI.Util;
using CompaniesOfferAPI.Util.CustomException;
using CompaniesOfferAPI.Util.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CompaniesOfferAPI.Service
{
    public class CompanyServiceCharge : ICompanyServiceCharge
    {
        private readonly IMapper _mapper;
        public CompanyServiceCharge(IMapper mapper)
        {
            _mapper = mapper;
        }

        public RX2GoAPIResponse GetRX2GoServiceCharge(RX2APIRequest request)
        {
            var listOffers = CompanyConfiguration.LoadComapanies(CompanyName.RX2Go);

            var chargeRequest = _mapper.Map<ServiceChargeRequest>(request);

            var charge = GetServiceCharge(chargeRequest, listOffers);

            return new RX2GoAPIResponse
            {
                total = charge
            };
        }

        public FedXAPIResponse GetFedXServiceCharge(FedXAPIRequest request)
        {
            var listOffers = CompanyConfiguration.LoadComapanies(CompanyName.FedX);

            var chargeRequest = _mapper.Map<ServiceChargeRequest>(request);

            var charge = GetServiceCharge(chargeRequest, listOffers);

            return new FedXAPIResponse
            {
                amount = charge
            };
        }

        public PremierAPIResponse GetPremierServiceCharge(PremierAPIRequest request)
        {
            var listOffers = CompanyConfiguration.LoadComapanies(CompanyName.Premier);

            var chargeRequest = _mapper.Map<ServiceChargeRequest>(request);

            var charge = GetServiceCharge(chargeRequest, listOffers);

            return new PremierAPIResponse { quote = charge };
        }

        private decimal GetServiceCharge(ServiceChargeRequest request, List<CompanyInfo> companyInfos)
        {
            var findOffer = companyInfos.FirstOrDefault(a => a.Source == request.Source && a.Destination == request.Destination && a.Dimension.SequenceEqual(request.Carton));

            if (findOffer == null)
                throw new NoContentException("No data found for this request");

            return findOffer.Cost;
        }
    }
}
