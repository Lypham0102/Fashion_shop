#pragma checksum "/Users/phamcongly/Documents/GitHub/Fashion_shop/Fashion_shop/Fashion_shop/Views/Shared/_LayoutAdmin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3237294f640b99f67fd07d61be38f15e90de7d83"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__LayoutAdmin), @"mvc.1.0.view", @"/Views/Shared/_LayoutAdmin.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3237294f640b99f67fd07d61be38f15e90de7d83", @"/Views/Shared/_LayoutAdmin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d5e5ff572e834d76182c276324ef5f44f60458f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__LayoutAdmin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("g-sidenav-show   bg-gray-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\n<html lang=\"en\">\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3237294f640b99f67fd07d61be38f15e90de7d833706", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"" />
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">
    <link rel=""apple-touch-icon"" sizes=""76x76"" href=""../assets/img/apple-icon.png"">
    <link rel=""icon"" type=""image/png"" href=""../assets/img/favicon.png"">
    <title>
       Page for Admin
    </title>
    <!--     Fonts and icons     -->
    <link href=""https://fonts.googleapis.com/css?family=Open+Sans:300,400,600,700"" rel=""stylesheet"" />
    <!-- Nucleo Icons -->
    <link href=""../assets/css/nucleo-icons.css"" rel=""stylesheet"" />
    <link href=""../assets/css/nucleo-svg.css"" rel=""stylesheet"" />
    <!-- Font Awesome Icons -->
    <script src=""https://kit.fontawesome.com/42d5adcbca.js"" crossorigin=""anonymous""></script>
    <link href=""../assets/css/nucleo-svg.css"" rel=""stylesheet"" />
    <!-- CSS Files -->
    <link id=""pagestyle"" href=""../assets/css/argon-dashboard.css?v=2.0.4"" rel=""stylesheet"" />
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
            WriteLiteral("\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3237294f640b99f67fd07d61be38f15e90de7d835632", async() => {
                WriteLiteral(@"
    <div class=""min-height-300 bg-primary position-absolute w-100""></div>
    <aside class=""sidenav bg-white navbar navbar-vertical navbar-expand-xs border-0 border-radius-xl my-3 fixed-start ms-4 "" id=""sidenav-main"">
        <div class=""sidenav-header"">
            <i class=""fas fa-times p-3 cursor-pointer text-secondary opacity-5 position-absolute end-0 top-0 d-none d-xl-none"" aria-hidden=""true"" id=""iconSidenav""></i>
            <a class=""navbar-brand m-0"" href="" https://demos.creative-tim.com/argon-dashboard/pages/dashboard.html "" target=""_blank"">
                <img src=""../assets/img/logo-ct-dark.png"" class=""navbar-brand-img h-100"" alt=""main_logo"">
                <span class=""ms-1 font-weight-bold"">TL Shop Service</span>
            </a>
        </div>
        <hr class=""horizontal dark mt-0"">
        <div class=""collapse navbar-collapse  w-auto "" id=""sidenav-collapse-main"">
            <ul class=""navbar-nav"">
                <li class=""nav-item"">
                    <a class=""nav-link active""");
                BeginWriteAttribute("href", " href=\"", 2041, "\"", 2076, 1);
#nullable restore
#line 38 "/Users/phamcongly/Documents/GitHub/Fashion_shop/Fashion_shop/Fashion_shop/Views/Shared/_LayoutAdmin.cshtml"
WriteAttributeValue("", 2048, Url.Action("Index","Users"), 2048, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                        <div class=""icon icon-shape icon-sm border-radius-md text-center me-2 d-flex align-items-center justify-content-center"">
                            <i class=""ni ni-single-02 text-primary text-sm opacity-10""></i>
                        </div>
                        <span class=""nav-link-text ms-1"">User</span>
                    </a>
                </li>
                <li class=""nav-item"">
                    <a class=""nav-link """);
                BeginWriteAttribute("href", " href=\"", 2541, "\"", 2578, 1);
#nullable restore
#line 46 "/Users/phamcongly/Documents/GitHub/Fashion_shop/Fashion_shop/Fashion_shop/Views/Shared/_LayoutAdmin.cshtml"
WriteAttributeValue("", 2548, Url.Action("IndexAd","Items"), 2548, 30, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                        <div class=""icon icon-shape icon-sm border-radius-md text-center me-2 d-flex align-items-center justify-content-center"">
                            <i class=""ni ni-bag-17 text-warning text-sm opacity-10""></i>
                        </div>
                        <span class=""nav-link-text ms-1"">Item</span>
                    </a>
                </li>
                <li class=""nav-item"">
                    <a class=""nav-link """);
                BeginWriteAttribute("href", " href=\"", 3040, "\"", 3074, 1);
#nullable restore
#line 54 "/Users/phamcongly/Documents/GitHub/Fashion_shop/Fashion_shop/Fashion_shop/Views/Shared/_LayoutAdmin.cshtml"
WriteAttributeValue("", 3047, Url.Action("Index","Bill"), 3047, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                        <div class=""icon icon-shape icon-sm border-radius-md text-center me-2 d-flex align-items-center justify-content-center"">
                            <i class=""ni ni-credit-card text-success text-sm opacity-10""></i>
                        </div>
                        <span class=""nav-link-text ms-1"">Order</span>
                    </a>
                </li>
                <li class=""nav-item"">
                    <a class=""nav-link """);
                BeginWriteAttribute("href", " href=\"", 3542, "\"", 3579, 1);
#nullable restore
#line 62 "/Users/phamcongly/Documents/GitHub/Fashion_shop/Fashion_shop/Fashion_shop/Views/Shared/_LayoutAdmin.cshtml"
WriteAttributeValue("", 3549, Url.Action("Index","Voucher"), 3549, 30, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                        <div class=""icon icon-shape icon-sm border-radius-md text-center me-2 d-flex align-items-center justify-content-center"">
                            <i class=""ni ni-money-coins text-info text-sm opacity-10""></i>
                        </div>
                        <span class=""nav-link-text ms-1"">Voucher</span>
                    </a>
                </li>
                <li class=""nav-item mt-3"">
                    <h6 class=""ps-4 ms-2 text-uppercase text-xs font-weight-bolder opacity-6"">Account pages</h6>
                </li>
                <li class=""nav-item"">
                    <a class=""nav-link "" href=""../pages/profile.html"">
                        <div class=""icon icon-shape icon-sm border-radius-md text-center me-2 d-flex align-items-center justify-content-center"">
                            <i class=""ni ni-single-02 text-dark text-sm opacity-10""></i>
                        </div>
                        <span class=""nav-link-text ms-1"">Profile</span>
            ");
                WriteLiteral(@"        </a>
                </li>
                <li class=""nav-item"">
                    <a class=""nav-link "" href=""../pages/sign-in.html"">
                        <div class=""icon icon-shape icon-sm border-radius-md text-center me-2 d-flex align-items-center justify-content-center"">
                            <i class=""ni ni-single-copy-04 text-warning text-sm opacity-10""></i>
                        </div>
                        <span class=""nav-link-text ms-1"">Sign In</span>
                    </a>
                </li>
                <li class=""nav-item"">
                    <a class=""nav-link "" href=""../pages/sign-up.html"">
                        <div class=""icon icon-shape icon-sm border-radius-md text-center me-2 d-flex align-items-center justify-content-center"">
                            <i class=""ni ni-collection text-info text-sm opacity-10""></i>
                        </div>
                        <span class=""nav-link-text ms-1"">Sign Up</span>
                    </a>
                ");
                WriteLiteral(@"</li>
            </ul>
        </div>
    </aside>
    <main class=""main-content position-relative border-radius-lg"">
        <!-- Navbar -->
        <nav class=""navbar navbar-main navbar-expand-lg px-0 mx-4 shadow-none border-radius-xl "" id=""navbarBlur"" data-scroll=""false"">
            <div class=""container-fluid py-1 px-3"">
                <nav aria-label=""breadcrumb"">
                    <ol class=""breadcrumb bg-transparent mb-0 pb-0 pt-1 px-0 me-sm-6 me-5"">
                        <li class=""breadcrumb-item text-sm""><a class=""opacity-5 text-white"" href=""javascript:;"">Pages</a></li>
                        <li class=""breadcrumb-item text-sm text-white active"" aria-current=""page"">Dashboard</li>
                    </ol>
                    <h6 class=""font-weight-bolder text-white mb-0"">Dashboard</h6>
                </nav>
                <div class=""collapse navbar-collapse mt-sm-0 mt-2 me-md-0 me-sm-4"" id=""navbar"">
                    <div class=""ms-md-auto pe-md-3 d-flex align-items-center"">
           ");
                WriteLiteral(@"             <div class=""input-group"">
                            <span class=""input-group-text text-body""><i class=""fas fa-search"" aria-hidden=""true""></i></span>
                            <input type=""text"" class=""form-control"" placeholder=""Type here..."">
                        </div>
                    </div>
                    <ul class=""navbar-nav  justify-content-end"">
                        <li class=""nav-item d-flex align-items-center"">
                            <a href=""javascript:;"" class=""nav-link text-white font-weight-bold px-0"">
                                <i class=""fa fa-user me-sm-1""></i>
                                <span class=""d-sm-inline d-none"">Sign In</span>
                            </a>
                        </li>
                        <li class=""nav-item d-xl-none ps-3 d-flex align-items-center"">
                            <a href=""javascript:;"" class=""nav-link text-white p-0"" id=""iconNavbarSidenav"">
                                <div class=""sidenav-toggler-inn");
                WriteLiteral(@"er"">
                                    <i class=""sidenav-toggler-line bg-white""></i>
                                    <i class=""sidenav-toggler-line bg-white""></i>
                                    <i class=""sidenav-toggler-line bg-white""></i>
                                </div>
                            </a>
                        </li>
                        <li class=""nav-item px-3 d-flex align-items-center"">
                            <a href=""javascript:;"" class=""nav-link text-white p-0"">
                                <i class=""fa fa-cog fixed-plugin-button-nav cursor-pointer""></i>
                            </a>
                        </li>
                        <li class=""nav-item dropdown pe-2 d-flex align-items-center"">
                            <a href=""javascript:;"" class=""nav-link text-white p-0"" id=""dropdownMenuButton"" data-bs-toggle=""dropdown"" aria-expanded=""false"">
                                <i class=""fa fa-bell cursor-pointer""></i>
                            </a>
 ");
                WriteLiteral(@"                           <ul class=""dropdown-menu  dropdown-menu-end  px-2 py-3 me-sm-n4"" aria-labelledby=""dropdownMenuButton"">
                                <li class=""mb-2"">
                                    <a class=""dropdown-item border-radius-md"" href=""javascript:;"">
                                        <div class=""d-flex py-1"">
                                            <div class=""my-auto"">
                                                <img src=""../assets/img/team-2.jpg"" class=""avatar avatar-sm  me-3 "">
                                            </div>
                                            <div class=""d-flex flex-column justify-content-center"">
                                                <h6 class=""text-sm font-weight-normal mb-1"">
                                                    <span class=""font-weight-bold"">New message</span> from Laur
                                                </h6>
                                                <p class=""text-xs text-secondary mb-0""");
                WriteLiteral(@">
                                                    <i class=""fa fa-clock me-1""></i>
                                                    13 minutes ago
                                                </p>
                                            </div>
                                        </div>
                                    </a>
                                </li>
                                <li class=""mb-2"">
                                    <a class=""dropdown-item border-radius-md"" href=""javascript:;"">
                                        <div class=""d-flex py-1"">
                                            <div class=""my-auto"">
                                                <img src=""../assets/img/small-logos/logo-spotify.svg"" class=""avatar avatar-sm bg-gradient-dark  me-3 "">
                                            </div>
                                            <div class=""d-flex flex-column justify-content-center"">
                                                <h6 clas");
                WriteLiteral(@"s=""text-sm font-weight-normal mb-1"">
                                                    <span class=""font-weight-bold"">New album</span> by Travis Scott
                                                </h6>
                                                <p class=""text-xs text-secondary mb-0"">
                                                    <i class=""fa fa-clock me-1""></i>
                                                    1 day
                                                </p>
                                            </div>
                                        </div>
                                    </a>
                                </li>
                                <li>
                                    <a class=""dropdown-item border-radius-md"" href=""javascript:;"">
                                        <div class=""d-flex py-1"">
                                            <div class=""avatar avatar-sm bg-gradient-secondary  me-3  my-auto"">
                                          ");
                WriteLiteral(@"      <svg width=""12px"" height=""12px"" viewBox=""0 0 43 36"" version=""1.1"" xmlns=""http://www.w3.org/2000/svg"" xmlns:xlink=""http://www.w3.org/1999/xlink"">
                                                    <title>credit-card</title>
                                                    <g stroke=""none"" stroke-width=""1"" fill=""none"" fill-rule=""evenodd"">
                                                        <g transform=""translate(-2169.000000, -745.000000)"" fill=""#FFFFFF"" fill-rule=""nonzero"">
                                                            <g transform=""translate(1716.000000, 291.000000)"">
                                                                <g transform=""translate(453.000000, 454.000000)"">
                                                                    <path class=""color-background"" d=""M43,10.7482083 L43,3.58333333 C43,1.60354167 41.3964583,0 39.4166667,0 L3.58333333,0 C1.60354167,0 0,1.60354167 0,3.58333333 L0,10.7482083 L43,10.7482083 Z"" opacity=""0.593633743""></path>
                 ");
                WriteLiteral(@"                                                   <path class=""color-background"" d=""M0,16.125 L0,32.25 C0,34.2297917 1.60354167,35.8333333 3.58333333,35.8333333 L39.4166667,35.8333333 C41.3964583,35.8333333 43,34.2297917 43,32.25 L43,16.125 L0,16.125 Z M19.7083333,26.875 L7.16666667,26.875 L7.16666667,23.2916667 L19.7083333,23.2916667 L19.7083333,26.875 Z M35.8333333,26.875 L28.6666667,26.875 L28.6666667,23.2916667 L35.8333333,23.2916667 L35.8333333,26.875 Z""></path>
                                                                </g>
                                                            </g>
                                                        </g>
                                                    </g>
                                                </svg>
                                            </div>
                                            <div class=""d-flex flex-column justify-content-center"">
                                                <h6 class=""text-sm font-weight-normal mb-1"">
");
                WriteLiteral(@"                                                    Payment successfully completed
                                                </h6>
                                                <p class=""text-xs text-secondary mb-0"">
                                                    <i class=""fa fa-clock me-1""></i>
                                                    2 days
                                                </p>
                                            </div>
                                        </div>
                                    </a>
                                </li>
                            </ul>
                        </li>
                    </ul>
                </div>
            </div>
        </nav>
        <!-- End Navbar -->
        <div class=""container-fluid py-4 "";>
            <div class=""row"">
                <div class=""col-xl-3 col-sm-6 mb-xl-0 mb-4"">
                    <div class=""card"">
                        <div class=""card-body p-3"">
                       ");
                WriteLiteral(@"     <div class=""row"">
                                <div class=""col-8"">
                                    <div class=""numbers"">
                                        <p class=""text-sm mb-0 text-uppercase font-weight-bold"">Today's Money</p>
                                        <h5 class=""font-weight-bolder"">
                                            $53,000
                                        </h5>
                                        <p class=""mb-0"">
                                            <span class=""text-success text-sm font-weight-bolder"">+55%</span>
                                            since yesterday
                                        </p>
                                    </div>
                                </div>
                                <div class=""col-4 text-end"">
                                    <div class=""icon icon-shape bg-gradient-primary shadow-primary text-center rounded-circle"">
                                        <i class=""ni ni-money-co");
                WriteLiteral(@"ins text-lg opacity-10"" aria-hidden=""true""></i>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col-xl-3 col-sm-6 mb-xl-0 mb-4"">
                    <div class=""card"">
                        <div class=""card-body p-3"">
                            <div class=""row"">
                                <div class=""col-8"">
                                    <div class=""numbers"">
                                        <p class=""text-sm mb-0 text-uppercase font-weight-bold"">Today's Users</p>
                                        <h5 class=""font-weight-bolder"">
                                            2,300
                                        </h5>
                                        <p class=""mb-0"">
                                            <span class=""text-success text-sm font-weight-bolder"">+3%</span>
                      ");
                WriteLiteral(@"                      since last week
                                        </p>
                                    </div>
                                </div>
                                <div class=""col-4 text-end"">
                                    <div class=""icon icon-shape bg-gradient-danger shadow-danger text-center rounded-circle"">
                                        <i class=""ni ni-world text-lg opacity-10"" aria-hidden=""true""></i>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col-xl-3 col-sm-6 mb-xl-0 mb-4"">
                    <div class=""card"">
                        <div class=""card-body p-3"">
                            <div class=""row"">
                                <div class=""col-8"">
                                    <div class=""numbers"">
                                        <p class=""text-sm mb");
                WriteLiteral(@"-0 text-uppercase font-weight-bold"">New Clients</p>
                                        <h5 class=""font-weight-bolder"">
                                            +3,462
                                        </h5>
                                        <p class=""mb-0"">
                                            <span class=""text-danger text-sm font-weight-bolder"">-2%</span>
                                            since last quarter
                                        </p>
                                    </div>
                                </div>
                                <div class=""col-4 text-end"">
                                    <div class=""icon icon-shape bg-gradient-success shadow-success text-center rounded-circle"">
                                        <i class=""ni ni-paper-diploma text-lg opacity-10"" aria-hidden=""true""></i>
                                    </div>
                                </div>
                            </div>
                        </di");
                WriteLiteral(@"v>
                    </div>
                </div>
            </div>
            <div style=""height: 100px;""></div>    
        </div>
        <div class=""container"" style=""margin-left: 10px;"">
                <main role=""main"" class=""pb-3"">
                    ");
#nullable restore
#line 298 "/Users/phamcongly/Documents/GitHub/Fashion_shop/Fashion_shop/Fashion_shop/Views/Shared/_LayoutAdmin.cshtml"
               Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                </main>
        </div>
    </main>
    <div class=""fixed-plugin"">
        <a class=""fixed-plugin-button text-dark position-fixed px-3 py-2"">
            <i class=""fa fa-cog py-2""> </i>
        </a>
        <div class=""card shadow-lg"">
            <div class=""card-header pb-0 pt-3 "">
                <div class=""float-start"">
                    <h5 class=""mt-3 mb-0"">Argon Configurator</h5>
                    <p>See our dashboard options.</p>
                </div>
                <div class=""float-end mt-4"">
                    <button class=""btn btn-link text-dark p-0 fixed-plugin-close-button"">
                        <i class=""fa fa-close""></i>
                    </button>
                </div>
                <!-- End Toggle Button -->
            </div>
            <hr class=""horizontal dark my-1"">
            <div class=""card-body pt-sm-3 pt-0 overflow-auto"">
                <!-- Sidebar Backgrounds -->
                <div>
                    <h6 class=""mb-0"">Sidebar Colors</h6>
   ");
                WriteLiteral(@"             </div>
                <a href=""javascript:void(0)"" class=""switch-trigger background-color"">
                    <div class=""badge-colors my-2 text-start"">
                        <span class=""badge filter bg-gradient-primary active"" data-color=""primary"" onclick=""sidebarColor(this)""></span>
                        <span class=""badge filter bg-gradient-dark"" data-color=""dark"" onclick=""sidebarColor(this)""></span>
                        <span class=""badge filter bg-gradient-info"" data-color=""info"" onclick=""sidebarColor(this)""></span>
                        <span class=""badge filter bg-gradient-success"" data-color=""success"" onclick=""sidebarColor(this)""></span>
                        <span class=""badge filter bg-gradient-warning"" data-color=""warning"" onclick=""sidebarColor(this)""></span>
                        <span class=""badge filter bg-gradient-danger"" data-color=""danger"" onclick=""sidebarColor(this)""></span>
                    </div>
                </a>
                <!-- Sidenav Type -->
  ");
                WriteLiteral(@"              <div class=""mt-3"">
                    <h6 class=""mb-0"">Sidenav Type</h6>
                    <p class=""text-sm"">Choose between 2 different sidenav types.</p>
                </div>
                <div class=""d-flex"">
                    <button class=""btn bg-gradient-primary w-100 px-3 mb-2 active me-2"" data-class=""bg-white"" onclick=""sidebarType(this)"">White</button>
                    <button class=""btn bg-gradient-primary w-100 px-3 mb-2"" data-class=""bg-default"" onclick=""sidebarType(this)"">Dark</button>
                </div>
                <p class=""text-sm d-xl-none d-block mt-2"">You can change the sidenav type just on desktop view.</p>
                <!-- Navbar Fixed -->
                <div class=""d-flex my-3"">
                    <h6 class=""mb-0"">Navbar Fixed</h6>
                    <div class=""form-check form-switch ps-0 ms-auto my-auto"">
                        <input class=""form-check-input mt-1 ms-auto"" type=""checkbox"" id=""navbarFixed"" onclick=""navbarFixed(this)"">
             ");
                WriteLiteral(@"       </div>
                </div>
                <hr class=""horizontal dark my-sm-4"">
                <div class=""mt-2 mb-5 d-flex"">
                    <h6 class=""mb-0"">Light / Dark</h6>
                    <div class=""form-check form-switch ps-0 ms-auto my-auto"">
                        <input class=""form-check-input mt-1 ms-auto"" type=""checkbox"" id=""dark-version"" onclick=""darkMode(this)"">
                    </div>
                </div>
                <a class=""btn bg-gradient-dark w-100"" href=""https://www.creative-tim.com/product/argon-dashboard"">Free Download</a>
                <a class=""btn btn-outline-dark w-100"" href=""https://www.creative-tim.com/learning-lab/bootstrap/license/argon-dashboard"">View documentation</a>
                <div class=""w-100 text-center"">
                    <a class=""github-button"" href=""https://github.com/creativetimofficial/argon-dashboard"" data-icon=""octicon-star"" data-size=""large"" data-show-count=""true"" aria-label=""Star creativetimofficial/argon-dashboard on GitHub");
                WriteLiteral(@""">Star</a>
                    <h6 class=""mt-3"">Thank you for sharing!</h6>
                    <a href=""https://twitter.com/intent/tweet?text=Check%20Argon%20Dashboard%20made%20by%20%40CreativeTim%20%23webdesign%20%23dashboard%20%23bootstrap5&amp;url=https%3A%2F%2Fwww.creative-tim.com%2Fproduct%2Fargon-dashboard"" class=""btn btn-dark mb-0 me-2"" target=""_blank"">
                        <i class=""fab fa-twitter me-1"" aria-hidden=""true""></i> Tweet
                    </a>
                    <a href=""https://www.facebook.com/sharer/sharer.php?u=https://www.creative-tim.com/product/argon-dashboard"" class=""btn btn-dark mb-0 me-2"" target=""_blank"">
                        <i class=""fab fa-facebook-square me-1"" aria-hidden=""true""></i> Share
                    </a>
                </div>
            </div>
        </div>
    </div>
    <!--   Core JS Files   -->
    <script src=""../assets/js/core/popper.min.js""></script>
    <script src=""../assets/js/core/bootstrap.min.js""></script>
    <script src=""../assets/js/plug");
                WriteLiteral(@"ins/perfect-scrollbar.min.js""></script>
    <script src=""../assets/js/plugins/smooth-scrollbar.min.js""></script>
    <script src=""../assets/js/plugins/chartjs.min.js""></script>
    <script>var ctx1 = document.getElementById(""chart-line"").getContext(""2d"");

        var gradientStroke1 = ctx1.createLinearGradient(0, 230, 0, 50);

        gradientStroke1.addColorStop(1, 'rgba(94, 114, 228, 0.2)');
        gradientStroke1.addColorStop(0.2, 'rgba(94, 114, 228, 0.0)');
        gradientStroke1.addColorStop(0, 'rgba(94, 114, 228, 0)');
        new Chart(ctx1, {
            type: ""line"",
            data: {
                labels: [""Apr"", ""May"", ""Jun"", ""Jul"", ""Aug"", ""Sep"", ""Oct"", ""Nov"", ""Dec""],
                datasets: [{
                    label: ""Mobile apps"",
                    tension: 0.4,
                    borderWidth: 0,
                    pointRadius: 0,
                    borderColor: ""#5e72e4"",
                    backgroundColor: gradientStroke1,
                    borderWidth: 3,
                  ");
                WriteLiteral(@"  fill: true,
                    data: [50, 40, 300, 220, 500, 250, 400, 230, 500],
                    maxBarThickness: 6

                }],
            },
            options: {
                responsive: true,
                maintainAspectRatio: false,
                plugins: {
                    legend: {
                        display: false,
                    }
                },
                interaction: {
                    intersect: false,
                    mode: 'index',
                },
                scales: {
                    y: {
                        grid: {
                            drawBorder: false,
                            display: true,
                            drawOnChartArea: true,
                            drawTicks: false,
                            borderDash: [5, 5]
                        },
                        ticks: {
                            display: true,
                            padding: 10,
                            color: '#fbfb");
                WriteLiteral(@"fb',
                            font: {
                                size: 11,
                                family: ""Open Sans"",
                                style: 'normal',
                                lineHeight: 2
                            },
                        }
                    },
                    x: {
                        grid: {
                            drawBorder: false,
                            display: false,
                            drawOnChartArea: false,
                            drawTicks: false,
                            borderDash: [5, 5]
                        },
                        ticks: {
                            display: true,
                            color: '#ccc',
                            padding: 20,
                            font: {
                                size: 11,
                                family: ""Open Sans"",
                                style: 'normal',
                                lineHeight: 2
       ");
                WriteLiteral(@"                     },
                        }
                    },
                },
            },
        });</script>
    <script>var win = navigator.platform.indexOf('Win') > -1;
        if (win && document.querySelector('#sidenav-scrollbar')) {
            var options = {
                damping: '0.5'
            }
            Scrollbar.init(document.querySelector('#sidenav-scrollbar'), options);
        }</script>
    <!-- Github buttons -->
    <script async defer src=""https://buttons.github.io/buttons.js""></script>
    <!-- Control Center for Soft Dashboard: parallax effects, scripts for the example pages etc -->
    <script src=""../assets/js/argon-dashboard.min.js?v=2.0.4""></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n</html>");
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