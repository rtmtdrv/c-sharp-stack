#pragma checksum "/Users/arttodorov/Desktop/Coding Dojo Files/c-sharp-stack/ViewModelFun/Views/Home/SingleUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "18c24d34c75a017867bf77229bc77983b6730ef1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_SingleUser), @"mvc.1.0.view", @"/Views/Home/SingleUser.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/SingleUser.cshtml", typeof(AspNetCore.Views_Home_SingleUser))]
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
#line 1 "/Users/arttodorov/Desktop/Coding Dojo Files/c-sharp-stack/ViewModelFun/Views/_ViewImports.cshtml"
using ViewModelFun;

#line default
#line hidden
#line 2 "/Users/arttodorov/Desktop/Coding Dojo Files/c-sharp-stack/ViewModelFun/Views/_ViewImports.cshtml"
using ViewModelFun.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18c24d34c75a017867bf77229bc77983b6730ef1", @"/Views/Home/SingleUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7312364e6c23e4cb7805f9e5f986831fce186000", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_SingleUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/arttodorov/Desktop/Coding Dojo Files/c-sharp-stack/ViewModelFun/Views/Home/SingleUser.cshtml"
  
    ViewData["Title"] = "User";
    ViewData["Header"] = "Here is a User!";

#line default
#line hidden
            BeginContext(93, 53, true);
            WriteLiteral("\n<h1 style=\"text-align: center; margin-bottom:30px;\">");
            EndContext();
            BeginContext(147, 18, false);
#line 7 "/Users/arttodorov/Desktop/Coding Dojo Files/c-sharp-stack/ViewModelFun/Views/Home/SingleUser.cshtml"
                                               Write(ViewData["Header"]);

#line default
#line hidden
            EndContext();
            BeginContext(165, 73, true);
            WriteLiteral("</h1>\n<div style=\"text-align: center;\">\n    <h1 style=\"font-size: 48px;\">");
            EndContext();
            BeginContext(239, 15, false);
#line 9 "/Users/arttodorov/Desktop/Coding Dojo Files/c-sharp-stack/ViewModelFun/Views/Home/SingleUser.cshtml"
                            Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(254, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(256, 14, false);
#line 9 "/Users/arttodorov/Desktop/Coding Dojo Files/c-sharp-stack/ViewModelFun/Views/Home/SingleUser.cshtml"
                                             Write(Model.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(270, 12, true);
            WriteLiteral("</h1>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; }
    }
}
#pragma warning restore 1591
