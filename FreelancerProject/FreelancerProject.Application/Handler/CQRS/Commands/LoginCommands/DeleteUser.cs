using FreelancersProject.Application.Common;
using FreelancersProject.Domain.Concretes;
using FreelancersProject.Persistence.Infratructure;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FreelancersProject.Application.Handler.CQRS.Commands.LoginCommands
{
	public class DeleteUser
	{

		public class DeletUserRequest : IRequest<BaseResponses<IdentityResult>>
		{
			public string Email { get; set; }
		}

		public class DeleteUserHandler : IRequestHandler<DeletUserRequest, BaseResponses<IdentityResult>>
		{
			private readonly UserManager<ApplicationUser> userManager;
			private readonly IUnitOfWork unitOfWork;

			public DeleteUserHandler(UserManager<ApplicationUser> userManager, IUnitOfWork unitOfWork)
			{
				this.userManager = userManager;
				this.unitOfWork = unitOfWork;
			}

			public async Task<BaseResponses<IdentityResult>> Handle(DeletUserRequest request, CancellationToken cancellationToken)
			{
				BaseResponses<IdentityResult> responce = null;
				using (var trx = unitOfWork.BeginTransaction())
				{
					try
					{
						var user = await userManager.FindByEmailAsync(request.Email);
						var result = await userManager.DeleteAsync(user);
						unitOfWork.SaveChanges();
						responce = new BaseResponses<IdentityResult>(result);
					}
					catch (Exception ex)
					{
						trx.Rollback();
						responce = new BaseResponses<IdentityResult>(System.Net.HttpStatusCode.BadRequest,ex.Message);
					}
					return responce;
				}

			}
		}
	}
}
