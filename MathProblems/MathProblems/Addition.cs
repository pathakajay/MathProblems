using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;

namespace MathProblems
{
    public class Addition : MathProblemsBase
    {
        private const string Operator = " + ";
        protected readonly string addtionBasePath = "";

        public override string GetOperator()
        {
            return " + ";    // get method
        }



        public Addition() : base(nameof(Addition))
        {

        }
        public override void CreateDirectory()
        {

        }
        public override void MissingNumberOneDigit()
        {
            List<string> finalList = new List<string>();
            int counter = 0;
            int fileCount = 0;
            List<string> allItems = new List<string>();
            while (true)
            {
                Random random = new Random();
                int number1 = random.Next(0, 9);
                int number2 = random.Next(0, 9);

                int randomNumber = counter % 3;
                string output = "";
                if (randomNumber == 0)
                {
                    output = number1.ToString().PadLeft(OneDigitSeprator.Length, ' ')
                        + GetOperator() + OneDigitSeprator + EqualTo
                        + (number1 + number2).ToString().PadLeft(OneDigitSeprator.Length, ' ');
                }
                else if (randomNumber == 1)
                {
                    output = number1.ToString().PadLeft(OneDigitSeprator.Length, ' ')
                        + GetOperator() +
                        number2.ToString().PadLeft(OneDigitSeprator.Length, ' ') + EqualTo + OneDigitSeprator;

                }
                else if (randomNumber == 2)
                {
                    output = OneDigitSeprator + GetOperator() + number2.ToString().PadLeft(OneDigitSeprator.Length, ' ') + EqualTo + (number1 + number2).ToString().PadLeft(OneDigitSeprator.Length, ' ');

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

                if (counter >= 0 && counter % SampleCount == 0)
                {
                    string filePath = Path.Combine(_MissingNumberOneDigit, fileCount.ToString("00") + nameof(MissingNumberOneDigit) + ".txt");
                    File.WriteAllLines(filePath, finalList);
                    fileCount += 1;
                    finalList.Clear();
                }
                if (fileCount == SheetCount || counter == int.MaxValue)
                {
                    break;
                }
            }
        }

        public override void OneDigitOperation()
        {
            List<string> finalList = new List<string>();
            int counter = 0;
            int fileCount = 0;
            List<string> allItems = new List<string>();
            while (true)
            {
                Random random = new Random();
                int number1 = random.Next(0, 9);
                int number2 = random.Next(0, 9);


                string output = "";

                output = number1.ToString().PadLeft(OneDigitSeprator.Length, ' ')
                    + GetOperator() +
                    number2.ToString().PadLeft(OneDigitSeprator.Length, ' ') + EqualTo + OneDigitSeprator;


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

                if (counter >= 0 && counter % SampleCount == 0)
                {
                    string filePath = Path.Combine(_OneDigitOperation, fileCount.ToString("00") + nameof(OneDigitOperation)
                        + ".txt");
                    File.WriteAllLines(filePath, finalList);
                    fileCount += 1;
                    finalList.Clear();
                }
                if (fileCount == 4 || counter == int.MaxValue)
                {
                    break;
                }
            }
        }
        public override void OneDigitAndTwoDigitOperation()
        {
            List<string> finalList = new List<string>();
            int counter = 0;
            int fileCount = 0;
            List<string> allItems = new List<string>();
            while (true)
            {
                Random random = new Random();
                int number1 = random.Next(0, 9);
                int number2 = random.Next(10, 99);
                if (number2 % 10 + number1 > 9)
                {
                    continue;
                }

                string output = "";

                output = number1.ToString().PadLeft(OneDigitSeprator.Length, ' ')
                    + GetOperator() +
                    number2.ToString().PadLeft(OneDigitSeprator.Length, ' ') + EqualTo + OneDigitSeprator;


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

                if (counter >= 0 && counter % SampleCount == 0)
                {
                    string filePath = Path.Combine(_OneDigitAndTwoDigitOperation, fileCount.ToString("00") + nameof(OneDigitAndTwoDigitOperation)
                        + ".txt");
                    File.WriteAllLines(filePath, finalList);
                    fileCount += 1;
                    finalList.Clear();
                }
                if (fileCount == SheetCount || counter == int.MaxValue)
                {
                    break;
                }
            }
        }
        public override void TwoDigitOperation()
        {
            List<string> finalList = new List<string>();
            int counter = 0;
            int fileCount = 0;
            List<string> allItems = new List<string>();
            while (true)
            {
                Random random = new Random();
                int number1 = random.Next(10, 99);
                int number2 = random.Next(10, 99);

                var temp1 = number1;
                var temp2 = number2;
                List<bool> continuteForSum = new List<bool>();
                while (temp1 > 0)
                {
                    var number1PlaceValue = temp1 % 10;
                    var number2PlaceValue = temp2 % 10;
                    if (number1PlaceValue + number2PlaceValue > 9)
                    {
                        continuteForSum.Add(false);
                    }
                    temp1 = temp1 / 10;
                    temp2 = temp2 / 10;
                }
                if (continuteForSum.Where(x => x == false).Count() > 0)
                {
                    continue;
                }
                string output = "";

                output = number1.ToString().PadLeft(TwoDigitSeprator.Length, ' ')
                    + GetOperator() +
                    number2.ToString().PadLeft(TwoDigitSeprator.Length, ' ') + EqualTo + TwoDigitSeprator;


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

                if (counter >= 0 && counter % SampleCount == 0)
                {
                    string filePath = Path.Combine(_TwoDigitOperation, fileCount.ToString("00") + nameof(TwoDigitOperation)
                        + ".txt");
                    File.WriteAllLines(filePath, finalList);
                    fileCount += 1;
                    finalList.Clear();
                }
                if (fileCount == SheetCount || counter == int.MaxValue)
                {
                    break;
                }
            }
        }
        public override void TwoDigitMissingOperation()
        {
            List<string> finalList = new List<string>();
            int counter = 0;
            int fileCount = 0;
            List<string> allItems = new List<string>();
            while (true)
            {
                Random random = new Random();
                int number1 = random.Next(10, 99);
                int number2 = random.Next(10, 99);

                var temp1 = number1;
                var temp2 = number2;
                List<bool> continuteForSum = new List<bool>();
                List<int> number1Digits = new List<int>();
                List<int> number2Digits = new List<int>();
                List<int> numberSumList = new List<int>();
                int sum = number1 + number2;
                while (temp1 > 0)
                {
                    var number1PlaceValue = temp1 % 10;
                    var number2PlaceValue = temp2 % 10;
                    if (number1PlaceValue + number2PlaceValue > 9)
                    {
                        continuteForSum.Add(false);
                    }
                    number1Digits.Add(number1PlaceValue);
                    number2Digits.Add(number2PlaceValue);
                    temp1 = temp1 / 10;
                    temp2 = temp2 / 10;
                }
                if (continuteForSum.Where(x => x == false).Count() > 0)
                {
                    continue;
                }
                while (sum > 0)
                {
                    var temp = sum % 10;
                    numberSumList.Add(temp);
                    sum = sum / 10;
                }
                
                string output = "";

                number2Digits.Reverse();
                number1Digits.Reverse();
                numberSumList.Reverse();
                int position1 = random.Next(1, 4);

                if (position1 == 1) //First and Last Position
                {
                    output = ("X" + number1Digits[1]).ToString().PadLeft(4, ' ') + Environment.NewLine
                    + "+" +
                    number2.ToString().PadLeft(2, ' ')
                    + Environment.NewLine + "_______" + Environment.NewLine
                    + (numberSumList[0] + "Y").ToString().PadLeft(4) + Environment.NewLine;
                }
                else if (position1 == 2)// Second and Fifth Position
                {
                    output = (number1Digits[0] + "X").ToString().PadLeft(4, ' ') + Environment.NewLine
                    + "+" +
                    number2.ToString().PadLeft(2, ' ')
                    + Environment.NewLine + "_______" + Environment.NewLine
                     + ("Y" + numberSumList[1]).ToString().PadLeft(4) + Environment.NewLine;
                }
                else if (position1 == 3)
                {
                    output = (number1Digits[0] + "X").ToString().PadLeft(4, ' ') + Environment.NewLine
                    + "+" +
                    ("Y" + number2Digits[1]).ToString().PadLeft(2, ' ')
                    + Environment.NewLine + "_______" + Environment.NewLine
                    + (number1 + number2).ToString().PadLeft(4) + Environment.NewLine;
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

                if (counter >= 0 && counter % SampleCount == 0)
                {
                    string filePath = Path.Combine(_TwoDigitMissingOperation, fileCount.ToString("00") + nameof(TwoDigitMissingOperation)
                        + ".txt");
                    File.WriteAllLines(filePath, finalList);
                    fileCount += 1;
                    finalList.Clear();
                }
                if (fileCount == SheetCount || counter == int.MaxValue)
                {
                    break;
                }
            }
        }
    }
}
