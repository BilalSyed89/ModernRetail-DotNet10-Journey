using System;
using System.Collections.Generic;
using System.Text;

namespace Packt.Shared
{
 public class EMployee : Person
    {

        public string? EmployeeCode { get; set; }
        public DateOnly HireDate { get; set; }



        public override void WriteToConsole()
        {
            WriteLine(format:
              "{0} was born on {1:dd/MM/yy} and hired on {2:dd/MM/yy}...",
     
        
              arg0: Name2, arg1: Born2, arg2: HireDate);
        }
    }

}

