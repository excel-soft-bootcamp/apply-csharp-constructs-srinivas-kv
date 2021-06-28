using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TATACarApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TATACar _harrier = new TATACar(new MultiJetEngine());
            _harrier.Drive();
            _harrier.Halt();
            TATACar _nexon = new TATACar(new VeriCorEngine());
            _nexon.Drive();
            _nexon.Halt();
            TATACar _hexa = new TATACar(new RevorTron());
            _hexa.Drive();
            _hexa.Halt();
            TATACar _nano = new TATACar(new DiCorEngine());
            _nano.Drive();
            _nano.Halt();
            Console.ReadLine();
        }
    }
}
