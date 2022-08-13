using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverridingLibrary.Models
{
    public class CommissionEmployeeModel : EmployeeModel
    {
        public decimal CommissionAmount { get; set; } = 100;

        public override decimal GetPaycheckAmount(int hoursWorked)
        {
            decimal initialPay = base.GetPaycheckAmount(hoursWorked);   
            return initialPay + CommissionAmount;                       
        }
    }
}
