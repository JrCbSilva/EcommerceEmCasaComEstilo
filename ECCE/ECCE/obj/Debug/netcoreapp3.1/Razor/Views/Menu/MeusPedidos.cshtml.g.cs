#pragma checksum "C:\Users\danie\Desktop\Fac\ECCE_TOPV21\ECCE\ECCE\Views\Menu\MeusPedidos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e4bfd43ece26d9ac600b86f818b9fcb99e3e261"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Menu_MeusPedidos), @"mvc.1.0.view", @"/Views/Menu/MeusPedidos.cshtml")]
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
#line 1 "C:\Users\danie\Desktop\Fac\ECCE_TOPV21\ECCE\ECCE\Views\_ViewImports.cshtml"
using ECCE;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\danie\Desktop\Fac\ECCE_TOPV21\ECCE\ECCE\Views\_ViewImports.cshtml"
using ECCE.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e4bfd43ece26d9ac600b86f818b9fcb99e3e261", @"/Views/Menu/MeusPedidos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac77d2a601f4d58340855bb0b07dde3ca55643c1", @"/Views/_ViewImports.cshtml")]
    public class Views_Menu_MeusPedidos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<TodosPedidos>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\danie\Desktop\Fac\ECCE_TOPV21\ECCE\ECCE\Views\Menu\MeusPedidos.cshtml"
                ViewData["Title"] = "Genero";
 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .card {
        flex-direction: column;
        text-align: center;
        border: none;
        background: #dcdcdc;
    }
    #tabelasempedido {
  
    }
    </style>
<hr />
<h4 class=""font-weight-bold"">Minhas Compras</h4>
<hr />
<div class=""card"">

");
#nullable restore
#line 22 "C:\Users\danie\Desktop\Fac\ECCE_TOPV21\ECCE\ECCE\Views\Menu\MeusPedidos.cshtml"
     if (Model.Count > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<table class=""table table-striped table-sm"">
    <thead class=""thead-dark"">
        <tr>
            <th>Número da Compra </th>
            <th>Valor</th>
            <th>Data</th>
            <th>Status</th>
            <th>Ver Itens</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 35 "C:\Users\danie\Desktop\Fac\ECCE_TOPV21\ECCE\ECCE\Views\Menu\MeusPedidos.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\n    <td>");
#nullable restore
#line 38 "C:\Users\danie\Desktop\Fac\ECCE_TOPV21\ECCE\ECCE\Views\Menu\MeusPedidos.cshtml"
   Write(item.CodigoVenda);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 39 "C:\Users\danie\Desktop\Fac\ECCE_TOPV21\ECCE\ECCE\Views\Menu\MeusPedidos.cshtml"
   Write(item.Valor.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 40 "C:\Users\danie\Desktop\Fac\ECCE_TOPV21\ECCE\ECCE\Views\Menu\MeusPedidos.cshtml"
   Write(item.Data);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 41 "C:\Users\danie\Desktop\Fac\ECCE_TOPV21\ECCE\ECCE\Views\Menu\MeusPedidos.cshtml"
   Write(item.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td><button type=\"button\" class=\"btn btn-warning btn-sm\"");
            BeginWriteAttribute("onclick", " onclick=\"", 913, "\"", 991, 3);
            WriteAttributeValue("", 923, "window.location.href=\'/pedido/VerIten?CodigoVenda=", 923, 50, true);
#nullable restore
#line 42 "C:\Users\danie\Desktop\Fac\ECCE_TOPV21\ECCE\ECCE\Views\Menu\MeusPedidos.cshtml"
WriteAttributeValue("", 973, item.CodigoVenda, 973, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 990, "\'", 990, 1, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-search\"></i></button></td>\n</tr>\n");
#nullable restore
#line 44 "C:\Users\danie\Desktop\Fac\ECCE_TOPV21\ECCE\ECCE\Views\Menu\MeusPedidos.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table> ");
#nullable restore
#line 46 "C:\Users\danie\Desktop\Fac\ECCE_TOPV21\ECCE\ECCE\Views\Menu\MeusPedidos.cshtml"
         }
            else
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\n    <div class=\"icon\"><span style=\"font-size: 38px\">:(</span></div>\n    <h3>Você ainda não fez nenhuma compra. Essa é sua hora! </h3>\n</div>");
#nullable restore
#line 53 "C:\Users\danie\Desktop\Fac\ECCE_TOPV21\ECCE\ECCE\Views\Menu\MeusPedidos.cshtml"
      }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</div>\n\n\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<TodosPedidos>> Html { get; private set; }
    }
}
#pragma warning restore 1591
