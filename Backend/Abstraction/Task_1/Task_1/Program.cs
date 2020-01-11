using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        public class AbstractHandler
        {
            public virtual void Open() { }
            public virtual void Create() { }
            public virtual void Change() { }
            public virtual void Save() { }
        }
        public class XMLHandler: AbstractHandler
        {
            public override void Open()
            {
                Console.WriteLine("Открытие XML файла");
            }
            public override void Create()
            {
                Console.WriteLine("Создание XML файла");
            }
            public override void Change()
            {
                Console.WriteLine("Редактирование XML файла");
            }
            public override void Save()
            {
                Console.WriteLine("Сохранение XML файла");
            }
        }
        public class TXTHandler : AbstractHandler
        {
            public override void Open()
            {
                Console.WriteLine("Открытие TXT файла");
            }
            public override void Create()
            {
                Console.WriteLine("Создание TXT файла");
            }
            public override void Change()
            {
                Console.WriteLine("Редактирование TXT файла");
            }
            public override void Save()
            {
                Console.WriteLine("Сохранение TXT файла");
            }
        }
        public class DOCHandle : AbstractHandler
        {
            public override void Open()
            {
                Console.WriteLine("Открытие DOC файла");
            }
            public override void Create()
            {
                Console.WriteLine("Создание DOC файла");
            }
            public override void Change()
            {
                Console.WriteLine("Редактирование DOC файла");
            }
            public override void Save()
            {
                Console.WriteLine("Сохранение DOC файла");
            }
        }
        static void Main(string[] args)
        {
            string choice = "";
            do
            {
                Console.Clear();
                Console.WriteLine("Выберите формат файла:\n1) .xml\n2) .txt\n3) .doc\n4)Exit");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        SubMenu(1);
                        break;
                    case "2":
                        SubMenu(2);
                        break;
                    case "3":
                        SubMenu(3);
                        break;
                    case "4":
                        break;
                    default:
                        Console.WriteLine("Выберите вариант из предложенных!");
                        break;
                }
            } while (choice != "4");
        }
        static void SubMenu(int i)
        {
            Console.WriteLine("Выберите действие с файлом:\n1) Создание.\n2) Открытие.\n3) Редактирование.\n4) Сохранение.");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    switch (i)
                    {
                        case 1:
                            XMLHandler xmlHandler = new XMLHandler();
                            xmlHandler.Create();
                            Console.ReadLine();     
                            break;
                        case 2:
                            TXTHandler xtxHandler = new TXTHandler();
                            xtxHandler.Create();
                            Console.ReadLine();
                            break;
                        case 3:
                            DOCHandle docHandler = new DOCHandle();
                            docHandler.Create();
                            Console.ReadLine();
                            break;
                    }
                    break;
                case "2":
                    switch (i)
                    {
                        case 1:
                            XMLHandler xmlHandler = new XMLHandler();
                            xmlHandler.Open();
                            Console.ReadLine();
                            break;
                        case 2:
                            TXTHandler xtxHandler = new TXTHandler();
                            xtxHandler.Open();
                            Console.ReadLine();
                            break;
                        case 3:
                            DOCHandle docHandler = new DOCHandle();
                            docHandler.Open();
                            Console.ReadLine();
                            break;
                    }
                    break;
                case "3":
                    switch (i)
                    {
                        case 1:
                            XMLHandler xmlHandler = new XMLHandler();
                            xmlHandler.Change();
                            Console.ReadLine();
                            break;
                        case 2:
                            TXTHandler xtxHandler = new TXTHandler();
                            xtxHandler.Change();
                            Console.ReadLine();
                            break;
                        case 3:
                            DOCHandle docHandler = new DOCHandle();
                            docHandler.Change();
                            Console.ReadLine();
                            break;
                    }
                    break;
                case "4":
                    switch (i)
                    {
                        case 1:
                            XMLHandler xmlHandler = new XMLHandler();
                            xmlHandler.Save();
                            Console.ReadLine();
                            break;
                        case 2:
                            TXTHandler xtxHandler = new TXTHandler();
                            xtxHandler.Save();
                            Console.ReadLine();
                            break;
                        case 3:
                            DOCHandle docHandler = new DOCHandle();
                            docHandler.Save();
                            Console.ReadLine();
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Выберите вариант из предложенных!");
                    break;
            }
        }
        }
}
