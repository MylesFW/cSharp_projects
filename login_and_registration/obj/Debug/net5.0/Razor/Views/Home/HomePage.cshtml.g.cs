#pragma checksum "C:\Users\Myles\Desktop\Coding Dojo\C#\cSharp_projects\login_and_registration\Views\Home\HomePage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "50d7c8d2c66a9466681cdfa2f431547362cad924"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_HomePage), @"mvc.1.0.view", @"/Views/Home/HomePage.cshtml")]
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
#line 1 "C:\Users\Myles\Desktop\Coding Dojo\C#\cSharp_projects\login_and_registration\Views\_ViewImports.cshtml"
using login_and_registration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Myles\Desktop\Coding Dojo\C#\cSharp_projects\login_and_registration\Views\_ViewImports.cshtml"
using login_and_registration.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Myles\Desktop\Coding Dojo\C#\cSharp_projects\login_and_registration\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50d7c8d2c66a9466681cdfa2f431547362cad924", @"/Views/Home/HomePage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e78fafdc7be96e8e8978422e1fa15a318cca3919", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_HomePage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Myles\Desktop\Coding Dojo\C#\cSharp_projects\login_and_registration\Views\Home\HomePage.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center d-flex"">
    <h2>Welcome to CheeZie's Rat Emporium and Child Casino</h2><h5>&#169;</h5><h2>!</h2>
</div>
<div class=""text-left d-flex"">
    <h1>YOU HAVE LOGGED IN</h1>
    <div>
        <a href=""logout"">Logout</a>
    </div>
</div>
</table>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; }
    }
}
#pragma warning restore 1591
