using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public sealed class Mediator<TCommand, TOutput> : IMediator<TCommand, TOutput>
    {

        public readonly IContainer container;
        public Mediator()
        {
            container = AutoFacBootstrapper.Container;
        }
        public async Task<TOutput> Send(TCommand command)
        {
            using (var scope = container.BeginLifetimeScope())
            {
                var d = scope.Resolve<ICommandHandler<TCommand, TOutput>>();
                return d.Handler(command).Result;
            }
        }
    }
}
