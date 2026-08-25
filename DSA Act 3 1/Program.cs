
using System.Globalization;

namespace DSA_Act_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * DSA Activity 2.3 - [Estrada, Jan Laurence]
             * Program Description:
             * 
             */

            try
            {



                int[] score = new int[10];
                for (int x = 1; x <= 12; x++)
                {
                    score[x-1]=Convert.ToInt32(Console.ReadLine());
                }

                foreach (string month in score)
                {
                    Console.WriteLine("Scores: " + $"-> {score}");
                }
                Console.ReadKey();







            }
            catch (Exception e)
            {
                Console.WriteLine("err enctrd. " + e.ToString());
            }
            finally
            {
                Console.ReadKey();
            }
        }

    }
}