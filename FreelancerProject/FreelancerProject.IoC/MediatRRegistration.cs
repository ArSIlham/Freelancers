using FreelancersProject.Application.Handler.CQRS.Commands.ProjectCommands;
using FreelancersProject.Application.Handler.CQRS.Queries;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace FreelancersProject.IoC
{
    public static class MediatRRegistration
    {
        public static void RegisterMediatR(IServiceCollection services)
        {
            //Owner
            services.AddMediatR(Assembly.GetAssembly(typeof(GettAllProject.GetAllProjectRequest)));

            services.AddMediatR(Assembly.GetAssembly(typeof(GetProjectSelectID.GetProjectSelectIDRequest)));
            



        }
    }
}
