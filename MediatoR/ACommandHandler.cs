using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    internal class ACommandHandler : ICommandHandler<ACommand, Output>
    {
        public async Task<Output> Handler(ACommand command)
        {
            return new Output();
        }
    }
}
