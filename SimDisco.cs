using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulador_de_procesos
{
    namespace Simulador_de_procesos
    {
        public class SimuladorDisco
        {
            private Queue<Proceso> enSwap = new Queue<Proceso>();
            // Tamaño total del espacio swap disco
            private const int totalSwap = 2048; 

            public bool Agregar(Proceso p)
            {
                if (UsoActual() + p.TamañoMemoria <= totalSwap)
                {
                    // Agrega el proceso 
                    enSwap.Enqueue(p);
                    return true;
                }
                return false;
            }

            public Proceso ExtraerProceso()
            {
                if (enSwap.Count > 0)
                    // Saca el proceso del swap para enviar a RAM
                    return enSwap.Dequeue();
                return null;
            }

            public int UsoActual()
            {
                // En base a la memoria calcula su tamaño 
                return enSwap.Sum(p => p.TamañoMemoria);
            }

            public int SwapDisponible()
            {
                // Swap disponible
                return totalSwap - UsoActual();
            }
            // Cantidad de procesos en Swap 
            public int CantidadEnSwap() => enSwap.Count;

            public Queue<Proceso> ObtenerProcesosEnSwap() => new Queue<Proceso>(enSwap);
        }
    }
}
