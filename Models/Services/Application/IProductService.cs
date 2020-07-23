using DemoPreventivatore.Models.InputModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoPreventivatore.Models.Services.Application
{
    public interface IProductService
    {
        OpenProductConfigurationEditModel GetProductForEditing(int productId);
        void EditProduct(int productId, OpenProductConfigurationEditModel editModel);
    }
}
