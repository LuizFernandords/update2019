using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models {
    public class Seller {
        private int id { get; set; }
        private string name { get; set; }
        private string email { get; set; }
        private DateTime birthdate { get; set; }
        private double basesalary { get; set; }

        public void addSales(SellerRecord sr) {
            
        }

        public void removeSales(SellerRecord sr) { 
        
        }

        public double totalSales(DateTime inital, DateTime final) {
            return 0;
        }



    }
}
