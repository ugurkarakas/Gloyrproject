#pragma checksum "C:\Users\User\Desktop\gloyr5gen - Kopya\gloyr5gen\Views\Shared\Components\CategoryMenu\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c3ae3adbc8c5f305e654cccbafd534b42cacc055"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CategoryMenu_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CategoryMenu/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/CategoryMenu/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_CategoryMenu_Default))]
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
#line 1 "C:\Users\User\Desktop\gloyr5gen - Kopya\gloyr5gen\Views\_ViewImports.cshtml"
using gloyr5gen.Entity;

#line default
#line hidden
#line 2 "C:\Users\User\Desktop\gloyr5gen - Kopya\gloyr5gen\Views\_ViewImports.cshtml"
using gloyr5gen.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3ae3adbc8c5f305e654cccbafd534b42cacc055", @"/Views/Shared/Components/CategoryMenu/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c108f57dabd38a30e5d6bcacb22454745773bcc0", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_CategoryMenu_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CategoryModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Advertisement", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "List", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("block__16443 text-center d-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(35, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\User\Desktop\gloyr5gen - Kopya\gloyr5gen\Views\Shared\Components\CategoryMenu\Default.cshtml"
 foreach (var item in Model.Take(6))
{


#line default
#line hidden
            BeginContext(80, 56, true);
            WriteLiteral("<div class=\"col-6 col-md-6 col-lg-4 mb-4 mb-lg-5\">\r\n    ");
            EndContext();
            BeginContext(136, 494, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cedc3fd522bc4e4abc596457be4c5ae9", async() => {
                BeginContext(269, 49, true);
                WriteLiteral("\r\n        <span class=\"custom-icon mx-auto\"><span");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 318, "\"", 350, 3);
                WriteAttributeValue("", 326, "icon-", 326, 5, true);
#line 8 "C:\Users\User\Desktop\gloyr5gen - Kopya\gloyr5gen\Views\Shared\Components\CategoryMenu\Default.cshtml"
WriteAttributeValue("", 331, item.Image, 331, 11, false);

#line default
#line hidden
                WriteAttributeValue(" ", 342, "d-block", 343, 8, true);
                EndWriteAttribute();
                BeginContext(351, 107, true);
                WriteLiteral("></span></span>\r\n        <h3><font style=\"vertical-align: inherit;\"><font style=\"vertical-align: inherit;\">");
                EndContext();
                BeginContext(459, 17, false);
#line 9 "C:\Users\User\Desktop\gloyr5gen - Kopya\gloyr5gen\Views\Shared\Components\CategoryMenu\Default.cshtml"
                                                                                     Write(item.CategoryName);

#line default
#line hidden
                EndContext();
                BeginContext(476, 110, true);
                WriteLiteral("</font></font></h3>\r\n        <p><font style=\"vertical-align: inherit;\"><font style=\"vertical-align: inherit;\">");
                EndContext();
                BeginContext(587, 10, false);
#line 10 "C:\Users\User\Desktop\gloyr5gen - Kopya\gloyr5gen\Views\Shared\Components\CategoryMenu\Default.cshtml"
                                                                                    Write(item.Count);

#line default
#line hidden
                EndContext();
                BeginContext(597, 29, true);
                WriteLiteral(" ilan</font></font></p>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-category", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 7 "C:\Users\User\Desktop\gloyr5gen - Kopya\gloyr5gen\Views\Shared\Components\CategoryMenu\Default.cshtml"
                                                                WriteLiteral(item.CategoryName);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["category"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-category", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["category"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(630, 11, true);
            WriteLiteral("\r\n</div> \r\n");
            EndContext();
#line 13 "C:\Users\User\Desktop\gloyr5gen - Kopya\gloyr5gen\Views\Shared\Components\CategoryMenu\Default.cshtml"
}

#line default
#line hidden
            BeginContext(644, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CategoryModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
