using Newtonsoft.Json;
using Raven.Client.Documents.Session;
using RedSteakServer.Data.Import;
using RedSteakServer.Models.Classes;
using RedSteakServer.Models.Singletons;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace RedSteakServer.Controllers
{
    public class QuestionsController : ApiController
    {

        // GET: api/Questions
        public IEnumerable<Question> Get()
        {
            var store = DocumentStoreHolder.Store;
            using (IDocumentSession session = store.OpenSession()) // opens a session that will work in context of 'Database'
            {
                var questions = from q in session.Query<Question>(IndexiesNamesHolder.Questions) orderby q.OrderNumber select q;
                return questions.ToList();
            }
        }

        // GET: api/Questions/5
        public Question Get(int id)
        {
            var store = DocumentStoreHolder.Store;
            using (IDocumentSession session = store.OpenSession()) // opens a session that will work in context of 'Database'
            {
                var question = from q in session.Query<Question>(IndexiesNamesHolder.Questions) where q.Id == id.ToString() select q;
                return question.Single();
            }
        }

        // POST: api/Questions    
        // Import of ALL default QUESTIONS from json string holder stored IN CODE!
        public void Post()
        {
            var store = DocumentStoreHolder.Store;

            using (IDocumentSession session = store.OpenSession()) // opens a session that will work in context of 'Database'
            {

                var jsonString = JsonImportHolder.Questions;
                var questions = JsonConvert.DeserializeObject<Question[]>(jsonString);

                // in real application (if too many records - objects in collection)
                // it's better to uses batch import!!! :-) not important here -> just few questions (~100) to import!
                // and just in the start of app life!
                foreach (var q in questions)
                {
                    session.Store(q); // stores question in session, assigning it to a collection `Questions`
                }

                session.SaveChanges(); // sends all changes to server
            }
        }

        // Not implemented jet!!!
        //// PUT: api/Questions/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        // Not implemented jet!!!
        //// DELETE: api/Questions/5
        //public void Delete(int id)
        //{
        //}
    }
}
