using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = AutoFacBootstrapper.Container;
            
            using (var scope= container.BeginLifetimeScope())
            {
                ACommand aCommand = new ACommand();
                var mediator = scope.Resolve<IMediator<ACommand, Output>>();
                var output=mediator.Send(aCommand).Result;
            }

        }
    }
}
