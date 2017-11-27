using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RedSteakServer.Models.Classes
{
    public class AnswersHeader
    {
        public string Id;
        public DateTime Created;
        public DateTime Updated;
        public string Note;
        public IEnumerable<QuestionValue> QuestionValues;
    }
}