#pragma checksum "C:\Users\danie\Downloads\Down\ECCE_TOPV18.05.2\ECCE_TOPV18.05.2\ECCE\ECCE\Views\Pedido\ItensPedido.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c03c406c6639dd25ceb9327bdcf67dcd5b16a740"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pedido_ItensPedido), @"mvc.1.0.view", @"/Views/Pedido/ItensPedido.cshtml")]
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
#line 1 "C:\Users\danie\Downloads\Down\ECCE_TOPV18.05.2\ECCE_TOPV18.05.2\ECCE\ECCE\Views\_ViewImports.cshtml"
using ECCE;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\danie\Downloads\Down\ECCE_TOPV18.05.2\ECCE_TOPV18.05.2\ECCE\ECCE\Views\_ViewImports.cshtml"
using ECCE.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c03c406c6639dd25ceb9327bdcf67dcd5b16a740", @"/Views/Pedido/ItensPedido.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac77d2a601f4d58340855bb0b07dde3ca55643c1", @"/Views/_ViewImports.cshtml")]
    public class Views_Pedido_ItensPedido : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ItensVenda>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\danie\Downloads\Down\ECCE_TOPV18.05.2\ECCE_TOPV18.05.2\ECCE\ECCE\Views\Pedido\ItensPedido.cshtml"
                ViewData["Title"] = "Itens da Compra";

                Layout = "_Layout_dashboard"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("<hr />\n<h4 class=\"font-weight-bold\">Lista de Itens da Venda</h4>\n<hr />\n<div>\n\n");
#nullable restore
#line 11 "C:\Users\danie\Downloads\Down\ECCE_TOPV18.05.2\ECCE_TOPV18.05.2\ECCE\ECCE\Views\Pedido\ItensPedido.cshtml"
     if (Model.Count > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<table class=""table table-striped table-sm"">
    <thead class=""thead-dark"">
        <tr>
            <th></th>
            <th>Venda</th>
            <th>Código do Produto</th>
            <th>Produto</th>
            <th>Tamanho</th>
            <th>Quantidade</th>
            <th>Valor</th>
            <th>Data</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 27 "C:\Users\danie\Downloads\Down\ECCE_TOPV18.05.2\ECCE_TOPV18.05.2\ECCE\ECCE\Views\Pedido\ItensPedido.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\n    <td></td>\n    <td>");
#nullable restore
#line 31 "C:\Users\danie\Downloads\Down\ECCE_TOPV18.05.2\ECCE_TOPV18.05.2\ECCE\ECCE\Views\Pedido\ItensPedido.cshtml"
   Write(item.CodigoVenda);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 32 "C:\Users\danie\Downloads\Down\ECCE_TOPV18.05.2\ECCE_TOPV18.05.2\ECCE\ECCE\Views\Pedido\ItensPedido.cshtml"
   Write(item.CodigoInterno);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 33 "C:\Users\danie\Downloads\Down\ECCE_TOPV18.05.2\ECCE_TOPV18.05.2\ECCE\ECCE\Views\Pedido\ItensPedido.cshtml"
   Write(item.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 34 "C:\Users\danie\Downloads\Down\ECCE_TOPV18.05.2\ECCE_TOPV18.05.2\ECCE\ECCE\Views\Pedido\ItensPedido.cshtml"
   Write(item.Tamanho);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 35 "C:\Users\danie\Downloads\Down\ECCE_TOPV18.05.2\ECCE_TOPV18.05.2\ECCE\ECCE\Views\Pedido\ItensPedido.cshtml"
   Write(item.Quantidade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 36 "C:\Users\danie\Downloads\Down\ECCE_TOPV18.05.2\ECCE_TOPV18.05.2\ECCE\ECCE\Views\Pedido\ItensPedido.cshtml"
   Write(item.Valor.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 37 "C:\Users\danie\Downloads\Down\ECCE_TOPV18.05.2\ECCE_TOPV18.05.2\ECCE\ECCE\Views\Pedido\ItensPedido.cshtml"
   Write(item.Data);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n</tr>");
#nullable restore
#line 38 "C:\Users\danie\Downloads\Down\ECCE_TOPV18.05.2\ECCE_TOPV18.05.2\ECCE\ECCE\Views\Pedido\ItensPedido.cshtml"
     }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table> ");
#nullable restore
#line 40 "C:\Users\danie\Downloads\Down\ECCE_TOPV18.05.2\ECCE_TOPV18.05.2\ECCE\ECCE\Views\Pedido\ItensPedido.cshtml"
         }
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"alert alert-primary\" role=\"alert\">\n    Sem Registros!\n</div>");
#nullable restore
#line 45 "C:\Users\danie\Downloads\Down\ECCE_TOPV18.05.2\ECCE_TOPV18.05.2\ECCE\ECCE\Views\Pedido\ItensPedido.cshtml"
      }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    <button type=\"button\" class=\"btn btn-warning btn-sm\" onclick=\"window.location.href=\'/pedido\'\">Voltar</button>\n\n</div>\n\n\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ItensVenda>> Html { get; private set; }
    }
}
#pragma warning restore 1591