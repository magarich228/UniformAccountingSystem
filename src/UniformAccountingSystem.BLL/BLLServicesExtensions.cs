using Microsoft.Extensions.DependencyInjection;
using UniformAccountingSystem.BLL.Abstractions;
using UniformAccountingSystem.BLL.Services;

namespace UniformAccountingSystem.Data
{
    public static class BLLServicesExtensions
    {
        public static IServiceCollection AddUasBLLServices(this IServiceCollection services)
        {
            services.AddScoped<IEmployeesManager, EmployeesManager>();

            return services;
        }
    }
}
