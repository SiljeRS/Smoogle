﻿using System;
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
            if(lightIsOn)
                Console.WriteLine("Light is already");
        }
    }
}