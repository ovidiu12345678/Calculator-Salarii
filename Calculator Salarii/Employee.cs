using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Salarii
{
    internal class Employee
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public int Salary { get; private set; } 
        public string Departament { get; private set; }

        public Employee()
        {
            this.Id = Guid.NewGuid();     
        }

        public override string ToString()
            => $"Employee Id : {Id} Name : {Name} Salary : {Salary} Departament : {Departament} ";
        
    }
}
