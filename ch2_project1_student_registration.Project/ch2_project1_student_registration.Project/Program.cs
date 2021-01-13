using System;

namespace ch2_project1_student_registration.Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Student Registration Form");

            Console.Write("Enter first name: ");
            String firstName = Console.ReadLine();
            
            Console.Write("Enter last name: ");
            String lastName = Console.ReadLine();
            
            Console.WriteLine("Enter year of birth");
            Convert.ToDouble(birthYear);
            double birthYear = Console.ReadLine();
            Console.WriteLine(birthYear);

            Console.WriteLine();

            String temppwd = firstName + "*" + birthYear;

            Console.WriteLine("Welcome" +firstName + lastName+ "!");
            Console.WriteLine("Your registration is complete.");
            Console.WriteLine("Your temporary password is: " + firstName + birthYear);
;        }
    }
}
