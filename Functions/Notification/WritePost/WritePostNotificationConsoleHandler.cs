using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MediatorASPCORE.Functions.Command.WritePost
{
    public class WritePostNotificationConsoleHandler :
        INotificationHandler<WritePostNotification>
    {
        public Task Handle(WritePostNotification notification,
            CancellationToken cancellationToken)
        {
            Console.WriteLine(notification.WhatToWrite);

            return Task.CompletedTask;
        }
    }
}
