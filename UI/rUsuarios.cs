using OtroRegistroConDetalle.BLL;
using OtroRegistroConDetalle.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OtroRegistroConDetalle.UI
{
    public partial class rUsuarios : Form
    {
        public rUsuarios()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            ErrorProvider.Clear();
            IdnumericUpDown.Value = 0;
            AliastextBox.Clear();
            NombretextBox.Clear();
            ClavetextBox.Clear();
            ConfirmartextBox.Clear();
            EmailtextBox.Clear();
            ActivocheckBox.Checked = true;
            FechadateTimePicker.Value = DateTime.Now;
        }

        private void LlenaCampo(Usuarios usuarios)
        {
            IdnumericUpDown.Value = usuarios.UsuarioId;
            AliastextBox.Text = usuarios.Alias;
            NombretextBox.Text = usuarios.Nombre;
            ClavetextBox.Text = usuarios.Clave;
            ConfirmartextBox.Text = usuarios.ConfirmarClave;
            EmailtextBox.Text = usuarios.Email;
            ActivocheckBox.Checked = usuarios.Activo;
            RolcomboBox.Text = usuarios.Rol;
            FechadateTimePicker.Value = usuarios.FechaIngreso;
        }

        private Usuarios LlenaClase()
        {
            Usuarios usuarios = new Usuarios();

            usuarios.UsuarioId = (int)IdnumericUpDown.Value;
            usuarios.Alias = AliastextBox.Text;
            usuarios.Nombre = NombretextBox.Text;
            usuarios.Clave = ClavetextBox.Text;
            usuarios.ConfirmarClave = ConfirmartextBox.Text;
            usuarios.Activo = ActivocheckBox.Checked;
            usuarios.Email = EmailtextBox.Text;
            usuarios.Rol = RolcomboBox.Text;
            usuarios.FechaIngreso = FechadateTimePicker.Value;

            return usuarios;
        }

        private bool Validar()
        {
            bool paso = true;

            if (AliastextBox.Text == string.Empty)
            {
                ErrorProvider.SetError(AliastextBox, "Este Campo no puede estar vacio");
                AliastextBox.Focus();
                paso = false;
            }
            if (NombretextBox.Text == string.Empty)
            {
                ErrorProvider.SetError(NombretextBox, "Este Campo no puede estar vacio");
                NombretextBox.Focus();
                paso = false;
            }
            if (ClavetextBox.Text == string.Empty)
            {
                ErrorProvider.SetError(ClavetextBox, "Este Campo no puede estar vacio");
                ClavetextBox.Focus();
                paso = false;
            }
            if (ConfirmartextBox.Text == string.Empty)
            {
                ErrorProvider.SetError(ConfirmartextBox, "Este Campo no puede estar vacio");
                ConfirmartextBox.Focus();
                paso = false;
            }
            if (EmailtextBox.Text == string.Empty)
            {
                ErrorProvider.SetError(EmailtextBox, "Este Campo no puede estar vacio");
                EmailtextBox.Focus();
                paso = false;
            }
            if (UsuariosBLL.ExisteAlias(AliastextBox.Text, (int)IdnumericUpDown.Value))
            {
                ErrorProvider.SetError(AliastextBox, "Este Alias ya existe");
                AliastextBox.Focus();
                paso = false;
            }
            if(UsuariosBLL.ExisteRol(RolcomboBox.Text, (int)IdnumericUpDown.Value))
            {
                ErrorProvider.SetError(RolcomboBox, "Este Rol ya existe");
                RolcomboBox.Focus();
                paso = false;
            }
            if(string.Equals(ClavetextBox.Text, ConfirmartextBox.Text) != true)
            {
                ErrorProvider.SetError(ConfirmartextBox, "La clave es distinta");
                ConfirmartextBox.Focus();
                paso = false;
            }

            return paso;
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            Usuarios usuarios = new Usuarios();
            int id;
            int.TryParse(IdnumericUpDown.Text, out id);

            usuarios = UsuariosBLL.Buscar(id);

            if (usuarios != null)
                LlenaCampo(usuarios);
            else
                MessageBox.Show("Transacción Fallida!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Usuarios usuarios;

            if (!Validar())
                return;

            usuarios = LlenaClase();

            var paso = UsuariosBLL.Guardar(usuarios);

            if (paso)
            {
                Limpiar();
                MessageBox.Show("Transacción Exitosa!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Transacción Fallida!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            int id;
            int.TryParse(IdnumericUpDown.Text, out id);

            Limpiar();

            if (UsuariosBLL.Eliminar(id))
                MessageBox.Show("Transacción Exitosa!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                ErrorProvider.SetError(IdnumericUpDown, "Id no existente");
        }

        private void rUsuarios_Load(object sender, EventArgs e)
        {
            RolcomboBox.DataSource = RolesBLL.GetRoles();
            RolcomboBox.DisplayMember = "Descripcion";
            RolcomboBox.ValueMember = "RolId";
        }
    }
}
