<<<<<<< HEAD
#pragma checksum "C:\Users\99450\Desktop\Freelancers\FreelancerProject\FreelancerProject\Areas\Freelancer\Views\Project\MyProjects.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b9f75e0166922d326b8b3b8f373a44586cda836"
=======
#pragma checksum "C:\freelancer\FreelancerProject\FreelancerProject\Areas\Freelancer\Views\Project\MyProjects.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4caf4cf478be1d42238bf46df036d2d40d1ce1a6"
>>>>>>> 0096745938172902581ce1fb2db754463ee60938
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
<<<<<<< HEAD
#line 2 "C:\Users\99450\Desktop\Freelancers\FreelancerProject\FreelancerProject\Areas\Freelancer\Views\Project\MyProjects.cshtml"
=======
#line 2 "C:\freelancer\FreelancerProject\FreelancerProject\Areas\Freelancer\Views\Project\MyProjects.cshtml"
>>>>>>> 0096745938172902581ce1fb2db754463ee60938
  
    ViewData["Title"] = "MyProjects";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>MyProjects</h1>\r\n\r\n\r\n<div style=\" margin: 0px 300px 0px 350px;\">\r\n\r\n");
#nullable restore
<<<<<<< HEAD
#line 22 "C:\Users\99450\Desktop\Freelancers\FreelancerProject\FreelancerProject\Areas\Freelancer\Views\Project\MyProjects.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""row"">
            <div class=""col-sm-2 pb-1 mb-0 pt-1 border-bottom border-gray text-center"">
                <p class=""font-weight-bold small mb-3 "">

                    Create Date:
                    <strong class=""d-block text-dark small"">

                        ");
#nullable restore
#line 31 "C:\Users\99450\Desktop\Freelancers\FreelancerProject\FreelancerProject\Areas\Freelancer\Views\Project\MyProjects.cshtml"
                   Write(item.Project.CreateDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </strong>\r\n                </p>\r\n            </div>\r\n\r\n            <div class=\"col-sm-2 pb-1 mb-0 pt-1 border-bottom border-gray\">\r\n                <p class=\"font-weight-bold small mb-3 \">");
#nullable restore
#line 37 "C:\Users\99450\Desktop\Freelancers\FreelancerProject\FreelancerProject\Areas\Freelancer\Views\Project\MyProjects.cshtml"
                                                   Write(item.Project.MinPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 37 "C:\Users\99450\Desktop\Freelancers\FreelancerProject\FreelancerProject\Areas\Freelancer\Views\Project\MyProjects.cshtml"
                                                                            Write(item.Project.MaxPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" $USD</p>\r\n");
#nullable restore
#line 38 "C:\Users\99450\Desktop\Freelancers\FreelancerProject\FreelancerProject\Areas\Freelancer\Views\Project\MyProjects.cshtml"
                 if (item.Project.Status == FreelancersProject.Domain.Concretes.Statuses.Pending.ToString())
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span class=\"badge badge-warning\">");
#nullable restore
#line 41 "C:\Users\99450\Desktop\Freelancers\FreelancerProject\FreelancerProject\Areas\Freelancer\Views\Project\MyProjects.cshtml"
                                                 Write(item.Project.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 42 "C:\Users\99450\Desktop\Freelancers\FreelancerProject\FreelancerProject\Areas\Freelancer\Views\Project\MyProjects.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\99450\Desktop\Freelancers\FreelancerProject\FreelancerProject\Areas\Freelancer\Views\Project\MyProjects.cshtml"
                 if (item.Project.Status == FreelancersProject.Domain.Concretes.Statuses.Waiting.ToString())
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span class=\"badge badge-danger\">");
#nullable restore
#line 46 "C:\Users\99450\Desktop\Freelancers\FreelancerProject\FreelancerProject\Areas\Freelancer\Views\Project\MyProjects.cshtml"
                                                Write(item.Project.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 47 "C:\Users\99450\Desktop\Freelancers\FreelancerProject\FreelancerProject\Areas\Freelancer\Views\Project\MyProjects.cshtml"
                }
=======
#line 12 "C:\freelancer\FreelancerProject\FreelancerProject\Areas\Freelancer\Views\Project\MyProjects.cshtml"
     foreach (var item in Model)
    {

>>>>>>> 0096745938172902581ce1fb2db754463ee60938

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card Hoverr\">\r\n            <div class=\"card-header\">\r\n                <p>");
#nullable restore
<<<<<<< HEAD
#line 48 "C:\Users\99450\Desktop\Freelancers\FreelancerProject\FreelancerProject\Areas\Freelancer\Views\Project\MyProjects.cshtml"
                 if (item.Project.Status == FreelancersProject.Domain.Concretes.Statuses.Completed.ToString())
                {

=======
#line 17 "C:\freelancer\FreelancerProject\FreelancerProject\Areas\Freelancer\Views\Project\MyProjects.cshtml"
              Write(item.Title);
>>>>>>> 0096745938172902581ce1fb2db754463ee60938

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n            <div class=\"card-body\">\r\n                <h5 class=\"card-title\">");
#nullable restore
<<<<<<< HEAD
#line 51 "C:\Users\99450\Desktop\Freelancers\FreelancerProject\FreelancerProject\Areas\Freelancer\Views\Project\MyProjects.cshtml"
                                                 Write(item.Project.Status);
=======
#line 20 "C:\freelancer\FreelancerProject\FreelancerProject\Areas\Freelancer\Views\Project\MyProjects.cshtml"
                                  Write(item.Description);
>>>>>>> 0096745938172902581ce1fb2db754463ee60938

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <p class=\"card-text\">");
#nullable restore
<<<<<<< HEAD
#line 52 "C:\Users\99450\Desktop\Freelancers\FreelancerProject\FreelancerProject\Areas\Freelancer\Views\Project\MyProjects.cshtml"
                }
=======
#line 21 "C:\freelancer\FreelancerProject\FreelancerProject\Areas\Freelancer\Views\Project\MyProjects.cshtml"
                                Write(item.OwnerId);
>>>>>>> 0096745938172902581ce1fb2db754463ee60938

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
<<<<<<< HEAD
#line 60 "C:\Users\99450\Desktop\Freelancers\FreelancerProject\FreelancerProject\Areas\Freelancer\Views\Project\MyProjects.cshtml"
WriteAttributeValue("", 2146, item.Project.Id, 2146, 16, false);
=======
#line 28 "C:\freelancer\FreelancerProject\FreelancerProject\Areas\Freelancer\Views\Project\MyProjects.cshtml"
WriteAttributeValue("", 981, item.Id, 981, 8, false);
>>>>>>> 0096745938172902581ce1fb2db754463ee60938

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
<<<<<<< HEAD
            WriteLiteral(">");
#nullable restore
#line 60 "C:\Users\99450\Desktop\Freelancers\FreelancerProject\FreelancerProject\Areas\Freelancer\Views\Project\MyProjects.cshtml"
                                                                                                                                      Write(item.Project.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        </strong>\r\n\r\n");
#nullable restore
#line 63 "C:\Users\99450\Desktop\Freelancers\FreelancerProject\FreelancerProject\Areas\Freelancer\Views\Project\MyProjects.cshtml"
                         if (item.Project.Description.Length > 100)

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "C:\Users\99450\Desktop\Freelancers\FreelancerProject\FreelancerProject\Areas\Freelancer\Views\Project\MyProjects.cshtml"
                                                              Write(item.Project.Description.Substring(0, 100));

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "C:\Users\99450\Desktop\Freelancers\FreelancerProject\FreelancerProject\Areas\Freelancer\Views\Project\MyProjects.cshtml"
                                                                                                              
                        else 

#line default
#line hidden
#nullable disable
#nullable restore
#line 64 "C:\Users\99450\Desktop\Freelancers\FreelancerProject\FreelancerProject\Areas\Freelancer\Views\Project\MyProjects.cshtml"
                        Write(item.Project.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <strong class=\"d-block\">\r\n                            Skills:\r\n");
#nullable restore
#line 68 "C:\Users\99450\Desktop\Freelancers\FreelancerProject\FreelancerProject\Areas\Freelancer\Views\Project\MyProjects.cshtml"
                             foreach (var skill in item.ProjectSkills)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 70 "C:\Users\99450\Desktop\Freelancers\FreelancerProject\FreelancerProject\Areas\Freelancer\Views\Project\MyProjects.cshtml"
                           Write(skill.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>  </span>\r\n");
#nullable restore
#line 71 "C:\Users\99450\Desktop\Freelancers\FreelancerProject\FreelancerProject\Areas\Freelancer\Views\Project\MyProjects.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </strong>\r\n                    </p>\r\n                    <br />\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 78 "C:\Users\99450\Desktop\Freelancers\FreelancerProject\FreelancerProject\Areas\Freelancer\Views\Project\MyProjects.cshtml"
=======
            WriteLiteral(" class=\"btn btn-primary\">Go somewhere</a>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 31 "C:\freelancer\FreelancerProject\FreelancerProject\Areas\Freelancer\Views\Project\MyProjects.cshtml"
>>>>>>> 0096745938172902581ce1fb2db754463ee60938
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
