using DemoPreventivatore.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoPreventivatore.Models.FeatureTypes
{
    public class SupportFeature : BaseFeature
    {
        public string SelectedValue { get; set; }
        public string SupportName { get; set; }
        public int Grams { get; set; }
        public FeatSupport[] Options { get; set; }
    }
}
