#pragma checksum "C:\Users\danie\Documents\GitHub\ECCEV.1.2\ECCE\ECCE\Views\Genero\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7485de24bcc67213ab7952a48c5968567a2d5420"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Genero_Index), @"mvc.1.0.view", @"/Views/Genero/Index.cshtml")]
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
#line 1 "C:\Users\danie\Documents\GitHub\ECCEV.1.2\ECCE\ECCE\Views\_ViewImports.cshtml"
using ECCE;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\danie\Documents\GitHub\ECCEV.1.2\ECCE\ECCE\Views\_ViewImports.cshtml"
using ECCE.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7485de24bcc67213ab7952a48c5968567a2d5420", @"/Views/Genero/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8d523cb7d045fc283b7b459a0bcbbd2d4e32902", @"/Views/_ViewImports.cshtml")]
    public class Views_Genero_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<tb_genero>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\danie\Documents\GitHub\ECCEV.1.2\ECCE\ECCE\Views\Genero\Index.cshtml"
                ViewData["Title"] = "Genero";

                Layout = "_Layout_dashboard"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<hr />
<div class=""row"">
    <div class=""col-md-10""><h4 class=""font-weight-bold"">Lista de Gêneros</h4></div>
    <div class="" col-md-2"">
        <button class=""btn btn-primary"" type=""button"" onclick=""window.location.href ='/genero/cadastrogenero'"">Novo Gênero</button>
    </div>
</div>
<hr />
<div>
");
#nullable restore
#line 15 "C:\Users\danie\Documents\GitHub\ECCEV.1.2\ECCE\ECCE\Views\Genero\Index.cshtml"
     if (Model.Count > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<table class=""table table-striped table-sm"">
    <thead class=""thead-dark"">
        <tr>
            <th>Código</th>
            <th>Nome</th>
            <th></th>
            <th></th>
            <th></th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 29 "C:\Users\danie\Documents\GitHub\ECCEV.1.2\ECCE\ECCE\Views\Genero\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n    <td>");
#nullable restore
#line 32 "C:\Users\danie\Documents\GitHub\ECCEV.1.2\ECCE\ECCE\Views\Genero\Index.cshtml"
   Write(item.CodigoGenero);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 33 "C:\Users\danie\Documents\GitHub\ECCEV.1.2\ECCE\ECCE\Views\Genero\Index.cshtml"
   Write(item.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td></td>\r\n    <td></td>\r\n    <td><button type=\"button\" class=\"btn btn-warning btn-sm\"");
            BeginWriteAttribute("onclick", " onclick=\"", 976, "\"", 1081, 5);
            WriteAttributeValue("", 986, "window.location.href=\'/genero/editar?CodigoGenero=", 986, 50, true);
#nullable restore
#line 36 "C:\Users\danie\Documents\GitHub\ECCEV.1.2\ECCE\ECCE\Views\Genero\Index.cshtml"
WriteAttributeValue("", 1036, item.CodigoGenero, 1036, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1054, "&Descricao=", 1054, 11, true);
#nullable restore
#line 36 "C:\Users\danie\Documents\GitHub\ECCEV.1.2\ECCE\ECCE\Views\Genero\Index.cshtml"
WriteAttributeValue("", 1065, item.Descricao, 1065, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1080, "\'", 1080, 1, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-edit\"></i></button></td>\r\n");
            WriteLiteral("    \r\n</tr>                ");
#nullable restore
#line 39 "C:\Users\danie\Documents\GitHub\ECCEV.1.2\ECCE\ECCE\Views\Genero\Index.cshtml"
                     }

#line default
#line hidden
#nullable disable
            WriteLiteral("</tbody>\r\n</table>\r\n");
#nullable restore
#line 42 "C:\Users\danie\Documents\GitHub\ECCEV.1.2\ECCE\ECCE\Views\Genero\Index.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"alert alert-primary\" role=\"alert\">\r\n    Sem Registros!\r\n</div>\r\n");
#nullable restore
#line 48 "C:\Users\danie\Documents\GitHub\ECCEV.1.2\ECCE\ECCE\Views\Genero\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<tb_genero>> Html { get; private set; }
    }
}
#pragma warning restore 1591
