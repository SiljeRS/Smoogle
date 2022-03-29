using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smoogle.Commands
{
    public class BlindsUpCommand : Command
    {
        private Blinds blinds;
        public BlindsUpCommand(Blinds b)
        {
            blinds = b;
        }
        public void Execute()
        {
            blinds.blindsUp();
        }
    }
}
