using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TATACarApp
{
    class TATACar
    {
        ICarEngine _Engine;
        public TATACar(ICarEngine Engine)
        {
            this._Engine = Engine;
        }
    
         public void Drive()
        {
            _Engine.Start();
        }
        public void Halt()
        {
            _Engine.Stop();
        }

    }
}

