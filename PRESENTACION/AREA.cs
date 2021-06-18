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
using System.Data.SqlClient;
using System.Configuration;
namespace PRESENTACION
{
    public partial class AREA : Form
    {
        public AREA()
        {
            InitializeComponent();
        }
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);
        private String idarea;
        private bool editarse = false;
        evisitas obje = new evisitas();
        nvisita objn = new nvisita();
        private void EDIFICIO_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'visitasDataSet4.AREA' Puede moverla o quitarla según sea necesario.
            this.aREATableAdapter.Fill(this.visitasDataSet4.AREA);
            // TODO: esta línea de código carga datos en la tabla 'visitasDataSet2.edificio' Puede moverla o quitarla según sea necesario.
            this.edificioTableAdapter.Fill(this.visitasDataSet2.edificio);

        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void ccarrera_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            MENUA men = new MENUA();
            men.Show();
            this.Hide();

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (tablaarea.SelectedRows.Count > 0)

            {
                editarse = true;
                idarea = tablaarea.CurrentRow.Cells[0].Value.ToString();
                tarea.Text = tablaarea.CurrentRow.Cells[1].Value.ToString();
                cedificio.Text = tablaarea.CurrentRow.Cells[2].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }

        private void bregistrar_Click(object sender, EventArgs e)
        {
            conexion.Close();
            if (editarse == false)
            {
                try
                {
                    obje.Area = tarea.Text.ToLower();
                    obje.N_edificio = cedificio.Text.ToLower();

                    objn.insertandoarea(obje);
                    MessageBox.Show("Se guardo Exitosamente");
                    limpiar();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("No Se guardo Exitosamente"+ex);
                }
            }

            else if (editarse == true)
            {
                try
                {

                    obje.Idarea = Convert.ToInt32(idarea);
                    obje.Area = tarea.Text.ToUpper();
                    obje.N_edificio = cedificio.Text.ToLowerInvariant();

                    objn.editandoarea(obje);
                    MessageBox.Show("Se Edito Exitosamente");
                    limpiar();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No Se Edito" + ex);
                }
            }
        }
        public void limpiar()
        {
            tarea.Text = " ";
            editarse = false;
        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            if (tablaarea.SelectedRows.Count > 0)

            {
                editarse = true;
                idarea = tablaarea.CurrentRow.Cells[0].Value.ToString();
                tarea.Text = tablaarea.CurrentRow.Cells[1].Value.ToString();
                cedificio.Text = tablaarea.CurrentRow.Cells[2].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }
    }
}
