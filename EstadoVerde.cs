using System;
using System.Collections.Generic;
using System.Text;

namespace Expo
{
    public class EstadoVerde:EstadoSemaforo
    {
        public EstadoVerde(Semaforo objSemaforo)
        {
            this.objSemaforo = objSemaforo;
        }
        public override void mostrar()
        {
            Console.WriteLine("Luz verde");
        }
    }
}
