#pragma checksum "C:\Users\Caio Mateus\source\repos\BarberWeb\BarberWeb\Views\Produto\Listar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "290971f53e927601fbcead2205d5b77ce37a27fa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produto_Listar), @"mvc.1.0.view", @"/Views/Produto/Listar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Produto/Listar.cshtml", typeof(AspNetCore.Views_Produto_Listar))]
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
#line 1 "C:\Users\Caio Mateus\source\repos\BarberWeb\BarberWeb\Views\_ViewImports.cshtml"
using BarberWeb;

#line default
#line hidden
#line 2 "C:\Users\Caio Mateus\source\repos\BarberWeb\BarberWeb\Views\_ViewImports.cshtml"
using Domain;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"290971f53e927601fbcead2205d5b77ce37a27fa", @"/Views/Produto/Listar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e663dbd030254a245208eec8e4f2d5c1bc4078f", @"/Views/_ViewImports.cshtml")]
    public class Views_Produto_Listar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Produto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Alterar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
#line 2 "C:\Users\Caio Mateus\source\repos\BarberWeb\BarberWeb\Views\Produto\Listar.cshtml"
  

    DateTime datahora = ViewBag.DataHora;

#line default
#line hidden
            BeginContext(74, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(94, 418, true);
            WriteLiteral(@"<div class=""m-5"">
    <h1>Gerenciamento de Produtos</h1>

    <table style=""margin-bottom:15px;margin-top:15px"" class=""table table-hover table-striped"">
        <thead>
            <tr>
                <th>Nome</th>
                <th>Descrição</th>
                <th>Preço</th>
                <th>Quantidade</th>
                <th>Criado Em</th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 23 "C:\Users\Caio Mateus\source\repos\BarberWeb\BarberWeb\Views\Produto\Listar.cshtml"
             foreach (Produto item in Model)
            {

#line default
#line hidden
            BeginContext(573, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(620, 9, false);
#line 26 "C:\Users\Caio Mateus\source\repos\BarberWeb\BarberWeb\Views\Produto\Listar.cshtml"
                   Write(item.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(629, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(661, 14, false);
#line 27 "C:\Users\Caio Mateus\source\repos\BarberWeb\BarberWeb\Views\Produto\Listar.cshtml"
                   Write(item.Descricao);

#line default
#line hidden
            EndContext();
            BeginContext(675, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(707, 31, false);
#line 28 "C:\Users\Caio Mateus\source\repos\BarberWeb\BarberWeb\Views\Produto\Listar.cshtml"
                   Write(item.Preco.Value.ToString("C2"));

#line default
#line hidden
            EndContext();
            BeginContext(738, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(770, 15, false);
#line 29 "C:\Users\Caio Mateus\source\repos\BarberWeb\BarberWeb\Views\Produto\Listar.cshtml"
                   Write(item.Quantidade);

#line default
#line hidden
            EndContext();
            BeginContext(785, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(817, 13, false);
#line 30 "C:\Users\Caio Mateus\source\repos\BarberWeb\BarberWeb\Views\Produto\Listar.cshtml"
                   Write(item.criadoEm);

#line default
#line hidden
            EndContext();
            BeginContext(830, 57, true);
            WriteLiteral("</td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(887, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b70f6fdc9f8e4981870c7af40c040025", async() => {
                BeginContext(945, 7, true);
                WriteLiteral("Remover");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 32 "C:\Users\Caio Mateus\source\repos\BarberWeb\BarberWeb\Views\Produto\Listar.cshtml"
                                                     WriteLiteral(item.ProdutoId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(956, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1035, 90, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "36d153edad204ae0a72124cbe46debcf", async() => {
                BeginContext(1114, 7, true);
                WriteLiteral("Alterar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 35 "C:\Users\Caio Mateus\source\repos\BarberWeb\BarberWeb\Views\Produto\Listar.cshtml"
                                                                          WriteLiteral(item.ProdutoId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1125, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 38 "C:\Users\Caio Mateus\source\repos\BarberWeb\BarberWeb\Views\Produto\Listar.cshtml"
            }

#line default
#line hidden
            BeginContext(1192, 80, true);
            WriteLiteral("        </tbody>\r\n\r\n    </table>\r\n    <p>\r\n        <b>Dados atualizados em: </b>");
            EndContext();
            BeginContext(1273, 8, false);
#line 43 "C:\Users\Caio Mateus\source\repos\BarberWeb\BarberWeb\Views\Produto\Listar.cshtml"
                                Write(datahora);

#line default
#line hidden
            EndContext();
            BeginContext(1281, 18, true);
            WriteLiteral("\r\n    </p>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Produto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
