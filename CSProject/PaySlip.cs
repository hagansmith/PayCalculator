using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CSProject
{
    public class PaySlip
    {
        private int _month;
        private int _year;
        enum MonthsOfYear
        {
            JAN = 1,
            FEB,
            MAR,
            APR,
            MAY,
            JUN,
            JUL,
            AUG,
            SEP,
            OCT,
            NOV,
            DEC
        }

        public void GeneratePaySlip(List<Staff> myStaff)
        {
            string path;
            foreach (Staff f in myStaff)
            {
                path = f.NameOfStaff + ".txt";
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine("PAYSLIP FOR {0} {1}", (MonthsOfYear)_month, _year);
                    sw.WriteLine("==================================");
                    sw.WriteLine("Name of Staff: {0}", f.NameOfStaff);
                    sw.WriteLine("Hours Worked: {0}", f.HoursWorked );
                    sw.WriteLine("");
                    sw.WriteLine("Basic Pay: {0}", f.BasicPay);
                    if (f.GetType().ToString() == "Manager") 
                    {
                         ((Manager)f).Allowance;
                    }
                    else
                    {
                        ((Admin)f).Overtime;
                    }
                    sw.WriteLine("");
                    sw.WriteLine("==================================");
                    sw.WriteLine("Total Pay: {0}", f.TotalPay);
                    sw.WriteLine("==================================");
                    sw.Close();
                }
            };
        }

        public void GenerateSummary(List<Staff> staffs)
        {
            var result = from staff in staffs
                         where staff.HoursWorked < 10
                         orderby staff.NameOfStaff
                         select staff;
        }


        public PaySlip(int payMonth, int payYear)
        {
            _month = payMonth;
            _year = payYear;
        }
    }
}
