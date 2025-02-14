﻿namespace TrabajoPrácticoPAV.Formularios.Provincia
{
    partial class Frm_BajaProvincia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_Pais = new TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea();
            this.btn_cancelar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.btn_eliminar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nombre = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.BarraSuperior = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_idProvincia = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.BarraSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label1.Location = new System.Drawing.Point(26, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 84;
            this.label1.Text = "País";
            // 
            // cmb_Pais
            // 
            this.cmb_Pais.Enabled = false;
            this.cmb_Pais.FormattingEnabled = true;
            this.cmb_Pais.Location = new System.Drawing.Point(89, 86);
            this.cmb_Pais.Name = "cmb_Pais";
            this.cmb_Pais.Pp_CampoAceptaNull = false;
            this.cmb_Pais.Pp_EsPk = false;
            this.cmb_Pais.Pp_MensajeError = "Seleccione un país";
            this.cmb_Pais.Pp_NombreCampo = "nombrePais";
            this.cmb_Pais.Pp_NombreCampoInsert = "idPais";
            this.cmb_Pais.Pp_NombreTabla = "Pais";
            this.cmb_Pais.Pp_PkTabla = "idPais";
            this.cmb_Pais.Size = new System.Drawing.Size(141, 24);
            this.cmb_Pais.TabIndex = 83;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btn_cancelar.Location = new System.Drawing.Point(377, 159);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Pp_Presionado = false;
            this.btn_cancelar.Size = new System.Drawing.Size(120, 34);
            this.btn_cancelar.TabIndex = 80;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btn_eliminar.Location = new System.Drawing.Point(225, 159);
            this.btn_eliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Pp_Presionado = false;
            this.btn_eliminar.Size = new System.Drawing.Size(120, 34);
            this.btn_eliminar.TabIndex = 79;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label2.Location = new System.Drawing.Point(528, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 82;
            this.label2.Text = "Nombre";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Enabled = false;
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txt_nombre.Location = new System.Drawing.Point(617, 85);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Pp_EsPk = false;
            this.txt_nombre.Pp_MensajeError = "Ingrese un nombre";
            this.txt_nombre.Pp_NombreCampo = "nombreProvincia";
            this.txt_nombre.Pp_NombreTabla = "Provincia";
            this.txt_nombre.Size = new System.Drawing.Size(141, 27);
            this.txt_nombre.TabIndex = 78;
            // 
            // BarraSuperior
            // 
            this.BarraSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.BarraSuperior.Controls.Add(this.label15);
            this.BarraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.BarraSuperior.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BarraSuperior.Name = "BarraSuperior";
            this.BarraSuperior.Size = new System.Drawing.Size(775, 39);
            this.BarraSuperior.TabIndex = 81;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(12, 7);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(221, 27);
            this.label15.TabIndex = 4;
            this.label15.Text = "BORRAR PROVINCIA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label3.Location = new System.Drawing.Point(251, 88);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 86;
            this.label3.Text = "Id provincia";
            // 
            // txt_idProvincia
            // 
            this.txt_idProvincia.Enabled = false;
            this.txt_idProvincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txt_idProvincia.Location = new System.Drawing.Point(366, 85);
            this.txt_idProvincia.Margin = new System.Windows.Forms.Padding(4);
            this.txt_idProvincia.Name = "txt_idProvincia";
            this.txt_idProvincia.Pp_EsPk = true;
            this.txt_idProvincia.Pp_MensajeError = "Ingrese un nombre";
            this.txt_idProvincia.Pp_NombreCampo = "idProvincia";
            this.txt_idProvincia.Pp_NombreTabla = "Provincia";
            this.txt_idProvincia.Size = new System.Drawing.Size(141, 27);
            this.txt_idProvincia.TabIndex = 85;
            // 
            // Frm_BajaProvincia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 229);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_idProvincia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_Pais);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.BarraSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_BajaProvincia";
            this.Text = "Frm_BajaProvincia";
            this.Load += new System.EventHandler(this.Frm_BajaProvincia_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BarraSuperior_MouseMove);
            this.BarraSuperior.ResumeLayout(false);
            this.BarraSuperior.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Clase.ComboBox_Aerolinea cmb_Pais;
        private Clase.Button_Aerolinea btn_cancelar;
        private Clase.Button_Aerolinea btn_eliminar;
        private System.Windows.Forms.Label label2;
        private Clase.TextBox_Aerolinea txt_nombre;
        private System.Windows.Forms.Panel BarraSuperior;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label3;
        private Clase.TextBox_Aerolinea txt_idProvincia;
    }
}