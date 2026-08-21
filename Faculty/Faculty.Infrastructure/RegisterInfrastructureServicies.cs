using Faculty.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Faculty.Infrastructure
{
    public static class RegisterInfrastructureServices
    {
        public static void AddInfrastructureServices(this IServiceCollection  services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(x => 
            {
                x.UseSqlServer(configuration.GetConnectionString("Default"));
            });
        }
    }
}
