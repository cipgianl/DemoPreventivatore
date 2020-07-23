using DemoPreventivatore.Models.InputModels;
using DemoPreventivatore.Models.Services.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoPreventivatore.Models.Services.Application
{
    public class MockProductService : IProductService
    {
        private readonly IProductRepository productRepository;

        public MockProductService(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        
        public OpenProductConfigurationEditModel GetProductForEditing(int productId)
        {
            var editModel = new OpenProductConfigurationEditModel()
            {
                ProductId = productId,
                Features = productRepository.GetProductFeatures(productId)
            };
            return editModel;
        }

        public void EditProduct(int productId, OpenProductConfigurationEditModel editModel)
        {
            productRepository.SaveProductFeatures(productId, editModel.Features);
        }
    }
}
