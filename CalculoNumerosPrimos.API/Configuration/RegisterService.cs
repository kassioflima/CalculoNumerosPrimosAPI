using CalculoNumerosPrimos.Application.Application;
using CalculoNumerosPrimos.Domain.Commands;
using CalculoNumerosPrimos.Domain.DomainNotifications;
using CalculoNumerosPrimos.Domain.Interfaces;
using CalculoNumerosPrimos.Domain.Response;
using Microsoft.Extensions.DependencyInjection;

namespace CalculoNumerosPrimos.API.Configuration
{
    public abstract class RegisterService
    {
        /// <summary>
        // Transient => Uma instancia para cada solicitacao;
        // Singleton => Uma instancia unica para a classe;
        // Scoped => Uma instancia unica para o request;
        /// </summary>
        /// <param name="services"></param>
        public static void RegisterServices(IServiceCollection services)
        {
            #region[-- Handlers --]
            services.AddScoped<ICalculoNumerosPrimosApplication, CalculoNumerosPrimosApplication>();
            #endregion

            #region[-- Repositorios EF Core --]

            #endregion

            #region[-- Dapper --]

            #endregion

            #region[-- ExternalData --]
            services.AddScoped<ICommandResult, CommandResult>();
            services.AddScoped<IHandler<DomainNotification>, DomainNotificationHandler>();
            #endregion
        }
    }
}
