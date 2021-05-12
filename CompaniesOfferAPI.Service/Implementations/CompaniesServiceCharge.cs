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

        public async Task<RX2GoAPIResponse> GetRX2GoServiceCharge(RX2APIRequest request)
        {
            var listOffers = CompanyConfiguration.LoadComapanies(CompanyName.RX2Go);

            var offer = new OfferRequest
            {
                Source = request.contactaddress,
                Destination = request.warehouseaddress,
                Carton = request.packagedimensions,
            };

            var charge = GetServiceCharge(offer, listOffers);

            return new RX2GoAPIResponse
            {
                total = charge
            };
        }

        public async Task<FedXAPIResponse> GetFedXServiceCharge(FedXAPIRequest request)
        {
            var listOffers = CompanyConfiguration.LoadComapanies(CompanyName.FedX);

            var offer = new OfferRequest
            {
                Source = request.consignee,
                Destination = request.consignor,
                Carton = request.cartons,
            };

            var charge = GetServiceCharge(offer, listOffers);

            return new FedXAPIResponse
            {
                amount = charge
            };
        }

        public async Task<PremierAPIResponse> GetPremierServiceCharge(PremierAPIRequest request)
        {
            var listOffers = CompanyConfiguration.LoadComapanies(CompanyName.Premier);

            var offer = new OfferRequest
            {
                Source = request.source,
                Destination = request.destination,
                Carton = request.packagedimensions,
            };

            var charge = GetServiceCharge(offer, listOffers);

            return new PremierAPIResponse { quote = charge };
        }

        private decimal GetServiceCharge(OfferRequest request, List<CompanyInfo> companyInfos)
        {
            var findOffer = companyInfos.Where(a => a.Source == request.Source && a.Destination == request.Destination && a.Diamention.SequenceEqual(request.Carton)).FirstOrDefault();

            if (findOffer == null)
                findOffer = companyInfos.Where(a => a.Source == string.Empty && a.Destination == string.Empty).FirstOrDefault();

            return findOffer.Cost;
        }
    }
}
