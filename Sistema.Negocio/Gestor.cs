using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Sistema.Negocio
{
     public class Gestor
    {

         #region  Metodos de Agregar
   
         public static void agregarFuncionario(Funcionario funcionarito)
         {
             try
             {
                 gestorBase.agregarFuncionario(funcionarito);
             }
             catch (Exception ex)
             {
                 throw ex;
             }
         }

        #endregion

        #region  Metodos de Mostrar

        public static ArrayList mostrarFuncionarios()
        {
            try
            {
                return gestorBase.listarFuncionarios();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region  Metodos de Eliminar

        public static void eliminarFuncionario(Funcionario funcionarito)
        {
            try
            {
                gestorBase.eliminarFuncionario(funcionarito);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region  Metodos de Actualizar

        public static void actualizarFuncionario(Funcionario funcionarito)
        {
            try
            {
                gestorBase.actualizarFuncionario(funcionarito);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

    }
}
