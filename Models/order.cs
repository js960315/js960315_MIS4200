using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace js960315_MIS4200.Models
{
    public class order
    {

        public int orderID { get; set; }
        public int customerID { get; set; }
        public customer customer { get; set; }
        public DateTime orderDate { get; set; }


    }
}