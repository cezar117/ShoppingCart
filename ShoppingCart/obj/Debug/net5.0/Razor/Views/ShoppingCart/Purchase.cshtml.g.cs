#pragma checksum "C:\repositorio_viajaclick\PRUEBAS\ShoppingCart\ShoppingCart\Views\ShoppingCart\Purchase.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "421a9a9acb826b9e1be8bdaa5edf14b976673f40"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ShoppingCart_Purchase), @"mvc.1.0.view", @"/Views/ShoppingCart/Purchase.cshtml")]
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
#line 1 "C:\repositorio_viajaclick\PRUEBAS\ShoppingCart\ShoppingCart\Views\_ViewImports.cshtml"
using ShoppingCart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\repositorio_viajaclick\PRUEBAS\ShoppingCart\ShoppingCart\Views\_ViewImports.cshtml"
using ShoppingCart.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"421a9a9acb826b9e1be8bdaa5edf14b976673f40", @"/Views/ShoppingCart/Purchase.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a65a8198b297c3ea7f3bc4f7f8cdac67c148a265", @"/Views/_ViewImports.cshtml")]
    public class Views_ShoppingCart_Purchase : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShoppingCart.Entities.ShoppingCart>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:70px;height:70px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\repositorio_viajaclick\PRUEBAS\ShoppingCart\ShoppingCart\Views\ShoppingCart\Purchase.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";
    ViewBag.Title = "Shopping Cart";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<br />\r\n\r\n<table class=\"table table-striped\">\r\n    <tr>\r\n        <th>Id</th>\r\n        <th>Nombre </th>\r\n        <th>Precio</th>\r\n        <th>Cantidad</th>\r\n        <th>Imagen</th>\r\n\r\n        <th></th>\r\n    </tr>\r\n");
#nullable restore
#line 20 "C:\repositorio_viajaclick\PRUEBAS\ShoppingCart\ShoppingCart\Views\ShoppingCart\Purchase.cshtml"
     foreach (var item in Model.Items)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 23 "C:\repositorio_viajaclick\PRUEBAS\ShoppingCart\ShoppingCart\Views\ShoppingCart\Purchase.cshtml"
           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "C:\repositorio_viajaclick\PRUEBAS\ShoppingCart\ShoppingCart\Views\ShoppingCart\Purchase.cshtml"
           Write(item.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>$ ");
#nullable restore
#line 25 "C:\repositorio_viajaclick\PRUEBAS\ShoppingCart\ShoppingCart\Views\ShoppingCart\Purchase.cshtml"
             Write(item.Precio);

#line default
#line hidden
#nullable disable
            WriteLiteral("  </td>\r\n            <td>");
#nullable restore
#line 26 "C:\repositorio_viajaclick\PRUEBAS\ShoppingCart\ShoppingCart\Views\ShoppingCart\Purchase.cshtml"
           Write(item.Cantidad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "421a9a9acb826b9e1be8bdaa5edf14b976673f405412", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 616, "~/img/", 616, 6, true);
#nullable restore
#line 27 "C:\repositorio_viajaclick\PRUEBAS\ShoppingCart\ShoppingCart\Views\ShoppingCart\Purchase.cshtml"
AddHtmlAttributeValue("", 622, item.Imagen, 622, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 29 "C:\repositorio_viajaclick\PRUEBAS\ShoppingCart\ShoppingCart\Views\ShoppingCart\Purchase.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <td>TOTAL:</td>\r\n        <td>$ ");
#nullable restore
#line 32 "C:\repositorio_viajaclick\PRUEBAS\ShoppingCart\ShoppingCart\Views\ShoppingCart\Purchase.cshtml"
         Write(ViewBag.totalCompra);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>TOTAL ITEMS:</td>\r\n        <td>");
#nullable restore
#line 36 "C:\repositorio_viajaclick\PRUEBAS\ShoppingCart\ShoppingCart\Views\ShoppingCart\Purchase.cshtml"
       Write(ViewBag.totalItems);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>Fecha de Compra:</td>\r\n        <td>");
#nullable restore
#line 40 "C:\repositorio_viajaclick\PRUEBAS\ShoppingCart\ShoppingCart\Views\ShoppingCart\Purchase.cshtml"
       Write(Model.FechaCompra);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShoppingCart.Entities.ShoppingCart> Html { get; private set; }
    }
}
#pragma warning restore 1591
