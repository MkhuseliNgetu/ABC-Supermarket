#pragma checksum "C:\Users\BraJo\Desktop\CLDV6212 Task 2 Mkhuseli Ngetu 20108278\ABC Supermarket\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae81dd34f5d4df8585d62f94cee87b7630ae3ff6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\BraJo\Desktop\CLDV6212 Task 2 Mkhuseli Ngetu 20108278\ABC Supermarket\Views\_ViewImports.cshtml"
using PractisingImageUpload;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\BraJo\Desktop\CLDV6212 Task 2 Mkhuseli Ngetu 20108278\ABC Supermarket\Views\_ViewImports.cshtml"
using PractisingImageUpload.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae81dd34f5d4df8585d62f94cee87b7630ae3ff6", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f409e7fb24ad45e3c12374fa48848aa855246c10", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
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
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ae81dd34f5d4df8585d62f94cee87b7630ae3ff63377", async() => {
                WriteLiteral("\r\n    <title> Home</title>\r\n");
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
            WriteLiteral("\r\n\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ae81dd34f5d4df8585d62f94cee87b7630ae3ff64383", async() => {
                WriteLiteral("\r\n    <h1 style=\"text-align:center\">Welcome to ABC Supermarket</h1>\r\n    <div>\r\n        <table>\r\n            <tr>\r\n");
#nullable restore
#line 14 "C:\Users\BraJo\Desktop\CLDV6212 Task 2 Mkhuseli Ngetu 20108278\ABC Supermarket\Views\Home\Index.cshtml"
                 foreach (string item in Model.ProductImages)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <td><img");
                BeginWriteAttribute("src", " src=\"", 305, "\"", 340, 2);
                WriteAttributeValue("", 311, "data:image/jpeg;base64,", 311, 23, true);
#nullable restore
#line 16 "C:\Users\BraJo\Desktop\CLDV6212 Task 2 Mkhuseli Ngetu 20108278\ABC Supermarket\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 334, item, 335, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" width=\"250\" height=\"250\" style=\"align-content:left\" alt=\"Product Image Unavailable\"/></td>");
#nullable restore
#line 16 "C:\Users\BraJo\Desktop\CLDV6212 Task 2 Mkhuseli Ngetu 20108278\ABC Supermarket\Views\Home\Index.cshtml"
                                                                                                                                                           //(W3docs, s.a).

                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </tr>\r\n\r\n            <tr>\r\n\r\n");
#nullable restore
#line 23 "C:\Users\BraJo\Desktop\CLDV6212 Task 2 Mkhuseli Ngetu 20108278\ABC Supermarket\Views\Home\Index.cshtml"
                 foreach (string item2 in Model.ProductNames)
                {




#line default
#line hidden
#nullable disable
                WriteLiteral("                    <td>");
#nullable restore
#line 28 "C:\Users\BraJo\Desktop\CLDV6212 Task 2 Mkhuseli Ngetu 20108278\ABC Supermarket\Views\Home\Index.cshtml"
                   Write(item2);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n");
#nullable restore
#line 29 "C:\Users\BraJo\Desktop\CLDV6212 Task 2 Mkhuseli Ngetu 20108278\ABC Supermarket\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </tr>\r\n\r\n            <tr>\r\n\r\n");
#nullable restore
#line 35 "C:\Users\BraJo\Desktop\CLDV6212 Task 2 Mkhuseli Ngetu 20108278\ABC Supermarket\Views\Home\Index.cshtml"
                 foreach (string item3 in Model.ProductDescriptions)
                {




#line default
#line hidden
#nullable disable
                WriteLiteral("                    <td>");
#nullable restore
#line 40 "C:\Users\BraJo\Desktop\CLDV6212 Task 2 Mkhuseli Ngetu 20108278\ABC Supermarket\Views\Home\Index.cshtml"
                   Write(item3);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n");
#nullable restore
#line 41 "C:\Users\BraJo\Desktop\CLDV6212 Task 2 Mkhuseli Ngetu 20108278\ABC Supermarket\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n            </tr>\r\n\r\n            <tr>\r\n\r\n");
#nullable restore
#line 48 "C:\Users\BraJo\Desktop\CLDV6212 Task 2 Mkhuseli Ngetu 20108278\ABC Supermarket\Views\Home\Index.cshtml"
                 foreach (string item4 in Model.ProductPrices)
                {




#line default
#line hidden
#nullable disable
                WriteLiteral("                    <td>");
#nullable restore
#line 53 "C:\Users\BraJo\Desktop\CLDV6212 Task 2 Mkhuseli Ngetu 20108278\ABC Supermarket\Views\Home\Index.cshtml"
                   Write(item4);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n");
#nullable restore
#line 54 "C:\Users\BraJo\Desktop\CLDV6212 Task 2 Mkhuseli Ngetu 20108278\ABC Supermarket\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n            </tr>\r\n        </table>\r\n\r\n\r\n\r\n\r\n\r\n\r\n    </div>\r\n    \r\n");
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
            WriteLiteral("\r\n</html>");
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
