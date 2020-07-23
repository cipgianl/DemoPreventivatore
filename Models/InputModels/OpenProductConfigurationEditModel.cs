using DemoPreventivatore.Models.FeatureTypes;
using DemoPreventivatore.Models.ModelBinders;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoPreventivatore.Models.InputModels
{
    [ModelBinder(typeof(OpenProductConfigurationModelBinder))]
    public class OpenProductConfigurationEditModel
    {
        public int ProductId { get; set; }
        public List<BaseFeature> Features { get; set; } = new List<BaseFeature>();
    }
}
