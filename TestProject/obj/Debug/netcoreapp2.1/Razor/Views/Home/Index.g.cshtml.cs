#pragma checksum "C:\Users\ZrinkoPuljic\OneDrive - iOLAP, Inc\private\.NETCore-master\TestProject\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e27c1f7d74c5b0c71e8bac97e6189ece866be942"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\ZrinkoPuljic\OneDrive - iOLAP, Inc\private\.NETCore-master\TestProject\Views\_ViewImports.cshtml"
using TestProject;

#line default
#line hidden
#line 2 "C:\Users\ZrinkoPuljic\OneDrive - iOLAP, Inc\private\.NETCore-master\TestProject\Views\_ViewImports.cshtml"
using TestProject.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e27c1f7d74c5b0c71e8bac97e6189ece866be942", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65c2accbd113524b139f3e5bda5a32a62bfc625b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\ZrinkoPuljic\OneDrive - iOLAP, Inc\private\.NETCore-master\TestProject\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(42, 1231, true);
            WriteLiteral(@"

    <section class=""featured"">
        <div class=""content-wrapper"">
            <hgroup class=""title"">

                <h2>Test project</h2>

                <p><strong>Project is organized as follows:</strong></p>
                <ul>
                    <li>
                        Autofac for dependency injections
                    </li>
                    <li>
                        <strong>TestProject.Client</strong>
                        <br />Views and controllers of main application
                    </li>
                    <li>
                        <strong>TestProject.Contracts</strong>
                        <br />Interfaces and Entities
                    </li>
                    <li>
                        <strong>TestProject.Domain</strong>
                        <br />Bussines logic and service layer code
                    </li>
                    <li>
                        <strong>TestProject.Infrastructure</strong>
                        <br />All code which communi");
            WriteLiteral("cates with database is here.\n                        <br />I\'ve used linq and EF code first\n                    </li>\n                </ul>              \n            </hgroup>\n\n        </div>\n    </section>\n");
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