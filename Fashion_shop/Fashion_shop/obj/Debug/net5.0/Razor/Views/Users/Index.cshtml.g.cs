<<<<<<< HEAD
#pragma checksum "D:\ASP-PROJECT\Fashion_shop\Fashion_shop\Fashion_shop\Views\Users\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f4c020688e74c2a764c1c62d0579c95145bd2e4"
=======
#pragma checksum "/Users/phamcongly/Documents/GitHub/Fashion_shop/Fashion_shop/Fashion_shop/Views/Users/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "269de88ed1a3d77dfbd81259dbac1a59daeef48d"
>>>>>>> dbb4c30fb50935a87c8da367ff7b0a7bdbd83656
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Index), @"mvc.1.0.view", @"/Views/Users/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f4c020688e74c2a764c1c62d0579c95145bd2e4", @"/Views/Users/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a58fb4587fbf21b5fa75ff6b2433f2010bf1d785", @"/Views/_ViewImports.cshtml")]
=======
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"269de88ed1a3d77dfbd81259dbac1a59daeef48d", @"/Views/Users/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d5e5ff572e834d76182c276324ef5f44f60458f", @"/Views/_ViewImports.cshtml")]
>>>>>>> dbb4c30fb50935a87c8da367ff7b0a7bdbd83656
    #nullable restore
    public class Views_Users_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Fashion_shop.Models.User>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("text-decoration: none; color: white;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "/Users/phamcongly/Documents/GitHub/Fashion_shop/Fashion_shop/Fashion_shop/Views/Users/Index.cshtml"
  
    ViewData["Title"] = "Xin chào";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
<<<<<<< HEAD
            WriteLiteral("<link rel=\"stylesheet\" href=\"css/View/Users/Index.css\">\r\n<h1>Thông tin khách hàng</h1>\r\n\r\n<button class=\"custom-button\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f4c020688e74c2a764c1c62d0579c95145bd2e44211", async() => {
=======
            WriteLiteral("<link rel=\"stylesheet\" href=\"css/View/Users/Index.css\">\n<h1>Thông tin khách hàng</h1>\n\n<button class=\"custom-button\">\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "269de88ed1a3d77dfbd81259dbac1a59daeef48d4213", async() => {
>>>>>>> dbb4c30fb50935a87c8da367ff7b0a7bdbd83656
                WriteLiteral("Thêm khách hàng");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</button>
<div style=""height: 10px;""></div>
<table class=""table"">
    <thead>
        <tr>
            <th> Tên</th>
            <th> Email </th>
            <th> Date </th>
            <th> PhoneNumber </th>
            <th> Address </th>
            <th> Custom </th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
<<<<<<< HEAD
#line 26 "D:\ASP-PROJECT\Fashion_shop\Fashion_shop\Fashion_shop\Views\Users\Index.cshtml"
=======
#line 26 "/Users/phamcongly/Documents/GitHub/Fashion_shop/Fashion_shop/Fashion_shop/Views/Users/Index.cshtml"
>>>>>>> dbb4c30fb50935a87c8da367ff7b0a7bdbd83656
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>\n                    ");
#nullable restore
<<<<<<< HEAD
#line 30 "D:\ASP-PROJECT\Fashion_shop\Fashion_shop\Fashion_shop\Views\Users\Index.cshtml"
=======
#line 30 "/Users/phamcongly/Documents/GitHub/Fashion_shop/Fashion_shop/Fashion_shop/Views/Users/Index.cshtml"
>>>>>>> dbb4c30fb50935a87c8da367ff7b0a7bdbd83656
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
<<<<<<< HEAD
#line 33 "D:\ASP-PROJECT\Fashion_shop\Fashion_shop\Fashion_shop\Views\Users\Index.cshtml"
=======
#line 33 "/Users/phamcongly/Documents/GitHub/Fashion_shop/Fashion_shop/Fashion_shop/Views/Users/Index.cshtml"
>>>>>>> dbb4c30fb50935a87c8da367ff7b0a7bdbd83656
               Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
<<<<<<< HEAD
#line 36 "D:\ASP-PROJECT\Fashion_shop\Fashion_shop\Fashion_shop\Views\Users\Index.cshtml"
=======
#line 36 "/Users/phamcongly/Documents/GitHub/Fashion_shop/Fashion_shop/Fashion_shop/Views/Users/Index.cshtml"
>>>>>>> dbb4c30fb50935a87c8da367ff7b0a7bdbd83656
               Write(Html.DisplayFor(modelItem => item.Date_of_birth));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
<<<<<<< HEAD
#line 39 "D:\ASP-PROJECT\Fashion_shop\Fashion_shop\Fashion_shop\Views\Users\Index.cshtml"
=======
#line 39 "/Users/phamcongly/Documents/GitHub/Fashion_shop/Fashion_shop/Fashion_shop/Views/Users/Index.cshtml"
>>>>>>> dbb4c30fb50935a87c8da367ff7b0a7bdbd83656
               Write(Html.DisplayFor(modelItem => item.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
<<<<<<< HEAD
#line 42 "D:\ASP-PROJECT\Fashion_shop\Fashion_shop\Fashion_shop\Views\Users\Index.cshtml"
=======
#line 42 "/Users/phamcongly/Documents/GitHub/Fashion_shop/Fashion_shop/Fashion_shop/Views/Users/Index.cshtml"
>>>>>>> dbb4c30fb50935a87c8da367ff7b0a7bdbd83656
               Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
#nullable disable
<<<<<<< HEAD
            WriteLiteral("\r\n                </td>\r\n                <td style=\"width:160px\">\r\n                    <button class=\"highlight\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1412, "\"", 1478, 3);
            WriteAttributeValue("", 1422, "location.href=\'", 1422, 15, true);
#nullable restore
#line 45 "D:\ASP-PROJECT\Fashion_shop\Fashion_shop\Fashion_shop\Views\Users\Index.cshtml"
WriteAttributeValue("", 1437, Url.Action("Edit", new { id= item.id }), 1437, 40, false);
=======
            WriteLiteral("\n                </td>\n                <td style=\"width:160px\">\n                    <button class=\"highlight\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1368, "\"", 1434, 3);
            WriteAttributeValue("", 1378, "location.href=\'", 1378, 15, true);
#nullable restore
#line 45 "/Users/phamcongly/Documents/GitHub/Fashion_shop/Fashion_shop/Fashion_shop/Views/Users/Index.cshtml"
WriteAttributeValue("", 1393, Url.Action("Edit", new { id= item.id }), 1393, 40, false);
>>>>>>> dbb4c30fb50935a87c8da367ff7b0a7bdbd83656

#line default
#line hidden
#nullable disable
<<<<<<< HEAD
            WriteAttributeValue("", 1477, "\'", 1477, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Edit</button>\r\n                    <button class=\"highlight\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1540, "\"", 1610, 3);
            WriteAttributeValue("", 1550, "location.href=\'", 1550, 15, true);
#nullable restore
#line 46 "D:\ASP-PROJECT\Fashion_shop\Fashion_shop\Fashion_shop\Views\Users\Index.cshtml"
WriteAttributeValue("", 1565, Url.Action("Details", new { id = item.id }), 1565, 44, false);
=======
            WriteAttributeValue("", 1433, "\'", 1433, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Edit</button>\n                    <button class=\"highlight\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1495, "\"", 1565, 3);
            WriteAttributeValue("", 1505, "location.href=\'", 1505, 15, true);
#nullable restore
#line 46 "/Users/phamcongly/Documents/GitHub/Fashion_shop/Fashion_shop/Fashion_shop/Views/Users/Index.cshtml"
WriteAttributeValue("", 1520, Url.Action("Details", new { id = item.id }), 1520, 44, false);
>>>>>>> dbb4c30fb50935a87c8da367ff7b0a7bdbd83656

#line default
#line hidden
#nullable disable
<<<<<<< HEAD
            WriteAttributeValue("", 1609, "\'", 1609, 1, true);
=======
            WriteAttributeValue("", 1564, "\'", 1564, 1, true);
>>>>>>> dbb4c30fb50935a87c8da367ff7b0a7bdbd83656
            EndWriteAttribute();
            WriteLiteral(">Details</button>\n                </td>\n            </tr>\n");
#nullable restore
<<<<<<< HEAD
#line 49 "D:\ASP-PROJECT\Fashion_shop\Fashion_shop\Fashion_shop\Views\Users\Index.cshtml"
=======
#line 49 "/Users/phamcongly/Documents/GitHub/Fashion_shop/Fashion_shop/Fashion_shop/Views/Users/Index.cshtml"
>>>>>>> dbb4c30fb50935a87c8da367ff7b0a7bdbd83656
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Fashion_shop.Models.User>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
