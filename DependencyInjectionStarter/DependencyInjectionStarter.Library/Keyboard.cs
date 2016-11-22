using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionStarter.Library
{
    public class Keyboard : IInstrument
    {
        public string PlayKeys()
        {
            return "pling plong pling";
        }

        public string MakeSound()
        {
            return PlayKeys();
        }
    }
}
