using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRESENTACION
{
    public partial class MENUG : Form
    {
        public MENUG()
        {
            InitializeComponent();
        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
            REGISTRO CAMBIO = new REGISTRO();
            CAMBIO.Show();
            this.Hide();
        }

        private void MENUG_Load(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            CONSULTAR CAMBIO = new CONSULTAR();
            CAMBIO.Show();
            this.Hide();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            login log = new login();
            log.Show();
            this.Hide();

        }
    }
}
