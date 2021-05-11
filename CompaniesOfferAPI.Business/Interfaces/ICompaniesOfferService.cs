using CompaniesOfferAPI.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CompaniesOfferAPI.Business.Interface
{
    public interface ICompaniesOfferService
    {
        Task<decimal> GetRX2GoOffer(OfferRequest request);
        Task<decimal> GetFedXOffer(OfferRequest request);
        Task<decimal> GetPremierOffer(OfferRequest request);
    }
}
