using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OtroRegistroConDetalle.UI.Registros;
using OtroRegistroConDetalle.UI.Consultas;

namespace OtroRegistroConDetalle.UI
{
    public partial class MainForms : Form
    {
        public MainForms()
        {
            InitializeComponent();
            this.UsuariostoolStripMenuItem.Click += new EventHandler(this.UsuariostoolStripMenuItem_ItemClicked);
            this.RolestoolStripMenuItem.Click += new EventHandler(this.RolestoolStripMenuItem_ItemClicked);

            this.cRolestoolStripMenuItem.Click += new EventHandler(this.cRolestoolStripMenuItem_ItemClicked);
            this.cUsuariostoolStripMenuItem.Click += new EventHandler(this.cUsuariostoolStripMenuItem_ItemClicked);
        }

        public void UsuariostoolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            var usuario = new rUsuarios();
            usuario.MdiParent = this;
            usuario.Show();
        }

        public void RolestoolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            var rol = new Registros.rRoles();
            rol.MdiParent = this;
            rol.Show();
        }

        public void cRolestoolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            var rol = new cRoles();
            rol.MdiParent = this;
            rol.Show();
        }

        public void cUsuariostoolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            var cusuarios = new cUsuarios();
            cusuarios.MdiParent = this;
            cusuarios.Show();
        }
    }
}
