#pragma checksum "/Users/takshdoria/Desktop/Courier_Management_.NetCoreMVC/Courier_Management_System/Views/User/Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da4122cdfbcc1a7642320fd36c0355e89e46ed3e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Profile), @"mvc.1.0.view", @"/Views/User/Profile.cshtml")]
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
#line 1 "/Users/takshdoria/Desktop/Courier_Management_.NetCoreMVC/Courier_Management_System/Views/_ViewImports.cshtml"
using Courier_Management_System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/takshdoria/Desktop/Courier_Management_.NetCoreMVC/Courier_Management_System/Views/_ViewImports.cshtml"
using Courier_Management_System.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da4122cdfbcc1a7642320fd36c0355e89e46ed3e", @"/Views/User/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ef3885b965a82ff5e3873a9599ae1fc12e1fee7", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Courier_Management_System.Models.User>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/profile.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("align-content:center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Consignment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<html>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da4122cdfbcc1a7642320fd36c0355e89e46ed3e6121", async() => {
                WriteLiteral("\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "da4122cdfbcc1a7642320fd36c0355e89e46ed3e6383", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    ");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da4122cdfbcc1a7642320fd36c0355e89e46ed3e8238", async() => {
                WriteLiteral(@"
    <div class=""container"">
        <div class=""main-body"">
            <div class=""row gutters-sm"">
                <div class=""col-md-4 mb-3"">
                    <div class=""card"">
                        <div class=""card-body"">
                            <div class=""d-flex flex-column align-items-center text-center"">
                                <img src=""https://bootdey.com/img/Content/avatar/avatar7.png"" alt=""Admin"" class=""rounded-circle"" width=""150"">
                                <div class=""mt-3"">
                                    <h4>");
#nullable restore
#line 16 "/Users/takshdoria/Desktop/Courier_Management_.NetCoreMVC/Courier_Management_System/Views/User/Profile.cshtml"
                                   Write(Model.name);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h4>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""card mt-3"">
                        <ul class=""list-group list-group-flush"">
                            <li class=""list-group-item d-flex justify-content-between align-items-center flex-wrap"">
                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da4122cdfbcc1a7642320fd36c0355e89e46ed3e9748", async() => {
                    WriteLiteral("Add Consignment");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                            </li>\n                            <li class=\"list-group-item d-flex justify-content-between align-items-center flex-wrap\">\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da4122cdfbcc1a7642320fd36c0355e89e46ed3e11529", async() => {
                    WriteLiteral("Check Status");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
</li>
                            <li class=""list-group-item d-flex justify-content-between align-items-center flex-wrap"">
                                <h6 class=""mb-0""><svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-twitter mr-2 icon-inline text-info""><path d=""M23 3a10.9 10.9 0 0 1-3.14 1.53 4.48 4.48 0 0 0-7.86 3v1A10.66 10.66 0 0 1 3 4s-4 9 5 13a11.64 11.64 0 0 1-7 2c9 5 20 0 20-11.5a4.5 4.5 0 0 0-.08-.83A7.72 7.72 0 0 0 23 3z""></path></svg>Twitter</h6>
                                <span class=""text-secondary"">bootdey</span>
                            </li>
                            <li class=""list-group-item d-flex justify-content-between align-items-center flex-wrap"">
                                <h6 class=""mb-0""><svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-wid");
                WriteLiteral(@"th=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-instagram mr-2 icon-inline text-danger""><rect x=""2"" y=""2"" width=""20"" height=""20"" rx=""5"" ry=""5""></rect><path d=""M16 11.37A4 4 0 1 1 12.63 8 4 4 0 0 1 16 11.37z""></path><line x1=""17.5"" y1=""6.5"" x2=""17.51"" y2=""6.5""></line></svg>Instagram</h6>
                                <span class=""text-secondary"">bootdey</span>
                            </li>
                            <li class=""list-group-item d-flex justify-content-between align-items-center flex-wrap"">
                                <h6 class=""mb-0""><svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-facebook mr-2 icon-inline text-primary""><path d=""M18 2h-3a5 5 0 0 0-5 5v3H7v4h3v8h4v-8h3l1-4h-4V7a1 1 0 0 1 1-1h3z""></path></svg>Facebook</h6>
                                <span class=""text-secondary"">bootdey</span>
        ");
                WriteLiteral(@"                    </li>
                        </ul>
                    </div>
                </div>
                <div class=""col-md-8"">
                    <div class=""card mb-3"">
                        <div class=""card-body"">
                            <div class=""row"">
                                <div class=""col-sm-3"">
                                    <h6 class=""mb-0"">Full Name</h6>
                                </div>
                                <div class=""col-sm-9 text-secondary"">
                                    ");
#nullable restore
#line 52 "/Users/takshdoria/Desktop/Courier_Management_.NetCoreMVC/Courier_Management_System/Views/User/Profile.cshtml"
                               Write(Model.name);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                </div>
                            </div>
                            <hr>
                            <div class=""row"">
                                <div class=""col-sm-3"">
                                    <h6 class=""mb-0"">Email</h6>
                                </div>
                                <div class=""col-sm-9 text-secondary"">
                                    ");
#nullable restore
#line 61 "/Users/takshdoria/Desktop/Courier_Management_.NetCoreMVC/Courier_Management_System/Views/User/Profile.cshtml"
                               Write(Model.email);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                </div>
                            </div>
                            <hr>
                            <div class=""row"">
                                <div class=""col-sm-3"">
                                    <h6 class=""mb-0"">Phone</h6>
                                </div>
                                <div class=""col-sm-9 text-secondary"">
                                    ");
#nullable restore
#line 70 "/Users/takshdoria/Desktop/Courier_Management_.NetCoreMVC/Courier_Management_System/Views/User/Profile.cshtml"
                               Write(Model.phone_no);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                </div>  
                            </div>
                            <hr>
                            <div class=""row"">
                                <div class=""col-sm-3"">
                                    <h6 class=""mb-0"">Address</h6>
                                </div>
                                <div class=""col-sm-9 text-secondary"">
                                    ");
#nullable restore
#line 79 "/Users/takshdoria/Desktop/Courier_Management_.NetCoreMVC/Courier_Management_System/Views/User/Profile.cshtml"
                               Write(Model.address);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""row gutters-sm"">
                        <div class=""col-sm-6 mb-3"">
                            <div class=""card h-100"">
                                <div class=""card-body"">
                                    <h6 class=""d-flex align-items-center mb-3""><i class=""material-icons text-info mr-2"">assignment</i>Project Status</h6>
                                    <small>Web Design</small>
                                    <div class=""progress mb-3"" style=""height: 5px"">
                                        <div class=""progress-bar bg-primary"" role=""progressbar"" style=""width: 80%"" aria-valuenow=""80"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                                    </div>
                                    <small>Website Markup</small>
                                    <div class=""progress mb-3"" style=""height: 5px"">
         ");
                WriteLiteral(@"                               <div class=""progress-bar bg-primary"" role=""progressbar"" style=""width: 72%"" aria-valuenow=""72"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                                    </div>
                                    <small>One Page</small>
                                    <div class=""progress mb-3"" style=""height: 5px"">
                                        <div class=""progress-bar bg-primary"" role=""progressbar"" style=""width: 89%"" aria-valuenow=""89"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                                    </div>
                                    <small>Mobile Template</small>
                                    <div class=""progress mb-3"" style=""height: 5px"">
                                        <div class=""progress-bar bg-primary"" role=""progressbar"" style=""width: 55%"" aria-valuenow=""55"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                                    </div>
                                    <small>Backend API</small>
         ");
                WriteLiteral(@"                           <div class=""progress mb-3"" style=""height: 5px"">
                                        <div class=""progress-bar bg-primary"" role=""progressbar"" style=""width: 66%"" aria-valuenow=""66"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-sm-6 mb-3"">
                            <div class=""card h-100"">
                                <div class=""card-body"">
                                    <h6 class=""d-flex align-items-center mb-3""><i class=""material-icons text-info mr-2"">assignment</i>Project Status</h6>
                                    <small>Web Design</small>
                                    <div class=""progress mb-3"" style=""height: 5px"">
                                        <div class=""progress-bar bg-primary"" role=""progressbar"" style=""width: 80%"" aria-valuenow=""80"" aria-valuemin=""0"" aria-valu");
                WriteLiteral(@"emax=""100""></div>
                                    </div>
                                    <small>Website Markup</small>
                                    <div class=""progress mb-3"" style=""height: 5px"">
                                        <div class=""progress-bar bg-primary"" role=""progressbar"" style=""width: 72%"" aria-valuenow=""72"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                                    </div>
                                    <small>One Page</small>
                                    <div class=""progress mb-3"" style=""height: 5px"">
                                        <div class=""progress-bar bg-primary"" role=""progressbar"" style=""width: 89%"" aria-valuenow=""89"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                                    </div>
                                    <small>Mobile Template</small>
                                    <div class=""progress mb-3"" style=""height: 5px"">
                                        <div class=""progress-bar bg-primar");
                WriteLiteral(@"y"" role=""progressbar"" style=""width: 55%"" aria-valuenow=""55"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                                    </div>
                                    <small>Backend API</small>
                                    <div class=""progress mb-3"" style=""height: 5px"">
                                        <div class=""progress-bar bg-primary"" role=""progressbar"" style=""width: 66%"" aria-valuenow=""66"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
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
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Courier_Management_System.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
