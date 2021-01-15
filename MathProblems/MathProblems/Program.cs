using System;
using System.Collections.Generic;
using System.IO;

namespace MathProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            AddAndSubtractThreeDigitNumber();
        }

        public static void AddAndSubtractThreeDigitNumber()
        {
            List<string> finalList = new List<string>();
            int counter = 0;
            int fileCount = 1;
            while (true)
            {
                Random random = new Random();

                int number1 = random.Next(0, 9);
                int number2 = random.Next(0, 9);
                if (number1 + number2 > 9)
                {
                    continue;
                }
                int number3 = random.Next(0, number2 + number1);
                string output = number1 + " + " + number2 + " - " + number3;
                if (!finalList.Contains(output))
                {
                    finalList.Add(output);
                    counter += 1;
                }

                if (counter >= 0 && counter % 20 == 0)
                {
                    string filePath = Path.Combine(@"C:\Temp\", fileCount.ToString("00") + "AddAndSubtractThreeDigitNumber.txt");
                    File.WriteAllLines(filePath, finalList);
                    fileCount += 1;
                    finalList.Clear();
                }


                if (fileCount == 6)
                {
                    break;
                }
            }

        }

    }
}
