#pragma checksum "C:\Projetos\dev\.NET\AspnCrudDapper\AspnCrudDapper\Views\Produto\ManderProduto.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1650b0dba9e69d4a17f7a60f34f2ea24e74258f0"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1650b0dba9e69d4a17f7a60f34f2ea24e74258f0", @"/Views/Produto/ManderProduto.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80af90e8f79ff7ffa577aebdf5a1af1fdad4d9d5", @"/Views/_ViewImports.cshtml")]
    public class Views_Produto_ManderProduto : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AspnCrudDapper.Entities.Produto>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Projetos\dev\.NET\AspnCrudDapper\AspnCrudDapper\Views\Produto\ManderProduto.cshtml"
  
    ViewData["Title"] = Model.ProdutoId == null ? "Incluir Produto" : "Editar Produto";
    ViewData["IdProduto"] = Model.ProdutoId == null ? "null" : string.Format("'{0}'", @Model.ProdutoId.ToString());
    Layout = null;

#line default
#line hidden
            BeginContext(273, 95, true);
            WriteLiteral("\r\n<div class=\"modal-content\">\r\n    <div class=\"modal-header\">\r\n        <h5 class=\"modal-title\">");
            EndContext();
            BeginContext(369, 17, false);
#line 10 "C:\Projetos\dev\.NET\AspnCrudDapper\AspnCrudDapper\Views\Produto\ManderProduto.cshtml"
                           Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(386, 114, true);
            WriteLiteral("</h5>\r\n        <button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-label=\"Close\"></button>\r\n    </div>\r\n");
            EndContext();
#line 13 "C:\Projetos\dev\.NET\AspnCrudDapper\AspnCrudDapper\Views\Produto\ManderProduto.cshtml"
     using (Html.BeginForm("", "", FormMethod.Post, new { id = "frmProduto" }))
    {

#line default
#line hidden
            BeginContext(588, 204, true);
            WriteLiteral("        <div class=\"modal-body\">\r\n            <div class=\"row\">\r\n                <div class=\"form-group col-xs-12 col-sm-12 col-md-12 col-lg-12 error\">\r\n                    <div>\r\n                        ");
            EndContext();
            BeginContext(793, 73, false);
#line 19 "C:\Projetos\dev\.NET\AspnCrudDapper\AspnCrudDapper\Views\Produto\ManderProduto.cshtml"
                   Write(Html.LabelFor(model => model.Nome, new { @class = "form-control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(866, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(893, 115, false);
#line 20 "C:\Projetos\dev\.NET\AspnCrudDapper\AspnCrudDapper\Views\Produto\ManderProduto.cshtml"
                   Write(Html.TextBoxFor(model => model.Nome, new { id = "Nome", @class = "form-control", placeholder = "Nome do produto" }));

#line default
#line hidden
            EndContext();
            BeginContext(1008, 242, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"form-group col-xs-12 col-sm-12 col-md-6 col-lg-4 error\">\r\n                    <div>\r\n                        ");
            EndContext();
            BeginContext(1251, 79, false);
#line 27 "C:\Projetos\dev\.NET\AspnCrudDapper\AspnCrudDapper\Views\Produto\ManderProduto.cshtml"
                   Write(Html.LabelFor(model => model.CodProduto, new { @class = "form-control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(1330, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(1357, 129, false);
#line 28 "C:\Projetos\dev\.NET\AspnCrudDapper\AspnCrudDapper\Views\Produto\ManderProduto.cshtml"
                   Write(Html.TextBoxFor(model => model.CodProduto, new { id = "CodProduto", @class = "form-control", placeholder = "C??digo do produto" }));

#line default
#line hidden
            EndContext();
            BeginContext(1486, 189, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"form-group col-xs-6 col-sm-6 col-md-4 col-lg-4 error\">\r\n                    <div>\r\n                        ");
            EndContext();
            BeginContext(1676, 76, false);
#line 33 "C:\Projetos\dev\.NET\AspnCrudDapper\AspnCrudDapper\Views\Produto\ManderProduto.cshtml"
                   Write(Html.LabelFor(model => model.Estoque, new { @class = "form-control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(1752, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(1779, 113, false);
#line 34 "C:\Projetos\dev\.NET\AspnCrudDapper\AspnCrudDapper\Views\Produto\ManderProduto.cshtml"
                   Write(Html.TextBoxFor(model => model.Estoque, new { id = "Estoque", @class = "form-control", placeholder = "Estoque" }));

#line default
#line hidden
            EndContext();
            BeginContext(1892, 189, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"form-group col-xs-6 col-sm-6 col-md-4 col-lg-4 error\">\r\n                    <div>\r\n                        ");
            EndContext();
            BeginContext(2082, 74, false);
#line 39 "C:\Projetos\dev\.NET\AspnCrudDapper\AspnCrudDapper\Views\Produto\ManderProduto.cshtml"
                   Write(Html.LabelFor(model => model.Preco, new { @class = "form-control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(2156, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(2183, 107, false);
#line 40 "C:\Projetos\dev\.NET\AspnCrudDapper\AspnCrudDapper\Views\Produto\ManderProduto.cshtml"
                   Write(Html.TextBoxFor(model => model.Preco, new { id = "Preco", @class = "form-control", placeholder = "Pre??o" }));

#line default
#line hidden
            EndContext();
            BeginContext(2290, 344, true);
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
            BeginWriteAttribute("onclick", " onclick=\"", 2634, "\"", 2682, 3);
            WriteAttributeValue("", 2644, "manterProduto(", 2644, 14, true);
#line 48 "C:\Projetos\dev\.NET\AspnCrudDapper\AspnCrudDapper\Views\Produto\ManderProduto.cshtml"
WriteAttributeValue("", 2658, ViewData["IdProduto"], 2658, 22, false);

#line default
#line hidden
            WriteAttributeValue("", 2680, ");", 2680, 2, true);
            EndWriteAttribute();
            BeginContext(2683, 41, true);
            WriteLiteral(" />\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 51 "C:\Projetos\dev\.NET\AspnCrudDapper\AspnCrudDapper\Views\Produto\ManderProduto.cshtml"
    }

#line default
#line hidden
            BeginContext(2731, 14, true);
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
