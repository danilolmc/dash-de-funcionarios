#pragma checksum "C:\Users\dola\OneDrive - GFT Technologies SE\Desktop\desafio-mvc\Views\Vaga\vagas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c6c6bea5b15ddc1591113cb9988c114fefcf3f2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vaga_vagas), @"mvc.1.0.view", @"/Views/Vaga/vagas.cshtml")]
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
#line 1 "C:\Users\dola\OneDrive - GFT Technologies SE\Desktop\desafio-mvc\Views\_ViewImports.cshtml"
using desafio_mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dola\OneDrive - GFT Technologies SE\Desktop\desafio-mvc\Views\_ViewImports.cshtml"
using desafio_mvc.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dola\OneDrive - GFT Technologies SE\Desktop\desafio-mvc\Views\Vaga\vagas.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c6c6bea5b15ddc1591113cb9988c114fefcf3f2", @"/Views/Vaga/vagas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f18134b6d419e4d0cae9dbf370c9501faae761e2", @"/Views/_ViewImports.cshtml")]
    public class Views_Vaga_vagas : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<desafio_mvc.Models.Vaga>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/vagas.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/customDay.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Vaga", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeletarVaga", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Cadastrar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\dola\OneDrive - GFT Technologies SE\Desktop\desafio-mvc\Views\Vaga\vagas.cshtml"
  
    Layout = "_LeftMenu";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4c6c6bea5b15ddc1591113cb9988c114fefcf3f25987", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c6c6bea5b15ddc1591113cb9988c114fefcf3f27105", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<script>
    $(document).ready(function () {
        $('#tabela_vagas').DataTable();
        $('.dataTables_empty').text(""Nenhuma vaga cadastrada no sistema"");

    });
</script>

<header>

    <h2>Vagas em aberto</h2>
    <h3>Gerencie as vagas em aberto</h3>

</header>

<section class=""datatable-container"">

    </header>

    <table id=""tabela_vagas"" class=""ui very basic table"">
        <thead>
            <tr>
                <th>Projeto</th>
                <th>Descrição da vaga</th>
                <th>Tecnologias</th>
                <th>Abertura da vaga</th>
                <th>Qtd. Vagas</th>
                <th>Código da vaga</th>
                <th></th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 48 "C:\Users\dola\OneDrive - GFT Technologies SE\Desktop\desafio-mvc\Views\Vaga\vagas.cshtml"
             foreach (var vaga in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"row\">\r\n                    <td>");
#nullable restore
#line 51 "C:\Users\dola\OneDrive - GFT Technologies SE\Desktop\desafio-mvc\Views\Vaga\vagas.cshtml"
                   Write(vaga.Projeto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 52 "C:\Users\dola\OneDrive - GFT Technologies SE\Desktop\desafio-mvc\Views\Vaga\vagas.cshtml"
                   Write(vaga.Descricao_vaga);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"techs\">\r\n\r\n");
#nullable restore
#line 55 "C:\Users\dola\OneDrive - GFT Technologies SE\Desktop\desafio-mvc\Views\Vaga\vagas.cshtml"
                         foreach (var tec in vaga.VagaTecnologias.Select(e => e.Tecnologia))
                        {
                            if (vaga.VagaTecnologias.Select(e => e.Tecnologia).Count() > 1)
                            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span>");
#nullable restore
#line 60 "C:\Users\dola\OneDrive - GFT Technologies SE\Desktop\desafio-mvc\Views\Vaga\vagas.cshtml"
                                 Write(tec.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 61 "C:\Users\dola\OneDrive - GFT Technologies SE\Desktop\desafio-mvc\Views\Vaga\vagas.cshtml"
                            }
                            else
                            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span>");
#nullable restore
#line 65 "C:\Users\dola\OneDrive - GFT Technologies SE\Desktop\desafio-mvc\Views\Vaga\vagas.cshtml"
                                 Write(tec.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 66 "C:\Users\dola\OneDrive - GFT Technologies SE\Desktop\desafio-mvc\Views\Vaga\vagas.cshtml"
                            }
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                    <td class=\"data\">");
#nullable restore
#line 69 "C:\Users\dola\OneDrive - GFT Technologies SE\Desktop\desafio-mvc\Views\Vaga\vagas.cshtml"
                                Write(vaga.Abertura_vaga);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 70 "C:\Users\dola\OneDrive - GFT Technologies SE\Desktop\desafio-mvc\Views\Vaga\vagas.cshtml"
                   Write(vaga.Qtd_vaga);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 71 "C:\Users\dola\OneDrive - GFT Technologies SE\Desktop\desafio-mvc\Views\Vaga\vagas.cshtml"
                   Write(vaga.Codigo_vaga);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                \r\n                    <td class=\"editDelete\">\r\n");
#nullable restore
#line 75 "C:\Users\dola\OneDrive - GFT Technologies SE\Desktop\desafio-mvc\Views\Vaga\vagas.cshtml"
                     if (User.FindFirst("levelAccess").Value == "admin"){

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c6c6bea5b15ddc1591113cb9988c114fefcf3f212681", async() => {
                WriteLiteral("\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 2428, "\"", 2460, 2);
                WriteAttributeValue("", 2435, "/wa/vagas/editar/", 2435, 17, true);
#nullable restore
#line 77 "C:\Users\dola\OneDrive - GFT Technologies SE\Desktop\desafio-mvc\Views\Vaga\vagas.cshtml"
WriteAttributeValue("", 2452, vaga.Id, 2452, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" id=\"pencil\"> \r\n                            <i class=\"fas fa-pencil-alt\"></i>\r\n                        </a>\r\n                            <input type=\"hidden\" name=\"id\" id=\"id\"");
                BeginWriteAttribute("value", " value=\"", 2636, "\"", 2652, 1);
#nullable restore
#line 80 "C:\Users\dola\OneDrive - GFT Technologies SE\Desktop\desafio-mvc\Views\Vaga\vagas.cshtml"
WriteAttributeValue("", 2644, vaga.Id, 2644, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                            <button type=\"submit\" class=\"trash\">\r\n                                <i class=\"fas fa-trash-alt\"></i>\r\n                            </button>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 85 "C:\Users\dola\OneDrive - GFT Technologies SE\Desktop\desafio-mvc\Views\Vaga\vagas.cshtml"
                     }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 88 "C:\Users\dola\OneDrive - GFT Technologies SE\Desktop\desafio-mvc\Views\Vaga\vagas.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c6c6bea5b15ddc1591113cb9988c114fefcf3f216130", async() => {
                WriteLiteral("Adicionar vaga");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</section>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<IdentityUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<desafio_mvc.Models.Vaga>> Html { get; private set; }
    }
}
#pragma warning restore 1591
