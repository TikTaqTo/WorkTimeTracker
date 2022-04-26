using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using MediatR;
using FluentValidation;
using WorkTimeTrackerService.Application.Behaviors;

namespace WorkTimeTrackerService.Application
{
  public static class ServiceCollectionExtensions
  {
    public static IServiceCollection AddApplication(this IServiceCollection services,
           Assembly[] automapperAssemblies)
    {
      //Нужно попробовать вместо передачи ряда Assembly, передать исполняющуюся сборку а именно WorkTimeTrackerService.Api Assembly
      services.AddAutoMapper(automapperAssemblies);
      services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
      services.AddMediatR(Assembly.GetExecutingAssembly());
      services.AddTransient(typeof(IPipelineBehavior<,>), typeof(LoggingBehavior<,>));
      services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));

      return services;
    }
  }
}
