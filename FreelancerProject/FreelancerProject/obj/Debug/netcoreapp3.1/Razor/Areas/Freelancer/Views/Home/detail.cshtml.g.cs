#pragma checksum "C:\Users\99450\Desktop\FreelancersM\FreelancerProject\FreelancerProject\Areas\Freelancer\Views\Home\detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fbee75785bacc617bca41b4092c485ef374c240b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Freelancer_Views_Home_detail), @"mvc.1.0.view", @"/Areas/Freelancer/Views/Home/detail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fbee75785bacc617bca41b4092c485ef374c240b", @"/Areas/Freelancer/Views/Home/detail.cshtml")]
    public class Areas_Freelancer_Views_Home_detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FreelancersProject.Domain.Concretes.Project>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\99450\Desktop\FreelancersM\FreelancerProject\FreelancerProject\Areas\Freelancer\Views\Home\detail.cshtml"
  
    ViewData["Title"] = "detail";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>detail</h1>\r\n\r\n<div class=\"card Hoverr\">\r\n    <div class=\"card-header\">\r\n        <p>");
#nullable restore
#line 12 "C:\Users\99450\Desktop\FreelancersM\FreelancerProject\FreelancerProject\Areas\Freelancer\Views\Home\detail.cshtml"
      Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n    <div class=\"card-body\">\r\n        <h5 class=\"card-title\">");
#nullable restore
#line 15 "C:\Users\99450\Desktop\FreelancersM\FreelancerProject\FreelancerProject\Areas\Freelancer\Views\Home\detail.cshtml"
                          Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n        <p class=\"card-text\">");
#nullable restore
#line 16 "C:\Users\99450\Desktop\FreelancersM\FreelancerProject\FreelancerProject\Areas\Freelancer\Views\Home\detail.cshtml"
                        Write(Model.OwnerId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
        <p class=""card-text"" style="" margin: 0px 0px 0px 10px;"">
        <p class=""card-text"">
            <a class=""Atag border border-primary"" href=""#"">C# Asp.Net Core </a>
            <a class=""Atag border border-primary"" href=""#"">Web Desing </a>
            <a class=""Atag border border-primary"" href=""#"">JavaScript </a>
        </p>
        <a href=""detail"" class=""btn btn-primary"">Go somewhere</a>
    </div>
</div>
       ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FreelancersProject.Domain.Concretes.Project> Html { get; private set; }
    }
}
#pragma warning restore 1591
