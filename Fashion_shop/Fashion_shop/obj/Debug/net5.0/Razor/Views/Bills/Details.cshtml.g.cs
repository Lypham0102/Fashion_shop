<<<<<<< HEAD
#pragma checksum "D:\ASP-PROJECT\Fashion_shop\Fashion_shop\Fashion_shop\Views\Bills\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac7f1c39ee68a05f3e24fec89c76c960b2c4ff9d"
=======
#pragma checksum "/Users/phamcongly/Documents/GitHub/Fashion_shop/Fashion_shop/Fashion_shop/Views/Bills/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8801c285a8099f5075f7c767c833c920c3970100"
>>>>>>> 2f63c7d88d7d3952c536294f87487cabfa5c8240
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Bills_Details), @"mvc.1.0.view", @"/Views/Bills/Details.cshtml")]
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
<<<<<<< HEAD
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac7f1c39ee68a05f3e24fec89c76c960b2c4ff9d", @"/Views/Bills/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a58fb4587fbf21b5fa75ff6b2433f2010bf1d785", @"/Views/_ViewImports.cshtml")]
=======
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8801c285a8099f5075f7c767c833c920c3970100", @"/Views/Bills/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d5e5ff572e834d76182c276324ef5f44f60458f", @"/Views/_ViewImports.cshtml")]
>>>>>>> 2f63c7d88d7d3952c536294f87487cabfa5c8240
    #nullable restore
    public class Views_Bills_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Fashion_shop.Models.Bill>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/phamcongly/Documents/GitHub/Fashion_shop/Fashion_shop/Fashion_shop/Views/Bills/Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Details</h1>\n\n<div>\n    <h4>Bill</h4>\n    <hr />\n    <dl class=\"row\">\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
<<<<<<< HEAD
#line 15 "D:\ASP-PROJECT\Fashion_shop\Fashion_shop\Fashion_shop\Views\Bills\Details.cshtml"
=======
#line 15 "/Users/phamcongly/Documents/GitHub/Fashion_shop/Fashion_shop/Fashion_shop/Views/Bills/Details.cshtml"
>>>>>>> 2f63c7d88d7d3952c536294f87487cabfa5c8240
       Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
<<<<<<< HEAD
#line 18 "D:\ASP-PROJECT\Fashion_shop\Fashion_shop\Fashion_shop\Views\Bills\Details.cshtml"
=======
#line 18 "/Users/phamcongly/Documents/GitHub/Fashion_shop/Fashion_shop/Fashion_shop/Views/Bills/Details.cshtml"
>>>>>>> 2f63c7d88d7d3952c536294f87487cabfa5c8240
       Write(Html.DisplayFor(model => model.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 21 "/Users/phamcongly/Documents/GitHub/Fashion_shop/Fashion_shop/Fashion_shop/Views/Bills/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Total));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 24 "/Users/phamcongly/Documents/GitHub/Fashion_shop/Fashion_shop/Fashion_shop/Views/Bills/Details.cshtml"
       Write(Html.DisplayFor(model => model.Total));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
<<<<<<< HEAD
#line 27 "D:\ASP-PROJECT\Fashion_shop\Fashion_shop\Fashion_shop\Views\Bills\Details.cshtml"
=======
#line 27 "/Users/phamcongly/Documents/GitHub/Fashion_shop/Fashion_shop/Fashion_shop/Views/Bills/Details.cshtml"
>>>>>>> 2f63c7d88d7d3952c536294f87487cabfa5c8240
       Write(Html.DisplayNameFor(model => model.Voucher_id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
<<<<<<< HEAD
#line 30 "D:\ASP-PROJECT\Fashion_shop\Fashion_shop\Fashion_shop\Views\Bills\Details.cshtml"
=======
#line 30 "/Users/phamcongly/Documents/GitHub/Fashion_shop/Fashion_shop/Fashion_shop/Views/Bills/Details.cshtml"
>>>>>>> 2f63c7d88d7d3952c536294f87487cabfa5c8240
       Write(Html.DisplayFor(model => model.Voucher_id));

#line default
#line hidden
#nullable disable
<<<<<<< HEAD
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac7f1c39ee68a05f3e24fec89c76c960b2c4ff9d6080", async() => {
=======
            WriteLiteral("\n        </dd>\n    </dl>\n</div>\n<div>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8801c285a8099f5075f7c767c833c920c39701006103", async() => {
>>>>>>> 2f63c7d88d7d3952c536294f87487cabfa5c8240
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
<<<<<<< HEAD
#line 35 "D:\ASP-PROJECT\Fashion_shop\Fashion_shop\Fashion_shop\Views\Bills\Details.cshtml"
=======
#line 35 "/Users/phamcongly/Documents/GitHub/Fashion_shop/Fashion_shop/Fashion_shop/Views/Bills/Details.cshtml"
>>>>>>> 2f63c7d88d7d3952c536294f87487cabfa5c8240
                           WriteLiteral(Model.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
<<<<<<< HEAD
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac7f1c39ee68a05f3e24fec89c76c960b2c4ff9d8223", async() => {
=======
            WriteLiteral(" |\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8801c285a8099f5075f7c767c833c920c39701008233", async() => {
>>>>>>> 2f63c7d88d7d3952c536294f87487cabfa5c8240
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Fashion_shop.Models.Bill> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
