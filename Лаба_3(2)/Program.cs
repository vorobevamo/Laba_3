using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Лаба_3_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = false;
            do
            {
                try
                {
                    // string path = @"С:\папка\mytext.txt";
                    string path;//Путь
                    Console.WriteLine("Введите путь в формате 'С:\\папка\\mytext.txt'");
                    path = Console.ReadLine();


                    Console.WriteLine("Введите текст");
                    string text = Console.ReadLine();


                    Console.WriteLine("Выберите кодировку utf-8, 1251, 866");
                    int Kodir = int.Parse(Console.ReadLine());


                    using (TextWriter txt = new StreamWriter(path, false, Encoding.GetEncoding(Kodir)))
                    {
                        txt.WriteLine(text);
                    }
                    flag = true;
                }
                catch (Exception) { }
            }
            while (!flag);

            Console.ReadKey();
        }
    }
}