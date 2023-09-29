using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace N01605386.Controllers
{
    //this contreoller can adding the id to the 0
    public class AddTenController : ApiController
    {
         // Get api/addten/{id}
        // GET localhost/AddTen/21    --->> 31
       //GET localhost/AddTen/0       --->> 10
      //GET localhost/AddTen/-9       --->> 1

        public int Get(int id)
        {
            int addnumber10 = id + 10;
            return addnumber10;

        }
    }
}
