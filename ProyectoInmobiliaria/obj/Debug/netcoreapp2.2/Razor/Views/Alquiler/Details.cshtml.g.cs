#pragma checksum "C:\Users\Laura\Documents\GitHub\ProyectoInmobiliaria\ProyectoInmobiliaria\Views\Alquiler\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "045eb18ba74722ac27a0f8c49e3b84c2a95d0255"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Alquiler_Details), @"mvc.1.0.view", @"/Views/Alquiler/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Alquiler/Details.cshtml", typeof(AspNetCore.Views_Alquiler_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"045eb18ba74722ac27a0f8c49e3b84c2a95d0255", @"/Views/Alquiler/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"119ecc686d10bca0ef1aa9cd4f703abd70a5a8ab", @"/Views/_ViewImports.cshtml")]
    public class Views_Alquiler_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProyectoInmobiliaria.Models.Alquiler>
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
#line 3 "C:\Users\Laura\Documents\GitHub\ProyectoInmobiliaria\ProyectoInmobiliaria\Views\Alquiler\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(90, 129, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Alquiler</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(220, 46, false);
#line 14 "C:\Users\Laura\Documents\GitHub\ProyectoInmobiliaria\ProyectoInmobiliaria\Views\Alquiler\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IdAlquiler));

#line default
#line hidden
            EndContext();
            BeginContext(266, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(328, 42, false);
#line 17 "C:\Users\Laura\Documents\GitHub\ProyectoInmobiliaria\ProyectoInmobiliaria\Views\Alquiler\Details.cshtml"
       Write(Html.DisplayFor(model => model.IdAlquiler));

#line default
#line hidden
            EndContext();
            BeginContext(370, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(431, 47, false);
#line 20 "C:\Users\Laura\Documents\GitHub\ProyectoInmobiliaria\ProyectoInmobiliaria\Views\Alquiler\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FechaInicio));

#line default
#line hidden
            EndContext();
            BeginContext(478, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(540, 43, false);
#line 23 "C:\Users\Laura\Documents\GitHub\ProyectoInmobiliaria\ProyectoInmobiliaria\Views\Alquiler\Details.cshtml"
       Write(Html.DisplayFor(model => model.FechaInicio));

#line default
#line hidden
            EndContext();
            BeginContext(583, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(644, 44, false);
#line 26 "C:\Users\Laura\Documents\GitHub\ProyectoInmobiliaria\ProyectoInmobiliaria\Views\Alquiler\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FechaFin));

#line default
#line hidden
            EndContext();
            BeginContext(688, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(750, 40, false);
#line 29 "C:\Users\Laura\Documents\GitHub\ProyectoInmobiliaria\ProyectoInmobiliaria\Views\Alquiler\Details.cshtml"
       Write(Html.DisplayFor(model => model.FechaFin));

#line default
#line hidden
            EndContext();
            BeginContext(790, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(851, 41, false);
#line 32 "C:\Users\Laura\Documents\GitHub\ProyectoInmobiliaria\ProyectoInmobiliaria\Views\Alquiler\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Monto));

#line default
#line hidden
            EndContext();
            BeginContext(892, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(954, 37, false);
#line 35 "C:\Users\Laura\Documents\GitHub\ProyectoInmobiliaria\ProyectoInmobiliaria\Views\Alquiler\Details.cshtml"
       Write(Html.DisplayFor(model => model.Monto));

#line default
#line hidden
            EndContext();
            BeginContext(991, 130, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Direccion\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1122, 46, false);
#line 41 "C:\Users\Laura\Documents\GitHub\ProyectoInmobiliaria\ProyectoInmobiliaria\Views\Alquiler\Details.cshtml"
       Write(Html.DisplayFor(model => model.casa.Direccion));

#line default
#line hidden
            EndContext();
            BeginContext(1168, 130, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Inquilino\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1299, 50, false);
#line 47 "C:\Users\Laura\Documents\GitHub\ProyectoInmobiliaria\ProyectoInmobiliaria\Views\Alquiler\Details.cshtml"
       Write(Html.DisplayFor(model => model.inquilino.Apellido));

#line default
#line hidden
            EndContext();
            BeginContext(1349, 20, true);
            WriteLiteral("&nbsp;\r\n            ");
            EndContext();
            BeginContext(1370, 48, false);
#line 48 "C:\Users\Laura\Documents\GitHub\ProyectoInmobiliaria\ProyectoInmobiliaria\Views\Alquiler\Details.cshtml"
       Write(Html.DisplayFor(model => model.inquilino.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(1418, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1466, 62, false);
#line 53 "C:\Users\Laura\Documents\GitHub\ProyectoInmobiliaria\ProyectoInmobiliaria\Views\Alquiler\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { id = Model.IdAlquiler }));

#line default
#line hidden
            EndContext();
            BeginContext(1528, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1536, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "045eb18ba74722ac27a0f8c49e3b84c2a95d02559300", async() => {
                BeginContext(1558, 12, true);
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
            BeginContext(1574, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProyectoInmobiliaria.Models.Alquiler> Html { get; private set; }
    }
}
#pragma warning restore 1591
