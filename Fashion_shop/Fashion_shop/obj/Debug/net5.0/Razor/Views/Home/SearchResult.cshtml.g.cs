#pragma checksum "/Users/phamcongly/Documents/GitHub/Fashion_shop/Fashion_shop/Fashion_shop/Views/Home/SearchResult.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "95a4129c856ce097f5154fbb325cbbf72eb1a593"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_SearchResult), @"mvc.1.0.view", @"/Views/Home/SearchResult.cshtml")]
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
#line 1 "/Users/phamcongly/Documents/GitHub/Fashion_shop/Fashion_shop/Fashion_shop/Views/_ViewImports.cshtml"
using Fashion_shop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/phamcongly/Documents/GitHub/Fashion_shop/Fashion_shop/Fashion_shop/Views/_ViewImports.cshtml"
using Fashion_shop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95a4129c856ce097f5154fbb325cbbf72eb1a593", @"/Views/Home/SearchResult.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d5e5ff572e834d76182c276324ef5f44f60458f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_SearchResult : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Fashion_shop.Models.Item>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("250"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/phamcongly/Documents/GitHub/Fashion_shop/Fashion_shop/Fashion_shop/Views/Home/SearchResult.cshtml"
  
    ViewData["Title"] = "Tìm kiếm";
    Layout = "~/Views/Shared/_LayoutMain.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\n<html lang=\"en\">\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "95a4129c856ce097f5154fbb325cbbf72eb1a5934117", async() => {
                WriteLiteral("\n    <title>Seach</title>\n    <meta charset=\"utf-8\">\n    <link rel=\"stylesheet\" href=\"/css/View/Items/Index.css\">\n");
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
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "95a4129c856ce097f5154fbb325cbbf72eb1a5935187", async() => {
                WriteLiteral("\n    <h3>Từ khóa liên quan đến \"");
#nullable restore
#line 14 "/Users/phamcongly/Documents/GitHub/Fashion_shop/Fashion_shop/Fashion_shop/Views/Home/SearchResult.cshtml"
                          Write(ViewBag.Keyword);

#line default
#line hidden
#nullable disable
                WriteLiteral("\"</h3>\n\n");
#nullable restore
#line 16 "/Users/phamcongly/Documents/GitHub/Fashion_shop/Fashion_shop/Fashion_shop/Views/Home/SearchResult.cshtml"
     if (Model.Count > 0)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <p> Tìm được ");
#nullable restore
#line 18 "/Users/phamcongly/Documents/GitHub/Fashion_shop/Fashion_shop/Fashion_shop/Views/Home/SearchResult.cshtml"
                Write(Model.Count);

#line default
#line hidden
#nullable disable
                WriteLiteral(" sản phẩm.</p>\n        <div class=\"row products\">\n");
#nullable restore
#line 20 "/Users/phamcongly/Documents/GitHub/Fashion_shop/Fashion_shop/Fashion_shop/Views/Home/SearchResult.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div class=\"col-sm-3 col-lg-3 col-md-3\">\n                    <div class=\"thumbnail\" style=\"margin-left: 20px;\">\n                        <a style=\"text-decoration-line: none;\"");
                BeginWriteAttribute("href", " href=\"", 712, "\"", 772, 1);
#nullable restore
#line 24 "/Users/phamcongly/Documents/GitHub/Fashion_shop/Fashion_shop/Fashion_shop/Views/Home/SearchResult.cshtml"
WriteAttributeValue("", 719, Url.Action("Details", "Items", new { id = item.id }), 719, 53, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "95a4129c856ce097f5154fbb325cbbf72eb1a5937246", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 25 "/Users/phamcongly/Documents/GitHub/Fashion_shop/Fashion_shop/Fashion_shop/Views/Home/SearchResult.cshtml"
AddHtmlAttributeValue("", 813, item.id, 813, 8, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 828, "~/img_items/", 828, 12, true);
#nullable restore
#line 25 "/Users/phamcongly/Documents/GitHub/Fashion_shop/Fashion_shop/Fashion_shop/Views/Home/SearchResult.cshtml"
AddHtmlAttributeValue("", 840, item.Image, 840, 11, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                            <div class=\"item-info\">\n                                <h5 style=\"color: black; text-decoration: none; font-family: Arial, Helvetica, sans-serif; font-weight: lighter; margin-bottom: 5px;\">");
#nullable restore
#line 27 "/Users/phamcongly/Documents/GitHub/Fashion_shop/Fashion_shop/Fashion_shop/Views/Home/SearchResult.cshtml"
                                                                                                                                                                 Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\n                                <h6 style=\"color: black; text-decoration: none; font-weight: bold; margin: 0; margin-left: 5px;\">");
#nullable restore
#line 28 "/Users/phamcongly/Documents/GitHub/Fashion_shop/Fashion_shop/Fashion_shop/Views/Home/SearchResult.cshtml"
                                                                                                                            Write(item.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral(" đ</h6>\n                            </div>\n                        </a>\n                    </div>\n                </div>\n");
#nullable restore
#line 33 "/Users/phamcongly/Documents/GitHub/Fashion_shop/Fashion_shop/Fashion_shop/Views/Home/SearchResult.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div>\n");
#nullable restore
#line 35 "/Users/phamcongly/Documents/GitHub/Fashion_shop/Fashion_shop/Fashion_shop/Views/Home/SearchResult.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <p>Không tìm thấy sản phẩm phù hợp.</p>\n");
#nullable restore
#line 39 "/Users/phamcongly/Documents/GitHub/Fashion_shop/Fashion_shop/Fashion_shop/Views/Home/SearchResult.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"    <div style=""height: 30px""></div>
    <!-- Start Script -->
    <script src=""assets/js/jquery-1.11.0.min.js""></script>
    <script src=""assets/js/jquery-migrate-1.2.1.min.js""></script>
    <script src=""assets/js/bootstrap.bundle.min.js""></script>
    <script src=""assets/js/templatemo.js""></script>
    <script src=""assets/js/custom.js""></script>
");
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
            WriteLiteral("\n</html>\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Fashion_shop.Models.Item>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591