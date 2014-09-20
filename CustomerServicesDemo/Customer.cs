using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerServicesDemo
{
    [Route("/Customers", "POST")]
    [Route("/Customers", "GET")]
    [Route("/Customers/{CustomerId}", "GET")]
    [Route("/Customers/{CustomerId}", "PUT")]
    [Route("/Customers/{CustomerId}", "DELETE")]
    public class Customer
    {
        public int? CustomerId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
    }
}