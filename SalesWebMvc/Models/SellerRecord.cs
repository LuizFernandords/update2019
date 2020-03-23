using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models {
    public class SellerRecord {
        private int id { get; set; }
        private DateTime date { get; set; }
        private double amount { get; set; }
        public  SalesStatus status { get; set; }

    }
}
