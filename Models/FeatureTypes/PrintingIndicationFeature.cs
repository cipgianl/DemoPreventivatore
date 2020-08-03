using DemoPreventivatore.Models.Entities;
using DemoPreventivatore.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoPreventivatore.Models.FeatureTypes
{
    public class PrintingIndicationFeature : BaseFeature
    {
        public IndicationEnum Indication { get; set; }
        public FeatPrintingIndication[] Options { get; set; }
    }
}
