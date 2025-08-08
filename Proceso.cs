using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulador_de_procesos
{
    public class Proceso
    {
        public string Nombre { get; set; }
        public int TiempoTotal { get; set; }
        public int TiempoRestante { get; set; }
        public int TamañoMemoria { get; set; }

        public Proceso(string nombre, int tiempo, int memoria)
        {
            Nombre = nombre;
            TiempoTotal = tiempo;
            TiempoRestante = tiempo;
            TamañoMemoria = memoria;
        }
    }
}
