using AutoMapper;
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
    public class FedXController : ControllerBase
    {
        private readonly ICompanyServiceCharge _companyServiceCharge;
        private readonly ILogger _logger;
        public FedXController(ICompanyServiceCharge companyServiceCharge, ILoggerFactory loggerFactory)
        {
            _companyServiceCharge = companyServiceCharge;
            _logger = loggerFactory.CreateLogger<FedXController>();
        }

        [HttpPost]
        [Route("getservicecharge")]
        [Consumes(MediaTypeNames.Application.Json)]
        public async Task<IActionResult> GetServiceCharge(FedXAPIRequest request)
        {
            try
            {
                _logger.LogInformation("FedX Contoller : GetServiceCharge Call");
                var response = _companyServiceCharge.GetFedXServiceCharge(request);

                _logger.LogInformation("FedX Contoller : GetServiceCharge Success");

                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogError($"FedX Contoller : GetServiceCharge - Error Occured ( {ex.Message } )");

                throw ex;
            }
        }
    }
}
