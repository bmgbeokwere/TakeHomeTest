using System;
using System.IO;

namespace Question3 {
    class Program {
        private static void Main(string[] args) {
            string path;
            do {
                Console.WriteLine("{0}Welcome to Question 2!{0}Please provide a valid file path:", Environment.NewLine);
                path = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(path) || !File.Exists(path));
            var primer = new PrimeFactorParser(path);

            Console.WriteLine("Wait here; we are preparing your results...");
            Console.WriteLine(primer.ToString());
            Console.ReadKey();
        }
    }
}
