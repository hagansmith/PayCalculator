using System;
namespace CSProject
{
    public class Admin : Staff
    {
        private const float _overtimeRate = 15.5F;
        private const float _adminHourlyRate = 30;

        public float Overtime { get; private set; }

        public Admin(string name) : base(name, _adminHourlyRate)
        {
            
        }

        public override void CalculatePay()
        {
            base.CalculatePay();

            if (HoursWorked > 160)
            {
                Overtime = _overtimeRate * (HoursWorked - 160);
                TotalPay += Overtime;
            }
        }

        public override string ToString()
        {
            return string.Format("[Admin: Overtime={0}]", Overtime);
        }

    }
}
