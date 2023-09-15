using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doctors
{
    public class Pediatrician : Doctor
    {

        private int declaredPatients;
        public int DeclaredPatients
        {
            get { return declaredPatients; }
            set { declaredPatients = value; }
        }

        public Pediatrician(string name, string gender, int age, string specialization, int experienceYear, int salary, int declaredPatients)
            : base(name, gender, age, specialization, experienceYear, salary)
        {
            this.declaredPatients = declaredPatients;
        }
    }
}
