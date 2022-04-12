#pragma checksum "C:\dev\eventmarketplace\Views\Home\ListaCasaDeShow.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d3405d1bdc8fc614fc6bfa83add79f76ee1a140"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ListaCasaDeShow), @"mvc.1.0.view", @"/Views/Home/ListaCasaDeShow.cshtml")]
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
#line 1 "C:\dev\eventmarketplace\Views\_ViewImports.cshtml"
using EventMarketplace;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\dev\eventmarketplace\Views\_ViewImports.cshtml"
using EventMarketplace.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d3405d1bdc8fc614fc6bfa83add79f76ee1a140", @"/Views/Home/ListaCasaDeShow.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0dd0c6153b728732d572975753d62c1cb58d0fc0", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_ListaCasaDeShow : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EventMarketplace.Models.CasaDeShow>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\dev\eventmarketplace\Views\Home\ListaCasaDeShow.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\dev\eventmarketplace\Views\Home\ListaCasaDeShow.cshtml"
  
    ViewData["Title"] = "Lista de casas de show";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">

    <div class=""card-header p-3"" style=""margin-top: 4.5rem;"">
        <h5 class=""mb-0""><i class=""fas fa-tasks me-4""></i>Lista de Eventos</h5>
    </div>

    <script>
        $(document).ready(function () {
            $('#casaDeShow').DataTable({
                ""info"": false,
                ""language"": {
                    ""lengthMenu"": ""Mostrando _MENU_ Registros por página"",
                    ""zeroRecords"": ""Nada encontrado"",
                    ""info"": ""Mostrando página _PAGE_ de _PAGES_"",
                    ""infoEmpty"": ""Nenhum registro disponível"",
                    ""search"": ""Buscar:"",
                    ""paginate"": {
                        ""first"": ""Primeiro"",
                        ""last"": ""Ultimo"",
                        ""next"": ""Proximo"",
                        ""previous"": ""Anterior""
                    }
                }
            });
        });
    </script>

    <table id=""casaDeShow"" class=""table table-striped table-bordered");
            WriteLiteral("\">\r\n        <thead>\r\n            <tr>\r\n                <th>Id</th>\r\n                <th>Nome</th>\r\n                <th>Endereço</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 46 "C:\dev\eventmarketplace\Views\Home\ListaCasaDeShow.cshtml"
             foreach (var casaDeShow in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 49 "C:\dev\eventmarketplace\Views\Home\ListaCasaDeShow.cshtml"
                   Write(casaDeShow.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 50 "C:\dev\eventmarketplace\Views\Home\ListaCasaDeShow.cshtml"
                   Write(casaDeShow.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 51 "C:\dev\eventmarketplace\Views\Home\ListaCasaDeShow.cshtml"
                   Write(casaDeShow.Endereco);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 53 "C:\dev\eventmarketplace\Views\Home\ListaCasaDeShow.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EventMarketplace.Models.CasaDeShow>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
