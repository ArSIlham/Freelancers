#pragma checksum "C:\Users\99450\Desktop\Freelancers - Copy\FreelancerProject\FreelancerProject\Areas\Freelancer\Views\Project\MyProjects.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4caf4cf478be1d42238bf46df036d2d40d1ce1a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Freelancer_Views_Project_MyProjects), @"mvc.1.0.view", @"/Areas/Freelancer/Views/Project/MyProjects.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4caf4cf478be1d42238bf46df036d2d40d1ce1a6", @"/Areas/Freelancer/Views/Project/MyProjects.cshtml")]
    public class Areas_Freelancer_Views_Project_MyProjects : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<FreelancersProject.Domain.Concretes.Project>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\99450\Desktop\Freelancers - Copy\FreelancerProject\FreelancerProject\Areas\Freelancer\Views\Project\MyProjects.cshtml"
  
    ViewData["Title"] = "MyProjects";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>MyProjects</h1>\r\n\r\n\r\n<div style=\" margin: 0px 300px 0px 350px;\">\r\n\r\n");
#nullable restore
#line 12 "C:\Users\99450\Desktop\Freelancers - Copy\FreelancerProject\FreelancerProject\Areas\Freelancer\Views\Project\MyProjects.cshtml"
     foreach (var item in Model)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card Hoverr\">\r\n            <div class=\"card-header\">\r\n                <p>");
#nullable restore
#line 17 "C:\Users\99450\Desktop\Freelancers - Copy\FreelancerProject\FreelancerProject\Areas\Freelancer\Views\Project\MyProjects.cshtml"
              Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n            <div class=\"card-body\">\r\n                <h5 class=\"card-title\">");
#nullable restore
#line 20 "C:\Users\99450\Desktop\Freelancers - Copy\FreelancerProject\FreelancerProject\Areas\Freelancer\Views\Project\MyProjects.cshtml"
                                  Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <p class=\"card-text\">");
#nullable restore
#line 21 "C:\Users\99450\Desktop\Freelancers - Copy\FreelancerProject\FreelancerProject\Areas\Freelancer\Views\Project\MyProjects.cshtml"
                                Write(item.OwnerId);

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
                <a");
            BeginWriteAttribute("href", " href=\"", 964, "\"", 989, 2);
            WriteAttributeValue("", 971, "detail?ID=", 971, 10, true);
#nullable restore
#line 28 "C:\Users\99450\Desktop\Freelancers - Copy\FreelancerProject\FreelancerProject\Areas\Freelancer\Views\Project\MyProjects.cshtml"
WriteAttributeValue("", 981, item.Id, 981, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Go somewhere</a>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 31 "C:\Users\99450\Desktop\Freelancers - Copy\FreelancerProject\FreelancerProject\Areas\Freelancer\Views\Project\MyProjects.cshtml"
    }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<FreelancersProject.Domain.Concretes.Project>> Html { get; private set; }
    }
}
#pragma warning restore 1591
