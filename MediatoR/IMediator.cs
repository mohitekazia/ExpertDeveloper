using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    interface IMediator<TCommand,TOutput>
    {
        Task<TOutput> Send(TCommand command);
    }
}
