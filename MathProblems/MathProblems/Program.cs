using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MathProblems
{
    class Program
    {


        static void Main(string[] args)
        {

            GenerateMissingNumberTwoDigit();
        }
        public static void GenerateMissingNumberTwoDigit()
        {
            const string separator = "____";
            List<string> finalList = new List<string>();
            int counter = 0;
            int fileCount = 0;
            List<string> allItems = new List<string>();
            while (true)
            {
                Random random = new Random();
                int number1 = random.Next(10, 99);
                int number2 = random.Next(1, 9);

                List<int> numbers = new List<int> { number1, number2 };
                numbers = numbers.OrderByDescending(q => q).ToList();
                number1 = numbers[0];
                number2 = numbers[1];
                int randomNumber = counter % 3;
                string output = "";
                if (randomNumber == 0)
                {
                    output = number1.ToString().PadLeft(separator.Length, ' ') + " - " + separator + " = " + (number1 - number2).ToString().PadLeft(separator.Length, ' ');

                }
                else if (randomNumber == 1)
                {
                    output = number1.ToString().PadLeft(separator.Length, ' ') + " - " + number2.ToString().PadLeft(separator.Length, ' ') + " = " + separator;

                }
                else if (randomNumber == 2)
                {
                    output = separator + " - " + number2.ToString().PadLeft(separator.Length, ' ') + " = " + (number1 - number2).ToString().PadLeft(separator.Length, ' ');

                }
                if (!string.IsNullOrEmpty(output) && !allItems.Contains(output))
                {
                    finalList.Add(output);
                    allItems.Add(output);
                    counter += 1;
                }
                else
                {
                    continue;
                }

                if (counter >= 0 && counter % 20 == 0)
                {
                    string filePath = Path.Combine(@"C:\Temp\GenerateMissingNumberTwoDigit\", fileCount.ToString("00") + "GenerateMissingNumberTwoDigit.txt");
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
        public static void GenerateMissingNumberOneDigit()
        {
            const string separator = "____";
            List<string> finalList = new List<string>();
            int counter = 0;
            int fileCount = 0;
            List<string> allItems = new List<string>();
            while (true)
            {
                Random random = new Random();
                int number1 = random.Next(0, 9);
                int number2 = random.Next(1, 9);

                List<int> numbers = new List<int> { number1, number2 };
                numbers = numbers.OrderByDescending(q => q).ToList();
                number1 = numbers[0];
                number2 = numbers[1];
                int randomNumber = counter % 3;
                string output = "";
                if (randomNumber == 0)
                {
                    output = number1.ToString().PadLeft(separator.Length,' ') + " - " + separator +  " = " + (number1 - number2).ToString().PadLeft(separator.Length, ' ');

                }
                else if (randomNumber == 1)
                {
                    output = number1.ToString().PadLeft(separator.Length, ' ') + " - " + number2.ToString().PadLeft(separator.Length, ' ') + " = " + separator;

                }
                else if (randomNumber == 2)
                {
                    output = separator + " - " + number2.ToString().PadLeft(separator.Length, ' ') + " = " + (number1 - number2).ToString().PadLeft(separator.Length, ' ');

                }
                if (!string.IsNullOrEmpty(output) && !allItems.Contains(output))
                {
                    finalList.Add(output);
                    allItems.Add(output);
                    counter += 1;
                }
                else
                {
                    continue;
                }

                if (counter >= 0 && counter % 20 == 0)
                {
                    string filePath = Path.Combine(@"C:\Temp\GenerateMissingNumberOneDigit\", fileCount.ToString("00") + "GenerateMissingNumberOneDigit.txt");
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

        public static void AddAndSubtractThreeDigitNumberTwoDigit()
        {
            List<string> finalList = new List<string>();
            int counter = 0;
            int fileCount = 0;
            List<string> allItems = new List<string>();
            while (true)
            {
                Random random = new Random();

                int number1 = random.Next(1, 99);
                int number2 = random.Next(1, 99);
                int number3 = random.Next(1, 99);
                List<int> numbers = new List<int> { number1, number2, number3 };
                numbers = numbers.OrderByDescending(q => q).ToList();

                string output = "";
                number3 = numbers[0];
                number2 = numbers[1];
                number1 = numbers[2];
                var onesPlace1 = 0;
                var onesPlace2 = 0;
                if (number3 > (number1 + number2))
                {
                    onesPlace1 = number3 % 10;
                    onesPlace2 = number2 % 10;
                    if (onesPlace1 >= onesPlace2 && (number3 - number2 + number1 < 100))
                    {
                        output = number3 + " - " + number2 + " + " + number1;
                    }

                }
                else if ((number3 - number2) >= number1)
                {
                    onesPlace1 = number3 % 10;
                    onesPlace2 = number2 % 10;

                    if (onesPlace1 >= onesPlace2)
                    {
                        onesPlace1 = (number3 - number2) % 10;
                        onesPlace2 = number1 % 10;
                        if (onesPlace1 >= onesPlace2)
                        {
                            output = number3 + " - " + number2 + " - " + number1;
                        }
                    }


                }
                else if ((number1 + number2) >= number3)
                {
                    onesPlace1 = number1 % 10;
                    onesPlace2 = number2 % 10;
                    if (onesPlace1 + onesPlace2 < 10)
                    {
                        onesPlace1 = (number1 + number2) % 10;
                        onesPlace2 = number3 % 10;
                        if (onesPlace1 >= onesPlace2)
                        {
                            output = number1 + " + " + number2 + " - " + number3;
                        }
                    }

                }
                else if (numbers.Sum() < 100)
                {
                    onesPlace1 = number1 % 10;
                    onesPlace2 = number2 % 10;
                    if (onesPlace1 + onesPlace2 < 10)
                    {
                        onesPlace1 = (number1 + number2) % 10;
                        onesPlace2 = number3 % 10;
                        if (onesPlace1 + onesPlace2 < 10)
                        {
                            output = number1 + " + " + number2 + " + " + number3;

                        }
                    }

                }


                /// Value Zero = Addition


                if (!string.IsNullOrEmpty(output) && !allItems.Contains(output))
                {
                    finalList.Add(output);
                    allItems.Add(output);
                    counter += 1;
                }
                else
                {
                    continue;
                }

                if (counter >= 0 && counter % 20 == 0)
                {
                    string filePath = Path.Combine(@"C:\Temp\", fileCount.ToString("00") + "TwoDigitAddAndSubtractThreeDigitNumber.txt");
                    File.WriteAllLines(filePath, finalList);
                    fileCount += 1;
                    finalList.Clear();
                }


                if (fileCount == 8)
                {
                    break;
                }
            }

        }

        public static void AddAndSubtractFourDigitNumberTwoDigit()
        {
            List<string> finalList = new List<string>();
            int counter = 0;
            int fileCount = 0;
            List<string> allItems = new List<string>();
            while (true)
            {
                Random random = new Random();

                int number1 = random.Next(1, 99);
                int number2 = random.Next(1, 99);
                int number3 = random.Next(1, 99);
                int number4 = random.Next(1, 99);
                List<int> numbers = new List<int> { number1, number2, number3, number4 };
                numbers = numbers.OrderByDescending(q => q).ToList();

                string output = "";
                number4 = numbers[0];
                number3 = numbers[1];
                number2 = numbers[2];
                number2 = numbers[3];
                var onesPlace1 = 0;
                var onesPlace2 = 0;
                if (numbers.Sum() < 100)
                {
                    onesPlace1 = number1 % 10;
                    onesPlace2 = number2 % 10;
                    if (onesPlace1 + onesPlace2 < 10)
                    {
                        onesPlace1 = (number1 + number2) % 10;
                        onesPlace2 = number3 % 10;
                        if (onesPlace1 + onesPlace2 < 10)
                        {
                            onesPlace1 = (number1 + number2 + number3) % 10;
                            onesPlace2 = number4 % 10;
                            if (onesPlace1 + onesPlace2 < 10)
                            {
                                output = number1 + " + " + number2 + " + " + number3 + " + " + number4;
                            }


                        }
                    }

                }


                /// Value Zero = Addition


                if (!string.IsNullOrEmpty(output) && !allItems.Contains(output))
                {
                    finalList.Add(output);
                    allItems.Add(output);
                    counter += 1;
                }
                else
                {
                    continue;
                }

                if (counter >= 0 && counter % 20 == 0)
                {
                    string filePath = Path.Combine(@"C:\Temp\", fileCount.ToString("00") + "AddAndSubtractFourDigitNumberTwoDigit.txt");
                    File.WriteAllLines(filePath, finalList);
                    fileCount += 1;
                    finalList.Clear();
                }


                if (fileCount == 8)
                {
                    break;
                }
            }

        }
    }
}
