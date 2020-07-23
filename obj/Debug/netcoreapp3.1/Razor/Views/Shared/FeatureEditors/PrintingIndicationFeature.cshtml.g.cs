#pragma checksum "C:\Users\Gianluca\source\repos\DemoPreventivatore\Views\Shared\FeatureEditors\PrintingIndicationFeature.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7db8cb46815f95e3a5d6e1a55aa9fd07a20e7b33"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_FeatureEditors_PrintingIndicationFeature), @"mvc.1.0.view", @"/Views/Shared/FeatureEditors/PrintingIndicationFeature.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Gianluca\source\repos\DemoPreventivatore\Views\_ViewImports.cshtml"
using DemoPreventivatore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Gianluca\source\repos\DemoPreventivatore\Views\_ViewImports.cshtml"
using DemoPreventivatore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Gianluca\source\repos\DemoPreventivatore\Views\_ViewImports.cshtml"
using DemoPreventivatore.Models.InputModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Gianluca\source\repos\DemoPreventivatore\Views\_ViewImports.cshtml"
using DemoPreventivatore.Models.FeatureTypes;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7db8cb46815f95e3a5d6e1a55aa9fd07a20e7b33", @"/Views/Shared/FeatureEditors/PrintingIndicationFeature.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46432ef6527283dfe409562a3079b72e53bc205f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_FeatureEditors_PrintingIndicationFeature : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PrintingIndicationFeature>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("max-width: 20em;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Gianluca\source\repos\DemoPreventivatore\Views\Shared\FeatureEditors\PrintingIndicationFeature.cshtml"
  
    // Determino i nomi dei campi in base all'Id sezione
    var nameFeature = $"{Model.FeatureID}_{Model.SectionId}";
    var fieldCmbIndication = $"cmbPrintingIndication{Model.SectionId}";

    var options = new List<SelectListItem>();

    for (int i = 0; i < Model.Options.Length; i++)
    {
        if (Model.Options[i].IdSection == Model.SectionId)
        {
            options.Add(new SelectListItem
            {
                Value = Model.Options[i].ID.ToString(),
                Text = Model.Options[i].ValueName,
                Selected = (int)Model.Indication == Model.Options[i].ID ? true : false
            });
        }

    }


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div");
            BeginWriteAttribute("id", " id=\"", 719, "\"", 736, 1);
#nullable restore
#line 26 "C:\Users\Gianluca\source\repos\DemoPreventivatore\Views\Shared\FeatureEditors\PrintingIndicationFeature.cshtml"
WriteAttributeValue("", 724, nameFeature, 724, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"container-fluid box-feature\">\r\n    <div style=\"min-width: 200px;\" class=\"form-row\">\r\n        <div class=\"col-10 col-form-label\">\r\n            <label");
            BeginWriteAttribute("for", " for=\"", 893, "\"", 918, 1);
#nullable restore
#line 29 "C:\Users\Gianluca\source\repos\DemoPreventivatore\Views\Shared\FeatureEditors\PrintingIndicationFeature.cshtml"
WriteAttributeValue("", 899, fieldCmbIndication, 899, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 29 "C:\Users\Gianluca\source\repos\DemoPreventivatore\Views\Shared\FeatureEditors\PrintingIndicationFeature.cshtml"
                                        Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7db8cb46815f95e3a5d6e1a55aa9fd07a20e7b336544", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 30 "C:\Users\Gianluca\source\repos\DemoPreventivatore\Views\Shared\FeatureEditors\PrintingIndicationFeature.cshtml"
AddHtmlAttributeValue("", 965, fieldCmbIndication, 965, 19, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
#nullable restore
#line 30 "C:\Users\Gianluca\source\repos\DemoPreventivatore\Views\Shared\FeatureEditors\PrintingIndicationFeature.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = options;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 30 "C:\Users\Gianluca\source\repos\DemoPreventivatore\Views\Shared\FeatureEditors\PrintingIndicationFeature.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Indication);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "section-id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 30 "C:\Users\Gianluca\source\repos\DemoPreventivatore\Views\Shared\FeatureEditors\PrintingIndicationFeature.cshtml"
AddHtmlAttributeValue("", 1046, Model.SectionId, 1046, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
    </div>
</div>

<script type=""text/javascript"">
    document.addEventListener(""DOMContentLoaded"", function (event) {
        $('select[id^=""cmbPrintingIndication""]').off().change(function () {
            let sectionId = parseInt($(this).attr(""section-id""));

        });
    });
</script>
");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PrintingIndicationFeature> Html { get; private set; }
    }
}
#pragma warning restore 1591