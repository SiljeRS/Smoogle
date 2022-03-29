using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Smoogle;

namespace Smoogle.Commands
{
    public class MakeCoffeeCommand : Command
    {
        Coffee _coffee;
        public MakeCoffeeCommand(Coffee coffee)
        {
            _coffee = coffee;
        }
        public void Execute()
        {
            _coffee.on();
            _coffee.getBeans();
            _coffee.brew();
            _coffee.off();
        }
    }
}
