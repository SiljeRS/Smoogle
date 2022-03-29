using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smoogle.Commands
{
    public class LightOffCommand : Command
    {
        private Light light;
        public LightOffCommand(Light l)
        {
            light = l;
        }
        public void Execute()
        {
            light.lightOff();
        }
    }
}
