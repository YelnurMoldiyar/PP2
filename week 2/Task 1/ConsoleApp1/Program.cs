using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text;

namespace Task_1
{
    class Program
    {
        public static bool polindrome(string s)
        {
            int i = 0; //начало слова (первый символ) 
            int j = s.Length - 1;  // конец слова (последний символ) 

            while (i < j) //цикл пока i<j
            {
                if (s[i] != s[j]) // если они не равны то false
                {
                    return false;
                }
                i++; //  c каждым разом увеличиваем i
                j--; // с каждым разом уменшаем j 
            }
            return true; // если s[i] = s[j] то это является true
        }

        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("input.txt"); // текстовый файл 
            String s = sr.ReadToEnd();  // читать файл от начало до конца
            if (polindrome(s))
            {
                Console.WriteLine("Yes"); // если это полиндром то "YES"
            }
            else
                Console.WriteLine("No"); // если это не полиндром то "No"
            Console.ReadKey();
        }
    }
}