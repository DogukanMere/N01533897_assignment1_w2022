using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace N01533897_assignment1_w2022.Controllers
{
    public class GreetingController : ApiController
    {

        // Question 3 (Greeting)
        // GET api/Greeting
        public string Post()
        {
            return "Hello World!";
        }

        // Question 4 (greeting num)
        // GET api/Greeting/num
        // Returns the input value with additional strings
        public string Get(int id)
        {
           
            return "Greetings to" + id + " people!";
        }
    }
}
