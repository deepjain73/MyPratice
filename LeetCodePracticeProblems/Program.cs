using System;


namespace LeetCodePracticeProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            //GreatestNumberofCandies gc = new GreatestNumberofCandies();
            //int[] n = { 2, 8, 7 };
            //int k = 1;
            //gc.findgreatest(n, k);
            //Console.WriteLine(gc.KidsWithCandies(n, k));

            //FindRunningSumOf1DArray fd = new FindRunningSumOf1DArray();
            //int[] a = { 1, 1, 1, 1, 1 };
            //fd.runningsum(a);

            //Console.ReadLine();

            //DefangingAnIPAddress da = new DefangingAnIPAddress();
            //string s = "255.100.50.0";
            //Console.WriteLine(da.DefangIPaddr(s));

            //GoodPairs gp = new GoodPairs();
            //int[] n = { 1, 2, 3};
            //Console.WriteLine(gp.NumIdenticalPairs(n));

            //RemoveVowels rv = new RemoveVowels();
            //string s = "welcome to geeksforgeeks";
            //rv.removevow(s);

            ShuffleTheArray sa = new ShuffleTheArray();
            int[] s = { 2, 5, 1, 3, 4, 7 };
            int n = 3;
            Console.WriteLine(sa.Shuffle(s, n));
        }
    }
}
