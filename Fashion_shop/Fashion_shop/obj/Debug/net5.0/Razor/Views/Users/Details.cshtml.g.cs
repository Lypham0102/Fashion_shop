#pragma checksum "D:\ASP-PROJECT\Fashion_shop\Fashion_shop\Fashion_shop\Views\Users\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3dee1a261f9e260817a67f64a0f4ee4efa25851b"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3dee1a261f9e260817a67f64a0f4ee4efa25851b", @"/Views/Users/Details.cshtml")]
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
<<<<<<< HEAD
    <h1 class=""text-center mt-5 mb-4""></h1>
=======
    <h1 class=""text-center mt-5 mb-4"">Thông tin khách hàng</h1>
>>>>>>> dbb4c30fb50935a87c8da367ff7b0a7bdbd83656
    <div class=""row"">
        <div class=""col-md-8 offset-md-2"">
            <div class=""card shadow"">
                <div class=""card-body"">
<<<<<<< HEAD
                    <h4 class=""card-title"">Chi  </h4>
                    <hr />
=======
                    <h4 class=""card-title"" style="" text-align: center;"">Chi tiết thông tin </h4>
                    <hr /> 
>>>>>>> dbb4c30fb50935a87c8da367ff7b0a7bdbd83656
                    <dl class=""row"">
                        <dt class=""col-sm-3"">
                            Name:
                        </dt>
                        <dd class=""col-sm-9"">
                            ");
#nullable restore
#line 30 "D:\ASP-PROJECT\Fashion_shop\Fashion_shop\Fashion_shop\Views\Users\Details.cshtml"
                       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-3\">\r\n                            Address:\r\n                        </dt>\r\n                        <dd class=\"col-sm-9\">\r\n                            ");
#nullable restore
#line 36 "D:\ASP-PROJECT\Fashion_shop\Fashion_shop\Fashion_shop\Views\Users\Details.cshtml"
                       Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-3\">\r\n                            NumberPhone:\r\n                        </dt>\r\n                        <dd class=\"col-sm-9\">\r\n                            ");
#nullable restore
#line 42 "D:\ASP-PROJECT\Fashion_shop\Fashion_shop\Fashion_shop\Views\Users\Details.cshtml"
                       Write(Html.DisplayFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-3\">\r\n                            Date:\r\n                        </dt>\r\n                        <dd class=\"col-sm-9\">\r\n                            ");
#nullable restore
#line 48 "D:\ASP-PROJECT\Fashion_shop\Fashion_shop\Fashion_shop\Views\Users\Details.cshtml"
                       Write(Html.DisplayFor(model => model.Date_of_birth));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-3\">\r\n                            Email:\r\n                        </dt>\r\n                        <dd class=\"col-sm-9\">\r\n                            ");
#nullable restore
#line 54 "D:\ASP-PROJECT\Fashion_shop\Fashion_shop\Fashion_shop\Views\Users\Details.cshtml"
                       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-3\">\r\n                            Bank:\r\n                        </dt>\r\n                        <dd class=\"col-sm-9\">\r\n                            ");
#nullable restore
#line 60 "D:\ASP-PROJECT\Fashion_shop\Fashion_shop\Fashion_shop\Views\Users\Details.cshtml"
                       Write(Html.DisplayFor(model => model.Bank));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-3\">\r\n                            NumberCard:\r\n                        </dt>\r\n                        <dd class=\"col-sm-9\">\r\n                            ");
#nullable restore
#line 66 "D:\ASP-PROJECT\Fashion_shop\Fashion_shop\Fashion_shop\Views\Users\Details.cshtml"
                       Write(Html.DisplayFor(model => model.CardNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-3\">\r\n                            Gender:\r\n                        </dt>\r\n                        <dd class=\"col-sm-9\">\r\n                            ");
#nullable restore
#line 72 "D:\ASP-PROJECT\Fashion_shop\Fashion_shop\Fashion_shop\Views\Users\Details.cshtml"
                       Write(Html.DisplayFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-3\">\r\n                            UserName:\r\n                        </dt>\r\n                        <dd class=\"col-sm-9\">\r\n                            ");
#nullable restore
#line 78 "D:\ASP-PROJECT\Fashion_shop\Fashion_shop\Fashion_shop\Views\Users\Details.cshtml"
                       Write(Html.DisplayFor(model => model.Username));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-3\">\r\n                            Passwork:\r\n                        </dt>\r\n                        <dd class=\"col-sm-9\">\r\n                            ");
#nullable restore
#line 84 "D:\ASP-PROJECT\Fashion_shop\Fashion_shop\Fashion_shop\Views\Users\Details.cshtml"
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
