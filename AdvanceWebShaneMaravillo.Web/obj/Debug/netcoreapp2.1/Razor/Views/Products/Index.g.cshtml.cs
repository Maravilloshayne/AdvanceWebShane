#pragma checksum "C:\Users\Shayne Maravillo\source\repos\AdvanceWebShaneMaravillo\AdvanceWebShaneMaravillo.Web\Views\Products\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b571a54fee7d518d54da386d3146b389b0340b2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Index), @"mvc.1.0.view", @"/Views/Products/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Products/Index.cshtml", typeof(AspNetCore.Views_Products_Index))]
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
#line 1 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebShaneMaravillo\AdvanceWebShaneMaravillo.Web\Views\Products\Index.cshtml"
using AdvanceWebShaneMaravillo.Web.Infrastructures.Data.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b571a54fee7d518d54da386d3146b389b0340b2", @"/Views/Products/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ed6b5a64add3e54cb142404c55f1a31915e2590", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AdvanceWebShaneMaravillo.Web.ViewModels.Products.IndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:150px;height:150px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Upload Banner"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Upload Thumbnail"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Update Content"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Update Title"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("page-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/home/products?pageIndex=1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(138, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 5 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebShaneMaravillo\AdvanceWebShaneMaravillo.Web\Views\Products\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_PublicLayout.cshtml";

#line default
#line hidden
            BeginContext(236, 247, true);
            WriteLiteral("\r\n<h2>Index Products</h2>\r\n\r\n\r\n\r\n<div class=\"card-container col-md-8\">\r\n    <div class=\"card\">\r\n        <div class=\"card-body\">\r\n            <div class=\"input-group mb-3\">\r\n                <input id=\"searchKeyword\" type=\"text\" class=\"form-control\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 483, "\"", 514, 1);
#line 18 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebShaneMaravillo\AdvanceWebShaneMaravillo.Web\Views\Products\Index.cshtml"
WriteAttributeValue("", 491, Model.Products.Keyword, 491, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(515, 334, true);
            WriteLiteral(@" placeholder=""Search by title"" aria-label=""Search title"" aria-describedby=""basic-addon2"">
                <div class=""input-group-append"">
                    <button class=""btn btn-outline-secondary"" type=""button"" onclick=""searchTrigger()"">Search</button>
                </div>
            </div>
        </div>
    </div>

");
            EndContext();
#line 26 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebShaneMaravillo\AdvanceWebShaneMaravillo.Web\Views\Products\Index.cshtml"
      
        if (Model.Products != null)
        {
            if (Model.Products.Items.Count > 0)
            {
                foreach (Product product in Model.Products.Items)
                {

#line default
#line hidden
            BeginContext(1055, 228, true);
            WriteLiteral("                    <div class=\"card\">\r\n                        <div class=\"card-body\">\r\n                            <div class=\"row\">\r\n                                <div class=\"col-sm-3\">\r\n                                    ");
            EndContext();
            BeginContext(1283, 84, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "aea2a6e0ed9c4889afa9de612bea7fb1", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1293, "~/products/", 1293, 11, true);
#line 37 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebShaneMaravillo\AdvanceWebShaneMaravillo.Web\Views\Products\Index.cshtml"
AddHtmlAttributeValue("", 1304, product.Id, 1304, 11, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 1315, "/thumbnail.png", 1315, 14, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1367, 138, true);
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\"col-sm-9\">\r\n                                    <h4>");
            EndContext();
            BeginContext(1506, 12, false);
#line 40 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebShaneMaravillo\AdvanceWebShaneMaravillo.Web\Views\Products\Index.cshtml"
                                   Write(product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1518, 46, true);
            WriteLiteral("</h4>\r\n                                    <p>");
            EndContext();
            BeginContext(1565, 19, false);
#line 41 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebShaneMaravillo\AdvanceWebShaneMaravillo.Web\Views\Products\Index.cshtml"
                                  Write(product.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1584, 139, true);
            WriteLiteral("</p>\r\n\r\n                                    <ul class=\"list-inline\">\r\n                                        <li class=\"list-inline-item\">");
            EndContext();
            BeginContext(1723, 158, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e288faf404c407cb52a86b2fcd3058c", async() => {
                BeginContext(1796, 81, true);
                WriteLiteral("<button class=\"btn-success form-control-sm\"><i class=\"fas fa-image\"></i></button>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1732, "~/manage/posts/update-banner/", 1732, 29, true);
#line 44 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebShaneMaravillo\AdvanceWebShaneMaravillo.Web\Views\Products\Index.cshtml"
AddHtmlAttributeValue("", 1761, product.Id, 1761, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1881, 76, true);
            WriteLiteral("</li>\r\n                                        <li class=\"list-inline-item\">");
            EndContext();
            BeginContext(1957, 169, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e490b603d50442e8a546bb029e0776fe", async() => {
                BeginContext(2036, 86, true);
                WriteLiteral("<button class=\"btn-success form-control-sm\"><i class=\"fas fa-file-image\"></i></button>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1966, "~/manage/posts/update-thumbnail/", 1966, 32, true);
#line 45 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebShaneMaravillo\AdvanceWebShaneMaravillo.Web\Views\Products\Index.cshtml"
AddHtmlAttributeValue("", 1998, product.Id, 1998, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2126, 76, true);
            WriteLiteral("</li>\r\n                                        <li class=\"list-inline-item\">");
            EndContext();
            BeginContext(2202, 163, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0dd3a062bd1e42efa9418652b3c775c0", async() => {
                BeginContext(2277, 84, true);
                WriteLiteral("<button class=\"btn-success form-control-sm\"><i class=\"fas fa-file-alt\"></i></button>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2211, "~/manage/posts/update-content/", 2211, 30, true);
#line 46 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebShaneMaravillo\AdvanceWebShaneMaravillo.Web\Views\Products\Index.cshtml"
AddHtmlAttributeValue("", 2241, product.Id, 2241, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2365, 76, true);
            WriteLiteral("</li>\r\n                                        <li class=\"list-inline-item\">");
            EndContext();
            BeginContext(2441, 158, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "47b5b5464aee4a10b1fe82b545dcbc5c", async() => {
                BeginContext(2512, 83, true);
                WriteLiteral("<button class=\"btn-success form-control-sm\"><i class=\"fas fa-pen-alt\"></i></button>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2450, "~/manage/posts/update-title/", 2450, 28, true);
#line 47 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebShaneMaravillo\AdvanceWebShaneMaravillo.Web\Views\Products\Index.cshtml"
AddHtmlAttributeValue("", 2478, product.Id, 2478, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2599, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 48 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebShaneMaravillo\AdvanceWebShaneMaravillo.Web\Views\Products\Index.cshtml"
                                          
                                            if (product.IsPublished)
                                            {

#line default
#line hidden
            BeginContext(2767, 106, true);
            WriteLiteral("                                                <li class=\"list-inline-item\"><a href=\"#\" title=\"Unpublish\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2873, "\"", 2930, 5);
            WriteAttributeValue("", 2883, "confirmUnpublish(\'", 2883, 18, true);
#line 51 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebShaneMaravillo\AdvanceWebShaneMaravillo.Web\Views\Products\Index.cshtml"
WriteAttributeValue("", 2901, product.Id, 2901, 11, false);

#line default
#line hidden
            WriteAttributeValue("", 2912, "\',\'", 2912, 3, true);
#line 51 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebShaneMaravillo\AdvanceWebShaneMaravillo.Web\Views\Products\Index.cshtml"
WriteAttributeValue("", 2915, product.Name, 2915, 13, false);

#line default
#line hidden
            WriteAttributeValue("", 2928, "\')", 2928, 2, true);
            EndWriteAttribute();
            BeginContext(2931, 99, true);
            WriteLiteral("><button class=\"btn-danger form-control-sm\"><i class=\"fas fa-window-close\"></i></button></a></li>\r\n");
            EndContext();
#line 52 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebShaneMaravillo\AdvanceWebShaneMaravillo.Web\Views\Products\Index.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
            BeginContext(3174, 104, true);
            WriteLiteral("                                                <li class=\"list-inline-item\"><a href=\"#\" title=\"Publish\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 3278, "\"", 3333, 5);
            WriteAttributeValue("", 3288, "confirmPublish(\'", 3288, 16, true);
#line 55 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebShaneMaravillo\AdvanceWebShaneMaravillo.Web\Views\Products\Index.cshtml"
WriteAttributeValue("", 3304, product.Id, 3304, 11, false);

#line default
#line hidden
            WriteAttributeValue("", 3315, "\',\'", 3315, 3, true);
#line 55 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebShaneMaravillo\AdvanceWebShaneMaravillo.Web\Views\Products\Index.cshtml"
WriteAttributeValue("", 3318, product.Name, 3318, 13, false);

#line default
#line hidden
            WriteAttributeValue("", 3331, "\')", 3331, 2, true);
            EndWriteAttribute();
            BeginContext(3334, 100, true);
            WriteLiteral("><button class=\"btn-success form-control-sm\"><i class=\"fas fa-check-square\"></i></button></a></li>\r\n");
            EndContext();
#line 56 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebShaneMaravillo\AdvanceWebShaneMaravillo.Web\Views\Products\Index.cshtml"
                                            }
                                        

#line default
#line hidden
            BeginContext(3524, 179, true);
            WriteLiteral("                                    </ul>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
            EndContext();
#line 63 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebShaneMaravillo\AdvanceWebShaneMaravillo.Web\Views\Products\Index.cshtml"
                }




#line default
#line hidden
            BeginContext(3728, 83, true);
            WriteLiteral("                <ul class=\"pagination\">\r\n                    <li class=\"page-item\">");
            EndContext();
            BeginContext(3811, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69b20b318fd64b259b2a9eb429e5b44e", async() => {
                BeginContext(3867, 5, true);
                WriteLiteral("First");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3876, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 69 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebShaneMaravillo\AdvanceWebShaneMaravillo.Web\Views\Products\Index.cshtml"
                       if (Model.Products.PageIndex > 1)
                        {

#line default
#line hidden
            BeginContext(3968, 50, true);
            WriteLiteral("                            <li class=\"page-item\">");
            EndContext();
            BeginContext(4018, 121, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "61551fbd91bb468fb56539ee9fafd0df", async() => {
                BeginContext(4106, 28, false);
#line 71 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebShaneMaravillo\AdvanceWebShaneMaravillo.Web\Views\Products\Index.cshtml"
                                                                                                                                    Write(Model.Products.PageIndex - 1);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4045, "~/home/products?pageIndex=", 4045, 26, true);
#line 71 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebShaneMaravillo\AdvanceWebShaneMaravillo.Web\Views\Products\Index.cshtml"
AddHtmlAttributeValue("", 4071, Model.Products.PageIndex - 1, 4071, 31, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4139, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 72 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebShaneMaravillo\AdvanceWebShaneMaravillo.Web\Views\Products\Index.cshtml"
                        }
                    

#line default
#line hidden
            BeginContext(4196, 79, true);
            WriteLiteral("                    <li class=\"page-item\"><a class=\"page-link active\" href=\"#\">");
            EndContext();
            BeginContext(4277, 24, false);
#line 74 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebShaneMaravillo\AdvanceWebShaneMaravillo.Web\Views\Products\Index.cshtml"
                                                                           Write(Model.Products.PageIndex);

#line default
#line hidden
            EndContext();
            BeginContext(4302, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 75 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebShaneMaravillo\AdvanceWebShaneMaravillo.Web\Views\Products\Index.cshtml"
                       if ((Model.Products.PageIndex + 1) <= Model.Products.PageCount)
                        {

#line default
#line hidden
            BeginContext(4428, 50, true);
            WriteLiteral("                            <li class=\"page-item\">");
            EndContext();
            BeginContext(4478, 121, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "478dc136a83448c288e7f3277d6af5e7", async() => {
                BeginContext(4566, 28, false);
#line 77 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebShaneMaravillo\AdvanceWebShaneMaravillo.Web\Views\Products\Index.cshtml"
                                                                                                                                    Write(Model.Products.PageIndex + 1);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4505, "~/home/products?pageIndex=", 4505, 26, true);
#line 77 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebShaneMaravillo\AdvanceWebShaneMaravillo.Web\Views\Products\Index.cshtml"
AddHtmlAttributeValue("", 4531, Model.Products.PageIndex + 1, 4531, 31, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4599, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 78 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebShaneMaravillo\AdvanceWebShaneMaravillo.Web\Views\Products\Index.cshtml"
                        }
                    

#line default
#line hidden
            BeginContext(4656, 42, true);
            WriteLiteral("                    <li class=\"page-item\">");
            EndContext();
            BeginContext(4698, 88, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c929b2e2f99c47c99ca31084165c1ad6", async() => {
                BeginContext(4778, 4, true);
                WriteLiteral("Last");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4725, "~/home/products?pageIndex=", 4725, 26, true);
#line 80 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebShaneMaravillo\AdvanceWebShaneMaravillo.Web\Views\Products\Index.cshtml"
AddHtmlAttributeValue("", 4751, Model.Products.PageCount, 4751, 25, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4786, 30, true);
            WriteLiteral("</li>\r\n                </ul>\r\n");
            EndContext();
#line 82 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebShaneMaravillo\AdvanceWebShaneMaravillo.Web\Views\Products\Index.cshtml"
            }
        }
    

#line default
#line hidden
            BeginContext(4849, 1872, true);
            WriteLiteral(@"
</div>



<!--MODAL-->
<div class=""modal"" tabindex=""-1"" role=""dialog"" id=""modal-unpublish"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Unpublish Product</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <p>Are you sure you want to unpublish <span id=""modal-unpublish-title""></span>?</p>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-danger"" id=""modal-unpublish-button"">Yes</button>
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">No</button>
            </div>
        </div>
    </div>
</div>

<!--MODAL-->
<div class=""modal"" tabindex=""-1"" role=""dialog"" id=""modal-publ");
            WriteLiteral(@"ish"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Publish Product</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <p>Are you sure you want to publish <span id=""modal-publish-title""></span>?</p>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-danger"" id=""modal-publish-button"">Yes</button>
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">No</button>
            </div>
        </div>
    </div>
</div>

");
            EndContext();
            DefineSection("pageStyles", async() => {
                BeginContext(6741, 254, true);
                WriteLiteral("\r\n    <style>\r\n        h2 {\r\n            margin-top: 30px;\r\n        }\r\n\r\n        .card-container {\r\n            margin-bottom: 30px;\r\n        }\r\n\r\n        .card {\r\n            margin-top: 15px;\r\n            margin-bottom: 15px;\r\n        }\r\n    </style>\r\n");
                EndContext();
            }
            );
            BeginContext(6998, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            DefineSection("pageScripts", async() => {
                BeginContext(7023, 2254, true);
                WriteLiteral(@"
    <script>

        //////////////////////SEARCH/////////////////////////////////////////////////////////////////
        function searchTrigger() {
            window.location = ""/home/products?pageIndex=1&keyword="" + $(""#searchKeyword"").val();
        }

        $(""#searchKeyword"").keyup(function (event) {
            if (event.keyCode === 13) {
                searchTrigger();
            }
        });


        ////////////////////UNPUBLISH/////////////////////////////////////////////////////////////////
        function confirmUnpublish(id, title) {
            $(""#modal-unpublish-title"").html(title);
            $(""#modal-unpublish-button"").attr(""onclick"", ""UnpublishProducts('"" + id + ""')"");
            $(""#modal-unpublish"").modal(""show"");
        }

        function UnpublishProducts(id) {
            $.ajax({
                type: ""POST"",
                url: ""/home/products/unpublish"",
                data: { id: id },
                success: function (data) {
        ");
                WriteLiteral(@"            location.reload();
                },
                error: function (xhr) {
                    var response = JSON.parse(xhr.responseText);
                    alert(""Error Occured : "" + response.errors[0]);
                    location.reload();
                }
            });
        }

        //////////////////PUBLISH///////////////////////////////////////////////////////////////////////
        function confirmPublish(id, title) {
            $(""#modal-publish-title"").html(title);
            $(""#modal-publish-button"").attr(""onclick"", ""PublishProducts('"" + id + ""')"");
            $(""#modal-publish"").modal(""show"");
        }

        function PublishProducts(id) {
            $.ajax({
                type: ""POST"",
                url: ""/home/products/publish"",
                data: { id: id },
                success: function (data) {
                    location.reload();
                },
                error: function (xhr) {
                    var respons");
                WriteLiteral("e = JSON.parse(xhr.responseText);\r\n                    alert(\"Error Occured : \" + response.errors[0]);\r\n                    location.reload();\r\n                }\r\n            });\r\n        }\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AdvanceWebShaneMaravillo.Web.ViewModels.Products.IndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591