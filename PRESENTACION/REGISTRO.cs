using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using ENTIDAD;
using NEGOCIO;

namespace PRESENTACION
{
    public partial class REGISTRO : Form
    {
        public REGISTRO()
        {
            InitializeComponent();
            cargardatos();
        }
        private string idregitro;
        evisitas objentidad = new evisitas();
        nvisita objnegocio = new nvisita();
        string edificio;
        string id;
        SqlConnection conexion = new SqlConnection(@"Data source=DESKTOP-Q81MT00;Initial Catalog=visitas;Integrated Security=true");

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

            Comedificio.ValueMember = "EDIFICIO";
            Comedificio.DisplayMember = "EDIFICIO";
            Comedificio.DataSource = dt;
            conexion.Close();
        }

        public void cargardatos2(string id)
        {
            conexion.Close();
            conexion.Open();
            
            SqlCommand cmd = new SqlCommand("SELECT IDAREA,AREA FROM AREA WHERE N_EDIFICIO = @edificio", conexion);
            cmd.Parameters.AddWithValue("@edificio", id);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            

            DataRow dr = dt.NewRow();
            dr["AREA"] = "SELECCIONA";
            dt.Rows.InsertAt(dr, 0);

            comboarea.ValueMember = "IDAREA";
            comboarea.DisplayMember = "AREA";
            comboarea.DataSource = dt;

            conexion.Close();
        }

        private void REGISTRO_Load(object sender, EventArgs e)
        {
           
            // TODO: esta línea de código carga datos en la tabla 'visitasDataSet1.CARRERAS' Puede moverla o quitarla según sea necesario.
            this.cARRERASTableAdapter.Fill(this.visitasDataSet1.CARRERAS);
            // TODO: esta línea de código carga datos en la tabla 'visitasDataSet.edificio' Puede moverla o quitarla según sea necesario.
           

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Comedificio_SelectedIndexChanged(object sender, EventArgs e)
        {
            edificio = Comedificio.SelectedValue.ToString();
            id = edificio;

            cargardatos2(id);

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void bregistrar_Click(object sender, EventArgs e)
        {
            conexion.Close();
            try
            {
                //objentidad.Idregistro = Convert.ToInt32(idregitro);
                objentidad.Nombre = tnombre.Text.ToUpper();
                objentidad.Apellido = tapellido.Text.ToUpper();
                objentidad.Correo = tcorreo.Text.ToUpper();
                objentidad.Carrera = ccarrera.Text.ToUpper();
                objentidad.Edificio = Comedificio.Text.ToUpper();
                objentidad.Area = comboarea.Text.ToUpper();
                objentidad.Hora_e = dataentrada.Value;
                objentidad.Hora_s = datasalida.Value;
                objentidad.Motivo= tmotivo.Text.ToUpper();

                objnegocio.insertandoregitro(objentidad);

                MessageBox.Show("Se guardo el registro");
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se guardo el registro"+ex);
            }
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            MENUG men = new MENUG();
            men.Show();
            this.Hide();
        }
    }
}
