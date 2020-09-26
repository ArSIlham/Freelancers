#pragma checksum "C:\freelancer\FreelancerProject\FreelancerProject\Areas\Freelancer\Views\Home\detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c9e2677be95d44fddcc530b1e99bad2666d72f13"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9e2677be95d44fddcc530b1e99bad2666d72f13", @"/Areas/Freelancer/Views/Home/detail.cshtml")]
    public class Areas_Freelancer_Views_Home_detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FreelancersProject.Application.DTOs.ProjectBidRequestDTO>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Comment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:400px; margin: 0 auto;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\freelancer\FreelancerProject\FreelancerProject\Areas\Freelancer\Views\Home\detail.cshtml"
  
    ViewData["Title"] = "detail";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>detail</h1>\r\n\r\n\r\n<div class=\"my-3 p-3 bg-white rounded box-shadow\">\r\n    <div class=\"card\">\r\n        <div class=\"card-body\">\r\n            <h5 class=\"card-title\">");
#nullable restore
#line 15 "C:\freelancer\FreelancerProject\FreelancerProject\Areas\Freelancer\Views\Home\detail.cshtml"
                              Write(Model.Project.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            <p class=\"card-text\">");
#nullable restore
#line 16 "C:\freelancer\FreelancerProject\FreelancerProject\Areas\Freelancer\Views\Home\detail.cshtml"
                            Write(Model.Project.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p class=\"card-text\">Price:");
#nullable restore
#line 17 "C:\freelancer\FreelancerProject\FreelancerProject\Areas\Freelancer\Views\Home\detail.cshtml"
                                  Write(Model.Project.MinPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" -");
#nullable restore
#line 17 "C:\freelancer\FreelancerProject\FreelancerProject\Areas\Freelancer\Views\Home\detail.cshtml"
                                                           Write(Model.Project.MaxPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" $USD</p>\r\n            <p class=\"card-text \"><small class=\"text-muted\">Status :");
#nullable restore
#line 18 "C:\freelancer\FreelancerProject\FreelancerProject\Areas\Freelancer\Views\Home\detail.cshtml"
                                                               Write(Model.Project.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small></p>\r\n            <p class=\"card-text\"><small class=\"text-muted\">Created Date :");
#nullable restore
#line 19 "C:\freelancer\FreelancerProject\FreelancerProject\Areas\Freelancer\Views\Home\detail.cshtml"
                                                                    Write(Model.Project.CreateDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</small></p>
        </div>

    </div>

    <div class=""card-body"">
        <div class=""table-responsive"" id=""proTeamScroll"" tabindex=""2"" style=""height: 400px; overflow: hidden; outline: none;"">
            <table class=""table table-striped"">
                <thead>
                    <tr>
                        <th>User</th>
                        <th>Freelancer Info</th>
                        <th>Price</th>
                        <th>Date</th>
                        <th>Status</th>
                        <th>Action</th>

                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 39 "C:\freelancer\FreelancerProject\FreelancerProject\Areas\Freelancer\Views\Home\detail.cshtml"
                     foreach (var item in Model.BidRequests)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 42 "C:\freelancer\FreelancerProject\FreelancerProject\Areas\Freelancer\Views\Home\detail.cshtml"
                           Write(item.FreeLancer.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 42 "C:\freelancer\FreelancerProject\FreelancerProject\Areas\Freelancer\Views\Home\detail.cshtml"
                                                 Write(item.FreeLancer.SurName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 43 "C:\freelancer\FreelancerProject\FreelancerProject\Areas\Freelancer\Views\Home\detail.cshtml"
                           Write(item.BidRequest.Comment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 44 "C:\freelancer\FreelancerProject\FreelancerProject\Areas\Freelancer\Views\Home\detail.cshtml"
                           Write(item.BidRequest.BidPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 45 "C:\freelancer\FreelancerProject\FreelancerProject\Areas\Freelancer\Views\Home\detail.cshtml"
                           Write(item.BidRequest.CreateDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 46 "C:\freelancer\FreelancerProject\FreelancerProject\Areas\Freelancer\Views\Home\detail.cshtml"
                             if (item.BidRequest.IsConfirmed)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td><span class=\"text-success\">Confirmed</span></td>\r\n                                <td></td>\r\n");
#nullable restore
#line 50 "C:\freelancer\FreelancerProject\FreelancerProject\Areas\Freelancer\Views\Home\detail.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td><span class=\"text-danger\">Waiting for action</span></td>\r\n                                <td>\r\n                                    <a href=\"#\" class=\"badge badge-success\" data-toggle=\"modal\" data-target=\"#confrimModal\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2368, "\"", 2411, 3);
            WriteAttributeValue("", 2378, "ConfirmBid(\'", 2378, 12, true);
#nullable restore
#line 55 "C:\freelancer\FreelancerProject\FreelancerProject\Areas\Freelancer\Views\Home\detail.cshtml"
WriteAttributeValue("", 2390, item.BidRequest.Id, 2390, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2409, "\')", 2409, 2, true);
            EndWriteAttribute();
            WriteLiteral(">Confirm</a>\r\n                                </td>\r\n");
#nullable restore
#line 57 "C:\freelancer\FreelancerProject\FreelancerProject\Areas\Freelancer\Views\Home\detail.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tr>\r\n");
#nullable restore
#line 59 "C:\freelancer\FreelancerProject\FreelancerProject\Areas\Freelancer\Views\Home\detail.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n<div class=\"container\">\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9e2677be95d44fddcc530b1e99bad2666d72f1311592", async() => {
                WriteLiteral(@"

        <div class=""form-group required-field-block"">
            <span class=""input-group-addon""><span class=""glyphicon glyphicon-user"">Amount</span></span>
            <div class=""col-md-12 input-group"">
                <input hidden=""hidden"" name=""project.Project.Id"" id=""project.Project.Id""");
                BeginWriteAttribute("value", " value=\"", 3090, "\"", 3115, 1);
#nullable restore
#line 78 "C:\freelancer\FreelancerProject\FreelancerProject\Areas\Freelancer\Views\Home\detail.cshtml"
WriteAttributeValue("", 3098, Model.Project.Id, 3098, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                <input type=""text"" size=""30""  name=""project.bidrequests.BidPrice"" id=""BidPrice"" class=""form-control"" placeholder=""e.g Min Price"">
                <div class=""required-icon"">
                    <div class=""text"">*</div>
                </div>
            </div>
        </div>

        <br>
        <br>

        <div class=""form-group required-field-block"">
            <div class=""col-md-12 input-group"">
                <div class=""col-sm-1 column"">
                    <label>Comment</label>
                    <span class=""input-group-addon""><span class=""glyphicon glyphicon-pencil""></span></span>
                </div>
                <div class=""col-sm-11 column"">

                    <textarea rows=""3"" size=""30""  name=""project.bidrequests.Comment"" id=""Comment"" class=""form-control"" placeholder=""Comment""></textarea>
                    <div class=""required-icon"">
                        <div class=""text"">*</div>
                    </div>
                </div>
    ");
                WriteLiteral("        </div>\r\n        </div>\r\n\r\n        <input type=\"submit\" class=\"btn btn-primary\"/>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FreelancersProject.Application.DTOs.ProjectBidRequestDTO> Html { get; private set; }
    }
}
#pragma warning restore 1591
