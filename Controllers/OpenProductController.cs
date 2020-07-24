using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DemoPreventivatore.Models.FeatureTypes;
using DemoPreventivatore.Models.InputModels;
using DemoPreventivatore.Models.Services.Application;

namespace DemoPreventivatore.Controllers
{
    public class OpenProductController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        public IActionResult Edit([FromServices] IProductService productService, int id)
        {
            OpenProductConfigurationEditModel product = productService.GetProductForEditing(id);
            return View(product);
        }

        [HttpGet]
        public JsonResult GetSelectSize([FromServices] IProductService productService, int id, int value)
        {
            OpenProductConfigurationEditModel product = productService.GetProductForEditing(id);
            var feat = (OpenFinalSizeFeature)product.Features.Where(w => w.FeatureId == "FINAL_FTO").First();
            var selectedValue = feat.Options.Where(w => w.ID == value).First();
            return Json(selectedValue);
        }

        [HttpGet]
        public JsonResult GetGramsBySupportId([FromServices] IProductService productService, string supportId, int sectionId)
        {
            OpenProductConfigurationEditModel product = productService.GetProductForEditing(1);
            var feat = (SupportFeature)product.Features.Where(w => w.FeatureId == "SUPPORT" && w.SectionId == sectionId).First();
            return Json(feat.Options.Where(g => g.SupportId == supportId).Select(g => g.Grams).ToArray());
        }
    }
}
