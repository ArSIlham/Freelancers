#pragma checksum "C:\CFreel\FreelancerProject\FreelancerProject\Areas\Hirer\Views\Project\MyProjectss.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f6674a8e461fa7d331bde6244d591896d34a0fc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Hirer_Views_Project_MyProjectss), @"mvc.1.0.view", @"/Areas/Hirer/Views/Project/MyProjectss.cshtml")]
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
#line 1 "C:\CFreel\FreelancerProject\FreelancerProject\Areas\Hirer\Views\_ViewImports.cshtml"
using FreelancersProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\CFreel\FreelancerProject\FreelancerProject\Areas\Hirer\Views\_ViewImports.cshtml"
using FreelancersProject.Application.Handler.CQRS.Commands.LoginCommands;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\CFreel\FreelancerProject\FreelancerProject\Areas\Hirer\Views\_ViewImports.cshtml"
using FreelancersProject.Application.Handler.CQRS.Commands.ProjectCommands;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\CFreel\FreelancerProject\FreelancerProject\Areas\Hirer\Views\_ViewImports.cshtml"
using FreelancersProject.Domain.Concretes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\CFreel\FreelancerProject\FreelancerProject\Areas\Hirer\Views\_ViewImports.cshtml"
using FreelancersProject.Application.DTOs;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f6674a8e461fa7d331bde6244d591896d34a0fc", @"/Areas/Hirer/Views/Project/MyProjectss.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fe388bcf2179414f0cb68f794e1bf118dd18f24", @"/Areas/Hirer/Views/_ViewImports.cshtml")]
    public class Areas_Hirer_Views_Project_MyProjectss : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProjectDTO>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ProjectDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Hirer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Project", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\CFreel\FreelancerProject\FreelancerProject\Areas\Hirer\Views\Project\MyProjectss.cshtml"
  
	ViewData["Title"] = "MyProjects";
	Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"d-flex align-items-center p-3 my-3 bg-purple rounded box-shadow\">\r\n\r\n\t<div class=\"lh-100 text-center \">\r\n\r\n\t</div>\r\n</div>\r\n<div class=\"my-3 p-3 bg-white rounded box-shadow\">\r\n\r\n\r\n\r\n");
#nullable restore
#line 17 "C:\CFreel\FreelancerProject\FreelancerProject\Areas\Hirer\Views\Project\MyProjectss.cshtml"
     foreach (var item in Model)
	{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t<div class=\"row\">\r\n\t\t\t<div class=\"col-sm-2 pb-1 mb-0 pt-1 border-bottom border-gray text-center\">\r\n\t\t\t\t<p class=\"font-weight-bold small mb-3 \">\r\n\r\n\t\t\t\t\tCreate Date:\r\n\t\t\t\t\t<strong class=\"d-block text-dark small\">\r\n\r\n\t\t\t\t\t\t");
#nullable restore
#line 26 "C:\CFreel\FreelancerProject\FreelancerProject\Areas\Hirer\Views\Project\MyProjectss.cshtml"
                   Write(item.Project.CreateDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t</strong>\r\n\t\t\t\t</p>\r\n\t\t\t</div>\r\n\r\n\t\t\t<div class=\"col-sm-2 pb-1 mb-0 pt-1 border-bottom border-gray\">\r\n\t\t\t\t<p class=\"font-weight-bold small mb-3 \">");
#nullable restore
#line 32 "C:\CFreel\FreelancerProject\FreelancerProject\Areas\Hirer\Views\Project\MyProjectss.cshtml"
                                                   Write(item.Project.MinPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 32 "C:\CFreel\FreelancerProject\FreelancerProject\Areas\Hirer\Views\Project\MyProjectss.cshtml"
                                                                            Write(item.Project.MaxPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" $USD</p>\r\n");
#nullable restore
#line 33 "C:\CFreel\FreelancerProject\FreelancerProject\Areas\Hirer\Views\Project\MyProjectss.cshtml"
                 if (item.Project.Status == Statuses.Pending.ToString())
				{


#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t<span class=\"badge badge-warning\">");
#nullable restore
#line 36 "C:\CFreel\FreelancerProject\FreelancerProject\Areas\Hirer\Views\Project\MyProjectss.cshtml"
                                                 Write(item.Project.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 37 "C:\CFreel\FreelancerProject\FreelancerProject\Areas\Hirer\Views\Project\MyProjectss.cshtml"
				}

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\CFreel\FreelancerProject\FreelancerProject\Areas\Hirer\Views\Project\MyProjectss.cshtml"
                 if (item.Project.Status == Statuses.Waiting.ToString())
				{


#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t<span class=\"badge badge-danger\">");
#nullable restore
#line 41 "C:\CFreel\FreelancerProject\FreelancerProject\Areas\Hirer\Views\Project\MyProjectss.cshtml"
                                                Write(item.Project.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 42 "C:\CFreel\FreelancerProject\FreelancerProject\Areas\Hirer\Views\Project\MyProjectss.cshtml"
				}

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\CFreel\FreelancerProject\FreelancerProject\Areas\Hirer\Views\Project\MyProjectss.cshtml"
                 if (item.Project.Status == Statuses.Completed.ToString())
				{


#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t<span class=\"badge badge-success\">");
#nullable restore
#line 46 "C:\CFreel\FreelancerProject\FreelancerProject\Areas\Hirer\Views\Project\MyProjectss.cshtml"
                                                 Write(item.Project.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 47 "C:\CFreel\FreelancerProject\FreelancerProject\Areas\Hirer\Views\Project\MyProjectss.cshtml"
				}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t</div>\r\n\t\t\t<div class=\"col-sm-8  pb-1 mb-0 pt-1 border-bottom border-gray\">\r\n\t\t\t\t<div class=\"media text-muted \">\r\n\r\n\t\t\t\t\t<p class=\"media-body  small  \">\r\n\t\t\t\t\t\t<strong class=\"d-block text-dark\">\r\n\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4f6674a8e461fa7d331bde6244d591896d34a0fc9581", async() => {
#nullable restore
#line 55 "C:\CFreel\FreelancerProject\FreelancerProject\Areas\Hirer\Views\Project\MyProjectss.cshtml"
                                                                                                                                      Write(item.Project.Title);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-projectI", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 55 "C:\CFreel\FreelancerProject\FreelancerProject\Areas\Hirer\Views\Project\MyProjectss.cshtml"
                                                                                                             WriteLiteral(item.Project.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["projectI"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-projectI", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["projectI"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t</strong>\r\n\r\n");
#nullable restore
#line 58 "C:\CFreel\FreelancerProject\FreelancerProject\Areas\Hirer\Views\Project\MyProjectss.cshtml"
                         if (item.Project.Description.Length > 100)

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "C:\CFreel\FreelancerProject\FreelancerProject\Areas\Hirer\Views\Project\MyProjectss.cshtml"
                                                              Write(item.Project.Description.Substring(0, 100));

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "C:\CFreel\FreelancerProject\FreelancerProject\Areas\Hirer\Views\Project\MyProjectss.cshtml"
                                                                                                              
						else 

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "C:\CFreel\FreelancerProject\FreelancerProject\Areas\Hirer\Views\Project\MyProjectss.cshtml"
                        Write(item.Project.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t<strong class=\"d-block\"> Skills:\r\n");
#nullable restore
#line 62 "C:\CFreel\FreelancerProject\FreelancerProject\Areas\Hirer\Views\Project\MyProjectss.cshtml"
                             foreach (var skill in item.ProjectSkills)
							{
								

#line default
#line hidden
#nullable disable
#nullable restore
#line 64 "C:\CFreel\FreelancerProject\FreelancerProject\Areas\Hirer\Views\Project\MyProjectss.cshtml"
                           Write(skill.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>  </span>\r\n");
#nullable restore
#line 65 "C:\CFreel\FreelancerProject\FreelancerProject\Areas\Hirer\Views\Project\MyProjectss.cshtml"
							}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t</strong>\r\n\t\t\t\t\t</p>\r\n\t\t\t\t\t<br />\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n");
#nullable restore
#line 72 "C:\CFreel\FreelancerProject\FreelancerProject\Areas\Hirer\Views\Project\MyProjectss.cshtml"
	}

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProjectDTO>> Html { get; private set; }
    }
}
#pragma warning restore 1591
