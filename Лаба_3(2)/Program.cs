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
            string text, path;
            Console.WriteLine("Ввести текст");
            text = Console.ReadLine();
            Console.WriteLine("Введите путь и имя файла для сохранения в формате C:\\File.txt:", Encoding.UTF8);
            path = Console.ReadLine();
            File.WriteAllText(path, text);
            Console.WriteLine("Сохранено успешно");
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
