#pragma checksum "/Users/arttodorov/Desktop/Coding Dojo Files/c-sharp-stack/QuotingDojo/Views/Home/Quotes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b804511a508959717401b0d8ddb9ada60963a130"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Quotes), @"mvc.1.0.view", @"/Views/Home/Quotes.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Quotes.cshtml", typeof(AspNetCore.Views_Home_Quotes))]
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
#line 1 "/Users/arttodorov/Desktop/Coding Dojo Files/c-sharp-stack/QuotingDojo/Views/_ViewImports.cshtml"
using QuotingDojo;

#line default
#line hidden
#line 2 "/Users/arttodorov/Desktop/Coding Dojo Files/c-sharp-stack/QuotingDojo/Views/_ViewImports.cshtml"
using QuotingDojo.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b804511a508959717401b0d8ddb9ada60963a130", @"/Views/Home/Quotes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1590bf4c09dff90063a94a6cfc81488d471e1d42", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Quotes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/quotes.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/arttodorov/Desktop/Coding Dojo Files/c-sharp-stack/QuotingDojo/Views/Home/Quotes.cshtml"
  
    ViewData["Title"] = "Quotes";

#line default
#line hidden
            BeginContext(39, 47, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b804511a508959717401b0d8ddb9ada60963a1303966", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(86, 65, true);
            WriteLiteral("\n<div class=\"wrapper\">\n    <h1>Here are the awesome quotes!</h1>\n");
            EndContext();
#line 7 "/Users/arttodorov/Desktop/Coding Dojo Files/c-sharp-stack/QuotingDojo/Views/Home/Quotes.cshtml"
     foreach (var quote in ViewBag.Quotes)
    {

#line default
#line hidden
            BeginContext(200, 45, true);
            WriteLiteral("        <div class=\"quotes\">\n            <p>\"");
            EndContext();
            BeginContext(246, 16, false);
#line 10 "/Users/arttodorov/Desktop/Coding Dojo Files/c-sharp-stack/QuotingDojo/Views/Home/Quotes.cshtml"
           Write(quote[@"quotes"]);

#line default
#line hidden
            EndContext();
            BeginContext(262, 39, true);
            WriteLiteral("\"</p>\n            <p class=\"creator\">- ");
            EndContext();
            BeginContext(302, 13, false);
#line 11 "/Users/arttodorov/Desktop/Coding Dojo Files/c-sharp-stack/QuotingDojo/Views/Home/Quotes.cshtml"
                            Write(quote["name"]);

#line default
#line hidden
            EndContext();
            BeginContext(315, 4, true);
            WriteLiteral(" at ");
            EndContext();
            BeginContext(320, 52, false);
#line 11 "/Users/arttodorov/Desktop/Coding Dojo Files/c-sharp-stack/QuotingDojo/Views/Home/Quotes.cshtml"
                                              Write(quote["created_at"].ToString("h:mmtt on MMM d, yyy"));

#line default
#line hidden
            EndContext();
            BeginContext(372, 20, true);
            WriteLiteral("</p>\n        </div>\n");
            EndContext();
#line 13 "/Users/arttodorov/Desktop/Coding Dojo Files/c-sharp-stack/QuotingDojo/Views/Home/Quotes.cshtml"
    }

#line default
#line hidden
            BeginContext(398, 53, true);
            WriteLiteral("</div>\n<a href=\"/\" class=\"btn btn-danger\">Go Back</a>");
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
