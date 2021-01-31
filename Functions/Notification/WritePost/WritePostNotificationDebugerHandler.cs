using MediatorASPCORE.Functions.Command.WritePost;
using MediatR;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MediatorASPCORE.Functions.Notification.WritePost
{
    public class WritePostNotificationDebuggerHandler :
        INotificationHandler<WritePostNotification>
    {
        public Task Handle(WritePostNotification notification,
            CancellationToken cancellationToken)
        {
            Debugger.Log(1, "Info",
                notification.WhatToWrite);

            return Task.CompletedTask;
        }
    }
}
