#pragma checksum "/Users/phamcongly/Documents/GitHub/Fashion_shop/Fashion_shop/Fashion_shop/Views/Items/DetailsAd.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a6f0fa7abba33b9ddac39d26119da0f09d79522"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Items_DetailsAd), @"mvc.1.0.view", @"/Views/Items/DetailsAd.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a6f0fa7abba33b9ddac39d26119da0f09d79522", @"/Views/Items/DetailsAd.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d5e5ff572e834d76182c276324ef5f44f60458f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Items_DetailsAd : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Fashion_shop.Models.Item_list>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Product Image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/phamcongly/Documents/GitHub/Fashion_shop/Fashion_shop/Fashion_shop/Views/Items/DetailsAd.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\n<html lang=\"en\">\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a6f0fa7abba33b9ddac39d26119da0f09d795224492", async() => {
                WriteLiteral("\n    <title>TL Store - Contact</title>\n    <meta charset=\"utf-8\">\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a6f0fa7abba33b9ddac39d26119da0f09d795225587", async() => {
                WriteLiteral(@"
    <link rel=""stylesheet"" href=""css/View/Users/Index.css"">
    <div class=""container"">
        <h1 class=""text-center mt-5 mb-4"">Thông tin sản phẩm</h1>
        <div class=""row"">
            <div class=""col-md-8 offset-md-2"">
                <div class=""card shadow"">
                    <div class=""card-body"">
                        <h4 class=""card-title"" style="" text-align: center;"">Chi tiết sản phẩm </h4>
                        <hr />
                        <div class=""row justify-content-center"">
                            <div class=""col-lg-6"">
                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "1a6f0fa7abba33b9ddac39d26119da0f09d795226457", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 924, "~/img_items/", 924, 12, true);
#nullable restore
#line 26 "/Users/phamcongly/Documents/GitHub/Fashion_shop/Fashion_shop/Fashion_shop/Views/Items/DetailsAd.cshtml"
AddHtmlAttributeValue("", 936, Model.item.Image, 936, 17, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                            </div>\n                        </div>\n                        <dl class=\"row\">\n                            <dt class=\"col-sm-4\">\n                                ");
#nullable restore
#line 31 "/Users/phamcongly/Documents/GitHub/Fashion_shop/Fashion_shop/Fashion_shop/Views/Items/DetailsAd.cshtml"
                           Write(Html.DisplayNameFor(model => model.item.Brand));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                            </dt>\n                            <dd class=\"col-sm-8\">\n                                ");
#nullable restore
#line 34 "/Users/phamcongly/Documents/GitHub/Fashion_shop/Fashion_shop/Fashion_shop/Views/Items/DetailsAd.cshtml"
                           Write(Html.DisplayFor(model => model.item.Brand));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                            </dd>\n                            <dt class=\"col-sm-4\">\n                                ");
#nullable restore
#line 37 "/Users/phamcongly/Documents/GitHub/Fashion_shop/Fashion_shop/Fashion_shop/Views/Items/DetailsAd.cshtml"
                           Write(Html.DisplayNameFor(model => model.item.Gender));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                            </dt>\n                            <dd class=\"col-sm-8\">\n                                ");
#nullable restore
#line 40 "/Users/phamcongly/Documents/GitHub/Fashion_shop/Fashion_shop/Fashion_shop/Views/Items/DetailsAd.cshtml"
                           Write(Html.DisplayFor(model => model.item.Gender));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                            </dd>\n                            <dt class=\"col-sm-4\">\n                                ");
#nullable restore
#line 43 "/Users/phamcongly/Documents/GitHub/Fashion_shop/Fashion_shop/Fashion_shop/Views/Items/DetailsAd.cshtml"
                           Write(Html.DisplayNameFor(model => model.item.Count));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                            </dt>\n                            <dd class=\"col-sm-8\">\n                                ");
#nullable restore
#line 46 "/Users/phamcongly/Documents/GitHub/Fashion_shop/Fashion_shop/Fashion_shop/Views/Items/DetailsAd.cshtml"
                           Write(Html.DisplayFor(model => model.item.Count));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                            </dd>\n                            <dt class=\"col-sm-4\">\n                                ");
#nullable restore
#line 49 "/Users/phamcongly/Documents/GitHub/Fashion_shop/Fashion_shop/Fashion_shop/Views/Items/DetailsAd.cshtml"
                           Write(Html.DisplayNameFor(model => model.item.Country));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                            </dt>\n                            <dd class=\"col-sm-8\">\n                                ");
#nullable restore
#line 52 "/Users/phamcongly/Documents/GitHub/Fashion_shop/Fashion_shop/Fashion_shop/Views/Items/DetailsAd.cshtml"
                           Write(Html.DisplayFor(model => model.item.Country));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                            </dd>\n                            <dt class=\"col-sm-4\">\n                                Materials\n                            </dt>\n                            <dd class=\"col-sm-8\">\n                                ");
#nullable restore
#line 58 "/Users/phamcongly/Documents/GitHub/Fashion_shop/Fashion_shop/Fashion_shop/Views/Items/DetailsAd.cshtml"
                           Write(ViewBag.A);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                            </dd>\n                            <dt class=\"col-sm-4\">\n                                User Item\n                            </dt>\n                            <dd class=\"col-sm-8\">\n                                ");
#nullable restore
#line 64 "/Users/phamcongly/Documents/GitHub/Fashion_shop/Fashion_shop/Fashion_shop/Views/Items/DetailsAd.cshtml"
                           Write(ViewBag.B);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                            </dd>\n                            <dt class=\"col-sm-4\">\n                                Product Type\n                            </dt>\n                            <dd class=\"col-sm-8\">\n                                ");
#nullable restore
#line 70 "/Users/phamcongly/Documents/GitHub/Fashion_shop/Fashion_shop/Fashion_shop/Views/Items/DetailsAd.cshtml"
                           Write(ViewBag.C);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                            </dd>
                        </dl>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div style=""height: 50px;""></div>
    <!-- End Footer -->
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Fashion_shop.Models.Item_list> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
