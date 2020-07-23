using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using DemoPreventivatore.Models.FeatureTypes;


namespace DemoPreventivatore.Models.Services.Infrastructure
{
    public interface IProductRepository
    {
        List<BaseFeature> GetProductFeatures(int productId);
        void SaveProductFeatures(int productId, List<BaseFeature> features);
    }
}
