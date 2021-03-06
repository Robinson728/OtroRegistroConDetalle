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
    public partial class cRoles : Form
    {
        public cRoles()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            var lista = new List<Roles>();

            if (!string.IsNullOrWhiteSpace(FiltrocomboBox.Text))
            {
                switch (FiltrocomboBox.SelectedIndex)
                {
                    case 0: //RolId
                        lista = RolesBLL.GetList(r => r.RolId == Conversiones.ToInt(FiltrarTextBox.Text));
                        break;
                    case 1: //Descripcion
                        lista = RolesBLL.GetList(r => r.Descripcion.Contains(FiltrarTextBox.Text));
                        break;
                    default:
                        break;
                }
            }
            else
                lista = RolesBLL.GetList(r => true);

            if (FiltroFechacheckBox.Checked == true)
            {
                lista = lista.Where(r => r.FechaCreacion.Date >= FechaDesdedateTimePicker.Value.Date && r.FechaCreacion.Date <= FechaHastadateTimePicker.Value.Date).ToList();
            }

            if(ActivosRadioButton.Checked == true)
            {
                lista = lista.Where(r => r.EsActivo == true).ToList();
            }

            if (InactivosRadioButton.Checked == true)
            {
                lista = lista.Where(r => r.EsActivo == false).ToList();
            }

            ConsultasDataGridView.DataSource = null;
            ConsultasDataGridView.DataSource = lista;
        }
    }
}
