using System.Linq;
using System.Runtime.Serialization;

namespace CompaniesOfferAPI.Util.Dtos
{
    public class RX2APIRequest
    {
        public string ContactAddress { get; set; }
        public string WarehouseAddress { get; set; }
        public int[] PackageDimensions { get; set; }
    }

    public class FedXAPIRequest 
    {
        public string Consignee { get; set; }
        public string Consignor { get; set; }
        public int[] Cartons { get; set; }
    }

    public class PremierAPIRequest 
    {
        public string Source { get; set; }
        public string Destination { get; set; }
        public string Packages { get; set; }

        [IgnoreDataMember]
        public int[] PackageDimensions {
            get => Packages.Split(',').Select(n => int.Parse(n)).ToArray();
        }
    }

    public class ServiceChargeRequest
    {
        public string Source { get; set; }
        public string Destination { get; set; }
        public int[] Carton { get; set; }
    }
}
