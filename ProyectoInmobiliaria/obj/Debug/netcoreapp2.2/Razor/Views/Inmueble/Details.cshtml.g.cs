#pragma checksum "C:\Users\Laura\Documents\GitHub\ProyectoInmobiliaria\ProyectoInmobiliaria\Views\Inmueble\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ea8f9bf9cdb1f3686497ec2290104a89289b3b7"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ea8f9bf9cdb1f3686497ec2290104a89289b3b7", @"/Views/Inmueble/Details.cshtml")]
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
            BeginContext(90, 129, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Inmueble</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-3\">\r\n            ");
            EndContext();
            BeginContext(220, 45, false);
#line 14 "C:\Users\Laura\Documents\GitHub\ProyectoInmobiliaria\ProyectoInmobiliaria\Views\Inmueble\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Direccion));

#line default
#line hidden
            EndContext();
            BeginContext(265, 60, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-9\">\r\n            ");
            EndContext();
            BeginContext(326, 41, false);
#line 17 "C:\Users\Laura\Documents\GitHub\ProyectoInmobiliaria\ProyectoInmobiliaria\Views\Inmueble\Details.cshtml"
       Write(Html.DisplayFor(model => model.Direccion));

#line default
#line hidden
            EndContext();
            BeginContext(367, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-3\">\r\n            ");
            EndContext();
            BeginContext(428, 39, false);
#line 20 "C:\Users\Laura\Documents\GitHub\ProyectoInmobiliaria\ProyectoInmobiliaria\Views\Inmueble\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Uso));

#line default
#line hidden
            EndContext();
            BeginContext(467, 60, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-9\">\r\n            ");
            EndContext();
            BeginContext(528, 35, false);
#line 23 "C:\Users\Laura\Documents\GitHub\ProyectoInmobiliaria\ProyectoInmobiliaria\Views\Inmueble\Details.cshtml"
       Write(Html.DisplayFor(model => model.Uso));

#line default
#line hidden
            EndContext();
            BeginContext(563, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-3\">\r\n            ");
            EndContext();
            BeginContext(624, 40, false);
#line 26 "C:\Users\Laura\Documents\GitHub\ProyectoInmobiliaria\ProyectoInmobiliaria\Views\Inmueble\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Tipo));

#line default
#line hidden
            EndContext();
            BeginContext(664, 60, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-9\">\r\n            ");
            EndContext();
            BeginContext(725, 36, false);
#line 29 "C:\Users\Laura\Documents\GitHub\ProyectoInmobiliaria\ProyectoInmobiliaria\Views\Inmueble\Details.cshtml"
       Write(Html.DisplayFor(model => model.Tipo));

#line default
#line hidden
            EndContext();
            BeginContext(761, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-3\">\r\n            ");
            EndContext();
            BeginContext(822, 56, false);
#line 32 "C:\Users\Laura\Documents\GitHub\ProyectoInmobiliaria\ProyectoInmobiliaria\Views\Inmueble\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CantidadHabitaciones));

#line default
#line hidden
            EndContext();
            BeginContext(878, 60, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-9\">\r\n            ");
            EndContext();
            BeginContext(939, 52, false);
#line 35 "C:\Users\Laura\Documents\GitHub\ProyectoInmobiliaria\ProyectoInmobiliaria\Views\Inmueble\Details.cshtml"
       Write(Html.DisplayFor(model => model.CantidadHabitaciones));

#line default
#line hidden
            EndContext();
            BeginContext(991, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-3\">\r\n            ");
            EndContext();
            BeginContext(1052, 42, false);
#line 38 "C:\Users\Laura\Documents\GitHub\ProyectoInmobiliaria\ProyectoInmobiliaria\Views\Inmueble\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Precio));

#line default
#line hidden
            EndContext();
            BeginContext(1094, 60, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-9\">\r\n            ");
            EndContext();
            BeginContext(1155, 38, false);
#line 41 "C:\Users\Laura\Documents\GitHub\ProyectoInmobiliaria\ProyectoInmobiliaria\Views\Inmueble\Details.cshtml"
       Write(Html.DisplayFor(model => model.Precio));

#line default
#line hidden
            EndContext();
            BeginContext(1193, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-3\">\r\n            ");
            EndContext();
            BeginContext(1254, 42, false);
#line 44 "C:\Users\Laura\Documents\GitHub\ProyectoInmobiliaria\ProyectoInmobiliaria\Views\Inmueble\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Estado));

#line default
#line hidden
            EndContext();
            BeginContext(1296, 60, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-9\">\r\n            ");
            EndContext();
            BeginContext(1357, 38, false);
#line 47 "C:\Users\Laura\Documents\GitHub\ProyectoInmobiliaria\ProyectoInmobiliaria\Views\Inmueble\Details.cshtml"
       Write(Html.DisplayFor(model => model.Estado));

#line default
#line hidden
            EndContext();
            BeginContext(1395, 135, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-3\">\r\n                Propietario\r\n        </dt>\r\n        <dd class=\"col-sm-9\">\r\n            ");
            EndContext();
            BeginContext(1531, 47, false);
#line 53 "C:\Users\Laura\Documents\GitHub\ProyectoInmobiliaria\ProyectoInmobiliaria\Views\Inmueble\Details.cshtml"
       Write(Html.DisplayFor(model => model.Duenio.Apellido));

#line default
#line hidden
            EndContext();
            BeginContext(1578, 20, true);
            WriteLiteral("&ensp;\r\n            ");
            EndContext();
            BeginContext(1599, 45, false);
#line 54 "C:\Users\Laura\Documents\GitHub\ProyectoInmobiliaria\ProyectoInmobiliaria\Views\Inmueble\Details.cshtml"
       Write(Html.DisplayFor(model => model.Duenio.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(1644, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1692, 62, false);
#line 59 "C:\Users\Laura\Documents\GitHub\ProyectoInmobiliaria\ProyectoInmobiliaria\Views\Inmueble\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { id = Model.IdInmueble }));

#line default
#line hidden
            EndContext();
            BeginContext(1754, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1762, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ea8f9bf9cdb1f3686497ec2290104a89289b3b710546", async() => {
                BeginContext(1784, 12, true);
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
            BeginContext(1800, 10, true);
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