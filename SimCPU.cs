using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulador_de_procesos
{
    public class SimuladorCPU
    {
        // Cola de procesos
        private Queue<Proceso> cola = new Queue<Proceso>();
        // Tiempo por ciclo 
        private int quantum;

        public SimuladorCPU(int quantum)
        {
            this.quantum = quantum;
        }

        public void Agregar(Proceso p)
        {
            // Agrega proceso a cola
            cola.Enqueue(p);
        }

        public Proceso Ejecutar()
        {
            // Verifica si hay proceso en cola
            if (cola.Count == 0) return null;
            // Saca el primer proceso de cola (FIFO)
            Proceso actual = cola.Dequeue();
            // Obtiene el tiempo a ejecutar
            int ejecutar = (actual.TiempoRestante > quantum) ? quantum : actual.TiempoRestante;
            // Baja el tiempo restante del proceso
            actual.TiempoRestante -= ejecutar;
            // Verifica si termino
            if (actual.TiempoRestante > 0)
                // Si no termina vuelve a la cola
                cola.Enqueue(actual);
            // De vuelve el proceso
            return actual;
        }

        public int ProcesosEnCola() => cola.Count;
    }
}
