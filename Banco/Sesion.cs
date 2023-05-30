using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Banco
{
    public partial class Sesion : Form
    {
        public Sesion()
        {
            InitializeComponent();
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cancelar del = new Cancelar();
            del.Show();
        }

        private void guna2GradientPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home casa= new Home();
            casa.Show();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cancelar cano = new Cancelar();
            cano.Show();
        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            Banco Xbanco = new Banco();
            Xbanco.Show();
        }
    }
}
