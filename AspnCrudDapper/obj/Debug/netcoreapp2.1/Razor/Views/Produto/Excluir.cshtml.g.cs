#pragma checksum "C:\Projetos\dev\.NET\AspnCrudDapper\AspnCrudDapper\Views\Produto\Excluir.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc348f754c3fed292239e2afdcd137ce6c87dc1a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produto_Excluir), @"mvc.1.0.view", @"/Views/Produto/Excluir.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Produto/Excluir.cshtml", typeof(AspNetCore.Views_Produto_Excluir))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc348f754c3fed292239e2afdcd137ce6c87dc1a", @"/Views/Produto/Excluir.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80af90e8f79ff7ffa577aebdf5a1af1fdad4d9d5", @"/Views/_ViewImports.cshtml")]
    public class Views_Produto_Excluir : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AspnCrudDapper.Entities.Produto>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Projetos\dev\.NET\AspnCrudDapper\AspnCrudDapper\Views\Produto\Excluir.cshtml"
  
    ViewData["Title"] = "Excluir";
    Layout = null;

#line default
#line hidden
            BeginContext(103, 95, true);
            WriteLiteral("\r\n<div class=\"modal-content\">\r\n    <div class=\"modal-header\">\r\n        <h4 class=\"modal-title\">");
            EndContext();
            BeginContext(199, 17, false);
#line 9 "C:\Projetos\dev\.NET\AspnCrudDapper\AspnCrudDapper\Views\Produto\Excluir.cshtml"
                           Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(216, 497, true);
            WriteLiteral(@"</h4>
        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close""></button>
    </div>
    <div class=""modal-body"">
        <p>
            <h3>Deseja realmente excluir?</h3>
        </p>
    </div>
    <div class=""kt-portlet__foot"">
        <div class=""modal-footer"">
            <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Cancelar</button>
            <input type=""submit"" class=""btn btn-danger"" id=""btnExcluirProduto"" value=""Excluir""");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 713, "\"", 769, 3);
            WriteAttributeValue("", 723, "excluirProduto(\'", 723, 16, true);
#line 20 "C:\Projetos\dev\.NET\AspnCrudDapper\AspnCrudDapper\Views\Produto\Excluir.cshtml"
WriteAttributeValue("", 739, Model.ProdutoId.ToString(), 739, 27, false);

#line default
#line hidden
            WriteAttributeValue("", 766, "\');", 766, 3, true);
            EndWriteAttribute();
            BeginContext(770, 41, true);
            WriteLiteral(" />\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
