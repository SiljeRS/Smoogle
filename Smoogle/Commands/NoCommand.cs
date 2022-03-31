using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smoogle.Commands
{
    public class NoCommand : Command
    {
        public void Execute()
        {
            Console.WriteLine("It is a NoCommand");
        }
    }
}
