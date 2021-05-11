using CompaniesOfferAPI.Business.Interface;
using CompaniesOfferAPI.Common.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;

namespace CompaniesOfferAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyOffrerController : ControllerBase
    {
        private readonly ICompaniesOfferService _companiesOfferService;
        public CompanyOffrerController(ICompaniesOfferService companiesOfferService)
        {
            _companiesOfferService = companiesOfferService;
        }

        [HttpPost]
        [Route("getrx2gooffer")]
        [Consumes(MediaTypeNames.Application.Json)]
        public async Task<IActionResult> GetRX2GoOffer(RX2APIRequest request)
        {
            var offer = await _companiesOfferService.GetRX2GoOffer(new OfferRequest
            {
                Source = request.contactaddress,
                Destination = request.warehouseaddress,
                Carton = request.packagedimensions,
            });

            return Ok(new RX2GoAPIResponse
            {
                total = offer
            });
        }

        [HttpPost]
        [Route("getfedxoffer")]
        [Consumes(MediaTypeNames.Application.Json)]
        public async Task<IActionResult> GetFedXOffer(FedXAPIRequest request)
        {
            var offer = await _companiesOfferService.GetFedXOffer(new OfferRequest
            {
                Source = request.consignee,
                Destination = request.consignor,
                Carton = request.cartons,
            });

            return Ok(new FedXAPIResponse
            {
                amount = offer
            });
        }

        [HttpPost]
        [Route("getpremieroffer")]
        [Consumes(MediaTypeNames.Application.Xml)]
        [Produces(MediaTypeNames.Application.Xml)]
        public async Task<IActionResult> GetPremierOffer(PremierAPIRequest request)
        {
            var offer = await _companiesOfferService.GetPremierOffer(new OfferRequest
            {
                Source = request.source,
                Destination = request.destination,
                Carton = request.packagedimensions,
            });

            return Ok(new PremierAPIResponse
            {
                quote = offer
            });
        }

    }
}
