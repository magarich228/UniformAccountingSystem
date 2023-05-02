using Microsoft.Extensions.DependencyInjection;
using UniformAccountingSystem.BLL.Abstractions;
using UniformAccountingSystem.BLL.Profiles;
using UniformAccountingSystem.BLL.Services;

namespace UniformAccountingSystem.Data
{
    public static class BLLServicesExtensions
    {
        public static IServiceCollection AddUasBLLServices(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(UniformProfile));

            services.AddScoped<IEmployeesManager, EmployeesManager>();
            services.AddScoped<IUniformService, UniformService>();
            services.AddScoped<IVendorManager, VendorManager>();

            return services;
        }
    }
}
