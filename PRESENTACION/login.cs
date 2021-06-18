using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace PRESENTACION
{
    public partial class login : Form
    {


        public login()
        {
            InitializeComponent();
        }

       SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);
        
        public void logear (String nombre, String usuario) {
            try
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("SELECT NOMBRE, TIPO FROM USUARIOG WHERE NOMBRE = @NOMBRE AND USUARIO = @USUARIO ", conexion);
                cmd.Parameters.AddWithValue("NOMBRE", nombre);
                cmd.Parameters.AddWithValue("USUARIO", usuario);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    
                    
                    if (dt.Rows[0][1].ToString() == "GENERAL")
                    {
                        MENUG menu1 = new MENUG();
                        menu1.Show();
                        this.Hide();
                    }
                    else if (dt.Rows[0][1].ToString() == "ADMIN")
                    {
                        MENUA menu2 = new MENUA();
                        menu2.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Datos incorrectos");
                }


            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

            logear(this.tnombre.Text, this.tusuario.Text);
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
           
            
        }

        private void doubleBitmapControl1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click_1(object sender, EventArgs e)
        {
            logear(this.tnombre.Text, this.tusuario.Text);
        }
    }
}
