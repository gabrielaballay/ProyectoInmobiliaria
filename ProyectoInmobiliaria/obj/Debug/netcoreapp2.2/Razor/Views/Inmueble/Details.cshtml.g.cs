#pragma checksum "C:\Users\Laura\Documents\GitHub\ProyectoInmobiliaria\ProyectoInmobiliaria\Views\Inmueble\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69913310b9eb2e101f7ba7bf5e89c3d3c3a7ce31"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Inmueble_Details), @"mvc.1.0.view", @"/Views/Inmueble/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Inmueble/Details.cshtml", typeof(AspNetCore.Views_Inmueble_Details))]
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
#line 1 "C:\Users\Laura\Documents\GitHub\ProyectoInmobiliaria\ProyectoInmobiliaria\Views\_ViewImports.cshtml"
using ProyectoInmobiliaria.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69913310b9eb2e101f7ba7bf5e89c3d3c3a7ce31", @"/Views/Inmueble/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"119ecc686d10bca0ef1aa9cd4f703abd70a5a8ab", @"/Views/_ViewImports.cshtml")]
    public class Views_Inmueble_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProyectoInmobiliaria.Models.Inmueble>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Laura\Documents\GitHub\ProyectoInmobiliaria\ProyectoInmobiliaria\Views\Inmueble\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(90, 131, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Inmueble</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(222, 46, false);
#line 14 "C:\Users\Laura\Documents\GitHub\ProyectoInmobiliaria\ProyectoInmobiliaria\Views\Inmueble\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IdInmueble));

#line default
#line hidden
            EndContext();
            BeginContext(268, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(332, 42, false);
#line 17 "C:\Users\Laura\Documents\GitHub\ProyectoInmobiliaria\ProyectoInmobiliaria\Views\Inmueble\Details.cshtml"
       Write(Html.DisplayFor(model => model.IdInmueble));

#line default
#line hidden
            EndContext();
            BeginContext(374, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(437, 45, false);
#line 20 "C:\Users\Laura\Documents\GitHub\ProyectoInmobiliaria\ProyectoInmobiliaria\Views\Inmueble\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Direccion));

#line default
#line hidden
            EndContext();
            BeginContext(482, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(546, 41, false);
#line 23 "C:\Users\Laura\Documents\GitHub\ProyectoInmobiliaria\ProyectoInmobiliaria\Views\Inmueble\Details.cshtml"
       Write(Html.DisplayFor(model => model.Direccion));

#line default
#line hidden
            EndContext();
            BeginContext(587, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(650, 39, false);
#line 26 "C:\Users\Laura\Documents\GitHub\ProyectoInmobiliaria\ProyectoInmobiliaria\Views\Inmueble\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Uso));

#line default
#line hidden
            EndContext();
            BeginContext(689, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(753, 35, false);
#line 29 "C:\Users\Laura\Documents\GitHub\ProyectoInmobiliaria\ProyectoInmobiliaria\Views\Inmueble\Details.cshtml"
       Write(Html.DisplayFor(model => model.Uso));

#line default
#line hidden
            EndContext();
            BeginContext(788, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(851, 40, false);
#line 32 "C:\Users\Laura\Documents\GitHub\ProyectoInmobiliaria\ProyectoInmobiliaria\Views\Inmueble\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Tipo));

#line default
#line hidden
            EndContext();
            BeginContext(891, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(955, 36, false);
#line 35 "C:\Users\Laura\Documents\GitHub\ProyectoInmobiliaria\ProyectoInmobiliaria\Views\Inmueble\Details.cshtml"
       Write(Html.DisplayFor(model => model.Tipo));

#line default
#line hidden
            EndContext();
            BeginContext(991, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1054, 56, false);
#line 38 "C:\Users\Laura\Documents\GitHub\ProyectoInmobiliaria\ProyectoInmobiliaria\Views\Inmueble\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CantidadHabitaciones));

#line default
#line hidden
            EndContext();
            BeginContext(1110, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1174, 52, false);
#line 41 "C:\Users\Laura\Documents\GitHub\ProyectoInmobiliaria\ProyectoInmobiliaria\Views\Inmueble\Details.cshtml"
       Write(Html.DisplayFor(model => model.CantidadHabitaciones));

#line default
#line hidden
            EndContext();
            BeginContext(1226, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1289, 42, false);
#line 44 "C:\Users\Laura\Documents\GitHub\ProyectoInmobiliaria\ProyectoInmobiliaria\Views\Inmueble\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Precio));

#line default
#line hidden
            EndContext();
            BeginContext(1331, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1395, 38, false);
#line 47 "C:\Users\Laura\Documents\GitHub\ProyectoInmobiliaria\ProyectoInmobiliaria\Views\Inmueble\Details.cshtml"
       Write(Html.DisplayFor(model => model.Precio));

#line default
#line hidden
            EndContext();
            BeginContext(1433, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1496, 42, false);
#line 50 "C:\Users\Laura\Documents\GitHub\ProyectoInmobiliaria\ProyectoInmobiliaria\Views\Inmueble\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Estado));

#line default
#line hidden
            EndContext();
            BeginContext(1538, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1602, 38, false);
#line 53 "C:\Users\Laura\Documents\GitHub\ProyectoInmobiliaria\ProyectoInmobiliaria\Views\Inmueble\Details.cshtml"
       Write(Html.DisplayFor(model => model.Estado));

#line default
#line hidden
            EndContext();
            BeginContext(1640, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1688, 68, false);
#line 58 "C:\Users\Laura\Documents\GitHub\ProyectoInmobiliaria\ProyectoInmobiliaria\Views\Inmueble\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1756, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1764, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69913310b9eb2e101f7ba7bf5e89c3d3c3a7ce3110545", async() => {
                BeginContext(1786, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1802, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProyectoInmobiliaria.Models.Inmueble> Html { get; private set; }
    }
}
#pragma warning restore 1591