using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program181
{
    internal class Program
    {
        static void Main()
        {

            Console.Write("Операция (1–Баланс, 2–Снятие, 3–Пополнение, 4–Перевод): ");
            if (!int.TryParse(Console.ReadLine(), out int op))
            {
                Console.WriteLine("Ошибка.");
                return;
            }

            string msg;
            switch (op)
            {
                case 1: msg = "Начинаем проверку баланса..."; break;
                case 2: msg = "Начинаем процедуру снятия наличных..."; break;
                case 3: msg = "Начинаем процедуру пополнения счёта..."; break;
                case 4: msg = "Начинаем оформление перевода..."; break;
                default:
                    Console.WriteLine("Неверная операция.");
                    return;
            }
            Console.WriteLine(msg);
        }
    }
}