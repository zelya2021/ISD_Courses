using System;

namespace HW_1
{
    //задание 1
    class Addres
    {
        int index;
        string country;
        string city;
        string street;
        string house;
        string apartment;

        public int Index {
            get
            {
                return index;
            }
            set
            {
                index = value;
            }
        }
        public string Country
        {
            get
            {
                return country;
            }
            set
            {
                country = value;
            }
        }
        public string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }
        public string Street
        {
            get
            {
                return street;
            }
            set
            {
                street = value;
            }
        }
        public string House
        {
            get
            {
                return house;
            }
            set
            {
                house = value;
            }
        }
        public string Apartment
        {
            get
            {
                return apartment;
            }
            set
            {
                apartment = value;
            }
        }
        public override string ToString()
        {
            return $"Страна:{Country}\nГород:{City}\nУлица:{Street}\nДом:{House}\nКвартира:{Apartment}";
        }
    }

    //задание 2
    class Rectangle
    {
        public double side1;
        public double side2;
        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }
        public double Area { get; private set; }
        public double Perimeter { get; private set; }
        public double AreaCalculator()
        {
            Area = side1 * side2;
            return Area;
        }
        public double PerimeterCalculator()
        {
            Perimeter = 2*(side1 + side2);
            return Perimeter;
        }
        public override string ToString()
        {
            return $"Периметр:{Perimeter};\tПлощадь:{Area}";
        }
    }

    //задание 3
    abstract class Book
    {
        public virtual string Show() { return ""; }
    }
    class Title : Book
    {
        public string Name { get; set; }
        public Title(string title)
        {
            Name = title;
        }
        public override string Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            return $"Название:{Name}\t";
        }
    }
    class Author : Book
    {
        public string Author_ { get; set; }
        public Author(string author)
        {
            Author_ = author;
        }
        public override string Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            return $"Автор:{Author_}\t";
        }
    }
    class Content : Book
    {
        public string Description { get; set; }
        public Content(string content)
        {
            Description = content;
        }
        public override string Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            return $"Содержание:{Description}\t";
        }
    }

    //задание 4
    class Point
    {
        public double X { get; private set; }
        public double Y { get; private set; }
        public double Z { get; private set; }
        public Point(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
    }
    class Figure
    {
        Point p1;
        Point p2;
        Point p3;
        Point p4;
        Point p5;
        public Figure(Point p1, Point p2, Point p3, Point p4, Point p5) : this(p1, p2, p3,p4)
        {
            this.p5 = p5;
        }
        public Figure(Point p1, Point p2, Point p3, Point p4):this(p1, p2, p3)
        {
            this.p4 = p4;
        }
        public Figure(Point p1, Point p2, Point p3)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
        }
        public double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow(B.X-A.X, 2)+ Math.Pow(B.Y - A.Y, 2)+ Math.Pow(B.Z - A.Z, 2));
        }
        public void PerimeterCalculator()
        {
            double rez = 0;
            if (p5 == null && p4 == null)
            {
                rez = LengthSide(p1, p2) + LengthSide(p2, p3);
            }
            if (p5==null)
            {
                 rez = LengthSide(p1, p2) + LengthSide(p2, p3) + LengthSide(p3, p4);
            }
            
            Console.WriteLine($"Периметр многоугольника: {rez}");
        }
        
    }

    //задание 5
    class User
    {
        public string Data { get; private set; } = "23.05.19";
        public string Name { get; set; } = "Vasya";
        public string LastName { get; set; } = "Pupkin";
        public int Age { get; set; } = 32;
        public string Login { get; set; } = "vasya2036";

        public override string ToString()
        {
            return $"Имя: {Name}\tФамилия: {LastName}\tВозраст: {Age}\tЛогин: {Login}\tДата: {Data}";
        }

    }

    //задание 6
    class Converter
    {
        double usd_toGRN;
        double rub_toGRN;
        double eur_toGRN;
        
        public Converter( double usd, double eur, double rub)
        {
            usd_toGRN = usd * 0.042;
            rub_toGRN = eur * 0.038;
            eur_toGRN = rub * 2.69;
            Console.WriteLine($"{usd} usd - {usd_toGRN} grn\n{eur} eur, - {rub_toGRN} grn\n{rub} rub - {eur_toGRN} grn");
        }
        public double ConvertToUSD(double usd)
        {
            return usd / 0.042;
        }
    }

    //задание 7
    class Employee
    {
        const double tax_levy= 0.96;
        public double experience_percent;
        public double salary=0;
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public double Experience
        {
            set
            {
                if (value < 5)
                {
                    experience_percent = 1.3;
                }
                else if(value >5&&value<10)
                {
                    experience_percent = 1.5;
                }
                else if (value > 10 && value < 20)
                {
                    experience_percent = 2;
                }
                else
                {
                    experience_percent = 2.5;
                }
            }
            get { return experience_percent; }
        }
        public Employee(string name, string last_name, double experience)
        {
            this.Name = name;
            this.LastName = last_name;
            this.Experience = experience;
        }

        public double Salary()
        {
            Console.WriteLine("Выберите номер должности: \n" +
                "1) Бухгалтер\n" +
                "2) Программист\n" +
                "3) Экономист\n" +
                "4) Врач\n");
            int current = Convert.ToInt32(Console.ReadLine());
            switch(current)
            {
                case 1:
                    {
                        salary= 16000 * tax_levy* experience_percent;
                        Position = "Бухгалтер";
                        break;
                    }
                case 2:
                    {
                        salary = 50000 * tax_levy* experience_percent;
                        Position = "Программист";
                        break;
                    }
                case 3:
                    {
                        salary = 20000 * tax_levy* experience_percent;
                        Position = "Экономист";
                        break;
                    }
                case 4:
                    {
                        salary = 15000 * tax_levy* experience_percent;
                        Position = "Врач";
                        break;
                    }
            }
            return salary;
        }
        public override string ToString()
        {
            return $"Имя: {Name}\t Фамилия: {LastName}\t Должность: {Position}\t ЗП: {salary}\t Налоги: {tax_levy}";
        }

    }

    //задание 8
    class Invoice
    {
        const double NCD= 0.2;
        public double accountNCD;
        public double accoun_without_tNCD;
        public string customer;
        public string provider;
        private string article;
        private int quantity;
        private int price;
        public Invoice(string customer, string provider, int quantity)
        {
            this.customer = customer;
            this.provider = provider;
            this.quantity = quantity;
        }
        public void NameProd()
        {
            Console.WriteLine("Выберите id продукта: \n" +
                "1) Гипсокартон\n" +
                "2) Утеплитель\n" +
                "3) Клеевые смеси\n" +
                "4) Крепеж\n");
            int id = Convert.ToInt32(Console.ReadLine());

            switch(id)
            {
                case 1:
                    {
                        article = "Гипсокартон";
                        price = 145;
                        break;
                    }
                case 2:
                    {
                        article = "Утеплитель";
                        price = 69;
                        break;
                    }
                case 3:
                    {
                        article = "Клеевая смесь";
                        price = 90;
                        break;
                    }
                case 4:
                    {
                        article = "Крепеж";
                        price = 120;
                        break;
                    }
            }
        }
        public double WithNCD()
        {
            return accountNCD = quantity * price+ quantity*price * NCD;
        }
        public double WithoutNCD()
        {
            return accoun_without_tNCD = quantity * price;
        }
        public override string ToString()
        {
            return $"Покупатель: {customer}\tПоставщик: {provider}\tТовар: {article}\tКоличество: {quantity}\n" +
                $"Цена с НСД: {accountNCD}\t Цена без НСД: {accoun_without_tNCD}\t НСД = {NCD}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //задание 1
            //Addres addres = new Addres();
            //addres.Index = 49114;
            //addres.Country = "Ukraine";
            //addres.City = "Dnieper";
            //addres.Street = "Orangerey";
            //addres.House = "3";
            //addres.Apartment = "59";
            //Console.WriteLine(addres);

            //задание 2
            //Console.Write("Введите длину\tx=");
            //double x = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Введите ширину\ty=");
            //double y = Convert.ToDouble(Console.ReadLine());
            //Rectangle rectangle = new Rectangle(x,y);
            //rectangle.PerimeterCalculator();
            //rectangle.AreaCalculator();
            //Console.Write(rectangle);

            //задание 3
            //Console.Write("Введите название: ");
            //string name = Console.ReadLine();
            //Title title = new Title(name);
            //Console.Write("Введите автора: ");
            //string auth = Console.ReadLine();
            //Author author = new Author(auth);
            //Console.Write("Введите содержание: ");
            //string cont = Console.ReadLine();
            //Content content = new Content(cont);
            //Console.Write(title.Show());
            //Console.Write(author.Show());
            //Console.Write(content.Show());
            //Console.ForegroundColor = ConsoleColor.White;

            //задание 4
            //Point p1 = new Point(2,4,7);
            //Point p2 = new Point(7, 1, 2);
            //Point p3 = new Point(6, 9, 8);
            //Point p4 = new Point(11, 2, 4);
            //Figure figure = new Figure(p1, p2, p3, p4);
            //figure.PerimeterCalculator();

            //задание 5
            //User user = new User();
            //Console.Write(user);

            //задание 6
            //Converter converter = new Converter(12, 6, 2.5);
            //Console.WriteLine($"45 grn - {converter.ConvertToUSD(45)} usd");

            //задание 7
            //Console.Write("Введите имя: ");
            //string name = Console.ReadLine();
            //Console.Write("Введите фамилию: ");
            //string last_name = Console.ReadLine();
            //Console.Write("Введите опыт(лет): ");
            //double exp = Convert.ToDouble(Console.ReadLine());
            //Employee employee = new Employee(name, last_name, exp);
            //employee.Salary();
            //Console.WriteLine(employee);

            //задание 8
            //Console.Write("Введите имя покупателя: ");
            //string name = Console.ReadLine();
            //Console.Write("Введите поставщика: ");
            //string provider = Console.ReadLine();
            //Console.Write("Введите количество: ");
            //int quantity = Convert.ToInt32(Console.ReadLine());
            //Invoice invoice = new Invoice(name, provider, quantity);
            //invoice.NameProd();
            //invoice.WithNCD();
            //invoice.WithoutNCD();
            //Console.WriteLine(invoice);
        }
    }
}
