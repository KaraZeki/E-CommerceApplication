#pragma checksum "D:\Asp_NETMVC\EnginDemirog\Abc\Abc.MsSql.MvcWebUI\Views\Shared\Components\CartSummary\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2e5265a75d4f23e412b1623a3ffdd759cbc0517"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CartSummary_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CartSummary/Default.cshtml")]
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
#line 1 "D:\Asp_NETMVC\EnginDemirog\Abc\Abc.MsSql.MvcWebUI\Views\_ViewImports.cshtml"
using Abc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Asp_NETMVC\EnginDemirog\Abc\Abc.MsSql.MvcWebUI\Views\_ViewImports.cshtml"
using Abc.MsSql.Business;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Asp_NETMVC\EnginDemirog\Abc\Abc.MsSql.MvcWebUI\Views\_ViewImports.cshtml"
using Abc.MsSql.DataAccess;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Asp_NETMVC\EnginDemirog\Abc\Abc.MsSql.MvcWebUI\Views\_ViewImports.cshtml"
using Abc.MsSql.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Asp_NETMVC\EnginDemirog\Abc\Abc.MsSql.MvcWebUI\Views\_ViewImports.cshtml"
using Abc.MsSql.MvcWebUI;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2e5265a75d4f23e412b1623a3ffdd759cbc0517", @"/Views/Shared/Components/CartSummary/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95dcc0305617cdff3c8bc1d04226ac5d7d627c03", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_CartSummary_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Abc.MsSql.MvcWebUI.Moddels.CartSummaryViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dropdown-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "List", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n\r\n<div class=\"dropdown-menu\" aria-labelledby=\"dropdownMenuLink\">\r\n");
#nullable restore
#line 5 "D:\Asp_NETMVC\EnginDemirog\Abc\Abc.MsSql.MvcWebUI\Views\Shared\Components\CartSummary\Default.cshtml"
     foreach (var item in Model.Cart.CartLines)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a class=\"dropdown-item\" href=\"#\">");
#nullable restore
#line 7 "D:\Asp_NETMVC\EnginDemirog\Abc\Abc.MsSql.MvcWebUI\Views\Shared\Components\CartSummary\Default.cshtml"
                                     Write(item.Product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("<span class=\"badge\">");
#nullable restore
#line 7 "D:\Asp_NETMVC\EnginDemirog\Abc\Abc.MsSql.MvcWebUI\Views\Shared\Components\CartSummary\Default.cshtml"
                                                                                  Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></a>\r\n");
#nullable restore
#line 8 "D:\Asp_NETMVC\EnginDemirog\Abc\Abc.MsSql.MvcWebUI\Views\Shared\Components\CartSummary\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <a class=""dropdown-item"" href=""#"">
        <svg width=""1em"" height=""1em"" viewBox=""0 0 16 16"" class=""bi bi-cart-dash-fill"" fill=""currentColor"" xmlns=""http://www.w3.org/2000/svg"">
            <path fill-rule=""evenodd"" d=""M.5 1a.5.5 0 0 0 0 1h1.11l.401 1.607 1.498 7.985A.5.5 0 0 0 4 12h1a2 2 0 1 0 0 4 2 2 0 0 0 0-4h7a2 2 0 1 0 0 4 2 2 0 0 0 0-4h1a.5.5 0 0 0 .491-.408l1.5-8A.5.5 0 0 0 14.5 3H2.89l-.405-1.621A.5.5 0 0 0 2 1H.5zM4 14a1 1 0 1 1 2 0 1 1 0 0 1-2 0zm7 0a1 1 0 1 1 2 0 1 1 0 0 1-2 0zM6.5 7a.5.5 0 0 0 0 1h4a.5.5 0 0 0 0-1h-4z""></path>
        </svg>");
#nullable restore
#line 13 "D:\Asp_NETMVC\EnginDemirog\Abc\Abc.MsSql.MvcWebUI\Views\Shared\Components\CartSummary\Default.cshtml"
         Write(Model.Cart.Total);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </a>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c2e5265a75d4f23e412b1623a3ffdd759cbc05176830", async() => {
                WriteLiteral("Go To Cart Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Abc.MsSql.MvcWebUI.Moddels.CartSummaryViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
