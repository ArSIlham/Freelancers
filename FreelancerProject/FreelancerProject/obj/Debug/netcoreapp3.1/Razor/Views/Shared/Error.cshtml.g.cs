#pragma checksum "C:\Users\99450\Desktop\Freelancers\FreelancerProject\FreelancerProject\Views\Shared\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b0d9aabd4dcd61e68a446816482b4ce562ed8ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Error), @"mvc.1.0.view", @"/Views/Shared/Error.cshtml")]
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
#line 1 "C:\Users\99450\Desktop\Freelancers\FreelancerProject\FreelancerProject\Views\_ViewImports.cshtml"
using FreelancersProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\99450\Desktop\Freelancers\FreelancerProject\FreelancerProject\Views\_ViewImports.cshtml"
using FreelancersProject.Application.Handler.CQRS.Commands.LoginCommands;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\99450\Desktop\Freelancers\FreelancerProject\FreelancerProject\Views\_ViewImports.cshtml"
using FreelancersProject.Application.Handler.CQRS.Commands.ProjectCommands;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\99450\Desktop\Freelancers\FreelancerProject\FreelancerProject\Views\_ViewImports.cshtml"
using FreelancersProject.Domain.Concretes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\99450\Desktop\Freelancers\FreelancerProject\FreelancerProject\Views\_ViewImports.cshtml"
using FreelancersProject.Application.DTOs;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b0d9aabd4dcd61e68a446816482b4ce562ed8ff", @"/Views/Shared/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b00cb1ede8fad256d2b696a8252d8c113a95fffc", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FreelancersProject.Models.ErrorViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\99450\Desktop\Freelancers\FreelancerProject\FreelancerProject\Views\Shared\Error.cshtml"
  
    ViewData["Title"] = "Error";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"text-danger\">Error.</h1>\r\n<h2 class=\"text-danger\">An error occurred while processing your request.</h2>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\99450\Desktop\Freelancers\FreelancerProject\FreelancerProject\Views\Shared\Error.cshtml"
 if (Model.ShowRequestId)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\r\n        <strong>Request ID:</strong> <code>");
#nullable restore
#line 12 "C:\Users\99450\Desktop\Freelancers\FreelancerProject\FreelancerProject\Views\Shared\Error.cshtml"
                                      Write(Model.RequestId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</code>\r\n    </p>\r\n");
#nullable restore
#line 14 "C:\Users\99450\Desktop\Freelancers\FreelancerProject\FreelancerProject\Views\Shared\Error.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h3>Development Mode</h3>
<p>
    Swapping to <strong>Development</strong> environment will display more detailed information about the error that occurred.
</p>
<p>
    <strong>The Development environment shouldn't be enabled for deployed applications.</strong>
    It can result in displaying sensitive information from exceptions to end users.
    For local debugging, enable the <strong>Development</strong> environment by setting the <strong>ASPNETCORE_ENVIRONMENT</strong> environment variable to <strong>Development</strong>
    and restarting the app.
</p>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FreelancersProject.Models.ErrorViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
