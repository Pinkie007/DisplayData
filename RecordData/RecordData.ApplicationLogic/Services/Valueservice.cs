using RecordData.ApplicationLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordData.ApplicationLogic.Services
{
    public class ValueService : IValueService
    {
        public IEnumerable<string> GetValues()
        {
            return new string[] { "value1", "value2" };
        }
        public string GetValue(string id)
        {
            return "value";
        }

        public string AddValue(int value)
        {
            return string.Empty;
        }
        
    }
}