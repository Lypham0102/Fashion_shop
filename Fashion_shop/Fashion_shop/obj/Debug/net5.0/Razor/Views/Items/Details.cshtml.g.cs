#pragma checksum "/Users/phamcongly/Documents/GitHub/Fashion_shop/Fashion_shop/Fashion_shop/Views/Items/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b44077f4d000252f627a11e7bce8cb46ff7bfd0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Items_Details), @"mvc.1.0.view", @"/Views/Items/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b44077f4d000252f627a11e7bce8cb46ff7bfd0", @"/Views/Items/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d5e5ff572e834d76182c276324ef5f44f60458f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Items_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Fashion_shop.Models.Item>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("modal-content modal-body border-0 p-0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Product Image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/phamcongly/Documents/GitHub/Fashion_shop/Fashion_shop/Fashion_shop/Views/Items/Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\n<html lang=\"en\">\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b44077f4d000252f627a11e7bce8cb46ff7bfd06189", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <link rel=""apple-touch-icon"" href=""assets/img/apple-icon.png"">
    <link rel=""shortcut icon"" type=""image/x-icon"" href=""assets/img/favicon.ico"">
    <link rel=""stylesheet"" href=""assets/css/bootstrap.min.css"">
    <link rel=""stylesheet"" href=""assets/css/templatemo.css"">
    <link rel=""stylesheet"" href=""assets/css/custom.css"">
    <!-- Load fonts style after rendering the layout styles -->
    <link rel=""stylesheet"" href=""https://fonts.googleapis.com/css2?family=Roboto:wght@100;200;300;400;500;700;900&display=swap"">
    <link rel=""stylesheet"" href=""assets/css/fontawesome.min.css"">
    <!--
    TemplateMo 559 Zay Shop
    https://templatemo.com/tm-559-zay-shop
    -->
    <style>
        body {
            width: 100vw;
            overflow-x: hidden;
        }
        .container {
            width: 100%;
            max-width: 100%;
            padding-left: 0px;
            padding-right: 0px;
            m");
                WriteLiteral(@"argin-left: auto;
            margin-right: auto;
        }

        .navbar-brand {
            font-family: 'Futura', sans-serif;
        }

        .size-option {
            display: inline-block;
            margin-right: 10px;
        }

            .size-option input[type=""radio""] {
                display: none;
            }

            .size-option label {
                display: block;
                width: 80px;
                height: 40px;
                border: 2px solid lightgray;
                border-radius: 5px;
                background-color: white;
                text-align: center;
                line-height: 40px;
                cursor: pointer;
            }

            .size-option input[type=""radio""]:checked + label {
                background-color: gray;
                color: white;
            }

        .navbar-nav .nav-link {
            margin-right: 10px;
            padding: 5px 10px;
            transition: all 0.3s ease;
        }
    ");
                WriteLiteral("        .navbar-nav .nav-link:hover {\n                margin-right: 15px;\n                background-color: #f2f2f2;\n            }\n\n    </style>\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b44077f4d000252f627a11e7bce8cb46ff7bfd09444", async() => {
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
    <!-- Header -->
    <nav class=""navbar navbar-expand-lg navbar-light shadow"">
        <div class=""container d-flex justify-content-between align-items-center"">
            <a class=""navbar-brand logo h1 align-self-center""");
                BeginWriteAttribute("href", " href=\"", 3926, "\"", 3961, 1);
#nullable restore
#line 104 "/Users/phamcongly/Documents/GitHub/Fashion_shop/Fashion_shop/Fashion_shop/Views/Items/Details.cshtml"
WriteAttributeValue("", 3933, Url.Action("Index", "Home"), 3933, 28, false);

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
                BeginWriteAttribute("href", " href=\"", 4739, "\"", 4774, 1);
#nullable restore
#line 115 "/Users/phamcongly/Documents/GitHub/Fashion_shop/Fashion_shop/Fashion_shop/Views/Items/Details.cshtml"
WriteAttributeValue("", 4746, Url.Action("Index", "Home"), 4746, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Home</a>\n                        </li>\n                        <li class=\"nav-item\">\n                            <a class=\"nav-link\"");
                BeginWriteAttribute("href", " href=\"", 4908, "\"", 4943, 1);
#nullable restore
#line 118 "/Users/phamcongly/Documents/GitHub/Fashion_shop/Fashion_shop/Fashion_shop/Views/Items/Details.cshtml"
WriteAttributeValue("", 4915, Url.Action("Index","Items"), 4915, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Store</a>\n                        </li>\n                        <li class=\"nav-item\">\n                            <a class=\"nav-link\"");
                BeginWriteAttribute("href", " href=\"", 5078, "\"", 5114, 1);
#nullable restore
#line 121 "/Users/phamcongly/Documents/GitHub/Fashion_shop/Fashion_shop/Fashion_shop/Views/Items/Details.cshtml"
WriteAttributeValue("", 5085, Url.Action("Contact","Home"), 5085, 29, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">Contact</a>
                        </li>
                    </ul>
                </div>
                <div class=""navbar align-self-center d-flex"">
                    <div class=""d-lg-none flex-sm-fill mt-3 mb-4 col-7 col-sm-auto pr-3"">
                        <div class=""input-group"">
                            <input type=""text"" class=""form-control"" id=""inputMobileSearch"" placeholder=""Search ..."">
                            <div class=""input-group-text"">
                                <i class=""fa fa-fw fa-search""></i>
                            </div>
                        </div>
                    </div>
                    <a class=""nav-icon d-none d-lg-inline"" href=""#"" data-bs-toggle=""modal"" data-bs-target=""#templatemo_search"">
                        <i class=""fa fa-fw fa-search text-dark mr-2""></i>
                    </a>
                    <a class=""nav-icon position-relative text-decoration-none"" href=""#"">
                        <i class=""fa fa-fw fa-cart-arrow-down text-dark mr-1"">");
                WriteLiteral(@"</i>
                        <span class=""position-absolute top-0 left-100 translate-middle badge rounded-pill bg-light text-dark"">7</span>
                    </a>
                    <a class=""nav-icon position-relative text-decoration-none"" href=""#"">
                        <i class=""fa fa-fw fa-user text-dark mr-3""></i>
                        <span class=""position-absolute top-0 left-100 translate-middle badge rounded-pill bg-light text-dark"">+99</span>
                    </a>
                </div>
            </div>
        </div>
    </nav>
    <!-- Close Header -->
    <!-- Modal -->
    <div class=""modal fade bg-white"" id=""templatemo_search"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog modal-lg"" role=""document"">
            <div class=""w-100 pt-1 mb-5 text-right"">
                <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
            </div>
            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b44077f4d000252f627a11e7bce8cb46ff7bfd016183", async() => {
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
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n        </div>\n    </div>\n");
                WriteLiteral(@"    <div class=""container"">
        <nav class=""navbar navbar-expand-lg navbar-light bg-light justify-content-center"">
            <div class=""collapse navbar-collapse"" id=""navbarNav"">
                <ul class=""navbar-nav mx-auto"">
                    <li class=""nav-item"">
                        <a class=""nav-link font-weight-bold text-dark"" href=""https://somehow.vn/collections/ao-men"">Áo</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link font-weight-bold text-dark"" href=""https://somehow.vn/collections/quan-men"">Quần</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link font-weight-bold text-dark"" href=""https://somehow.vn/collections/set-quan-ao"">Set Quần Áo</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link font-weight-bold text-dark"" href=""https://somehow.vn/collections/giay-dep"">Giày - Dép</a>
                    </li>");
                WriteLiteral(@"
                    <li class=""nav-item"">
                        <a class=""nav-link font-weight-bold text-dark"" href=""https://somehow.vn/collections/phu-kien-men"">Phụ Kiện</a>
                    </li>
                </ul>
            </div>
        </nav>
    </div>
    <div style=""height: 50px;""></div>
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-6"">
                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7b44077f4d000252f627a11e7bce8cb46ff7bfd019828", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 9104, "~/img_items/", 9104, 12, true);
#nullable restore
#line 194 "/Users/phamcongly/Documents/GitHub/Fashion_shop/Fashion_shop/Fashion_shop/Views/Items/Details.cshtml"
AddHtmlAttributeValue("", 9116, Html.DisplayFor(model => model.Image), 9116, 38, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n            </div>\n            <div class=\"col-lg-6\">\n                <div>\n                    <h4 style=\"color: #757575;\">");
#nullable restore
#line 198 "/Users/phamcongly/Documents/GitHub/Fashion_shop/Fashion_shop/Fashion_shop/Views/Items/Details.cshtml"
                                           Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\n                    <h5 style=\"color: #757575;\">");
#nullable restore
#line 199 "/Users/phamcongly/Documents/GitHub/Fashion_shop/Fashion_shop/Fashion_shop/Views/Items/Details.cshtml"
                                           Write(Html.DisplayFor(model => model.id));

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\n                    <h5 style=\"font-weight: bold;\">");
#nullable restore
#line 200 "/Users/phamcongly/Documents/GitHub/Fashion_shop/Fashion_shop/Fashion_shop/Views/Items/Details.cshtml"
                                              Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
#nullable disable
                WriteLiteral("0.000 đ</h5>\n                    <hr />\n                    <h4>Thông tin sản phẩm</h4>\n                    <dl class=\"row\">\n                        <dt class=\"col-sm-4\">\n                            ");
#nullable restore
#line 205 "/Users/phamcongly/Documents/GitHub/Fashion_shop/Fashion_shop/Fashion_shop/Views/Items/Details.cshtml"
                       Write(Html.DisplayNameFor(model => model.Brand));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        </dt>\n                        <dd class=\"col-sm-8\">\n                            ");
#nullable restore
#line 208 "/Users/phamcongly/Documents/GitHub/Fashion_shop/Fashion_shop/Fashion_shop/Views/Items/Details.cshtml"
                       Write(Html.DisplayFor(model => model.Brand));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        </dd>\n                        <dt class=\"col-sm-4\">\n                            ");
#nullable restore
#line 211 "/Users/phamcongly/Documents/GitHub/Fashion_shop/Fashion_shop/Fashion_shop/Views/Items/Details.cshtml"
                       Write(Html.DisplayNameFor(model => model.Color));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        </dt>\n                        <dd class=\"col-sm-8\">\n                            ");
#nullable restore
#line 214 "/Users/phamcongly/Documents/GitHub/Fashion_shop/Fashion_shop/Fashion_shop/Views/Items/Details.cshtml"
                       Write(Html.DisplayFor(model => model.Color));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        </dd>\n                        <dt class=\"col-sm-4\">\n                            ");
#nullable restore
#line 217 "/Users/phamcongly/Documents/GitHub/Fashion_shop/Fashion_shop/Fashion_shop/Views/Items/Details.cshtml"
                       Write(Html.DisplayNameFor(model => model.Gender));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        </dt>\n                        <dd class=\"col-sm-8\">\n                            ");
#nullable restore
#line 220 "/Users/phamcongly/Documents/GitHub/Fashion_shop/Fashion_shop/Fashion_shop/Views/Items/Details.cshtml"
                       Write(Html.DisplayFor(model => model.Gender));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        </dd>\n                        <dt class=\"col-sm-4\">\n                            ");
#nullable restore
#line 223 "/Users/phamcongly/Documents/GitHub/Fashion_shop/Fashion_shop/Fashion_shop/Views/Items/Details.cshtml"
                       Write(Html.DisplayNameFor(model => model.Count));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        </dt>\n                        <dd class=\"col-sm-8\">\n                            ");
#nullable restore
#line 226 "/Users/phamcongly/Documents/GitHub/Fashion_shop/Fashion_shop/Fashion_shop/Views/Items/Details.cshtml"
                       Write(Html.DisplayFor(model => model.Count));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        </dd>\n                        <dt class=\"col-sm-4\">\n                            ");
#nullable restore
#line 229 "/Users/phamcongly/Documents/GitHub/Fashion_shop/Fashion_shop/Fashion_shop/Views/Items/Details.cshtml"
                       Write(Html.DisplayNameFor(model => model.Country));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        </dt>\n                        <dd class=\"col-sm-8\">\n                            ");
#nullable restore
#line 232 "/Users/phamcongly/Documents/GitHub/Fashion_shop/Fashion_shop/Fashion_shop/Views/Items/Details.cshtml"
                       Write(Html.DisplayFor(model => model.Country));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        </dd>\n                        <dt class=\"col-sm-4\">\n                            Materials\n                        </dt>\n                        <dd class=\"col-sm-8\">\n                            ");
#nullable restore
#line 238 "/Users/phamcongly/Documents/GitHub/Fashion_shop/Fashion_shop/Fashion_shop/Views/Items/Details.cshtml"
                       Write(ViewBag.A);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        </dd>\n                        <dt class=\"col-sm-4\">\n                            User Item\n                        </dt>\n                        <dd class=\"col-sm-8\">\n                            ");
#nullable restore
#line 244 "/Users/phamcongly/Documents/GitHub/Fashion_shop/Fashion_shop/Fashion_shop/Views/Items/Details.cshtml"
                       Write(ViewBag.B);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        </dd>\n                        <dt class=\"col-sm-4\">\n                            Product Type\n                        </dt>\n                        <dd class=\"col-sm-8\">\n                            ");
#nullable restore
#line 250 "/Users/phamcongly/Documents/GitHub/Fashion_shop/Fashion_shop/Fashion_shop/Views/Items/Details.cshtml"
                       Write(ViewBag.C);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        </dd>\n                    </dl>\n                </div>\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b44077f4d000252f627a11e7bce8cb46ff7bfd028290", async() => {
                    WriteLiteral(@"
                    <label for=""size"">Size:</label>
                    <div class=""size-option"">
                        <input type=""radio"" id=""size-s"" name=""size"" value=""S"">
                        <label for=""size-s"">S</label>
                    </div>
                    <div class=""size-option"">
                        <input type=""radio"" id=""size-m"" name=""size"" value=""M"">
                        <label for=""size-m"">M</label>
                    </div>
                    <div class=""size-option"">
                        <input type=""radio"" id=""size-l"" name=""size"" value=""L"">
                        <label for=""size-l"">L</label>
                    </div>
                    <div class=""size-option"">
                        <input type=""radio"" id=""size-xl"" name=""size"" value=""XL"">
                        <label for=""size-xl"">XL</label>
                    </div>
                    <div class=""size-option"">
                        <input type=""radio"" id=""size-xxl"" name=""size"" value=""XXL"">
              ");
                    WriteLiteral(@"          <label for=""size-xxl"">XXL</label>
                    </div>
                    <div class=""size-option"">
                        <input type=""radio"" id=""size-xxxl"" name=""size"" value=""XXXL"">
                        <label for=""size-xxxl"">XXXL</label>
                    </div>
                ");
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
                WriteLiteral("\n            </div>\n        </div>\n    </div>\n    <div>\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b44077f4d000252f627a11e7bce8cb46ff7bfd031074", async() => {
                    WriteLiteral("Back");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    </div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Fashion_shop.Models.Item> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591