#pragma checksum "C:\Users\User\Desktop\gloyr5gen - Kopya\gloyr5gen\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9375fd70e97a7eb44d6ead4bfdec4b4090bde72a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9375fd70e97a7eb44d6ead4bfdec4b4090bde72a", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c108f57dabd38a30e5d6bcacb22454745773bcc0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Advertisement>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Advertisement", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "List", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("text-decoration:none;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\User\Desktop\gloyr5gen - Kopya\gloyr5gen\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(76, 546, true);
            WriteLiteral(@"
<!-- HOME -->
<section class=""home-section section-hero overlay bg-image"" style=""background-image: url('/images/hero_11.jpg');"" id=""home-section"">

    <div class=""container"">
        <div class=""row align-items-center justify-content-center"">
            <div class=""col-md-12"">
                <div class=""mb-5 text-center"">
                    <h1 class=""text-white font-weight-bold"">Hemen İş Bul</h1>
                    <p>Hayalindeki İşe Bir Tık Uzaktasın. Ücretsiz İş Bulma Platformu.</p>
                </div>
               ");
            EndContext();
            BeginContext(623, 26, false);
#line 16 "C:\Users\User\Desktop\gloyr5gen - Kopya\gloyr5gen\Views\Home\Index.cshtml"
          Write(Html.Partial("_SearchBox"));

#line default
#line hidden
            EndContext();
            BeginContext(649, 597, true);
            WriteLiteral(@"
            </div>
        </div>
    </div>


</section>

<section class=""py-5 bg-image overlay-primary fixed overlay"" style=""background-image: url('/images/hero_11.jpg');"">
    <div class=""container"">
        <div class=""row mb-5 justify-content-center"">
            <div class=""col-md-7 text-center"">
                <h2 class=""section-title mb-2 text-white"">Öne Çıkan Şirketler</h2>
                <p class=""lead text-white"">Blue Paket</p>
            </div>
        </div>
        <div style=""background-color:white; padding:16px; -webkit-border-radius: 5px;"">
            ");
            EndContext();
            BeginContext(1247, 53, false);
#line 33 "C:\Users\User\Desktop\gloyr5gen - Kopya\gloyr5gen\Views\Home\Index.cshtml"
       Write(await Component.InvokeAsync("FeaturedAdvertisements"));

#line default
#line hidden
            EndContext();
            BeginContext(1300, 275, true);
            WriteLiteral(@"

        </div><br />
    </div>
</section>

<section class=""site-section"">
    <div class=""container"">

        <div class=""row mb-5 justify-content-center"">
            <div class=""col-md-7 text-center"">
                <h2 class=""section-title mb-2"">Öne Çıkan ");
            EndContext();
            BeginContext(1576, 13, false);
#line 44 "C:\Users\User\Desktop\gloyr5gen - Kopya\gloyr5gen\Views\Home\Index.cshtml"
                                                    Write(Model.Count());

#line default
#line hidden
            EndContext();
            BeginContext(1589, 152, true);
            WriteLiteral(" Adet İlan Bulundu.</h2>\r\n                <p class=\"lead text-black\">White Paket</p>\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"mb-5\">\r\n");
            EndContext();
#line 50 "C:\Users\User\Desktop\gloyr5gen - Kopya\gloyr5gen\Views\Home\Index.cshtml"
             foreach (var advertisement in Model)
            {
                

#line default
#line hidden
            BeginContext(1824, 49, false);
#line 52 "C:\Users\User\Desktop\gloyr5gen - Kopya\gloyr5gen\Views\Home\Index.cshtml"
           Write(Html.Partial("_AdvertisementItem", advertisement));

#line default
#line hidden
            EndContext();
#line 52 "C:\Users\User\Desktop\gloyr5gen - Kopya\gloyr5gen\Views\Home\Index.cshtml"
                                                                  
            }

#line default
#line hidden
            BeginContext(1890, 83, true);
            WriteLiteral("        </div>\r\n        <div class=\"row mb-5 justify-content-center\">\r\n            ");
            EndContext();
            BeginContext(1973, 213, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f6b6b53ae0d84bc7b12bde40d3e004dc", async() => {
                BeginContext(2055, 127, true);
                WriteLiteral("<button type=\"submit\" class=\"btn btn-primary btn-lg btn-block text-white btn-search\" style=\"width:250px;\">Daha Fazlası</button>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2186, 600, true);
            WriteLiteral(@"
        </div>
    </div>
</section>

<section class=""site-section services-section bg-light block__62849"" id=""next-section"">
    <div class=""col-md-12"">
        <div class=""mb-5 text-center"">
            <h2 class=""text-black font-weight-bold""><font style=""vertical-align: inherit;""><font style=""vertical-align: inherit;"">Popüler Meslekler</font></font></h2>
            <p><font style=""vertical-align: inherit;""><font style=""vertical-align: inherit;"">En Çok Arananlar...</font></font></p>
        </div>
    </div>
    <div class=""container"">
        <div class=""row"">

            ");
            EndContext();
            BeginContext(2787, 43, false);
#line 71 "C:\Users\User\Desktop\gloyr5gen - Kopya\gloyr5gen\Views\Home\Index.cshtml"
       Write(await Component.InvokeAsync("CategoryMenu"));

#line default
#line hidden
            EndContext();
            BeginContext(2830, 42, true);
            WriteLiteral("\r\n\r\n        </div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Advertisement>> Html { get; private set; }
    }
}
#pragma warning restore 1591
