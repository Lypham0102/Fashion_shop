#pragma checksum "D:\ASP-PROJECT\Fashion_shop\Fashion_shop\Fashion_shop\Views\Users\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14bd14761b30b6408dda67a398a8907bc2c38c01"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Details), @"mvc.1.0.view", @"/Views/Users/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14bd14761b30b6408dda67a398a8907bc2c38c01", @"/Views/Users/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a58fb4587fbf21b5fa75ff6b2433f2010bf1d785", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Users_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Fashion_shop.Models.User>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\ASP-PROJECT\Fashion_shop\Fashion_shop\Fashion_shop\Views\Users\Details.cshtml"
  
    ViewData["Title"] = "Thông tin";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<link rel=""stylesheet"" href=""css/View/Users/Index.css"">
<div class=""container"">
    <h1 class=""text-center mt-5 mb-4"">Thông tin khách hàng</h1>
    <div class=""row"">
        <div class=""col-md-8 offset-md-2"">
            <div class=""card shadow"">
                <div class=""card-body"">
                    <h4 class=""card-title"" style="" text-align: center;"">Chi tiết thông tin </h4>
                    <hr /> 
                    <dl class=""row"">
                        <dt class=""col-sm-3"">
                            Name:
                        </dt>
                        <dd class=""col-sm-9"">
                            ");
#nullable restore
#line 21 "D:\ASP-PROJECT\Fashion_shop\Fashion_shop\Fashion_shop\Views\Users\Details.cshtml"
                       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-3\">\r\n                            Address:\r\n                        </dt>\r\n                        <dd class=\"col-sm-9\">\r\n                            ");
#nullable restore
#line 27 "D:\ASP-PROJECT\Fashion_shop\Fashion_shop\Fashion_shop\Views\Users\Details.cshtml"
                       Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-3\">\r\n                            NumberPhone:\r\n                        </dt>\r\n                        <dd class=\"col-sm-9\">\r\n                            ");
#nullable restore
#line 33 "D:\ASP-PROJECT\Fashion_shop\Fashion_shop\Fashion_shop\Views\Users\Details.cshtml"
                       Write(Html.DisplayFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-3\">\r\n                            Date:\r\n                        </dt>\r\n                        <dd class=\"col-sm-9\">\r\n                            ");
#nullable restore
#line 39 "D:\ASP-PROJECT\Fashion_shop\Fashion_shop\Fashion_shop\Views\Users\Details.cshtml"
                       Write(Html.DisplayFor(model => model.Date_of_birth));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-3\">\r\n                            Email:\r\n                        </dt>\r\n                        <dd class=\"col-sm-9\">\r\n                            ");
#nullable restore
#line 45 "D:\ASP-PROJECT\Fashion_shop\Fashion_shop\Fashion_shop\Views\Users\Details.cshtml"
                       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-3\">\r\n                            Bank:\r\n                        </dt>\r\n                        <dd class=\"col-sm-9\">\r\n                            ");
#nullable restore
#line 51 "D:\ASP-PROJECT\Fashion_shop\Fashion_shop\Fashion_shop\Views\Users\Details.cshtml"
                       Write(Html.DisplayFor(model => model.Bank));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-3\">\r\n                            NumberCard:\r\n                        </dt>\r\n                        <dd class=\"col-sm-9\">\r\n                            ");
#nullable restore
#line 57 "D:\ASP-PROJECT\Fashion_shop\Fashion_shop\Fashion_shop\Views\Users\Details.cshtml"
                       Write(Html.DisplayFor(model => model.CardNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-3\">\r\n                            Gender:\r\n                        </dt>\r\n                        <dd class=\"col-sm-9\">\r\n                            ");
#nullable restore
#line 63 "D:\ASP-PROJECT\Fashion_shop\Fashion_shop\Fashion_shop\Views\Users\Details.cshtml"
                       Write(Html.DisplayFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-3\">\r\n                            UserName:\r\n                        </dt>\r\n                        <dd class=\"col-sm-9\">\r\n                            ");
#nullable restore
#line 69 "D:\ASP-PROJECT\Fashion_shop\Fashion_shop\Fashion_shop\Views\Users\Details.cshtml"
                       Write(Html.DisplayFor(model => model.Username));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-3\">\r\n                            Passwork:\r\n                        </dt>\r\n                        <dd class=\"col-sm-9\">\r\n                            ");
#nullable restore
#line 75 "D:\ASP-PROJECT\Fashion_shop\Fashion_shop\Fashion_shop\Views\Users\Details.cshtml"
                       Write(Html.DisplayFor(model => model.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dd>\r\n                    </dl>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<div style=\"height: 50px;\"></div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Fashion_shop.Models.User> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
