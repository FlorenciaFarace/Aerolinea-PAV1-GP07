﻿
namespace TrabajoPrácticoPAV.Formularios.TipoDoc
{
    partial class Frm_ABMTipoDoc
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
            this.cmb_tipoDoc = new TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_alta = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmb_tipoDoc
            // 
            this.cmb_tipoDoc.FormattingEnabled = true;
            this.cmb_tipoDoc.Location = new System.Drawing.Point(98, 98);
            this.cmb_tipoDoc.Name = "cmb_tipoDoc";
            this.cmb_tipoDoc.Pp_CampoAceptaNull = true;
            this.cmb_tipoDoc.Pp_EsPk = false;
            this.cmb_tipoDoc.Pp_MensajeError = null;
            this.cmb_tipoDoc.Pp_NombreCampo = "nombreTipoDoc";
            this.cmb_tipoDoc.Pp_NombreCampoInsert = null;
            this.cmb_tipoDoc.Pp_NombreTabla = "Tipo_Documento";
            this.cmb_tipoDoc.Pp_PkTabla = "tipoDoc";
            this.cmb_tipoDoc.Size = new System.Drawing.Size(274, 21);
            this.cmb_tipoDoc.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(162, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipos  Documento";
            // 
            // btn_alta
            // 
            this.btn_alta.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.btn_alta.Location = new System.Drawing.Point(98, 213);
            this.btn_alta.Name = "btn_alta";
            this.btn_alta.Size = new System.Drawing.Size(80, 23);
            this.btn_alta.TabIndex = 2;
            this.btn_alta.Text = "Agregar Nuevo";
            this.btn_alta.UseVisualStyleBackColor = true;
            this.btn_alta.Click += new System.EventHandler(this.btn_alta_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.btn_cancelar.Location = new System.Drawing.Point(297, 213);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 3;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.BackColor = System.Drawing.Color.White;
            this.btn_actualizar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_actualizar.Location = new System.Drawing.Point(401, 98);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(63, 21);
            this.btn_actualizar.TabIndex = 4;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.UseVisualStyleBackColor = false;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(203, 213);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_modificar.TabIndex = 5;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // Frm_ABMTipoDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(494, 308);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_alta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_tipoDoc);
            this.Name = "Frm_ABMTipoDoc";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Frm_ABMTipoDoc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Clase.ComboBox_Aerolinea cmb_tipoDoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_alta;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.Button btn_modificar;
    }
}