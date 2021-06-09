﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using TrabajoPrácticoPAV.Backend;

namespace TrabajoPrácticoPAV.NE_Usuarios
{
    class NE_Avion
    {
        public int Pp_numero_modelo { get; set; }
        public int Pp_id_modelo { get; set; }

        Conexion_DB _BD = new Conexion_DB();


        public DataTable RecuperarTodos()
        {
            string sql = @"SELECT Avion.numeroPorModelo, Modelo.nombre, Avion.idModelo from Avion inner join  Modelo on Avion.idModelo = Modelo.idModelo order by Modelo.nombre, Avion.numeroPorModelo,Avion.idModelo";
            return _BD.EjecutarSelect(sql);
        }

        public DataTable RecuperarPorNumModelo(string numModelo)
        {
            string sql = $"SELECT * FROM Avion WHERE numeroPorModelo = {numModelo}";
            return _BD.EjecutarSelect(sql);
        }

        public DataTable RecuperarPorIdModelo(string idModelo)
        {
            string sql = $"SELECT * FROM Avion WHERE idModelo = {idModelo}";
            return _BD.EjecutarSelect(sql);
        }

        public void Insertar()
        {
            string sqlInsertar = @"INSERT INTO Avion (numeroPorModelo, idModelo) " + " VALUES ( " + Pp_numero_modelo + ", " + Pp_id_modelo + ")";
            _BD.Insertar(sqlInsertar, false);
        }
 
        public DataTable Recuperar_Mixto(string numero, string modelo)
        {
            string sql = @"SELECT Avion.numeroPorModelo, Modelo.nombre,  Avion.idModelo from Avion "
            + " inner join Modelo on Avion.idModelo = Modelo.idModelo "
            + "  where Avion.numeroPorModelo LIKE " + "'" + numero + "%' and Modelo.nombre = '" + modelo + "'";
            return _BD.EjecutarSelect(sql);
        }

        public DataTable Recuperar_x_modelo(string modelo)
        {
            string sql = @"SELECT Avion.numeroPorModelo, Modelo.nombre,  Avion.idModelo from Avion "
            + " inner join Modelo on Avion.idModelo = Modelo.idModelo "
            + " where Modelo.nombre = '" + modelo + "'";
            return _BD.EjecutarSelect(sql);
        }
        
        public DataTable Recuperar_x_numero(string patronNumero)
        {
            string sql = @"SELECT Avion.numeroPorModelo, Modelo.nombre,  Avion.idModelo from Avion "
            + " inner join Modelo on Avion.idModelo = Modelo.idModelo "
            + " where Avion.numeroPorModelo LIKE " + "'"+ patronNumero+ "%'" ;
            return _BD.EjecutarSelect(sql);
        }

        public void Remover_avion(string numero , object idModelo)
        {
            string sql = @"delete from Avion where numeroPorModelo = '" + numero + "' and  idModelo= " + idModelo;
            _BD.EjecutarSelect(sql);
             
            //_BD.Borrar(sql, false);
        }


        //public DataTable Editar_avion (string numero , object idModelo)
        // {
        //     string sql = @"Update Avion set Avion.numeroPorModelo = " + numero + ", Avion.idModelo= " + idModelo
        //     + " where Avion.numeroPorModelo = " + numero;
        //     return _BD.EjecutarSelect(sql);

        // }

        public DataTable RecuperarTodosReporte()
        {
            string sql = @"SELECT Avion.numeroPorModelo, Modelo.nombre from Avion inner join  Modelo on Avion.idModelo = Modelo.idModelo order by Modelo.nombre, Avion.numeroPorModelo";
            DataTable tabla = new DataTable();
            tabla = _BD.EjecutarSelect(sql);
            return tabla;
        }
    }
}


