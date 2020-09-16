using FreelancersProject.Application.Common;
using FreelancersProject.Application.Services;
using FreelancersProject.Domain.Concretes;
using FreelancersProject.Persistence.CustomException;
using FreelancersProject.Persistence.Infratructure;
using FreelancersProject.Persistence.Repositories.Concretes;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FreelancersProject.Application.Handler.CQRS.Queries.SkillQueries
{
	public class SkillList
	{

		public class SkillListRequest: IRequest<BaseResponses<IEnumerable<Skill>>>
		{

			
		}

		public class SkillListHandler : IRequestHandler<SkillListRequest, BaseResponses<IEnumerable<Skill>>>
		{
			
			private readonly ISkillService skillService;
			private readonly IUnitOfWork unitOfWork;

			public SkillListHandler(ISkillService skillService, IUnitOfWork unitOfWork)
			{
				
				this.skillService = skillService;
				this.unitOfWork = unitOfWork;
			}
			public  async Task<BaseResponses<IEnumerable<Skill>>> Handle(SkillListRequest request, CancellationToken cancellationToken)
			{
				BaseResponses<IEnumerable<Skill>> response = null;



				using (var trx = unitOfWork.BeginTransaction())
				{
					try
					{
						var result = await skillService.GetAll();
						response = new BaseResponses<IEnumerable<Skill>>(result);
					}
					catch (RestException ex)
					{
						response = new BaseResponses<IEnumerable<Skill>>(ex.StatusCode, ex.Message);
					}
					return response;
				}
			}
		}
	}
}
