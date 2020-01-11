using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        public interface IPlayable
        {
            void Play();
            void Pause();
            void Stop();
        }
        public interface IRecodable
        {
            void Record();
            void Pause();
            void Stop();
        }
        class Player : IPlayable, IRecodable
        {
            public void Pause()
            {
                Console.WriteLine("Pause Playable");
            }

            public void Play()
            {
                Console.WriteLine("Play Playable");
            }
            public void Stop()
            {
                Console.WriteLine("Stop Playable");
            }

            public void Record()
            {
                Console.WriteLine("Record Recodable");
            }
             void IRecodable.Pause()
            {
                Console.WriteLine("Pause Recodable");
            }
             void IRecodable.Stop()
            {
                Console.WriteLine("Stop Recodable");
            }

        }
        static void Main(string[] args)
        {
            Player pl = new Player();
            pl.Record();
            ((IRecodable)pl).Pause();
            ((IRecodable)pl).Stop();
            pl.Play();
            pl.Pause();
            pl.Stop();
            Console.ReadKey();
        }
    }
}
