using Simulador_de_procesos.Simulador_de_procesos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulador_de_procesos
{
    public partial class Form1 : Form
    {
        // Instancias del simulador 
        SimuladorCPU cpu;
        SimuladorMemoria memoria;
        SimuladorDisco disco;

        public Form1()
        {
            InitializeComponent();

            // Inicializar Round Robin de 1000ms y instancias del simulador
            cpu = new SimuladorCPU(quantum: 1000); 
            // 1024MB Ram
            memoria = new SimuladorMemoria();
            // Disco para memorial virtual de 2048MB
            disco = new SimuladorDisco();
            // Inicia el timer del form
            timerSimulacion.Start();

            progressMemoria.Style = ProgressBarStyle.Continuous;
            progressMemoria.BackColor = Color.FromArgb(0xF5, 0xF0, 0xF6);
        }

        // Actualiza la barra de disco 
        private void ActualizarDisco()
        {
            // Captura el uso actual
            int uso = disco.UsoActual();
            // Capacidad del disco
            progressDisco.Maximum = 2048;
            // Uso actual
            progressDisco.Value = uso;
            // Muestra el uso actual
            lblDisco.Text = $"Swap: {uso}MB / 2048MB";
        }
        // Ejecuta los procesos en el CPU
        private void EjecutarCPU()
        {
            // Obtiene los prcesos de la cola y ejecuta
            var proceso = cpu.Ejecutar();
            // Verifica que la cola tenga un proceso
            if (proceso != null)
            {
                // Muestra el nombre del proceso 
                lblCPU.Text = "CPU: " + proceso.Nombre;
                // Define el tiempo total del proceso
                progressCPU.Maximum = proceso.TiempoTotal;
                // Muestra si estado actual restando el tiempo que le queda al total
                progressCPU.Value = proceso.TiempoTotal - proceso.TiempoRestante;
                // Muestra el proceso en el listBox
                Log.Items.Insert(0, $"[CPU] Ejecutando {proceso.Nombre}");

                // Verifica si el proceso termino y liberar memoria
                if (proceso.TiempoRestante <= 0)
                {
                    // Elimina el proceso
                    bool eliminado = memoria.Eliminar(proceso);
                    if (eliminado)
                    {
                        // Muestra el mensaje en el listBox del proceso finalizado 
                        Log.Items.Insert(0, $"[FINALIZADO] Proceso {proceso.Nombre} terminado y liberado de memoria.");
                    }
                }
            }
            // Si no tiene procesos 
            else
            {
                // Mensaje del CPU
                lblCPU.Text = "CPU: Inactiva";
                // Barra vacia
                progressCPU.Value = 0;
            }
        }
        // Actualiza la barra de memoria 
        private void ActualizarMemoria()
        {
            // Obtiene el uso
            int uso = memoria.UsoActual();
            // Define el maximo de la barra
            progressMemoria.Maximum = 1024;
            // Define el valor de uso en la barra
            progressMemoria.Value = uso;
            // Muestra el uso en la lblMemoria
            lblMemoria.Text = $"Memoria: {uso}MB / 1024MB";
        }
        // Al no entrar procesos en RAM el disco actua como memoria virtual
        private void MoverProcesosDesdeSwap()
        {
            // Intentar mover procesos desde el disco a la RAM
            Queue<Proceso> procesosEnSwap = disco.ObtenerProcesosEnSwap();
            // Guarda los intento en Swap
            int intentos = procesosEnSwap.Count;
            // Mientras intentos sean mayor a 0 ejecuta en bucle
            while (intentos-- > 0)
            {
                // Saca procesos del swap
                Proceso p = disco.ExtraerProceso();
                // Lo pasa a RAM
                if (memoria.Agregar(p))
                {
                    // Si pasa el if lo añade al CPU
                    cpu.Agregar(p);
                    // Muestra mensaje del cambio
                    Log.Items.Insert(0, $"[SWAP→RAM] Proceso {p.Nombre} cambió de disco a memoria.");
                }
                // Si no entra 
                else
                {
                    // No hay espacio vuelve al swap 
                    disco.Agregar(p);
                    // Break para eviar bucles innecesarios 
                    break; 
                }
            }
        }
        // Resumen del estado actual
        private void btnReporte_Click(object sender, EventArgs e)
        {
            // Limpia el listbox
            Resumen.Items.Clear();
            // Mensaje
            Resumen.Items.Add("Resumen de procesos en RAM:");
            // Busca en memoria, obtiene y muestra los datos
            foreach (var p in memoria.ObtenerProcesos())
            {
                Resumen.Items.Add($"Proceso: {p.Nombre}, Memoria: {p.TamañoMemoria}, Tiempo restante: {p.TiempoRestante}");
            }
            // Busca en CPU, obtiene y muestra los datos
            Resumen.Items.Add($"Procesos en CPU: {cpu.ProcesosEnCola()}");
            // Busca en SWAP, obtiene y muestra los datos
            Resumen.Items.Add($"Procesos en SWAP: {disco.CantidadEnSwap()}");
            // Busca en Disco, obtiene y muestra los datos
            Resumen.Items.Add($"Uso de SWAP: {disco.UsoActual()}MB / 2048MB");
        }
        // Crear nuevos procesos
        private void btnCrearProceso_Click_1(object sender, EventArgs e)
        {



            // Captura los datos
            string nombre = txtNombreProceso.Text;
            int duracion = (int)nudDuracion.Value;
            int memoriaMB = (int)nudTamanio.Value;

          

  

            // Validación de entradas
            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Ingrese un nombre válido");
                return;
            }

            if (duracion <= 0 || memoriaMB <= 0)
            {
                MessageBox.Show("Duración y tamaño de memoria deben ser mayores a 0");
                return;
            }
            // Crea el proceso
            Proceso nuevo = new Proceso(nombre, duracion, memoriaMB);

            // Intentar cargar en memoria
            if (memoria.Agregar(nuevo))
            {
                // Si pasa lo agrega
                cpu.Agregar(nuevo);
                // Lo muestra en el log
                Log.Items.Insert(0, $"[RAM] Proceso {nombre} agregado.");
            }
            // Si no cabe RAM lo envia a swap
            else if (disco.Agregar(nuevo))
            {
                // Mensaje
                Log.Items.Insert(0, $"[SWAP] Proceso {nombre} enviado al disco.");
            }
            // Si no pasa las validaciones anteriores
            else
            {
                MessageBox.Show("No hay suficiente memoria ni espacio en disco para este proceso.");
                Log.Items.Insert(0, $"[ERROR] Proceso {nombre} descartado por falta de espacio.");
            }

            txtNombreProceso.Clear();
        }

        // Timer para actualizar la simulación cada segundo
        private void timerSimulacion_Tick_1(object sender, EventArgs e)
        {
            // Procesos de swap a ram
            MoverProcesosDesdeSwap(); 
            // Ejecutar el proceso actual
            EjecutarCPU();
            // Actualizar barra de memoria
            ActualizarMemoria();
            //Actualizar barra disco
            ActualizarDisco();
        }

  

        private void btn_discord_Click(object sender, EventArgs e)          
        {
            string nombre = "Discord";
            int duracion = 506, memoriaMB = 250;
            // Crea el proceso
            Proceso nuevo = new Proceso(nombre, duracion, memoriaMB);

            // Intentar cargar en memoria
            if (memoria.Agregar(nuevo))
            {
                // Si pasa lo agrega
                cpu.Agregar(nuevo);
                // Lo muestra en el log
                Log.Items.Insert(0, $"[RAM] Proceso {nombre} agregado.");
            }
            // Si no cabe RAM lo envia a swap
            else if (disco.Agregar(nuevo))
            {
                // Mensaje
                Log.Items.Insert(0, $"[SWAP] Proceso {nombre} enviado al disco.");
            }
            // Si no pasa las validaciones anteriores
            else
            {
                MessageBox.Show("No hay suficiente memoria ni espacio en disco para este proceso.");
                Log.Items.Insert(0, $"[ERROR] Proceso {nombre} descartado por falta de espacio.");
            }
        }

        private void btn_teams_Click(object sender, EventArgs e)
        {
            string nombre = "Teams";
            int duracion = 4354, memoriaMB = 250;
            Proceso nuevo = new Proceso(nombre, duracion, memoriaMB);

            if (memoria.Agregar(nuevo))
            {
                cpu.Agregar(nuevo);
                Log.Items.Insert(0, $"[RAM] Proceso {nombre} agregado");
            }
            else if (disco.Agregar(nuevo))
            {
                Log.Items.Insert(0, $"[SWAP] Proceso {nombre} enviado al disco");

            }
            else
            {
                MessageBox.Show("No hay suficiente memoria ni espacio en disco para este proceso.");
                Log.Items.Insert(0, $"[ERROR] Proceso {nombre} descartado por falta de espacio.");
            }

        }

        private void btn_excel_Click(object sender, EventArgs e)
        {
            string nombre = "Excel";
            int duracion = 5465, memoriaMB = 798;
            Proceso nuevo = new Proceso(nombre, duracion, memoriaMB);


            if (memoria.Agregar(nuevo))
            {
                cpu.Agregar(nuevo);
                Log.Items.Insert(0, $"[RAM] Procesp {nombre} agregado");

            }
            else if(disco.Agregar(nuevo)){
                Log.Items.Insert(0, $"[SWAP] Proceso {nombre} enviado al disco");

            }
            else
            {
                MessageBox.Show("No hay suficiente memoria ni espacio en disco para este proceso.");
                Log.Items.Insert(0, $"[ERROR] Proceso {nombre} descartado por falta de espacio ");
            }
        }
    }
}
