#pragma checksum "C:\Users\Shayne Maravillo\source\repos\AdvanceWebShaneMaravillo\AdvanceWebShaneMaravillo.Web\Views\Category\UpdateTitle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17bed734d6055e7986be80b76a5d3d994eef3fe6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_UpdateTitle), @"mvc.1.0.view", @"/Views/Category/UpdateTitle.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Category/UpdateTitle.cshtml", typeof(AspNetCore.Views_Category_UpdateTitle))]
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
#line 1 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebShaneMaravillo\AdvanceWebShaneMaravillo.Web\Views\_ViewImports.cshtml"
using AdvanceWebShaneMaravillo.Web;

#line default
#line hidden
#line 2 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebShaneMaravillo\AdvanceWebShaneMaravillo.Web\Views\_ViewImports.cshtml"
using AdvanceWebShaneMaravillo.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17bed734d6055e7986be80b76a5d3d994eef3fe6", @"/Views/Category/UpdateTitle.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ed6b5a64add3e54cb142404c55f1a31915e2590", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_UpdateTitle : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AdvanceWebShaneMaravillo.Web.ViewModels.Categories.UpdateTitleViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/home/categories/update-title"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebShaneMaravillo\AdvanceWebShaneMaravillo.Web\Views\Category\UpdateTitle.cshtml"
  
    ViewData["Title"] = "UpdateTitle";
    Layout = "~/Views/Shared/_PublicLayout.cshtml";

#line default
#line hidden
            BeginContext(180, 82, true);
            WriteLiteral("\r\n<h2>Update Title</h2>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-6\">\r\n        ");
            EndContext();
            BeginContext(262, 966, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0cd12ee16ce4a0bbf35cb4cc6f57d2d", async() => {
                BeginContext(322, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(337, 24, false);
#line 12 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebShaneMaravillo\AdvanceWebShaneMaravillo.Web\Views\Category\UpdateTitle.cshtml"
       Write(Html.ValidationSummary());

#line default
#line hidden
                EndContext();
                BeginContext(361, 86, true);
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n                <input type=\"hidden\" name=\"Id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 447, "\"", 464, 1);
#line 14 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebShaneMaravillo\AdvanceWebShaneMaravillo.Web\Views\Category\UpdateTitle.cshtml"
WriteAttributeValue("", 455, Model.Id, 455, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(465, 121, true);
                WriteLiteral(" />\r\n                <label for=\"Name\">Name:</label>\r\n                <input type=\"text\" class=\"form-control\" name=\"Name\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 586, "\"", 605, 1);
#line 16 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebShaneMaravillo\AdvanceWebShaneMaravillo.Web\Views\Category\UpdateTitle.cshtml"
WriteAttributeValue("", 594, Model.Name, 594, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(606, 222, true);
                WriteLiteral(" />\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label for=\"Description\">Description</label>\r\n                <textarea class=\"form-control\" rows=\"4\" name=\"Description\">\r\n                    ");
                EndContext();
                BeginContext(829, 17, false);
#line 21 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebShaneMaravillo\AdvanceWebShaneMaravillo.Web\Views\Category\UpdateTitle.cshtml"
               Write(Model.Description);

#line default
#line hidden
                EndContext();
                BeginContext(846, 241, true);
                WriteLiteral("\r\n                </textarea>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label for=\"Post Expiry\">Post Expiry:</label>\r\n                <input type=\"text\" class=\"form-control\" name=\"PostExpiry\" id=\"postExpiry\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1087, "\"", 1112, 1);
#line 26 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebShaneMaravillo\AdvanceWebShaneMaravillo.Web\Views\Category\UpdateTitle.cshtml"
WriteAttributeValue("", 1095, Model.PostExpiry, 1095, 17, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1113, 108, true);
                WriteLiteral(" />\r\n            </div>\r\n            <button type=\"submit\" class=\"btn btn-default\">Submit</button>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1228, 24, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("pageScripts", async() => {
                BeginContext(1273, 127, true);
                WriteLiteral("\r\n    <script>\r\n    $(function () {\r\n        $(\"#postExpiry\").datepicker({ dateFormat: \'dd/mm/yy\' });\r\n    });\r\n    </script>\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AdvanceWebShaneMaravillo.Web.ViewModels.Categories.UpdateTitleViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591