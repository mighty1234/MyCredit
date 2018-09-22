using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Unity.Attributes;

namespace MyCredit.Controllers
{
    public class HiController : ApiController
    {
        private IGreeter _greeter;
        
        public HiController([Dependency("HiController")]IGreeter greeter)
        {
            _greeter = greeter;
        }
        // GET: /Hi
        public string  Get()
        {
            return _greeter.SayHello();
        }   
               


   


   
    }
}
