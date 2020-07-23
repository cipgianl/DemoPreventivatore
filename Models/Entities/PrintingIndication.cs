using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoPreventivatore.Models.Entities
{
    public class PrintingIndication
    {
        public int ID { get; set; }
        public int IdSection { get; set; }
        public string ValueName { get; set; }

        public override string ToString()
        {
            return ValueName;
        }
    }
}
