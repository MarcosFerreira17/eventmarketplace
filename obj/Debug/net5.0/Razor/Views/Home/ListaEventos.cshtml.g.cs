#pragma checksum "C:\Users\mnia\OneDrive - GFT Technologies SE\Documents\Workspace\Atividades\Desafio MVC\EventMarketplace\Views\Home\ListaEventos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27b844b89ec5e907b952550b8dc10adc80fce37f"
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
#line 1 "C:\Users\mnia\OneDrive - GFT Technologies SE\Documents\Workspace\Atividades\Desafio MVC\EventMarketplace\Views\_ViewImports.cshtml"
using EventMarketplace;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mnia\OneDrive - GFT Technologies SE\Documents\Workspace\Atividades\Desafio MVC\EventMarketplace\Views\_ViewImports.cshtml"
using EventMarketplace.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27b844b89ec5e907b952550b8dc10adc80fce37f", @"/Views/Home/ListaEventos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0dd0c6153b728732d572975753d62c1cb58d0fc0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ListaEventos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EventMarketplace.Models.Evento>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\mnia\OneDrive - GFT Technologies SE\Documents\Workspace\Atividades\Desafio MVC\EventMarketplace\Views\Home\ListaEventos.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\mnia\OneDrive - GFT Technologies SE\Documents\Workspace\Atividades\Desafio MVC\EventMarketplace\Views\Home\ListaEventos.cshtml"
  
    ViewData["Title"] = "Lista de Eventos";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""card-header p-3"" style="" margin-top: 4.8rem"">
    <h5 class=""mb-0""><i class=""fas fa-tasks me-4""></i>Lista de Eventos</h5>
</div>

<script>
    $(document).ready(function () {
        $('#events').DataTable({
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

<table id=""events"" class=""table table-striped table-bordered"">
    <thead>
        <tr>
            <th>Id</th>
            <th>Evento</th>
            <th>Genero</th>
            <th>V");
            WriteLiteral("alor do ingresso</th>\r\n            <th>Casa de Show</th>\r\n            <th>Data</th>\r\n            <th>Qtd de Ingressos Disponiveis</th>\r\n            <th>Ações</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 49 "C:\Users\mnia\OneDrive - GFT Technologies SE\Documents\Workspace\Atividades\Desafio MVC\EventMarketplace\Views\Home\ListaEventos.cshtml"
         foreach (var eventos in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 52 "C:\Users\mnia\OneDrive - GFT Technologies SE\Documents\Workspace\Atividades\Desafio MVC\EventMarketplace\Views\Home\ListaEventos.cshtml"
               Write(eventos.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <th>\r\n                    <img src=\"https://mdbcdn.b-cdn.net/img/Photos/Avatars/avatar-5.webp\"\r\n                    class=\"shadow-1-strong rounded-circle\" style=\"width: 55px; height: auto;\">\r\n                    <span class=\"ms-2\">");
#nullable restore
#line 56 "C:\Users\mnia\OneDrive - GFT Technologies SE\Documents\Workspace\Atividades\Desafio MVC\EventMarketplace\Views\Home\ListaEventos.cshtml"
                                  Write(eventos.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </th>\r\n                <td>");
#nullable restore
#line 58 "C:\Users\mnia\OneDrive - GFT Technologies SE\Documents\Workspace\Atividades\Desafio MVC\EventMarketplace\Views\Home\ListaEventos.cshtml"
                     if (@eventos.Genero == "0")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span>Pagode</span>\r\n");
#nullable restore
#line 61 "C:\Users\mnia\OneDrive - GFT Technologies SE\Documents\Workspace\Atividades\Desafio MVC\EventMarketplace\Views\Home\ListaEventos.cshtml"
                    }
                    else if (@eventos.Genero == "1")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span>Funk</span>\r\n");
#nullable restore
#line 65 "C:\Users\mnia\OneDrive - GFT Technologies SE\Documents\Workspace\Atividades\Desafio MVC\EventMarketplace\Views\Home\ListaEventos.cshtml"
                    }
                    else if (@eventos.Genero == "2")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span>Rock</span>\r\n");
#nullable restore
#line 69 "C:\Users\mnia\OneDrive - GFT Technologies SE\Documents\Workspace\Atividades\Desafio MVC\EventMarketplace\Views\Home\ListaEventos.cshtml"
                    }
                    else if (@eventos.Genero == "3")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span>Metal</span>\r\n");
#nullable restore
#line 73 "C:\Users\mnia\OneDrive - GFT Technologies SE\Documents\Workspace\Atividades\Desafio MVC\EventMarketplace\Views\Home\ListaEventos.cshtml"
                    }
                    else if (@eventos.Genero == "4")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span>Eletronica</span>\r\n");
#nullable restore
#line 77 "C:\Users\mnia\OneDrive - GFT Technologies SE\Documents\Workspace\Atividades\Desafio MVC\EventMarketplace\Views\Home\ListaEventos.cshtml"
                    }
                    else if (@eventos.Genero == "5")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span>Pop</span>\r\n");
#nullable restore
#line 81 "C:\Users\mnia\OneDrive - GFT Technologies SE\Documents\Workspace\Atividades\Desafio MVC\EventMarketplace\Views\Home\ListaEventos.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span>Diversos</span>\r\n");
#nullable restore
#line 85 "C:\Users\mnia\OneDrive - GFT Technologies SE\Documents\Workspace\Atividades\Desafio MVC\EventMarketplace\Views\Home\ListaEventos.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>R$");
#nullable restore
#line 86 "C:\Users\mnia\OneDrive - GFT Technologies SE\Documents\Workspace\Atividades\Desafio MVC\EventMarketplace\Views\Home\ListaEventos.cshtml"
                 Write(eventos.ValorDoTicket);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 87 "C:\Users\mnia\OneDrive - GFT Technologies SE\Documents\Workspace\Atividades\Desafio MVC\EventMarketplace\Views\Home\ListaEventos.cshtml"
               Write(eventos.CasaDeShow.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 88 "C:\Users\mnia\OneDrive - GFT Technologies SE\Documents\Workspace\Atividades\Desafio MVC\EventMarketplace\Views\Home\ListaEventos.cshtml"
               Write(eventos.Data);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 89 "C:\Users\mnia\OneDrive - GFT Technologies SE\Documents\Workspace\Atividades\Desafio MVC\EventMarketplace\Views\Home\ListaEventos.cshtml"
               Write(eventos.Capacidade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 2964, "\"", 3002, 2);
            WriteAttributeValue("", 2971, "/Admin/EditarEvento/", 2971, 20, true);
#nullable restore
#line 90 "C:\Users\mnia\OneDrive - GFT Technologies SE\Documents\Workspace\Atividades\Desafio MVC\EventMarketplace\Views\Home\ListaEventos.cshtml"
WriteAttributeValue("", 2991, eventos.Id, 2991, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Comprar</a></td>\r\n            </tr>\r\n");
#nullable restore
#line 92 "C:\Users\mnia\OneDrive - GFT Technologies SE\Documents\Workspace\Atividades\Desafio MVC\EventMarketplace\Views\Home\ListaEventos.cshtml"
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
