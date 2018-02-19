using System;
namespace CSProject
{
    public class Staff
    {
        private float _hourlyRate;
        private int _hWorked;

        public float TotalPay { get; protected set; }
        public float BasicPay { get; private set; }
        public string NameOfStaff { get; private set; }

        public int HoursWorked
        {
            get
            {
                return _hWorked;
            }
            set
            {
                if (value > 0)
                {
                    _hWorked = value;
                }
                else
                {
                    _hWorked = 0;
                }
            }
        }

        public Staff (string name, float rate)
        {
            _hourlyRate = rate;
            NameOfStaff = name;
                
        }

        public virtual void CalculatePay()
        {
            Console.WriteLine("Calculating Pay...");

            BasicPay = _hWorked * _hourlyRate;
            TotalPay = BasicPay;
        }

        public override string ToString()
        {
            return string.Format("[Staff: TotalPay={0}, BasicPay={1}, NameOfStaff={2}, HoursWorked={3}]", TotalPay, BasicPay, NameOfStaff, HoursWorked);
        }
    }
}
