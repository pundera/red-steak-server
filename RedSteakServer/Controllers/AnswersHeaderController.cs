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
    public class AnswersHeaderController : ApiController
    {
        // GET: api/AnswersHeader
        // ALL -> for the list of all headers.. in app
        public IEnumerable<AnswersHeader> Get()
        {
            var store = DocumentStoreHolder.Store;
            using (IDocumentSession session = store.OpenSession()) // opens a session that will work in context of 'Database'
            {
                // result -> without QuestionValues!!! shorter json..
                var headers = from q in session.Query<AnswersHeader>(IndexiesHolder.AnswersHeaders) orderby q.Updated descending select new AnswersHeader() { Id = q.Id, Created = q.Created, Updated = q.Updated, Note = q.Note };
                return headers.ToList();
            }
        }

        // POST: api/AnswersHeader
        [HttpPost]
        public void Post([FromBody]AnswersHeader value)
        {
            var store = DocumentStoreHolder.Store;
            using (IDocumentSession session = store.OpenSession()) // opens a session that will work in context of 'Database'
            {

                // just for some future logic -> new or updated object ib DB..
                if (string.IsNullOrEmpty(value.Id))
                {
                    // new DB record :-) .. new collection object
                    session.Store(value);
                }
                else
                {
                    // update of DB record :-) .. just new value of collection object
                    session.Store(value);
                }

                session.SaveChanges(); // sends all changes to server
            }
        }

    }
}
