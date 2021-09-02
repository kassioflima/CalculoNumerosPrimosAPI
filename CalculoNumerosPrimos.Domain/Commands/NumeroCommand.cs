using CalculoNumerosPrimos.Domain.Interfaces;
using Flunt.Notifications;
using Flunt.Validations;

namespace CalculoNumerosPrimos.Domain.Commands
{
    public class NumeroCommand : Notifiable<Notification>, ICommand
    {
        public int Numero { get; set; }

        public bool EhValido()
        {
            AddNotifications(new Contract<NumeroCommand>()
                .Requires()
                .IsGreaterThan(Numero, 0, "Numero", "O número deve ser maior que zero!"));

            return IsValid;
        }
    }
}
