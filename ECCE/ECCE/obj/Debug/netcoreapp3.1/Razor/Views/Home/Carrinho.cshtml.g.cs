#pragma checksum "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Home\Carrinho.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ff99542f8bd62b5beac663391deea05734dcb8e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Carrinho), @"mvc.1.0.view", @"/Views/Home/Carrinho.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ff99542f8bd62b5beac663391deea05734dcb8e", @"/Views/Home/Carrinho.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8d523cb7d045fc283b7b459a0bcbbd2d4e32902", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Carrinho : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Home\Carrinho.cshtml"
  

    ViewData["Title"] = "Carrinho";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n<div class=\"row\" id=\"idcarrinho\"></div>\r\n\r\n<script>\r\n    $(document).ready(function () {\r\n        GetCarrinho();\r\n    });\r\n\r\n\r\n    function AddCar(codigo,descricao) {\r\n        var _url = \'");
#nullable restore
#line 19 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Home\Carrinho.cshtml"
               Write(Url.Action("AddCar", "Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';

        $.ajax({
            url: _url,
            type: 'GET',
            data: {
                key: codigo,
                value: descricao
            },
            processData: true,
            contentType: true,
            success: function (result) {
                GetCarrinho();
            }
            ,
            error: function (jqXHR) {

            },
            complete: function (jqXHR, status) {

            }

        });
    }

    function GetCarrinho() {
        var _url = '");
#nullable restore
#line 45 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Home\Carrinho.cshtml"
               Write(Url.Action("GetAll", "Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';

        $.ajax({
            url: _url,
            type: 'GET',
            processData: true,
            contentType: true,
            success: function (result) {
                $(""#idcarrinho"").html(result);

             }
            ,
            error: function (jqXHR) {

            },
            complete: function (jqXHR, status) {

            }

        });
    }


    function RemoveItem(codigo) {
        var _url = '");
#nullable restore
#line 69 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Home\Carrinho.cshtml"
               Write(Url.Action("RemoveItem", "Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';

        $.ajax({
            url: _url,
            type: 'GET',
            data: {
                key: codigo
            },
            processData: true,
            contentType: true,
            success: function (result) {
                GetCarrinho();
            }
            ,
            error: function (jqXHR) {

            },
            complete: function (jqXHR, status) {

            }

        });
    }

</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591