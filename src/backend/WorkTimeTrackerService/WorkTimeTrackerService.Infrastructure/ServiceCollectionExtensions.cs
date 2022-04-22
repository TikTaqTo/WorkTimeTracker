using System;
using System.Reflection;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WorkTimeTrackerService.Application.Abstractions.Dictionaries;
using WorkTimeTrackerService.Application.Abstractions.Projects;
using WorkTimeTrackerService.Application.Abstractions.ProjectTasks;
using WorkTimeTrackerService.Infrastructure.Persistence;
using WorkTimeTrackerService.Infrastructure.Services.Dictionaries;
using WorkTimeTrackerService.Infrastructure.Services.Projects;
using WorkTimeTrackerService.Infrastructure.Services.ProjectTasks;

namespace WorkTimeTrackerService.Infrastructure
{
  public static class ServiceCollectionExtensions
  {

    public static IServiceCollection AddInfrastructure(this IServiceCollection services,
            IConfiguration configuration)
    {
      services.AddDbContext<WorkTimeTrackerServiceContext>(options =>
      {
        options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
            sqlOptions =>
            {
              sqlOptions.MigrationsAssembly(typeof(ServiceCollectionExtensions).GetTypeInfo().Assembly
                          .GetName().Name);
              sqlOptions.EnableRetryOnFailure(
                          Convert.ToInt32(configuration.GetSection("InfrastructureSettings:MaxRetryCount").Value),
                          TimeSpan.FromSeconds(
                              Convert.ToInt32(configuration.GetSection("InfrastructureSettings:MaxDelayCount")
                                  .Value)),
                          null);
            });
      });

      services.AddControllers().AddJsonOptions(x =>
      x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve);

      services.AddScoped<IProjectTaskService, ProjectTaskService>();
      services.AddScoped<IProjectTaskStatusService, ProjectTaskStatusService>();
      services.AddScoped<IProjectTaskTypeService, ProjectTaskTypeService>();
      services.AddScoped<IProjectService, ProjectService>();

      return services;
    }
  }
}
