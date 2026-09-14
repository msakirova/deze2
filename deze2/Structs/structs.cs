using deze2.Enums;

namespace deze2.structs
{
    public struct Candidate
    {
        public string Name;
        public byte Age;
        public double Height;
        public double Weight;
        public string Movie;
        public Candidate(string name, byte age, double height, double weight, string movie)
        {
            Name = name;
            Age = age;
            Height = height;
            Weight = weight;
            Movie = movie;

        }

        public void Print(string name, byte age, double height, double weight, string movie)
        {
            Console.WriteLine($"Имя:{name}, Возраст: {age}, Рост: {height}, Вес: {weight}, Любимый фильм: {movie}" );
        }

    }
    public struct Ticket
    {
        public string Name;
        public byte TrainNumber;
        public DateTime DateTime;
        public TrainType Type;
        public double Price;
        public Ticket(string name, byte trainnumber, DateTime datetime, TrainType type, double price)
        {
            Name = name;
            TrainNumber = trainnumber;
            DateTime = datetime;
            Type = type;
            Price = price;

        }

        public void Print(string name, byte trainnumber, DateTime datetime, TrainType type, double price)
        {
            Console.WriteLine($"Имя:{name}, Номер поезда: {trainnumber}, Дата и время: {datetime}, Тип поезда: {type}, Цена билета: {price}");
        }
    }
    public struct Contract
    {
        public string Name;
        public string CarBrand;
        public Class AvtoClass;
        public DateOnly StartDateTime;
        public DateOnly EndDateTime;
        public double PriceDay;
        public Contract(string name, string carbrand, Class avtoclass, DateOnly startdatetime, DateOnly enddatetime, double priceday)
        {
            Name = name;
            CarBrand = carbrand;
            AvtoClass = avtoclass;
            StartDateTime = startdatetime;
            EndDateTime = enddatetime;
            PriceDay = priceday;

        }

        public void Print(string name, string carbrand, Class avtoclass, DateOnly startdatetime, DateOnly enddatetime, double priceday)
        {
            Console.WriteLine($"Имя:{name}, Марка автомобиля: {carbrand}, Класс автомобиля: {avtoclass}, Дата начала аренды: {startdatetime}, Дата конца аренды: {enddatetime}, Стоимость аренда за сутки: {priceday}");
        }
    }
    public struct Student
    {
        public string Name;
        public string ZBook;
        public Faculty Faculty;
        public byte Course;
        public double GPA;
        public DateOnly EnterDate;
        public Student(string name, string zbook, Faculty faculty, byte course, double gpa, DateOnly enterdate)
        {
            Name = name;
            ZBook = zbook;
            Faculty = faculty;
            Course = course;
            GPA = gpa;
            EnterDate = enterdate;
        }

        public void Print(string name, string zbook, Faculty faculty, byte course, double gpa, DateOnly enterdate)
        {
            Console.WriteLine($"Имя:{name}, Номер зачетной книжки: {zbook}, Факультет: {faculty}, Курс: {course}, Средний бал: {gpa}, Дата зачисления: {enterdate}");
        }
    }
}
