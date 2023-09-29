using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace N01605386.Controllers
{
    public class NumberMachineController : ApiController
    {
       public int Get(int id)
        {
            int add = id + 10;
            int sub =  add - 10;
            int milt = sub * 2;
            int final_ans = milt / 2;
            return final_ans;
           
        }
    }
}
