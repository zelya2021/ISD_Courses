using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class DocumentWorker
    {
        public virtual void OpenDocument()
        {
            Console.WriteLine("Документ открыт");
        }
        public virtual void EditDocument()
        {
            Console.WriteLine("Редактирование документа доступно в версии Про");
        }
        public virtual void SaveDocument()
        {
            Console.WriteLine("Сохранение документа доступно в версии Про");
        }
    }
    class ProDocumentWorker:DocumentWorker
    {
        public override void OpenDocument()
        {
            Console.WriteLine("Документ отркрыт в pro");
        }
        public override void EditDocument()
        {
            Console.WriteLine("Документ отредактирован в старом формате(pro)");
        }
        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в новом формате(pro)");
        }
    }
    class ExpertDocumentWorker: ProDocumentWorker
    {
        public override void SaveDocument()
        {
            Console.WriteLine("Cохранение в остальных форматах доступно в версии Эксперт(exp)");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ввдите номер ключа доступа(pro or exp)");
            string value = Console.ReadLine();
            if(value==""|| value == "pro")
            {
                ProDocumentWorker proDocument = new  ProDocumentWorker();
                DocumentWorker documentWorker = proDocument;
                documentWorker.OpenDocument();
                documentWorker.EditDocument();
                documentWorker.SaveDocument();
            }
            else if(value=="exp")
            {
                ExpertDocumentWorker expert = new ExpertDocumentWorker();
                DocumentWorker documentWorker = expert;
                documentWorker.SaveDocument();
            }
            else
            {
                Console.WriteLine("Некорректные данные!");
            }
        }
    }
}
