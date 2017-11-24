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
        // GET: api/QuestionValues
        public IEnumerable<QuestionValue> Get()
        {
            var store = DocumentStoreHolder.Store;
            using (IDocumentSession session = store.OpenSession()) // opens a session that will work in context of 'Database'
            {
                var questionValues = from q in session.Query<QuestionValue>(IndexiesNamesHolder.QuestionValues) orderby q.QuestionId select q;
                return questionValues.ToList();
            }
        }

        // GET: api/QuestionValues/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/QuestionValues
        public void Post([FromBody]QuestionValue value)
        {
            var store = DocumentStoreHolder.Store;

            using (IDocumentSession session = store.OpenSession()) // opens a session that will work in context of 'Database'
            {

                if (string.IsNullOrEmpty(value.Id))
                {
                    // new DB record :-) .. new collection object
                    session.Store(value);
                } else
                {
                    // update of DB record :-) .. new value of collection object
                    session.Store(value);
                }

                session.SaveChanges(); // sends all changes to server
            }
        }

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
