#pragma checksum "C:\Users\Caio Mateus\source\repos\BarberWeb\BarberWeb\Views\Funcionario\Listar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73f0ecf3ce4b4c94cd576373c6e11ba967a7e9ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Funcionario_Listar), @"mvc.1.0.view", @"/Views/Funcionario/Listar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Funcionario/Listar.cshtml", typeof(AspNetCore.Views_Funcionario_Listar))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73f0ecf3ce4b4c94cd576373c6e11ba967a7e9ee", @"/Views/Funcionario/Listar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e663dbd030254a245208eec8e4f2d5c1bc4078f", @"/Views/_ViewImports.cshtml")]
    public class Views_Funcionario_Listar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Funcionario>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Funcionario", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Remover", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(26, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Caio Mateus\source\repos\BarberWeb\BarberWeb\Views\Funcionario\Listar.cshtml"
  

    DateTime datahora = ViewBag.DataHora;

#line default
#line hidden
            BeginContext(80, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(100, 531, true);
            WriteLiteral(@"    <div class=""m-5"">
        <h1>Gerenciamento de Funcionario</h1>

        <table style=""margin-bottom:15px;margin-top:15px"" class=""table table-hover table-striped"">
            <thead>
                <tr>
                    <th>Id</th>
                    <th>Nome</th>
                    <th>CPF</th>
                    <th>RG</th>
                    <th>Telefone</th>
                    <th>E-mail</th>
                    <th>Endereço</th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 26 "C:\Users\Caio Mateus\source\repos\BarberWeb\BarberWeb\Views\Funcionario\Listar.cshtml"
                 foreach (Funcionario item in Model)
                {

#line default
#line hidden
            BeginContext(704, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(751, 7, false);
#line 29 "C:\Users\Caio Mateus\source\repos\BarberWeb\BarberWeb\Views\Funcionario\Listar.cshtml"
                   Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(758, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(790, 9, false);
#line 30 "C:\Users\Caio Mateus\source\repos\BarberWeb\BarberWeb\Views\Funcionario\Listar.cshtml"
                   Write(item.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(799, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(831, 8, false);
#line 31 "C:\Users\Caio Mateus\source\repos\BarberWeb\BarberWeb\Views\Funcionario\Listar.cshtml"
                   Write(item.Cpf);

#line default
#line hidden
            EndContext();
            BeginContext(839, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(871, 13, false);
#line 32 "C:\Users\Caio Mateus\source\repos\BarberWeb\BarberWeb\Views\Funcionario\Listar.cshtml"
                   Write(item.Telefone);

#line default
#line hidden
            EndContext();
            BeginContext(884, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(916, 10, false);
#line 33 "C:\Users\Caio Mateus\source\repos\BarberWeb\BarberWeb\Views\Funcionario\Listar.cshtml"
                   Write(item.Email);

#line default
#line hidden
            EndContext();
            BeginContext(926, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(958, 13, false);
#line 34 "C:\Users\Caio Mateus\source\repos\BarberWeb\BarberWeb\Views\Funcionario\Listar.cshtml"
                   Write(item.Endereco);

#line default
#line hidden
            EndContext();
            BeginContext(971, 57, true);
            WriteLiteral("</td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1028, 112, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3280134c04814b4ab5f9878eae86ba95", async() => {
                BeginContext(1129, 7, true);
                WriteLiteral("Remover");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 36 "C:\Users\Caio Mateus\source\repos\BarberWeb\BarberWeb\Views\Funcionario\Listar.cshtml"
                                                                                                       WriteLiteral(item.Id);

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
            BeginContext(1140, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1219, 109, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8de463cf2de64a359acdfd556180b165", async() => {
                BeginContext(1317, 7, true);
                WriteLiteral("Alterar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 39 "C:\Users\Caio Mateus\source\repos\BarberWeb\BarberWeb\Views\Funcionario\Listar.cshtml"
                                                                                                    WriteLiteral(item.Id);

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
            BeginContext(1328, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 42 "C:\Users\Caio Mateus\source\repos\BarberWeb\BarberWeb\Views\Funcionario\Listar.cshtml"
                }

#line default
#line hidden
            BeginContext(1399, 96, true);
            WriteLiteral("            </tbody>\r\n\r\n        </table>\r\n        <p>\r\n            <b>Dados atualizados em: </b>");
            EndContext();
            BeginContext(1496, 8, false);
#line 47 "C:\Users\Caio Mateus\source\repos\BarberWeb\BarberWeb\Views\Funcionario\Listar.cshtml"
                                    Write(datahora);

#line default
#line hidden
            EndContext();
            BeginContext(1504, 28, true);
            WriteLiteral("\r\n        </p>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Funcionario>> Html { get; private set; }
    }
}
#pragma warning restore 1591
