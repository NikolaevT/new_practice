// Создать класс "существа" с методами Walk(), Say(), See()
// Сделать 3 наследующих от него класса (например человек, червь и тд)
// со СВОЕЙ реализацией данных методов
using System;
using System.Globalization;

namespace Tusk2
{
    class Program
    {
        static void Main(string[] args)
        {
            var str1 = new StringNewGenerate();
            var str2 = new StringNewGenerate(17);
            var str3 = new StringNewGenerate("may");
            Console.WriteLine(str1.GetLenght());
            str1.Add(10);
            Console.WriteLine(str1.GetLenght());
            str3.Add("ggg");
            Console.WriteLine(str3.GetLenght());
            str3.Clear();
            Console.WriteLine(str3);
        }
    }
}