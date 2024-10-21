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
            var serviceChargeList = CompanyConfiguration.LoadServiceChargeData(CompanyName.RX2Go);

            var chargeRequest = _mapper.Map<ServiceChargeRequest>(request);

            var charge = GetServiceCharge(chargeRequest, serviceChargeList);

            return new RX2GoAPIResponse
            {
                Total = charge
            };
        }

        public FedXAPIResponse GetFedXServiceCharge(FedXAPIRequest request)
        {
            var serviceChargeList = CompanyConfiguration.LoadServiceChargeData(CompanyName.FedX);

            var chargeRequest = _mapper.Map<ServiceChargeRequest>(request);

            var charge = GetServiceCharge(chargeRequest, serviceChargeList);

            var res = new FedXAPIResponse
            {
                Amount = charge
            };

            return  res;
        }

        public PremierAPIResponse GetPremierServiceCharge(PremierAPIRequest request)
        {
            var serviceChargeList = CompanyConfiguration.LoadServiceChargeData(CompanyName.Premier);

            var chargeRequest = _mapper.Map<ServiceChargeRequest>(request);

            var charge = GetServiceCharge(chargeRequest, serviceChargeList);

            return new PremierAPIResponse { Quote = charge };
        }

        private decimal GetServiceCharge(ServiceChargeRequest request, List<ServiceChargeDetails> serviceCharge)
        {
            var findOffer = serviceCharge.FirstOrDefault(a => a.Source == request.Source && a.Destination == request.Destination && a.Dimension.SequenceEqual(request.Carton));

            if (findOffer == null)
                throw new NoContentException("No data found for this request");

            return findOffer.Cost;
        }
    }
}
