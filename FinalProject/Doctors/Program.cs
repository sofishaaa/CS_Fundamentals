using System;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Xml.Serialization;
using System.Runtime.Serialization;

namespace Doctors
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                string[] lines = File.ReadAllLines(@"Z:\Desktop\doctors.txt");

                List<Doctor> doctors = new List<Doctor>();
                List<Surgeon> surgeons = new List<Surgeon>();
                List<Pediatrician> pediatricians = new List<Pediatrician>();


                foreach (string line in lines)
                {
                    string[] parts = line.Split(" - ");

                    if (parts.Length == 7)
                    {
                        string name = parts[0];
                        string gender = parts[1];
                        int age = int.Parse(parts[2]);
                        string specialization = parts[3];
                        int experienceYear = int.Parse(parts[4]);
                        int salary = int.Parse(parts[5]);
                        int value6 = int.Parse(parts[6]);

                        if (specialization == "surgeon")
                        {
                            Surgeon surgeon = new Surgeon(name, gender, age, specialization, experienceYear, salary, value6);
                            surgeons.Add(surgeon);
                        }
                        else if (specialization == "pediatrician")
                        {
                            Pediatrician pediatrician = new Pediatrician(name, gender, age, specialization, experienceYear, salary, value6);
                            pediatricians.Add(pediatrician);
                        }
                    }
                }

                List<Surgeon> qualifiedSurgeons = surgeons.Where(surgeon => surgeon.OperationsCount > 1000 && surgeon.ExperienceYear > 5).ToList();
                List<Pediatrician> qualifiedPediatricians = pediatricians.Where(pediatrician => pediatrician.DeclaredPatients > 1000).ToList();

                using (StreamWriter writer = new StreamWriter(@"Z:\Desktop\surgeons.txt"))
                {
                    foreach (var surgeon in qualifiedSurgeons)
                    {
                        writer.WriteLine($"{surgeon.Name}, {surgeon.Age}, {surgeon.ExperienceYear}, {surgeon.OperationsCount}");
                    }
                }

                using (StreamWriter writer = new StreamWriter(@"Z:\Desktop\pediatricians.txt"))
                {
                    foreach (var pediatrician in qualifiedPediatricians)
                    {
                        writer.WriteLine($"{pediatrician.Name}, {pediatrician.Age}, {pediatrician.DeclaredPatients}");
                    }
                }

                Console.WriteLine($"Surgeons count with > 1000 operations and > 5 years experience: {qualifiedSurgeons.Count}");
                Console.WriteLine($"Pediatricians count with > 1000 declared patients: {qualifiedPediatricians.Count}");

                Console.WriteLine("-----------------------");
                Console.WriteLine("<<<<<----------------------->>>>>");


                List<Person> persons = new List<Person>();
                persons.Add(new Person("John", "male", 30));
                persons.Add(new Person("Sophie", "female", 25));

                foreach (var person in persons)
                {
                    person.DisplayPersonInfo();
                }

                Console.WriteLine("-----------------------");
                Console.WriteLine("<<<<<----------------------->>>>>");


                List<Neurologist> neurologists = new List<Neurologist>();
                neurologists.Add(new Neurologist("Ostap", "male", 38, "neurology", 15, 8000));
                neurologists.Add(new Neurologist("Melaniia", "female", 44, "neurology", 12, 7500));

                foreach (var neurologist in neurologists)
                {
                    neurologist.PerformNeurologicalExamination();
                }

                Console.WriteLine("-----------------------");
                Console.WriteLine("<<<<<----------------------->>>>>");


                List<Cardiologist> cardiologists = new List<Cardiologist>();
                cardiologists.Add(new Cardiologist("Smith", "female", 39, "cardiology", 10, 6000));
                cardiologists.Add(new Cardiologist("Johnson", "female", 45, "cardiology", 16, 7500));

                foreach (var cardiologist in cardiologists)
                {
                    cardiologist.MeasureBloodPressure();
                }

                Console.WriteLine("-----------------------");
                Console.WriteLine("<<<<<----------------------->>>>>");


                Prescription prescription1 = new Prescription("Drug145", DateTime.Parse("2023-09-11"), DateTime.Parse("2024-09-11"));

                if (prescription1.IsExpired())
                {
                    Console.WriteLine("Prescription has expired.");
                }
                else
                {
                    Console.WriteLine("Prescription is still valid.");
                }

                Console.WriteLine("-----------------------");
                Console.WriteLine("<<<<<----------------------->>>>>");


                //XML
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Prescription));
                using (Stream stream = new FileStream("prescription.xml", FileMode.Create))
                {
                    xmlSerializer.Serialize(stream, prescription1);
                }

                using (Stream stream = new FileStream("prescription.xml", FileMode.Open))
                {
                    Prescription deserializedPrescription = xmlSerializer.Deserialize(stream) as Prescription;
                    Console.WriteLine();
                    Console.WriteLine("XML file is ready");
                    stream.Close();
                }

                Console.WriteLine("-----------------------");
                Console.WriteLine("<<<<<----------------------->>>>>");

            }
            catch (IOException exc)
            {
                Console.WriteLine($"An IO error occured: {exc.Message}");
                Console.WriteLine("Please check if the file exists");
                Console.WriteLine("____________");
            }
            catch (SerializationException exce)
            {
                Console.WriteLine($"An serialization error occured: {exce.Message}");
                Console.WriteLine("Try again");
                Console.WriteLine("____________");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occured: {ex.Message}");
                Console.WriteLine("Try again");
                Console.WriteLine("____________");
            }
        }
    }
}