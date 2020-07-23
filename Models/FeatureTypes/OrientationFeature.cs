using DemoPreventivatore.Models.Entities;
using DemoPreventivatore.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoPreventivatore.Models.FeatureTypes
{
    public class OrientationFeature : BaseFeature
    {
        public OrientationEnum Orientation { get; set; }
        public Orientation[] Options { get; set; }
    }
}
