using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Negocio
{
    public class Estudiante : Usuario
    {
        private int cantidadMaterias;
        private double pago;

        public Estudiante():base()
        {
            this.cantidadMaterias = 0;
            this.pago = 0;
        }

        public Estudiante(string nombre, string cedula, DateTime fechaNacimiento, int cantidadMaterias, double pago) : base(nombre, cedula, fechaNacimiento)
        {
            this.cantidadMaterias = cantidadMaterias;
            this.pago = pago;
        }

        public int CantidadMaterias { get => cantidadMaterias; set => cantidadMaterias = value; }
        public double Pago { get => pago; set => pago = value; }
    }
}
