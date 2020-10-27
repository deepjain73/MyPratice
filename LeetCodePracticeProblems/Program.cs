using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace LeetCodePracticeProblems
{
    class Program
    {
        static void Main(string[] args)
        {
           

            //int[] nums = { 2, 2, 1 };
            //Dictionary<int,int> d = new Dictionary<int,int>();

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (d.ContainsKey(nums[i]))
            //    {
            //        d[nums[i]] = d[nums[i]] + 1;
            //    }

            //    else
            //    {
            //        d.Add(nums[i], 1);
            //    }
            //}

            //foreach (var j in d)
            //{
            //    if (j.Value == 1)
            //    {
            //        Console.WriteLine(j.Key);
            //    }
            //}
            // int[] nums = { 1, 2, 3, 4, 5, 6, 7 };
            // int k = 3;

            //for(int i = 0; i<k; i++)
            // {
            //     int temp = nums[nums.Length - 1];

            //     for(int j = nums.Length-2; j >= 0; j--)
            //     {
            //         nums[j+1] = nums[j];
            //     }

            //     nums[0] = temp;
            // }

            //foreach(var t in nums)
            // {
            //     Console.WriteLine(t);
            // }

            //int[] prices = { 7, 1, 5, 3, 6, 5 };
            //int profit = 0;

            //for (int i = 0; i < prices.Length-1; i++)
            //{
            //    if (prices[i + 1] > prices[i])
            //    {
            //        profit = profit + (prices[i + 1] - prices[i]);
            //    }
            //}

            //Console.WriteLine( profit);
            //int[] n = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };

            //int i = 0;
            //for(int j = 1;j<n.Length;j++)
            //{
            //    if (n[i] != n[j]) 
            //    {
            //        i++;
            //    }

            //    n[i] = n[j];
            //}

            //Console.WriteLine(i + 1);
            //GreatestNumberofCandies gc = new GreatestNumberofCandies();
            //int[] n = { 2, 8, 7 };
            //int k = 1;
            //gc.findgreatest(n, k);
            //Console.WriteLine(gc.KidsWithCandies(n, k));

            //FindRunningSumOf1DArray fd = new FindRunningSumOf1DArray();
            //int[] a = { 1, 1, 1, 1, 1 };
            //fd.runningsum(a);
            //var d = fd.RunningSum(a);
            //foreach(var j in d)
            //{
            //    Console.WriteLine(j);
            //}


            //DefangingAnIPAddress da = new DefangingAnIPAddress();
            //string s = "255.100.50.0";
            //Console.WriteLine(da.DefangIPaddr(s));

            //GoodPairs gp = new GoodPairs();
            //int[] n = { 1, 2, 3};
            //Console.WriteLine(gp.NumIdenticalPairs(n));

            //RemoveVowels rv = new RemoveVowels();
            //string s = "welcome to geeksforgeeks";
            //rv.removevow(s);

            //ShuffleTheArray sa = new ShuffleTheArray();
            //int[] s = { 2, 5, 1, 3, 4, 7 };
            //int n = 3;
            //Console.WriteLine(sa.Shuffle(s, n));

            //JewelsAndStones js = new JewelsAndStones();
            //string j = "aA";
            //string s = "aAAbbbb";
            //Console.WriteLine(js.NumJewelsInStones(j, s));

            //NumberOfStepsToReduce_ANumberToZero nm = new NumberOfStepsToReduce_ANumberToZero();
            //int n = 123;
            //Console.WriteLine(nm.NumberOfSteps(n));

            //SubtractTheProductAndSumOf_igitsOfAnInteger sp = new SubtractTheProductAndSumOf_igitsOfAnInteger();
            //int n = 4421;
            //Console.WriteLine(sp.SubtractProductAndSum(n));

            //NumbersSmallerThanTheCurrentNumber mn = new NumbersSmallerThanTheCurrentNumber();
            //int[] n = { 8, 1, 2, 2, 3 };
            //var v = mn.SmallerNumbersThanCurrent(n);

            //foreach (var i in v)
            //{
            //    Console.WriteLine(i);
            //}

            //DecompressRunLengthEncodedList rd = new DecompressRunLengthEncodedList();
            //int[] s = { 1, 2, 3, 4 };
            //var c = rd.DecompressRLElist(s);
            //foreach(var i in c)
            //{
            //    Console.WriteLine(i);
            //}

            //ReturnTargetArray rt = new ReturnTargetArray();
            //int[] s = { 0, 1, 2, 3, 4 };
            //int[] t = { 0, 1, 2, 2, 1 };
            //var f = rt.CreateTargetArray(s, t);

            //foreach (var i in f)
            //{
            //    Console.WriteLine(i);
            //}
            //rt.CreateTargetArray(s, t);

            //XOROperationinanArray xr = new XOROperationinanArray();
            //int c = 10, s = 5;

            //Console.WriteLine(xr.XorOperation(c, s));

            //SplitaStringinBalancedStrings ss = new SplitaStringinBalancedStrings();
            //string s = "RLRRRLLRLL";
            //Console.WriteLine(ss.BalancedStringSplit(s));

            //FindLonelyNode fn = new FindLonelyNode();
            //FindLonelyNode.Node root = new FindLonelyNode.Node(1);
            //root.left = new FindLonelyNode.Node(2);
            //root.right = new FindLonelyNode.Node(3);
            //root.left.right = new FindLonelyNode.Node(4);
            //root.right.left = new FindLonelyNode.Node(5);
            //root.right.left.right = new FindLonelyNode.Node(6);
            //fn.findlonelynode(root);

            //RangeSumOfBst rs = new RangeSumOfBst();
            //RangeSumOfBst.Node root = new RangeSumOfBst.Node(10);
            //int l = 7, r = 15;
            //Console.WriteLine(rs.RangeSumBST(root, l, r));

            //findanagrammappings fm = new findanagrammappings();
            //int[] a = { 12, 28, 46, 32, 50 };
            //int[] b = { 50, 12, 32, 46, 28 };
            //fm.findanamap(a, b);

            //EvenNumberofDigits ed = new EvenNumberofDigits();
            //int[] nums = { 12, 345, 2, 6, 7896 };
            //Console.WriteLine(ed.FindNumbers(nums));


            //Convert_Binary_Number_in_a_Linked_List_to_Integer cl = new Convert_Binary_Number_in_a_Linked_List_to_Integer();
            //Convert_Binary_Number_in_a_Linked_List_to_Integer.Node head = new Convert_Binary_Number_in_a_Linked_List_to_Integer.Node(1);
            //Convert_Binary_Number_in_a_Linked_List_to_Integer.Node n = new Convert_Binary_Number_in_a_Linked_List_to_Integer.Node(0);
            //head.next = n;
            //Convert_Binary_Number_in_a_Linked_List_to_Integer.Node n1 = new Convert_Binary_Number_in_a_Linked_List_to_Integer.Node(0);
            //n.next = n1;
            //Convert_Binary_Number_in_a_Linked_List_to_Integer.Node n2 = new Convert_Binary_Number_in_a_Linked_List_to_Integer.Node(1);
            //n1.next = n2;
            //Convert_Binary_Number_in_a_Linked_List_to_Integer.Node n3 = new Convert_Binary_Number_in_a_Linked_List_to_Integer.Node(0);
            //n2.next = n3;
            //Convert_Binary_Number_in_a_Linked_List_to_Integer.Node n4 = new Convert_Binary_Number_in_a_Linked_List_to_Integer.Node(0);
            //n3.next = n4;
            //Convert_Binary_Number_in_a_Linked_List_to_Integer.Node n5 = new Convert_Binary_Number_in_a_Linked_List_to_Integer.Node(1);
            //n4.next = n5;
            //Convert_Binary_Number_in_a_Linked_List_to_Integer.Node n6 = new Convert_Binary_Number_in_a_Linked_List_to_Integer.Node(1);
            //n5.next = n6;
            //Convert_Binary_Number_in_a_Linked_List_to_Integer.Node n7 = new Convert_Binary_Number_in_a_Linked_List_to_Integer.Node(1);
            //n6.next = n7;
            //Convert_Binary_Number_in_a_Linked_List_to_Integer.Node n8 = new Convert_Binary_Number_in_a_Linked_List_to_Integer.Node(0);
            //n7.next = n8;
            //Convert_Binary_Number_in_a_Linked_List_to_Integer.Node n9 = new Convert_Binary_Number_in_a_Linked_List_to_Integer.Node(0);
            //n8.next = n9;
            //Convert_Binary_Number_in_a_Linked_List_to_Integer.Node n10 = new Convert_Binary_Number_in_a_Linked_List_to_Integer.Node(0);
            //n9.next = n10;
            //Convert_Binary_Number_in_a_Linked_List_to_Integer.Node n11 = new Convert_Binary_Number_in_a_Linked_List_to_Integer.Node(0);
            //n10.next = n11;
            //Convert_Binary_Number_in_a_Linked_List_to_Integer.Node n12 = new Convert_Binary_Number_in_a_Linked_List_to_Integer.Node(0);
            //n11.next = n12;
            //Convert_Binary_Number_in_a_Linked_List_to_Integer.Node n13 = new Convert_Binary_Number_in_a_Linked_List_to_Integer.Node(0);
            //n12.next = n13;

            //Console.WriteLine(cl.GetDecimalValue(head));

            //CountGoodTriplets cd = new CountGoodTriplets();
            //int[] a = { 3, 0, 1, 1, 9, 7 };
            //int x = 7, y = 2, z = 3;

            //Console.WriteLine(cd.countGoodTriplets(a, x, y, z));

            //MatrixDiagonalSum ms = new MatrixDiagonalSum();
            //int[,] s = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } } ;
            //int n = 3;

            //Console.WriteLine(ms.DiagonalSum(s,n));

            //ToLowerUpperCase tl = new ToLowerUpperCase();
            //Console.WriteLine("Input: ");
            //var a = Console.ReadLine();
            //Console.WriteLine("Lower Case: " + " " + tl.toLowerCase(a));
            //Console.WriteLine("Upper Case: " + " " + tl.toUpperCase(a));

            //IntersectionOfThreeSortedArrays st = new IntersectionOfThreeSortedArrays();
            //int[] a = { 1, 5, 10, 20, 40, 80 };
            //int[] b = { 6, 7, 20, 80, 100 };
            //int[] c = { 3, 4, 15, 20, 30, 70, 80, 120 };
            //st.FindIntersection(a, b, c);
            //st.findIntersection(a, b, c);

            //Cells_with_Odd_Values_in_a_Matrix cm = new Cells_with_Odd_Values_in_a_Matrix();
            //int n = 2, m = 3, x = 2;
            //int[,] a = new int[,] { { 0, 1 }, { 1, 1 } };
            //Console.WriteLine(cm.OddCells(n, m, a,x));

            Console.ReadLine();


        }
    }
}
