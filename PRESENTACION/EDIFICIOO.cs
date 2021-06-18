using NEGOCIO;
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

namespace PRESENTACION
{
    public partial class EDIFICIOO : Form
    {

        public EDIFICIOO()
        {
            InitializeComponent();
        }
        private string idedificio;
        private bool editarse = false;
        evisitas obje = new evisitas();
        nvisita objn = new nvisita();
        private void bunifuCustomLabel4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
      
        private void EDIFICIOO_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'visitasDataSet3.edificio' Puede moverla o quitarla según sea necesario.
            this.edificioTableAdapter.Fill(this.visitasDataSet3.edificio);
         
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            MENUA men = new MENUA();
            men.Show();
            this.Hide();

        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tedificio_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            editarse = true;
            idedificio = tablaedificio.CurrentRow.Cells[0].Value.ToString();
            tedificio.Text = tablaedificio.CurrentRow.Cells[1].Value.ToString();
        }

        private void bregistrar_Click(object sender, EventArgs e)
        {
           
            if (editarse == false)
            {
                try
                {
                    obje.Edificio = tedificio.Text.ToLower();
                    

                    objn.insertandoedificio(obje);
                    MessageBox.Show("Se guardo Exitosamente");
                    limpiar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No Se guardo " + ex);
                }
            }

            else if (editarse == true)
            {
                try
                {

                    obje.Idedificio = Convert.ToInt32(idedificio);
                    obje.Edificio = tedificio.Text.ToLower();
                    

                    objn.editandoedificio(obje);
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
            tedificio.Text = " ";
            editarse = false;
        }
    }
}
