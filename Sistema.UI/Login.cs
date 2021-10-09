using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.UI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtUsuario.Text != "" && this.txtClave.Text != "")
                {
                    // BD para validar el usuario
                    Principal inicio = new Principal();
                    inicio.stsUsuario.Text = "Usuario: " + this.txtUsuario.Text;
                    inicio.Show();
                    this.Hide();
                }
                else MessageBox.Show("Debe llenar todos los datos");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
