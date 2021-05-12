using AutoMapper;
using CompaniesOfferAPI.Util;
using CompaniesOfferAPI.Util.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompaniesOfferAPI.Service
{
    public class CompaniesServiceCharge : ICompaniesServiceCharge
    {
        private readonly IMapper _mapper;
        public CompaniesServiceCharge(IMapper mapper)
        {
            _mapper = mapper;
        }

        public RX2GoAPIResponse GetRX2GoServiceCharge(RX2APIRequest request)
        {
            var listOffers = CompanyConfiguration.LoadComapanies(CompanyName.RX2Go);

            var chargeRequest = _mapper.Map<ServiceChargeRequest>(request);

            //var chargeRequest = new ServiceChargeRequest
            //{
            //    Source = request.contactaddress,
            //    Destination = request.warehouseaddress,
            //    Carton = request.packagedimensions,
            //};

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

            //var chargeRequest = new ServiceChargeRequest
            //{
            //    Source = request.consignee,
            //    Destination = request.consignor,
            //    Carton = request.cartons,
            //};

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

            //var chargeRequest = new ServiceChargeRequest
            //{
            //    Source = request.source,
            //    Destination = request.destination,
            //    Carton = request.packagedimensions,
            //};

            var charge = GetServiceCharge(chargeRequest, listOffers);

            return new PremierAPIResponse { quote = charge };
        }

        private decimal GetServiceCharge(ServiceChargeRequest request, List<CompanyInfo> companyInfos)
        {
            var findOffer = companyInfos.Where(a => a.Source == request.Source && a.Destination == request.Destination && a.Diamention.SequenceEqual(request.Carton)).FirstOrDefault();

            if (findOffer == null)
                findOffer = companyInfos.Where(a => a.Source == string.Empty && a.Destination == string.Empty).FirstOrDefault();

            return findOffer.Cost;
        }
    }
}
