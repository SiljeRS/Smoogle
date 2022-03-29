using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smoogle
{
    public class Coffee
    {
        private int _beans = 0;
        public Coffee(int beans)
        {
            _beans = beans;
        }
        public void on()
        {
            Console.WriteLine("Coffee machine is on");
        }
        public void off()
        {
            Console.WriteLine("Coffee machine is off");
        }
        public void clean()
        {
            Console.WriteLine("Coffee machine is cleaned");
        }
        public void getBeans()
        {
            if (_beans > 0)
            {
                Console.WriteLine("Getting beans");
                _beans -= 1;
            }
            else
                Console.WriteLine("Not enough beans");
        }
        public void brew()
        {
            if ((_beans + 1) > 0)
            {
                Console.WriteLine("Brewing");
                Thread.Sleep(1000);
                Console.WriteLine("Coffee is ready");
            }
        }
    }
}
