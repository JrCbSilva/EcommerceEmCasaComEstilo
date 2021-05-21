#pragma checksum "C:\Users\danie\Downloads\Down\ECCE_TOPV18.05.2\ECCE_TOPV18.05.2\ECCE\ECCE\Views\Produto\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "84f84f926a024ce444b21107a38ddd7ad4162993"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produto_Index), @"mvc.1.0.view", @"/Views/Produto/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84f84f926a024ce444b21107a38ddd7ad4162993", @"/Views/Produto/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac77d2a601f4d58340855bb0b07dde3ca55643c1", @"/Views/_ViewImports.cshtml")]
    public class Views_Produto_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<tb_produto>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\danie\Downloads\Down\ECCE_TOPV18.05.2\ECCE_TOPV18.05.2\ECCE\ECCE\Views\Produto\Index.cshtml"
                ViewData["Title"] = "Produto";

                Layout = "_Layout_dashboard"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<hr />
<div class=""row"">
    <div class=""col-md-10""><h4 class=""font-weight-bold"">Lista de Produtos</h4></div>
    <div class="" col-md-2"">
        <button class=""btn btn-primary"" type=""button"" onclick=""window.location.href ='/produto/cadastroproduto'"">Novo Produto</button>
    </div>
</div>
<hr />
    <div>
");
#nullable restore
#line 16 "C:\Users\danie\Downloads\Down\ECCE_TOPV18.05.2\ECCE_TOPV18.05.2\ECCE\ECCE\Views\Produto\Index.cshtml"
         if (Model.Count > 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<table class=""table table-striped table-sm"">
    <thead class=""thead-dark"">
        <tr>
            <th>Código Interno</th>
            <th>Nome</th>
            <th>Valor</th>
            <th>Quantidade</th>
            <th>Ativo</th>
            <th>Tamanho</th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 31 "C:\Users\danie\Downloads\Down\ECCE_TOPV18.05.2\ECCE_TOPV18.05.2\ECCE\ECCE\Views\Produto\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\n    <td>");
#nullable restore
#line 34 "C:\Users\danie\Downloads\Down\ECCE_TOPV18.05.2\ECCE_TOPV18.05.2\ECCE\ECCE\Views\Produto\Index.cshtml"
   Write(item.CodigoInterno);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 35 "C:\Users\danie\Downloads\Down\ECCE_TOPV18.05.2\ECCE_TOPV18.05.2\ECCE\ECCE\Views\Produto\Index.cshtml"
   Write(item.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 36 "C:\Users\danie\Downloads\Down\ECCE_TOPV18.05.2\ECCE_TOPV18.05.2\ECCE\ECCE\Views\Produto\Index.cshtml"
   Write(item.Valor.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 37 "C:\Users\danie\Downloads\Down\ECCE_TOPV18.05.2\ECCE_TOPV18.05.2\ECCE\ECCE\Views\Produto\Index.cshtml"
   Write(item.Quantidade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 38 "C:\Users\danie\Downloads\Down\ECCE_TOPV18.05.2\ECCE_TOPV18.05.2\ECCE\ECCE\Views\Produto\Index.cshtml"
   Write(item.Ativo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 39 "C:\Users\danie\Downloads\Down\ECCE_TOPV18.05.2\ECCE_TOPV18.05.2\ECCE\ECCE\Views\Produto\Index.cshtml"
   Write(item.Tamanho);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td><button type=\"button\" class=\"btn btn-warning btn-sm\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1106, "\"", 1248, 7);
            WriteAttributeValue("", 1116, "window.location.href=\'/produto/editar?CodigoProduto=", 1116, 52, true);
#nullable restore
#line 40 "C:\Users\danie\Downloads\Down\ECCE_TOPV18.05.2\ECCE_TOPV18.05.2\ECCE\ECCE\Views\Produto\Index.cshtml"
WriteAttributeValue("", 1168, item.CodigoProduto, 1168, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1187, "&CodigoInterno=", 1187, 15, true);
#nullable restore
#line 40 "C:\Users\danie\Downloads\Down\ECCE_TOPV18.05.2\ECCE_TOPV18.05.2\ECCE\ECCE\Views\Produto\Index.cshtml"
WriteAttributeValue("", 1202, item.CodigoInterno, 1202, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1221, "&Descricao=", 1221, 11, true);
#nullable restore
#line 40 "C:\Users\danie\Downloads\Down\ECCE_TOPV18.05.2\ECCE_TOPV18.05.2\ECCE\ECCE\Views\Produto\Index.cshtml"
WriteAttributeValue("", 1232, item.Descricao, 1232, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1247, "\'", 1247, 1, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-edit\"></i></button></td>\n</tr>\n");
#nullable restore
#line 42 "C:\Users\danie\Downloads\Down\ECCE_TOPV18.05.2\ECCE_TOPV18.05.2\ECCE\ECCE\Views\Produto\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table> ");
#nullable restore
#line 44 "C:\Users\danie\Downloads\Down\ECCE_TOPV18.05.2\ECCE_TOPV18.05.2\ECCE\ECCE\Views\Produto\Index.cshtml"
         }
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"alert alert-primary\" role=\"alert\">\n    Sem Registros!\n</div>");
#nullable restore
#line 49 "C:\Users\danie\Downloads\Down\ECCE_TOPV18.05.2\ECCE_TOPV18.05.2\ECCE\ECCE\Views\Produto\Index.cshtml"
      }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n\n\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<tb_produto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
