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
    public class Rx2GoController : ControllerBase
    {
        private readonly ICompanyServiceCharge _companiesServiceCharge;
        private readonly ILogger _logger;
        public Rx2GoController(ICompanyServiceCharge companiesServiceCharge, ILoggerFactory loggerFactory)
        {
            _companiesServiceCharge = companiesServiceCharge;
            _logger = loggerFactory.CreateLogger<Rx2GoController>();
        }

        [HttpPost]
        [Route("getservicecharge")]
        [Consumes(MediaTypeNames.Application.Json)]
        public async Task<IActionResult> GetServiceCharge(RX2APIRequest request)
        {
            try
            {
                _logger.LogInformation("RX2Go Contoller : GetServiceCharge call");
                
                var response = _companiesServiceCharge.GetRX2GoServiceCharge(request);

                _logger.LogInformation("RX2Go Contoller : GetServiceCharge Success");

                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogError($"RX2Go Contoller : GetServiceCharge - Error occured ( {ex.Message} )");
                throw ex;
            }
        }
    }
}
