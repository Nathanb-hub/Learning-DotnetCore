#pragma checksum "C:\Users\nathb\Desktop\Courses\Dotnet Core\FirstAppCourse\FirstAppCourse\FirstAppCourse\Views\App\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "021a9e41b5ba801aa8fc76f5c078fc88bb40741a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_App_index), @"mvc.1.0.view", @"/Views/App/index.cshtml")]
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
#line 1 "C:\Users\nathb\Desktop\Courses\Dotnet Core\FirstAppCourse\FirstAppCourse\FirstAppCourse\Views\_ViewImports.cshtml"
using FirstAppCourse.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nathb\Desktop\Courses\Dotnet Core\FirstAppCourse\FirstAppCourse\FirstAppCourse\Views\_ViewImports.cshtml"
using FirstAppCourse.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"021a9e41b5ba801aa8fc76f5c078fc88bb40741a", @"/Views/App/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f38e67cac05683a1de6a00ffe2ce044310ec7de", @"/Views/_ViewImports.cshtml")]
    public class Views_App_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\nathb\Desktop\Courses\Dotnet Core\FirstAppCourse\FirstAppCourse\FirstAppCourse\Views\App\index.cshtml"
  
    ViewBag.Title ="First App with ViewBag"; 


#line default
#line hidden
#nullable disable
            WriteLiteral(@"<p> hello from our view template</p>
    <div class=""main"">
        <ul>
            <li>1</li>
            <li>2</li>
            <li>3</li>
        </ul>
    </div>
    <div class=""second"">
        <ul>
            <li>4</li>
            <li>5</li>
            <li>6</li>
        </ul>
    </div>
    <div class=""third"">
        <ul>
            <li>7</li>
            <li>8</li>
            <li>9</li>
        </ul>
    </div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
