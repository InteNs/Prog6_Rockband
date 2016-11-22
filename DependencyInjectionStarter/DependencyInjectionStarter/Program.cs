using DependencyInjectionStarter.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionStarter
{
    class Program
    {
        static void Main(string[] args)
        {
            var rockBand1 = new RockBand(new Guitar(), new Guitar(), new BassGuitar(), new Drums(), new Vocal());
            var rockBand2 = new RockBand(new Guitar(), new BassGuitar(), new Drums(), new Vocal(), new Keyboard());
            Console.WriteLine("--band 1---");
            rockBand1.DoSoundCheck();
            Console.WriteLine("--band 2---");
            rockBand2.DoSoundCheck();
            Console.ReadLine();
        }
    }
}
