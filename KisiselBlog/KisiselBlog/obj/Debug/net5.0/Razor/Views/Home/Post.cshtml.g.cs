#pragma checksum "C:\Users\90553\Desktop\KisiselBlog\KisiselBlog\Views\Home\Post.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4323dfc1d1fa344777c01a61f389df177a3b7f8d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Post), @"mvc.1.0.view", @"/Views/Home/Post.cshtml")]
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
#line 1 "C:\Users\90553\Desktop\KisiselBlog\KisiselBlog\Views\_ViewImports.cshtml"
using KisiselBlog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\90553\Desktop\KisiselBlog\KisiselBlog\Views\_ViewImports.cshtml"
using KisiselBlog.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4323dfc1d1fa344777c01a61f389df177a3b7f8d", @"/Views/Home/Post.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59e44facd34fc26581da87c2067e0d6074402084", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Post : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<KisiselBlog.Models.Blog>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\90553\Desktop\KisiselBlog\KisiselBlog\Views\Home\Post.cshtml"
  
    ViewData["Title"] = "Post";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<header class=\"masthead\"");
            BeginWriteAttribute("style", " style=\"", 98, "\"", 146, 5);
            WriteAttributeValue("", 106, "background-image:", 106, 17, true);
            WriteAttributeValue(" ", 123, "url(", 124, 5, true);
#nullable restore
#line 6 "C:\Users\90553\Desktop\KisiselBlog\KisiselBlog\Views\Home\Post.cshtml"
WriteAttributeValue("", 128, Model.ImagePath, 128, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 144, ")", 144, 1, true);
            WriteAttributeValue(" ", 145, "", 146, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">
    <div class=""container position-relative px-4 px-lg-5"">
        <div class=""row gx-4 gx-lg-5 justify-content-center"">
            <div class=""col-md-10 col-lg-8 col-xl-7"">
                <div class=""site-heading"">
                    <h1>Süper Psikoloji</h1>
                    <span class=""subheading"">Sınırların Kadar Özgürsün</span>
                </div>
            </div>
        </div>
    </div>
</header>

<div class=""container"">
    <header class=""masthead""");
            BeginWriteAttribute("style", " style=\"", 635, "\"", 684, 4);
            WriteAttributeValue("", 643, "background-image:", 643, 17, true);
            WriteAttributeValue(" ", 660, "url(\'", 661, 6, true);
#nullable restore
#line 20 "C:\Users\90553\Desktop\KisiselBlog\KisiselBlog\Views\Home\Post.cshtml"
WriteAttributeValue("", 666, Model.ImagePath, 666, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 682, "\')", 682, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n        <div class=\"overlay\"></div>\r\n        <div class=\"container\">\r\n            <div class=\"row\">\r\n                <div class=\"col-lg-8 col-md-10 mx-auto\">\r\n                    <div class=\"post-heading\">\r\n                        <h1>");
#nullable restore
#line 26 "C:\Users\90553\Desktop\KisiselBlog\KisiselBlog\Views\Home\Post.cshtml"
                       Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                        <h2 class=\"subheading\">");
#nullable restore
#line 27 "C:\Users\90553\Desktop\KisiselBlog\KisiselBlog\Views\Home\Post.cshtml"
                                          Write(Model.Subtitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                        <span class=\"meta\">\r\n                            Posted by\r\n                            ");
#nullable restore
#line 30 "C:\Users\90553\Desktop\KisiselBlog\KisiselBlog\Views\Home\Post.cshtml"
                       Write(Model.Yazar.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </span>
                    </div>
                </div>
            </div>
        </div>
    </header>
    <div class=""container"">
        <!-- Post Content -->
        <article>
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-lg-8 col-md-10 mx-auto"">
                        ");
#nullable restore
#line 43 "C:\Users\90553\Desktop\KisiselBlog\KisiselBlog\Views\Home\Post.cshtml"
                   Write(Html.Raw(Model.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </article>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<KisiselBlog.Models.Blog> Html { get; private set; }
    }
}
#pragma warning restore 1591
