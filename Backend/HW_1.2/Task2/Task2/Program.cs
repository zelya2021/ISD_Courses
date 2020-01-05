using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        class ClassRoom
        {
            Pupil p1;
            Pupil p2;
            Pupil p3;
            Pupil p4;
            public ClassRoom(Pupil p1, Pupil p2, Pupil p3, Pupil p4) : this(p1, p2,p3)
            {
                this.p4 = p4;
            }
            public ClassRoom(Pupil p1, Pupil p2, Pupil p3) :this(p1,p2)
            {
                this.p3 = p3;
            }
            public ClassRoom(Pupil p1, Pupil p2)
            {
                this.p1 = p1;
                this.p2 = p2;
            }
        }
        class Pupil
        {
            public void Study() { }
            public void Read() { }
            public void Write() { }
            public void Relax() { }
        }
        class ExcelentPupil: Pupil
        {
            public new void Study()
            {
                Console.WriteLine("ExcelentPupil Study");
            }
            public new void Read()
            {
                Console.WriteLine("ExcelentPupil Read");
            }
            public new void Write()
            {
                Console.WriteLine("ExcelentPupil Write");
            }
            public new void Relax()
            {
                Console.WriteLine("ExcelentPupil Relax");
            }
        }
        class GoodPupil: Pupil
        {
            public new void Study()
            {
                Console.WriteLine("GoodPupil Study");
            }
            public new void Read()
            {
                Console.WriteLine("GoodPupil Read");
            }
            public new void Write()
            {
                Console.WriteLine("GoodPupil Write");
            }
            public new void Relax()
            {
                Console.WriteLine("GoodPupil Relax");
            }
        }
        class BadPupil: Pupil
        {
            public new void Study()
            {
                Console.WriteLine("BadPupil Study");
            }
            public new void Read()
            {
                Console.WriteLine("BadPupil Read");
            }
            public new void Write()
            {
                Console.WriteLine("BadPupil Write");
            }
            public new void Relax()
            {
                Console.WriteLine("BadPupil Relax");
            }
        }
        static void Main(string[] args)
        {
            Pupil p1 = new Pupil();
            Pupil p2 = new Pupil();
            Pupil p3 = new Pupil();
            ClassRoom classRoom = new ClassRoom(p1,p2,p3);
            ExcelentPupil excelentPupil = new ExcelentPupil();
            GoodPupil goodPupil = new GoodPupil();
            BadPupil badPupil = new BadPupil();
            p1.Read();
        }
    }
}
