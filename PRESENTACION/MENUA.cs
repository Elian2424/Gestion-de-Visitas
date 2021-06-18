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
    public partial class MENUA : Form
    {
        public MENUA()
        {
            InitializeComponent();
        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
            EDIFICIOO MEN = new EDIFICIOO();
            MEN.Show();
            this.Hide();
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            AREA A = new AREA();
            A.Show();
            this.Hide();
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            USUARIO U = new USUARIO();
            U.Show();
            this.Hide();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            login log = new login();
            log.Show();
            this.Hide();
        }
    }
}
