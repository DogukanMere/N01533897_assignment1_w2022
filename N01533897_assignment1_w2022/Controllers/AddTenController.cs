using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace N01533897_assignment1_w2022.Controllers
{
    public class AddTenController : ApiController
    {
        //Question 1
        //GET api/AddTen/num
        public int Get(int id)
        {
            int product1 = id + 10;
            return product1;
        }
    }
}
