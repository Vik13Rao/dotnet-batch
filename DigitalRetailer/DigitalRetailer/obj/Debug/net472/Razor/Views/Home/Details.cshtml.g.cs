#pragma checksum "C:\Users\vikram.rao\Documents\GitHub\dotnet-batch\DigitalRetailer\DigitalRetailer\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00649a9f4f3d7e1b05c8548d8326b6ee61b93859"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Details.cshtml", typeof(AspNetCore.Views_Home_Details))]
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
#line 1 "C:\Users\vikram.rao\Documents\GitHub\dotnet-batch\DigitalRetailer\DigitalRetailer\Views\_ViewImports.cshtml"
using DigitalRetailer.ViewModels;

#line default
#line hidden
#line 2 "C:\Users\vikram.rao\Documents\GitHub\dotnet-batch\DigitalRetailer\DigitalRetailer\Views\_ViewImports.cshtml"
using DigitalRetailer.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00649a9f4f3d7e1b05c8548d8326b6ee61b93859", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4bea99f86baceb5feb0050c9899a2c21429df7a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Laptop>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\vikram.rao\Documents\GitHub\dotnet-batch\DigitalRetailer\DigitalRetailer\Views\Home\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(58, 101, true);
            WriteLiteral("\r\n<section class=\"jumbotron text-center\">\r\n\t<div class=\"container\">\r\n\t\t<h1 class=\"jumbotron-heading\">");
            EndContext();
            BeginContext(160, 10, false);
#line 8 "C:\Users\vikram.rao\Documents\GitHub\dotnet-batch\DigitalRetailer\DigitalRetailer\Views\Home\Details.cshtml"
                                 Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(170, 14, true);
            WriteLiteral("</h1>\r\n\t\t<h5>$");
            EndContext();
            BeginContext(185, 11, false);
#line 9 "C:\Users\vikram.rao\Documents\GitHub\dotnet-batch\DigitalRetailer\DigitalRetailer\Views\Home\Details.cshtml"
        Write(Model.Price);

#line default
#line hidden
            EndContext();
            BeginContext(196, 102, true);
            WriteLiteral("</h5>\r\n\t</div>\r\n</section>\r\n<div class=\"container\">\r\n\t<div class=\"row\">\r\n\t\t<div class=\"col-lg-4\">\r\n\t\t\t");
            EndContext();
            BeginContext(298, 80, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "00649a9f4f3d7e1b05c8548d8326b6ee61b938594908", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 308, "~/Images/", 308, 9, true);
#line 15 "C:\Users\vikram.rao\Documents\GitHub\dotnet-batch\DigitalRetailer\DigitalRetailer\Views\Home\Details.cshtml"
AddHtmlAttributeValue("", 317, Model.ImageUrl, 317, 15, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 15 "C:\Users\vikram.rao\Documents\GitHub\dotnet-batch\DigitalRetailer\DigitalRetailer\Views\Home\Details.cshtml"
AddHtmlAttributeValue("", 357, Model.Name, 357, 11, false);

#line default
#line hidden
            AddHtmlAttributeValue(" ", 368, "image", 369, 6, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(378, 44, true);
            WriteLiteral("\r\n\t\t</div>\r\n\t\t<div class=\"col-lg-8\">\r\n\t\t\t<p>");
            EndContext();
            BeginContext(423, 17, false);
#line 18 "C:\Users\vikram.rao\Documents\GitHub\dotnet-batch\DigitalRetailer\DigitalRetailer\Views\Home\Details.cshtml"
          Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(440, 42, true);
            WriteLiteral("</p>\r\n\t\t\t<a class=\"btn btn-lg btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 482, "\"", 510, 2);
            WriteAttributeValue("", 489, "/home/order/", 489, 12, true);
#line 19 "C:\Users\vikram.rao\Documents\GitHub\dotnet-batch\DigitalRetailer\DigitalRetailer\Views\Home\Details.cshtml"
WriteAttributeValue("", 501, Model.Id, 501, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(511, 41, true);
            WriteLiteral(">Buy</a>\r\n\t\t</div>\r\n\t</div>\r\n</div>\r\n\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Laptop> Html { get; private set; }
    }
}
#pragma warning restore 1591
