using System;

namespace Лб2__1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Console.InputEncoding = System.Text.Encoding.Unicode; //для правильного відображення укр.мови

            Address Den = new Address();

            Den.index = 71008;
            Den.country = "Україна";
            Den.city = "Київ";
            Den.street = "вулиця Михайла Грушевського";
            Den.house = 12;
            Den.apartment = 522;

            Den.GetInfo();

            Console.ReadKey();
        }
    }
}
