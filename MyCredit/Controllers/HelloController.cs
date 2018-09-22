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
    public class HelloController : ApiController
    {
        
        private IGreeter _greeter;

        public HelloController([Dependency("HelloController")]IGreeter greeter)
        {
            _greeter = greeter;
        }
        // GET: api/Hello
        public string Get()
        {
            return _greeter.SayHello();
        }
    }
       
}

