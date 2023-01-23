using System;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            //int number = Convert.ToInt32(Console.ReadLine());  // first task
            //int result=near7(number);
            //Console.WriteLine(result);

            //int number = Convert.ToInt32(Console.ReadLine()); // second task
            //SumValuable(number);  // second task

            //string word1 = "sa";
            //string word2 = "necesen";

            WordLength("sa", "necesen");
           
        }



        //static int near7(int number)
        //{

        //    if (number % 7 == 0)
        //    {
        //        return number;
        //    }
        //    else if (number % 7 > 3)
        //    {
        //        return (number / 7 + 1) * 7;
        //    }
        //    else
        //    {
        //        return number / 7 * 7;
        //    }
        //}


        //static void SumValuable(int number)
        //{

        //    int sum = 0;

        //    for (int i = 0; i < number; i++)
        //    {
        //        sum += i;
        //    }
        //    Console.WriteLine(sum);
        //}


        //////////////////////////////////////////////////////////////////////////////////////

        static string WordLength(string word1, string word2)
        {
            
            if (word1.Length>word2.Length)
            {
                return "word1 is longer word2";
            }
            else if (word1.Length==word2.Length)
            {
                return " word1 equal word2 ";
            }
            else
            {
                return "word2 is longer word1";
            }
        }
    











    }













}

