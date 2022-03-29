using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smoogle
{
    public class Light
    {
        private bool lightIsOn = false;
        public void lightOn()
        {
            if (lightIsOn)
                Console.WriteLine("Light is already on");
            else
            {
                Console.WriteLine("Light is turned on");
                lightIsOn = true;
            }
        }
        public void lightOff()
        {
            if (!lightIsOn)
                Console.WriteLine("Light is already off");
            else
            {
                Console.WriteLine("Light is turned off");
                lightIsOn = false;
            }
        }
    }
}
