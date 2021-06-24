﻿
namespace TrabajoPrácticoPAV.Formularios.Teléfono
{
    partial class Frm_ABM_Teléfono
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
            this.dataGrid_telefonos = new System.Windows.Forms.DataGridView();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.numeroTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.chk_todos = new System.Windows.Forms.CheckBox();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.txt_nroTelefono = new Clase11.Clases.LabelText02();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_telefonos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid_telefonos
            // 
            this.dataGrid_telefonos.AllowUserToAddRows = false;
            this.dataGrid_telefonos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_telefonos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroTelefono,
            this.tipoDoc,
            this.numeroDoc});
            this.dataGrid_telefonos.Location = new System.Drawing.Point(44, 205);
            this.dataGrid_telefonos.Name = "dataGrid_telefonos";
            this.dataGrid_telefonos.Size = new System.Drawing.Size(376, 203);
            this.dataGrid_telefonos.TabIndex = 0;
            this.dataGrid_telefonos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_telefonos_CellClick);
            // 
            // btn_agregar
            // 
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btn_agregar.Location = new System.Drawing.Point(446, 239);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(90, 28);
            this.btn_agregar.TabIndex = 19;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_consultar
            // 
            this.btn_consultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_consultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btn_consultar.Location = new System.Drawing.Point(318, 102);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(90, 28);
            this.btn_consultar.TabIndex = 19;
            this.btn_consultar.Text = "Consultar";
            this.btn_consultar.UseVisualStyleBackColor = true;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btn_salir.Location = new System.Drawing.Point(446, 307);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(90, 28);
            this.btn_salir.TabIndex = 19;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btn_modificar.Location = new System.Drawing.Point(446, 205);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(90, 28);
            this.btn_modificar.TabIndex = 19;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(40, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(162, 21);
            this.label9.TabIndex = 21;
            this.label9.Text = "Consultar Teléfonos";
            // 
            // numeroTelefono
            // 
            this.numeroTelefono.HeaderText = "Nro. de teléfono";
            this.numeroTelefono.Name = "numeroTelefono";
            // 
            // tipoDoc
            // 
            this.tipoDoc.HeaderText = "tipoDocumento";
            this.tipoDoc.Name = "tipoDoc";
            // 
            // numeroDoc
            // 
            this.numeroDoc.HeaderText = "Nro. Documento";
            this.numeroDoc.Name = "numeroDoc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(234, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 21);
            this.label1.TabIndex = 23;
            this.label1.Text = "Teléfonos";
            // 
            // chk_todos
            // 
            this.chk_todos.AutoSize = true;
            this.chk_todos.Location = new System.Drawing.Point(68, 113);
            this.chk_todos.Name = "chk_todos";
            this.chk_todos.Size = new System.Drawing.Size(56, 17);
            this.chk_todos.TabIndex = 24;
            this.chk_todos.Text = "Todos";
            this.chk_todos.UseVisualStyleBackColor = true;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btn_eliminar.Location = new System.Drawing.Point(446, 273);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(90, 28);
            this.btn_eliminar.TabIndex = 19;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // txt_nroTelefono
            // 
            this.txt_nroTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nroTelefono.Location = new System.Drawing.Point(44, 78);
            this.txt_nroTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nroTelefono.Name = "txt_nroTelefono";
            this.txt_nroTelefono.Pp_ancho = 10;
            this.txt_nroTelefono.Pp_decimales = 2;
            this.txt_nroTelefono.Pp_Etiqueta = "Número de teléfono";
            this.txt_nroTelefono.Pp_mensajeError = null;
            this.txt_nroTelefono.Pp_nombre_campo = null;
            this.txt_nroTelefono.Pp_nombre_tabla = "Telefono";
            this.txt_nroTelefono.Pp_ReadOnly = false;
            this.txt_nroTelefono.Pp_Text = "";
            this.txt_nroTelefono.Pp_tipoDato = Clase11.Clases.LabelText02.TipoDato.texto;
            this.txt_nroTelefono.Pp_validable = false;
            this.txt_nroTelefono.Size = new System.Drawing.Size(228, 28);
            this.txt_nroTelefono.TabIndex = 26;
            // 
            // Frm_ABM_Teléfono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(227)))), ((int)(((byte)(187)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(609, 426);
            this.Controls.Add(this.txt_nroTelefono);
            this.Controls.Add(this.chk_todos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_consultar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.dataGrid_telefonos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_ABM_Teléfono";
            this.Text = "Frm_ABM_Teléfono";
            this.Load += new System.EventHandler(this.Frm_ABM_Teléfono_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_telefonos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid_telefonos;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chk_todos;
        private System.Windows.Forms.Button btn_eliminar;
        private Clase11.Clases.LabelText02 txt_nroTelefono;
    }
}