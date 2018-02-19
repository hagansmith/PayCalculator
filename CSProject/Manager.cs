using System;
namespace CSProject
{
    public class Manager : Staff
    {
        private const float _managerHourlyRate = 50;

        public int _allowance { get; private set; };

        public Manager(string name) : base(name, _managerHourlyRate)
        {
            
        }

        public override void CalculatePay()
        {
            base.CalculatePay();
            _allowance = 1000;

            if (HoursWorked > 160)
            {
                TotalPay = HoursWorked * _managerHourlyRate + _allowance;
            }
        }

        public override string ToString()
        {
            return string.Format("[Manager: _allowance={0}]", _allowance);
        }
    }
}
