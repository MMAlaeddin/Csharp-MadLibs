#pragma checksum "/Users/Guest/Desktop/MadLibs.Solution/Views/Home/Form.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef9130bc917b307e015cbf30c72c37c7c078cbc7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Form), @"mvc.1.0.view", @"/Views/Home/Form.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Form.cshtml", typeof(AspNetCore.Views_Home_Form))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef9130bc917b307e015cbf30c72c37c7c078cbc7", @"/Views/Home/Form.cshtml")]
    public class Views_Home_Form : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 25, true);
            WriteLiteral("<!DOCTYPE html>\n<html>\n  ");
            EndContext();
            BeginContext(25, 191, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef9130bc917b307e015cbf30c72c37c7c078cbc72817", async() => {
                BeginContext(31, 178, true);
                WriteLiteral("\n    <meta charset=\'utf-8\'>\n    <title>Create a Custom MadLib!</title>\n    <link rel=\'stylesheet\' href=\'https://maxcdn.bootstrapcdn.com/bootstrap/3.2.0/css/bootstrap.min.css\'>\n  ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(216, 3, true);
            WriteLiteral("\n  ");
            EndContext();
            BeginContext(219, 2141, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef9130bc917b307e015cbf30c72c37c7c078cbc74164", async() => {
                BeginContext(225, 2128, true);
                WriteLiteral(@"
    <h1>Fill in the following boxes to complete a Madlibs story! We hope you enjoy the adventure.</h1>
    <form action=""/story2"" method=""post"">
      <label for=""Adj1"">Adjective</label>
      <input id=""Adj1"" name=""Adj1"" type=""text"">
      <label for=""Adj2"">Adjective</label>
      <input id=""Adj2"" name=""Adj2"" type=""text"">
      <label for=""Noun1"">Noun</label>
      <input id=""Noun1"" name=""Noun1"" type=""text"">
      <label for=""Noun2"">Noun</label>
      <input id=""Noun2"" name=""Noun2"" type=""text"">
      <label for=""PluralNoun1"">Plural Noun</label>
      <input id=""PluralNoun1"" name=""PluralNoun1"" type=""text"">
      <label for=""Game1"">Game</label>
      <input id=""Game1"" name=""Game1"" type=""text"">
      <label for=""PluralNoun2"">Plural Noun</label>
      <input id=""PluralNoun2"" name=""PluralNoun2"" type=""text"">
      <label for=""VerbIng1"">Verb ending with ""-ing""</label>
      <input id=""VerbIng1"" name=""VerbIng1"" type=""text"">
      <label for=""VerbIng2"">Verb ending with ""-ing""</label>
      <input id=""VerbIng2"" name=");
                WriteLiteral(@"""VerbIng2"" type=""text"">
      <label for=""PluralNoun3"">Plural Noun</label>
      <input id=""PluralNoun3"" name=""PluralNoun3"" type=""text"">
      <label for=""VerbIng3"">Verb ending with ""-ing""</label>
      <input id=""VerbIng3"" name=""VerbIng3"" type=""text"">
      <label for=""Noun3"">Noun</label>
      <input id=""Noun3"" name=""Noun3"" type=""text"">
      <label for=""Plant1"">Plant</label>
      <input id=""Plant1"" name=""Plant1"" type=""text"">
      <label for=""Body1"">Part of the body</label>
      <input id=""Body1"" name=""Body1"" type=""text"">
      <label for=""Place1"">Place</label>
      <input id=""Place1"" name=""Place1"" type=""text"">
      <label for=""VerbIng4"">Verb ending with ""-ing""</label>
      <input id=""VerbIng4"" name=""VerbIng4"" type=""text"">
      <label for=""Adj3"">Adjective</label>
      <input id=""Adj3"" name=""Adj3"" type=""text"">
      <label for=""Number"">Number</label>
      <input id=""Number"" name=""Number"" type=""text"">
      <label for=""PluralNoun4"">Plural Noun</label>
      <input id=""PluralNoun4"" name=""PluralNoun4"" ");
                WriteLiteral("type=\"text\">\n      <button type =\"submit\">See My Story!</button> \n    </form>\n  ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2360, 8, true);
            WriteLiteral("\n</html>");
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
