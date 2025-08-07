using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_16_Hospital_Triage_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int patientCount = 5;
            string[] symptoms = new string[patientCount];
            string[] departments = new string[patientCount];

            Console.WriteLine("Hospital Triage System");
            Console.WriteLine("Please enter symptoms for 5 patients:");

            for (int i = 0; i < patientCount; i++)
            {
                Console.Write($"Patient {i + 1} symptoms: ");
                symptoms[i] = Console.ReadLine().ToLower();

                departments[i] = DetermineDepartment(symptoms[i]);

                Console.WriteLine($"Assigned to: {departments[i]}\n");
            }

            Console.WriteLine("\nTriage Summary:");
            Console.WriteLine("----------------");
            for (int i = 0; i < patientCount; i++)
            {
                Console.WriteLine($"Patient {i + 1}: {symptoms[i]} → {departments[i]}");
            }
        }
        static string DetermineDepartment(string symptom)
        {
            if (symptom.Contains("fever") || symptom.Contains("cough"))
            {
                return "General Medicine";
            }
            else if (symptom.Contains("injury") || symptom.Contains("burn"))
            {
                return "Emergency";
            }
            else
            {
                return "Refer to Specialist";
            }
        }

    }
}
