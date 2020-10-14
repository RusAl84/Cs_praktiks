using System;
using System.Collections.Generic;
using System.Text;

namespace prakt4_01
{
    abstract class kreppa
    {
        public string name;
        abstract  int bolt;

        public kreppa(string name, int bolt)
        {
            this.name = name;
            ///this.bolt = bolt;
        }

    }
}
