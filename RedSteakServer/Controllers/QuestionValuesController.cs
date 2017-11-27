using Raven.Client.Documents.Session;
using RedSteakServer.Models.Classes;
using RedSteakServer.Models.Singletons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RedSteakServer.Controllers
{
    public class QuestionValuesController : ApiController
    {
        // Options:
        public void Options() { }

        // PUT: api/QuestionValues/5
        public void Put(int id, [FromBody]QuestionValue value)
        {
            
        }

        // DELETE: api/QuestionValues/5
        public void Delete(int id)
        {
        }
    }
}
