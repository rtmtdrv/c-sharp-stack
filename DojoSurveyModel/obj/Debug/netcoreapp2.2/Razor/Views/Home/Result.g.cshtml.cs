#pragma checksum "/Users/arttodorov/Desktop/Coding Dojo Files/c-sharp-stack/DojoSurveyModel/Views/Home/Result.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "345deb24c605fc592a47efb36e18ea2cf5ff69cc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Result), @"mvc.1.0.view", @"/Views/Home/Result.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Result.cshtml", typeof(AspNetCore.Views_Home_Result))]
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
#line 1 "/Users/arttodorov/Desktop/Coding Dojo Files/c-sharp-stack/DojoSurveyModel/Views/_ViewImports.cshtml"
using DojoSurveyModel;

#line default
#line hidden
#line 5 "/Users/arttodorov/Desktop/Coding Dojo Files/c-sharp-stack/DojoSurveyModel/Views/Home/Result.cshtml"
using DojoSurveyModel.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"345deb24c605fc592a47efb36e18ea2cf5ff69cc", @"/Views/Home/Result.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e4289d96fd8ae90127722315813cc45e29f652a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Result : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Survey>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/arttodorov/Desktop/Coding Dojo Files/c-sharp-stack/DojoSurveyModel/Views/Home/Result.cshtml"
  
    ViewData["Title"] = "Result";

#line default
#line hidden
            BeginContext(39, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(84, 373, true);
            WriteLiteral(@"
<h1>Results</h1>
    <div class=""jumbotron"">
        <h1>Submitted Info</h1>
        <hr class=""my-4"">
        <div class=""row"">
            <div class=""col-6"">
                <h3>Name:</h3>
                <h3>Dojo Location:</h3>
                <h3>Language:</h3>
                <h3>Comment:</h3>
            </div>
            <div class=""col-6"">
                <h3>");
            EndContext();
            BeginContext(458, 10, false);
#line 20 "/Users/arttodorov/Desktop/Coding Dojo Files/c-sharp-stack/DojoSurveyModel/Views/Home/Result.cshtml"
               Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(468, 26, true);
            WriteLiteral("</h3>\n                <h3>");
            EndContext();
            BeginContext(495, 14, false);
#line 21 "/Users/arttodorov/Desktop/Coding Dojo Files/c-sharp-stack/DojoSurveyModel/Views/Home/Result.cshtml"
               Write(Model.Location);

#line default
#line hidden
            EndContext();
            BeginContext(509, 26, true);
            WriteLiteral("</h3>\n                <h3>");
            EndContext();
            BeginContext(536, 14, false);
#line 22 "/Users/arttodorov/Desktop/Coding Dojo Files/c-sharp-stack/DojoSurveyModel/Views/Home/Result.cshtml"
               Write(Model.Language);

#line default
#line hidden
            EndContext();
            BeginContext(550, 26, true);
            WriteLiteral("</h3>\n                <h3>");
            EndContext();
            BeginContext(577, 13, false);
#line 23 "/Users/arttodorov/Desktop/Coding Dojo Files/c-sharp-stack/DojoSurveyModel/Views/Home/Result.cshtml"
               Write(Model.Comment);

#line default
#line hidden
            EndContext();
            BeginContext(590, 136, true);
            WriteLiteral("</h3>\n            </div>\n            <br>\n            <a href=\"/\" class=\"btn btn-dark btn-lg mt-5\">Go Back</a>\n        </div>\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Survey> Html { get; private set; }
    }
}
#pragma warning restore 1591
