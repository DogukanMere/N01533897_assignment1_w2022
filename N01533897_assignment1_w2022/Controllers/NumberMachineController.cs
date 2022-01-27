using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace N01533897_assignment1_w2022.Controllers
{
    public class NumberMachineController : ApiController
    {

        // Quest 5
        // GET api/NumberMachine/id

        //<summary>
        // Gives the input number after processing with 4 mathematical operations
        // </summary>


        public int Get(int id)
        {
            // Get square
            int product1 = id * id;

            // Substract 10
            int product2 = product1 - 10;

            // Plus 30
            int product3 = product2 + 30;

            // Divide by 2
            int product4 = product3 / 2;

            // Return the result
            return product4; 
        }
    }
}
