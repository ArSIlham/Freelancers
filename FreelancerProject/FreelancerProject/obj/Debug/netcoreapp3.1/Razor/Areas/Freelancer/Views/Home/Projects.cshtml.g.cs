#pragma checksum "C:\Users\99450\Desktop\Freelancers\FreelancerProject\FreelancerProject\Areas\Freelancer\Views\Home\Projects.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c147d6b60a2d943181bcfae0baafbb8ddff61945"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Freelancer_Views_Home_Projects), @"mvc.1.0.view", @"/Areas/Freelancer/Views/Home/Projects.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c147d6b60a2d943181bcfae0baafbb8ddff61945", @"/Areas/Freelancer/Views/Home/Projects.cshtml")]
    public class Areas_Freelancer_Views_Home_Projects : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<FreelancersProject.Domain.Concretes.Project>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/StyleSheet.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\99450\Desktop\Freelancers\FreelancerProject\FreelancerProject\Areas\Freelancer\Views\Home\Projects.cshtml"
  
    ViewData["Title"] = "Projects";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Projects</h1>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c147d6b60a2d943181bcfae0baafbb8ddff619453732", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<div style=\" margin: 0px 300px 0px 350px;\">\r\n\r\n");
#nullable restore
#line 12 "C:\Users\99450\Desktop\Freelancers\FreelancerProject\FreelancerProject\Areas\Freelancer\Views\Home\Projects.cshtml"
     foreach (var item in Model)
    {
        

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card Hoverr\" >\r\n            <div class=\"card-header\">\r\n                <p>");
#nullable restore
#line 17 "C:\Users\99450\Desktop\Freelancers\FreelancerProject\FreelancerProject\Areas\Freelancer\Views\Home\Projects.cshtml"
              Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n            <div class=\"card-body\">\r\n                <h5 class=\"card-title\">");
#nullable restore
#line 20 "C:\Users\99450\Desktop\Freelancers\FreelancerProject\FreelancerProject\Areas\Freelancer\Views\Home\Projects.cshtml"
                                  Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <p class=\"card-text\">");
#nullable restore
#line 21 "C:\Users\99450\Desktop\Freelancers\FreelancerProject\FreelancerProject\Areas\Freelancer\Views\Home\Projects.cshtml"
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
                <a href=""#"" class=""btn btn-primary"">Go somewhere</a>
            </div>
        </div>
");
#nullable restore
#line 31 "C:\Users\99450\Desktop\Freelancers\FreelancerProject\FreelancerProject\Areas\Freelancer\Views\Home\Projects.cshtml"
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
