#pragma checksum "C:\Users\Isabella\source\Repos\SiteCompleto\SiteCompleto\SiteCompleto\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0459ea10380f38383ae06b4b53861a936c251158"
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
#line 1 "C:\Users\Isabella\source\Repos\SiteCompleto\SiteCompleto\SiteCompleto\Views\_ViewImports.cshtml"
using SiteCompleto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Isabella\source\Repos\SiteCompleto\SiteCompleto\SiteCompleto\Views\_ViewImports.cshtml"
using SiteCompleto.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0459ea10380f38383ae06b4b53861a936c251158", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d142c12bec0a7381d97ed31965b7b2896637c8d", @"/Views/_ViewImports.cshtml")]
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Isabella\source\Repos\SiteCompleto\SiteCompleto\SiteCompleto\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0459ea10380f38383ae06b4b53861a936c2511583348", async() => {
                WriteLiteral(@"
    <!--ESPAÇO PARA O SLIDE-->
    <div class=""slider"">
        <div class=""load""></div>
        <div class=content>
            <div class=""principal""></div>
        </div>
    </div>

    <!--FIM DO SLIDE -->
    <!--Carrossel de Imagens-->
    <section class=""image-section"">
        <div class=""swiper"">
            <div class=""swiper-wrapper"">
                <div class=""swiper-slide swiper-slide--one"">
                    <span>AÇÃO</span>
                    <div>
                        <h2>Jujutsu Kaisen</h2>
                    </div>
                </div>
                <div class=""swiper-slide swiper-slide--two"">
                    <span>AVENTURA</span>
                    <div>
                        <h2>One Piece</h2>
                    </div>
                </div>

                <div class=""swiper-slide swiper-slide--three"">
                    <span>FANTASIA</span>
                    <div>
                        <h2>Demon Slayer</h2>
                    ");
                WriteLiteral(@"</div>
                </div>

                <div class=""swiper-slide swiper-slide--four"">
                    <span>AVENTURA</span>
                    <div>
                        <h2>Naruto Shippuden</h2>
                    </div>
                </div>

                <div class=""swiper-slide swiper-slide--five"">
                    <span>ROMANCE</span>
                    <div>
                        <h2>Kimi No Na Wa</h2>
                    </div>
                </div>
            </div>
            <!-- Add Pagination -->
            <div class=""swiper-pagination""></div>
        </div>
    </section>
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
            WriteLiteral("\r\n\r\n<!-- Fim Carrossel de Imagens-->");
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
