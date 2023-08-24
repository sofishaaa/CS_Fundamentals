using System;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace HW7
{
    class Program
    {
        public static void Main(string[] args)
        {

            Dictionary<string, string> PhoneBook = new Dictionary<string, string>(); //номери - ключі, імена - значення

            string path1 = @"Z:\Desktop\LearningC#\HW7\phones.txt";
            string line;


            try
            {
                using (StreamReader reader = new StreamReader(path1))
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(" : ");
                        if (parts.Length == 2)
                        {
                            string phoneName = parts[0];
                            string phoneNumber = parts[1];
                            PhoneBook[phoneNumber] = phoneName;
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            string path2 = "Z:\\Desktop\\LearningC#\\HW7\\numbers.txt";

            using (StreamWriter writer = new StreamWriter(path2))
            {
                foreach (var keyValuePair in PhoneBook)
                {
                    writer.WriteLine(keyValuePair.Key);
                }
            }

            Dictionary<string, string> newPhoneBook = new Dictionary<string, string>();

            using (StreamReader read = new StreamReader(path1))
            {
                while ((line = read.ReadLine()) != null)
                {
                    string[] parts = line.Split(" : ");
                    if (parts.Length == 2)
                    {
                        string newPhoneName = parts[0];
                        string newPhoneNumber = parts[1];
                        if (newPhoneNumber.Length == 11)
                            newPhoneNumber = "+3" + newPhoneNumber;
                        newPhoneBook[newPhoneNumber] = newPhoneName;
                    }
                }
            }
            Console.Write("Enter a name to find the phone number: ");
            string findName = Console.ReadLine();
            bool isThereName = true;
            foreach (var keyValuePair in newPhoneBook)
            {
                if (findName.ToLower() == keyValuePair.Value.ToLower())
                {
                    Console.WriteLine($"{keyValuePair.Value} : {keyValuePair.Key}");
                    isThereName = false;
                }
            }
            if (isThereName)
                Console.WriteLine("Invalid name!");

            string path3 = "Z:\\Desktop\\LearningC#\\HW7\\new.txt";

            using (StreamWriter writ = new StreamWriter(path3))
            {
                foreach (var keyValuePair in newPhoneBook)
                {
                    writ.WriteLine($"{keyValuePair.Value} : {keyValuePair.Key}");
                }
            }
        }
    }
}   
