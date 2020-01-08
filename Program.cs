using System;

namespace Expo
{
    class Program
    {
             static void Main(string[] args)
            {
                Semaforo objSemaforo = new Semaforo();
                // Muestra el aviso por defecto (verde, no hay alerta)
                objSemaforo.mostrarAviso();
                objSemaforo.setEstado(new EstadoNaranja(objSemaforo));
                objSemaforo.mostrarAviso();
                objSemaforo.setEstado(new EstadoRojo(objSemaforo));
                objSemaforo.mostrarAviso();
            }
    }
}

