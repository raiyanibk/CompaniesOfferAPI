﻿using AutoMapper;
using CompaniesOfferAPI.Service;
using CompaniesOfferAPI.Util.Models;
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
        private readonly ICompaniesServiceCharge _companiesServiceCharge;
        private readonly ILogger _logger;
        private readonly IMapper _mapper;
        public FedXController(ICompaniesServiceCharge companiesServiceCharge, ILoggerFactory loggerFactory, IMapper mapper)
        {
            _companiesServiceCharge = companiesServiceCharge;
            _logger = loggerFactory.CreateLogger<FedXController>();
            _mapper = mapper;
        }

        [HttpPost]
        [Route("getservicecharge")]
        [Consumes(MediaTypeNames.Application.Json)]
        public async Task<IActionResult> GetServiceCharge(FedXAPIRequest request)
        {
            try
            {
                _logger.LogInformation("FedX Contoller : GetServiceCharge Call");
                var response = _companiesServiceCharge.GetFedXServiceCharge(request);

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
