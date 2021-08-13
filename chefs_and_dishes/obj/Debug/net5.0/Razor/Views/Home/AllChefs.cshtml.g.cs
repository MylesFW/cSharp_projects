#pragma checksum "C:\Users\Myles\Desktop\Coding Dojo\C#\cSharp_projects\chefs_and_dishes\Views\Home\AllChefs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f1afeb95f6e404e367cb3c112ec7edc70be2a70"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AllChefs), @"mvc.1.0.view", @"/Views/Home/AllChefs.cshtml")]
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
#line 1 "C:\Users\Myles\Desktop\Coding Dojo\C#\cSharp_projects\chefs_and_dishes\Views\_ViewImports.cshtml"
using chefs_and_dishes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Myles\Desktop\Coding Dojo\C#\cSharp_projects\chefs_and_dishes\Views\_ViewImports.cshtml"
using chefs_and_dishes.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Myles\Desktop\Coding Dojo\C#\cSharp_projects\chefs_and_dishes\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f1afeb95f6e404e367cb3c112ec7edc70be2a70", @"/Views/Home/AllChefs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0970981d5b2dafdb9c72c5953c0ea94f189c5479", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AllChefs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Chef>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Myles\Desktop\Coding Dojo\C#\cSharp_projects\chefs_and_dishes\Views\Home\AllChefs.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<div class=""text-center"">
    <h1 class=""display-4 font-italic"">A list of our Featured Chefs!</h1><hr>
    <div class=""col-sm-6 mx-auto mx-auto"">
        <div class=""card"" >
                <div class=""card-body"">
                    <table class=""table table-striped"">
                        <tr>
                            <th>Chef</th>
                            <th>Age</th>
                            <th># of Dishes</th>
                        </tr>
");
#nullable restore
#line 20 "C:\Users\Myles\Desktop\Coding Dojo\C#\cSharp_projects\chefs_and_dishes\Views\Home\AllChefs.cshtml"
                         foreach(var chef in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 24 "C:\Users\Myles\Desktop\Coding Dojo\C#\cSharp_projects\chefs_and_dishes\Views\Home\AllChefs.cshtml"
                               Write(chef.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n                                    ");
#nullable restore
#line 25 "C:\Users\Myles\Desktop\Coding Dojo\C#\cSharp_projects\chefs_and_dishes\Views\Home\AllChefs.cshtml"
                               Write(chef.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n");
#nullable restore
#line 28 "C:\Users\Myles\Desktop\Coding Dojo\C#\cSharp_projects\chefs_and_dishes\Views\Home\AllChefs.cshtml"
                                      
                                        int now = int.Parse(DateTime.Now.ToString("yyyyMMdd"));
                                        int dob = int.Parse(@chef.DOB.ToString("yyyyMMdd"));
                                        int age = (now - dob) / 10000;
                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    ");
#nullable restore
#line 33 "C:\Users\Myles\Desktop\Coding Dojo\C#\cSharp_projects\chefs_and_dishes\Views\Home\AllChefs.cshtml"
                               Write(age);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n");
#nullable restore
#line 36 "C:\Users\Myles\Desktop\Coding Dojo\C#\cSharp_projects\chefs_and_dishes\Views\Home\AllChefs.cshtml"
                                     if (chef.CreatedDishes == null)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <p>0</p>\r\n");
#nullable restore
#line 39 "C:\Users\Myles\Desktop\Coding Dojo\C#\cSharp_projects\chefs_and_dishes\Views\Home\AllChefs.cshtml"
                                    }
                                    else
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\Myles\Desktop\Coding Dojo\C#\cSharp_projects\chefs_and_dishes\Views\Home\AllChefs.cshtml"
                                   Write(chef.CreatedDishes.Count());

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\Myles\Desktop\Coding Dojo\C#\cSharp_projects\chefs_and_dishes\Views\Home\AllChefs.cshtml"
                                                                   ;
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 46 "C:\Users\Myles\Desktop\Coding Dojo\C#\cSharp_projects\chefs_and_dishes\Views\Home\AllChefs.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Chef>> Html { get; private set; }
    }
}
#pragma warning restore 1591