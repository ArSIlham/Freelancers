using FreelancersProject.Persistence.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace FreelancersProject.IoC
{
    public static class RepositoryRegistration
    {
        public static void RegisterRepo(IServiceCollection services)
        {
            services.AddTransient<IOwnerRepository, OwnersRepository>();
        }
    }
}
