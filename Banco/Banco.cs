using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class Banco : Form
    {
        public Banco()
        {
            InitializeComponent();
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            Registro VRegistro = new Registro();
            VRegistro.Show();
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            Home VHome = new Home();
            VHome.Show();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Cancelar VDestino = new Cancelar();
            VDestino.Show();
        }
    }
}
