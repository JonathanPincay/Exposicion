using System;
using System.Collections.Generic;
using System.Text;

namespace Expo
{
    public class EstadoRojo:EstadoSemaforo
    {
        public EstadoRojo(Semaforo objSemaforo)
        {
            this.objSemaforo = objSemaforo;
        }
        public override void mostrar()
        {
            Console.WriteLine("Luz Roja");
        }
    }
}
