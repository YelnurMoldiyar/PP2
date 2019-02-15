using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task2
{
    class Program
    {
        public static bool Isprime(int n)
        {
            if (n == 1) //if n equal to 1 then it is not prime number
            {
                return false;
            }
            if (n == 2) //if n equal to 2 then add, because the 2 is prime number
            {
                return true;
            }
            for (int i = 2; i <= Math.Sqrt(n); i++) // continue before square of number 
            {
                if (n % i == 0) // if the number is diveded onto i then it is not a prime number
                {
                    return false;

                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("input.txt"); //the txt file 
            string s = sr.ReadLine();  //read the text
            string[] ar = s.Split();
            int[] arr = new int[ar.Length]; //create a massive
            for (int i = 0; i < ar.Length; i++)
            {
                arr[i] = int.Parse(ar[i]);
            }

            sr.Close();
            StreamWriter sw = new StreamWriter("output.txt"); //the new txt file 
            for (int i = 0; i < arr.Length; i++)
            {

                if (Isprime(arr[i]))
                {
                    sw.Write(arr[i] + " ");  //write the output on the output.txt file
                }

            }
            sw.Close();
        }
    }
}
