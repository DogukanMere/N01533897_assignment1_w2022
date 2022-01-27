using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace N01533897_assignment1_w2022.Controllers
{
    public class SquareController : ApiController
    {

        //Question 2 (Square)
        //GET api/Square/num
        public int Get(int id)
        {
            //Give the square of input value
            int product = id * id;
            return product;
        }


    }
}
