using CompaniesOfferAPI.Service;
using CompaniesOfferAPI.Util.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Net.Mime;
using System.Threading.Tasks;

namespace CompaniesOfferAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Rx2GoController : ControllerBase
    {
        private readonly ICompanyServiceCharge _companyServiceCharge;
        private readonly ILogger _logger;
        public Rx2GoController(ICompanyServiceCharge companyServiceCharge, ILoggerFactory loggerFactory)
        {
            _companyServiceCharge = companyServiceCharge;
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
                
                var response = _companyServiceCharge.GetRX2GoServiceCharge(request);

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
