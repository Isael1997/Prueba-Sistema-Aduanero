#pragma checksum "C:\Users\gp\Documents\ITLA\Administracion de  Proyectos de Software\Proyecto\Pruebas\WebApplication2\WebApplication2\Views\Clientes\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0140f0d18a19978e993fd2a0a6122990eccf850e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clientes_Details), @"mvc.1.0.view", @"/Views/Clientes/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Clientes/Details.cshtml", typeof(AspNetCore.Views_Clientes_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0140f0d18a19978e993fd2a0a6122990eccf850e", @"/Views/Clientes/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b36aee4455a440795f240a74431c307640c545e", @"/Views/_ViewImports.cshtml")]
    public class Views_Clientes_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication2.Models.Clientes>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(40, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\gp\Documents\ITLA\Administracion de  Proyectos de Software\Proyecto\Pruebas\WebApplication2\WebApplication2\Views\Clientes\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(85, 122, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Clientes</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(208, 43, false);
#line 14 "C:\Users\gp\Documents\ITLA\Administracion de  Proyectos de Software\Proyecto\Pruebas\WebApplication2\WebApplication2\Views\Clientes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Nombres));

#line default
#line hidden
            EndContext();
            BeginContext(251, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(295, 39, false);
#line 17 "C:\Users\gp\Documents\ITLA\Administracion de  Proyectos de Software\Proyecto\Pruebas\WebApplication2\WebApplication2\Views\Clientes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Nombres));

#line default
#line hidden
            EndContext();
            BeginContext(334, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(378, 45, false);
#line 20 "C:\Users\gp\Documents\ITLA\Administracion de  Proyectos de Software\Proyecto\Pruebas\WebApplication2\WebApplication2\Views\Clientes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Apellidos));

#line default
#line hidden
            EndContext();
            BeginContext(423, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(467, 41, false);
#line 23 "C:\Users\gp\Documents\ITLA\Administracion de  Proyectos de Software\Proyecto\Pruebas\WebApplication2\WebApplication2\Views\Clientes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Apellidos));

#line default
#line hidden
            EndContext();
            BeginContext(508, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(552, 43, false);
#line 26 "C:\Users\gp\Documents\ITLA\Administracion de  Proyectos de Software\Proyecto\Pruebas\WebApplication2\WebApplication2\Views\Clientes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Empresa));

#line default
#line hidden
            EndContext();
            BeginContext(595, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(639, 39, false);
#line 29 "C:\Users\gp\Documents\ITLA\Administracion de  Proyectos de Software\Proyecto\Pruebas\WebApplication2\WebApplication2\Views\Clientes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Empresa));

#line default
#line hidden
            EndContext();
            BeginContext(678, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(722, 45, false);
#line 32 "C:\Users\gp\Documents\ITLA\Administracion de  Proyectos de Software\Proyecto\Pruebas\WebApplication2\WebApplication2\Views\Clientes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Provincia));

#line default
#line hidden
            EndContext();
            BeginContext(767, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(811, 41, false);
#line 35 "C:\Users\gp\Documents\ITLA\Administracion de  Proyectos de Software\Proyecto\Pruebas\WebApplication2\WebApplication2\Views\Clientes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Provincia));

#line default
#line hidden
            EndContext();
            BeginContext(852, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(896, 45, false);
#line 38 "C:\Users\gp\Documents\ITLA\Administracion de  Proyectos de Software\Proyecto\Pruebas\WebApplication2\WebApplication2\Views\Clientes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Municipio));

#line default
#line hidden
            EndContext();
            BeginContext(941, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(985, 41, false);
#line 41 "C:\Users\gp\Documents\ITLA\Administracion de  Proyectos de Software\Proyecto\Pruebas\WebApplication2\WebApplication2\Views\Clientes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Municipio));

#line default
#line hidden
            EndContext();
            BeginContext(1026, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1070, 41, false);
#line 44 "C:\Users\gp\Documents\ITLA\Administracion de  Proyectos de Software\Proyecto\Pruebas\WebApplication2\WebApplication2\Views\Clientes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Calle));

#line default
#line hidden
            EndContext();
            BeginContext(1111, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1155, 37, false);
#line 47 "C:\Users\gp\Documents\ITLA\Administracion de  Proyectos de Software\Proyecto\Pruebas\WebApplication2\WebApplication2\Views\Clientes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Calle));

#line default
#line hidden
            EndContext();
            BeginContext(1192, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1236, 42, false);
#line 50 "C:\Users\gp\Documents\ITLA\Administracion de  Proyectos de Software\Proyecto\Pruebas\WebApplication2\WebApplication2\Views\Clientes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Sector));

#line default
#line hidden
            EndContext();
            BeginContext(1278, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1322, 38, false);
#line 53 "C:\Users\gp\Documents\ITLA\Administracion de  Proyectos de Software\Proyecto\Pruebas\WebApplication2\WebApplication2\Views\Clientes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Sector));

#line default
#line hidden
            EndContext();
            BeginContext(1360, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1404, 43, false);
#line 56 "C:\Users\gp\Documents\ITLA\Administracion de  Proyectos de Software\Proyecto\Pruebas\WebApplication2\WebApplication2\Views\Clientes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Usuario));

#line default
#line hidden
            EndContext();
            BeginContext(1447, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1491, 39, false);
#line 59 "C:\Users\gp\Documents\ITLA\Administracion de  Proyectos de Software\Proyecto\Pruebas\WebApplication2\WebApplication2\Views\Clientes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Usuario));

#line default
#line hidden
            EndContext();
            BeginContext(1530, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1574, 46, false);
#line 62 "C:\Users\gp\Documents\ITLA\Administracion de  Proyectos de Software\Proyecto\Pruebas\WebApplication2\WebApplication2\Views\Clientes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Contraseña));

#line default
#line hidden
            EndContext();
            BeginContext(1620, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1664, 42, false);
#line 65 "C:\Users\gp\Documents\ITLA\Administracion de  Proyectos de Software\Proyecto\Pruebas\WebApplication2\WebApplication2\Views\Clientes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Contraseña));

#line default
#line hidden
            EndContext();
            BeginContext(1706, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1750, 43, false);
#line 68 "C:\Users\gp\Documents\ITLA\Administracion de  Proyectos de Software\Proyecto\Pruebas\WebApplication2\WebApplication2\Views\Clientes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Estatus));

#line default
#line hidden
            EndContext();
            BeginContext(1793, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1837, 39, false);
#line 71 "C:\Users\gp\Documents\ITLA\Administracion de  Proyectos de Software\Proyecto\Pruebas\WebApplication2\WebApplication2\Views\Clientes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Estatus));

#line default
#line hidden
            EndContext();
            BeginContext(1876, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1923, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7006f009e5da4396ba060e0d9cd52fc9", async() => {
                BeginContext(1969, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 76 "C:\Users\gp\Documents\ITLA\Administracion de  Proyectos de Software\Proyecto\Pruebas\WebApplication2\WebApplication2\Views\Clientes\Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1977, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1985, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fa251f0cd5434834b4183515e169de2b", async() => {
                BeginContext(2007, 12, true);
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
            BeginContext(2023, 10, true);
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
