using CalculoNumerosPrimos.Domain.Queries;
using System.Threading.Tasks;

namespace CalculoNumerosPrimos.Domain.Interfaces
{
    public interface ICalculoNumerosPrimosApplication
    {
        Task<NumerosPrimosQueryResult> CalcularDivisoresEPrimos(int numero);
    }
}
