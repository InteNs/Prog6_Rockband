using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionStarter.Library
{
    public class RockBand
    {
        private List<IInstrument> Instruments { get; set; }

        public RockBand(params IInstrument[] instruments)
        {
           Instruments = new List<IInstrument>(instruments);
        }
        public void DoSoundCheck()
        {
            Instruments.ForEach(i => Console.WriteLine(i.MakeSound()));
        }
    }
}
