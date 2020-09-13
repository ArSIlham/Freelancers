using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using static FreelancersProject.Application.Handler.CQRS.Commands.ProjectCommands.CreateProject;

namespace FreelancersProject.Application.Validators
{
	public class CreateProjectValidator: AbstractValidator<CreateProjectRequest>
	{
		public CreateProjectValidator()
		{
			RuleFor(m => m.Title).NotEmpty().WithMessage("Please specify Title");
			RuleFor(m => m.Description).NotEmpty().WithMessage("Please specify Description");
			RuleFor(m => m.MinPrice).NotEmpty().WithMessage("Please specify Minimum Price");
			RuleFor(m => m.MaxPrice).NotEmpty().WithMessage("Please specify Maximum Price");
		}
	}
}
