namespace SCI0
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idArticuloLabel;
            System.Windows.Forms.Label idAreaLabel;
            System.Windows.Forms.Label nombreArticuloLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label idUnidadMedidaLabel;
            System.Windows.Forms.Label cantidadNormalLabel;
            System.Windows.Forms.Label cantidadCriticaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCIS = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadNormalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadCriticaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vInventarioCISBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sCIDataSet = new SCI0.SCIDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabITN = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vInventarioITNBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sCIDataSet1 = new SCI0.SCIDataSet();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabMNT = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vInventarioMTNBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabSGR = new System.Windows.Forms.TabPage();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vInventarioSGRBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.tabLBC = new System.Windows.Forms.TabPage();
            this.fillBy1ToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillBy1ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.inventarioDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn36 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.tabAMT = new System.Windows.Forms.TabPage();
            this.inventarioDataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn33 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn34 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn35 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn37 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paneBtnlAMT = new System.Windows.Forms.Panel();
            this.numericoCritico = new System.Windows.Forms.NumericUpDown();
            this.numericoNormal = new System.Windows.Forms.NumericUpDown();
            this.cbxMedida = new System.Windows.Forms.ComboBox();
            this.unidadMedidaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sCIDataSet2 = new SCI0.SCIDataSet();
            this.tbxDescripcion = new System.Windows.Forms.TextBox();
            this.tbxArticulo = new System.Windows.Forms.TextBox();
            this.cbxArea = new System.Windows.Forms.ComboBox();
            this.areasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbxId = new System.Windows.Forms.TextBox();
            this.btnCancelarAMT = new System.Windows.Forms.PictureBox();
            this.btnGuardarAMT = new System.Windows.Forms.PictureBox();
            this.btnModificarAMT = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.vInventarioAMTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vInventarioLBCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vInventarioCISTableAdapter = new SCI0.SCIDataSetTableAdapters.vInventarioCISTableAdapter();
            this.vInventarioITNTableAdapter = new SCI0.SCIDataSetTableAdapters.vInventarioITNTableAdapter();
            this.vInventarioMTNTableAdapter = new SCI0.SCIDataSetTableAdapters.vInventarioMTNTableAdapter();
            this.vInventarioSGRTableAdapter = new SCI0.SCIDataSetTableAdapters.vInventarioSGRTableAdapter();
            this.vInventarioLBCTableAdapter = new SCI0.SCIDataSetTableAdapters.vInventarioLBCTableAdapter();
            //this.vInventarioAMTTableAdapter = new SCI0.SCIDataSetTableAdapters.vInventarioAMTTableAdapter();
            this.tableAdapterManager = new SCI0.SCIDataSetTableAdapters.TableAdapterManager();
            this.inventarioTableAdapter = new SCI0.SCIDataSetTableAdapters.InventarioTableAdapter();
            this.inventarioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.areasTableAdapter = new SCI0.SCIDataSetTableAdapters.AreasTableAdapter();
            this.unidadMedidaTableAdapter = new SCI0.SCIDataSetTableAdapters.UnidadMedidaTableAdapter();
            idArticuloLabel = new System.Windows.Forms.Label();
            idAreaLabel = new System.Windows.Forms.Label();
            nombreArticuloLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            idUnidadMedidaLabel = new System.Windows.Forms.Label();
            cantidadNormalLabel = new System.Windows.Forms.Label();
            cantidadCriticaLabel = new System.Windows.Forms.Label();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabCIS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vInventarioCISBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCIDataSet)).BeginInit();
            this.tabITN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vInventarioITNBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCIDataSet1)).BeginInit();
            this.tabMNT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vInventarioMTNBindingSource)).BeginInit();
            this.tabSGR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vInventarioSGRBindingSource)).BeginInit();
            this.tabLBC.SuspendLayout();
            this.fillBy1ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioBindingSource)).BeginInit();
            this.tabAMT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioDataGridView1)).BeginInit();
            this.paneBtnlAMT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericoCritico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericoNormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidadMedidaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCIDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelarAMT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardarAMT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnModificarAMT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vInventarioAMTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vInventarioLBCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // idArticuloLabel
            // 
            idArticuloLabel.AutoSize = true;
            idArticuloLabel.Location = new System.Drawing.Point(14, 14);
            idArticuloLabel.Name = "idArticuloLabel";
            idArticuloLabel.Size = new System.Drawing.Size(23, 15);
            idArticuloLabel.TabIndex = 10;
            idArticuloLabel.Text = "Id: ";
            // 
            // idAreaLabel
            // 
            idAreaLabel.AutoSize = true;
            idAreaLabel.Location = new System.Drawing.Point(153, 17);
            idAreaLabel.Name = "idAreaLabel";
            idAreaLabel.Size = new System.Drawing.Size(35, 15);
            idAreaLabel.TabIndex = 11;
            idAreaLabel.Text = "Área:";
            // 
            // nombreArticuloLabel
            // 
            nombreArticuloLabel.AutoSize = true;
            nombreArticuloLabel.Location = new System.Drawing.Point(329, 17);
            nombreArticuloLabel.Name = "nombreArticuloLabel";
            nombreArticuloLabel.Size = new System.Drawing.Size(98, 15);
            nombreArticuloLabel.TabIndex = 12;
            nombreArticuloLabel.Text = "Nombre Articulo:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(9, 46);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(75, 15);
            descripcionLabel.TabIndex = 13;
            descripcionLabel.Text = "Descripcion:";
            // 
            // idUnidadMedidaLabel
            // 
            idUnidadMedidaLabel.AutoSize = true;
            idUnidadMedidaLabel.Location = new System.Drawing.Point(9, 76);
            idUnidadMedidaLabel.Name = "idUnidadMedidaLabel";
            idUnidadMedidaLabel.Size = new System.Drawing.Size(52, 15);
            idUnidadMedidaLabel.TabIndex = 14;
            idUnidadMedidaLabel.Text = "Medida:";
            // 
            // cantidadNormalLabel
            // 
            cantidadNormalLabel.AutoSize = true;
            cantidadNormalLabel.Location = new System.Drawing.Point(205, 74);
            cantidadNormalLabel.Name = "cantidadNormalLabel";
            cantidadNormalLabel.Size = new System.Drawing.Size(103, 15);
            cantidadNormalLabel.TabIndex = 15;
            cantidadNormalLabel.Text = "Cantidad Normal:";
            // 
            // cantidadCriticaLabel
            // 
            cantidadCriticaLabel.AutoSize = true;
            cantidadCriticaLabel.Location = new System.Drawing.Point(465, 75);
            cantidadCriticaLabel.Name = "cantidadCriticaLabel";
            cantidadCriticaLabel.Size = new System.Drawing.Size(96, 15);
            cantidadCriticaLabel.TabIndex = 16;
            cantidadCriticaLabel.Text = "Cantidad Critica:";
            // 
            // panelTitulo
            // 
            this.panelTitulo.Controls.Add(this.label1);
            this.panelTitulo.Controls.Add(this.pictureBox1);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(1180, 25);
            this.panelTitulo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 4);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(135, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inventario por áreas";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCIS);
            this.tabControl1.Controls.Add(this.tabITN);
            this.tabControl1.Controls.Add(this.tabMNT);
            this.tabControl1.Controls.Add(this.tabSGR);
            this.tabControl1.Controls.Add(this.tabLBC);
            this.tabControl1.Controls.Add(this.tabAMT);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1180, 595);
            this.tabControl1.TabIndex = 1;
            // 
            // tabCIS
            // 
            this.tabCIS.Controls.Add(this.dataGridView1);
            this.tabCIS.Controls.Add(this.panel1);
            this.tabCIS.Location = new System.Drawing.Point(4, 24);
            this.tabCIS.Name = "tabCIS";
            this.tabCIS.Padding = new System.Windows.Forms.Padding(3);
            this.tabCIS.Size = new System.Drawing.Size(1172, 567);
            this.tabCIS.TabIndex = 0;
            this.tabCIS.Text = "Coordinación | Ingresos propios | Servicios escolares";
            this.tabCIS.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Clave,
            this.Articulo,
            this.descripcionDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.Medida,
            this.cantidadNormalDataGridViewTextBoxColumn,
            this.cantidadCriticaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vInventarioCISBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1166, 479);
            this.dataGridView1.TabIndex = 1;
            // 
            // Clave
            // 
            this.Clave.DataPropertyName = "Clave";
            this.Clave.HeaderText = "Clave";
            this.Clave.Name = "Clave";
            this.Clave.ReadOnly = true;
            // 
            // Articulo
            // 
            this.Articulo.DataPropertyName = "Articulo";
            this.Articulo.HeaderText = "Articulo";
            this.Articulo.Name = "Articulo";
            this.Articulo.ReadOnly = true;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Medida
            // 
            this.Medida.DataPropertyName = "Medida";
            this.Medida.HeaderText = "Medida";
            this.Medida.Name = "Medida";
            this.Medida.ReadOnly = true;
            // 
            // cantidadNormalDataGridViewTextBoxColumn
            // 
            this.cantidadNormalDataGridViewTextBoxColumn.DataPropertyName = "CantidadNormal";
            this.cantidadNormalDataGridViewTextBoxColumn.HeaderText = "CantidadNormal";
            this.cantidadNormalDataGridViewTextBoxColumn.Name = "cantidadNormalDataGridViewTextBoxColumn";
            this.cantidadNormalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantidadCriticaDataGridViewTextBoxColumn
            // 
            this.cantidadCriticaDataGridViewTextBoxColumn.DataPropertyName = "CantidadCritica";
            this.cantidadCriticaDataGridViewTextBoxColumn.HeaderText = "CantidadCritica";
            this.cantidadCriticaDataGridViewTextBoxColumn.Name = "cantidadCriticaDataGridViewTextBoxColumn";
            this.cantidadCriticaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vInventarioCISBindingSource
            // 
            this.vInventarioCISBindingSource.DataMember = "vInventarioCIS";
            this.vInventarioCISBindingSource.DataSource = this.sCIDataSet;
            // 
            // sCIDataSet
            // 
            this.sCIDataSet.DataSetName = "SCIDataSet";
            this.sCIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 482);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1166, 82);
            this.panel1.TabIndex = 0;
            // 
            // tabITN
            // 
            this.tabITN.Controls.Add(this.dataGridView2);
            this.tabITN.Controls.Add(this.panel2);
            this.tabITN.Location = new System.Drawing.Point(4, 24);
            this.tabITN.Name = "tabITN";
            this.tabITN.Padding = new System.Windows.Forms.Padding(3);
            this.tabITN.Size = new System.Drawing.Size(1172, 567);
            this.tabITN.TabIndex = 2;
            this.tabITN.Text = "Intendencia";
            this.tabITN.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dataGridView2.DataSource = this.vInventarioITNBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(1166, 479);
            this.dataGridView2.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Clave";
            this.dataGridViewTextBoxColumn1.HeaderText = "Clave";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Articulo";
            this.dataGridViewTextBoxColumn2.HeaderText = "Articulo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Descripcion";
            this.dataGridViewTextBoxColumn3.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Cantidad";
            this.dataGridViewTextBoxColumn4.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Medida";
            this.dataGridViewTextBoxColumn5.HeaderText = "Medida";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "CantidadNormal";
            this.dataGridViewTextBoxColumn6.HeaderText = "CantidadNormal";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "CantidadCritica";
            this.dataGridViewTextBoxColumn7.HeaderText = "CantidadCritica";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // vInventarioITNBindingSource
            // 
            this.vInventarioITNBindingSource.DataMember = "vInventarioITN";
            this.vInventarioITNBindingSource.DataSource = this.sCIDataSet1;
            // 
            // sCIDataSet1
            // 
            this.sCIDataSet1.DataSetName = "SCIDataSet";
            this.sCIDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 482);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1166, 82);
            this.panel2.TabIndex = 2;
            // 
            // tabMNT
            // 
            this.tabMNT.Controls.Add(this.dataGridView3);
            this.tabMNT.Controls.Add(this.panel3);
            this.tabMNT.Location = new System.Drawing.Point(4, 24);
            this.tabMNT.Name = "tabMNT";
            this.tabMNT.Padding = new System.Windows.Forms.Padding(3);
            this.tabMNT.Size = new System.Drawing.Size(1172, 567);
            this.tabMNT.TabIndex = 3;
            this.tabMNT.Text = "Mantenimiento";
            this.tabMNT.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AllowUserToOrderColumns = true;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            this.dataGridView3.DataSource = this.vInventarioMTNBindingSource;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(3, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(1166, 479);
            this.dataGridView3.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Clave";
            this.dataGridViewTextBoxColumn8.HeaderText = "Clave";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Articulo";
            this.dataGridViewTextBoxColumn9.HeaderText = "Articulo";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Descripcion";
            this.dataGridViewTextBoxColumn10.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Cantidad";
            this.dataGridViewTextBoxColumn11.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Medida";
            this.dataGridViewTextBoxColumn12.HeaderText = "Medida";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "CantidadNormal";
            this.dataGridViewTextBoxColumn13.HeaderText = "CantidadNormal";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "CantidadCritica";
            this.dataGridViewTextBoxColumn14.HeaderText = "CantidadCritica";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // vInventarioMTNBindingSource
            // 
            this.vInventarioMTNBindingSource.DataMember = "vInventarioMTN";
            this.vInventarioMTNBindingSource.DataSource = this.sCIDataSet1;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 482);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1166, 82);
            this.panel3.TabIndex = 4;
            // 
            // tabSGR
            // 
            this.tabSGR.Controls.Add(this.dataGridView4);
            this.tabSGR.Controls.Add(this.panel4);
            this.tabSGR.Location = new System.Drawing.Point(4, 24);
            this.tabSGR.Name = "tabSGR";
            this.tabSGR.Padding = new System.Windows.Forms.Padding(3);
            this.tabSGR.Size = new System.Drawing.Size(1172, 567);
            this.tabSGR.TabIndex = 1;
            this.tabSGR.Text = "Servicios generales";
            this.tabSGR.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.AllowUserToOrderColumns = true;
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21});
            this.dataGridView4.DataSource = this.vInventarioSGRBindingSource;
            this.dataGridView4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView4.Location = new System.Drawing.Point(3, 3);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.Size = new System.Drawing.Size(1166, 479);
            this.dataGridView4.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Clave";
            this.dataGridViewTextBoxColumn15.HeaderText = "Clave";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Articulo";
            this.dataGridViewTextBoxColumn16.HeaderText = "Articulo";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Descripcion";
            this.dataGridViewTextBoxColumn17.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "Cantidad";
            this.dataGridViewTextBoxColumn18.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "Medida";
            this.dataGridViewTextBoxColumn19.HeaderText = "Medida";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "CantidadNormal";
            this.dataGridViewTextBoxColumn20.HeaderText = "CantidadNormal";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "CantidadCritica";
            this.dataGridViewTextBoxColumn21.HeaderText = "CantidadCritica";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.ReadOnly = true;
            // 
            // vInventarioSGRBindingSource
            // 
            this.vInventarioSGRBindingSource.DataMember = "vInventarioSGR";
            this.vInventarioSGRBindingSource.DataSource = this.sCIDataSet1;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(3, 482);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1166, 82);
            this.panel4.TabIndex = 4;
            // 
            // tabLBC
            // 
            this.tabLBC.Controls.Add(this.fillBy1ToolStrip);
            this.tabLBC.Controls.Add(this.inventarioDataGridView);
            this.tabLBC.Controls.Add(this.panel5);
            this.tabLBC.Location = new System.Drawing.Point(4, 24);
            this.tabLBC.Name = "tabLBC";
            this.tabLBC.Padding = new System.Windows.Forms.Padding(3);
            this.tabLBC.Size = new System.Drawing.Size(1172, 567);
            this.tabLBC.TabIndex = 4;
            this.tabLBC.Text = "Laboratorio de cómputo";
            this.tabLBC.UseVisualStyleBackColor = true;
            // 
            // fillBy1ToolStrip
            // 
            this.fillBy1ToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.fillBy1ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillBy1ToolStripButton});
            this.fillBy1ToolStrip.Location = new System.Drawing.Point(5, 454);
            this.fillBy1ToolStrip.Name = "fillBy1ToolStrip";
            this.fillBy1ToolStrip.Size = new System.Drawing.Size(152, 25);
            this.fillBy1ToolStrip.TabIndex = 2;
            this.fillBy1ToolStrip.Text = "fillBy1ToolStrip";
            // 
            // fillBy1ToolStripButton
            // 
            this.fillBy1ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillBy1ToolStripButton.Name = "fillBy1ToolStripButton";
            this.fillBy1ToolStripButton.Size = new System.Drawing.Size(140, 22);
            this.fillBy1ToolStripButton.Text = "Laboratorio de cómputo";
            this.fillBy1ToolStripButton.Click += new System.EventHandler(this.fillBy1ToolStripButton_Click);
            // 
            // inventarioDataGridView
            // 
            this.inventarioDataGridView.AllowUserToAddRows = false;
            this.inventarioDataGridView.AllowUserToDeleteRows = false;
            this.inventarioDataGridView.AllowUserToOrderColumns = true;
            this.inventarioDataGridView.AutoGenerateColumns = false;
            this.inventarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventarioDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24,
            this.dataGridViewTextBoxColumn25,
            this.dataGridViewTextBoxColumn26,
            this.dataGridViewTextBoxColumn27,
            this.dataGridViewTextBoxColumn28,
            this.dataGridViewTextBoxColumn36});
            this.inventarioDataGridView.DataSource = this.inventarioBindingSource;
            this.inventarioDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.inventarioDataGridView.Location = new System.Drawing.Point(3, 3);
            this.inventarioDataGridView.Name = "inventarioDataGridView";
            this.inventarioDataGridView.ReadOnly = true;
            this.inventarioDataGridView.Size = new System.Drawing.Size(1166, 453);
            this.inventarioDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "IdArea";
            this.dataGridViewTextBoxColumn22.HeaderText = "IdArea";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "IdArticulo";
            this.dataGridViewTextBoxColumn23.HeaderText = "IdArticulo";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "NombreArticulo";
            this.dataGridViewTextBoxColumn24.HeaderText = "NombreArticulo";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "Descripcion";
            this.dataGridViewTextBoxColumn25.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.DataPropertyName = "Cantidad";
            this.dataGridViewTextBoxColumn26.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            this.dataGridViewTextBoxColumn26.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.DataPropertyName = "IdUnidadMedida";
            this.dataGridViewTextBoxColumn27.HeaderText = "IdUnidadMedida";
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            this.dataGridViewTextBoxColumn27.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.DataPropertyName = "CantidadNormal";
            this.dataGridViewTextBoxColumn28.HeaderText = "CantidadNormal";
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            this.dataGridViewTextBoxColumn28.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn36
            // 
            this.dataGridViewTextBoxColumn36.DataPropertyName = "CantidadCritica";
            this.dataGridViewTextBoxColumn36.HeaderText = "CantidadCritica";
            this.dataGridViewTextBoxColumn36.Name = "dataGridViewTextBoxColumn36";
            this.dataGridViewTextBoxColumn36.ReadOnly = true;
            // 
            // inventarioBindingSource
            // 
            this.inventarioBindingSource.DataMember = "Inventario";
            this.inventarioBindingSource.DataSource = this.sCIDataSet;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(3, 482);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1166, 82);
            this.panel5.TabIndex = 4;
            // 
            // tabAMT
            // 
            this.tabAMT.AutoScroll = true;
            this.tabAMT.Controls.Add(this.inventarioDataGridView1);
            this.tabAMT.Controls.Add(this.paneBtnlAMT);
            this.tabAMT.Location = new System.Drawing.Point(4, 24);
            this.tabAMT.Name = "tabAMT";
            this.tabAMT.Padding = new System.Windows.Forms.Padding(3);
            this.tabAMT.Size = new System.Drawing.Size(1172, 567);
            this.tabAMT.TabIndex = 5;
            this.tabAMT.Text = "Archivo muerto";
            this.tabAMT.UseVisualStyleBackColor = true;
            // 
            // inventarioDataGridView1
            // 
            this.inventarioDataGridView1.AllowUserToAddRows = false;
            this.inventarioDataGridView1.AllowUserToDeleteRows = false;
            this.inventarioDataGridView1.AllowUserToOrderColumns = true;
            this.inventarioDataGridView1.AutoGenerateColumns = false;
            this.inventarioDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.inventarioDataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.inventarioDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventarioDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn29,
            this.dataGridViewTextBoxColumn30,
            this.dataGridViewTextBoxColumn31,
            this.dataGridViewTextBoxColumn32,
            this.dataGridViewTextBoxColumn33,
            this.dataGridViewTextBoxColumn34,
            this.dataGridViewTextBoxColumn35,
            this.dataGridViewTextBoxColumn37});
            this.inventarioDataGridView1.DataSource = this.inventarioBindingSource;
            this.inventarioDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inventarioDataGridView1.Location = new System.Drawing.Point(3, 3);
            this.inventarioDataGridView1.Name = "inventarioDataGridView1";
            this.inventarioDataGridView1.ReadOnly = true;
            this.inventarioDataGridView1.RowHeadersVisible = false;
            this.inventarioDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.inventarioDataGridView1.Size = new System.Drawing.Size(1166, 463);
            this.inventarioDataGridView1.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn29
            // 
            this.dataGridViewTextBoxColumn29.DataPropertyName = "IdArea";
            this.dataGridViewTextBoxColumn29.HeaderText = "IdArea";
            this.dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
            this.dataGridViewTextBoxColumn29.ReadOnly = true;
            this.dataGridViewTextBoxColumn29.Width = 67;
            // 
            // dataGridViewTextBoxColumn30
            // 
            this.dataGridViewTextBoxColumn30.DataPropertyName = "IdArticulo";
            this.dataGridViewTextBoxColumn30.HeaderText = "IdArticulo";
            this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
            this.dataGridViewTextBoxColumn30.ReadOnly = true;
            this.dataGridViewTextBoxColumn30.Width = 82;
            // 
            // dataGridViewTextBoxColumn31
            // 
            this.dataGridViewTextBoxColumn31.DataPropertyName = "NombreArticulo";
            this.dataGridViewTextBoxColumn31.HeaderText = "NombreArticulo";
            this.dataGridViewTextBoxColumn31.Name = "dataGridViewTextBoxColumn31";
            this.dataGridViewTextBoxColumn31.ReadOnly = true;
            this.dataGridViewTextBoxColumn31.Width = 117;
            // 
            // dataGridViewTextBoxColumn32
            // 
            this.dataGridViewTextBoxColumn32.DataPropertyName = "Descripcion";
            this.dataGridViewTextBoxColumn32.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn32.Name = "dataGridViewTextBoxColumn32";
            this.dataGridViewTextBoxColumn32.ReadOnly = true;
            this.dataGridViewTextBoxColumn32.Width = 97;
            // 
            // dataGridViewTextBoxColumn33
            // 
            this.dataGridViewTextBoxColumn33.DataPropertyName = "Cantidad";
            this.dataGridViewTextBoxColumn33.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn33.Name = "dataGridViewTextBoxColumn33";
            this.dataGridViewTextBoxColumn33.ReadOnly = true;
            this.dataGridViewTextBoxColumn33.Width = 81;
            // 
            // dataGridViewTextBoxColumn34
            // 
            this.dataGridViewTextBoxColumn34.DataPropertyName = "IdUnidadMedida";
            this.dataGridViewTextBoxColumn34.HeaderText = "IdUnidadMedida";
            this.dataGridViewTextBoxColumn34.Name = "dataGridViewTextBoxColumn34";
            this.dataGridViewTextBoxColumn34.ReadOnly = true;
            this.dataGridViewTextBoxColumn34.Width = 124;
            // 
            // dataGridViewTextBoxColumn35
            // 
            this.dataGridViewTextBoxColumn35.DataPropertyName = "CantidadNormal";
            this.dataGridViewTextBoxColumn35.HeaderText = "CantidadNormal";
            this.dataGridViewTextBoxColumn35.Name = "dataGridViewTextBoxColumn35";
            this.dataGridViewTextBoxColumn35.ReadOnly = true;
            this.dataGridViewTextBoxColumn35.Width = 122;
            // 
            // dataGridViewTextBoxColumn37
            // 
            this.dataGridViewTextBoxColumn37.DataPropertyName = "CantidadCritica";
            this.dataGridViewTextBoxColumn37.HeaderText = "CantidadCritica";
            this.dataGridViewTextBoxColumn37.Name = "dataGridViewTextBoxColumn37";
            this.dataGridViewTextBoxColumn37.ReadOnly = true;
            this.dataGridViewTextBoxColumn37.Width = 115;
            // 
            // paneBtnlAMT
            // 
            this.paneBtnlAMT.Controls.Add(cantidadCriticaLabel);
            this.paneBtnlAMT.Controls.Add(this.numericoCritico);
            this.paneBtnlAMT.Controls.Add(cantidadNormalLabel);
            this.paneBtnlAMT.Controls.Add(this.numericoNormal);
            this.paneBtnlAMT.Controls.Add(idUnidadMedidaLabel);
            this.paneBtnlAMT.Controls.Add(this.cbxMedida);
            this.paneBtnlAMT.Controls.Add(descripcionLabel);
            this.paneBtnlAMT.Controls.Add(this.tbxDescripcion);
            this.paneBtnlAMT.Controls.Add(nombreArticuloLabel);
            this.paneBtnlAMT.Controls.Add(this.tbxArticulo);
            this.paneBtnlAMT.Controls.Add(idAreaLabel);
            this.paneBtnlAMT.Controls.Add(this.cbxArea);
            this.paneBtnlAMT.Controls.Add(idArticuloLabel);
            this.paneBtnlAMT.Controls.Add(this.tbxId);
            this.paneBtnlAMT.Controls.Add(this.btnCancelarAMT);
            this.paneBtnlAMT.Controls.Add(this.btnGuardarAMT);
            this.paneBtnlAMT.Controls.Add(this.btnModificarAMT);
            this.paneBtnlAMT.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.paneBtnlAMT.Location = new System.Drawing.Point(3, 466);
            this.paneBtnlAMT.Name = "paneBtnlAMT";
            this.paneBtnlAMT.Size = new System.Drawing.Size(1166, 98);
            this.paneBtnlAMT.TabIndex = 4;
            // 
            // numericoCritico
            // 
            this.numericoCritico.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.inventarioBindingSource, "CantidadCritica", true));
            this.numericoCritico.Location = new System.Drawing.Point(567, 75);
            this.numericoCritico.Name = "numericoCritico";
            this.numericoCritico.Size = new System.Drawing.Size(120, 21);
            this.numericoCritico.TabIndex = 17;
            this.numericoCritico.ValueChanged += new System.EventHandler(this.cantidadCriticaNumericUpDown_ValueChanged);
            // 
            // numericoNormal
            // 
            this.numericoNormal.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.inventarioBindingSource, "CantidadNormal", true));
            this.numericoNormal.Location = new System.Drawing.Point(314, 74);
            this.numericoNormal.Name = "numericoNormal";
            this.numericoNormal.Size = new System.Drawing.Size(120, 21);
            this.numericoNormal.TabIndex = 16;
            // 
            // cbxMedida
            // 
            this.cbxMedida.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventarioBindingSource, "IdUnidadMedida", true));
            this.cbxMedida.DataSource = this.unidadMedidaBindingSource;
            this.cbxMedida.DisplayMember = "IdUnidadMedida";
            this.cbxMedida.FormattingEnabled = true;
            this.cbxMedida.Location = new System.Drawing.Point(67, 73);
            this.cbxMedida.Name = "cbxMedida";
            this.cbxMedida.Size = new System.Drawing.Size(121, 23);
            this.cbxMedida.TabIndex = 15;
            this.cbxMedida.ValueMember = "IdUnidadMedida";
            // 
            // unidadMedidaBindingSource
            // 
            this.unidadMedidaBindingSource.DataMember = "UnidadMedida";
            this.unidadMedidaBindingSource.DataSource = this.sCIDataSet2;
            // 
            // sCIDataSet2
            // 
            this.sCIDataSet2.DataSetName = "SCIDataSet";
            this.sCIDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbxDescripcion
            // 
            this.tbxDescripcion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventarioBindingSource, "Descripcion", true));
            this.tbxDescripcion.Location = new System.Drawing.Point(90, 43);
            this.tbxDescripcion.Name = "tbxDescripcion";
            this.tbxDescripcion.Size = new System.Drawing.Size(735, 21);
            this.tbxDescripcion.TabIndex = 14;
            // 
            // tbxArticulo
            // 
            this.tbxArticulo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventarioBindingSource, "NombreArticulo", true));
            this.tbxArticulo.Location = new System.Drawing.Point(433, 14);
            this.tbxArticulo.Name = "tbxArticulo";
            this.tbxArticulo.Size = new System.Drawing.Size(401, 21);
            this.tbxArticulo.TabIndex = 13;
            // 
            // cbxArea
            // 
            this.cbxArea.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventarioBindingSource, "IdArea", true));
            this.cbxArea.DataSource = this.areasBindingSource;
            this.cbxArea.DisplayMember = "IdArea";
            this.cbxArea.FormattingEnabled = true;
            this.cbxArea.Location = new System.Drawing.Point(194, 14);
            this.cbxArea.Name = "cbxArea";
            this.cbxArea.Size = new System.Drawing.Size(121, 23);
            this.cbxArea.TabIndex = 12;
            this.cbxArea.ValueMember = "IdArea";
            // 
            // areasBindingSource
            // 
            this.areasBindingSource.DataMember = "Areas";
            this.areasBindingSource.DataSource = this.sCIDataSet2;
            // 
            // tbxId
            // 
            this.tbxId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventarioBindingSource, "IdArticulo", true));
            this.tbxId.Enabled = false;
            this.tbxId.Location = new System.Drawing.Point(37, 12);
            this.tbxId.Name = "tbxId";
            this.tbxId.Size = new System.Drawing.Size(100, 21);
            this.tbxId.TabIndex = 11;
            // 
            // btnCancelarAMT
            // 
            this.btnCancelarAMT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnCancelarAMT.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarAMT.Image")));
            this.btnCancelarAMT.Location = new System.Drawing.Point(1086, 12);
            this.btnCancelarAMT.Name = "btnCancelarAMT";
            this.btnCancelarAMT.Size = new System.Drawing.Size(50, 50);
            this.btnCancelarAMT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCancelarAMT.TabIndex = 10;
            this.btnCancelarAMT.TabStop = false;
            this.btnCancelarAMT.Click += new System.EventHandler(this.btnCancelarAMT_Click);
            // 
            // btnGuardarAMT
            // 
            this.btnGuardarAMT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnGuardarAMT.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarAMT.Image")));
            this.btnGuardarAMT.Location = new System.Drawing.Point(1014, 12);
            this.btnGuardarAMT.Name = "btnGuardarAMT";
            this.btnGuardarAMT.Size = new System.Drawing.Size(50, 50);
            this.btnGuardarAMT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnGuardarAMT.TabIndex = 9;
            this.btnGuardarAMT.TabStop = false;
            this.btnGuardarAMT.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // btnModificarAMT
            // 
            this.btnModificarAMT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnModificarAMT.Image = ((System.Drawing.Image)(resources.GetObject("btnModificarAMT.Image")));
            this.btnModificarAMT.Location = new System.Drawing.Point(946, 12);
            this.btnModificarAMT.Name = "btnModificarAMT";
            this.btnModificarAMT.Size = new System.Drawing.Size(50, 50);
            this.btnModificarAMT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnModificarAMT.TabIndex = 8;
            this.btnModificarAMT.TabStop = false;
            this.btnModificarAMT.Click += new System.EventHandler(this.btnModificarAMT_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // vInventarioAMTBindingSource
            // 
            this.vInventarioAMTBindingSource.DataMember = "vInventarioAMT";
            this.vInventarioAMTBindingSource.DataSource = this.sCIDataSet1;
            // 
            // vInventarioLBCBindingSource
            // 
            this.vInventarioLBCBindingSource.DataMember = "vInventarioLBC";
            this.vInventarioLBCBindingSource.DataSource = this.sCIDataSet1;
            // 
            // vInventarioCISTableAdapter
            // 
            this.vInventarioCISTableAdapter.ClearBeforeFill = true;
            // 
            // vInventarioITNTableAdapter
            // 
            this.vInventarioITNTableAdapter.ClearBeforeFill = true;
            // 
            // vInventarioMTNTableAdapter
            // 
            this.vInventarioMTNTableAdapter.ClearBeforeFill = true;
            // 
            // vInventarioSGRTableAdapter
            // 
            this.vInventarioSGRTableAdapter.ClearBeforeFill = true;
            // 
            // vInventarioLBCTableAdapter
            // 
            this.vInventarioLBCTableAdapter.ClearBeforeFill = true;
            // 
            // vInventarioAMTTableAdapter
            // 
            //this.vInventarioAMTTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AreasTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.InventarioTableAdapter = null;
            this.tableAdapterManager.UnidadMedidaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SCI0.SCIDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            // 
            // inventarioTableAdapter
            // 
            this.inventarioTableAdapter.ClearBeforeFill = true;
            // 
            // inventarioBindingSource1
            // 
            this.inventarioBindingSource1.DataMember = "Inventario";
            this.inventarioBindingSource1.DataSource = this.sCIDataSet1;
            // 
            // areasTableAdapter
            // 
            this.areasTableAdapter.ClearBeforeFill = true;
            // 
            // unidadMedidaTableAdapter
            // 
            this.unidadMedidaTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 620);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panelTitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabCIS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vInventarioCISBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCIDataSet)).EndInit();
            this.tabITN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vInventarioITNBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCIDataSet1)).EndInit();
            this.tabMNT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vInventarioMTNBindingSource)).EndInit();
            this.tabSGR.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vInventarioSGRBindingSource)).EndInit();
            this.tabLBC.ResumeLayout(false);
            this.tabLBC.PerformLayout();
            this.fillBy1ToolStrip.ResumeLayout(false);
            this.fillBy1ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioBindingSource)).EndInit();
            this.tabAMT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inventarioDataGridView1)).EndInit();
            this.paneBtnlAMT.ResumeLayout(false);
            this.paneBtnlAMT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericoCritico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericoNormal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidadMedidaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCIDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelarAMT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardarAMT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnModificarAMT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.vInventarioAMTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vInventarioLBCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.TabPage tabCIS;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tabSGR;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SCIDataSet sCIDataSet;
        private System.Windows.Forms.BindingSource vInventarioCISBindingSource;
        private SCIDataSetTableAdapters.vInventarioCISTableAdapter vInventarioCISTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clave;
        private System.Windows.Forms.DataGridViewTextBoxColumn Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medida;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadNormalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadCriticaDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabITN;
        private System.Windows.Forms.TabPage tabMNT;
        private System.Windows.Forms.TabPage tabLBC;
        private System.Windows.Forms.TabPage tabAMT;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Panel panel2;
        private SCIDataSet sCIDataSet1;
        private System.Windows.Forms.BindingSource vInventarioITNBindingSource;
        private SCIDataSetTableAdapters.vInventarioITNTableAdapter vInventarioITNTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.BindingSource vInventarioMTNBindingSource;
        private SCIDataSetTableAdapters.vInventarioMTNTableAdapter vInventarioMTNTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.BindingSource vInventarioSGRBindingSource;
        private SCIDataSetTableAdapters.vInventarioSGRTableAdapter vInventarioSGRTableAdapter;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.BindingSource vInventarioLBCBindingSource;
        private SCIDataSetTableAdapters.vInventarioLBCTableAdapter vInventarioLBCTableAdapter;
        private System.Windows.Forms.Panel paneBtnlAMT;
        private System.Windows.Forms.BindingSource vInventarioAMTBindingSource;
        //private SCIDataSetTableAdapters.vInventarioAMTTableAdapter vInventarioAMTTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private SCIDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.PictureBox btnCancelarAMT;
        private System.Windows.Forms.PictureBox btnGuardarAMT;
        private System.Windows.Forms.PictureBox btnModificarAMT;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.BindingSource inventarioBindingSource;
        private SCIDataSetTableAdapters.InventarioTableAdapter inventarioTableAdapter;
        private System.Windows.Forms.BindingSource inventarioBindingSource1;
        private System.Windows.Forms.DataGridView inventarioDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn36;
        private System.Windows.Forms.ToolStrip fillBy1ToolStrip;
        private System.Windows.Forms.ToolStripButton fillBy1ToolStripButton;
        private System.Windows.Forms.DataGridView inventarioDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn33;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn34;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn35;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn37;
        private System.Windows.Forms.TextBox tbxId;
        private System.Windows.Forms.ComboBox cbxArea;
        private SCIDataSet sCIDataSet2;
        private System.Windows.Forms.BindingSource areasBindingSource;
        private SCIDataSetTableAdapters.AreasTableAdapter areasTableAdapter;
        private System.Windows.Forms.ComboBox cbxMedida;
        private System.Windows.Forms.TextBox tbxDescripcion;
        private System.Windows.Forms.TextBox tbxArticulo;
        private System.Windows.Forms.BindingSource unidadMedidaBindingSource;
        private SCIDataSetTableAdapters.UnidadMedidaTableAdapter unidadMedidaTableAdapter;
        private System.Windows.Forms.NumericUpDown numericoCritico;
        private System.Windows.Forms.NumericUpDown numericoNormal;
    }
}

