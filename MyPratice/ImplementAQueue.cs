using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;


namespace MyPratice
{
   public class ImplementAQueue
    {
        //Stack S1, S2; 
        System.Collections.Stack S1, S2;
        public ImplementAQueue()
        {
            S1 = new System.Collections.Stack();
            S2 = new System.Collections.Stack();           
        }
        public void push(int data)
        {
            S1.Push(data);
        }                
        public int pop()
        {
            if(S1.Count==0)
            {
                throw new Exception("No more items to return");
            }
            //1
            while(S1.Count != 0)
            { 
                S2.Push(S1.Pop());                
            }
            //2
            var popvalue = S2.Pop();
            //3
            while(S2.Count != 0)
            {
                S1.Push(S2.Pop());
            }
            return  int.Parse(popvalue.ToString());          
        }
    }
}
