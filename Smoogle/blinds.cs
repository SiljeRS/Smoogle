using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smoogle
{
    public class Blinds
    {
        private bool blindsAreDown = false;
        public void blindsDown()
        {
            if(blindsAreDown)
                Console.WriteLine("Blinds are already down");
            else
            {
                Console.WriteLine("Blind was rolled down");
                blindsAreDown = true;
            }
        }
        public void blindsUp()
        {
            if (!blindsAreDown)
                Console.WriteLine("Blind was already up");
            else
            {
                Console.WriteLine("Blinds are rolled up");
                blindsAreDown = false;
            }
        }
    }
}
