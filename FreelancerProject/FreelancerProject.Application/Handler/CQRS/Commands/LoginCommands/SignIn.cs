using AutoMapper;
using FreelancersProject.Application.Common;
using FreelancersProject.Domain.Concretes;
using FreelancersProject.Persistence.CustomException;
using FreelancersProject.Persistence.Infratructure;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FreelancersProject.Application.Handler.CQRS.Commands.LoginCommands
{
	public class SignIn
	{

		public class SignInRequest : IRequest<BaseResponses<ApplicationUser>>
		{
			[Required]
			public string Name { get; set; }
			[Required]
			public string SurName { get; set; }
			[Required]
			public string UserName { get; set; }
			[Required]
			public string Email { get; set; }
			[Required]
			public string PasswordHash { get; set; }
			[Required]
			[Compare("PasswordHash")]
			public string ConfirmPassword { get; set; }
			public string PhoneNumber { get; set; }
			[Required]
			public Guid CountryId { get; set; }
			[Required]
			public string Role { get; set; }




		}


		public class SignInHandler : IRequestHandler<SignInRequest, BaseResponses<ApplicationUser>>
		{
			private readonly UserManager<ApplicationUser> userManager;
			private readonly IMapper mapper;
			private readonly IUnitOfWork unitOfWork;
			private readonly RoleManager<ApplicationRole> roleManager;

			public SignInHandler(UserManager<ApplicationUser> userManager, IMapper mapper, IUnitOfWork unitOfWork, RoleManager<ApplicationRole> roleManager)
			{
				this.userManager = userManager;
				this.mapper = mapper;
				this.unitOfWork = unitOfWork;
				this.roleManager = roleManager;
			}
			public async Task<BaseResponses<ApplicationUser>> Handle(SignInRequest request, CancellationToken cancellationToken)
			{
				BaseResponses<ApplicationUser> response = null;

				using (var trx = unitOfWork.BeginTransaction())
				{
					try
					{
						var user = mapper.Map<ApplicationUser>(request);
						var result = await userManager.CreateAsync(user, user.PasswordHash);
						if (result.Succeeded)
						{
							var role = await roleManager.FindByNameAsync(request.Role);
							
							if (role == null)
							{
								var roleResult=await roleManager.CreateAsync(new ApplicationRole { Name = request.Role });
							}
							var tempUser = await userManager.FindByEmailAsync(request.Email);
							var finalResult=await userManager.AddToRoleAsync(tempUser, request.Role);
							unitOfWork.SaveChanges();

							response = new BaseResponses<ApplicationUser>(user, result.Succeeded, "");

						}
						List<ValidationError> errors = null;
						if (!result.Succeeded)
						{
							errors = new List<ValidationError>();
							foreach (var item in result.Errors)
							{
								errors.Add(new ValidationError(item.Code, item.Description));
							}

							response = new BaseResponses<ApplicationUser>(user, result.Succeeded) { ValidationErrors = errors };
						}

						

					}
					catch (RestException ex)
					{
						trx.Rollback();
						response = new BaseResponses<ApplicationUser>(ex.StatusCode, ex.Message);


					}
					return response;
				}


			}
		}

	}



}
