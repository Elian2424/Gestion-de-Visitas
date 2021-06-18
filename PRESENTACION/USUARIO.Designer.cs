
namespace PRESENTACION
{
    partial class USUARIO
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(USUARIO));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fechan = new System.Windows.Forms.DateTimePicker();
            this.ttipo = new System.Windows.Forms.ComboBox();
            this.tapellido = new System.Windows.Forms.TextBox();
            this.tnombre = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tusuario = new System.Windows.Forms.TextBox();
            this.bregistrar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.moverform = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(187)))));
            this.panel1.Controls.Add(this.bunifuImageButton2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.bunifuImageButton3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 77);
            this.panel1.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(153, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(324, 28);
            this.label4.TabIndex = 8;
            this.label4.Text = "Administrador de Usuarios";
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(187)))));
            this.bunifuImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.Image")));
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.Location = new System.Drawing.Point(755, 0);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Size = new System.Drawing.Size(45, 44);
            this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton3.TabIndex = 7;
            this.bunifuImageButton3.TabStop = false;
            this.bunifuImageButton3.Zoom = 10;
            this.bunifuImageButton3.Click += new System.EventHandler(this.bunifuImageButton3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // fechan
            // 
            this.fechan.Location = new System.Drawing.Point(536, 214);
            this.fechan.Name = "fechan";
            this.fechan.Size = new System.Drawing.Size(200, 20);
            this.fechan.TabIndex = 49;
            // 
            // ttipo
            // 
            this.ttipo.DisplayMember = "CARRERA";
            this.ttipo.FormattingEnabled = true;
            this.ttipo.Items.AddRange(new object[] {
            "SELECCIONA",
            "GENERAL",
            "ADMIN"});
            this.ttipo.Location = new System.Drawing.Point(240, 211);
            this.ttipo.Name = "ttipo";
            this.ttipo.Size = new System.Drawing.Size(100, 21);
            this.ttipo.TabIndex = 47;
            this.ttipo.ValueMember = "CARRERA";
            // 
            // tapellido
            // 
            this.tapellido.Location = new System.Drawing.Point(429, 154);
            this.tapellido.Name = "tapellido";
            this.tapellido.Size = new System.Drawing.Size(100, 20);
            this.tapellido.TabIndex = 45;
            // 
            // tnombre
            // 
            this.tnombre.Location = new System.Drawing.Point(186, 155);
            this.tnombre.Name = "tnombre";
            this.tnombre.Size = new System.Drawing.Size(100, 20);
            this.tnombre.TabIndex = 44;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(352, 154);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(67, 18);
            this.bunifuCustomLabel5.TabIndex = 42;
            this.bunifuCustomLabel5.Text = "Apellido:";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(118, 211);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(116, 18);
            this.bunifuCustomLabel4.TabIndex = 41;
            this.bunifuCustomLabel4.Text = "Tipo de Usuario:";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(383, 214);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(147, 18);
            this.bunifuCustomLabel3.TabIndex = 40;
            this.bunifuCustomLabel3.Text = "Fecha de Nacimiento:";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(118, 154);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(62, 18);
            this.bunifuCustomLabel1.TabIndex = 38;
            this.bunifuCustomLabel1.Text = "Nombre:";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(155, 275);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(62, 18);
            this.bunifuCustomLabel2.TabIndex = 51;
            this.bunifuCustomLabel2.Text = "Usuario:";
            // 
            // tusuario
            // 
            this.tusuario.Location = new System.Drawing.Point(240, 276);
            this.tusuario.Name = "tusuario";
            this.tusuario.Size = new System.Drawing.Size(100, 20);
            this.tusuario.TabIndex = 52;
            // 
            // bregistrar
            // 
            this.bregistrar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(187)))));
            this.bregistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(187)))));
            this.bregistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bregistrar.BorderRadius = 0;
            this.bregistrar.ButtonText = "REGISTRAR";
            this.bregistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bregistrar.DisabledColor = System.Drawing.Color.Gray;
            this.bregistrar.Iconcolor = System.Drawing.Color.Transparent;
            this.bregistrar.Iconimage = null;
            this.bregistrar.Iconimage_right = null;
            this.bregistrar.Iconimage_right_Selected = null;
            this.bregistrar.Iconimage_Selected = null;
            this.bregistrar.IconMarginLeft = 0;
            this.bregistrar.IconMarginRight = 0;
            this.bregistrar.IconRightVisible = true;
            this.bregistrar.IconRightZoom = 0D;
            this.bregistrar.IconVisible = true;
            this.bregistrar.IconZoom = 90D;
            this.bregistrar.IsTab = false;
            this.bregistrar.Location = new System.Drawing.Point(364, 330);
            this.bregistrar.Name = "bregistrar";
            this.bregistrar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(187)))));
            this.bregistrar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.bregistrar.OnHoverTextColor = System.Drawing.Color.White;
            this.bregistrar.selected = false;
            this.bregistrar.Size = new System.Drawing.Size(104, 48);
            this.bregistrar.TabIndex = 53;
            this.bregistrar.Text = "REGISTRAR";
            this.bregistrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bregistrar.Textcolor = System.Drawing.Color.White;
            this.bregistrar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bregistrar.Click += new System.EventHandler(this.bregistrar_Click);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(187)))));
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(708, 3);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(41, 41);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 19;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // moverform
            // 
            this.moverform.Fixed = true;
            this.moverform.Horizontal = true;
            this.moverform.TargetControl = this.panel1;
            this.moverform.Vertical = true;
            // 
            // USUARIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bregistrar);
            this.Controls.Add(this.tusuario);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.fechan);
            this.Controls.Add(this.ttipo);
            this.Controls.Add(this.tapellido);
            this.Controls.Add(this.tnombre);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "USUARIO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "USUARIO";
            this.Load += new System.EventHandler(this.USUARIO_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker fechan;
        private System.Windows.Forms.ComboBox ttipo;
        private System.Windows.Forms.TextBox tapellido;
        private System.Windows.Forms.TextBox tnombre;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.TextBox tusuario;
        private Bunifu.Framework.UI.BunifuFlatButton bregistrar;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuDragControl moverform;
    }
}