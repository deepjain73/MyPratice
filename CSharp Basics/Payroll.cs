    using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Basics
{
    interface IPayroll
    {
        void pay();
    }
    class Payroll
    {
        List<IPayroll> payees = new List<IPayroll>();

        public Payroll()
        {
            payees.Add(new Teacher());
            payees.Add(new Teacher());
            payees.Add(new Principal());
            Logger.log("Payroll started","Payroll");

        }

        public void payall()
        {
            foreach (var p in payees)
            {
                p.pay();
            }

            Logger.log("Payall completed","Payroll",2);
        }
    }
}
