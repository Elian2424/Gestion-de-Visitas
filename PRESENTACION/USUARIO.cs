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
    public partial class USUARIO : Form
    {
        public USUARIO()
        {
            InitializeComponent();
        }
        evisitas objentidad = new evisitas();
        nvisita objnegocio = new nvisita();
        private void Comedificio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tcorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel6_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void USUARIO_Load(object sender, EventArgs e)
        {

        }

        private void bregistrar_Click(object sender, EventArgs e)
        {
            try
            {
                objentidad.Nombre = tnombre.Text.ToUpper();
                objentidad.Apellido = tapellido.Text.ToUpper();
                objentidad.Fechan = fechan.Value;
                objentidad.Usuario = tusuario.Text.ToUpper();
                objentidad.Tipo = ttipo.Text.ToUpper();

                objnegocio.insertandousuariog(objentidad);

                MessageBox.Show("Se guardo el Usuario");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se  guardo el Usuario" + ex);
            }

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            MENUA men = new MENUA();
            men.Show();
            this.Hide();
        }
    }
}
