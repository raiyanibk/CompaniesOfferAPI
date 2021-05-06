using CompaniesOfferAPI.Business.Interface;
using CompaniesOfferAPI.Common.Models;
using CompaniesOfferAPI.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CompaniesOfferAPI.Business
{
    public class CompaniesOfferService : ICompaniesOfferService
    {
        private readonly ICompaniesOfferRepository _companiesOfferRepository;
        public CompaniesOfferService(ICompaniesOfferRepository companiesOfferRepository)
        {
            _companiesOfferRepository = companiesOfferRepository;
        }

        public async Task<decimal> GetRX2GoOffer(OfferRequest request)
        {
            return await _companiesOfferRepository.GetRX2GoOffer(request);
        }

       
        public async Task<decimal> GetFedXOffer(OfferRequest request)
        {
            return await _companiesOfferRepository.GetFedXOffer(request);
        }

       
        public async Task<decimal> GetPremierOffer(OfferRequest request)
        {
            return await _companiesOfferRepository.GetPremierOffer(request);
        }
    }
}
