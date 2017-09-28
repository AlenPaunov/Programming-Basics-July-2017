using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digits
{
    class Digits
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());
            char[] numbers = input.ToString().ToCharArray();
            var colls = int.Parse(numbers[0].ToString()) + int.Parse(numbers[2].ToString());
            var rows = int.Parse(numbers[0].ToString()) + int.Parse(numbers[1].ToString());
            char[] digitsNumber = input.ToString().ToArray();
            var firstDigitNumber = int.Parse(digitsNumber[0].ToString());
            var secondDigitNumber = int.Parse(digitsNumber[1].ToString());
            var thirdDigitNumber = int.Parse(digitsNumber[2].ToString());
            var number = input;
            var firstDigit = 0;
            var secondDigit = 0;
            var thirdDigit = 0;

            for (int outerLoop = 0; outerLoop < rows; outerLoop++)
            {
                for (int innerLoop = 0; innerLoop < colls; innerLoop++)
                {
                   
                    char[] digits = number.ToString().ToArray();
                    if (number>=0)
                    {
                        if (number.ToString().Length >= 3)
                        {
                            firstDigit = int.Parse(digits[0].ToString());
                            secondDigit = int.Parse(digits[1].ToString());
                            thirdDigit = int.Parse(digits[2].ToString());
                        }
                        else if (number.ToString().Length >= 2)
                        {
                            firstDigit = 0;
                            secondDigit = int.Parse(digits[0].ToString());
                            thirdDigit = int.Parse(digits[1].ToString());
                        }
                        else
                        {
                            firstDigit = 0;
                            secondDigit = 0;
                            thirdDigit = int.Parse(digits[0].ToString());
                        }
                    }
                    else
                    {
                        if (number.ToString().Length == 4)
                        {
                            firstDigit = int.Parse(digits[1].ToString());
                            secondDigit = int.Parse(digits[2].ToString());
                            thirdDigit = int.Parse(digits[3].ToString());
                        }
                        else if (number.ToString().Length == 3)
                        {
                            firstDigit = 0;
                            secondDigit = int.Parse(digits[1].ToString());
                            thirdDigit = int.Parse(digits[2].ToString());
                        }
                        else
                        {
                            firstDigit = 0;
                            secondDigit = 0;
                            thirdDigit = int.Parse(digits[1].ToString());
                        }
                    }
                    

                    bool divisibleOfThree = false;
                    var sumDigits = firstDigit + secondDigit + thirdDigit;
                    if (sumDigits>9)
                    {
                        char[] sumDigits2 = sumDigits.ToString().ToCharArray();
                        sumDigits = int.Parse(sumDigits2[0].ToString()) + int.Parse(sumDigits2[1].ToString());

                    }
                    if (sumDigits==9||sumDigits==6||sumDigits==3)
                    {
                        divisibleOfThree = true;
                    }

                    if (thirdDigit == 5 || thirdDigit==0)
                    {
                        number -= firstDigitNumber;
                    }
                    else if (divisibleOfThree==true)
                    {
                        number -= secondDigitNumber;
                    }
                    else
                    {
                        number += thirdDigitNumber;
                    }
                    Console.Write("{0}", number);
                    if (innerLoop + 1 == colls)
                    {
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }
            }
        }
    }
}
