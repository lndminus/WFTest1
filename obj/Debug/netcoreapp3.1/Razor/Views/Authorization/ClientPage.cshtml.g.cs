#pragma checksum "C:\Users\Максим\source\repos\WorkFinder\Views\Authorization\ClientPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3896bfc7cb80b3d4904bdca89d128f401f8928f9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Authorization_ClientPage), @"mvc.1.0.view", @"/Views/Authorization/ClientPage.cshtml")]
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
#line 1 "C:\Users\Максим\source\repos\WorkFinder\Views\_ViewImports.cshtml"
using WorkFinder;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Максим\source\repos\WorkFinder\Views\_ViewImports.cshtml"
using WorkFinder.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3896bfc7cb80b3d4904bdca89d128f401f8928f9", @"/Views/Authorization/ClientPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"438d3beb01c139d469f5ff2455c389a9157c0dca", @"/Views/_ViewImports.cshtml")]
    public class Views_Authorization_ClientPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-brand"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"container body-content\">\r\n    <footer>\r\n        <h1>Клієнт</h1>\r\n    </footer>\r\n    <footer>\r\n        <h2>");
#nullable restore
#line 6 "C:\Users\Максим\source\repos\WorkFinder\Views\Authorization\ClientPage.cshtml"
       Write(ViewBag.Client.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    </footer>\r\n    <footer>\r\n        <h2>");
#nullable restore
#line 9 "C:\Users\Максим\source\repos\WorkFinder\Views\Authorization\ClientPage.cshtml"
       Write(ViewBag.Client.Surename);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    </footer>\r\n    <div class=\"container\">\r\n        <ul class=\"nav navbar-nav\">\r\n            <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3896bfc7cb80b3d4904bdca89d128f401f8928f94217", async() => {
                WriteLiteral("Створити оголошення");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 323, "~/AdPost/CreatePost?clientid=", 323, 29, true);
#nullable restore
#line 13 "C:\Users\Максим\source\repos\WorkFinder\Views\Authorization\ClientPage.cshtml"
AddHtmlAttributeValue("", 352, ViewBag.Client.Id, 352, 18, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n        </ul>\r\n    </div>\r\n    <div class=\"container\">\r\n        <ul class=\"nav navbar-nav\">\r\n            <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3896bfc7cb80b3d4904bdca89d128f401f8928f95986", async() => {
                WriteLiteral("Переглянути оголошення");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 541, "~/AdPost/ShowAllPosts?clientid=", 541, 31, true);
#nullable restore
#line 18 "C:\Users\Максим\source\repos\WorkFinder\Views\Authorization\ClientPage.cshtml"
AddHtmlAttributeValue("", 572, ViewBag.Client.Id, 572, 18, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n        </ul>\r\n    </div>\r\n    <div>\r\n        <p>Запити на виконання ваших оголошень</p>\r\n        <table class=\"table-condensed\">\r\n            <tr>\r\n                <td>Оголошення</td>\r\n                <td></td>\r\n            </tr>\r\n");
#nullable restore
#line 28 "C:\Users\Максим\source\repos\WorkFinder\Views\Authorization\ClientPage.cshtml"
             foreach (var request in ViewBag.ClientPostRequests)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\Максим\source\repos\WorkFinder\Views\Authorization\ClientPage.cshtml"
                 foreach (var post in ViewBag.ClientPosts)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\Максим\source\repos\WorkFinder\Views\Authorization\ClientPage.cshtml"
                     if (request.AdPostId == post.AdPostId)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 35 "C:\Users\Максим\source\repos\WorkFinder\Views\Authorization\ClientPage.cshtml"
                           Write(post.PostName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3896bfc7cb80b3d4904bdca89d128f401f8928f99028", async() => {
                WriteLiteral("Детальніше");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1246, "~/AdPost/ShowRequest?requestid=", 1246, 31, true);
#nullable restore
#line 36 "C:\Users\Максим\source\repos\WorkFinder\Views\Authorization\ClientPage.cshtml"
AddHtmlAttributeValue("", 1277, request.RequestId, 1277, 18, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 1295, "&clientid=", 1295, 10, true);
#nullable restore
#line 36 "C:\Users\Максим\source\repos\WorkFinder\Views\Authorization\ClientPage.cshtml"
AddHtmlAttributeValue("", 1305, ViewBag.Client.Id, 1305, 18, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                        </tr>\r\n");
#nullable restore
#line 38 "C:\Users\Максим\source\repos\WorkFinder\Views\Authorization\ClientPage.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\Максим\source\repos\WorkFinder\Views\Authorization\ClientPage.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\Максим\source\repos\WorkFinder\Views\Authorization\ClientPage.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
