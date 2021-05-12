using CompaniesOfferAPI.Util.Models;
using CompaniesOfferAPI.Service;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;
using System.Threading.Tasks;
using System;
using Microsoft.Extensions.Logging;

namespace CompaniesOfferAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PremierController : ControllerBase
    {
        private readonly ICompaniesServiceCharge _companiesServiceCharge;
        private readonly ILogger _logger;
        public PremierController(ICompaniesServiceCharge companiesServiceCharge, ILoggerFactory loggerFactory)
        {
            _companiesServiceCharge = companiesServiceCharge;
            _logger = loggerFactory.CreateLogger<PremierController>();
        }

        [HttpPost]
        [Route("getservicecharge")]
        [Consumes(MediaTypeNames.Application.Xml)]
        [Produces(MediaTypeNames.Application.Xml)]
        public async Task<IActionResult> GetServiceCharge(PremierAPIRequest request)
        {
            try
            {
                _logger.LogInformation("Premier Contoller : GetServiceCharge Call");

                var response = await _companiesServiceCharge.GetPremierServiceCharge(request);
                
                _logger.LogInformation("Premier Contoller : GetServiceCharge Success");

                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Premier Contoller : GetServiceCharge - Error Occured ( {ex.Message} )");
                throw ex;
            }
        }
    }
}
