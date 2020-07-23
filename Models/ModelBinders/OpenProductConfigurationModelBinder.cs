using DemoPreventivatore.Models.FeatureTypes;
using DemoPreventivatore.Models.InputModels;
using DemoPreventivatore.Models.Services.Infrastructure;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoPreventivatore.Models.ModelBinders
{
    public class OpenProductConfigurationModelBinder : IModelBinder
    {
        private readonly IModelMetadataProvider modelMetadataProvider;
        private readonly IModelBinderFactory modelBinderFactory;
        private readonly IProductRepository productRepository;

        public OpenProductConfigurationModelBinder(IModelMetadataProvider modelMetadataProvider, IModelBinderFactory modelBinderFactory, IProductRepository productRepository)
        {
            this.modelMetadataProvider = modelMetadataProvider;
            this.modelBinderFactory = modelBinderFactory;
            this.productRepository = productRepository;
        }

        public async Task BindModelAsync(ModelBindingContext bindingContext)
        {
            if (!int.TryParse(bindingContext.ValueProvider.GetValue("id").FirstValue, out int productId))
            {
                throw new Exception("The product id was not provided");
            }

            var editModel = new OpenProductConfigurationEditModel
            {
                Features = productRepository.GetProductFeatures(productId)
            };

            for (int i = 0; i < editModel.Features.Count; i++)
            {
                BaseFeature feature = editModel.Features[i];
                ModelMetadata modelMetadata = modelMetadataProvider.GetMetadataForType(feature.GetType());
                IModelBinder modelBinder = modelBinderFactory.CreateBinder(new ModelBinderFactoryContext
                {
                    Metadata = modelMetadata,
                    CacheToken = modelMetadata
                });

                string modelName = $"{bindingContext.BinderModelName}.Features[{i}]".TrimStart('.');
                using (var scope = bindingContext.EnterNestedScope(modelMetadata, modelName, modelName, feature))
                {
                    await modelBinder.BindModelAsync(bindingContext);
                }
            }

            bindingContext.Result = ModelBindingResult.Success(editModel);
        }
    }
}
