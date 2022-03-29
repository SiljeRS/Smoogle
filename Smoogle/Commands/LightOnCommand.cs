using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smoogle.Commands
{
    public class LightOnCommand
    {
        private Light light;
        LightOnCommand(Light l)
        {
            light = l;
        }
        public void Execute()
        {
            light.lightOn();
        }
    }
}
