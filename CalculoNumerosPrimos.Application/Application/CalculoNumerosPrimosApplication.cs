using CalculoNumerosPrimos.Domain.Commands;
using CalculoNumerosPrimos.Domain.DomainNotifications;
using CalculoNumerosPrimos.Domain.Entities;
using CalculoNumerosPrimos.Domain.Interfaces;
using CalculoNumerosPrimos.Domain.Queries;
using CalculoNumerosPrimos.Domain.Response;
using System.Threading.Tasks;

namespace CalculoNumerosPrimos.Application.Application
{
    public class CalculoNumerosPrimosApplication : CommandHandler, ICommandHandler<NumeroCommand>, ICalculoNumerosPrimosApplication
    {
        public CalculoNumerosPrimosApplication(IHandler<DomainNotification> notifications) : base(notifications)
        {
        }

        public async Task<ICommandResult> HandleAsync(NumeroCommand command)
        {
            if (command.EhValido())
            {
                var numerosPrimos = new NumerosPrimos(command.Numero);

                numerosPrimos.CalcularNumeroPrimos(command.Numero);

                return new CommandResult(true, "Success", new NumerosPrimosQueryResult
                {
                    Divisores = numerosPrimos.Divisores,
                    NumeroEntrada = numerosPrimos.NumeroEntrada,
                    Primos = numerosPrimos.Primos
                });
            }

            return new CommandResult(false, "Parâmetro inválido para calcular números primos!");
        }
    }
}
