using DemoPreventivatore.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoPreventivatore.Models.FeatureTypes
{
    public class OpenFinalSizeFeature : BaseFeature
    {
        public int SelectedValue { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }
        public OpenFinalSize[] Options { get; set; }
    }
}
