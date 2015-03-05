using System;

namespace Question1 {
    class Program {
        static void Main(string[] args) {
            const string question1 = "{0}What is the length of the first side (value must be a valid integer)?";
            const string question2 = "{0}What is the length of the second side (value must be a valid integer)?";
            const string question3 = "{0}What is the length of the third side (value must be a valid integer)?";

            int side1;
            int side2;
            int side3;

            Console.Write("Welcome to the Question 1.{0}Please enter the specs of the Triangle (Be warned, you will come back to the begining, if the triangle is not valid.):{0}", Environment.NewLine);

            bool isValid;
            do {
                do {
                    Console.WriteLine(question1, Environment.NewLine);
                } while (!int.TryParse(Console.ReadLine(), out side1));

                do {
                    Console.WriteLine(question2, Environment.NewLine);
                } while (!int.TryParse(Console.ReadLine(), out side2));

                do {
                    Console.WriteLine(question3, Environment.NewLine);
                } while (!int.TryParse(Console.ReadLine(), out side3));

                isValid = Triangle.IsValid(side1, side2, side3);
                if (!isValid) {
                    Console.WriteLine("Please re-enter the values; the triangle was not valid.");
                }
            } while (isValid == false);

            Console.WriteLine("{0}You entered a {1} Triangle!", Environment.NewLine, new Triangle(side1, side2, side3).GetTriangleType());
            Console.ReadKey();
        }
    }
}
