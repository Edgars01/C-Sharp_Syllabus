using System;
using System.Collections.Generic;
using System.Text;

namespace Firm
{
    internal class Commission : Hourly
    {
        private double _totalSales;
        private double _commissionRateForEmployee;

        public Commission(string eName, string eAddress, string ePhone, string socSecNumber, double rate, double commissionRateForEmployee) 
            : base(eName, eAddress, ePhone, socSecNumber, rate)
        {
            _commissionRateForEmployee = commissionRateForEmployee;
        }

        public void AddSales(double totalSales)
        {
            _totalSales += totalSales;
        }

        public override double Pay()
        {
            return base.Pay() + _commissionRateForEmployee * _totalSales;
        }

        public override string ToString()
        {
            var sales = base.ToString();
            sales += "\nCurrent hours: " + _totalSales; 
            return sales;
        }
    }
}
