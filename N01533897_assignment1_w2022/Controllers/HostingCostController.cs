using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace N01533897_assignment1_w2022.Controllers
{
    public class HostingCostController : ApiController
    {
        //Question 6 (Initiative Question)
        //GET api/HostingCost/num 

        //<summary>
        // Gets created variables in consider to calculate the cost with details
        // such as before tax and after tax
        // and provide each detail with extra strings
        // </summary>
        // <param name="id"> The input number (number of day(s))</param>
        // <returns> Gives the detailed total cost per night (which is given as parameter id) </returns>

        public string Get(double id)
        {
            double x = 5.50;
            double y = x * id;
            double taxTotal = y * 0.13;
            double total = taxTotal + y;

            string product1 = id + " fortnights at $5.50/FN = $" + Math.Round(y, 2) + " CAD --           ";
            string product2 = "HST 13% = $" + Math.Round(taxTotal, 2) + " CAD --             ";
            string product3 = "Total = $" + Math.Round(total, 2) + " CAD";
            return product1 + product2 + product3;
        }
    }
}
