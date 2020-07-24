using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoPreventivatore.Models.Entities
{
    public class FeatPrintColor
    {
        public int ID { get; set; }
        public int IdSection { get; set; }
        public int Indication { get; set; }
        public int Value { get; set; }
        public string ValueName { get; set; }
        public string FieldName { get; set; }
        public override string ToString()
        {
            return ValueName;
        }
    }
}
