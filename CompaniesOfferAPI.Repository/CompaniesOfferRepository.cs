using CompaniesOfferAPI.Common;
using CompaniesOfferAPI.Common.Models;
using CompaniesOfferAPI.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompaniesOfferAPI.Repository
{
    public class CompaniesOfferRepository : ICompaniesOfferRepository
    {
        public CompaniesOfferRepository()
        {

        }

        /// <summary>
        /// Sample Company Name = RX2Go
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<decimal> GetRX2GoOffer(OfferRequest request)
        {
            var listOffers = CompanyConfiguration.LoadComapanies(CompanyName.RX2Go);
            var cost = await GetCost(request, listOffers);

            return await Task.FromResult(cost);
        }

        /// <summary>
        /// Sample Company Name = FedX
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<decimal> GetFedXOffer(OfferRequest request)
        {
            var listOffers = CompanyConfiguration.LoadComapanies(CompanyName.FedX);
            var cost = await GetCost(request, listOffers);

            return await Task.FromResult(cost);
        }

        /// <summary>
        /// Sample Company Name = Premier
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<decimal> GetPremierOffer(OfferRequest request)
        {
            var listOffers = CompanyConfiguration.LoadComapanies(CompanyName.Premier);
            var cost = await GetCost(request, listOffers);

            return await Task.FromResult(cost);
        }

        private async Task<decimal> GetCost(OfferRequest request, List<CompanyInfo> companyInfos)
        {
            var findOffer = companyInfos.Where(a => a.Source == request.Source && a.Destination == request.Destination && a.Diamention.SequenceEqual(request.Carton)).FirstOrDefault();

            if (findOffer == null)
                findOffer = companyInfos.Where(a => a.Source == string.Empty && a.Destination == string.Empty).FirstOrDefault();

            return await Task.FromResult(findOffer.Cost);
        }
    }
}
