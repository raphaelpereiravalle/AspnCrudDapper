#pragma checksum "C:\Projetos\dev\.NET\AspnCrudDapper\AspnCrudDapper\Views\Produto\ManderProduto.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ace695b029f40bdf6c041514ba351d30bb153e2e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produto_ManderProduto), @"mvc.1.0.view", @"/Views/Produto/ManderProduto.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Produto/ManderProduto.cshtml", typeof(AspNetCore.Views_Produto_ManderProduto))]
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
#line 1 "C:\Projetos\dev\.NET\AspnCrudDapper\AspnCrudDapper\Views\_ViewImports.cshtml"
using AspnCrudDapper;

#line default
#line hidden
#line 2 "C:\Projetos\dev\.NET\AspnCrudDapper\AspnCrudDapper\Views\_ViewImports.cshtml"
using AspnCrudDapper.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ace695b029f40bdf6c041514ba351d30bb153e2e", @"/Views/Produto/ManderProduto.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80af90e8f79ff7ffa577aebdf5a1af1fdad4d9d5", @"/Views/_ViewImports.cshtml")]
    public class Views_Produto_ManderProduto : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AspnCrudDapper.Entities.Produto>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Projetos\dev\.NET\AspnCrudDapper\AspnCrudDapper\Views\Produto\ManderProduto.cshtml"
  
    ViewData["Title"] = Model.ProdutoId == null ? "Incluir Produto" : "Editar Produto";
    ViewData["Acao"] = Model.ProdutoId == null ? 0 : 1;
    ViewData["IdProduto"] = Model.ProdutoId == null ? "null" : string.Format("'{0}'", @Model.ProdutoId.ToString());
    Layout = null;

#line default
#line hidden
            BeginContext(330, 95, true);
            WriteLiteral("\r\n<div class=\"modal-content\">\r\n    <div class=\"modal-header\">\r\n        <h5 class=\"modal-title\">");
            EndContext();
            BeginContext(426, 17, false);
#line 11 "C:\Projetos\dev\.NET\AspnCrudDapper\AspnCrudDapper\Views\Produto\ManderProduto.cshtml"
                           Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(443, 114, true);
            WriteLiteral("</h5>\r\n        <button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-label=\"Close\"></button>\r\n    </div>\r\n");
            EndContext();
#line 14 "C:\Projetos\dev\.NET\AspnCrudDapper\AspnCrudDapper\Views\Produto\ManderProduto.cshtml"
     using (Html.BeginForm("", "", FormMethod.Post, new { id = "frmProduto" }))
    {

#line default
#line hidden
            BeginContext(645, 204, true);
            WriteLiteral("        <div class=\"modal-body\">\r\n            <div class=\"row\">\r\n                <div class=\"form-group col-xs-12 col-sm-12 col-md-12 col-lg-12 error\">\r\n                    <div>\r\n                        ");
            EndContext();
            BeginContext(850, 73, false);
#line 20 "C:\Projetos\dev\.NET\AspnCrudDapper\AspnCrudDapper\Views\Produto\ManderProduto.cshtml"
                   Write(Html.LabelFor(model => model.Nome, new { @class = "form-control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(923, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(950, 115, false);
#line 21 "C:\Projetos\dev\.NET\AspnCrudDapper\AspnCrudDapper\Views\Produto\ManderProduto.cshtml"
                   Write(Html.TextBoxFor(model => model.Nome, new { id = "Nome", @class = "form-control", placeholder = "Nome do produto" }));

#line default
#line hidden
            EndContext();
            BeginContext(1065, 213, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"form-group col-md-6 error\">\r\n                    <div>\r\n                        ");
            EndContext();
            BeginContext(1279, 76, false);
#line 28 "C:\Projetos\dev\.NET\AspnCrudDapper\AspnCrudDapper\Views\Produto\ManderProduto.cshtml"
                   Write(Html.LabelFor(model => model.Estoque, new { @class = "form-control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(1355, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(1382, 113, false);
#line 29 "C:\Projetos\dev\.NET\AspnCrudDapper\AspnCrudDapper\Views\Produto\ManderProduto.cshtml"
                   Write(Html.TextBoxFor(model => model.Estoque, new { id = "Estoque", @class = "form-control", placeholder = "Estoque" }));

#line default
#line hidden
            EndContext();
            BeginContext(1495, 162, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"form-group col-md-6 error\">\r\n                    <div>\r\n                        ");
            EndContext();
            BeginContext(1658, 74, false);
#line 34 "C:\Projetos\dev\.NET\AspnCrudDapper\AspnCrudDapper\Views\Produto\ManderProduto.cshtml"
                   Write(Html.LabelFor(model => model.Preco, new { @class = "form-control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(1732, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(1759, 107, false);
#line 35 "C:\Projetos\dev\.NET\AspnCrudDapper\AspnCrudDapper\Views\Produto\ManderProduto.cshtml"
                   Write(Html.TextBoxFor(model => model.Preco, new { id = "Preco", @class = "form-control", placeholder = "Preço" }));

#line default
#line hidden
            EndContext();
            BeginContext(1866, 344, true);
            WriteLiteral(@"
                    </div>
                </div>
            </div>
        </div>
        <div>
            <div class=""modal-footer"">
                <button type=""submit"" class=""btn btn-secondary"" data-dismiss=""modal"">Fechar</button>
                <input type=""submit"" class=""btn btn-primary"" id=""btnManterProduto"" value=""Enviar""");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2210, "\"", 2277, 5);
            WriteAttributeValue("", 2220, "manterProduto(", 2220, 14, true);
#line 43 "C:\Projetos\dev\.NET\AspnCrudDapper\AspnCrudDapper\Views\Produto\ManderProduto.cshtml"
WriteAttributeValue("", 2234, ViewData["Acao"], 2234, 17, false);

#line default
#line hidden
            WriteAttributeValue("", 2251, ",", 2251, 1, true);
#line 43 "C:\Projetos\dev\.NET\AspnCrudDapper\AspnCrudDapper\Views\Produto\ManderProduto.cshtml"
WriteAttributeValue(" ", 2252, ViewData["IdProduto"], 2253, 22, false);

#line default
#line hidden
            WriteAttributeValue("", 2275, ");", 2275, 2, true);
            EndWriteAttribute();
            BeginContext(2278, 41, true);
            WriteLiteral(" />\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 46 "C:\Projetos\dev\.NET\AspnCrudDapper\AspnCrudDapper\Views\Produto\ManderProduto.cshtml"
    }

#line default
#line hidden
            BeginContext(2326, 14, true);
            WriteLiteral("</div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AspnCrudDapper.Entities.Produto> Html { get; private set; }
    }
}
#pragma warning restore 1591