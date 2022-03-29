using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smoogle.Commands
{
    public class BlindsDownCommand : Command
    {
        private Blinds blinds;
        public BlindsDownCommand(Blinds b)
        {
            blinds = b;
        }
        public void Execute()
        {
            blinds.blindsDown();
        }
    }
}
