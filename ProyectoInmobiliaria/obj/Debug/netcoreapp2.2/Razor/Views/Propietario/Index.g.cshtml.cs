#pragma checksum "C:\Users\Gabriel\Desktop\ProyectoInmobiliaria\ProyectoInmobiliaria\ProyectoInmobiliaria\Views\Propietario\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cfbe93201bf69eb66c3eb14b061ac61336eb8ace"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Propietario_Index), @"mvc.1.0.view", @"/Views/Propietario/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Propietario/Index.cshtml", typeof(AspNetCore.Views_Propietario_Index))]
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
#line 1 "C:\Users\Gabriel\Desktop\ProyectoInmobiliaria\ProyectoInmobiliaria\ProyectoInmobiliaria\Views\_ViewImports.cshtml"
using ProyectoInmobiliaria.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cfbe93201bf69eb66c3eb14b061ac61336eb8ace", @"/Views/Propietario/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"119ecc686d10bca0ef1aa9cd4f703abd70a5a8ab", @"/Views/_ViewImports.cshtml")]
    public class Views_Propietario_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProyectoInmobiliaria.Models.Propietario>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(61, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Gabriel\Desktop\ProyectoInmobiliaria\ProyectoInmobiliaria\ProyectoInmobiliaria\Views\Propietario\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(104, 36, true);
            WriteLiteral("\r\n<h3>Propietarios</h3>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(140, 77, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cfbe93201bf69eb66c3eb14b061ac61336eb8ace4212", async() => {
                BeginContext(202, 11, true);
                WriteLiteral("Crear Nuevo");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(217, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(310, 42, false);
#line 16 "C:\Users\Gabriel\Desktop\ProyectoInmobiliaria\ProyectoInmobiliaria\ProyectoInmobiliaria\Views\Propietario\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(352, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(408, 44, false);
#line 19 "C:\Users\Gabriel\Desktop\ProyectoInmobiliaria\ProyectoInmobiliaria\ProyectoInmobiliaria\Views\Propietario\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Apellido));

#line default
#line hidden
            EndContext();
            BeginContext(452, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(508, 39, false);
#line 22 "C:\Users\Gabriel\Desktop\ProyectoInmobiliaria\ProyectoInmobiliaria\ProyectoInmobiliaria\Views\Propietario\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Dni));

#line default
#line hidden
            EndContext();
            BeginContext(547, 100, true);
            WriteLiteral("\r\n            </th>\r\n            \r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 29 "C:\Users\Gabriel\Desktop\ProyectoInmobiliaria\ProyectoInmobiliaria\ProyectoInmobiliaria\Views\Propietario\Index.cshtml"
 foreach (var item in Model) {
    

#line default
#line hidden
            BeginContext(685, 58, true);
            WriteLiteral("        <tr>          \r\n            <td>\r\n                ");
            EndContext();
            BeginContext(744, 41, false);
#line 33 "C:\Users\Gabriel\Desktop\ProyectoInmobiliaria\ProyectoInmobiliaria\ProyectoInmobiliaria\Views\Propietario\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(785, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(841, 43, false);
#line 36 "C:\Users\Gabriel\Desktop\ProyectoInmobiliaria\ProyectoInmobiliaria\ProyectoInmobiliaria\Views\Propietario\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Apellido));

#line default
#line hidden
            EndContext();
            BeginContext(884, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(940, 38, false);
#line 39 "C:\Users\Gabriel\Desktop\ProyectoInmobiliaria\ProyectoInmobiliaria\ProyectoInmobiliaria\Views\Propietario\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Dni));

#line default
#line hidden
            EndContext();
            BeginContext(978, 112, true);
            WriteLiteral("\r\n            </td>\r\n            \r\n            <td>\r\n                <span class=\"btn-outline-secondary btn-sm\">");
            EndContext();
            BeginContext(1091, 64, false);
#line 43 "C:\Users\Gabriel\Desktop\ProyectoInmobiliaria\ProyectoInmobiliaria\ProyectoInmobiliaria\Views\Propietario\Index.cshtml"
                                                      Write(Html.ActionLink("Edit", "Edit", new { id = item.IdPropietario }));

#line default
#line hidden
            EndContext();
            BeginContext(1155, 68, true);
            WriteLiteral("</span> |\r\n                <span class=\"btn-outline-success btn-sm\">");
            EndContext();
            BeginContext(1224, 70, false);
#line 44 "C:\Users\Gabriel\Desktop\ProyectoInmobiliaria\ProyectoInmobiliaria\ProyectoInmobiliaria\Views\Propietario\Index.cshtml"
                                                    Write(Html.ActionLink("Details", "Details", new { id = item.IdPropietario }));

#line default
#line hidden
            EndContext();
            BeginContext(1294, 67, true);
            WriteLiteral("</span> |\r\n                <span class=\"btn-outline-danger btn-sm\">");
            EndContext();
            BeginContext(1362, 68, false);
#line 45 "C:\Users\Gabriel\Desktop\ProyectoInmobiliaria\ProyectoInmobiliaria\ProyectoInmobiliaria\Views\Propietario\Index.cshtml"
                                                   Write(Html.ActionLink("Delete", "Delete", new { id = item.IdPropietario }));

#line default
#line hidden
            EndContext();
            BeginContext(1430, 31, true);
            WriteLiteral("</span>\r\n</td>\r\n        </tr>\r\n");
            EndContext();
#line 48 "C:\Users\Gabriel\Desktop\ProyectoInmobiliaria\ProyectoInmobiliaria\ProyectoInmobiliaria\Views\Propietario\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1464, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProyectoInmobiliaria.Models.Propietario>> Html { get; private set; }
    }
}
#pragma warning restore 1591
