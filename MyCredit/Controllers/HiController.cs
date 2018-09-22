using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyCredit.Controllers
{
    public class HiController : ApiController
    {
        Greeter gr = new Greeter();
        // GET: api/Hi
        public string  Get()
        {
            return gr.SayHello();
        }   
               


   


   
    }
}
