using OtroRegistroConDetalle.BLL;
using OtroRegistroConDetalle.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtroRegistroConDetalle.UI.Consultas
{
    public partial class cUsuarios : Form
    {
        public cUsuarios()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            var lista = new List<Usuarios>();

            if (!string.IsNullOrWhiteSpace(FiltrocomboBox.Text))
            {
                switch (FiltrocomboBox.SelectedIndex)
                {
                    case 0: //UsuarioId
                        lista = UsuariosBLL.GetList(r => r.UsuarioId == Conversiones.ToInt(FiltrarTextBox.Text));
                        break;
                    case 1: //Alias
                        lista = UsuariosBLL.GetList(r => r.Alias.Contains(FiltrarTextBox.Text));
                        break;
                    case 2: //Nombre
                        lista = UsuariosBLL.GetList(r => r.Nombre.Contains(FiltrarTextBox.Text));
                        break;
                    case 3: //Email
                        lista = UsuariosBLL.GetList(r => r.Email.Contains(FiltrarTextBox.Text));
                        break;
                    case 4:// Rol
                        lista = UsuariosBLL.GetList(r => r.Rol.Contains(FiltrarTextBox.Text));
                        break;
                    default:
                        break;
                }
            }
            else
                lista = UsuariosBLL.GetList(r => true);

            if (FiltroFechacheckBox.Checked == true)
            {
                lista = lista.Where(r => r.FechaIngreso.Date >= FechaDesdedateTimePicker.Value.Date && r.FechaIngreso.Date <= FechaHastadateTimePicker.Value.Date).ToList();
            }

            if(ActivosRadioButton.Checked == true)
            {
                lista = lista.Where(r => r.Activo == true).ToList();
            }

            if (InactivosRadioButton.Checked == true)
            {
                lista = lista.Where(r => r.Activo == false).ToList();
            }

            ConsultasDataGridView.DataSource = null;
            ConsultasDataGridView.DataSource = lista;
        }
    }
}
