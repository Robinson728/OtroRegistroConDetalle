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
    public partial class MainForms : Form
    {
        public MainForms()
        {
            InitializeComponent();
            this.UsuariostoolStripMenuItem.Click += new EventHandler(this.UsuariostoolStripMenuItem_ItemClicked);
            this.RolestoolStripMenuItem.Click += new EventHandler(this.RolestoolStripMenuItem_ItemClicked);
        }

        public void UsuariostoolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            var usuario = new rUsuarios();
            usuario.MdiParent = this;
            usuario.Show();
        }

        public void RolestoolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            var rol = new rRoles();
            rol.MdiParent = this;
            rol.Show();
        }
    }
}
