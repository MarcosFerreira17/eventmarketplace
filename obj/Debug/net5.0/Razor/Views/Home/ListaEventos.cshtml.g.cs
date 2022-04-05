#pragma checksum "C:\Users\mnia\OneDrive - GFT Technologies SE\Documents\Workspace\Atividades\Desafio MVC\Projeto do Desafio\eventmarketplace\Views\Home\ListaEventos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "18f49be8a27c38fec8ce1f396e6019d37882219c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ListaEventos), @"mvc.1.0.view", @"/Views/Home/ListaEventos.cshtml")]
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
#line 1 "C:\Users\mnia\OneDrive - GFT Technologies SE\Documents\Workspace\Atividades\Desafio MVC\Projeto do Desafio\eventmarketplace\Views\_ViewImports.cshtml"
using EventMarketplace;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mnia\OneDrive - GFT Technologies SE\Documents\Workspace\Atividades\Desafio MVC\Projeto do Desafio\eventmarketplace\Views\_ViewImports.cshtml"
using EventMarketplace.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18f49be8a27c38fec8ce1f396e6019d37882219c", @"/Views/Home/ListaEventos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0dd0c6153b728732d572975753d62c1cb58d0fc0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ListaEventos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EventMarketplace.Models.Evento>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\mnia\OneDrive - GFT Technologies SE\Documents\Workspace\Atividades\Desafio MVC\Projeto do Desafio\eventmarketplace\Views\Home\ListaEventos.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\mnia\OneDrive - GFT Technologies SE\Documents\Workspace\Atividades\Desafio MVC\Projeto do Desafio\eventmarketplace\Views\Home\ListaEventos.cshtml"
  
    ViewData["Title"] = "Lista de Eventos";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""card-header p-3"" style=""margin-top: 4.5rem;"">
    <h5 class=""mb-0""><i class=""fas fa-tasks me-4""></i>Lista de Eventos</h5>
</div>

<script>
    $(document).ready(function () {
        $('#evenos').DataTable({
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

<table id=""eventos"" class=""table table-striped table-bordered"">
    <thead>
        <tr>
            <th>Id</th>
            <th>Imagem</th>
            <th>Evento</th>
            <th>");
            WriteLiteral("Genero</th>\r\n            <th>Valor do ingresso</th>\r\n            <th>Casa de Show</th>\r\n            <th>Data</th>\r\n            <th>Qtd de Ingressos Disponiveis</th>\r\n            <th>Ações</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 50 "C:\Users\mnia\OneDrive - GFT Technologies SE\Documents\Workspace\Atividades\Desafio MVC\Projeto do Desafio\eventmarketplace\Views\Home\ListaEventos.cshtml"
         foreach (var eventos in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 53 "C:\Users\mnia\OneDrive - GFT Technologies SE\Documents\Workspace\Atividades\Desafio MVC\Projeto do Desafio\eventmarketplace\Views\Home\ListaEventos.cshtml"
               Write(eventos.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td><img");
            BeginWriteAttribute("src", " src=\"", 1530, "\"", 1560, 2);
            WriteAttributeValue("", 1536, "..\\fotos\\", 1536, 9, true);
#nullable restore
#line 54 "C:\Users\mnia\OneDrive - GFT Technologies SE\Documents\Workspace\Atividades\Desafio MVC\Projeto do Desafio\eventmarketplace\Views\Home\ListaEventos.cshtml"
WriteAttributeValue("", 1545, eventos.Imagem, 1545, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                    class=\"shadow-1-strong rounded-circle\" style=\"width: 100px; height: 100px;\"></td>\r\n                <td>");
#nullable restore
#line 56 "C:\Users\mnia\OneDrive - GFT Technologies SE\Documents\Workspace\Atividades\Desafio MVC\Projeto do Desafio\eventmarketplace\Views\Home\ListaEventos.cshtml"
               Write(eventos.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"text-center\">");
#nullable restore
#line 57 "C:\Users\mnia\OneDrive - GFT Technologies SE\Documents\Workspace\Atividades\Desafio MVC\Projeto do Desafio\eventmarketplace\Views\Home\ListaEventos.cshtml"
                                         if (@eventos.Genero == "0")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span>Pagode</span>\r\n");
#nullable restore
#line 60 "C:\Users\mnia\OneDrive - GFT Technologies SE\Documents\Workspace\Atividades\Desafio MVC\Projeto do Desafio\eventmarketplace\Views\Home\ListaEventos.cshtml"
                    }
                    else if (@eventos.Genero == "1")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span>Funk</span>\r\n");
#nullable restore
#line 64 "C:\Users\mnia\OneDrive - GFT Technologies SE\Documents\Workspace\Atividades\Desafio MVC\Projeto do Desafio\eventmarketplace\Views\Home\ListaEventos.cshtml"
                    }
                    else if (@eventos.Genero == "2")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span>Rock</span>\r\n");
#nullable restore
#line 68 "C:\Users\mnia\OneDrive - GFT Technologies SE\Documents\Workspace\Atividades\Desafio MVC\Projeto do Desafio\eventmarketplace\Views\Home\ListaEventos.cshtml"
                    }
                    else if (@eventos.Genero == "3")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span>Metal</span>\r\n");
#nullable restore
#line 72 "C:\Users\mnia\OneDrive - GFT Technologies SE\Documents\Workspace\Atividades\Desafio MVC\Projeto do Desafio\eventmarketplace\Views\Home\ListaEventos.cshtml"
                    }
                    else if (@eventos.Genero == "4")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span>Eletronica</span>\r\n");
#nullable restore
#line 76 "C:\Users\mnia\OneDrive - GFT Technologies SE\Documents\Workspace\Atividades\Desafio MVC\Projeto do Desafio\eventmarketplace\Views\Home\ListaEventos.cshtml"
                    }
                    else if (@eventos.Genero == "5")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span>Pop</span>\r\n");
#nullable restore
#line 80 "C:\Users\mnia\OneDrive - GFT Technologies SE\Documents\Workspace\Atividades\Desafio MVC\Projeto do Desafio\eventmarketplace\Views\Home\ListaEventos.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span>Diversos</span>\r\n");
#nullable restore
#line 84 "C:\Users\mnia\OneDrive - GFT Technologies SE\Documents\Workspace\Atividades\Desafio MVC\Projeto do Desafio\eventmarketplace\Views\Home\ListaEventos.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>R$");
#nullable restore
#line 85 "C:\Users\mnia\OneDrive - GFT Technologies SE\Documents\Workspace\Atividades\Desafio MVC\Projeto do Desafio\eventmarketplace\Views\Home\ListaEventos.cshtml"
                 Write(eventos.ValorDoTicket.ToString("f2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 86 "C:\Users\mnia\OneDrive - GFT Technologies SE\Documents\Workspace\Atividades\Desafio MVC\Projeto do Desafio\eventmarketplace\Views\Home\ListaEventos.cshtml"
               Write(eventos.CasaDeShow.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 87 "C:\Users\mnia\OneDrive - GFT Technologies SE\Documents\Workspace\Atividades\Desafio MVC\Projeto do Desafio\eventmarketplace\Views\Home\ListaEventos.cshtml"
               Write(eventos.Data.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 88 "C:\Users\mnia\OneDrive - GFT Technologies SE\Documents\Workspace\Atividades\Desafio MVC\Projeto do Desafio\eventmarketplace\Views\Home\ListaEventos.cshtml"
               Write(eventos.Ingresso);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 2955, "\"", 2989, 2);
            WriteAttributeValue("", 2962, "/Home/novaVenda/", 2962, 16, true);
#nullable restore
#line 89 "C:\Users\mnia\OneDrive - GFT Technologies SE\Documents\Workspace\Atividades\Desafio MVC\Projeto do Desafio\eventmarketplace\Views\Home\ListaEventos.cshtml"
WriteAttributeValue("", 2978, eventos.Id, 2978, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Comprar</a></td>\r\n                \r\n            </tr>\r\n");
#nullable restore
#line 92 "C:\Users\mnia\OneDrive - GFT Technologies SE\Documents\Workspace\Atividades\Desafio MVC\Projeto do Desafio\eventmarketplace\Views\Home\ListaEventos.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EventMarketplace.Models.Evento>> Html { get; private set; }
    }
}
#pragma warning restore 1591
