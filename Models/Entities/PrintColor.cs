using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoPreventivatore.Models.Entities
{
    public class PrintColor
    {
        public int ID { get; set; }
        public int SectionId { get; set; }
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
