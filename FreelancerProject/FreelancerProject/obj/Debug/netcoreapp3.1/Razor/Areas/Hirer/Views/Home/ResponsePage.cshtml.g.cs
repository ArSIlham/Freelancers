<<<<<<< HEAD
#pragma checksum "C:\Users\99450\Desktop\Freelancers\FreelancerProject\FreelancerProject\Areas\Hirer\Views\Home\ResponsePage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f513f998c62b503a0169a792a5708fde40b905f"
=======
#pragma checksum "C:\freelancer\FreelancerProject\FreelancerProject\Areas\Hirer\Views\Home\ResponsePage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f513f998c62b503a0169a792a5708fde40b905f"
>>>>>>> 0096745938172902581ce1fb2db754463ee60938
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Hirer_Views_Home_ResponsePage), @"mvc.1.0.view", @"/Areas/Hirer/Views/Home/ResponsePage.cshtml")]
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
<<<<<<< HEAD
#line 1 "C:\Users\99450\Desktop\Freelancers\FreelancerProject\FreelancerProject\Areas\Hirer\Views\_ViewImports.cshtml"
=======
#line 1 "C:\freelancer\FreelancerProject\FreelancerProject\Areas\Hirer\Views\_ViewImports.cshtml"
>>>>>>> 0096745938172902581ce1fb2db754463ee60938
using FreelancersProject;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 2 "C:\Users\99450\Desktop\Freelancers\FreelancerProject\FreelancerProject\Areas\Hirer\Views\_ViewImports.cshtml"
=======
#line 2 "C:\freelancer\FreelancerProject\FreelancerProject\Areas\Hirer\Views\_ViewImports.cshtml"
>>>>>>> 0096745938172902581ce1fb2db754463ee60938
using FreelancersProject.Application.Handler.CQRS.Commands.LoginCommands;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 3 "C:\Users\99450\Desktop\Freelancers\FreelancerProject\FreelancerProject\Areas\Hirer\Views\_ViewImports.cshtml"
=======
#line 3 "C:\freelancer\FreelancerProject\FreelancerProject\Areas\Hirer\Views\_ViewImports.cshtml"
>>>>>>> 0096745938172902581ce1fb2db754463ee60938
using FreelancersProject.Application.Handler.CQRS.Commands.ProjectCommands;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 4 "C:\Users\99450\Desktop\Freelancers\FreelancerProject\FreelancerProject\Areas\Hirer\Views\_ViewImports.cshtml"
=======
#line 4 "C:\freelancer\FreelancerProject\FreelancerProject\Areas\Hirer\Views\_ViewImports.cshtml"
>>>>>>> 0096745938172902581ce1fb2db754463ee60938
using FreelancersProject.Domain.Concretes;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 5 "C:\Users\99450\Desktop\Freelancers\FreelancerProject\FreelancerProject\Areas\Hirer\Views\_ViewImports.cshtml"
=======
#line 5 "C:\freelancer\FreelancerProject\FreelancerProject\Areas\Hirer\Views\_ViewImports.cshtml"
>>>>>>> 0096745938172902581ce1fb2db754463ee60938
using FreelancersProject.Application.DTOs;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f513f998c62b503a0169a792a5708fde40b905f", @"/Areas/Hirer/Views/Home/ResponsePage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fe388bcf2179414f0cb68f794e1bf118dd18f24", @"/Areas/Hirer/Views/_ViewImports.cshtml")]
    public class Areas_Hirer_Views_Home_ResponsePage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FreelancersProject.Application.DTOs.ErrorPageDTO>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
<<<<<<< HEAD
#line 3 "C:\Users\99450\Desktop\Freelancers\FreelancerProject\FreelancerProject\Areas\Hirer\Views\Home\ResponsePage.cshtml"
=======
#line 3 "C:\freelancer\FreelancerProject\FreelancerProject\Areas\Hirer\Views\Home\ResponsePage.cshtml"
>>>>>>> 0096745938172902581ce1fb2db754463ee60938
  
	ViewData["Title"] = "ResponsePage";
	Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
            WriteLiteral(@"
<style>
	* {
  -webkit-box-sizing: border-box;
          box-sizing: border-box;
}

body {
  padding: 0;
  margin: 0;
}

#notfound {
  position: relative;
  height: 100vh;
}

#notfound .notfound {
  position: absolute;
  left: 50%;
  top: 50%;
  -webkit-transform: translate(-50%, -50%);
      -ms-transform: translate(-50%, -50%);
          transform: translate(-50%, -50%);
}

.notfound {
  max-width: 560px;
  width: 100%;
  padding-left: 160px;
  line-height: 1.1;
}

.notfound .notfound-404 {
  position: absolute;
  left: 0;
  top: 0;
  display: inline-block;
  width: 140px;
  height: 140px;
  background-image: url('~/wwwroot/images/emoji.png');
  background-size: cover;
}

.notfound .notfound-404:before {
  content: '';
  position: absolute;
  width: 100%;
  height: 100%;
  -webkit-transform: scale(2.4);
      -ms-transform: scale(2.4);
          transform: scale(2.4);
  border-radius: 50%;
  background-color: #f2f5f8;
  z-index: -1;
}

.notfound h1 {");
            WriteLiteral(@"
  font-family: 'Nunito', sans-serif;
  font-size: 65px;
  font-weight: 700;
  margin-top: 0px;
  margin-bottom: 10px;
  color: #151723;
  text-transform: uppercase;
}

.notfound h2 {
  font-family: 'Nunito', sans-serif;
  font-size: 21px;
  font-weight: 400;
  margin: 0;
  text-transform: uppercase;
  color: #151723;
}

.notfound p {
  font-family: 'Nunito', sans-serif;
  color: #999fa5;
  font-weight: 400;
}

.notfound a {
  font-family: 'Nunito', sans-serif;
  display: inline-block;
  font-weight: 700;
  border-radius: 40px;
  text-decoration: none;
  color: #388dbc;
}

media only screen and (max-width: 767px) {
  .notfound .notfound-404 {
    width: 110px;
    height: 110px;
  }
  .notfound {
    padding-left: 15px;
    padding-right: 15px;
    padding-top: 110px;
  }
}
</style>

<div id=""notfound"">
	<div class=""notfound"">
		<div class=""notfound-404""></div>
		<h1>");
#nullable restore
<<<<<<< HEAD
#line 130 "C:\Users\99450\Desktop\Freelancers\FreelancerProject\FreelancerProject\Areas\Hirer\Views\Home\ResponsePage.cshtml"
=======
#line 130 "C:\freelancer\FreelancerProject\FreelancerProject\Areas\Hirer\Views\Home\ResponsePage.cshtml"
>>>>>>> 0096745938172902581ce1fb2db754463ee60938
       Write(Convert.ToInt32(Model.StatusCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\t\t<h2>Oops! ");
#nullable restore
<<<<<<< HEAD
#line 131 "C:\Users\99450\Desktop\Freelancers\FreelancerProject\FreelancerProject\Areas\Hirer\Views\Home\ResponsePage.cshtml"
=======
#line 131 "C:\freelancer\FreelancerProject\FreelancerProject\Areas\Hirer\Views\Home\ResponsePage.cshtml"
>>>>>>> 0096745938172902581ce1fb2db754463ee60938
             Write(Model.StatusCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\t\t<p>");
#nullable restore
<<<<<<< HEAD
#line 132 "C:\Users\99450\Desktop\Freelancers\FreelancerProject\FreelancerProject\Areas\Hirer\Views\Home\ResponsePage.cshtml"
=======
#line 132 "C:\freelancer\FreelancerProject\FreelancerProject\Areas\Hirer\Views\Home\ResponsePage.cshtml"
>>>>>>> 0096745938172902581ce1fb2db754463ee60938
      Write(Model.Errors);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t\t<a href=\"#\">Back to homepage</a>\r\n\t</div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FreelancersProject.Application.DTOs.ErrorPageDTO> Html { get; private set; }
    }
}
#pragma warning restore 1591
