#pragma checksum "D:\ASP-PROJECT\Fashion_shop\Fashion_shop\Fashion_shop\Views\Items\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "55a9b05fcdfefbab98205d596b4a83d0ea98203d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Items_Index), @"mvc.1.0.view", @"/Views/Items/Index.cshtml")]
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
#line 1 "D:\ASP-PROJECT\Fashion_shop\Fashion_shop\Fashion_shop\Views\_ViewImports.cshtml"
using Fashion_shop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ASP-PROJECT\Fashion_shop\Fashion_shop\Fashion_shop\Views\_ViewImports.cshtml"
using Fashion_shop.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ASP-PROJECT\Fashion_shop\Fashion_shop\Fashion_shop\Views\Items\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\ASP-PROJECT\Fashion_shop\Fashion_shop\Fashion_shop\Views\Items\Index.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55a9b05fcdfefbab98205d596b4a83d0ea98203d", @"/Views/Items/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a58fb4587fbf21b5fa75ff6b2433f2010bf1d785", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Items_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<Fashion_shop.Models.Item>>
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
#line 4 "D:\ASP-PROJECT\Fashion_shop\Fashion_shop\Fashion_shop\Views\Items\Index.cshtml"
  
    ViewData["Title"] = "Hello";
    Layout = "~/Views/Shared/_LayoutMain.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "55a9b05fcdfefbab98205d596b4a83d0ea98203d4446", async() => {
                WriteLiteral("\r\n    <title>Hello</title>\r\n    <meta charset=\"utf-8\">\r\n    <link rel=\"stylesheet\" href=\"css/View/Items/Index.css\">\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "55a9b05fcdfefbab98205d596b4a83d0ea98203d5539", async() => {
                WriteLiteral(@"
    <div class=""dropdown"" style=""margin-top: 10px; margin-left: 20px;"">
        <button class=""btn btn-secondary dropdown-toggle"" type=""button"" id=""sortDropdown"" data-bs-toggle=""dropdown"" aria-expanded=""false"">
            Sắp xếp theo giá
        </button>
        <ul class=""dropdown-menu"" aria-labelledby=""sortDropdown"">
            <li>
                <a class=""dropdown-item""");
                BeginWriteAttribute("href", " href=\"", 878, "\"", 932, 1);
#nullable restore
#line 28 "D:\ASP-PROJECT\Fashion_shop\Fashion_shop\Fashion_shop\Views\Items\Index.cshtml"
WriteAttributeValue("", 885, Url.Action("Index", new { sortOrder = "asc" }), 885, 47, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Giá tăng dần</a>\r\n            </li>\r\n            <li>\r\n                <a class=\"dropdown-item\"");
                BeginWriteAttribute("href", " href=\"", 1029, "\"", 1084, 1);
#nullable restore
#line 31 "D:\ASP-PROJECT\Fashion_shop\Fashion_shop\Fashion_shop\Views\Items\Index.cshtml"
WriteAttributeValue("", 1036, Url.Action("Index", new { sortOrder = "desc" }), 1036, 48, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Giá giảm dần</a>\r\n            </li>\r\n        </ul>\r\n    </div>\r\n    <div class=\"row products\">\r\n");
#nullable restore
#line 36 "D:\ASP-PROJECT\Fashion_shop\Fashion_shop\Fashion_shop\Views\Items\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"col-sm-3 col-lg-3 col-md-3\" style=\"margin-bottom: 10px;\">\r\n                <div class=\"thumbnail\" style=\"margin-left: 20px; padding-bottom: 10px;\">\r\n                    <a style=\"text-decoration-line: none;\"");
                BeginWriteAttribute("href", " href=\"", 1462, "\"", 1522, 1);
#nullable restore
#line 40 "D:\ASP-PROJECT\Fashion_shop\Fashion_shop\Fashion_shop\Views\Items\Index.cshtml"
WriteAttributeValue("", 1469, Url.Action("Details", "Items", new { id = item.id }), 1469, 53, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "55a9b05fcdfefbab98205d596b4a83d0ea98203d8164", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 41 "D:\ASP-PROJECT\Fashion_shop\Fashion_shop\Fashion_shop\Views\Items\Index.cshtml"
AddHtmlAttributeValue("", 1560, item.id, 1560, 8, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1575, "~/img_items/", 1575, 12, true);
#nullable restore
#line 41 "D:\ASP-PROJECT\Fashion_shop\Fashion_shop\Fashion_shop\Views\Items\Index.cshtml"
AddHtmlAttributeValue("", 1587, item.Image, 1587, 11, false);

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
                WriteLiteral("\r\n                        <div class=\"item-info\">\r\n                            <h5 style=\"color: black; text-decoration: none; font-family: Arial, Helvetica, sans-serif; font-weight: lighter; margin-bottom: 5px;\">");
#nullable restore
#line 43 "D:\ASP-PROJECT\Fashion_shop\Fashion_shop\Fashion_shop\Views\Items\Index.cshtml"
                                                                                                                                                             Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n                            <h6 style=\"color: black; text-decoration: none; font-weight: bold; margin: 0; margin-left: 5px;\">");
#nullable restore
#line 44 "D:\ASP-PROJECT\Fashion_shop\Fashion_shop\Fashion_shop\Views\Items\Index.cshtml"
                                                                                                                        Write(string.Format("{0:N0}", item.Price));

#line default
#line hidden
#nullable disable
                WriteLiteral("vnd</h6>\r\n                        </div>\r\n                    </a>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 49 "D:\ASP-PROJECT\Fashion_shop\Fashion_shop\Fashion_shop\Views\Items\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </div>\r\n    <!-- Hiển thị phân trang -->\r\n    <div type=\"hidden\" style=\"font-family: Arial\">\r\n        ");
#nullable restore
#line 53 "D:\ASP-PROJECT\Fashion_shop\Fashion_shop\Fashion_shop\Views\Items\Index.cshtml"
    Write(Model.PageCount < Model.PageNumber ? 0 : Model.PageNumber);

#line default
#line hidden
#nullable disable
                WriteLiteral("/");
#nullable restore
#line 53 "D:\ASP-PROJECT\Fashion_shop\Fashion_shop\Fashion_shop\Views\Items\Index.cshtml"
                                                                Write(Model.PageCount);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n    <div class=\"pagination\">\r\n");
#nullable restore
#line 56 "D:\ASP-PROJECT\Fashion_shop\Fashion_shop\Fashion_shop\Views\Items\Index.cshtml"
         if (Model.HasPreviousPage)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <a");
                BeginWriteAttribute("href", " href=\"", 2417, "\"", 2462, 1);
#nullable restore
#line 58 "D:\ASP-PROJECT\Fashion_shop\Fashion_shop\Fashion_shop\Views\Items\Index.cshtml"
WriteAttributeValue("", 2424, Url.Action("Index", new { page = 1 }), 2424, 38, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"page-link\">&lt;&lt;</a>\r\n            <a");
                BeginWriteAttribute("href", " href=\"", 2510, "\"", 2574, 1);
#nullable restore
#line 59 "D:\ASP-PROJECT\Fashion_shop\Fashion_shop\Fashion_shop\Views\Items\Index.cshtml"
WriteAttributeValue("", 2517, Url.Action("Index", new { page = Model.PageNumber - 1 }), 2517, 57, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"page-link\">&lt;</a>\r\n");
#nullable restore
#line 60 "D:\ASP-PROJECT\Fashion_shop\Fashion_shop\Fashion_shop\Views\Items\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "D:\ASP-PROJECT\Fashion_shop\Fashion_shop\Fashion_shop\Views\Items\Index.cshtml"
         for (int i = 1; i <= Model.PageCount; i++)
        {
            if (i == Model.PageNumber)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <a");
                BeginWriteAttribute("href", " href=\"", 2752, "\"", 2797, 1);
#nullable restore
#line 65 "D:\ASP-PROJECT\Fashion_shop\Fashion_shop\Fashion_shop\Views\Items\Index.cshtml"
WriteAttributeValue("", 2759, Url.Action("Index", new { page = i }), 2759, 38, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"current-page\">");
#nullable restore
#line 65 "D:\ASP-PROJECT\Fashion_shop\Fashion_shop\Fashion_shop\Views\Items\Index.cshtml"
                                                                                 Write(i);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n");
#nullable restore
#line 66 "D:\ASP-PROJECT\Fashion_shop\Fashion_shop\Fashion_shop\Views\Items\Index.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <a");
                BeginWriteAttribute("href", " href=\"", 2894, "\"", 2939, 1);
#nullable restore
#line 69 "D:\ASP-PROJECT\Fashion_shop\Fashion_shop\Fashion_shop\Views\Items\Index.cshtml"
WriteAttributeValue("", 2901, Url.Action("Index", new { page = i }), 2901, 38, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"page-link\">");
#nullable restore
#line 69 "D:\ASP-PROJECT\Fashion_shop\Fashion_shop\Fashion_shop\Views\Items\Index.cshtml"
                                                                              Write(i);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n");
#nullable restore
#line 70 "D:\ASP-PROJECT\Fashion_shop\Fashion_shop\Fashion_shop\Views\Items\Index.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "D:\ASP-PROJECT\Fashion_shop\Fashion_shop\Fashion_shop\Views\Items\Index.cshtml"
         if (Model.HasNextPage)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <a");
                BeginWriteAttribute("href", " href=\"", 3051, "\"", 3115, 1);
#nullable restore
#line 74 "D:\ASP-PROJECT\Fashion_shop\Fashion_shop\Fashion_shop\Views\Items\Index.cshtml"
WriteAttributeValue("", 3058, Url.Action("Index", new { page = Model.PageNumber + 1 }), 3058, 57, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"page-link\">&gt;</a>\r\n            <a");
                BeginWriteAttribute("href", " href=\"", 3159, "\"", 3218, 1);
#nullable restore
#line 75 "D:\ASP-PROJECT\Fashion_shop\Fashion_shop\Fashion_shop\Views\Items\Index.cshtml"
WriteAttributeValue("", 3166, Url.Action("Index", new { page = Model.PageCount }), 3166, 52, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"page-link\">&gt;&gt;</a>\r\n");
#nullable restore
#line 76 "D:\ASP-PROJECT\Fashion_shop\Fashion_shop\Fashion_shop\Views\Items\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"    </div>
    <div style=""height: 30px""></div>
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
            WriteLiteral("\r\n</html>\r\n");
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "D:\ASP-PROJECT\Fashion_shop\Fashion_shop\Fashion_shop\Views\Items\Index.cshtml"
            
    public string FormatPrice(decimal price)
    {
        return string.Format("{0:#,##0}", price);
    }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<Fashion_shop.Models.Item>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
