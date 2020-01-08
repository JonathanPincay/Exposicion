using System;
using System.Collections.Generic;
using System.Text;

namespace Expo
{
    public abstract class EstadoSemaforo
    {
        protected Semaforo objSemaforo;
        // Método que deberán crear las clases que hereden de ésta
        public abstract void mostrar();
    }
}
