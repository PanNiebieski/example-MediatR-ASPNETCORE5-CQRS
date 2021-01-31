using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatorASPCORE.Functions.Command.WritePost
{
    public class WritePostNotification
        : INotification
    {
        public string WhatToWrite { get; set; }
    }

}
