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

                int sum = 0;
                int avg = 0;
                int[] score = new int[10];
                for (int x = 0; x < 10; x++)
                {
                    Console.Write($"Enter Score {x + 1}: ");
                    score[x] = Convert.ToInt32(Console.ReadLine());
                    sum =+ score[x];
                }
                avg = sum / 10;
                Console.Write("Scores: ");
                foreach (int x in score)
                {
                    Console.Write(x + " ");
                }
                Console.WriteLine();
                Console.Write("Average Score is " + avg);
                Console.WriteLine();
                string remark;

                if (avg >= 90)
                    remark = "Excellent";
                else if (avg >= 80)
                    remark = "Very Good";
                else if (avg >= 75)
                    remark = "Passed";
                else
                    remark = "Failed";

                Console.Write("Remark: " + remark );


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