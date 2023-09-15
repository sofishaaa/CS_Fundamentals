using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doctors
{
    public class Surgeon : Doctor
    {
        private int operationsCount;
        public int OperationsCount
        {
            get { return operationsCount; }
            set { operationsCount = value; }
        }

        public Surgeon(string name, string gender, int age, string specialization, int experienceYear, int salary, int operationsCount)
            : base(name, gender, age, specialization, experienceYear, salary)
        {
            this.operationsCount = operationsCount;
        }
    }
}
