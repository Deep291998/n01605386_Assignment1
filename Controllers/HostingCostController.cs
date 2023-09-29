using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace N01605386.Controllers
{
    public class HostingCostController : ApiController
    {
        public string Get(int id)
        {
            int onefortnight = 14;
            double charge = 5.50;
            double tax = 13;

            double numofdays = id / onefortnight + 1;
            double cost = numofdays * charge;
            double totltax = cost * tax / 100;
            double total = totltax + cost;
            return   numofdays +  " fortnights at $5.50 / FN =" + cost  + " CAD HST 13 % = " + totltax + " CAD Total = $" + total + " CAD";
            
        }
    }
}
