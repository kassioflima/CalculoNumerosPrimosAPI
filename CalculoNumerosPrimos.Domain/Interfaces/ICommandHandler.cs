using System.Threading.Tasks;

namespace CalculoNumerosPrimos.Domain.Interfaces
{
    public interface ICommandHandler<Command> where Command : ICommand
    {
        Task<ICommandResult> HandleAsync(Command command);
    }
}
