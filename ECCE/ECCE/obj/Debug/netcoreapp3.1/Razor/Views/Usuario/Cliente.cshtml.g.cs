#pragma checksum "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Usuario\Cliente.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "58625f84398b2401cfff78e919ee9971d51d6e82"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Cliente), @"mvc.1.0.view", @"/Views/Usuario/Cliente.cshtml")]
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
#line 1 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\_ViewImports.cshtml"
using ECCE;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\_ViewImports.cshtml"
using ECCE.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58625f84398b2401cfff78e919ee9971d51d6e82", @"/Views/Usuario/Cliente.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8d523cb7d045fc283b7b459a0bcbbd2d4e32902", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_Cliente : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<tb_login>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Usuario\Cliente.cshtml"
    ViewData["Title"] = "Produto";

    Layout = "_Layout_dashboard";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    <div class=\"col-md-12 text-center\">\r\n        <h5>Lista de Clientes</h5>\r\n    </div>\r\n\r\n<br />\r\n\r\n");
#nullable restore
#line 16 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Usuario\Cliente.cshtml"
     if (Model.Count > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <table class=""table table-striped table-sm"">
            <thead class=""thead-dark"">
                <tr>
                    <th></th>
                    <th>Código</th>
                    <th>Nome</th>
                    <th>Email</th>
                    <th>Editar</th>
                    <th></th>
                    <th></th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 31 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Usuario\Cliente.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td></td>\r\n                        <td>");
#nullable restore
#line 35 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Usuario\Cliente.cshtml"
                       Write(item.CodigoLogin);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 36 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Usuario\Cliente.cshtml"
                       Write(item.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 37 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Usuario\Cliente.cshtml"
                       Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td><button type=\"button\" class=\"btn btn-warning btn-sm\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1023, "\"", 1240, 17);
            WriteAttributeValue("", 1033, "window.location.href=\'/usuario/editaradmin?CodigoLogin=", 1033, 55, true);
#nullable restore
#line 38 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Usuario\Cliente.cshtml"
WriteAttributeValue("", 1088, item.CodigoLogin, 1088, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1105, "&Nome=", 1105, 6, true);
#nullable restore
#line 38 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Usuario\Cliente.cshtml"
WriteAttributeValue("", 1111, item.Nome, 1111, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1121, "&Email=", 1121, 7, true);
#nullable restore
#line 38 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Usuario\Cliente.cshtml"
WriteAttributeValue("", 1128, item.Email, 1128, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1139, "&Telefone=", 1139, 10, true);
#nullable restore
#line 38 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Usuario\Cliente.cshtml"
WriteAttributeValue("", 1149, item.Telefone, 1149, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1163, "&CPF_CNPJ=", 1163, 10, true);
#nullable restore
#line 38 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Usuario\Cliente.cshtml"
WriteAttributeValue("", 1173, item.CPF_CNPJ, 1173, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1187, "&Senha=", 1187, 7, true);
#nullable restore
#line 38 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Usuario\Cliente.cshtml"
WriteAttributeValue("", 1194, item.Senha, 1194, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1205, "&Tipo=", 1205, 6, true);
#nullable restore
#line 38 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Usuario\Cliente.cshtml"
WriteAttributeValue("", 1211, item.Tipo, 1211, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1221, "&Ativo=", 1221, 7, true);
#nullable restore
#line 38 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Usuario\Cliente.cshtml"
WriteAttributeValue("", 1228, item.Ativo, 1228, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1239, "\'", 1239, 1, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-edit\"></i></button></td>\r\n                        <td></td>\r\n                        <td></td>\r\n                    </tr>\r\n");
#nullable restore
#line 42 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Usuario\Cliente.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
#nullable restore
#line 45 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Usuario\Cliente.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-primary\" role=\"alert\">\r\n            Sem Registros!\r\n        </div>\r\n");
#nullable restore
#line 51 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Usuario\Cliente.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<tb_login>> Html { get; private set; }
    }
}
#pragma warning restore 1591
