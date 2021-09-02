using CalculoNumerosPrimos.Domain.DomainNotifications;
using Flunt.Notifications;
using System;
using System.Collections.Generic;

namespace CalculoNumerosPrimos.Domain.Commands
{
    public class CommandHandler : Notifiable<Notification>
    {
        private readonly IHandler<DomainNotification> _notifications;

        public CommandHandler(IHandler<DomainNotification> notifications)
        {
            _notifications = notifications;
        }
    }

    public interface IHandler<T> : IDisposable where T : IDomainEvent
    {
        void Handle(T args);
        bool HasNotifications();
        List<T> GetValues();
    }
}
