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
    public partial class Registro : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user=root;database=banco;port=3306;password=");
        public Registro()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {


            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO datos (nombre,email,usuario,clave, numero_cuenta,cantidad) VALUES ('" + guna2TextBox1.Text+ " "+guna2TextBox2.Text + "', '" + guna2TextBox3.Text + "','" + guna2TextBox5.Text + "','" + guna2TextBox6.Text + "', '" + guna2TextBox4.Text + "','" + 0 + "');";
            DataTable de = new DataTable();
            MySqlDataAdapter dp = new MySqlDataAdapter(cmd);
            dp.Fill(de);
            con.Close();


            MessageBox.Show("Registro exitoso");
            this.Hide();
            Banco VBanco = new Banco();
            VBanco.Show();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Cancelar VDestino = new Cancelar();
            VDestino.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Banco bn = new Banco();
            bn.Show();
        }
    }
}
