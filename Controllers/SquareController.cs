using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace N01605386.Controllers
{
    public class SquareController : ApiController
    {
        //This controller can sraure the id 
        // GET localhost/Square/  ->->  square of 2 will be 4 
        // GET localhost/Square/  ->->  square of -21 will be 4
        //GET localhost/Square/   ->->  square of 10 will be 100
        // get method is used
        public double get(double id)
        {
            double square = Math.Pow(id, 2);
            return square;
        }
    }
}
