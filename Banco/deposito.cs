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
    public partial class Menu1 : Form
    {
        int i = 0;
        MySqlConnection con = new MySqlConnection("server=localhost;user=root;database=banco;port=3306;password=");
        public Menu1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home DHome = new Home();
            DHome.Show();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Transferencia DTransferencia = new Transferencia();
            DTransferencia.Show();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home DHome = new Home();
            DHome.Show();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Cancelar VDestino = new Cancelar();
            VDestino.Show();
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            i = 0;

            string usu = "";
            string consulta = "SELECT * FROM datos WHERE clave=@clave";
            using (con)
            {
                con.Open();

                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cmd.Parameters.AddWithValue("@clave", guna2TextBox3.Text);

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                int i = dt.Rows.Count;

                if (i > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        // Obtener los valores de las columnas
                        int id = Convert.ToInt32(row["id"]);
                        string clave = row["clave"].ToString();
                        string nombre = row["nombre"].ToString();
                        int cant = Convert.ToInt32(row["cantidad"]);
                        usu = row["usuario"].ToString();
                        // ...
                        // Hacer algo con los datos obtenidos
                        MessageBox.Show($"id: {id}, clave: {clave}, nombre: {nombre}");
                        try
                        {
                            string texto = guna2TextBox1.Text;
                            int numero = int.Parse(texto);
                            cant = cant + numero;
                            string consultaUpdate = "UPDATE datos SET cantidad=@monto WHERE clave=@clave";
                            // string consult = "update datos set cantidad='" + cant + "' where clave='" + textBox2 + "'";
                            MySqlCommand updateCmd = con.CreateCommand();
                            updateCmd.CommandType = CommandType.Text;
                            updateCmd.CommandText = consultaUpdate;
                            updateCmd.Parameters.AddWithValue("@monto", cant);

                            updateCmd.Parameters.AddWithValue("@clave", clave);

                            int rowsAffected = updateCmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                Console.WriteLine("Actualización exitosa.");
                            }
                            else
                            {
                                Console.WriteLine("No se pudo actualizar el registro.");
                            }

                            //






                        }
                        catch
                        {
                            MessageBox.Show("Error Deposito Erronea!");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("No se encontraron resultados.");
                }
            }

            //


            string consultaInsert = "INSERT INTO deposito (usuario,cantidad) VALUES (@nombre, @monto)";

            using (con)
            {
                con.Open();

                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consultaInsert;

                cmd.Parameters.AddWithValue("@nombre", usu);
                cmd.Parameters.AddWithValue("@monto", guna2TextBox1.Text);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Console.WriteLine("Inserción exitosa.");

                }
                else
                {
                    Console.WriteLine("No se pudo insertar el registro.");
                }
            }

            MessageBox.Show("Deposito Exitoso");
        }
    }
}
