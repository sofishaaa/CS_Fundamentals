using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doctors
{
    public class Cardiologist : Doctor
    {
        public Cardiologist(string name, string gender, int age, string specialization, int experienceYear, int salary)
            : base(name, gender, age, specialization, experienceYear, salary)
        {
        }

        public void MeasureBloodPressure()
        {
            try
            {
                Console.WriteLine("Cardiologist makes measure blood pressure.");

                Random random = new Random();
                int heartRate = random.Next(60, 100);

                Console.WriteLine($"Patient's heart rate is {heartRate} beats per minute.");

                if (heartRate < 60)
                {
                    Console.WriteLine("Patient's heart rate is too low!");
                }
                else if (heartRate > 100)
                {
                    Console.WriteLine("Patient's heart rate is too high!");
                }
                else
                {
                    Console.WriteLine("Good! Patient's heart rate is within the normal range.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

        }
    }
}
