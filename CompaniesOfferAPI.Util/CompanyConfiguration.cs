using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompaniesOfferAPI.Util
{
    public class CompanyConfiguration
    {
        public static List<ServiceChargeDetails> LoadServiceChargeData(string companyName)
        {
            // Mock Companies Information

            List<ServiceChargeDetails> companies = new List<ServiceChargeDetails>();

            // Company 1 : RX2Go
            companies.Add(new ServiceChargeDetails
            {
                Name = CompanyName.RX2Go,
                Source = "S1",
                Destination = "D1",
                Dimension = new int[] { 4, 4, 4 },
                Cost = 100
            });
            companies.Add(new ServiceChargeDetails
            {
                Name = CompanyName.RX2Go,
                Source = "S1",
                Destination = "D1",
                Dimension = new int[] { 5, 5, 5 },
                Cost = 200
            });
            companies.Add(new ServiceChargeDetails
            {
                Name = CompanyName.RX2Go,
                Source = "S1",
                Destination = "D1",
                Dimension = new int[] { 6, 6, 6 },
                Cost = 300
            });
            //-----
            companies.Add(new ServiceChargeDetails
            {
                Name = CompanyName.RX2Go,
                Source = "S2",
                Destination = "D2",
                Dimension = new int[] { 4, 4, 4 },
                Cost = 300
            });
            companies.Add(new ServiceChargeDetails
            {
                Name = CompanyName.RX2Go,
                Source = "S2",
                Destination = "D2",
                Dimension = new int[] { 5, 5, 5 },
                Cost = 420
            });
            companies.Add(new ServiceChargeDetails
            {
                Name = CompanyName.RX2Go,
                Source = "S2",
                Destination = "D2",
                Dimension = new int[] { 6, 6, 6 },
                Cost = 500
            });
            //-----
            companies.Add(new ServiceChargeDetails
            {
                Name = CompanyName.RX2Go,
                Source = "S3",
                Destination = "D3",
                Dimension = new int[] { 4, 4, 4 },
                Cost = 300
            });
            companies.Add(new ServiceChargeDetails
            {
                Name = CompanyName.RX2Go,
                Source = "S3",
                Destination = "D3",
                Dimension = new int[] { 5, 5, 5 },
                Cost = 440
            });
            companies.Add(new ServiceChargeDetails
            {
                Name = CompanyName.RX2Go,
                Source = "S3",
                Destination = "D3",
                Dimension = new int[] { 6, 6, 6 },
                Cost = 520
            });
           
            //// Company 2 : FedX
            companies.Add(new ServiceChargeDetails
            {
                Name = CompanyName.FedX,
                Source = "S1",
                Destination = "D1",
                Dimension = new int[] { 4, 4, 4 },
                Cost = 110
            });
            companies.Add(new ServiceChargeDetails
            {
                Name = CompanyName.FedX,
                Source = "S1",
                Destination = "D1",
                Dimension = new int[] { 5, 5, 5 },
                Cost = 190
            });
            companies.Add(new ServiceChargeDetails
            {
                Name = CompanyName.FedX,
                Source = "S1",
                Destination = "D1",
                Dimension = new int[] { 6, 6, 6 },
                Cost = 310
            });
            //-----
            companies.Add(new ServiceChargeDetails
            {
                Name = CompanyName.FedX,
                Source = "S2",
                Destination = "D2",
                Dimension = new int[] { 4, 4, 4 },
                Cost = 310
            });
            companies.Add(new ServiceChargeDetails
            {
                Name = CompanyName.FedX,
                Source = "S2",
                Destination = "D2",
                Dimension = new int[] { 5, 5, 5 },
                Cost = 410
            });
            companies.Add(new ServiceChargeDetails
            {
                Name = CompanyName.FedX,
                Source = "S2",
                Destination = "D2",
                Dimension = new int[] { 6, 6, 6 },
                Cost = 510
            });
            //-----
            companies.Add(new ServiceChargeDetails
            {
                Name = CompanyName.FedX,
                Source = "S3",
                Destination = "D3",
                Dimension = new int[] { 4, 4, 4 },
                Cost = 350
            });
            companies.Add(new ServiceChargeDetails
            {
                Name = CompanyName.FedX,
                Source = "S3",
                Destination = "D3",
                Dimension = new int[] { 5, 5, 5 },
                Cost = 430
            });
            companies.Add(new ServiceChargeDetails
            {
                Name = CompanyName.FedX,
                Source = "S3",
                Destination = "D3",
                Dimension = new int[] { 6, 6, 6 },
                Cost = 550
            });

            //// Company 3 : Premier
            companies.Add(new ServiceChargeDetails
            {
                Name = CompanyName.Premier,
                Source = "S1",
                Destination = "D1",
                Dimension = new int[] { 4, 4, 4 },
                Cost = 130
            });
            companies.Add(new ServiceChargeDetails
            {
                Name = CompanyName.Premier,
                Source = "S1",
                Destination = "D1",
                Dimension = new int[] { 5, 5, 5 },
                Cost = 230
            });
            companies.Add(new ServiceChargeDetails
            {
                Name = CompanyName.Premier,
                Source = "S1",
                Destination = "D1",
                Dimension = new int[] { 6, 6, 6 },
                Cost = 290
            });
            //-----
            companies.Add(new ServiceChargeDetails
            {
                Name = CompanyName.Premier,
                Source = "S2",
                Destination = "D2",
                Dimension = new int[] { 4, 4, 4 },
                Cost = 330
            });
            companies.Add(new ServiceChargeDetails
            {
                Name = CompanyName.Premier,
                Source = "S2",
                Destination = "D2",
                Dimension = new int[] { 5, 5, 5 },
                Cost = 430
            });
            companies.Add(new ServiceChargeDetails
            {
                Name = CompanyName.Premier,
                Source = "S2",
                Destination = "D2",
                Dimension = new int[] { 6, 6, 6 },
                Cost = 490
            });
            //-----
            companies.Add(new ServiceChargeDetails
            {
                Name = CompanyName.Premier,
                Source = "S3",
                Destination = "D3",
                Dimension = new int[] { 4, 4, 4 },
                Cost = 370
            });
            companies.Add(new ServiceChargeDetails
            {
                Name = CompanyName.Premier,
                Source = "S3",
                Destination = "D3",
                Dimension = new int[] { 5, 5, 5 },
                Cost = 470
            });
            companies.Add(new ServiceChargeDetails
            {
                Name = CompanyName.Premier,
                Source = "S3",
                Destination = "D3",
                Dimension = new int[] { 6, 6, 6 },
                Cost = 500
            });


            //-- Default
            companies.Add(new ServiceChargeDetails
            {
                Name = CompanyName.RX2Go,
                Source = "",
                Destination = "",
                Dimension = new int[] { },
                Cost = 550
            });
            companies.Add(new ServiceChargeDetails
            {
                Name = CompanyName.FedX,
                Source = "",
                Destination = "",
                Dimension = new int[] { },
                Cost = 650
            });
            companies.Add(new ServiceChargeDetails
            {
                Name = CompanyName.Premier,
                Source = "",
                Destination = "",
                Dimension = new int[] { },
                Cost = 750
            });

            return companies.Where(a=>a.Name == companyName).ToList();
        }
    }


    public class ServiceChargeDetails
    {
        public string Name { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }
        public int[] Dimension { get; set; }
        public decimal Cost { get; set; }
    }

}
