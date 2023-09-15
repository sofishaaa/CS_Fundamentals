using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doctors
{
    public class Doctor : Person
    {
        private string specialization;
        private int experienceYear;
        private int salary;

        public string Specialization { get; set; }

        public int ExperienceYear
        {
            get { return experienceYear; }
            set { experienceYear = value; }
        }

        public int Salary { get; set; }

        public Doctor(string name, string gender, int age, string specialization, int experienceYear, int salary) 
            : base(name, gender, age)
        {
            try
            {
                if (string.IsNullOrEmpty(specialization))
                {
                    throw new ArgumentException("Specialization cannot be null or empty.", nameof(specialization));
                }

                if (experienceYear < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(experienceYear), "Experience year cannot be negative.");
                }

                if (salary < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(salary), "Salary cannot be negative.");
                }

                this.specialization = specialization;
                this.experienceYear = experienceYear;
                this.salary = salary;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"ArgumentOutOfRangeException: {ex.Message}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"ArgumentException: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }
    }
}
