using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompaniesOfferAPI.Common
{
    public class CompanyConfiguration
    {
        public static List<CompanyInfo> LoadComapanies(string companyName)
        {
            // Mock Companies Information

            List<CompanyInfo> companies = new List<CompanyInfo>();

            // Company 1 : RX2Go
            companies.Add(new CompanyInfo
            {
                Name = CompanyName.RX2Go,
                Source = "S1",
                Destination = "D1",
                Diamention = new int[] { 4, 4, 4 },
                Cost = 100
            });
            companies.Add(new CompanyInfo
            {
                Name = CompanyName.RX2Go,
                Source = "S1",
                Destination = "D1",
                Diamention = new int[] { 5, 5, 5 },
                Cost = 200
            });
            companies.Add(new CompanyInfo
            {
                Name = CompanyName.RX2Go,
                Source = "S1",
                Destination = "D1",
                Diamention = new int[] { 6, 6, 6 },
                Cost = 300
            });
            //-----
            companies.Add(new CompanyInfo
            {
                Name = CompanyName.RX2Go,
                Source = "S2",
                Destination = "D2",
                Diamention = new int[] { 4, 4, 4 },
                Cost = 300
            });
            companies.Add(new CompanyInfo
            {
                Name = CompanyName.RX2Go,
                Source = "S2",
                Destination = "D2",
                Diamention = new int[] { 5, 5, 5 },
                Cost = 420
            });
            companies.Add(new CompanyInfo
            {
                Name = CompanyName.RX2Go,
                Source = "S2",
                Destination = "D2",
                Diamention = new int[] { 6, 6, 6 },
                Cost = 500
            });
            //-----
            companies.Add(new CompanyInfo
            {
                Name = CompanyName.RX2Go,
                Source = "S3",
                Destination = "D3",
                Diamention = new int[] { 4, 4, 4 },
                Cost = 300
            });
            companies.Add(new CompanyInfo
            {
                Name = CompanyName.RX2Go,
                Source = "S3",
                Destination = "D3",
                Diamention = new int[] { 5, 5, 5 },
                Cost = 440
            });
            companies.Add(new CompanyInfo
            {
                Name = CompanyName.RX2Go,
                Source = "S3",
                Destination = "D3",
                Diamention = new int[] { 6, 6, 6 },
                Cost = 520
            });
           
            //// Company 2 : FedX
            companies.Add(new CompanyInfo
            {
                Name = CompanyName.FedX,
                Source = "S1",
                Destination = "D1",
                Diamention = new int[] { 4, 4, 4 },
                Cost = 110
            });
            companies.Add(new CompanyInfo
            {
                Name = CompanyName.FedX,
                Source = "S1",
                Destination = "D1",
                Diamention = new int[] { 5, 5, 5 },
                Cost = 190
            });
            companies.Add(new CompanyInfo
            {
                Name = CompanyName.FedX,
                Source = "S1",
                Destination = "D1",
                Diamention = new int[] { 6, 6, 6 },
                Cost = 310
            });
            //-----
            companies.Add(new CompanyInfo
            {
                Name = CompanyName.FedX,
                Source = "S2",
                Destination = "D2",
                Diamention = new int[] { 4, 4, 4 },
                Cost = 310
            });
            companies.Add(new CompanyInfo
            {
                Name = CompanyName.FedX,
                Source = "S2",
                Destination = "D2",
                Diamention = new int[] { 5, 5, 5 },
                Cost = 410
            });
            companies.Add(new CompanyInfo
            {
                Name = CompanyName.FedX,
                Source = "S2",
                Destination = "D2",
                Diamention = new int[] { 6, 6, 6 },
                Cost = 510
            });
            //-----
            companies.Add(new CompanyInfo
            {
                Name = CompanyName.FedX,
                Source = "S3",
                Destination = "D3",
                Diamention = new int[] { 4, 4, 4 },
                Cost = 350
            });
            companies.Add(new CompanyInfo
            {
                Name = CompanyName.FedX,
                Source = "S3",
                Destination = "D3",
                Diamention = new int[] { 5, 5, 5 },
                Cost = 430
            });
            companies.Add(new CompanyInfo
            {
                Name = CompanyName.FedX,
                Source = "S3",
                Destination = "D3",
                Diamention = new int[] { 6, 6, 6 },
                Cost = 550
            });

            //// Company 3 : Premier
            companies.Add(new CompanyInfo
            {
                Name = CompanyName.Premier,
                Source = "S1",
                Destination = "D1",
                Diamention = new int[] { 4, 4, 4 },
                Cost = 130
            });
            companies.Add(new CompanyInfo
            {
                Name = CompanyName.Premier,
                Source = "S1",
                Destination = "D1",
                Diamention = new int[] { 5, 5, 5 },
                Cost = 230
            });
            companies.Add(new CompanyInfo
            {
                Name = CompanyName.Premier,
                Source = "S1",
                Destination = "D1",
                Diamention = new int[] { 6, 6, 6 },
                Cost = 290
            });
            //-----
            companies.Add(new CompanyInfo
            {
                Name = CompanyName.Premier,
                Source = "S2",
                Destination = "D2",
                Diamention = new int[] { 4, 4, 4 },
                Cost = 330
            });
            companies.Add(new CompanyInfo
            {
                Name = CompanyName.Premier,
                Source = "S2",
                Destination = "D2",
                Diamention = new int[] { 5, 5, 5 },
                Cost = 430
            });
            companies.Add(new CompanyInfo
            {
                Name = CompanyName.Premier,
                Source = "S2",
                Destination = "D2",
                Diamention = new int[] { 6, 6, 6 },
                Cost = 490
            });
            //-----
            companies.Add(new CompanyInfo
            {
                Name = CompanyName.Premier,
                Source = "S3",
                Destination = "D3",
                Diamention = new int[] { 4, 4, 4 },
                Cost = 370
            });
            companies.Add(new CompanyInfo
            {
                Name = CompanyName.Premier,
                Source = "S3",
                Destination = "D3",
                Diamention = new int[] { 5, 5, 5 },
                Cost = 470
            });
            companies.Add(new CompanyInfo
            {
                Name = CompanyName.Premier,
                Source = "S3",
                Destination = "D3",
                Diamention = new int[] { 6, 6, 6 },
                Cost = 500
            });


            //-- Default
            companies.Add(new CompanyInfo
            {
                Name = CompanyName.RX2Go,
                Source = "",
                Destination = "",
                Diamention = new int[] { },
                Cost = 550
            });
            companies.Add(new CompanyInfo
            {
                Name = CompanyName.FedX,
                Source = "",
                Destination = "",
                Diamention = new int[] { },
                Cost = 650
            });
            companies.Add(new CompanyInfo
            {
                Name = CompanyName.Premier,
                Source = "",
                Destination = "",
                Diamention = new int[] { },
                Cost = 750
            });

            return companies.Where(a=>a.Name == companyName).ToList();
        }
    }


    public class CompanyInfo
    {
        public string Name { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }
        public int[] Diamention { get; set; }
        public decimal Cost { get; set; }
    }

}
