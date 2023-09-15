using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doctors
{
    public class Neurologist : Doctor
    {
        public Neurologist(string name, string gender, int age, string specialization, int experienceYear, int salary)
            : base(name, gender, age, specialization, experienceYear, salary)
        {
        }

        public void PerformNeurologicalExamination()
        {
            try
            {
                Console.WriteLine("Neurologist is performing a neurological examination.");

                Console.WriteLine("Testing knee jerk reflex...");  //колінний рефлекс

                Random random = new Random();
                bool reflexResponse = random.Next(0, 2) == 0;

                if (reflexResponse)
                {
                    Console.WriteLine("Great! Normal reflex response observed.");
                }
                else
                {
                    Console.WriteLine("Abnormal reflex response observed!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred during the neurological examination: {ex.Message}");
            }
        }

    }
}
