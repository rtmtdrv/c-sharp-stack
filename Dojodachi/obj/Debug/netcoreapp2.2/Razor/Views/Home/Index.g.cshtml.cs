#pragma checksum "/Users/arttodorov/Desktop/Coding Dojo Files/c-sharp-stack/Dojodachi/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23a836e5d7420e64e459d70bad84ed23dd73382f"
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
#line 1 "/Users/arttodorov/Desktop/Coding Dojo Files/c-sharp-stack/Dojodachi/Views/_ViewImports.cshtml"
using Dojodachi;

#line default
#line hidden
#line 2 "/Users/arttodorov/Desktop/Coding Dojo Files/c-sharp-stack/Dojodachi/Views/_ViewImports.cshtml"
using Dojodachi.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23a836e5d7420e64e459d70bad84ed23dd73382f", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f823666e3659d58cebeb316cce4284db07d26c9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Pet>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/index.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "/Users/arttodorov/Desktop/Coding Dojo Files/c-sharp-stack/Dojodachi/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(59, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "23a836e5d7420e64e459d70bad84ed23dd73382f4045", async() => {
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
            BeginContext(105, 62, true);
            WriteLiteral("\r\n\r\n<div class=\"wrapper\">\r\n    <p><span>Fullness:</span>\r\n    ");
            EndContext();
            BeginContext(168, 14, false);
#line 10 "/Users/arttodorov/Desktop/Coding Dojo Files/c-sharp-stack/Dojodachi/Views/Home/Index.cshtml"
Write(Model.Fullness);

#line default
#line hidden
            EndContext();
            BeginContext(182, 32, true);
            WriteLiteral(" | <span>Happiness:</span>\r\n    ");
            EndContext();
            BeginContext(215, 15, false);
#line 11 "/Users/arttodorov/Desktop/Coding Dojo Files/c-sharp-stack/Dojodachi/Views/Home/Index.cshtml"
Write(Model.Happiness);

#line default
#line hidden
            EndContext();
            BeginContext(230, 23, true);
            WriteLiteral(" | <span>Meals:</span> ");
            EndContext();
            BeginContext(254, 11, false);
#line 11 "/Users/arttodorov/Desktop/Coding Dojo Files/c-sharp-stack/Dojodachi/Views/Home/Index.cshtml"
                                      Write(Model.Meals);

#line default
#line hidden
            EndContext();
            BeginContext(265, 36, true);
            WriteLiteral(" | \r\n    <span>Energy:</span>\r\n     ");
            EndContext();
            BeginContext(302, 12, false);
#line 13 "/Users/arttodorov/Desktop/Coding Dojo Files/c-sharp-stack/Dojodachi/Views/Home/Index.cshtml"
Write(Model.Energy);

#line default
#line hidden
            EndContext();
            BeginContext(314, 44, true);
            WriteLiteral("</p>\r\n     <div class=\"info\">\r\n         <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 358, "\"", 381, 1);
#line 15 "/Users/arttodorov/Desktop/Coding Dojo Files/c-sharp-stack/Dojodachi/Views/Home/Index.cshtml"
WriteAttributeValue("", 364, ViewBag.PetImage, 364, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(382, 13, true);
            WriteLiteral(" alt=\"PIC\">\r\n");
            EndContext();
#line 16 "/Users/arttodorov/Desktop/Coding Dojo Files/c-sharp-stack/Dojodachi/Views/Home/Index.cshtml"
           
             if (@ViewBag.Result == "Your DojoDachi didn't like that. Fullness +0, Meals -1" || @ViewBag.Result == "Your Dojodachi didn't feel like playing. Happiness +0, Energy -5")
             {

#line default
#line hidden
            BeginContext(608, 39, true);
            WriteLiteral("                 <p class=\"bad-result\">");
            EndContext();
            BeginContext(648, 14, false);
#line 19 "/Users/arttodorov/Desktop/Coding Dojo Files/c-sharp-stack/Dojodachi/Views/Home/Index.cshtml"
                                  Write(ViewBag.Result);

#line default
#line hidden
            EndContext();
            BeginContext(662, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 20 "/Users/arttodorov/Desktop/Coding Dojo Files/c-sharp-stack/Dojodachi/Views/Home/Index.cshtml"
             }
             else
             {

#line default
#line hidden
            BeginContext(719, 40, true);
            WriteLiteral("                 <p class=\"good-result\">");
            EndContext();
            BeginContext(760, 14, false);
#line 23 "/Users/arttodorov/Desktop/Coding Dojo Files/c-sharp-stack/Dojodachi/Views/Home/Index.cshtml"
                                   Write(ViewBag.Result);

#line default
#line hidden
            EndContext();
            BeginContext(774, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 24 "/Users/arttodorov/Desktop/Coding Dojo Files/c-sharp-stack/Dojodachi/Views/Home/Index.cshtml"
             }
         

#line default
#line hidden
            BeginContext(808, 358, true);
            WriteLiteral(@"     </div>
     <div class=""links"">
         <a href=""feed"" class""btn btn-primary"">Feed  -  </a>
         <a href=""play"" class""btn btn-primary"">Play  -  </a>
         <a href=""work"" class""btn btn-primary"">Work  -  </a>
         <a href=""sleep"" class""btn btn-primary"">Sleep</a>
     </div>
     <a href=""reset"" class=""btn btn-danger"">Reset</a>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pet> Html { get; private set; }
    }
}
#pragma warning restore 1591
