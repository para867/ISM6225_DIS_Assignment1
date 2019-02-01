using System;
using System.Linq;

namespace Assignment1
{
    // All organizing structures use { and } to define their boundaries
    class Program
    {
        // All .NET programs begin with the main method
        public static void Main()
        {
            //Declaring two integers for the start and end of the range
            int n1, n2;
            string nPrime = string.Empty;
            //Input starting number of range
            Console.WriteLine("enter first number: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            //Input ending number of range
            Console.WriteLine("enter second number: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            printPrimeNumbers(n1, n2, nPrime);

            //Input the number of terms in the series
            int num1;
            Console.WriteLine("Enter number of terms in the series: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            double r1 = getSeriesResult(num1);
            Console.WriteLine("The sum of the series is: " + r1);
            Console.ReadKey();

            long num2 = 15;
            long r2 = decimalToBinary(num2);
            
            long num3 = 1111;
            long r3 = binaryToDecimal(num3);
           
            int n4 = 5;
            printTriangle(n4);

            int[] arr = new int[] { 1, 2, 3, 2, 2, 1, 3, 2 };
               computeFrequency(arr);
             
            // The exercises appeard easy but it took a long time to finish them without any errors.
            //I also need to work on the corner cases, for example checking if the 
            //entries provided at run time are valid. Especially, the problems with the binary to decimal 
            //and vice versa, need to check for large numbers which were throwing an exception.

        }

        private static void printPrimeNumbers(int n1, int n2, string nPrime)
        {
            bool flag = true;
            for (; n1 <= n2; ++n1)
            {
                flag = true;
                for (int i = 2; i <= n1 / 2; ++i)
                {
                    if (n1 % i == 0)
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    nPrime += n1.ToString() + ", ";
                }
            }
            Console.WriteLine("Prime numbers are: " + nPrime);
            Console.ReadLine();
        }

        //Method to calculate factorial of a number
        //Mathematically, n! = 1 * 2 * 3 * …. * (n-1) * n

        public static int Faktor(int num)
        {
            int result = 1;
            for (int i = 1; i <= num; i++)
            {
                result *= i;

            }
            return result;
        }

        // Method to compute sum of series 1/2 - 2!/3 - 3!/4 .. - n
        public static double getSeriesResult(int n)
        {
            try
            {
                int index = 1;
                double series = 0.0, sum = 0.0;
                while (index <= n)
                {
                    int fact = Faktor(index);
                    series = Math.Pow(-1, index - 1) * fact / (index + 1);
                    sum = sum + series;
                    index++;
                }
                //Round up sum to 3 decimal places
                return Math.Round(sum, 3);
            }
            catch
            {
                Console.WriteLine("Exception occured while computing getSeriesResult()");
            }

            return 0;
        }

        public static long decimalToBinary(long n)
        {
            try
            {
        // C# method that that takes a decimal number as input 
        // and displays its equivalent in binary form
            string answer;
            string result;

            Console.Write("Input a Number : ");
            answer = Console.ReadLine();

            int num = Convert.ToInt32(answer);
            result = "";
            while (num > 1)
            {
                int decval = num % 2;
                result = Convert.ToString(decval) + result;
                num /= 2;
            }
            result = Convert.ToString(num) + result;
            Console.WriteLine("Binary: {0}", result);
        }
            catch
            {
                Console.WriteLine("Exception occured while computing decimalToBinary()");
            }

            return 0;
        }

        public static long binaryToDecimal(long n)
        {
            try
            {
        // C# Method to Perform Binary to Decimal Conversion
            int num, binary_val, decimal_val = 0, base_val = 1, rem;
            Console.Write("Enter a Binary Number(1s and 0s) : ");
            num = int.Parse(Console.ReadLine()); /* maximum five digits */
            binary_val = num;
            while (num > 0)
            {
                rem = num % 10;
                decimal_val = decimal_val + rem * base_val;
                num = num / 10;
                base_val = base_val * 2;
            }
            Console.Write("The Binary Number is : " + binary_val);
            Console.Write("\nIts Decimal Equivalent is : " + decimal_val);
            Console.ReadLine();
    }
            catch
            {
                Console.WriteLine("Exception occured while computing binaryToDecimal()");
            }

            return 0;
        }

        public static void printTriangle(int n)
        {
            try
            {
        // Method for displaying Star pyramid in C#

        // Declare variables for row and column
        int i, j, k;
        for (i = 1; i <= 5; i++)
        {
            for (j = i; j < 5; j++)
            {
                Console.Write(" ");
            }
            for (k = 1; k < (i * 2); k++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        Console.ReadLine();
    }
            catch
            {
                Console.WriteLine("Exception occured while computing printTriangle()");
            }
        }

        // C# method that prints number of  
        // occurrences of each element in the array. 
        public static void computeFrequency(int[] arr)
        {
            try
            {
                int N = arr.Length;
                int[] unique = new int[4];
                int counter = 0;

                for (int i = 0; i < N; i++)
                {
                    if (!unique.Contains(arr[i]))
                        unique[i] = arr[i];
                }

                for (int i = 0; i < unique.Length; i++)
                {
                    if (unique[i] != 0)
                    {
                        if (unique[i] == arr[i])
                        {
                            counter++;
                            Console.WriteLine(unique[i] + " Occurs {0} times", counter);
                        }
                    }
                }
                Console.ReadKey();
            }

            
            catch
            {
                Console.WriteLine("Exception occured while computing computeFrequency()");
            }
        }
    }
}

