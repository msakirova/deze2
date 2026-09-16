using System.Numerics;
using labTumakov.Enums;

namespace labTumakov.Structs
{
    public struct BunkAccount
    {
        public BigInteger Num;
        public AccountType Type;
        public double Balance;
        public BunkAccount(BigInteger num, AccountType type, double balance)
        {
            Num = num;
            Type = type;
            Balance = balance;
        }
        public void Print(BigInteger num, AccountType type, double balance)
        {
            Console.WriteLine($"Номер счета: {num}, Тип счета: {type}, Баланс: {balance} pублей");
        }

    }
    public struct Worker
    {
        public Universitets Univer;
        public string Name;
        public Worker(string name, Universitets univer)
        {
            Name = name;
            Univer = univer;
        }
        public void Print(string name, Universitets univer)
        {
            Console.WriteLine($"Имя:{name}, Университет: {univer}");
        }

    }

}
