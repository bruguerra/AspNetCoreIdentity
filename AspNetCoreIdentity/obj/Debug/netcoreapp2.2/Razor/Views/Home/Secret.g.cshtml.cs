#pragma checksum "C:\dotNetCore\AspNetCoreIdentity\AspNetCoreIdentity\Views\Home\Secret.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a87cb0778cf09f2e405c931b318fbe5a7fe76468"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Secret), @"mvc.1.0.view", @"/Views/Home/Secret.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Secret.cshtml", typeof(AspNetCore.Views_Home_Secret))]
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
#line 1 "C:\dotNetCore\AspNetCoreIdentity\AspNetCoreIdentity\Views\_ViewImports.cshtml"
using AspNetCoreIdentity;

#line default
#line hidden
#line 2 "C:\dotNetCore\AspNetCoreIdentity\AspNetCoreIdentity\Views\_ViewImports.cshtml"
using AspNetCoreIdentity.Models;

#line default
#line hidden
#line 1 "C:\dotNetCore\AspNetCoreIdentity\AspNetCoreIdentity\Views\Home\Secret.cshtml"
using AspNetCoreIdentity.Extensions;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a87cb0778cf09f2e405c931b318fbe5a7fe76468", @"/Views/Home/Secret.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b55bec701bb5c4324487dfe3a90e1f98fbf801d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Secret : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\dotNetCore\AspNetCoreIdentity\AspNetCoreIdentity\Views\Home\Secret.cshtml"
  
    ViewData["Title"] = "Secret Policy";

#line default
#line hidden
            BeginContext(87, 4, true);
            WriteLiteral("<h1>");
            EndContext();
            BeginContext(92, 17, false);
#line 5 "C:\dotNetCore\AspNetCoreIdentity\AspNetCoreIdentity\Views\Home\Secret.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(109, 70, true);
            WriteLiteral("</h1>\r\n\r\n<p>Use this page to detail your site\'s secret policy.</p>\r\n\r\n");
            EndContext();
#line 9 "C:\dotNetCore\AspNetCoreIdentity\AspNetCoreIdentity\Views\Home\Secret.cshtml"
  
    if (this.ifClaim("Produtos", "Adicionar"))
    {

#line default
#line hidden
            BeginContext(238, 62, true);
            WriteLiteral("        <p>Você só verá se tiver permissão de adicionar!</p>\r\n");
            EndContext();
#line 13 "C:\dotNetCore\AspNetCoreIdentity\AspNetCoreIdentity\Views\Home\Secret.cshtml"
    }

#line default
#line hidden
            BeginContext(310, 13, true);
            WriteLiteral("\r\n<div>\r\n    ");
            EndContext();
            BeginContext(324, 80, false);
#line 17 "C:\dotNetCore\AspNetCoreIdentity\AspNetCoreIdentity\Views\Home\Secret.cshtml"
Write(Html.ActionLink("Secret","Secret").ifClaimShow(Context, "Produtos", "Adicionar"));

#line default
#line hidden
            EndContext();
            BeginContext(404, 40, true);
            WriteLiteral("\r\n</div>\r\n<br />\r\n<div>\r\n    <a href=\"#\"");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 444, "\"", 518, 3);
            WriteAttributeValue("", 452, "btn", 452, 3, true);
            WriteAttributeValue(" ", 455, "btn-danger", 456, 11, true);
#line 21 "C:\dotNetCore\AspNetCoreIdentity\AspNetCoreIdentity\Views\Home\Secret.cshtml"
WriteAttributeValue(" ", 466, Html.Raw(this.ifClaimShow("Produtos","Adicionar")), 467, 51, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(519, 28, true);
            WriteLiteral(">Excluir</a>\r\n\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
