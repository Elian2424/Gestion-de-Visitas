
namespace PRESENTACION
{
    partial class AREA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AREA));
            this.cedificio = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bregistrar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tablaarea = new System.Windows.Forms.DataGridView();
            this.tarea = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.visitasDataSet2 = new PRESENTACION.visitasDataSet2();
            this.edificioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.edificioTableAdapter = new PRESENTACION.visitasDataSet2TableAdapters.edificioTableAdapter();
            this.moverform = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.visitasDataSet4 = new PRESENTACION.visitasDataSet4();
            this.aREABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aREATableAdapter = new PRESENTACION.visitasDataSet4TableAdapters.AREATableAdapter();
            this.iDAREADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aREADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nEDIFICIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaarea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitasDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edificioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitasDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aREABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cedificio
            // 
            this.cedificio.DataSource = this.edificioBindingSource;
            this.cedificio.DisplayMember = "EDIFICIO";
            this.cedificio.FormattingEnabled = true;
            this.cedificio.Location = new System.Drawing.Point(466, 121);
            this.cedificio.Name = "cedificio";
            this.cedificio.Size = new System.Drawing.Size(91, 21);
            this.cedificio.TabIndex = 41;
            this.cedificio.ValueMember = "EDIFICIO";
            this.cedificio.SelectedIndexChanged += new System.EventHandler(this.ccarrera_SelectedIndexChanged);
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
            this.panel1.Size = new System.Drawing.Size(747, 77);
            this.panel1.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(153, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(276, 28);
            this.label4.TabIndex = 8;
            this.label4.Text = "Administrador de Area";
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(187)))));
            this.bunifuImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.Image")));
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.Location = new System.Drawing.Point(696, 0);
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
            this.bunifuImageButton2.Location = new System.Drawing.Point(657, 3);
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
            // bregistrar
            // 
            this.bregistrar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(187)))));
            this.bregistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(187)))));
            this.bregistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bregistrar.BorderRadius = 0;
            this.bregistrar.ButtonText = "GUARDAR";
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
            this.bregistrar.Location = new System.Drawing.Point(269, 339);
            this.bregistrar.Name = "bregistrar";
            this.bregistrar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(187)))));
            this.bregistrar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.bregistrar.OnHoverTextColor = System.Drawing.Color.White;
            this.bregistrar.selected = false;
            this.bregistrar.Size = new System.Drawing.Size(90, 32);
            this.bregistrar.TabIndex = 48;
            this.bregistrar.Text = "GUARDAR";
            this.bregistrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bregistrar.Textcolor = System.Drawing.Color.White;
            this.bregistrar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bregistrar.Click += new System.EventHandler(this.bregistrar_Click);
            // 
            // tablaarea
            // 
            this.tablaarea.AutoGenerateColumns = false;
            this.tablaarea.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tablaarea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaarea.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDAREADataGridViewTextBoxColumn,
            this.aREADataGridViewTextBoxColumn,
            this.nEDIFICIODataGridViewTextBoxColumn});
            this.tablaarea.DataSource = this.aREABindingSource;
            this.tablaarea.Location = new System.Drawing.Point(208, 161);
            this.tablaarea.Name = "tablaarea";
            this.tablaarea.RowHeadersVisible = false;
            this.tablaarea.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaarea.Size = new System.Drawing.Size(317, 172);
            this.tablaarea.TabIndex = 47;
            // 
            // tarea
            // 
            this.tarea.Location = new System.Drawing.Point(193, 122);
            this.tarea.Name = "tarea";
            this.tarea.Size = new System.Drawing.Size(134, 20);
            this.tarea.TabIndex = 46;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(114, 124);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(62, 18);
            this.bunifuCustomLabel1.TabIndex = 45;
            this.bunifuCustomLabel1.Text = "Nombre:";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(360, 121);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(65, 18);
            this.bunifuCustomLabel2.TabIndex = 50;
            this.bunifuCustomLabel2.Text = "Edificio:";
            this.bunifuCustomLabel2.Click += new System.EventHandler(this.bunifuCustomLabel2_Click);
            // 
            // visitasDataSet2
            // 
            this.visitasDataSet2.DataSetName = "visitasDataSet2";
            this.visitasDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // edificioBindingSource
            // 
            this.edificioBindingSource.DataMember = "edificio";
            this.edificioBindingSource.DataSource = this.visitasDataSet2;
            // 
            // edificioTableAdapter
            // 
            this.edificioTableAdapter.ClearBeforeFill = true;
            // 
            // moverform
            // 
            this.moverform.Fixed = true;
            this.moverform.Horizontal = true;
            this.moverform.TargetControl = this.panel1;
            this.moverform.Vertical = true;
            // 
            // visitasDataSet4
            // 
            this.visitasDataSet4.DataSetName = "visitasDataSet4";
            this.visitasDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aREABindingSource
            // 
            this.aREABindingSource.DataMember = "AREA";
            this.aREABindingSource.DataSource = this.visitasDataSet4;
            // 
            // aREATableAdapter
            // 
            this.aREATableAdapter.ClearBeforeFill = true;
            // 
            // iDAREADataGridViewTextBoxColumn
            // 
            this.iDAREADataGridViewTextBoxColumn.DataPropertyName = "IDAREA";
            this.iDAREADataGridViewTextBoxColumn.HeaderText = "IDAREA";
            this.iDAREADataGridViewTextBoxColumn.Name = "iDAREADataGridViewTextBoxColumn";
            this.iDAREADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aREADataGridViewTextBoxColumn
            // 
            this.aREADataGridViewTextBoxColumn.DataPropertyName = "AREA";
            this.aREADataGridViewTextBoxColumn.HeaderText = "AREA";
            this.aREADataGridViewTextBoxColumn.Name = "aREADataGridViewTextBoxColumn";
            // 
            // nEDIFICIODataGridViewTextBoxColumn
            // 
            this.nEDIFICIODataGridViewTextBoxColumn.DataPropertyName = "N_EDIFICIO";
            this.nEDIFICIODataGridViewTextBoxColumn.HeaderText = "N_EDIFICIO";
            this.nEDIFICIODataGridViewTextBoxColumn.Name = "nEDIFICIODataGridViewTextBoxColumn";
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
            this.bunifuFlatButton1.Location = new System.Drawing.Point(402, 339);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(187)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(90, 32);
            this.bunifuFlatButton1.TabIndex = 51;
            this.bunifuFlatButton1.Text = "EDITAR";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click_1);
            // 
            // AREA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 450);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bregistrar);
            this.Controls.Add(this.tablaarea);
            this.Controls.Add(this.tarea);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.cedificio);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AREA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EDIFICIO";
            this.Load += new System.EventHandler(this.EDIFICIO_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaarea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitasDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edificioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitasDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aREABindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cedificio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton bregistrar;
        private System.Windows.Forms.DataGridView tablaarea;
        private System.Windows.Forms.TextBox tarea;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private visitasDataSet2 visitasDataSet2;
        private System.Windows.Forms.BindingSource edificioBindingSource;
        private visitasDataSet2TableAdapters.edificioTableAdapter edificioTableAdapter;
        private Bunifu.Framework.UI.BunifuDragControl moverform;
        private visitasDataSet4 visitasDataSet4;
        private System.Windows.Forms.BindingSource aREABindingSource;
        private visitasDataSet4TableAdapters.AREATableAdapter aREATableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDAREADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aREADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nEDIFICIODataGridViewTextBoxColumn;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
    }
}