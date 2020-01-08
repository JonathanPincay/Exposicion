using System;
using System.Collections.Generic;
using System.Text;

namespace Expo
{
    public class EstadoNaranja:EstadoSemaforo
    {
        public EstadoNaranja(Semaforo objSemaforo)
        {
            this.objSemaforo = objSemaforo;
        }
        public override void mostrar()
        {
            Console.WriteLine("Luz Naranja");
        }
    }
}
