using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENTIDAD;
using NEGOCIO;
using System.Data.SqlClient;
using System.Configuration;
namespace PRESENTACION
{

    public partial class CONSULTAR : Form
    {
        nvisita objn = new nvisita();
        evisitas obje = new evisitas();
        public CONSULTAR()
        {
            InitializeComponent();
            cargardatos();
        }
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);
        private void CONSULTAR_Load(object sender, EventArgs e)
        {

        }
        public void cargardatos()
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SELECT IDEDIFICIO,EDIFICIO FROM EDIFICIO", conexion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);


            DataRow fila = dt.NewRow();
            fila["EDIFICIO"] = "SELECCIONA";
            dt.Rows.InsertAt(fila, 0);

            cedificio.ValueMember = "EDIFICIO";
            cedificio.DisplayMember = "EDIFICIO";
            cedificio.DataSource = dt;
            conexion.Close();
        }

        private void tablaregistro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void mostrart()
        {
            

            
            tablaregistro.DataSource = objn.listandovisita(cedificio.Text.ToString());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void tablaregistro_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            MENUG men = new MENUG();
            men.Show();
            this.Hide();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bregistrar_Click(object sender, EventArgs e)
        {
            mostrart();
        }
    }
}
