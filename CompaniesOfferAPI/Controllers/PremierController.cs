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
    public class PremierController : ControllerBase
    {
        private readonly ICompanyServiceCharge _companyServiceCharge;
        private readonly ILogger _logger;
        public PremierController(ICompanyServiceCharge companyServiceCharge, ILoggerFactory loggerFactory)
        {
            _companyServiceCharge = companyServiceCharge;
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

                var response = _companyServiceCharge.GetPremierServiceCharge(request);
                
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
