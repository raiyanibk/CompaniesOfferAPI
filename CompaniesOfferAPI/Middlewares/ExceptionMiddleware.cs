﻿using CompaniesOfferAPI.Util.CustomException;
using CompaniesOfferAPI.Util.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Net;
using System.Threading.Tasks;

namespace CompaniesOfferAPI.Middleware
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger _logger;
        public ExceptionMiddleware(RequestDelegate next, ILoggerFactory loggerFactory)
        {
            _next = next;
            _logger = loggerFactory.CreateLogger<ExceptionMiddleware>();
        }
        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(httpContext, ex);
            }
        }
        private Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            var exceptionMessage = exception.InnerException != null ? exception.InnerException.Message : exception.Message;
            var statusCode = (int)HttpStatusCode.InternalServerError;
            switch (exception.GetType().Name)
            {
                case nameof(UnauthorizedException):
                    statusCode = (int)HttpStatusCode.Unauthorized;
                    
                    break;
                case nameof(BadRequestException):
                    statusCode = (int)HttpStatusCode.BadRequest;
                    break;
                case nameof(NotFoundException):
                    statusCode = (int)HttpStatusCode.NotFound;
                    break;
                case nameof(NoContentException):
                    statusCode = (int)HttpStatusCode.NoContent;
                    break;
                default:
                    statusCode = (int)HttpStatusCode.InternalServerError;
                    exceptionMessage = "Something went wrong";
                    break;
            }
            
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = statusCode;

            _logger.LogError($"{exception.Message}");

            return context.Response.WriteAsync(new ErrorDetail()
            {
                StatusCode = statusCode,
                Message = exceptionMessage
            }.ToString());
        }
    }
}
