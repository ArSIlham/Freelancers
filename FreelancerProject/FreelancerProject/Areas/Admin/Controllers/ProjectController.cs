using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using FreelancersProject.Application.DTOs;
using FreelancersProject.Application.Handler.CQRS.Commands.ConfirmedBidCommands;
using FreelancersProject.Application.Handler.CQRS.Commands.ProjectCommands;
using FreelancersProject.Application.Handler.CQRS.Queries.ProjectQueries;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FreelancersProject.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Authorize(Roles = "Admin")]
	public class ProjectController : Controller
	{
		private readonly IMediator mediator;

		public ProjectController(IMediator mediator)
		{
			this.mediator = mediator;
		}
		public async Task<IActionResult> ProjectManager()
		{
			var result = await mediator.Send(new AllProjectList.AllProjectRequest ());
			if (result.StatusCode == HttpStatusCode.OK)
			{
				return View(result.Entity);

			}

			else
			{
				var error = new ErrorPageDTO() { StatusCode = result.StatusCode, Errors = result.Errors, Success = result.Success };
				return RedirectToAction("ResponsePage", "Home", error);
			}
		}

		public async Task<IActionResult> Delete(string projectId)
		{

			var result = await mediator.Send(new DeleteProject.DeleteProjectRequest { ProjectId = projectId });
			if (result.StatusCode == HttpStatusCode.OK)
			{
				return RedirectToAction("ProjectManager");
			}
			else
			{
				var error = new ErrorPageDTO() { StatusCode = result.StatusCode, Errors = result.Errors, Success = result.Success };
				return RedirectToAction("ResponsePage", "Home", new { Area = "Hirer", model = error });
			}


		}

		public async Task<IActionResult> DeleteBidRequest(string requestId)
		{

			var result = await mediator.Send(new DeleteBid.DeleteBidRequest { BidRequestId = requestId });
			if (result.StatusCode == HttpStatusCode.OK)
			{
				return RedirectToAction("ProjectManager");
			}
			else
			{
				var error = new ErrorPageDTO() { StatusCode = result.StatusCode, Errors = result.Errors, Success = result.Success };
				return RedirectToAction("ResponsePage", "Home", new { Area = "Hirer", model = error });
			}


		}
		public async Task<IActionResult> ProjectDetails([FromQuery] string projectId)
		{
			var result = await mediator.Send(new ProjectDetails.ProjectDetailsRequest { ProjectId = projectId });
			if (result.StatusCode == HttpStatusCode.OK)
			{
				return View(result.Entity);

			}

			else
			{
				var error = new ErrorPageDTO() { StatusCode = result.StatusCode, Errors = result.Errors, Success = result.Success };
				return RedirectToAction("ResponsePage", "Home", error);
			}
		}
	}
}
