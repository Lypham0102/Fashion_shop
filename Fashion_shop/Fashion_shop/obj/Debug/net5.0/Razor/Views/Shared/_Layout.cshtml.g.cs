#pragma checksum "/Users/phamcongly/Documents/GitHub/Fashion_shop/Fashion_shop/Fashion_shop/Views/Shared/_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f28b4e5a864b1380f5b8a373990aedf9b9f20ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f28b4e5a864b1380f5b8a373990aedf9b9f20ff", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d5e5ff572e834d76182c276324ef5f44f60458f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-right: 20px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("modal-content modal-body border-0 p-0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/phamcongly/Documents/GitHub/Fashion_shop/Fashion_shop/Fashion_shop/Views/Shared/_Layout.cshtml"
  
    var userName = Context.Request.Cookies["UserName"];

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\n<html lang=\"en\">\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f28b4e5a864b1380f5b8a373990aedf9b9f20ff5488", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <link rel=""apple-touch-icon"" href=""assets/img/apple-icon.png"">
    <link rel=""shortcut icon"" type=""image/x-icon"" href=""assets/img/TL-Shop.ico"">
    <link rel=""stylesheet"" href=""assets/css/bootstrap.min.css"">
    <link rel=""stylesheet"" href=""assets/css/templatemo.css"">
    <link rel=""stylesheet"" href=""assets/css/custom.css"">
");
                WriteLiteral(@"    <!-- Load fonts style after rendering the layout styles -->
    <link rel=""stylesheet"" href=""https://fonts.googleapis.com/css2?family=Roboto:wght@100;200;300;400;500;700;900&display=swap"">
    <link rel=""stylesheet"" href=""assets/css/fontawesome.min.css"">
");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f28b4e5a864b1380f5b8a373990aedf9b9f20ff7196", async() => {
                WriteLiteral(@"
    <!-- Start Top Nav -->
    <nav class=""navbar navbar-expand-lg bg-dark navbar-light d-none d-lg-block"" id=""templatemo_nav_top"">
        <div class=""container text-light"">
            <div class=""w-100 d-flex justify-content-between"">
                <div>
                    <i class=""fa fa-envelope mx-2""></i>
                    <a class=""navbar-sm-brand text-light text-decoration-none"" href=""abc@gmail.com"">info@tlshop.com</a>
                    <i class=""fa fa-phone mx-2""></i>
                    <a class=""navbar-sm-brand text-light text-decoration-none"" href=""tel:010-020-0340"">010-020-0340</a>
                </div>
                <div>
                    <a class=""text-light"" href=""https://fb.com/templatemo"" target=""_blank"" rel=""sponsored""><i class=""fab fa-facebook-f fa-sm fa-fw me-2""></i></a>
                    <a class=""text-light"" href=""https://www.instagram.com/"" target=""_blank""><i class=""fab fa-instagram fa-sm fa-fw me-2""></i></a>
                    <a class=""text-light"" href=""https://twitt");
                WriteLiteral(@"er.com/"" target=""_blank""><i class=""fab fa-twitter fa-sm fa-fw me-2""></i></a>
                    <a class=""text-light"" href=""https://www.linkedin.com/"" target=""_blank""><i class=""fab fa-linkedin fa-sm fa-fw""></i></a>
                </div>
            </div>
        </div>
    </nav>
    <!-- Close Top Nav -->
    <!-- Header -->
    <nav class=""navbar navbar-expand-lg navbar-light shadow"">
        <div class=""container d-flex justify-content-between align-items-center"">
            <a class=""navbar-brand logo h1 align-self-center""");
                BeginWriteAttribute("href", " href=\"", 2428, "\"", 2463, 1);
#nullable restore
#line 43 "/Users/phamcongly/Documents/GitHub/Fashion_shop/Fashion_shop/Fashion_shop/Views/Shared/_Layout.cshtml"
WriteAttributeValue("", 2435, Url.Action("Index", "Home"), 2435, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" style=""display: flex; align-items: center; white-space: nowrap;"">
                TL Shop
            </a>
            <button class=""navbar-toggler border-0"" type=""button"" data-bs-toggle=""collapse"" data-bs-target=""#templatemo_main_nav"" aria-controls=""navbarSupportedContent"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                <span class=""navbar-toggler-icon""></span>
            </button>

            <div class=""align-self-center collapse navbar-collapse flex-fill  d-lg-flex justify-content-lg-between"" id=""templatemo_main_nav"">
                <div class=""flex-fill"">
                    <ul class=""nav navbar-nav d-flex justify-content-between mx-lg-auto"">
                        <li class=""nav-item"">
                            <a class=""nav-link""");
                BeginWriteAttribute("href", " href=\"", 3241, "\"", 3276, 1);
#nullable restore
#line 54 "/Users/phamcongly/Documents/GitHub/Fashion_shop/Fashion_shop/Fashion_shop/Views/Shared/_Layout.cshtml"
WriteAttributeValue("", 3248, Url.Action("Index", "Home"), 3248, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Home</a>\n                        </li>\n                        <li class=\"nav-item\">\n                            <a class=\"nav-link\"");
                BeginWriteAttribute("href", " href=\"", 3410, "\"", 3445, 1);
#nullable restore
#line 57 "/Users/phamcongly/Documents/GitHub/Fashion_shop/Fashion_shop/Fashion_shop/Views/Shared/_Layout.cshtml"
WriteAttributeValue("", 3417, Url.Action("Index","Items"), 3417, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Store</a>\n                        </li>\n                        <li class=\"nav-item\">\n                            <a class=\"nav-link\"");
                BeginWriteAttribute("href", " href=\"", 3580, "\"", 3616, 1);
#nullable restore
#line 60 "/Users/phamcongly/Documents/GitHub/Fashion_shop/Fashion_shop/Fashion_shop/Views/Shared/_Layout.cshtml"
WriteAttributeValue("", 3587, Url.Action("Contact","Home"), 3587, 29, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Contact</a>\n                        </li>\n                        <li class=\"nav-item\">\n                        </li>\n                    </ul>\n                </div>\n");
#nullable restore
#line 66 "/Users/phamcongly/Documents/GitHub/Fashion_shop/Fashion_shop/Fashion_shop/Views/Shared/_Layout.cshtml"
                 if (string.IsNullOrEmpty(userName))
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <a class=\"nav-icon position-relative text-decoration-none\"");
                BeginWriteAttribute("href", " href=\"", 3934, "\"", 3970, 1);
#nullable restore
#line 68 "/Users/phamcongly/Documents/GitHub/Fashion_shop/Fashion_shop/Fashion_shop/Views/Shared/_Layout.cshtml"
WriteAttributeValue("", 3941, Url.Action("Login", "Users"), 3941, 29, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" style=""margin-right: 20px;"">
                        <i class=""fa fa-fw fa-user text-dark mr-3""></i>
                        <span class=""position-absolute top-0 left-100 translate-middle badge rounded-pill bg-light text-dark"" style=""margin-right: 20px;""></span>
                    </a>
");
#nullable restore
#line 72 "/Users/phamcongly/Documents/GitHub/Fashion_shop/Fashion_shop/Fashion_shop/Views/Shared/_Layout.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    <div class=""dropdown"">
                        <a class=""nav-link dropdown-toggle text-dark"" href=""#"" role=""button"" id=""userDropdown"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                            Hello, ");
#nullable restore
#line 77 "/Users/phamcongly/Documents/GitHub/Fashion_shop/Fashion_shop/Fashion_shop/Views/Shared/_Layout.cshtml"
                              Write(userName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        </a>\n                        <div class=\"dropdown-menu\" aria-labelledby=\"userDropdown\">\n                            <a class=\"dropdown-item\"");
                BeginWriteAttribute("href", " href=\"", 4747, "\"", 4789, 1);
#nullable restore
#line 80 "/Users/phamcongly/Documents/GitHub/Fashion_shop/Fashion_shop/Fashion_shop/Views/Shared/_Layout.cshtml"
WriteAttributeValue("", 4754, Url.Action("DetailsUser", "Users"), 4754, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Xem thông tin</a>\n                            <a class=\"dropdown-item\"");
                BeginWriteAttribute("href", " href=\"", 4861, "\"", 4899, 1);
#nullable restore
#line 81 "/Users/phamcongly/Documents/GitHub/Fashion_shop/Fashion_shop/Fashion_shop/Views/Shared/_Layout.cshtml"
WriteAttributeValue("", 4868, Url.Action("History", "Bills"), 4868, 31, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Lịch sử đơn hàng</a>\n                            <a class=\"dropdown-item\"");
                BeginWriteAttribute("href", " href=\"", 4974, "\"", 5011, 1);
#nullable restore
#line 82 "/Users/phamcongly/Documents/GitHub/Fashion_shop/Fashion_shop/Fashion_shop/Views/Shared/_Layout.cshtml"
WriteAttributeValue("", 4981, Url.Action("Logout", "Users"), 4981, 30, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Đăng xuất</a>\n                        </div>\n                    </div>\n");
#nullable restore
#line 85 "/Users/phamcongly/Documents/GitHub/Fashion_shop/Fashion_shop/Fashion_shop/Views/Shared/_Layout.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            <div class=""navbar align-self-center d-flex"" style=""margin-right: 20px;"">
                <div class=""d-lg-none flex-sm-fill mt-3 mb-4 col-7 col-sm-auto pr-3"">
                    <div class=""input-group"">
                        <input type=""text"" class=""form-control"" id=""inputMobileSearch"" placeholder=""Search ..."">
                        <div class=""input-group-text"">
                            <i class=""fa fa-fw fa-search""></i>
                        </div>
                    </div>
                </div>
                <a class=""nav-icon position-relative text-decoration-none""");
                BeginWriteAttribute("href", " href=\"", 5707, "\"", 5741, 1);
#nullable restore
#line 95 "/Users/phamcongly/Documents/GitHub/Fashion_shop/Fashion_shop/Fashion_shop/Views/Shared/_Layout.cshtml"
WriteAttributeValue("", 5714, Url.Action("Cart","Bills"), 5714, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" style=""margin-right: 20px;"">
                    <i class=""fa fa-fw fa-cart-arrow-down text-dark mr-1""></i>
                    <span class=""position-absolute top-0 left-100 translate-middle badge rounded-pill bg-light text-dark""></span>
                </a>
                <!-- Thêm form để tìm kiếm -->
                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f28b4e5a864b1380f5b8a373990aedf9b9f20ff17055", async() => {
                    WriteLiteral(@"
                    <!-- Thay method=""get"" thành method=""post"" -->
                    <div class=""input-group"">
                        <input type=""text"" class=""form-control"" id=""inputMobileSearch"" name=""keyword"" placeholder=""Search ..."">
                        <div class=""input-group-text"" onclick=""performSearch()"">
                            <i class=""fa fa-fw fa-search""></i>
                        </div>
                    </div>
                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 100 "/Users/phamcongly/Documents/GitHub/Fashion_shop/Fashion_shop/Fashion_shop/Views/Shared/_Layout.cshtml"
AddHtmlAttributeValue("", 6093, Url.Action("Search", "Home"), 6093, 29, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
            </div>
            </div>
        </div>
    </nav>
    <!-- Modal -->
    <div class=""modal fade bg-white"" id=""templatemo_search"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog modal-lg"" role=""document"">
            <div class=""w-100 pt-1 mb-5 text-right"">
                <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
            </div>
            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f28b4e5a864b1380f5b8a373990aedf9b9f20ff20111", async() => {
                    WriteLiteral(@"
                <div class=""input-group mb-2"">
                    <input type=""text"" class=""form-control"" id=""inputModalSearch"" name=""q"" placeholder=""Search ..."">
                    <button type=""submit"" class=""input-group-text bg-success text-light"">
                        <i class=""fa fa-fw fa-search text-white""></i>
                    </button>
                </div>
            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n        </div>\n    </div>\n    <div class=\"container\">\n        <main role=\"main\" class=\"pb-3\">\n            ");
#nullable restore
#line 131 "/Users/phamcongly/Documents/GitHub/Fashion_shop/Fashion_shop/Fashion_shop/Views/Shared/_Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
        </main>
    </div>
    <!-- Start Footer -->
    <footer class=""bg-dark"" id=""tempaltemo_footer"">
        <div class=""container"">
            <div class=""row"">

                <div class=""col-md-4 pt-5"">
                    <h2 class=""h2 text-success border-bottom pb-3 border-light logo"">TL Shop</h2>
                    <ul class=""list-unstyled text-light footer-link-list"">
                        <li>
                            <i class=""fas fa-map-marker-alt fa-fw""></i>
                            123 Consectetur at ligula 10660
                        </li>
                        <li>
                            <i class=""fa fa-phone fa-fw""></i>
                            <a class=""text-decoration-none"" href=""tel:010-020-0340"">010-020-0340</a>
                        </li>
                        <li>
                            <i class=""fa fa-envelope fa-fw""></i>
                            <a class=""text-decoration-none"" href=""mailto:info@company.com"">info@company.com</a>
                   ");
                WriteLiteral(@"     </li>
                    </ul>
                </div>

                <div class=""col-md-4 pt-5"">
                    <h2 class=""h2 text-light border-bottom pb-3 border-light"">Products</h2>
                    <ul class=""list-unstyled text-light footer-link-list"">
                        <li><a class=""text-decoration-none"" href=""#"">Luxury</a></li>
                        <li><a class=""text-decoration-none"" href=""#"">Sport Wear</a></li>
                        <li><a class=""text-decoration-none"" href=""#"">Men's Shoes</a></li>
                        <li><a class=""text-decoration-none"" href=""#"">Women's Shoes</a></li>
                        <li><a class=""text-decoration-none"" href=""#"">Popular Dress</a></li>
                        <li><a class=""text-decoration-none"" href=""#"">Gym Accessories</a></li>
                        <li><a class=""text-decoration-none"" href=""#"">Sport Shoes</a></li>
                    </ul>
                </div>
                <div class=""col-md-4 pt-5"">
                    <h2 cla");
                WriteLiteral(@"ss=""h2 text-light border-bottom pb-3 border-light"">Further Info</h2>
                    <ul class=""list-unstyled text-light footer-link-list"">
                        <li><a class=""text-decoration-none"" href=""#"">Home</a></li>
                        <li><a class=""text-decoration-none"" href=""#"">About Us</a></li>
                        <li><a class=""text-decoration-none"" href=""#"">Shop Locations</a></li>
                        <li><a class=""text-decoration-none"" href=""#"">FAQs</a></li>
                        <li><a class=""text-decoration-none"" href=""#"">Contact</a></li>
                    </ul>
                </div>

            </div>

            <div class=""row text-light mb-4"">
                <div class=""col-12 mb-3"">
                    <div class=""w-100 my-3 border-top border-light""></div>
                </div>
                <div class=""col-auto me-auto"">
                    <ul class=""list-inline text-left footer-icons"">
                        <li class=""list-inline-item border border-light round");
                WriteLiteral(@"ed-circle text-center"">
                            <a class=""text-light text-decoration-none"" target=""_blank"" href=""http://facebook.com/""><i class=""fab fa-facebook-f fa-lg fa-fw""></i></a>
                        </li>
                        <li class=""list-inline-item border border-light rounded-circle text-center"">
                            <a class=""text-light text-decoration-none"" target=""_blank"" href=""https://www.instagram.com/""><i class=""fab fa-instagram fa-lg fa-fw""></i></a>
                        </li>
                        <li class=""list-inline-item border border-light rounded-circle text-center"">
                            <a class=""text-light text-decoration-none"" target=""_blank"" href=""https://twitter.com/""><i class=""fab fa-twitter fa-lg fa-fw""></i></a>
                        </li>
                        <li class=""list-inline-item border border-light rounded-circle text-center"">
                            <a class=""text-light text-decoration-none"" target=""_blank"" href=""https://www.linke");
                WriteLiteral(@"din.com/""><i class=""fab fa-linkedin fa-lg fa-fw""></i></a>
                        </li>
                    </ul>
                </div>
            </div>
        </div>

        <div class=""w-100 bg-black py-3"">
            <div class=""container"">
                <div class=""row pt-2"">
                    <div class=""col-12"">
                        <p class=""text-left text-light"">
                            Copyright &copy; 2023 TL Team
                        </p>
                    </div>
                </div>
            </div>
        </div>
    </footer>
    <!-- End Footer -->
    <!-- Start Script -->
    <script src=""assets/js/jquery-1.11.0.min.js""></script>
    <script src=""assets/js/jquery-migrate-1.2.1.min.js""></script>
    <script src=""assets/js/bootstrap.bundle.min.js""></script>
    <script src=""assets/js/templatemo.js""></script>
    <script src=""assets/js/custom.js""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js""></script>
    <script s");
                WriteLiteral("rc=\"https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js\"></script>\n\n    <!-- End Script -->\n    <!-- Thêm đoạn mã JavaScript để gửi yêu cầu tìm kiếm -->\n    <!-- Thêm đoạn mã JavaScript để gửi yêu cầu tìm kiếm -->\n");
                WriteLiteral(@"    <script>function performSearch() {
            var keyword = document.getElementByName(""keyword"").value;
            // Sử dụng AJAX để gửi yêu cầu tìm kiếm tới action ""Search"" trong controller ""HomeController""
            $.ajax({
                url: ""/Home/Search"", // Đường dẫn tới action ""Search""
                type: ""post"", // Thay đổi method thành POST
                data: { keyword: keyword }, // Gửi dữ liệu từ khóa tìm kiếm lên server
                success: function (result) {
                    // Khi nhận được kết quả từ server, chuyển hướng tới action ""SearchResult"" để hiển thị danh sách sản phẩm tìm kiếm
                    window.location.href = ""/Home/Search?keyword="" + keyword;
                },
                error: function (error) {
                    console.log(""Error: "" + error);
                }
            });
        }</script>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
