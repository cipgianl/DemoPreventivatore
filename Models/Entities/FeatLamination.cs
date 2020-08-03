using DemoPreventivatore.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoPreventivatore.Models.Entities
{
    public class FeatLamination
    {
        public int ID { get; set; }
        public int IdSection { get; set; }
        public CoatingEnum Coating { get; set; }
        public IndicationEnum Indication { get; set; }
        public string ValueName { get; set; }

        public override string ToString()
        {
            return ValueName;
        }
    }
}
