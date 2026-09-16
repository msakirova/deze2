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
            AccountType account = AccountType.Сберегательный;
            Console.WriteLine($"Тип счета: {account}");
            Console.ReadKey();

            //Упражнение 3.2
            Console.WriteLine("Упражнение 3.2");
            BunkAccount bunkaccount = new BunkAccount(9999999999999999999, account, 25000.5);
            bunkaccount.Print(9999999999999999999, account, 25000.5);
            Console.ReadKey();

            //Домашнее задание 3.1
            Console.WriteLine("Домашнее задание 3.1");
            Universitets univer = Universitets.KAI;
            Worker worker = new Worker("Тестик Тестикович", univer);
            worker.Print("Тестик Тестикович", univer);
            Console.ReadKey();
        }
    }
}
