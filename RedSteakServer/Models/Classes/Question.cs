using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RedSteakServer.Models.Classes
{
    public class Question
    {
        public string Id;
        public int Number;
        public string Header;
        public byte Type;
        public string[] TypeValues;
        public bool? Vertical;
        public dynamic DefaultValue;
        public int OrderNumber;
    }
}