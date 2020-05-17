using System;
using System.Reflection;

namespace MyPratice
{
    class Program
    {
        static void Main(string[] args)
        {

            Array a = new Array();
            //a.SetArray();
            //a.LoopThroughArray();
            //a.nameprint("Deepti");
            //a.namearray();
            //a.reversename();


            EvenOdd e = new EvenOdd();
            //e.EvenorOdd();
            //e.even();
            //e.odd();
            //e.table();

            MathematicalOperators r = new MathematicalOperators();
            //r.addmethod(5, 7);
            //r.subtraction(6, 8);

            Pyramid p = new Pyramid();
            //p.starpattern();
            //p.reversestarpattern();

            ContiguousSubarray s = new ContiguousSubarray();
            int[] b = new int[8] { -2, -3, 4, -1, -2, 1, 5, -3 };
           // s.SumOfContiguousSubarray(b);


            Findtheduplicate fd = new Findtheduplicate();
            //int[] d = new int[5] { 3, 1, 2, 1, 4 };
            //fd.findduplicate(d);

            FindmissingInteger fm = new FindmissingInteger();
            //Console.WriteLine(fm.missinginteger());
            //fm.missinginteger();

            ContinousSubarray cs = new ContinousSubarray();
            //cs.continoussubarray();

            FindASubarray f = new FindASubarray();
            //f.findAsubarray();

            SortAnArray sa = new SortAnArray();
            //int[] san = new int[] { 0, 1, 2, 1,2,0,2,0,1 ,0};
            //sa.sortanarray(san);

            //EquilibriumIndex eq = new EquilibriumIndex();
            //int[] Array = new int[] { -7, 1, 5, 2, -4, 3, 0 };
            //int n = Array.Length;
            //Console.WriteLine(eq.equilibriumIndex(Array,7));

            //LeadersArray la = new LeadersArray();
            //la.leaderArray();

            //SmallestElement sr = new SmallestElement();
            //int[] smallarray = new int[] { 7, 10, 4, 3, 20, 15 };
            //int k = 3;
            //Console.Write("The K'th smallest element in given array is " + sr.smallestElement(smallarray, k));

            //CountFrequencyUsingDictionaMy cf = new CountFrequencyUsingDictionaMy();
            ////cf.CalcFreq();

            //dimensional dr = new dimensional();
            ////dr.twodimensionalarray();
            ////dr.Threedimensional();

            SpiralForm sp = new SpiralForm();
            sp.printinSpiralForm();





            Console.ReadLine();

           

           


           
        
            
        }
    }
}

