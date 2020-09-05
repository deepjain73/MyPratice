using System;
using System.Collections.Generic;
using System.Text;

namespace MyPratice
{
    class FindValidEmailAddress
    {

        //        Given a list of strings, return a list of strings that are valid email addresses

        string[] input = {"b", "c*", "a.com", "b@c.com", "c@a.edu", "c@d"};
        //output - {"b@c.com", "c@a.edu"}

        //valid - <alphanumeric>@<alphanumeric>.<{com, edu, org
           //}>;
         //invalidcharlist = {'#', '*', ';'};

        public List<string> returnValid(List<string> list)
        {

            
            List<string> returnlist = new List<string>();
            foreach (string s in list)
            {
                if (findvalidemailadd(s))
                {

                    returnlist.Add(s);
                }
            }

            return returnlist;
        }




          public bool findvalidemailadd(string s)
          {

            if (s == null)
            {
                Console.WriteLine("String is empty");
             }

            string[] checkforat = s.Split('@');
            if (checkforat.Length != 2)
            {
              return false;
            }

            //checkforat[0] = a
            //checkforat[1] = b.com

            string[] checkfordot = checkforat[1].Split('.');
             if (checkfordot.Length != 2)
             {
                return false;
             }

    //checkfordot[0] = b
    //checkfordot[1] = com

    // is checkforat[0] a valid alphanumeric string
    // is checkfordot[0] a valid alphanumeri string
    // is checkfordot[1] a string in this list {com, edu, org}

    //if (checkforat[0] == invalidcharlist) // if checkforat[0] is not valid alphanumeric  
    //{
    //    return false;
    //}

    //if (checkfordot[0] == invalidcharlist) // if checkfordot[0] is not valid alphanumeric 
    //{
    //    return false;
    //}

    if ((checkfordot[1] == "com") || (checkfordot[1] == "edu") || (checkfordot[1] == "org"))
     {
        return true; // a@b.com
    }

    // a@b.sdfsdf
    return false;

}
    }
}
