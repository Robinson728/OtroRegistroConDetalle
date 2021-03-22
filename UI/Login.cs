using OtroRegistroConDetalle.BLL;
using OtroRegistroConDetalle.UI.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtroRegistroConDetalle.UI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void IngresarButton_Click(object sender, EventArgs e)
        {

            if (UsuariosBLL.Validar(UsuarioTextBox.Text, ClaveTextBox.Text))
            {
                MainForms main = new MainForms();
                main.Show();
            }
            else
            {
                MessageBox.Show("Error Nombre Usuario o Contraseña incorrecta!", "Error!");
                UsuarioTextBox.Clear();
                ClaveTextBox.Focus();
            }
        }

        private void RegistrarseButton_Click(object sender, EventArgs e)
        {
            rUsuarios usuarios = new rUsuarios();
            usuarios.Show();
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
