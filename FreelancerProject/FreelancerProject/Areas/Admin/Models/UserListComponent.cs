using FreelancersProject.Application.Handler.CQRS.Queries.UserListQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreelancersProject.Areas.Admin.Models
{
	[Area("Admin")]
	public class UserListViewComponent :ViewComponent
	{
		
		private readonly IMediator mediator;

		public UserListViewComponent(  IMediator mediator)
		{
			
			this.mediator = mediator;
		}

		public async Task<IViewComponentResult> InvokeAsync(string rolename)
		{
			var result = await mediator.Send(new UserList.UserListRequest() { RoleName = rolename });
			return (IViewComponentResult)View("UserList",result.Entity);
		}
	}
}
