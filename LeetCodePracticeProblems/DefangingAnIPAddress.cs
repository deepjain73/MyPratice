using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePracticeProblems
{
    class DefangingAnIPAddress
    {
        public string DefangIPaddr(string address)
        {
            string s = " ";

            for(int i = 0; i<address.Length; i++)
            {
                if(address[i] == '.')
                {
                    s = s + "[.]";
                }

                else
                {
                    s = s + address[i];
                }
            }

            return s;
        }
    }
        
            
}
