using AutoMapper;
using FreelancersProject.Application.Common;
using FreelancersProject.Application.DTOs;
using FreelancersProject.Domain.Concretes;
using FreelancersProject.Persistence.Infratructure;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FreelancersProject.Application.Handler.CQRS.Queries.UserListQueries
{
	public class UserList
	{

		public class UserListRequest : IRequest<BaseResponses<IEnumerable<ApplicationUsersDTO>>>
		{
			public string RoleName { get; set; }
		}

		public class UserListHandler : IRequestHandler<UserListRequest, BaseResponses<IEnumerable<ApplicationUsersDTO>>>
		{
			private readonly UserManager<ApplicationUser> userManager;
			private readonly RoleManager<ApplicationRole> roleManager;
			private readonly IUnitOfWork unitOfWork;
			private readonly IMapper mapper;

			public UserListHandler(UserManager<ApplicationUser> userManager, RoleManager<ApplicationRole> roleManager, IUnitOfWork unitOfWork, IMapper mapper)
			{
				this.userManager = userManager;
				this.roleManager = roleManager;
				this.unitOfWork = unitOfWork;
				this.mapper = mapper;
			}
			public async Task<BaseResponses<IEnumerable<ApplicationUsersDTO>>> Handle(UserListRequest request, CancellationToken cancellationToken)
			{
				BaseResponses<IEnumerable<ApplicationUsersDTO>> response = null;

				using (var trx = unitOfWork.BeginTransaction())
				{
					try
					{
						var appUsers = new List<ApplicationUsersDTO>();
						var users = await userManager.GetUsersInRoleAsync(request.RoleName);

						foreach (var item in users)
						{
							var user = mapper.Map<ApplicationUsersDTO>(item);
							appUsers.Add(user);

						}
						response = new BaseResponses<IEnumerable<ApplicationUsersDTO>>(appUsers);
						unitOfWork.SaveChanges();

					}
					catch (Exception ex)
					{
						response = new BaseResponses<IEnumerable<ApplicationUsersDTO>>(System.Net.HttpStatusCode.BadRequest, ex.Message);
						trx.Rollback();

					}
				}

				return response;
			}
		}
	}
}
