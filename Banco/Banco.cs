using MySql.Data.MySqlClient;
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
        int i = 0;
        MySqlConnection con = new MySqlConnection("server=localhost;user=root;database=banco;port=3306;password=");
        public Banco()
        {
            InitializeComponent();
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registro VRegistro = new Registro();
            VRegistro.Show();
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            i = 0;
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from datos where usuario='" + guna2TextBox5.Text + "' and clave ='" + guna2TextBox6.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());


            if (i == 0)
            {
                MessageBox.Show("Contraseña o/y usuario incorrectos.");
            }
            else
            {
                this.Hide();
                Home VHome = new Home();
                VHome.Show();
            }
            con.Close();


            
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Cancelar VDestino = new Cancelar();
            VDestino.Show();
        }

        private void Banco_Load(object sender, EventArgs e)
        {

        }
    }
}
