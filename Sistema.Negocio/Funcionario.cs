using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Negocio
{
    public class Funcionario : Usuario
    {
        private string perfil;
        private double salario;

        public Funcionario(string nombre, string cedula, DateTime fechaNacimiento, string perfil, double salario):base(nombre, cedula, fechaNacimiento)
        {
            this.perfil = perfil;
            this.salario = salario;
        }

        public Funcionario() : base()
        {
            this.perfil = "";
            this.salario = 0;
        }

        public string Perfil { get => perfil; set => perfil = value; }
        public double Salario { get => salario; set => salario = value; }
    }
}
