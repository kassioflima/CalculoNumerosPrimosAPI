using CalculoNumerosPrimos.Domain.Commands;
using System.Threading.Tasks;

namespace CalculoNumerosPrimos.Domain.Interfaces
{
    public interface ICalculoNumerosPrimosApplication
    {
        Task<ICommandResult> HandleAsync(NumeroCommand command);
    }
}
