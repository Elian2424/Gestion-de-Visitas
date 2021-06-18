
namespace PRESENTACION
{
    partial class EDIFICIOO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EDIFICIOO));
            this.tedificio = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tablaedificio = new System.Windows.Forms.DataGridView();
            this.bregistrar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.moverform = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.visitasDataSet = new PRESENTACION.visitasDataSet();
            this.visitasDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.visitasDataSet3 = new PRESENTACION.visitasDataSet3();
            this.edificioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.edificioTableAdapter = new PRESENTACION.visitasDataSet3TableAdapters.edificioTableAdapter();
            this.iDEDIFICIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eDIFICIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaedificio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitasDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitasDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edificioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tedificio
            // 
            this.tedificio.Location = new System.Drawing.Point(265, 149);
            this.tedificio.Name = "tedificio";
            this.tedificio.Size = new System.Drawing.Size(134, 20);
            this.tedificio.TabIndex = 39;
            this.tedificio.TextChanged += new System.EventHandler(this.tedificio_TextChanged);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(186, 151);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(62, 18);
            this.bunifuCustomLabel1.TabIndex = 35;
            this.bunifuCustomLabel1.Text = "Nombre:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(187)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.bunifuImageButton3);
            this.panel1.Controls.Add(this.bunifuImageButton2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(685, 77);
            this.panel1.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(153, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(308, 28);
            this.label4.TabIndex = 8;
            this.label4.Text = "Administrador de Edificio";
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(187)))));
            this.bunifuImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.Image")));
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.Location = new System.Drawing.Point(636, 0);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Size = new System.Drawing.Size(45, 44);
            this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton3.TabIndex = 7;
            this.bunifuImageButton3.TabStop = false;
            this.bunifuImageButton3.Zoom = 10;
            this.bunifuImageButton3.Click += new System.EventHandler(this.bunifuImageButton3_Click);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(187)))));
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(589, 0);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(41, 41);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 18;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
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
            // tablaedificio
            // 
            this.tablaedificio.AutoGenerateColumns = false;
            this.tablaedificio.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tablaedificio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaedificio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDEDIFICIODataGridViewTextBoxColumn,
            this.eDIFICIODataGridViewTextBoxColumn});
            this.tablaedificio.DataSource = this.edificioBindingSource;
            this.tablaedificio.Location = new System.Drawing.Point(228, 196);
            this.tablaedificio.Name = "tablaedificio";
            this.tablaedificio.RowHeadersVisible = false;
            this.tablaedificio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaedificio.Size = new System.Drawing.Size(204, 135);
            this.tablaedificio.TabIndex = 42;
            this.tablaedificio.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.bregistrar.Location = new System.Drawing.Point(228, 378);
            this.bregistrar.Name = "bregistrar";
            this.bregistrar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(187)))));
            this.bregistrar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.bregistrar.OnHoverTextColor = System.Drawing.Color.White;
            this.bregistrar.selected = false;
            this.bregistrar.Size = new System.Drawing.Size(90, 32);
            this.bregistrar.TabIndex = 43;
            this.bregistrar.Text = "REGISTRAR";
            this.bregistrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bregistrar.Textcolor = System.Drawing.Color.White;
            this.bregistrar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bregistrar.Click += new System.EventHandler(this.bregistrar_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(187)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(187)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "EDITAR";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(343, 378);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(187)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(90, 32);
            this.bunifuFlatButton1.TabIndex = 44;
            this.bunifuFlatButton1.Text = "EDITAR";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // moverform
            // 
            this.moverform.Fixed = true;
            this.moverform.Horizontal = true;
            this.moverform.TargetControl = this.panel1;
            this.moverform.Vertical = true;
            // 
            // visitasDataSet
            // 
            this.visitasDataSet.DataSetName = "visitasDataSet";
            this.visitasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // visitasDataSetBindingSource
            // 
            this.visitasDataSetBindingSource.DataSource = this.visitasDataSet;
            this.visitasDataSetBindingSource.Position = 0;
            // 
            // visitasDataSet3
            // 
            this.visitasDataSet3.DataSetName = "visitasDataSet3";
            this.visitasDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // edificioBindingSource
            // 
            this.edificioBindingSource.DataMember = "edificio";
            this.edificioBindingSource.DataSource = this.visitasDataSet3;
            // 
            // edificioTableAdapter
            // 
            this.edificioTableAdapter.ClearBeforeFill = true;
            // 
            // iDEDIFICIODataGridViewTextBoxColumn
            // 
            this.iDEDIFICIODataGridViewTextBoxColumn.DataPropertyName = "IDEDIFICIO";
            this.iDEDIFICIODataGridViewTextBoxColumn.HeaderText = "IDEDIFICIO";
            this.iDEDIFICIODataGridViewTextBoxColumn.Name = "iDEDIFICIODataGridViewTextBoxColumn";
            this.iDEDIFICIODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eDIFICIODataGridViewTextBoxColumn
            // 
            this.eDIFICIODataGridViewTextBoxColumn.DataPropertyName = "EDIFICIO";
            this.eDIFICIODataGridViewTextBoxColumn.HeaderText = "EDIFICIO";
            this.eDIFICIODataGridViewTextBoxColumn.Name = "eDIFICIODataGridViewTextBoxColumn";
            // 
            // EDIFICIOO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 450);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.bregistrar);
            this.Controls.Add(this.tablaedificio);
            this.Controls.Add(this.tedificio);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EDIFICIOO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AREA";
            this.Load += new System.EventHandler(this.EDIFICIOO_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaedificio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitasDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitasDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edificioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tedificio;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView tablaedificio;
        private Bunifu.Framework.UI.BunifuFlatButton bregistrar;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuDragControl moverform;
        private System.Windows.Forms.BindingSource visitasDataSetBindingSource;
        private visitasDataSet visitasDataSet;
        private visitasDataSet3 visitasDataSet3;
        private System.Windows.Forms.BindingSource edificioBindingSource;
        private visitasDataSet3TableAdapters.edificioTableAdapter edificioTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDEDIFICIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eDIFICIODataGridViewTextBoxColumn;
    }
}