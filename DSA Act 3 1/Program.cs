using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;
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

                int sum;
                int avg;
                int[] score = new int[10];
                for (int x = 0; x < 10; x++)
                {
                    Console.Write($"Enter Score {x + 1}: ");
                    score[x] = Convert.ToInt32(Console.ReadLine());
                    sum =+score[x];
                    avg = sum / 10;
                }
                avg = sum / 10;
                Console.Write("Scores: ");
                foreach (int x in score) Console.Write(x);

                Console.Write("Average Score is " + avg);

                string remark;


                Console.Write("Remark: " );







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