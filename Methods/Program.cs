using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            // QUE 1
            // Console.WriteLine("Enter the word");
            // string word = Console.ReadLine();

            // Console.WriteLine(MidChar(word));

            // QUE 2
            // Console.WriteLine("Enter the word");
            // string word = Console.ReadLine();

            // Console.WriteLine(CountVowel(word));

            //  QUE 6
            Console.WriteLine("Enter the number");
            int even = int.Parse(Console.ReadLine());

            Console.WriteLine(CheckEven(even));


            // QUE 7
            // Console.WriteLine("Enter the number");
            // string num = Console.ReadLine();

            // ReverseNum(num);

            // QUE 8
            // Console.WriteLine("Enter a non negative number - i.e. number greater than one.");
            // int pali = int.Parse(Console.ReadLine());

            // if(pali < 1)
            // {
            //     Console.WriteLine("Invalid Input.");
            // }
            // else
            // {
            //     Palindrome(pali);
            // }

            // QUE 9
            // Console.WriteLine("Enter the number");
            // string word = Console.ReadLine();

            // Console.WriteLine(SumNum(word));

            //QUE 10
            // Console.WriteLine("Enter the number");
            // int num = int.Parse(Console.ReadLine());

            // Console.WriteLine(LastNum(num));
        }

        // QUE 1
        public static char MidChar(string k)
        {
            if(k.Length % 2 == 0)
            {
                return(k[((k.Length - 1) / 2) + 1]);
            }
            else
            {
                return(k[k.Length / 2]);
            }
            
        }

        // QUE 2
        public static int CountVowel(string k)
        {
            int count = 0;
            for(int m = 0; m < k.Length; m++)
            {
                if(k[m] == 'a' || k[m] == 'e' || k[m] == 'i' || k[m] == 'o' || k[m] == 'u')
                {
                    count++;
                }
            }

            return(count);
        }

        // QUE 4 - WIP
        public static bool Password(string k)
        {
            bool validPass = true;
            for(int m = 0; m < k.Length; m++)
            {
                if(k.Length > 9)
                {
                }
                else
                {
                    validPass = false;
                }
            }

            return(validPass);
        }

        // QUE 6
        public static bool CheckEven(int k)
        {
            bool isEven = true;
            for(;k > 1;k /=10)
            {
                int j = k % 10;
                if(j % 2 == 0)
                {continue;}
                else
                {
                    isEven = false;
                    break;
                }
            }

            return(isEven);
        }

        // QUE 7
        public static void ReverseNum(string k)
        {
            for(int i = k.Length - 1; i >= 0; i--)
            {
                Console.Write(k[i]);
            }
        }

        // QUE 8
        public static void Palindrome(int k)
        {
            string m = k.ToString();
            string j = "";
            for(int i = m.Length - 1; i >= 0; i--)
            {
                j +=m[i];
            }

            Console.WriteLine( j == m);

        }

        //QUE 9
        public static int SumNum(string k)
        {
            int sum = 0;
            for(int i = 0; i < k.Length; i++)
            {
                sum +=int.Parse(k[i].ToString());
            }

            return(sum);
        }

        // QUE 10
        public static string LastNum(int k)
        {
            int lastNum =k % 10;
            string lastNumToWord = "";
            switch (lastNum)
            {
                case 0:
                lastNumToWord = "Zero";
                break;
                case 1:
                lastNumToWord = "One";
                break;              
                case 2:
                lastNumToWord = "Two";
                break; 
                case 3:
                lastNumToWord = "Three";
                break; 
                case 4:
                lastNumToWord = "Four";
                break;
                case 5:
                lastNumToWord = "Five";
                break;
                case 6:
                lastNumToWord = "Six";
                break;
                case 7:
                lastNumToWord = "Seven";
                break;
                case 8:
                lastNumToWord = "Eight";
                break;
                case 9:
                lastNumToWord = "Nine";
                break;
                default:
                break;
            }

            return(lastNumToWord);
        }
    }
}
