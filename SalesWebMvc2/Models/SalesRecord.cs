using SalesWebMvc2.Models.Enuns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc2.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amaunt { get; set; }
        public SaleStatus Status { get; set; }
        public Seller Seller { get; set; }
        public SalesRecord()
        {
        }

        public SalesRecord(int id, DateTime date, double amaunt, SaleStatus status, Seller seller)
        {
            Id = id;
            Date = date;
            Amaunt = amaunt;
            Status = status;
            Seller = seller;
        }

        public SalesRecord(DateTime date, double amaunt, SaleStatus status, Seller seller)
        {
            Date = date;
            Amaunt = amaunt;
            Status = status;
            Seller = seller;
        }
    }
}
