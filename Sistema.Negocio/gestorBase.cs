using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Data;
using System.IO;
//using System.Data.Odbc;
using System.Data.SqlClient;
using Sistema.Datos;

namespace Sistema.Negocio
{
    public class gestorBase
    {
        #region Metodos de Agregar
   
        public static void agregarFuncionario(Funcionario funcionarito)
        {
            string sentencia = "insert into funcionario(nombre,cedula,fechaNacimiento,perfil, salario) values(@nombre, @cedula, @fechaNacimiento, @perfil, @salario)";
            Parameter[] parametros = {
                                         new Parameter("@nombre",funcionarito.Nombre),
                                         new Parameter("@cedula",funcionarito.Cedula),
                                         new Parameter("@fechaNacimiento",funcionarito.FechaNacimiento),
                                         new Parameter("@perfil",funcionarito.Perfil),
                                         new Parameter("@salario",funcionarito.Salario)
                                      };
            Database.exectuteNonQuery(sentencia, parametros);
        }

        #endregion

        #region Metodos de Eliminar

        public static void eliminarFuncionario(Funcionario funcionarito)
        {
            string sentencia = "delete from funcionario where cedula = @cedula";
            Parameter[] parametros = {   new Parameter("@cedula",funcionarito.Cedula) };
            Database.exectuteNonQuery(sentencia, parametros);
        }

        #endregion

        #region Metodos de Actualizar

        public static void actualizarFuncionario(Funcionario funcionarito)
        {
            string sentencia = "update funcionario set nombre = @nombre,fechaNacimiento = @fechaNacimiento,perfil = @perfil, salario = @salario where cedula = @cedula";
            Parameter[] parametros = {
                                         new Parameter("@nombre",funcionarito.Nombre),
                                         new Parameter("@cedula",funcionarito.Cedula),
                                         new Parameter("@fechaNacimiento",funcionarito.FechaNacimiento),
                                         new Parameter("@perfil",funcionarito.Perfil),
                                         new Parameter("@salario",funcionarito.Salario)
                                      };
            Database.exectuteNonQuery(sentencia, parametros);
        }

        #endregion

        #region Metodos de Listar

        public static ArrayList listarFuncionarios()
        {
            string sentencia = "select * from funcionario ";
            Parameter[] parametros = {new Parameter("", 0) };
            DataSet datos = Database.executeDataset(sentencia, parametros);
            return ToFuncionarios(datos);
        }            


        public static ArrayList ToFuncionarios(DataSet datos)
        {
            Funcionario funcionarito;
            ArrayList lista = new ArrayList();
            foreach (DataRow fila in datos.Tables[0].Rows) 
            {
                funcionarito = new Funcionario();
                funcionarito.Nombre = (String)fila["nombre"];
                funcionarito.Cedula = (String)fila["cedula"];
                funcionarito.FechaNacimiento = (DateTime)fila["fechaNacimiento"];
                funcionarito.Perfil = (String)fila["perfil"];
                funcionarito.Salario = Double.Parse((String)fila["salario"]);
                lista.Add(funcionarito);
            }
            return lista;
        }

        #endregion

    }
}
