#pragma checksum "C:\Users\gp\Documents\ITLA\Administracion de  Proyectos de Software\Proyecto\Pruebas\WebApplication2\WebApplication2\Views\Clientes\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47d819adf9741099c824c5046c39727a46896e70"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clientes_Delete), @"mvc.1.0.view", @"/Views/Clientes/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Clientes/Delete.cshtml", typeof(AspNetCore.Views_Clientes_Delete))]
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
#line 1 "C:\Users\gp\Documents\ITLA\Administracion de  Proyectos de Software\Proyecto\Pruebas\WebApplication2\WebApplication2\Views\_ViewImports.cshtml"
using WebApplication2;

#line default
#line hidden
#line 2 "C:\Users\gp\Documents\ITLA\Administracion de  Proyectos de Software\Proyecto\Pruebas\WebApplication2\WebApplication2\Views\_ViewImports.cshtml"
using WebApplication2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47d819adf9741099c824c5046c39727a46896e70", @"/Views/Clientes/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b36aee4455a440795f240a74431c307640c545e", @"/Views/_ViewImports.cshtml")]
    public class Views_Clientes_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication2.Models.Clientes>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(40, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\gp\Documents\ITLA\Administracion de  Proyectos de Software\Proyecto\Pruebas\WebApplication2\WebApplication2\Views\Clientes\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(84, 169, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Clientes</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(254, 43, false);
#line 15 "C:\Users\gp\Documents\ITLA\Administracion de  Proyectos de Software\Proyecto\Pruebas\WebApplication2\WebApplication2\Views\Clientes\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Nombres));

#line default
#line hidden
            EndContext();
            BeginContext(297, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(341, 39, false);
#line 18 "C:\Users\gp\Documents\ITLA\Administracion de  Proyectos de Software\Proyecto\Pruebas\WebApplication2\WebApplication2\Views\Clientes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Nombres));

#line default
#line hidden
            EndContext();
            BeginContext(380, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(424, 45, false);
#line 21 "C:\Users\gp\Documents\ITLA\Administracion de  Proyectos de Software\Proyecto\Pruebas\WebApplication2\WebApplication2\Views\Clientes\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Apellidos));

#line default
#line hidden
            EndContext();
            BeginContext(469, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(513, 41, false);
#line 24 "C:\Users\gp\Documents\ITLA\Administracion de  Proyectos de Software\Proyecto\Pruebas\WebApplication2\WebApplication2\Views\Clientes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Apellidos));

#line default
#line hidden
            EndContext();
            BeginContext(554, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(598, 43, false);
#line 27 "C:\Users\gp\Documents\ITLA\Administracion de  Proyectos de Software\Proyecto\Pruebas\WebApplication2\WebApplication2\Views\Clientes\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Empresa));

#line default
#line hidden
            EndContext();
            BeginContext(641, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(685, 39, false);
#line 30 "C:\Users\gp\Documents\ITLA\Administracion de  Proyectos de Software\Proyecto\Pruebas\WebApplication2\WebApplication2\Views\Clientes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Empresa));

#line default
#line hidden
            EndContext();
            BeginContext(724, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(768, 45, false);
#line 33 "C:\Users\gp\Documents\ITLA\Administracion de  Proyectos de Software\Proyecto\Pruebas\WebApplication2\WebApplication2\Views\Clientes\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Provincia));

#line default
#line hidden
            EndContext();
            BeginContext(813, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(857, 41, false);
#line 36 "C:\Users\gp\Documents\ITLA\Administracion de  Proyectos de Software\Proyecto\Pruebas\WebApplication2\WebApplication2\Views\Clientes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Provincia));

#line default
#line hidden
            EndContext();
            BeginContext(898, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(942, 45, false);
#line 39 "C:\Users\gp\Documents\ITLA\Administracion de  Proyectos de Software\Proyecto\Pruebas\WebApplication2\WebApplication2\Views\Clientes\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Municipio));

#line default
#line hidden
            EndContext();
            BeginContext(987, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1031, 41, false);
#line 42 "C:\Users\gp\Documents\ITLA\Administracion de  Proyectos de Software\Proyecto\Pruebas\WebApplication2\WebApplication2\Views\Clientes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Municipio));

#line default
#line hidden
            EndContext();
            BeginContext(1072, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1116, 41, false);
#line 45 "C:\Users\gp\Documents\ITLA\Administracion de  Proyectos de Software\Proyecto\Pruebas\WebApplication2\WebApplication2\Views\Clientes\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Calle));

#line default
#line hidden
            EndContext();
            BeginContext(1157, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1201, 37, false);
#line 48 "C:\Users\gp\Documents\ITLA\Administracion de  Proyectos de Software\Proyecto\Pruebas\WebApplication2\WebApplication2\Views\Clientes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Calle));

#line default
#line hidden
            EndContext();
            BeginContext(1238, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1282, 42, false);
#line 51 "C:\Users\gp\Documents\ITLA\Administracion de  Proyectos de Software\Proyecto\Pruebas\WebApplication2\WebApplication2\Views\Clientes\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Sector));

#line default
#line hidden
            EndContext();
            BeginContext(1324, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1368, 38, false);
#line 54 "C:\Users\gp\Documents\ITLA\Administracion de  Proyectos de Software\Proyecto\Pruebas\WebApplication2\WebApplication2\Views\Clientes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Sector));

#line default
#line hidden
            EndContext();
            BeginContext(1406, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1450, 43, false);
#line 57 "C:\Users\gp\Documents\ITLA\Administracion de  Proyectos de Software\Proyecto\Pruebas\WebApplication2\WebApplication2\Views\Clientes\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Usuario));

#line default
#line hidden
            EndContext();
            BeginContext(1493, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1537, 39, false);
#line 60 "C:\Users\gp\Documents\ITLA\Administracion de  Proyectos de Software\Proyecto\Pruebas\WebApplication2\WebApplication2\Views\Clientes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Usuario));

#line default
#line hidden
            EndContext();
            BeginContext(1576, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1620, 46, false);
#line 63 "C:\Users\gp\Documents\ITLA\Administracion de  Proyectos de Software\Proyecto\Pruebas\WebApplication2\WebApplication2\Views\Clientes\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Contraseña));

#line default
#line hidden
            EndContext();
            BeginContext(1666, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1710, 42, false);
#line 66 "C:\Users\gp\Documents\ITLA\Administracion de  Proyectos de Software\Proyecto\Pruebas\WebApplication2\WebApplication2\Views\Clientes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Contraseña));

#line default
#line hidden
            EndContext();
            BeginContext(1752, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1796, 43, false);
#line 69 "C:\Users\gp\Documents\ITLA\Administracion de  Proyectos de Software\Proyecto\Pruebas\WebApplication2\WebApplication2\Views\Clientes\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Estatus));

#line default
#line hidden
            EndContext();
            BeginContext(1839, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1883, 39, false);
#line 72 "C:\Users\gp\Documents\ITLA\Administracion de  Proyectos de Software\Proyecto\Pruebas\WebApplication2\WebApplication2\Views\Clientes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Estatus));

#line default
#line hidden
            EndContext();
            BeginContext(1922, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(1960, 207, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76446d363c344082841b367a4242f039", async() => {
                BeginContext(1986, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1996, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "db2dc75359e04973a9c259e785a856d3", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 77 "C:\Users\gp\Documents\ITLA\Administracion de  Proyectos de Software\Proyecto\Pruebas\WebApplication2\WebApplication2\Views\Clientes\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2032, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(2116, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d1f5569c619c42e4973e3de0617adaae", async() => {
                    BeginContext(2138, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2154, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2167, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication2.Models.Clientes> Html { get; private set; }
    }
}
#pragma warning restore 1591