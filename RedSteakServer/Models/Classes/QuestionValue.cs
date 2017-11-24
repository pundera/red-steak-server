using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RedSteakServer.Models.Classes
{
    public class QuestionValue
    {
        public string Id;
        public AnswersHeader Header;
        public Question Question;
        public dynamic Value;
    }
}