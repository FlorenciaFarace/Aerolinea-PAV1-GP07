﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TrabajoPrácticoPAV.Backend
{
    class Conexion_DB
    {
        public enum EstadoTransaccion { error, correcto }
        public enum TipoConexion { simple, transaccion }

        string cadenaConexion = @"Data Source=200.69.137.167,11333;Initial Catalog=BD3K6G07_2021;Persist Security Info=True;User ID=BD3K6G07_2021;Password=BDG07_6587";
        SqlConnection conexion = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlTransaction Transaccion;

        EstadoTransaccion ControlTransaccion = EstadoTransaccion.correcto;
        TipoConexion ControlConexion = TipoConexion.simple;

        public void InicioTransaccion()
        {
            ControlTransaccion = EstadoTransaccion.correcto;
            ControlConexion = TipoConexion.transaccion;
        }

        public EstadoTransaccion FinalTransaccion()
        {
            if (ControlConexion == TipoConexion.transaccion)
            {
                if (ControlTransaccion == EstadoTransaccion.correcto)
                {
                    Transaccion.Commit();
                }
                else
                {
                    Transaccion.Rollback();
                }
            }
            ControlConexion = TipoConexion.simple;
            Desconectar();
            return ControlTransaccion;
        }

        private void Conectar()
        {
            if (conexion.State != ConnectionState.Open)
            {
                conexion.ConnectionString = cadenaConexion;
                conexion.Open();
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.Text;

                if (ControlConexion == TipoConexion.transaccion)
                {
                    Transaccion = conexion.BeginTransaction(IsolationLevel.ReadCommitted);
                    cmd.Transaction = Transaccion;
                }
            }
        }
        private void Desconectar()
        {
            if (ControlConexion == TipoConexion.simple)
            {
                conexion.Close();
            }

        }

        public DataTable EjecutarSelect(string sql)
        {
            Conectar();
            cmd.CommandText = sql;
            DataTable tabla = new DataTable();
            try
            {
                tabla.Load(cmd.ExecuteReader());
            }
            catch (Exception e)
            {
                ControlTransaccion = EstadoTransaccion.error;
                MessageBox.Show("Error en la consulta: \n "
                                 + sql + "\n"
                                 + "El mensaje de error es: \n"
                                 + e.Message);
            }

            Desconectar();
            return tabla;
        }
        public EstadoTransaccion Insertar(string SqlInsertar)
        {
            return InsModBorr(SqlInsertar);

        }
        public EstadoTransaccion Modificar(string SqlModificar)
        {
            return InsModBorr(SqlModificar);
        }
        public EstadoTransaccion Borrar(string SqlBorrar)
        {
            return InsModBorr(SqlBorrar);
        }
        private EstadoTransaccion InsModBorr(string sql)
        {
            Conectar();
            cmd.CommandText = sql;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                ControlTransaccion = EstadoTransaccion.error;
                MessageBox.Show("Error en el comando: \n "
                                 + sql + "\n"
                                 + "El mensaje de error es: \n"
                                 + e.Message);
            }
            Desconectar();
            return ControlTransaccion;


        }
    }
}
