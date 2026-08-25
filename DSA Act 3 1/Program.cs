
using System.Globalization;
using System.Transactions;

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
                for (int x = 0; x < 10; x++)
                {
                    Console.WriteLine($"Enter Score[{x + 1}]: ");
                    score[x] = Convert.ToInt32(Console.ReadLine());
                }

                foreach (int scores in score)
                {
                    Console.WriteLine("Scores: "  $" {score}");
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