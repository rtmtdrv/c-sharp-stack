#pragma checksum "/Users/arttodorov/Desktop/Coding Dojo Files/c-sharp-stack/ViewModelFun/Views/Home/Users.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f16e3c7807edde79b26caa1fd55985d1f7ee0b79"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Users), @"mvc.1.0.view", @"/Views/Home/Users.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Users.cshtml", typeof(AspNetCore.Views_Home_Users))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f16e3c7807edde79b26caa1fd55985d1f7ee0b79", @"/Views/Home/Users.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7312364e6c23e4cb7805f9e5f986831fce186000", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Users : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<User>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/arttodorov/Desktop/Coding Dojo Files/c-sharp-stack/ViewModelFun/Views/Home/Users.cshtml"
  
    ViewData["Title"] = "Users";
    ViewData["Header"] = "Here are some users!";

#line default
#line hidden
            BeginContext(87, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(106, 53, true);
            WriteLiteral("\n<h1 style=\"text-align: center; margin-bottom:30px;\">");
            EndContext();
            BeginContext(160, 18, false);
#line 8 "/Users/arttodorov/Desktop/Coding Dojo Files/c-sharp-stack/ViewModelFun/Views/Home/Users.cshtml"
                                               Write(ViewData["Header"]);

#line default
#line hidden
            EndContext();
            BeginContext(178, 77, true);
            WriteLiteral("</h1>\n<div style=\"width:30%; border:1px solid #333; padding:20px;\">\n    <!-- ");
            EndContext();
#line 10 "/Users/arttodorov/Desktop/Coding Dojo Files/c-sharp-stack/ViewModelFun/Views/Home/Users.cshtml"
           
        for(int i = 0; i<@Model.Count;i++)
        {

#line default
#line hidden
            BeginContext(311, 17, true);
            WriteLiteral("            <p><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 328, "\"", 385, 4);
            WriteAttributeValue("", 335, "/SingleUser/", 335, 12, true);
#line 13 "/Users/arttodorov/Desktop/Coding Dojo Files/c-sharp-stack/ViewModelFun/Views/Home/Users.cshtml"
WriteAttributeValue("", 347, Model[i].FirstName, 347, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 366, "/", 366, 1, true);
#line 13 "/Users/arttodorov/Desktop/Coding Dojo Files/c-sharp-stack/ViewModelFun/Views/Home/Users.cshtml"
WriteAttributeValue("", 367, Model[i].LastName, 367, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(386, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(388, 18, false);
#line 13 "/Users/arttodorov/Desktop/Coding Dojo Files/c-sharp-stack/ViewModelFun/Views/Home/Users.cshtml"
                                                                       Write(Model[i].FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(406, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(408, 17, false);
#line 13 "/Users/arttodorov/Desktop/Coding Dojo Files/c-sharp-stack/ViewModelFun/Views/Home/Users.cshtml"
                                                                                           Write(Model[i].LastName);

#line default
#line hidden
            EndContext();
            BeginContext(425, 9, true);
            WriteLiteral("</a></p>\n");
            EndContext();
#line 14 "/Users/arttodorov/Desktop/Coding Dojo Files/c-sharp-stack/ViewModelFun/Views/Home/Users.cshtml"
        }
    

#line default
#line hidden
            BeginContext(449, 6, true);
            WriteLiteral(" -->\n\n");
            EndContext();
#line 17 "/Users/arttodorov/Desktop/Coding Dojo Files/c-sharp-stack/ViewModelFun/Views/Home/Users.cshtml"
 foreach(var name in Model)
{

#line default
#line hidden
            BeginContext(485, 7, true);
            WriteLiteral("    <p>");
            EndContext();
            BeginContext(493, 14, false);
#line 19 "/Users/arttodorov/Desktop/Coding Dojo Files/c-sharp-stack/ViewModelFun/Views/Home/Users.cshtml"
  Write(name.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(507, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(509, 13, false);
#line 19 "/Users/arttodorov/Desktop/Coding Dojo Files/c-sharp-stack/ViewModelFun/Views/Home/Users.cshtml"
                  Write(name.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(522, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
#line 20 "/Users/arttodorov/Desktop/Coding Dojo Files/c-sharp-stack/ViewModelFun/Views/Home/Users.cshtml"
}

#line default
#line hidden
            BeginContext(529, 14, true);
            WriteLiteral("</div>\n\n    \n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
