using System;

namespace Task3
{
    abstract class Vehicle
    {
        public double Price { get; set; }
        public double Speed { get; set; }
        public int Year { get; set; }
        public Vehicle(double price, double speed, int year)
        {
            this.Price = price;
            this.Speed = speed;
            this.Year = year;
        }
        public void Show()
        {
            Console.WriteLine($"Общая информация:\nЦена:{Price};\tСкорость:{Speed};\tГод{Year}");
        }
    }
    class Plane: Vehicle
    {
        public double Height { get; set; }
        public int Number_of_Passengers { get; set; } 
        public Plane(double price, double speed, int year,double height, int number_of_passengers)
            :base(price, speed, year)
        {
            this.Height = height;
            this.Number_of_Passengers = number_of_passengers;
        }
        public override string ToString()
        {
            return $"Дополнительная информация:\nВысота:{Height};\tКол-во пассажиров:{Number_of_Passengers}";
        }
    }
    class Ship : Vehicle
    {
        public string Port { get; set; }
        public int Number_of_Passengers { get; set; }
        public Ship(double price, double speed, int year,string port, int number_of_passengers)
             : base(price, speed, year)
        {
            this.Port = port;
            this.Number_of_Passengers = number_of_passengers;
        }
        public override string ToString()
        {
            return $"Дополнительная информация:\nПорт:{Port};\tКол-во пассажиров:{Number_of_Passengers}";
        }
    }
    class Car : Vehicle
    {
        public Car(double price, double speed, int year) : base(price, speed, year) { }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите цену самолета: ");
            double price_plane = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите скорость самолета: ");
            double speed_plane = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите год самолета: ");
            int year_plane = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите высту самолета: ");
            double height_plane = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введитекол-во пассажиров самолета: ");
            int count_peple_plane = Convert.ToInt32(Console.ReadLine());
            Plane plane = new Plane(price_plane, speed_plane, year_plane, height_plane, count_peple_plane);
            plane.Show();
            Console.WriteLine(plane);

            Console.Write("Введите цену машины: ");
            double price_car = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите скорость машины: ");
            double speed_car = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите год машины: ");
            int year_car = Convert.ToInt32(Console.ReadLine());
            Car car = new Car(price_car, speed_car, year_car);
            car.Show();

            Console.Write("Введите цену коробля: ");
            double price_ship = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите скорость коробля: ");
            double speed_ship = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите год коробля: ");
            int year_ship = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите порт коробля: ");
            string port_ship = Console.ReadLine();
            Console.Write("Введитекол-во пассажиров коробля: ");
            int count_peple_ship = Convert.ToInt32(Console.ReadLine());
            Ship ship = new Ship(price_ship, speed_ship, year_ship, port_ship, count_peple_ship);
            ship.Show();
            Console.WriteLine(ship);

        }
    }
}
