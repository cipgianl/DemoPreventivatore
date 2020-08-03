using DemoPreventivatore.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoPreventivatore.Models.FeatureTypes
{
    public class LaminationFeature : BaseFeature
    {
        public int SelectedValue { get; set; }
        public int Coating { get; set; }
        public int Indication { get; set; }
        public FeatLamination[] Options { get; set; }
    }
}
