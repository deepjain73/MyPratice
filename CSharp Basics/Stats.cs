using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Basics
{
    class Stats
    {
        public void start()
        {
            Program.Posted += hasposted;
        }

        private void hasposted()
        {
            Console.WriteLine("Survey posted,run stats");
        }
    }
}
