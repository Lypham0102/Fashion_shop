#pragma checksum "/Users/phamcongly/Documents/GitHub/Fashion_shop/Fashion_shop/Fashion_shop/Views/Bills/IndexCus.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f79b8f2751395349d31917fb88235b49c9e29a1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Bills_IndexCus), @"mvc.1.0.view", @"/Views/Bills/IndexCus.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f79b8f2751395349d31917fb88235b49c9e29a1", @"/Views/Bills/IndexCus.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d5e5ff572e834d76182c276324ef5f44f60458f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Bills_IndexCus : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Fashion_shop.Models.Bill>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-muted"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/phamcongly/Documents/GitHub/Fashion_shop/Fashion_shop/Fashion_shop/Views/Bills/IndexCus.cshtml"
  
    ViewData["Title"] = "Shopping Cart";
    Layout = "~/Views/Shared/_LayoutLogin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\n<html lang=\"en\">\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f79b8f2751395349d31917fb88235b49c9e29a14373", async() => {
                WriteLiteral("\n    <meta charset=\"utf-8\">\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">\n    <link rel=\"stylesheet\"");
                BeginWriteAttribute("href", " href=\"", 308, "\"", 359, 1);
#nullable restore
#line 11 "/Users/phamcongly/Documents/GitHub/Fashion_shop/Fashion_shop/Fashion_shop/Views/Bills/IndexCus.cshtml"
WriteAttributeValue("", 315, Url.Content("~/css/View/Bill/IndexCus.css"), 315, 44, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n    <link rel=\"stylesheet\" href=\"https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css\">\n    <link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css\">\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f79b8f2751395349d31917fb88235b49c9e29a16111", async() => {
                WriteLiteral(@"
    <!-- Start Top Nav -->
    <nav class=""navbar navbar-expand-lg bg-dark navbar-light d-none d-lg-block"" id=""templatemo_nav_top"">
        <div class=""container text-light"">
            <div class=""w-100 d-flex justify-content-between"">
                <div>
                    <i class=""fa fa-envelope mx-2""></i>
                    <a class=""navbar-sm-brand text-light text-decoration-none"" href=""abc@gmail.com"">info@company.com</a>
                    <i class=""fa fa-phone mx-2""></i>
                    <a class=""navbar-sm-brand text-light text-decoration-none"" href=""tel:010-020-0340"">010-020-0340</a>
                </div>
                <div>
                    <a class=""text-light"" href=""https://fb.com/templatemo"" target=""_blank"" rel=""sponsored""><i class=""fab fa-facebook-f fa-sm fa-fw me-2""></i></a>
                    <a class=""text-light"" href=""https://www.instagram.com/"" target=""_blank""><i class=""fab fa-instagram fa-sm fa-fw me-2""></i></a>
                    <a class=""text-light"" href=""https://twit");
                WriteLiteral(@"ter.com/"" target=""_blank""><i class=""fab fa-twitter fa-sm fa-fw me-2""></i></a>
                    <a class=""text-light"" href=""https://www.linkedin.com/"" target=""_blank""><i class=""fab fa-linkedin fa-sm fa-fw""></i></a>
                </div>
            </div>
        </div>
    </nav>
    <!-- Close Top Nav -->
    <div style=""height: 100px;""></div>
    <div class=""card"">
        <div class=""row"">
            <div class=""col-md-8 cart"">
                <div class=""title"">
                    <div class=""row"">
                        <div class=""col"" style=""text-align: center; margin-top:30px;""><h4><b>Shopping Cart</b></h4></div>
                        <div class=""col align-self-center text-right text-muted"">1 items</div>
                    </div>
                </div>
                <div class=""row border-top border-bottom"">
                    <div class=""row main align-items-center"" style=""margin-left: 10px;"">
                        <div class=""col-2""><img class=""img-fluid"" src=""https://i.imgur.com/1Gra");
                WriteLiteral(@"kTl.jpg""></div>
                        <div class=""col"">
                            <div class=""row text-muted"">Shirt</div>
                            <div class=""row"">Cotton T-shirt</div>
                        </div>
                        <div class=""col"">
                            <a href=""#"" style=""color: black;"">-</a><a href=""#"" class=""border"">1</a><a href=""#"" style=""color: black;"">+</a>
                        </div>
                        <div class=""col"">&euro; 44.00 <span class=""close"">&#10005;</span></div>
                    </div>
                </div>
                <div class=""back-to-shop""><a");
                BeginWriteAttribute("href", " href=\"", 3275, "\"", 3310, 1);
#nullable restore
#line 59 "/Users/phamcongly/Documents/GitHub/Fashion_shop/Fashion_shop/Fashion_shop/Views/Bills/IndexCus.cshtml"
WriteAttributeValue("", 3282, Url.Action("Index","Items"), 3282, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" style=""color: black;"">&leftarrow;</a><span class=""text-muted"">Back to shop</span></div>
            </div>
            <div class=""col-md-4 summary"">
                <div><h5><b>Summary</b></h5></div>
                <hr>
                <div class=""row"">
                    <div class=""col"" style=""padding-left:10px;"">ITEMS 1</div>
                    <div class=""col text-right"">&euro; 132.00</div>
                </div>
                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f79b8f2751395349d31917fb88235b49c9e29a110077", async() => {
                    WriteLiteral("\n                    <p>SHIPPING</p>\n                    <select>");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f79b8f2751395349d31917fb88235b49c9e29a110405", async() => {
                        WriteLiteral("Standard-Delivery- &euro;5.00");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("</select>\n                    <p>GIVE CODE</p>\n                    <input id=\"code\" placeholder=\"Enter your code\">\n                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                <div class=""row"" style=""border-top: 1px solid rgba(0,0,0,.1); padding: 2vh 0;"">
                    <div class=""col"">TOTAL PRICE</div>
                    <div class=""col text-right"">&euro; 137.00</div>
                </div>
                <button class=""btn"">CHECKOUT</button>
            </div>
        </div>
    </div>
    <!-- End Featured Product -->
    <!-- Start Script -->
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js""></script>
    <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.bundle.min.js""></script>
    <!-- End Script -->
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
            WriteLiteral("\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Fashion_shop.Models.Bill>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
