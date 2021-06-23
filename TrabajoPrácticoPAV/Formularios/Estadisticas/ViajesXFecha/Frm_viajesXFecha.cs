﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using TrabajoPrácticoPAV.NE_Usuarios;

namespace TrabajoPrácticoPAV.Formularios.Estadisticas.ViajesXFecha
{
    public partial class Frm_viajesXFecha : Form
    {
        NE_Viajes viajes = new NE_Viajes();
        public Frm_viajesXFecha()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void Frm_viajesXFecha_Load(object sender, EventArgs e)
        {

            this.rv_1.RefreshReport();
        }

        private void button_Aerolinea1_Click(object sender, EventArgs e)
        {
           string fecha = msk_fecha.Text;
           MessageBox.Show(fecha);
           ArmarReporteUsuario01(viajes.RecuperarViajesXFecha(fecha));
        }
        private void ArmarReporteUsuario01(DataTable tabla) 
        {
            ReportDataSource PaqueteDatos = new ReportDataSource("ViajesXFecha", tabla);
            rv_1.LocalReport.ReportEmbeddedResource = "TrabajoPrácticoPAV.Formularios.Estadisticas.ViajesXFecha.ViajesXFecha.rdlc";
            rv_1.LocalReport.DataSources.Clear();
            rv_1.LocalReport.DataSources.Add(PaqueteDatos);
            rv_1.RefreshReport();
        }
    }
}
