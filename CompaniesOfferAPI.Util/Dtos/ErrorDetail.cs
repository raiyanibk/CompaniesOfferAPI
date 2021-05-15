using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompaniesOfferAPI.Util.Dtos
{
    public class ErrorDetail
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
