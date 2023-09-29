using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace N01605386.Controllers
{
    public class GreetingController : ApiController
    {
        //This controller can greeting peoples after return the id
        //GET localhost/Greeting/3 ->->   Greetings to 3 people!
        //GET localhost/Greeting/3 ->->   Greetings to 6 people!
        //GET localhost/Greeting/3 ->->   Greetings to 0 people!
        public string Get (int id)
            {
                return "Greeting " + id +" people!";
            }
        
        //starting a post method for hello world output
        public string Post()
        {
            return "Hello World";
        }
    }
}
