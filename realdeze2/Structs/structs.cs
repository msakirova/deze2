using System;
using System.Collections.Generic;
using System.Text;

namespace realdeze2.Structs
{
    public struct User
    {
        public string Name;
        public byte Age;
        public string City;
        public int PIN;
        public User(string name, byte age, string city, int pin)
        {
            Name = name;
            Age = age;
            City = city;
            PIN = pin;
        }
        public void Print(string name, byte age, string city, int pin)
        {
            Console.WriteLine($"Имя:{name}, Возраст: {age}, Город: {city}, PIN-код: {pin}");
        }

    }
    public struct Shop
    {
        public int NormPrice;
        public int SalePercent;
        public int HolidayPrice;
        public int BottlesNeeded;
        public Shop(int normPrice, int salePercent, int holidayPrice)
        {
            NormPrice = normPrice;
            SalePercent = salePercent;
            HolidayPrice = holidayPrice;
            BottlesNeeded = 0;
        }
        public int BottleShop(int normPrice, int salePrice, int holidayPrice)
        {
            double saving = normPrice * (salePrice / 100.0);
            double bottels = (int)(holidayPrice / saving);
            return (int)bottels;

        }
    }
    public struct Swap
    {
        public string Str;
        public Swap(string str)
        {
            Str = str;
        }
        public string SwapCase(string str)
        {
            var res = new StringBuilder(str.Length);
            foreach (char c in str)
            {
                if (char.IsLower(c))
                    res.Append(char.ToUpper(c));
                else if (char.IsUpper(c))
                    res.Append(char.ToLower(c));
                else
                    res.Append(c);
            }
            return res.ToString();

        }
    }
    public struct Drink
    {
        public string Nameofalcohol;
        public double AlcoholPercent;
        public Drink(string name, double percent)
        {
            Nameofalcohol = name;
            AlcoholPercent = percent;
        }

    }
    public struct Student
    {
        public string LastName;
        public string FirstName;
        public int Id;
        public DateTime BirthDay;
        public char AlcoholCategory;
        public double DrinkVolume;
        public Drink FavDrink;
        public Student(string lastname,string firstname, int id, DateTime birthDay, char alcoholcategory, double dinkvolume, Drink favdrink)
        {
            LastName = lastname;
            FirstName = firstname;
            Id = id;
            BirthDay = birthDay;
            AlcoholCategory = alcoholcategory;
            DrinkVolume = dinkvolume;
            FavDrink = favdrink;
        }
        public string categoryName(char c)
        {
            switch (c)
            {
                case 'a': return "алкоголик";
                case 'b': return "любитель выпить";
                case 'c': return "пьёт по праздникам";
                case 'd': return "не пьёт";
                default: return "неизвестно";
            }
        }
    }
}