#pragma checksum "C:\Users\danie\Downloads\Down\ECCE_TOPV18.05.2\ECCE_TOPV18.05.2\ECCE\ECCE\Views\Home\Masculino.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "481373fc749b44c0cd28a9e16305014644a296a5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Masculino), @"mvc.1.0.view", @"/Views/Home/Masculino.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"481373fc749b44c0cd28a9e16305014644a296a5", @"/Views/Home/Masculino.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac77d2a601f4d58340855bb0b07dde3ca55643c1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Masculino : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ProdutoVWList>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ProdutoDetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\danie\Downloads\Down\ECCE_TOPV18.05.2\ECCE_TOPV18.05.2\ECCE\ECCE\Views\Home\Masculino.cshtml"
                ViewData["Title"] = "Home Page"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\" id=\"idcarrinho\"></div>\n<hr />\n<h6 class=\"font-weight-bold\" style=\"color:#7876a1\">Masculino</h6>\n<hr />\n<div class=\"row\">\n");
#nullable restore
#line 9 "C:\Users\danie\Downloads\Down\ECCE_TOPV18.05.2\ECCE_TOPV18.05.2\ECCE\ECCE\Views\Home\Masculino.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"card col-md-3 text-center\">\n    <div class=\"card-header\">\n        <div>");
#nullable restore
#line 13 "C:\Users\danie\Downloads\Down\ECCE_TOPV18.05.2\ECCE_TOPV18.05.2\ECCE\ECCE\Views\Home\Masculino.cshtml"
        Write(item.tb_produto.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n    </div>\n    <div class=\"card-body\">\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "481373fc749b44c0cd28a9e16305014644a296a54786", async() => {
                WriteLiteral("\n            <p><img");
                BeginWriteAttribute("src", " src=\"", 551, "\"", 567, 1);
#nullable restore
#line 17 "C:\Users\danie\Downloads\Down\ECCE_TOPV18.05.2\ECCE_TOPV18.05.2\ECCE\ECCE\Views\Home\Masculino.cshtml"
WriteAttributeValue("", 557, item.Foto, 557, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"height: 200px;\" /></p>\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 16 "C:\Users\danie\Downloads\Down\ECCE_TOPV18.05.2\ECCE_TOPV18.05.2\ECCE\ECCE\Views\Home\Masculino.cshtml"
             WriteLiteral(item.tb_produto.CodigoProduto);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </div>\n    <div class=\"card-footer\">\n        <p>");
#nullable restore
#line 21 "C:\Users\danie\Downloads\Down\ECCE_TOPV18.05.2\ECCE_TOPV18.05.2\ECCE\ECCE\Views\Home\Masculino.cshtml"
      Write(item.tb_produto.Valor.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "481373fc749b44c0cd28a9e16305014644a296a57938", async() => {
                WriteLiteral("Mais Detalhes");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 22 "C:\Users\danie\Downloads\Down\ECCE_TOPV18.05.2\ECCE_TOPV18.05.2\ECCE\ECCE\Views\Home\Masculino.cshtml"
             WriteLiteral(item.tb_produto.CodigoProduto);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </div>\n\n</div>\n");
            WriteLiteral("                <br />");
#nullable restore
#line 28 "C:\Users\danie\Downloads\Down\ECCE_TOPV18.05.2\ECCE_TOPV18.05.2\ECCE\ECCE\Views\Home\Masculino.cshtml"
                      }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n<script>\n    $(document).ready(function () {\n        GetCarrinho();\n    });\n\n\n    function AddCar(codigo,descricao) {\n        var _url = \'");
#nullable restore
#line 37 "C:\Users\danie\Downloads\Down\ECCE_TOPV18.05.2\ECCE_TOPV18.05.2\ECCE\ECCE\Views\Home\Masculino.cshtml"
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
#line 63 "C:\Users\danie\Downloads\Down\ECCE_TOPV18.05.2\ECCE_TOPV18.05.2\ECCE\ECCE\Views\Home\Masculino.cshtml"
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
#line 87 "C:\Users\danie\Downloads\Down\ECCE_TOPV18.05.2\ECCE_TOPV18.05.2\ECCE\ECCE\Views\Home\Masculino.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ProdutoVWList>> Html { get; private set; }
    }
}
#pragma warning restore 1591
