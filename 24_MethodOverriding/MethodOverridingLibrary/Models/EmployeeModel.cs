using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverridingLibrary.Models
{
    public class EmployeeModel : PersonModel
    {
        public decimal HourlyRate { get; set; } = 25;
        
        public virtual decimal GetPaycheckAmount(int hoursWorked)
        {
            return HourlyRate * hoursWorked;
        }
    }
}
