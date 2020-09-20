using FreelancersProject.Persistence.Repositories;
using FreelancersProject.Persistence.Repositories.Concretes;
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
            services.AddTransient<IProjectRepository, ProjectRepository>();
            services.AddTransient<ISkillRepository, SkillRepository>();
            services.AddTransient<ICountryRepository, CountryRepository>();
            services.AddTransient<IOfferedProjectRepository, OfferedProjectRepository>();
            services.AddTransient<IBidRequestRepository, BidRequestRepository>();
        }
    }
}
