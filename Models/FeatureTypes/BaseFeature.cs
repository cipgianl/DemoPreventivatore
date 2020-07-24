using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoPreventivatore.Models.FeatureTypes
{
    public class BaseFeature
    {
        public string Name { get; set; }
        public string FeatureId { get; set; }
        public int SectionId { get; set; }
        public bool Visible { get; set; }
        public bool Calculate { get; set; }
        public string EditorName => $"FeatureEditors/{this.GetType().Name}";
    }
}
