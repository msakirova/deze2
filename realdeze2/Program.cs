using realdeze2.Structs;

namespace realdeze2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            Console.WriteLine("#1");
            Console.WriteLine($"sbyte: {sbyte.MaxValue} - {sbyte.MinValue}");
            Console.WriteLine($"byte: {byte.MaxValue} - {byte.MinValue}");
            Console.WriteLine($"short: {short.MaxValue} - {short.MinValue}");
            Console.WriteLine($"ushort: {ushort.MaxValue} - {ushort.MinValue}");
            Console.WriteLine($"int: {int.MaxValue} - {int.MinValue}");
            Console.WriteLine($"uint: {uint.MaxValue} - {uint.MinValue}");
            Console.WriteLine($"long: {long.MaxValue} - {long.MinValue}");
            Console.WriteLine($"ulong: {ulong.MaxValue} - {ulong.MinValue}");
            Console.WriteLine($"float: {float.MaxValue} - {float.MinValue}");
            Console.WriteLine($"double: {double.MaxValue} - {double.MinValue}");
            Console.WriteLine($"decimal: {decimal.MaxValue} - {decimal.MinValue}");
            Console.ReadKey();

            //Задание 2
            Console.WriteLine("#2");
            Console.WriteLine("Введите Ваше имя:");
            var name = Console.ReadLine();
            Console.WriteLine("Введите Ваш возраст:");
            var agestr = Console.ReadLine();
            var res1 = byte.TryParse(agestr, out var age);
            if (res1 == false)
                Console.WriteLine("Введено не корректно");
            Console.WriteLine("Введите город:");
            var city = Console.ReadLine();
            Console.WriteLine("Введите PIN-код:");
            var pinstr = Console.ReadLine();
            var res2 = int.TryParse(pinstr, out var pin);
            if (res2 == false)
                Console.WriteLine("Введено не корректно");
            User user = new User(name, age, city, pin);
            user.Print(name, age, city, pin);
            Console.ReadKey();

            //Задание 3
            Console.WriteLine("Введите строку:");
            string str = Console.ReadLine();
            Swap strres = new Swap(str);
            var res = strres.SwapCase(str);
            Console.WriteLine(res);
            Console.ReadKey();

            //Задание 4
            Console.WriteLine("#4");
            Console.WriteLine("Введите строку:");
            string inputstr = Console.ReadLine();
            Console.WriteLine("Введите подстроку:");
            string sub = Console.ReadLine();
            int count = 0;
            int i = 0;
            while ((i = inputstr.IndexOf(sub, i)) != -1)
            {
                count++;
                i += sub.Length;
            }
            Console.WriteLine($"Количество вхождений: {count}");
            Console.ReadKey();

            //Задание 5
            Console.WriteLine("#5");
            Console.WriteLine("Введите стандартную цену:");
            var normPricestr = Console.ReadLine();
            var res3 = int.TryParse(normPricestr, out var normPrice);
            if (res3 == false)
                Console.WriteLine("Введено не корректно");
            Console.WriteLine("Введите скидку:");
            var salePricestr = Console.ReadLine();
            var res4 = int.TryParse(salePricestr, out var salePrice);
            if (res4 == false)
                Console.WriteLine("Введено не корректно");
            Console.WriteLine("Введите стоимость отпуска:");
            var holidayPricestr = Console.ReadLine();
            var res5 = int.TryParse(holidayPricestr, out var holidayPrice);
            if (res5 == false)
                Console.WriteLine("Введено не корректно");
            Shop shop = new Shop(normPrice, salePrice, holidayPrice);
            var result = shop.BottleShop(normPrice, salePrice, holidayPrice);
            Console.WriteLine($"Нужное количество бутылок: {result}");
            Console.ReadKey();

            //Задание 6
            Console.WriteLine("#6");
            Drink vodka = new Drink("vodka", 40);
            Drink beer = new Drink("beer", 5);
            Drink vine = new Drink("vine", 12);
            Student[] student = new Student[5];
            student[0] = new Student("Пупыркин", "Василий", 1, new DateTime(2006, 12, 31), 'a', 0.5, beer);
            student[1] = new Student("Фирсова", "Кятя", 2, new DateTime(2008, 09, 12), 'b', 0.75, vine);
            student[2] = new Student("Пипкин", "Миша", 3, new DateTime(2008, 03, 21), 'c', 1.5, beer);
            student[3] = new Student("Узумаки", "Наруто", 4, new DateTime(2005, 10, 10), 'd', 0.5, vodka);
            student[4] = new Student("Учиха", "Саске", 5, new DateTime(2005, 07, 23), 'd', 0.5, vine);


            double volume = 0;
            double totalvolume = 0;
            foreach (var studentik in student) 
            {
                volume += studentik.DrinkVolume;
                totalvolume += studentik.DrinkVolume * (studentik.FavDrink.AlcoholPercent / 100.0);
            }
            Console.WriteLine($"Общий объем выпитой жидкости: {volume}");
            Console.WriteLine($"Общий объем алкоголя: {totalvolume}");

            foreach (var studentik in student)
            {
                double studentAlcoholVolume = studentik.DrinkVolume * (studentik.FavDrink.AlcoholPercent / 100.0);
                double alcoholPercentOfTotal = (studentAlcoholVolume / totalvolume) * 100.0;
                double liquidPercentageOfTotal = (studentik.DrinkVolume / totalvolume) * 100.0;

                Console.WriteLine($"{studentik.FirstName} {studentik.LastName}:");
                Console.WriteLine($"Алкоголь: {studentAlcoholVolume} {alcoholPercentOfTotal}% от общего алкоголя");
                Console.WriteLine($"л {studentik.DrinkVolume}л {liquidPercentageOfTotal}% от общего объема");
                Console.WriteLine();
            }

        }
        
    }

}