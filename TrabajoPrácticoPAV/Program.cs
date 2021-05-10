﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoPrácticoPAV.Formularios;
using TrabajoPrácticoPAV.Formularios.Provincia;
using TrabajoPrácticoPAV.Formularios.Pais;
using TrabajoPrácticoPAV.Formularios.Tripulacion;
using TrabajoPrácticoPAV.Formularios.Ciudad;

namespace TrabajoPrácticoPAV
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Frm_Ciudad());
        }
    }
}
