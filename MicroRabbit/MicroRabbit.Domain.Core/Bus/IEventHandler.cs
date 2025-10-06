using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MicroRabbit.Domain.Core.Events;

namespace MicroRabbit.Domain.Core.Bus
{
    internal interface IEventHandler<in TEvent> : IEventHandler
        where TEvent : Event
    {
        Task Handler(TEvent @event);
    }

    public interface IEventHandler
    {

    }
}
