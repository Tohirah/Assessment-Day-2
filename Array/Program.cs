using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            // QUE 1
            
            // Console.WriteLine("enter size of the first Array.");
            // int arrSize1 = int.Parse(Console.ReadLine());
            
            // Console.WriteLine("enter size of the second Array.");
            // int arrSize2 = int.Parse(Console.ReadLine());

            // int[] arr1 = new int[arrSize1];
            // int[] arr2 = new int[arrSize2];

            // for(int i = 0; i < arrSize1; i++)
            // {
            //     Console.WriteLine("Enter next element");
            //     arr1[i] = int.Parse(Console.ReadLine());
            // }
            // Console.WriteLine("Elements for second Array");
            // for(int j = 0; j < arrSize2; j++)
            // {
            //     Console.WriteLine("Enter next element");
            //     arr2[j] = int.Parse(Console.ReadLine());
            // }

            // for(int k = 0; k < arrSize1; k++)
            // {
            //     int count = 0;
            //     for(int m = 0; m < arrSize2; m++)
            //     {
            //         if(arr1[k] == arr2[m])
            //         {
            //             count++;
            //         }
            //     }
            //     Console.WriteLine(arr1[k] + " occurred " + count + " times");
            // }

            // QUE 2
            // Console.WriteLine("enter size of the Array.");
            // int arrSize = int.Parse(Console.ReadLine());

            // int[] arr = new int[arrSize];

            // for(int i = 0; i < arrSize; i++)
            // {
            //     Console.WriteLine("Enter next element");
            //     arr[i] = int.Parse(Console.ReadLine());
            // }

            // int small = 0;
            // for(int j = 0; j < arr.Length; j++)
            //     {
            //         for(int i = j+1; i < arr.Length; i++)
            //         {
            //             if(arr[i] < arr[j])
            //             {
            //                 small = arr[i];
            //                 arr[i] = arr[j];
            //                 arr[j] = small; 
            //             }
            //         }
            //     }
            //     Console.WriteLine("Check");
            // int smallest = arr[0];
            // int largest = arr[arrSize - 1];
            // for(int w = smallest + 1; w < largest; w++)
            // {
            //     Console.WriteLine(w);
            // }

            //     QUE 3
            // Console.WriteLine("Enter size of the Array.");
            // int arrSize = int.Parse(Console.ReadLine());

            // int[] arr = new int[arrSize];

            // for(int i = 0; i < arrSize; i++)
            // {
            //     Console.WriteLine("Enter next element");
            //     arr[i] = int.Parse(Console.ReadLine());
            // }
            // for(int j = 0; j < arrSize; j++)
            // {
            //     for(int k = j + 1; k < arrSize; k++)
            //     {
            //         if(arr[j] == arr[k])
            //         {
            //             arr[k] = 0;
            //         }
            //     }
            // }

            // Console.Write("New elements are: ");
            // for(int i = 0; i < arrSize; i++)
            // {
            //     if(arr[i] == 0)
            //     continue;
            //     Console.Write(arr[i] + ", ");
            // }
            // Console.WriteLine("");

            // QUE 4
            // Console.WriteLine("Enter the number of subjects");
            // int length = int.Parse(Console.ReadLine());

            // int[] score = new int[length];
            // string[] subject = new string[length]; 

            // for(int j = 0; j < length; j++)
            // {
            //     Console.WriteLine("Enter the name of the next subject");
            //     subject[j] = Console.ReadLine();

            //     Console.WriteLine("Enter the score for the subject");
            //     score[j] = int.Parse(Console.ReadLine());
            // }

            // Console.Write("Your new score is: ");
            // for(int k = 0; k < length; k++)
            // {
            //     if(score[k] < 50)
            //     {
            //         score[k] +=10;
            //     }
            //     else if(score[k] < 60 && score[k] >= 50)
            //     {
            //         score[k] +=2;
            //     }
            //     else if(score[k] > 70)
            //     {
            //         score[k] -=5;
            //     }
            //     else
            //     {
            //         score[k] +=4;
            //     }

            // if(k < length - 1)
            //     {
            //         Console.Write(subject[k] + "-" + score[k] + ", ");
            //     }
            //     else
            //     {
            //         Console.Write(subject[k] + "-" + score[k]);
            //     }

            // }
            // Console.WriteLine("");

            // QUE 5
            // Console.WriteLine("Enter size of the Array.");
            // int length = int.Parse(Console.ReadLine());

            // int[] arrDuplicate = new int[length];

            // int count = 1;
            // int largestCount = 0;
            // int largestNum = 0;

            // for(int i = 0; i < arrDuplicate.Length; i++)
            // {
            //     Console.WriteLine("Enter next Element");
            //     arrDuplicate[i] = int.Parse(Console.ReadLine());
            // }

            // for(int j = 0; j < arrDuplicate.Length - 1; j++)
            // {
            //     for(int k = j + 1; k <arrDuplicate.Length; k++)
            //     {
            //         if(arrDuplicate[j] == arrDuplicate[k])
            //         {
            //             count++;
            //             largestNum = arrDuplicate[j];
            //         }
            //         else
            //         {
            //         break;
            //         }
            //     }
            //     if(count > largestCount)
            //     {
            //         largestCount = count;
            //         largestNum = arrDuplicate[j];
            //     }
            //     count = 1;
            // }

            // if(largestCount > 0)
            // {
            //     for(int k = 1; k <= largestCount; k++)
            //     {
            //         if(k < largestCount)
            //         {
            //             Console.Write(largestNum + ", ");
            //         }
            //         else
            //         {
            //             Console.Write(largestNum);
            //         }
            //     }
            // }
            // else
            // {
            //     Console.WriteLine("Equal number of consecutive equal sequence for all elements");
            // }
            

            // QUE 7 - WIP
            Console.WriteLine("Enter size of the Array.");
            int len = int.Parse(Console.ReadLine());

            int[] arrMerge1 = new int[len];
            int[] arrMerge2 = new int[len];
            int[] mergedArr = new int[len * 2];

            for(int i = 0; i < len; i++)
            {
                Console.WriteLine("Enter next element for first array");
                arrMerge1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("SECOND ARRAY ELEMENTS");
            for(int i = 0; i < len; i++)
            {
                Console.WriteLine("Enter next element for second array");
                arrMerge2[i] = int.Parse(Console.ReadLine());
            }

            int n = 0;

            for(int k = 0; k < mergedArr.Length; k++)
            {
                if(k < len)
                {
                    mergedArr[k] = arrMerge1[k];
                }
                else
                {
                    mergedArr[k] = arrMerge2[n];
                    n++;
                }
            }

            int biggest = 0;
            
            for(int i = 0; i < mergedArr.Length; i++)
            {
                    for(int j = i + 1; j < mergedArr.Length; j++)
                    {
                        if(mergedArr[j] < mergedArr[i])
                        {
                            biggest = mergedArr[j];
                            mergedArr[j] = mergedArr[i];
                            mergedArr[i] = biggest;
                        }
                    }
                }

            foreach (int item in mergedArr)
            {
                Console.WriteLine(item);
            }

            // QUE 8
            // Console.WriteLine("Enter size of the Array.");
            // int len = int.Parse(Console.ReadLine());

            // int[] arr = new int[len];

            // for(int i = 0; i < len; i++)
            // {
            //     Console.WriteLine("Enter next element");
            //     arr[i] = int.Parse(Console.ReadLine());
            // }

            // int biggest = 0;
            // int secondbiggest = 0;

            // for(int k = 0; k < len; k++)
            // {
            //     if(arr[k] > biggest)
            //     {
            //         secondbiggest = biggest;
            //         biggest = arr[k];
            //     }
            //     else if(secondbiggest < arr[k] && arr[k] < biggest)
            //     {
            //         secondbiggest = arr[k];
            //     }
            // }

            // Console.WriteLine(secondbiggest);


        }
    }
}
