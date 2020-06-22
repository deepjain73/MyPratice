using System;
using System.Reflection;
using System.Collections.Generic;


namespace MyPratice
{
    class Program
    {
        static void Main(string[] args)
        {

            //Array a = new Array();
            //a.SetArray();
            //a.LoopThroughArray();
            //a.nameprint("Deepti");
            //a.namearray();
            //a.reversename();


            //EvenOdd e = new EvenOdd();
            //e.EvenorOdd();
            //e.even();
            //e.odd();
            //e.table();

            //MathematicalOperators r = new MathematicalOperators();
            //r.addmethod(5, 7);
            //r.subtraction(6, 8);

            //Pyramid p = new Pyramid();
            //p.starpattern();
            //p.reversestarpattern();

            //ContiguousSubarray s = new ContiguousSubarray();
            //int[] b = new int[8] { -2, -3, 4, -1, -2, 1, 5, -3 };
            //// s.SumOfContiguousSubarray(b);


            //Findtheduplicate fd = new Findtheduplicate();
            //int[] d = new int[] { 4,5,2,8,4,9,1,7};
            //Console.WriteLine(fd.findduplicate(d));

            //FindmissingInteger fm = new FindmissingInteger();
            //Console.WriteLine(fm.missinginteger());
            //fm.missinginteger();

            //ContinousSubarray cs = new ContinousSubarray();
            //cs.continoussubarray();

            //FindASubarray f = new FindASubarray();
            //f.findAsubarray();

            //SortAnArray sa = new SortAnArray();
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
            //cf.CalcFreq();

            //dimensional dr = new dimensional();
            ////dr.twodimensionalarray();
            ////dr.Threedimensional();

            //SpiralForm sp = new SpiralForm();
            //sp.printinSpiralForm();

            //DecreasingFrequency df = new DecreasingFrequency();
            //df.decreasingFrequency();

            //MyQueue<int> myqueue = new MyQueue<int>();
            ////myqueue.Enque(100);
            ////myqueue.Enque(20);
            ////myqueue.Enque(10);
            ////myqueue.Enque(3);

            ////int i = myqueue.Dque();
            ////Console.WriteLine(i);

            //myqueue.Enqueue(1);
            //myqueue.Enqueue(2);
            //myqueue.Enqueue(3);
            //myqueue.Enqueue(4);
            //myqueue.Enqueue(5);
            //myqueue.Dequeue();
            //myqueue.Dequeue();
            //myqueue.Enqueue(6);
            //myqueue.Enqueue(7);
            //myqueue.Enqueue(8);
            //myqueue.Enqueue(9);
            //myqueue.Enqueue(10);
            //myqueue.Dequeue();
            //myqueue.Enqueue(11);
            //myqueue.Enqueue(12);
            //myqueue.Enqueue(13);
            //myqueue.Enqueue(14);
            //myqueue.Enqueue(15);
            //myqueue.Enqueue(16);

            //foreach (var i in myqueue.array)
            //{
            //    Console.WriteLine(i);
            //}

            //NewQueue newQueue = new NewQueue();
            //newQueue.Enqueue("D");
            //newQueue.Enqueue("E");
            //newQueue.Enqueue("E");
            //newQueue.Enqueue("P");
            //newQueue.Enqueue("T");
            //newQueue.Enqueue("I");
            //newQueue.Dequeue();
            //newQueue.Dequeue();

            //foreach (var n in newQueue.array)
            //{
            //    Console.WriteLine(n);
            //}

            //Stack mystack = new Stack();
            //mystack.push(1);
            //mystack.push(2);
            //mystack.push(3);
            //mystack.push(4);
            //mystack.push(5);
            //mystack.pop();
            //mystack.push(6);
            //mystack.push(7);
            //mystack.push(8);
            //mystack.push(9);

            //////// Console.WriteLine(mystack.Peek());

            //foreach (var i in mystack.array)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine();

            //FibonacciRecursion fb = new FibonacciRecursion();

            ////fb.fibonaaci(5);
            ////Console.WriteLine(fb.fib(4));
            //Factorial ft = new Factorial();
            //Console.WriteLine(ft.Fact(4));

            //NextGreaterElement nx = new NextGreaterElement();
            //nx.printnextelement();

            //ImplementAQueue im = new ImplementAQueue();
            //im.push(1);
            //im.push(2);
            //im.push(3);
            //im.push(4);
            //Console.WriteLine(im.pop());
            //im.push(5);
            //Console.WriteLine(im.pop());
            //Console.WriteLine(im.pop()); Console.WriteLine(im.pop()); Console.WriteLine(im.pop());
            //Console.WriteLine(im.pop());


            //ImplementAQueueUsingStack iq = new ImplementAQueueUsingStack();
            //iq.enqueue(1);
            //iq.enqueue(2);
            //iq.enqueue(3);
            //iq.enqueue(4);

            //Console.WriteLine(iq.dequeue());
            //iq.enqueue(5);
            //Console.WriteLine(iq.dequeue());
            //Console.WriteLine(iq.dequeue());
            //Console.WriteLine(iq.dequeue());
            //Console.WriteLine(iq.dequeue());


            ImplementAStackUsingQueue si = new ImplementAStackUsingQueue();

            //si.push(1);
            //si.push(2);
            //si.push(3);
            //si.push(4);
            //si.push(5);
            //Console.WriteLine(si.pop());
            //Console.WriteLine(si.pop());
            //Console.WriteLine(si.pop());
            //Console.WriteLine(si.pop());
            //Console.WriteLine(si.pop());

            FindMinElement f = new FindMinElement();
            //f.push(3);
            //f.push(7);
            //f.push(5);
            //f.getmin();
            //f.push(2);
            //f.push(1);
            //f.getmin();
            //f.pop();
            //f.pop();
            ////f.pop();
            ////f.pop();
            ////f.pop();


            //Console.WriteLine(f.getmin());

            //LinkedList ll = new LinkedList();
            //ll.head = new LinkedList.Node(1);

            //LinkedList.Node n1 = new LinkedList.Node(100);
            //ll.head.next = n1;

            //LinkedList.Node n2 = new LinkedList.Node(200);
            //n1.next = n2;


            //LinkedList.Node n3 = new LinkedList.Node(300);
            //n2.next = n3;

            //LinkedList.Node n1_1 = new LinkedList.Node(150);
            //n1.next = n1_1;
            //n1_1.next = n2;


            //ll.printList(ll.head);
            ////Console.WriteLine("print alternate");
            ////ll.printAlternateItemInList(ll.head);
            ////n1_1.next = n3;
            ////ll.printList(n1);

            //ll.printNthNodeValue(ll.head,5);


            ////DoublyLinkedList dl = new DoublyLinkedList();
            ////dl.head = new DoublyLinkedList.Node(1);

            //LRUCache lr = new LRUCache(4);
            //lr.set(1, 10);
            //lr.set(2, 20);
            //lr.set(1, 30);
            //Console.WriteLine("Value for the key: 1 is " + lr.get(1));
            //lr.set(4, 40);
            //lr.set(5, 45);
            ////Console.WriteLine("Value for the key: 1 is " + lr.get(1));
            //lr.set(6, 50);

            //Console.WriteLine("Value for the key: 2 is " + lr.get(2));
            //Console.WriteLine("Value for the key: 3 is " + lr.get(3));

            //Console.WriteLine("Value for the key: 1 is " + lr.get(1));
            //Console.WriteLine("Value for the key: 2 is " + lr.get(2));
            //Console.WriteLine("Value for the key: 3 is " + lr.get(3));
            //Console.WriteLine("Value for the key: 4 is " + lr.get(4));
            //Console.WriteLine("Value for the key: 5 is " + lr.get(5));
            //Console.WriteLine("Value for the key: 6 is " + lr.get(6));
            //Console.WriteLine("Value for the key: 7 is " + lr.get(7));



            //NonRepeatingChar nr = new NonRepeatingChar();
            //nr.firstnonrepeatingch('a');
            //nr.firstnonrepeatingch('a');
            //nr.firstnonrepeatingch('c');
            //nr.firstnonrepeatingch('d');
            //nr.firstnonrepeatingch('d');
            //nr.firstnonrepeatingch('c');
            //nr.firstnonrepeatingch('y');
            //nr.firstnonrepeatingch('d');

            //Palindrome pm = new Palindrome();
            //string S = "madam";
            //pm.palindrome(S);

            //LongestPalidromic lp = new LongestPalidromic();
            //string S = "babad";
            //lp.findlps(S);
            //string s = "ABCDEFGHIJ";
            //Console.WriteLine(s.Substring(1,2));
            //Console.WriteLine(s.Substring(2, 2));
            //Console.WriteLine(s.Substring(3, 2));

            //Reversestring rs = new Reversestring();
            //rs.reversestring();

            //RemoveDuplicates rm = new RemoveDuplicates();
            //string t = "azxxzy";
            //int i = 0;
            //rm.removeduplicate();

            //RotatingString rs = new RotatingString();

            //string a = "amazon", b = "onamaz";//anticlock
            //string a1 = "amazon", b1 = "onamaz"; //clockwise

            //if (rs.rotatestring(a, b, 2))
            //{
            //    Console.WriteLine("Anticlockwise Rotated");
            //    //Console.WriteLine("Clockwise Rotated");
            //}
            //else
            //{
            //    Console.WriteLine("Anticlockwise NOT Rotated");
            //    Console.WriteLine("Clockwise not Rotated");
            //}

            // RomanToIntConversion rc = new RomanToIntConversion();
            // //rc.romantoint("2");
            // //rc.romantoint("V");
            ////rc.romantoint("III");
            // rc.romantoint("VIII");
            // // rc.romantoint("MCMIV");

            // LCSubstring lc = new LCSubstring();
            // lc.findlcs();

            // Longestsubstringwithoutdup lp = new Longestsubstringwithoutdup();
            // lp.findlswithoutdup();

            //ImplementAtoi im = new ImplementAtoi();
            //Console.WriteLine( im.atoi());

            //ImplementStrStr sr = new ImplementStrStr();
            //Console.WriteLine(sr.strstr());

            //LongestCP lc = new LongestCP();
            //lc.findlcp();


            //test t = new test();
            //if(t.findroating(2))
            //{
            //    Console.WriteLine("isrotating");
            //}
            //else
            //{
            //    Console.WriteLine("notrotating");
            //}
            //URL_shortner us = new URL_shortner();
            //var code = us.decode("aaa");
            //var output = us.encode(code);
            //Console.WriteLine(output);       
            //Console.ReadLine();

            ShortURL su = new ShortURL();
            Console.WriteLine(su.getshortURL("www.google.com"));
            Console.WriteLine(su.getshortURL("www.microsoft.com"));
            Console.WriteLine(su.getshortURL("www.google.com"));









        }
    }
}

