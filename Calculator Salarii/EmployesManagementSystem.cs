using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Salarii
{
    internal class EmployesManagementSystem
    {
        #region singleton
        private EmployesManagementSystem() 
        { 

        }
        private static EmployesManagementSystem instance = null;

        public static EmployesManagementSystem Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new EmployesManagementSystem();
                }
                return instance;
            }
        }
        #endregion

        private List<Employee> employees = new List<Employee>();

        public void AddEmployee (Employee employeeToAdd)
        {
            if(employeeToAdd == null)
            {
                throw new ArgumentNullException();
            }
            if(employees.FindAll(e => e.Id == employeeToAdd.Id).Count > 0) 
            {
                throw new EmployeeAlredayExistException();
            }

            employees.Add(employeeToAdd);
        }

        public void RemoveEmployee (Employee employeeToAdd) 
        {
            if (employeeToAdd == null)
            {
                throw new ArgumentNullException();
            }
            if (employees.FindAll(e => e.Id == employeeToAdd.Id).Count > 0)
            {
                throw new EmployeeDoesNotExistException();
            }

            employees.Remove(employeeToAdd);
        }

        public List<Employee> GetWellPayedEmployess(double  referenceSalary) => 
            this.employees.FindAll(e => e.Salary > referenceSalary);

        public List<Employee> GetMaxSalary()
        {
            var maxSalary = double.MinValue;
            employees.ForEach(e =>
            {
                if(e.Salary > maxSalary)
                {
                    maxSalary = e.Salary;
                }
                
            });
            return employees.FindAll(e => e.Salary == maxSalary);

        }

        public List<Employee> GetMaxSalary(string departament)
        {
            var maxSalary = double.MinValue;

          List<Employee> result = new List<Employee>();
            employees.ForEach(e =>
            {
                if (e.Departament != departament)
                {
                    return;
                }

                if(e.Salary > maxSalary &&  e.Departament == departament)
                {
                    maxSalary = e.Salary;
                    result.Clear();
                    result.Add(e);
                }
            });
            return result;
        }

        public double GetTotalCost()
        {
            double total = 0.0d;

            employees.ForEach(e => total += e.Salary);
            return total;
        }

        public double GetCostForDepartament(string departament)
        {
            double total = 0.0d;
            employees.FindAll(e => e.Departament == departament).ForEach(e => total += e.Salary);
            return total;
        }
        
    }
}
