using System;
using System.Collections.Generic;

namespace RecruitmentTasks
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        //Task1
        static string[] ReverseArray(string[] text)
        {
            int textLength = text.Length;
            string[] reversedText = new string[textLength];
            int x = 0;

            for (int i = textLength - 1; i >= 0; i--)
            {
                reversedText[x] = text[i];
                x++;
            }

            return reversedText;
        }

        //Task2
        static void Palindrome(string text)
        {

            string[] nonLetters = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "-", "=", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "_", "+", " ", "[", "]", "{", "}", "/", ";", ":", "|", "'", ",", ".", "?", "<", ">" };
            //left only letters
            foreach (string x in nonLetters)
            {
                text = text.Replace(x, "");
            }
            text = text.ToLower();
            int first = 0;
            int last = text.Length - 1;
            int pairsAmmount = text.Length / 2;
            //check if palindrome
            for(int i = pairsAmmount; i>0; i--)
            {
                if(text[first] != text[last])
                {
                    Console.WriteLine("NO");
                    return;
                }
                first++; last--;
            }

            Console.WriteLine("YES");

        }

        //Task3
        static string Permutation(int[]a, int[]b)
        {
            Array.Sort(a);
            Array.Sort(b);

            for(int i = a.Length-1; i>=0; i--)
            {
                if (a[i] != b[i])
                    return "NO";
            }
            return "YES";
        }

        //Task4
        static string ExistingOfPower2(List<int> intList)
        {
            List<int> resultList = new List<int>();
            string result = "";

            foreach(int x in intList)
            {
                for (int i =31; i>=0; i--)
                {
                    if(x==Math.Pow(2,i))
                    {
                        resultList.Add(x);
                    }
                }
            }

            resultList.Sort();

            foreach(int z in resultList)
            {
                result += z + ",";
            }

            if(result == "")
            {
                return "NA";
            }

            return result;
        }

        //Task5
        static int[] FindingPrimes(int[,] numbers)
        {
            int cases = numbers[0, 0];
            int[] results = new int[cases];
            for(int z = 0; z<cases; z++)
            {
                bool ifPrime = false;
                int min = numbers[z+1, 0];
                int max = numbers[z+1, 1];
                List<int> PrimesList = new List<int>();
                //Find prime numbers in the interval
                for (int i = min; i <= max; i++)//give number to check
                {
                    for (int x = 2; x <= max; x++)//give divider
                    {
                        if (x != i)
                        {
                            if (i % x == 0)
                            {
                                ifPrime = true;
                            }
                        }

                    }
                    if (ifPrime != true)
                    {
                        if (i != 1)
                            PrimesList.Add(i);
                    }
                    ifPrime = false;
                }
                //Console.WriteLine(PrimesList.Count);
                results[z] = PrimesList.Count;
            }
            return results;
        }

        //Task8
        static int CommonDigit (int a, int[] b)
        {
            int[] count = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            string allDigits = "";
            //string with all digits
            for(int i = 0; i<a; i++)
            {
                allDigits += b[i];
            }
            //array with ammount of every digit
            for(int x = 0; x<allDigits.Length; x++)
            {
                count[allDigits[x]-'0']++;
            }
            //find most common digit
            int max = 0;
            for (int z = 0; z<=9; z++)
            {
                if(count[z]>count[max] || count[z] == count[max])
                {
                    max = z;
                }
            }
            
            return max;
        }

        //Task 9
        static int DigitSum(int a, int[] b)
        {
            int postitionOfMax = 0;
            int[] sumArray = new int[a];
            for(int i = 0; i<a; i++)
            {
                sumArray[i] = 0;
                while (b[i] != 0)
                {
                    sumArray[i] += b[i] % 10;
                    b[i] /= 10;
                }
            }

            for (int z = 0; z < a; z++)
            {
                if (sumArray[z] > sumArray[postitionOfMax] || sumArray[z] == sumArray[postitionOfMax])
                {
                    postitionOfMax = z;
                }
            }

            return postitionOfMax;
        }


    }
 }

