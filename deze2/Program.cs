using deze2.Enums;
using deze2.structs;

namespace deze2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание 0
            Console.WriteLine("#0");
            byte oxygenLevel = 250;
            byte extraOxygen = 10;
            byte result = (byte)(oxygenLevel + extraOxygen);
            Console.WriteLine($"oxygenLevel = {oxygenLevel}");
            Console.WriteLine($"extraOxygen = {extraOxygen}");
            Console.WriteLine($"result.byte = {result}");
            Console.WriteLine($"result.int = {extraOxygen + oxygenLevel}");

            //Задание 1
            Console.WriteLine("#1");
            Console.WriteLine("Введите имя кандидата:");
            var name1 = Console.ReadLine();
            Console.WriteLine("Введите возраст кандидата:");
            var agestr = Console.ReadLine();
            var res1 = byte.TryParse(agestr, out var age);
            if (res1 == false)
                Console.WriteLine("Введено не корректно");
            Console.WriteLine("Введите рост кандидата в метрах:");
            var  heightstr = Console.ReadLine();
            var res2 = double.TryParse(heightstr, out var height);
            if (res2 == false)
                Console.WriteLine("Введено не корректно");
            Console.WriteLine("Введите вес кандидата в килограммах:");
            var weightstr = Console.ReadLine();
            var res3 = double.TryParse(weightstr, out var weight);
            if (res3 == false)
                Console.WriteLine("Введено не корректно");
            Console.WriteLine("Введите любимый фильм кандидата про космос:");
            var movie = Console.ReadLine();
            Candidate candidate1 = new Candidate(name1, age, height, weight, movie);
            candidate1.Print(name1, age, height, weight, movie);
            Console.ReadKey();

            //Задание 2
            Console.WriteLine("#2");
            Console.WriteLine("Введите Ваше ФИО");
            var name2 = Console.ReadLine();
            Console.WriteLine("Введите номер поезда (от 0 до 255)");
            var numtrainstr = Console.ReadLine();
            var res4 = byte.TryParse(numtrainstr, out var numtrain);
            if (res4 == false)
                Console.WriteLine("Введено не корректно");
            Console.WriteLine("Введите дату и время отправления");
            var datetimestr = Console.ReadLine();
            var res5 = DateTime.TryParse(datetimestr, out var datetime);
            if (res5 == false)
                Console.WriteLine("Введено не корректно");
            Console.WriteLine("Введите тип вагона: Плацкарт/Купе/СВ/Люкс");
            var typestr = Console.ReadLine();
            var res6 = TrainType.TryParse(typestr, out TrainType type);
            if (res6 == false)
                Console.WriteLine("Введено не корректно");
            Console.WriteLine("Введите цену");
            var pricestr = Console.ReadLine();
            var res7 = int.TryParse(pricestr, out var price);
            if (res7 == false)
                Console.WriteLine("Введено не корректно");
            Ticket ticket1 = new Ticket(name2, numtrain, datetime, type, price);
            ticket1.Print(name2, numtrain, datetime, type, price);
            Console.ReadKey();

            //Задание 3
            Console.WriteLine("#3");
            Console.WriteLine("Введите Ваше имя");
            var name3 = Console.ReadLine();
            Console.WriteLine("Введите марку автомобиля");
            var carbrand = Console.ReadLine();
            Console.WriteLine("Введите класс автомобиля: Эконом/Комфорт/Бизнес/Премиум");
            var avtoclassstr = Console.ReadLine();
            var res8 = Class.TryParse(avtoclassstr, out Class avtoclass);
            if (res8 == false)
                Console.WriteLine("Введено не корректно");
            Console.WriteLine("Введите дату начала аренды");
            var startstr = Console.ReadLine();
            var res9 = DateOnly.TryParse(startstr, out DateOnly start);
            if (res9 == false)
                Console.WriteLine("Введено не корректно");
            Console.WriteLine("Введите дату окончания аренды");
            var endstr = Console.ReadLine();
            var res10 = DateOnly.TryParse(endstr, out DateOnly end);
            if (res10 == false)
                Console.WriteLine("Введено не корректно");
            Console.WriteLine("Введите стоимость аренды за сутки");
            var pricedaystr = Console.ReadLine();
            var res11 = double.TryParse(pricedaystr, out var priceday);
            if (res11 == false)
                Console.WriteLine("Введено не корректно");
            Contract contract1 = new Contract(name3, carbrand, avtoclass, start, end, priceday);
            contract1.Print(name3, carbrand, avtoclass, start, end, priceday);
            Console.ReadKey();

            //Задание 4
            Console.WriteLine("#");
            Console.WriteLine("Введите Ваше ФИО");
            var name4 = Console.ReadLine();
            Console.WriteLine("Введите номер зачетной книжки");
            var zbook = Console.ReadLine();
            Console.WriteLine("Введите факультет: ИТ/Экономика/Юриспруденция/Дизайн");
            var facultystr = Console.ReadLine();
            var res12 = Faculty.TryParse(facultystr, out Faculty faculty);
            if (res12 == false)
                Console.WriteLine("Введено не корректно");
            Console.WriteLine("Введите курс (1 - 4)");
            var coursestr = Console.ReadLine();
            var res13 = byte.TryParse(coursestr, out var course);
            if (res13 == false || course > 4)
                Console.WriteLine("Введено не корректно");
            Console.WriteLine("Введите средний бал (1,0 - 5,0)");
            var gpastr = Console.ReadLine();
            var res14 = double.TryParse(gpastr, out var gpa);
            if (res14 == false || gpa > 5.0)
                Console.WriteLine("Введено не корректно");
            Console.WriteLine("Введите дату зачисления");
            var enterdatestr = Console.ReadLine();
            var res15 = DateOnly.TryParse(enterdatestr, out DateOnly enterdate);
            if (res15 == false)
                Console.WriteLine("Введено не корректно");
            Student student1 = new Student(name4, zbook, faculty, course, gpa, enterdate);
            student1.Print(name4, zbook, faculty, course, gpa, enterdate);
            Console.ReadKey();


        }
    }
}