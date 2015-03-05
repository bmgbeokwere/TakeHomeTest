using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Question3 {
    public class PrimeFactorParser {
        public string FilePath { get; set; }
        public List<int> Numbers { get; set; }

        public PrimeFactorParser(string filePath) {
            FilePath = filePath;
            Numbers = GetNumbersFromFile(filePath);
        }

        public static List<int> GetNumbersFromFile(string filePath) {
            var list = new List<int>();
            if (File.Exists(filePath)) {
                using (var file = new StreamReader(filePath)) {
                    int number;
                    while (!file.EndOfStream) {
                        if (int.TryParse(file.ReadLine(), out number)) {
                            list.Add(number);
                        }
                    }
                }
            }

            return list;
        }
        /// <summary>
        /// Modified brute force...
        /// </summary>
        /// <param name="topCandidate"></param>
        /// <returns></returns>
        public static List<int> GetPrimeNumbers(int topCandidate) {
            var list = new List<int>();
            if (topCandidate > 1 && topCandidate%2 == 0) list.Add(2);

            for (var i = 3; i < topCandidate; i += 2) {
                for (var j = 2; j <= i; j += 2) {
                    if ((i%j) != 0 && (topCandidate%i) == 0) {
                        list.Add(i);
                    }
                }
            }

            return list.Distinct().ToList();
        }

        //This method does not require unit testing.  The format can change to whatever I like, and that would break unit tests.
        public override string ToString() {
            var sb = new StringBuilder();

            foreach (var number in Numbers) {
                sb.AppendFormat("{0}Primes of {1}:{0}{2}{0}", Environment.NewLine, number, string.Join(",", GetPrimeNumbers(number)));
            }

            return sb.ToString();
        }
    }
}
