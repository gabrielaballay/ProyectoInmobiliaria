#pragma checksum "C:\Users\Gabriel\Desktop\ProyectoInmobiliaria\ProyectoInmobiliaria\ProyectoInmobiliaria\Views\Alquiler\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "888a4dd876844f793796d0c991ec3f975b212d18"
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
#line 1 "C:\Users\Gabriel\Desktop\ProyectoInmobiliaria\ProyectoInmobiliaria\ProyectoInmobiliaria\Views\_ViewImports.cshtml"
using ProyectoInmobiliaria.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"888a4dd876844f793796d0c991ec3f975b212d18", @"/Views/Alquiler/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"119ecc686d10bca0ef1aa9cd4f703abd70a5a8ab", @"/Views/_ViewImports.cshtml")]
    public class Views_Alquiler_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProyectoInmobiliaria.Models.Alquiler>>
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
            BeginContext(58, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Gabriel\Desktop\ProyectoInmobiliaria\ProyectoInmobiliaria\ProyectoInmobiliaria\Views\Alquiler\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(101, 58, true);
            WriteLiteral("\r\n<h4 class=\"mt-2\">Listado de Alquileres</h4>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(159, 77, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "888a4dd876844f793796d0c991ec3f975b212d184209", async() => {
                BeginContext(221, 11, true);
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
            BeginContext(236, 60, true);
            WriteLiteral("\r\n</p>\r\n<span style=\"color:forestgreen\" class=\"text-center\">");
            EndContext();
            BeginContext(297, 15, false);
#line 12 "C:\Users\Gabriel\Desktop\ProyectoInmobiliaria\ProyectoInmobiliaria\ProyectoInmobiliaria\Views\Alquiler\Index.cshtml"
                                               Write(ViewBag.Mensaje);

#line default
#line hidden
            EndContext();
            BeginContext(312, 53, true);
            WriteLiteral("</span>\r\n<span style=\"color:red\" class=\"text-center\">");
            EndContext();
            BeginContext(366, 13, false);
#line 13 "C:\Users\Gabriel\Desktop\ProyectoInmobiliaria\ProyectoInmobiliaria\ProyectoInmobiliaria\Views\Alquiler\Index.cshtml"
                                       Write(ViewBag.Error);

#line default
#line hidden
            EndContext();
            BeginContext(379, 93, true);
            WriteLiteral("</span>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(473, 47, false);
#line 18 "C:\Users\Gabriel\Desktop\ProyectoInmobiliaria\ProyectoInmobiliaria\ProyectoInmobiliaria\Views\Alquiler\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FechaInicio));

#line default
#line hidden
            EndContext();
            BeginContext(520, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(576, 44, false);
#line 21 "C:\Users\Gabriel\Desktop\ProyectoInmobiliaria\ProyectoInmobiliaria\ProyectoInmobiliaria\Views\Alquiler\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FechaFin));

#line default
#line hidden
            EndContext();
            BeginContext(620, 216, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Direccion\r\n            </th>\r\n            <th>\r\n                Inquilino\r\n            </th>\r\n\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 34 "C:\Users\Gabriel\Desktop\ProyectoInmobiliaria\ProyectoInmobiliaria\ProyectoInmobiliaria\Views\Alquiler\Index.cshtml"
         if (Model != null)
        {
            foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(932, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1005, 46, false);
#line 40 "C:\Users\Gabriel\Desktop\ProyectoInmobiliaria\ProyectoInmobiliaria\ProyectoInmobiliaria\Views\Alquiler\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.FechaInicio));

#line default
#line hidden
            EndContext();
            BeginContext(1051, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1131, 43, false);
#line 43 "C:\Users\Gabriel\Desktop\ProyectoInmobiliaria\ProyectoInmobiliaria\ProyectoInmobiliaria\Views\Alquiler\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.FechaFin));

#line default
#line hidden
            EndContext();
            BeginContext(1174, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1254, 49, false);
#line 46 "C:\Users\Gabriel\Desktop\ProyectoInmobiliaria\ProyectoInmobiliaria\ProyectoInmobiliaria\Views\Alquiler\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.casa.Direccion));

#line default
#line hidden
            EndContext();
            BeginContext(1303, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1383, 53, false);
#line 49 "C:\Users\Gabriel\Desktop\ProyectoInmobiliaria\ProyectoInmobiliaria\ProyectoInmobiliaria\Views\Alquiler\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.inquilino.Apellido));

#line default
#line hidden
            EndContext();
            BeginContext(1436, 32, true);
            WriteLiteral("&ensp;\r\n                        ");
            EndContext();
            BeginContext(1469, 51, false);
#line 50 "C:\Users\Gabriel\Desktop\ProyectoInmobiliaria\ProyectoInmobiliaria\ProyectoInmobiliaria\Views\Alquiler\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.inquilino.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(1520, 122, true);
            WriteLiteral("\r\n                    </th>\r\n                    <td>\r\n                        <span class=\"btn-outline-secondary btn-sm\">");
            EndContext();
            BeginContext(1643, 63, false);
#line 53 "C:\Users\Gabriel\Desktop\ProyectoInmobiliaria\ProyectoInmobiliaria\ProyectoInmobiliaria\Views\Alquiler\Index.cshtml"
                                                              Write(Html.ActionLink("Editar", "Edit", new { id = item.IdAlquiler }));

#line default
#line hidden
            EndContext();
            BeginContext(1706, 76, true);
            WriteLiteral("</span> |\r\n                        <span class=\"btn-outline-success btn-sm\">");
            EndContext();
            BeginContext(1783, 67, false);
#line 54 "C:\Users\Gabriel\Desktop\ProyectoInmobiliaria\ProyectoInmobiliaria\ProyectoInmobiliaria\Views\Alquiler\Index.cshtml"
                                                            Write(Html.ActionLink("Detalle", "Details", new { id = item.IdAlquiler }));

#line default
#line hidden
            EndContext();
            BeginContext(1850, 75, true);
            WriteLiteral("</span> |\r\n                        <span class=\"btn-outline-danger btn-sm\">");
            EndContext();
            BeginContext(1926, 65, false);
#line 55 "C:\Users\Gabriel\Desktop\ProyectoInmobiliaria\ProyectoInmobiliaria\ProyectoInmobiliaria\Views\Alquiler\Index.cshtml"
                                                           Write(Html.ActionLink("Borrar", "Delete", new { id = item.IdAlquiler }));

#line default
#line hidden
            EndContext();
            BeginContext(1991, 59, true);
            WriteLiteral("</span>\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 58 "C:\Users\Gabriel\Desktop\ProyectoInmobiliaria\ProyectoInmobiliaria\ProyectoInmobiliaria\Views\Alquiler\Index.cshtml"
            }
        }

#line default
#line hidden
            BeginContext(2076, 24, true);
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