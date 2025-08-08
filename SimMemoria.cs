using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulador_de_procesos
{
    public class SimuladorMemoria
    {
        private List<Proceso> procesos = new List<Proceso>();
        // Espacio en memoria 
        private const int totalMemoria = 1024;

        public bool Agregar(Proceso p)
        {
            // Verifica que tenga espacio en memoria
            if (UsoActual() + p.TamañoMemoria <= totalMemoria)
            {
                // Lo añade
                procesos.Add(p);
                // Envia true = se agrego el proceso
                return true;
            }
            // No lo pudo agregar
            return false;
        }

        public bool Eliminar(Proceso p)
        {
            // Elima procesos, utilizado para eliminar proceso finalizados 
            return procesos.Remove(p);
        }

        public int UsoActual()
        {
            // Uso actual
            return procesos.Sum(p => p.TamañoMemoria);
        }

        public int MemoriaDisponible()
        {
            // Memoria disponibles
            return totalMemoria - UsoActual();
        }

        public List<Proceso> ObtenerProcesos() => procesos;
    }
}
