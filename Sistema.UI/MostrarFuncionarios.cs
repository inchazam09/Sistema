using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema.Negocio;

namespace Sistema.UI
{
    public partial class MostrarFuncionarios : Form
    {
        public MostrarFuncionarios()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MostrarFuncionarios_Load(object sender, EventArgs e)
        {
            try
            {
                this.dtgFuncionarios.DataSource = Gestor.mostrarFuncionarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ArrayList lista = (ArrayList)dtgFuncionarios.DataSource;
                if (lista == null)
                    MessageBox.Show("No hay funcionarios por eliminar");
                else
                {
                    int indice = dtgFuncionarios.CurrentRow.Index;
                    Funcionario funcionarito = (Funcionario)lista[indice];
                    Gestor.eliminarFuncionario(funcionarito);
                    dtgFuncionarios.DataSource = null;
                    this.dtgFuncionarios.DataSource = Gestor.mostrarFuncionarios();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ArrayList lista = (ArrayList)dtgFuncionarios.DataSource;
                if (lista == null)
                    MessageBox.Show("No hay funcionarios por actualizar");
                else
                {
                    int indice = dtgFuncionarios.CurrentRow.Index;
                    Funcionario funcionarito = (Funcionario)lista[indice];
                    AgregarUsuario actualiza = new AgregarUsuario(funcionarito);
                    actualiza.ShowDialog();
                    dtgFuncionarios.DataSource = null;
                    this.dtgFuncionarios.DataSource = Gestor.mostrarFuncionarios();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
