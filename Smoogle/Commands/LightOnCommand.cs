using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smoogle.Commands
{
    public class LightOnCommand : Command
    {
        private Light light;
        public LightOnCommand(Light l)
        {
            light = l;
        }
        public void Execute()
        {
            light.lightOn();
        }
    }
}
