using Microsoft.Extensions.DependencyInjection;
using VagasEmprego.Application.Interfaces;
using VagasEmprego.Infra.Data.Context;

namespace VagasEmprego.CrossCutting.Ioc
{
    public class ConfigStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            #region AppServices

            services.AddScoped<IEmpregoAppService, EmpregoAppService>();

            #endregion

            #region Repositories
            services.AddScoped<IEmpregoRepository, EmpregoRepository>();
            #endregion
        }
    }
}
