#pragma checksum "C:\Users\mnia\OneDrive - GFT Technologies SE\Documents\Workspace\Atividades\Desafio MVC\Projeto do Desafio\eventmarketplace\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c563e5792d80ff4f3a404834d9d3c3771dc22b5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_RegisterConfirmation), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/RegisterConfirmation.cshtml")]
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
#line 1 "C:\Users\mnia\OneDrive - GFT Technologies SE\Documents\Workspace\Atividades\Desafio MVC\Projeto do Desafio\eventmarketplace\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mnia\OneDrive - GFT Technologies SE\Documents\Workspace\Atividades\Desafio MVC\Projeto do Desafio\eventmarketplace\Areas\Identity\Pages\_ViewImports.cshtml"
using EventMarketplace.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mnia\OneDrive - GFT Technologies SE\Documents\Workspace\Atividades\Desafio MVC\Projeto do Desafio\eventmarketplace\Areas\Identity\Pages\_ViewImports.cshtml"
using EventMarketplace.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\mnia\OneDrive - GFT Technologies SE\Documents\Workspace\Atividades\Desafio MVC\Projeto do Desafio\eventmarketplace\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using EventMarketplace.Areas.Identity.Pages.Account;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c563e5792d80ff4f3a404834d9d3c3771dc22b5", @"/Areas/Identity/Pages/Account/RegisterConfirmation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2df237faa521352fe8199ff5bbccd917b3e6cef2", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45a149f231c238cbf2eb9b530d7c114daf9829b8", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_RegisterConfirmation : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\mnia\OneDrive - GFT Technologies SE\Documents\Workspace\Atividades\Desafio MVC\Projeto do Desafio\eventmarketplace\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
  
    ViewData["Title"] = "Register confirmation";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div style=\"margin-left: 4rem;\">\r\n    <h1>");
#nullable restore
#line 7 "C:\Users\mnia\OneDrive - GFT Technologies SE\Documents\Workspace\Atividades\Desafio MVC\Projeto do Desafio\eventmarketplace\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
#nullable restore
#line 8 "C:\Users\mnia\OneDrive - GFT Technologies SE\Documents\Workspace\Atividades\Desafio MVC\Projeto do Desafio\eventmarketplace\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
      
        if (@Model.DisplayConfirmAccountLink)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <p>
                This app does not currently have a real email sender registered, see <a
                href=""https://aka.ms/aspaccountconf"">these
                    docs</a> for how to configure a real email sender.
                Normally this would be emailed: <a id=""confirm-link""");
            BeginWriteAttribute("href", " href=\"", 537, "\"", 571, 1);
#nullable restore
#line 15 "C:\Users\mnia\OneDrive - GFT Technologies SE\Documents\Workspace\Atividades\Desafio MVC\Projeto do Desafio\eventmarketplace\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
WriteAttributeValue("", 544, Model.EmailConfirmationUrl, 544, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Click here to confirm\r\n                    your\r\n                    account</a>\r\n            </p>\r\n");
#nullable restore
#line 19 "C:\Users\mnia\OneDrive - GFT Technologies SE\Documents\Workspace\Atividades\Desafio MVC\Projeto do Desafio\eventmarketplace\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>\r\n                Please check your email to confirm your account.\r\n            </p>\r\n");
#nullable restore
#line 25 "C:\Users\mnia\OneDrive - GFT Technologies SE\Documents\Workspace\Atividades\Desafio MVC\Projeto do Desafio\eventmarketplace\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RegisterConfirmationModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RegisterConfirmationModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RegisterConfirmationModel>)PageContext?.ViewData;
        public RegisterConfirmationModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
