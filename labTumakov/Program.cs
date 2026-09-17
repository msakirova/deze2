using System.Numerics;
using labTumakov.Enums;
using labTumakov.Structs;

namespace labTumakov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Упражнение 3.1
            Console.WriteLine("Упражнение #3.1");
            Console.WriteLine("Введите тип счета: Сберегательный/Текущий");
            var accountstr = Console.ReadLine();
            var res1 = AccountType.TryParse(accountstr, out AccountType account);
            if (res1 == false)
                Console.WriteLine("Введено не корректно");
            Console.WriteLine($"Тип счета: {account}");
            Console.ReadKey();

            //Упражнение 3.2
            Console.WriteLine("Упражнение 3.2");
            Console.WriteLine("Введите номер счета:");
            var numstr = Console.ReadLine();
            var res2 = BigInteger.TryParse(accountstr, out BigInteger num);
            if (res2 == false)
                Console.WriteLine("Введено не корректно");
            Console.WriteLine("Введите баланс счета:");
            var balancestr = Console.ReadLine();
            var res3 = double.TryParse(balancestr, out double balance);
            if (res3 == false)
                Console.WriteLine("Введено не корректно");
            BunkAccount bunkaccount = new BunkAccount(num, account, balance);
            bunkaccount.Print(num, account, balance);
            Console.ReadKey();

            //Домашнее задание 3.1
            Console.WriteLine("Домашнее задание 3.1");
            Console.WriteLine("Введите ФИО:");
            var name = Console.ReadLine();
            Console.WriteLine("Введите университет: КГУ/КАИ/КХТИ");
            var universtr = Console.ReadLine();
            var res4 = Universitets.TryParse(accountstr, out Universitets univer);
            if (res4 == false)
                Console.WriteLine("Введено не корректно");
            Worker worker = new Worker(name, univer);
            worker.Print(name, univer);
            Console.ReadKey();
        }
    }
}
