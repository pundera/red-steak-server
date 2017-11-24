﻿using RedSteakServer.Models.Singletons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RedSteakServer.Controllers
{
    // just example - of web rest API controller 
    // for testing purposes!!! :-)
    public class DocController : ApiController
    {
        // GET: api/Doc
        public IEnumerable<string> Get()
        {
            var store = DocumentStoreHolder.Store;


            return new string[] { "value1", "value2" };
        }

        // GET: api/Doc/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Doc
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Doc/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Doc/5
        public void Delete(int id)
        {
        }
    }
}
