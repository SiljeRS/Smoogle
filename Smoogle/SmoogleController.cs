using Smoogle.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smoogle
{
    public class SmoogleController
    {
        private Command[] commandsOn;
        private Command[] commandsOff;
        private int numberOfButtons = 0;

        public SmoogleController(int buttons)
        {
            commandsOn = new Command[buttons];
            commandsOff = new Command[buttons];
            numberOfButtons = buttons;

            for (int i = 0; i < buttons; i++)
            {
                commandsOn[i] = new NoCommand();
                commandsOff[i] = new NoCommand();
            }
        }
        public void setCommand(int index, Command on, Command off)
        {
            if (index < 0 || index >= numberOfButtons)
                return;
            commandsOn[index] = on;
            commandsOff[index] = off;
        }
        public void onButtonWasPushed(int index)
        {
            if (index < 0 || index >= numberOfButtons)
            {
                Console.WriteLine("Button doesn't exist!");
                return;
            }
            commandsOn[index].Execute();
        }
        public void offButtonWasPushed(int index)
        {
            if (index < 0 || index >= numberOfButtons)
            {
                Console.WriteLine("Button doesn't exist!");
                return;
            }
            commandsOff[index].Execute();
        }
    }
}
