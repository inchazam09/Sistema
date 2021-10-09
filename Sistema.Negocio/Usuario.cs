using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Negocio
{
    public class Usuario
    {
        protected string nombre;
        protected string cedula;
        protected DateTime fechaNacimiento;

        public Usuario(string nombre, string cedula, DateTime fechaNacimiento)
        {
            this.Nombre = nombre;
            this.Cedula = cedula;
            this.FechaNacimiento = fechaNacimiento;
        }
        public Usuario()
        {
            this.Nombre = "";
            this.Cedula = "";
            this.FechaNacimiento = DateTime.Today;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Cedula { get => cedula; set => cedula = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
    }
}
