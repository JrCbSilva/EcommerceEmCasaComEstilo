#pragma checksum "C:\Users\danie\Desktop\Fac\ECCE_TOPV21\ECCE\ECCE\Views\Pedido\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc96e76a69203eb4c2745a798084c6d8df82e9a5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pedido_Index), @"mvc.1.0.view", @"/Views/Pedido/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc96e76a69203eb4c2745a798084c6d8df82e9a5", @"/Views/Pedido/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac77d2a601f4d58340855bb0b07dde3ca55643c1", @"/Views/_ViewImports.cshtml")]
    public class Views_Pedido_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<TodosPedidos>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\danie\Desktop\Fac\ECCE_TOPV21\ECCE\ECCE\Views\Pedido\Index.cshtml"
    ViewData["Title"] = "Genero";

    Layout = "_Layout_dashboard";


#line default
#line hidden
#nullable disable
            WriteLiteral("<hr />\n<h4 class=\"font-weight-bold\">Lista de Vendas</h4>\n<hr />\n<div >\n\n");
#nullable restore
#line 13 "C:\Users\danie\Desktop\Fac\ECCE_TOPV21\ECCE\ECCE\Views\Pedido\Index.cshtml"
     if (Model.Count > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<table class=""table table-striped table-sm"">
    <thead class=""thead-dark"">
        <tr>
            <th>Venda</th>
            <th>Cliente</th>
            <th>Valor</th>
            <th>Data</th>
            <th>Status</th>
            <th>Editar Status</th>
            <th>Ver Itens</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 28 "C:\Users\danie\Desktop\Fac\ECCE_TOPV21\ECCE\ECCE\Views\Pedido\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>");
#nullable restore
#line 31 "C:\Users\danie\Desktop\Fac\ECCE_TOPV21\ECCE\ECCE\Views\Pedido\Index.cshtml"
           Write(item.CodigoVenda);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 32 "C:\Users\danie\Desktop\Fac\ECCE_TOPV21\ECCE\ECCE\Views\Pedido\Index.cshtml"
           Write(item.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 33 "C:\Users\danie\Desktop\Fac\ECCE_TOPV21\ECCE\ECCE\Views\Pedido\Index.cshtml"
           Write(item.Valor.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 34 "C:\Users\danie\Desktop\Fac\ECCE_TOPV21\ECCE\ECCE\Views\Pedido\Index.cshtml"
           Write(item.Data);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 35 "C:\Users\danie\Desktop\Fac\ECCE_TOPV21\ECCE\ECCE\Views\Pedido\Index.cshtml"
           Write(item.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td><button type=\"button\" class=\"btn btn-warning btn-sm\"");
            BeginWriteAttribute("onclick", " onclick=\"", 853, "\"", 930, 3);
            WriteAttributeValue("", 863, "window.location.href=\'/pedido/Editar?CodigoVenda=", 863, 49, true);
#nullable restore
#line 36 "C:\Users\danie\Desktop\Fac\ECCE_TOPV21\ECCE\ECCE\Views\Pedido\Index.cshtml"
WriteAttributeValue("", 912, item.CodigoVenda, 912, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 929, "\'", 929, 1, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-edit \"></i></button></td>\n            <td><button type=\"button\" class=\"btn btn-warning btn-sm\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1042, "\"", 1121, 3);
            WriteAttributeValue("", 1052, "window.location.href=\'/pedido/VerItens?CodigoVenda=", 1052, 51, true);
#nullable restore
#line 37 "C:\Users\danie\Desktop\Fac\ECCE_TOPV21\ECCE\ECCE\Views\Pedido\Index.cshtml"
WriteAttributeValue("", 1103, item.CodigoVenda, 1103, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1120, "\'", 1120, 1, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-search\"></i></button></td>\n        </tr>                \n");
#nullable restore
#line 39 "C:\Users\danie\Desktop\Fac\ECCE_TOPV21\ECCE\ECCE\Views\Pedido\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n");
#nullable restore
#line 42 "C:\Users\danie\Desktop\Fac\ECCE_TOPV21\ECCE\ECCE\Views\Pedido\Index.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-primary\" role=\"alert\">\n            Sem Registros!\n        </div>\n");
#nullable restore
#line 48 "C:\Users\danie\Desktop\Fac\ECCE_TOPV21\ECCE\ECCE\Views\Pedido\Index.cshtml"
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
