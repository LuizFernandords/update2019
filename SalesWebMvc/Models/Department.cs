using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models {
    public class Department {
        public int id { get; set; }
        public string name { get; set; }

        public void addSeller(Seller seller) {

        }

        public double totalSales(DateTime initial, DateTime final) {
            return 0;
        }


    }
}
