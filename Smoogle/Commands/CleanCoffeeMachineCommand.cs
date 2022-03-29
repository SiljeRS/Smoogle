using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smoogle.Commands
{
    public class CleanCoffeeMachineCommand : Command
    {
        Coffee _coffee;
        public CleanCoffeeMachineCommand(Coffee coffee)
        {
            _coffee = coffee;
        }
        public void Execute()
        {
            _coffee.on();
            _coffee.clean();
            _coffee.off();
        }
    }
}
