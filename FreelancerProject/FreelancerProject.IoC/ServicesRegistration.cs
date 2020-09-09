using FreelancersProject.Application.Services.Owner;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace FreelancersProject.IoC
{
    public static class ServicesRegistration
    {
        public static void RegisterService(IServiceCollection services)
        {
            services.AddTransient<IOwnerService, OwnerService>();
        }
    }
}
