#pragma checksum "C:\Users\Laura\Documents\GitHub\ProyectoInmobiliaria\ProyectoInmobiliaria\Views\Alquiler\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d826943245f15248a3b7bb80fd5607b38dd0bac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Alquiler_Index), @"mvc.1.0.view", @"/Views/Alquiler/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Alquiler/Index.cshtml", typeof(AspNetCore.Views_Alquiler_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d826943245f15248a3b7bb80fd5607b38dd0bac", @"/Views/Alquiler/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"119ecc686d10bca0ef1aa9cd4f703abd70a5a8ab", @"/Views/_ViewImports.cshtml")]
    public class Views_Alquiler_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProyectoInmobiliaria.Models.Alquiler>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(58, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Laura\Documents\GitHub\ProyectoInmobiliaria\ProyectoInmobiliaria\Views\Alquiler\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(101, 45, true);
            WriteLiteral("\r\n<h3>Listado de Alquileres</h3>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(146, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d826943245f15248a3b7bb80fd5607b38dd0bac3782", async() => {
                BeginContext(169, 10, true);
                WriteLiteral("Create New");
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
            BeginContext(183, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(276, 46, false);
#line 16 "C:\Users\Laura\Documents\GitHub\ProyectoInmobiliaria\ProyectoInmobiliaria\Views\Alquiler\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IdAlquiler));

#line default
#line hidden
            EndContext();
            BeginContext(322, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(378, 47, false);
#line 19 "C:\Users\Laura\Documents\GitHub\ProyectoInmobiliaria\ProyectoInmobiliaria\Views\Alquiler\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FechaInicio));

#line default
#line hidden
            EndContext();
            BeginContext(425, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(481, 44, false);
#line 22 "C:\Users\Laura\Documents\GitHub\ProyectoInmobiliaria\ProyectoInmobiliaria\Views\Alquiler\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FechaFin));

#line default
#line hidden
            EndContext();
            BeginContext(525, 216, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Direccion\r\n            </th>\r\n            <th>\r\n                Inquilino\r\n            </th>\r\n\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 35 "C:\Users\Laura\Documents\GitHub\ProyectoInmobiliaria\ProyectoInmobiliaria\Views\Alquiler\Index.cshtml"
 if (Model != null)
{
    foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(805, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(854, 45, false);
#line 41 "C:\Users\Laura\Documents\GitHub\ProyectoInmobiliaria\ProyectoInmobiliaria\Views\Alquiler\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IdAlquiler));

#line default
#line hidden
            EndContext();
            BeginContext(899, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(955, 46, false);
#line 44 "C:\Users\Laura\Documents\GitHub\ProyectoInmobiliaria\ProyectoInmobiliaria\Views\Alquiler\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FechaInicio));

#line default
#line hidden
            EndContext();
            BeginContext(1001, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1057, 43, false);
#line 47 "C:\Users\Laura\Documents\GitHub\ProyectoInmobiliaria\ProyectoInmobiliaria\Views\Alquiler\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FechaFin));

#line default
#line hidden
            EndContext();
            BeginContext(1100, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1156, 49, false);
#line 50 "C:\Users\Laura\Documents\GitHub\ProyectoInmobiliaria\ProyectoInmobiliaria\Views\Alquiler\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.casa.Direccion));

#line default
#line hidden
            EndContext();
            BeginContext(1205, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1261, 53, false);
#line 53 "C:\Users\Laura\Documents\GitHub\ProyectoInmobiliaria\ProyectoInmobiliaria\Views\Alquiler\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.inquilino.Apellido));

#line default
#line hidden
            EndContext();
            BeginContext(1314, 24, true);
            WriteLiteral("&ensp;\r\n                ");
            EndContext();
            BeginContext(1339, 53, false);
#line 54 "C:\Users\Laura\Documents\GitHub\ProyectoInmobiliaria\ProyectoInmobiliaria\Views\Alquiler\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.inquilino.Apellido));

#line default
#line hidden
            EndContext();
            BeginContext(1392, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1448, 59, false);
#line 57 "C:\Users\Laura\Documents\GitHub\ProyectoInmobiliaria\ProyectoInmobiliaria\Views\Alquiler\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { id=item.IdAlquiler }));

#line default
#line hidden
            EndContext();
            BeginContext(1507, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1528, 65, false);
#line 58 "C:\Users\Laura\Documents\GitHub\ProyectoInmobiliaria\ProyectoInmobiliaria\Views\Alquiler\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { id=item.IdAlquiler }));

#line default
#line hidden
            EndContext();
            BeginContext(1593, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1614, 63, false);
#line 59 "C:\Users\Laura\Documents\GitHub\ProyectoInmobiliaria\ProyectoInmobiliaria\Views\Alquiler\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { id=item.IdAlquiler }));

#line default
#line hidden
            EndContext();
            BeginContext(1677, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 62 "C:\Users\Laura\Documents\GitHub\ProyectoInmobiliaria\ProyectoInmobiliaria\Views\Alquiler\Index.cshtml"
    }
}

#line default
#line hidden
            BeginContext(1723, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProyectoInmobiliaria.Models.Alquiler>> Html { get; private set; }
    }
}
#pragma warning restore 1591
