#pragma checksum "C:\Users\igor.pinheiro\Desktop\Arquivos 2\Desafio_BHS\SmartPedidos\Views\Pedido\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6646c44da4df272b28b0a3cf0aca01c3952231f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pedido_Index), @"mvc.1.0.view", @"/Views/Pedido/Index.cshtml")]
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
#line 1 "C:\Users\igor.pinheiro\Desktop\Arquivos 2\Desafio_BHS\SmartPedidos\Views\_ViewImports.cshtml"
using SmartPedidos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\igor.pinheiro\Desktop\Arquivos 2\Desafio_BHS\SmartPedidos\Views\_ViewImports.cshtml"
using SmartPedidos.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6646c44da4df272b28b0a3cf0aca01c3952231f4", @"/Views/Pedido/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5665fa6418af1b3586c4541a80a5dcd41a2bc2b8", @"/Views/_ViewImports.cshtml")]
    public class Views_Pedido_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SmartPedidos.Models.Pedido>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<style type=\"text/css\">\r\n  h2 {\r\n    color: rgb(135, 194, 199);\r\n  }\r\n</style>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6646c44da4df272b28b0a3cf0aca01c3952231f43239", async() => {
                WriteLiteral(@"
  <h2>Todos Pedidos</h2><br>
  <a href=""../Pedido/Criar"" class=""btn btn-secondary"">Criar Pedido</a>
  <a href=""#"" class=""btn btn-primary"">Filtrar</a><br><br><br>

  <div class=""row"">
    <div class=""col-md-12"">
      <table class=""table table-hover"">
        <tbody>
          <tr>
            <th>Descri????o</th>
            <th>Data</th>
            <th>Valor</th>
            <th>Status</th>
            <th></th>
            <th></th>
          </tr>

");
#nullable restore
#line 26 "C:\Users\igor.pinheiro\Desktop\Arquivos 2\Desafio_BHS\SmartPedidos\Views\Pedido\Index.cshtml"
           foreach (var item in Model)
          {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr>\r\n              <td>");
#nullable restore
#line 29 "C:\Users\igor.pinheiro\Desktop\Arquivos 2\Desafio_BHS\SmartPedidos\Views\Pedido\Index.cshtml"
             Write(item.Descricao);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n              <td>");
#nullable restore
#line 30 "C:\Users\igor.pinheiro\Desktop\Arquivos 2\Desafio_BHS\SmartPedidos\Views\Pedido\Index.cshtml"
             Write(item.DataPedido);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n              <td>");
#nullable restore
#line 31 "C:\Users\igor.pinheiro\Desktop\Arquivos 2\Desafio_BHS\SmartPedidos\Views\Pedido\Index.cshtml"
             Write(item.ValorPedido);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n              <td>");
#nullable restore
#line 32 "C:\Users\igor.pinheiro\Desktop\Arquivos 2\Desafio_BHS\SmartPedidos\Views\Pedido\Index.cshtml"
             Write(item.Status);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n              <td>\r\n\r\n                <a");
                BeginWriteAttribute("href", " href=\"", 874, "\"", 906, 2);
                WriteAttributeValue("", 881, "../Pedido/Listar/", 881, 17, true);
#nullable restore
#line 35 "C:\Users\igor.pinheiro\Desktop\Arquivos 2\Desafio_BHS\SmartPedidos\Views\Pedido\Index.cshtml"
WriteAttributeValue("", 898, item.Id, 898, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 907, "\"", 920, 1);
#nullable restore
#line 35 "C:\Users\igor.pinheiro\Desktop\Arquivos 2\Desafio_BHS\SmartPedidos\Views\Pedido\Index.cshtml"
WriteAttributeValue("", 912, item.Id, 912, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-primary\">Itens</a>\r\n\r\n              </td>\r\n              <td>\r\n                <a");
                BeginWriteAttribute("href", " href=\"", 1018, "\"", 1051, 2);
                WriteAttributeValue("", 1025, "../Pedido/Deletar/", 1025, 18, true);
#nullable restore
#line 39 "C:\Users\igor.pinheiro\Desktop\Arquivos 2\Desafio_BHS\SmartPedidos\Views\Pedido\Index.cshtml"
WriteAttributeValue("", 1043, item.Id, 1043, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-danger\">Deletar</a>\r\n              </td>\r\n            </tr>\r\n");
#nullable restore
#line 42 "C:\Users\igor.pinheiro\Desktop\Arquivos 2\Desafio_BHS\SmartPedidos\Views\Pedido\Index.cshtml"
          }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </tbody>\r\n      </table>\r\n    </div>\r\n  </div>\r\n\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SmartPedidos.Models.Pedido>> Html { get; private set; }
    }
}
#pragma warning restore 1591
