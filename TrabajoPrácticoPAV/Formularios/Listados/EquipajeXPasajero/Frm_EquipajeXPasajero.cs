﻿using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoPrácticoPAV.Clase;
using TrabajoPrácticoPAV.NE_Usuarios;

namespace TrabajoPrácticoPAV.Formularios.Listados.EquipajeXPasajero
{
    public partial class Frm_EquipajeXPasajero : Form
    {
        NE_Equipaje tripulacion = new NE_Equipaje();
        DataTable tabla = new DataTable();

        public Frm_EquipajeXPasajero()
        {
            InitializeComponent();
        }
        
        private void Frm_EquipajeXPasajero_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);
            cmb_TipoDoc.CargarCombo();
            this.reportViewer1.RefreshReport();
        }

        private void ArmarReporteEquipaje01()
        {
            ReportDataSource PaqueteDatos = new ReportDataSource("DataSet1", tabla);
            reportViewer1.LocalReport.ReportEmbeddedResource = "TrabajoPrácticoPAV.Formularios.Listados.EquipajeXPasajero.ReporteEquipaje.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(PaqueteDatos);
            reportViewer1.RefreshReport();            
            MessageBox.Show(tabla.Rows.Count.ToString());
            
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {

            if (rbu_Pasajero.Checked && cmb_TipoDoc.SelectedIndex != -1 && msk_NroDoc.Text != "")
            {
                tabla = tripulacion.RecuperarPorPasajero(cmb_TipoDoc.Text, msk_NroDoc.Text);
                if (tabla.Rows.Count != 0)
                    ArmarReporteEquipaje01();
                else
                {
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.RefreshReport();
                    MessageBox.Show("No se encontraron resultados");
                }
            }
            if (rbu_Peso.Checked)
            {

                if (int.Parse(txt_Desde.Text) > int.Parse(txt_Hasta.Text))
                {
                    MessageBox.Show("El rango no es válido. Por favor ingrese nuevamente un rango.");
                }
                string desde = "";
                string hasta = "";

                if (txt_Desde.Text == "")
                    desde = "0";
                else
                    desde = txt_Desde.Text;
                if (txt_Hasta.Text == "")
                    hasta = "99999";
                else
                    hasta = txt_Hasta.Text;

                tabla = tripulacion.RecuperarPorRango(desde, hasta);
                if (tabla.Rows.Count != 0)
                    ArmarReporteEquipaje01();
                else
                {
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.RefreshReport();
                    MessageBox.Show("No se encontraron resultados");
                }
            }

            if (rbu_Todos.Checked)
            {
                tabla = tripulacion.RecuperarEquipaje();
                if (tabla.Rows.Count != 0)
                    ArmarReporteEquipaje01();
                else
                {
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.RefreshReport();
                    MessageBox.Show("No se encontraron resultados");
                }
            }
        }
    }
}

        


