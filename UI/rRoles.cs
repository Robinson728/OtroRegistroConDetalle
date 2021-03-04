using OtroRegistroConDetalle.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using OtroRegistroConDetalle.BLL;

namespace OtroRegistroConDetalle.UI
{
    public partial class rRoles : Form
    {
        public List<RolesDetalle> Detalle { get; set; }
        public rRoles()
        {
            InitializeComponent();
            this.Detalle = new List<RolesDetalle>();
        }

        private void CargarGrid()
        {
            DetallesdataGridView.DataSource = null;
            DetallesdataGridView.DataSource = this.Detalle;
        }

        private void Limpiar()
        {
            ErrorProvider.Clear();
            IdnumericUpDown.Value = 0;
            DescripciontextBox.Clear();
            ActivocheckBox.Checked = true;
            AsignadocheckBox.Checked = true;
            this.Detalle = new List<RolesDetalle>();
            CargarGrid();
        }

        private void LlenaCampo(Roles rol)
        {
            IdnumericUpDown.Value = rol.RolId;
            DescripciontextBox.Text = rol.Descripcion;
            this.Detalle = rol.Detalle;
            CargarGrid();
        }

        private Roles LLenaClase()
        {
            Roles rol = new Roles();

            rol.RolId = (int)IdnumericUpDown.Value;
            rol.Descripcion = DescripciontextBox.Text;
            rol.Detalle = this.Detalle;
            CargarGrid();

            return rol;
        }

        private bool Validar()
        {
            bool paso = true;

            if (DescripciontextBox.Text == string.Empty)
            {
                ErrorProvider.SetError(DescripciontextBox, "Este Campo no puede estar vacio");
                DescripciontextBox.Focus();
                paso = false;
            }
            if(RolesBLL.ExisteDescripcion(DescripciontextBox.Text, (int)IdnumericUpDown.Value))
            {
                ErrorProvider.SetError(DescripciontextBox, "Esta Descripcion ya existe");
                DescripciontextBox.Focus();
                paso = false;
            }
            if (PermisocomboBox.Text == string.Empty)
            {
                ErrorProvider.SetError(PermisocomboBox, "Debe seleccionar un Permiso Id");
                PermisocomboBox.Focus();
                paso = false;
            }
            if (this.Detalle.Count == 0)
            {
                ErrorProvider.SetError(DetallesdataGridView, "Debe agregar un Permiso");
                DetallesdataGridView.Focus();
                paso = false;
            }

            return paso;
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            Roles rol = new Roles();
            int id;
            int.TryParse(IdnumericUpDown.Text, out id);

            rol = RolesBLL.Buscar(id);

            if (rol != null)
                LlenaCampo(rol);
            else
                MessageBox.Show("Transacción Fallida", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Roles rol;

            if (!Validar())
                return;
            rol = LLenaClase();

            var paso = RolesBLL.Guardar(rol);

            if (paso)
            {
                Limpiar();
                MessageBox.Show("Transacción Exitosa", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Transacción Fallida", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            int id;
            int.TryParse(IdnumericUpDown.Text, out id);

            Limpiar();

            if (RolesBLL.ELiminar(id))
                MessageBox.Show("Transacción Exitosa", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                ErrorProvider.SetError(IdnumericUpDown, "Id no existente");
        }

        private void Agregarbutton_Click(object sender, EventArgs e)
        {
            if (DetallesdataGridView.DataSource != null)
                this.Detalle = (List<RolesDetalle>)DetallesdataGridView.DataSource;

            this.Detalle.Add(new RolesDetalle() { 
                    RolId = (int)IdnumericUpDown.Value,
                    PermisoId = Convert.ToInt32(PermisocomboBox.Text),
                    EsAsignado = AsignadocheckBox.Checked
                }
            );
            CargarGrid();
            PermisocomboBox.Focus();
            AsignadocheckBox.Checked = true;
        }

        private void RemoverButton_Click(object sender, EventArgs e)
        {
            if((DetallesdataGridView.Rows.Count > 0) && (DetallesdataGridView.CurrentRow != null))
            {
                Detalle.RemoveAt(DetallesdataGridView.CurrentRow.Index);
                CargarGrid();
            }
            else
            {
                ErrorProvider.SetError(DetallesdataGridView, "No hay filas que remover");
                DetallesdataGridView.Focus();
            }
        }

        private void rRoles_Load(object sender, EventArgs e)
        {
            PermisocomboBox.DataSource = PermisosBLL.GetPermisos();
            PermisocomboBox.DisplayMember = "PermisoId";
            PermisocomboBox.ValueMember = "Nombre";
        }
    }
}
