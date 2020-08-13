using System;
using System.Collections.Generic;
using System.Text;

namespace MyPratice
{
    public class Array
    {
        int[] rollno;
        public void SetArray()
        {
            rollno = new int[10]; /*{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };*/   //array initailization
            rollno[0] = 1;
            rollno[1] = 2;
            rollno[2] = 3;
            rollno[3] = 4;
            rollno[4] = 5;
            rollno[5] = 6;
            rollno[6] = 7;
            rollno[7] = 8;
            rollno[8] = 9;
            rollno[9] = 10;

            // for (int i = 0; i < 10; Console.WriteLine(i), i++);
        }

        public void LoopThroughArray()
        {
            // for loop:
            for (int i = 0; i < rollno.Length; i++)
            {
                Console.WriteLine(rollno[i]);
            }

            ////foreach:
            foreach (int ii in rollno)
                Console.WriteLine(ii);

            ////while loop:
            int i1 = 0;
            while (i1 < rollno.Length)
            {
                Console.WriteLine(rollno[i1]);
                i1++;
            }

            ///do while loop:
            Console.WriteLine("Now doing do while loop");
            int di = 0;
            do
            {
                Console.WriteLine(rollno[di]);
                di++;
            }
            while (di < rollno.Length);

            //   

            // for loop:
            Console.WriteLine("for loop");
            string[] daysofweek = new string[7] { "Sunday", "ronday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

            for (int i = 0; i < daysofweek.Length; i++)
            {
                Console.WriteLine(daysofweek[i]);
            }

            // for each loop:
            Console.WriteLine("for each");
            foreach (string i in daysofweek)
                Console.WriteLine(i);

        }

        string[] name = new string[6] { "D", "E", "E", "P", "T", "I" };
        public void namearray()
        {
            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }
        }

        public void nameprint(string name)
        {
            Console.WriteLine("Hello" + " " + name);
        }

        public void reversename()
        {
            for (int i = name.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(name[i]);
            }
        }



        public void PlusOne(int[] digits)
        {

            if (digits == null)
            {
                return;
            }
            int carry = 0, output = 0;
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (i == digits.Length - 1)
                {
                    output = digits[i] + 1 + carry;
                }
                else
                    output = digits[i] + carry;

                if (output >= 10)
                {
                    carry = output / 10;
                    output = output % 10;
                    digits[i] = output;
                }
                else
                {
                    digits[i] = output;
                    break;
                }
            }
            for (int i = 0; i < digits.Length; i++)
                Console.Write(digits[i].ToString() + " ");





        }

        public void reverse(string s)
        {
            char[] c = s.ToCharArray();

            for (int i = 0; i < c.Length/2 ; i++)
            {
                char tmp = c[i];
                c[i] = c[c.Length - 1 - i];
                c[c.Length - 1 - i] = tmp;

            }
            Console.WriteLine(c);
        }

        public bool palindrome(string s)
        {
            char[] c = s.ToCharArray();
            int n = c.Length;

            for (int i = 0; i < n / 2; i++)
            {
                if (c[i] != c[n - 1 - i])
                {
                    return false;
                }
            }

            return true;

        }

        public int binarysearch(int[] s, int target)
        {
            int mid, low = 0, high = s.Length - 1;

            while (low <= high)
            {
                mid = (low + high) / 2;

                if (s[mid] == target)
                {
                    return mid;
                }

                if (target > s[mid])
                {
                    low = mid + 1;
                }

                else
                {
                    high = mid - 1;
                }
            }

            return -1;
        }

        public int binarysearch1(int[] s, int target, int l, int h)
        {
            if (l <= h)
            {
                int mid;

                mid = (l + h) / 2;

                if (s[mid] == target)
                {
                    return mid;
                }

                if (target > s[mid])

                    return binarysearch1(s, target, mid + 1, h);

                else

                return binarysearch1(s, target, l, mid - 1);

            }
            return -1;


        }

        public void reverse1(char[] c,int start, int end)
        {
            for (int i = start, j = end; i <= (start + end) / 2 ; i++,j--)
            {
                char temp = c[i];
                c[i] = c[j];
                c[j] = temp;
            }

            
        }

        public void stringhandling(char[] s)
        {
            int k=0, j=0;
            for ( k = 0; k < s.Length; k++, j++)
            {   
                //just forward j until you find space or end of array
                while (j <s.Length && s[j] != ' ')
                    j++;
                //reverse using start and end index
                reverse1(s, k, j-1);

                //forward k to j and then k++ will move it to next char after space
                k = j;               
            }
            //print array
            Console.WriteLine(s);
            //call reverse on full array
            reverse1(s, 0, s.Length-1);

        }

        public void selectionsort(int[] s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i + 1; j < s.Length; j++)
                {
                    if (s[j] < s[i])
                    {
                        int temp = s[i];
                        s[i] = s[j];
                        s[j] = temp;
                    }
                }

            }
        }

    }
}
    

    
            