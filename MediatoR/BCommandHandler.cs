using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    internal sealed class BCommandHandler : ICommandHandler<BCommand, Output>
    {
        public async Task<Output> Handler(BCommand command)
        {
            return new Output();
        }
    }
}
