using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace inluppg4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv ett tal");
            string inputNum = Console.ReadLine();
            string outputNum = inputNum;

            for (int i = 0; i < inputNum.Length; i++)
            {
                int currentNum = int.Parse(inputNum[i].ToString());
                if (currentNum == 9)
                {
                    Console.Write(0);
                }
                else
                {
                    currentNum += 1;
                    Console.Write(currentNum);
                }
            }
        }
    }
}