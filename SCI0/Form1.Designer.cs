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
            System.Windows.Forms.Label cantidadCriticaLabel;
            System.Windows.Forms.Label cantidadNormalLabel;
            System.Windows.Forms.Label idUnidadMedidaLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label nombreArticuloLabel;
            System.Windows.Forms.Label idAreaLabel;
            System.Windows.Forms.Label idArticuloLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.btnAMT = new System.Windows.Forms.Button();
            this.btnLBC = new System.Windows.Forms.Button();
            this.btnSGR = new System.Windows.Forms.Button();
            this.btnMTN = new System.Windows.Forms.Button();
            this.btnCIS = new System.Windows.Forms.Button();
            this.btnITN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabInventario = new System.Windows.Forms.TabControl();
            this.tabAreasEditar = new System.Windows.Forms.TabPage();
            this.inventarioDataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn33 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn34 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn35 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn37 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sCIDataSet = new SCI0.SCIDataSet();
            this.unidadMedidaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.areasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableAdapterManager = new SCI0.SCIDataSetTableAdapters.TableAdapterManager();
            this.inventarioTableAdapter = new SCI0.SCIDataSetTableAdapters.InventarioTableAdapter();
            this.inventarioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.areasTableAdapter = new SCI0.SCIDataSetTableAdapters.AreasTableAdapter();
            this.unidadMedidaTableAdapter = new SCI0.SCIDataSetTableAdapters.UnidadMedidaTableAdapter();
            this.paneBtnlAMT = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.numericoCritico = new System.Windows.Forms.NumericUpDown();
            this.numericoNormal = new System.Windows.Forms.NumericUpDown();
            this.cbxMedida = new System.Windows.Forms.ComboBox();
            this.tbxDescripcion = new System.Windows.Forms.TextBox();
            this.tbxArticulo = new System.Windows.Forms.TextBox();
            this.cbxArea = new System.Windows.Forms.ComboBox();
            this.tbxId = new System.Windows.Forms.TextBox();
            cantidadCriticaLabel = new System.Windows.Forms.Label();
            cantidadNormalLabel = new System.Windows.Forms.Label();
            idUnidadMedidaLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            nombreArticuloLabel = new System.Windows.Forms.Label();
            idAreaLabel = new System.Windows.Forms.Label();
            idArticuloLabel = new System.Windows.Forms.Label();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabInventario.SuspendLayout();
            this.tabAreasEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCIDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidadMedidaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioBindingSource1)).BeginInit();
            this.paneBtnlAMT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericoCritico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericoNormal)).BeginInit();
            this.SuspendLayout();
            // 
            // cantidadCriticaLabel
            // 
            cantidadCriticaLabel.AutoSize = true;
            cantidadCriticaLabel.Location = new System.Drawing.Point(465, 75);
            cantidadCriticaLabel.Name = "cantidadCriticaLabel";
            cantidadCriticaLabel.Size = new System.Drawing.Size(84, 13);
            cantidadCriticaLabel.TabIndex = 16;
            cantidadCriticaLabel.Text = "Cantidad Critica:";
            // 
            // cantidadNormalLabel
            // 
            cantidadNormalLabel.AutoSize = true;
            cantidadNormalLabel.Location = new System.Drawing.Point(205, 74);
            cantidadNormalLabel.Name = "cantidadNormalLabel";
            cantidadNormalLabel.Size = new System.Drawing.Size(88, 13);
            cantidadNormalLabel.TabIndex = 15;
            cantidadNormalLabel.Text = "Cantidad Normal:";
            // 
            // idUnidadMedidaLabel
            // 
            idUnidadMedidaLabel.AutoSize = true;
            idUnidadMedidaLabel.Location = new System.Drawing.Point(9, 76);
            idUnidadMedidaLabel.Name = "idUnidadMedidaLabel";
            idUnidadMedidaLabel.Size = new System.Drawing.Size(45, 13);
            idUnidadMedidaLabel.TabIndex = 14;
            idUnidadMedidaLabel.Text = "Medida:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(9, 46);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(66, 13);
            descripcionLabel.TabIndex = 13;
            descripcionLabel.Text = "Descripcion:";
            // 
            // nombreArticuloLabel
            // 
            nombreArticuloLabel.AutoSize = true;
            nombreArticuloLabel.Location = new System.Drawing.Point(329, 17);
            nombreArticuloLabel.Name = "nombreArticuloLabel";
            nombreArticuloLabel.Size = new System.Drawing.Size(45, 13);
            nombreArticuloLabel.TabIndex = 12;
            nombreArticuloLabel.Text = "Articulo:";
            // 
            // idAreaLabel
            // 
            idAreaLabel.AutoSize = true;
            idAreaLabel.Location = new System.Drawing.Point(153, 17);
            idAreaLabel.Name = "idAreaLabel";
            idAreaLabel.Size = new System.Drawing.Size(32, 13);
            idAreaLabel.TabIndex = 11;
            idAreaLabel.Text = "Área:";
            // 
            // idArticuloLabel
            // 
            idArticuloLabel.AutoSize = true;
            idArticuloLabel.Location = new System.Drawing.Point(14, 14);
            idArticuloLabel.Name = "idArticuloLabel";
            idArticuloLabel.Size = new System.Drawing.Size(22, 13);
            idArticuloLabel.TabIndex = 10;
            idArticuloLabel.Text = "Id: ";
            // 
            // panelTitulo
            // 
            this.panelTitulo.Controls.Add(this.btnAMT);
            this.panelTitulo.Controls.Add(this.btnLBC);
            this.panelTitulo.Controls.Add(this.btnSGR);
            this.panelTitulo.Controls.Add(this.btnMTN);
            this.panelTitulo.Controls.Add(this.btnCIS);
            this.panelTitulo.Controls.Add(this.btnITN);
            this.panelTitulo.Controls.Add(this.label1);
            this.panelTitulo.Controls.Add(this.pictureBox1);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(1183, 25);
            this.panelTitulo.TabIndex = 0;
            // 
            // btnAMT
            // 
            this.btnAMT.Location = new System.Drawing.Point(915, -1);
            this.btnAMT.Name = "btnAMT";
            this.btnAMT.Size = new System.Drawing.Size(144, 23);
            this.btnAMT.TabIndex = 26;
            this.btnAMT.Text = "Archivo muerto";
            this.btnAMT.UseVisualStyleBackColor = true;
            this.btnAMT.MouseHover += new System.EventHandler(this.aMTToolStripButton_Click);
            // 
            // btnLBC
            // 
            this.btnLBC.Location = new System.Drawing.Point(765, 0);
            this.btnLBC.Name = "btnLBC";
            this.btnLBC.Size = new System.Drawing.Size(144, 23);
            this.btnLBC.TabIndex = 25;
            this.btnLBC.Text = "Laboratorio de cómputo";
            this.btnLBC.UseVisualStyleBackColor = true;
            this.btnLBC.Click += new System.EventHandler(this.lBCToolStripButton_Click);
            // 
            // btnSGR
            // 
            this.btnSGR.Location = new System.Drawing.Point(640, 0);
            this.btnSGR.Name = "btnSGR";
            this.btnSGR.Size = new System.Drawing.Size(119, 23);
            this.btnSGR.TabIndex = 24;
            this.btnSGR.Text = "Servicios generales";
            this.btnSGR.UseVisualStyleBackColor = true;
            this.btnSGR.Click += new System.EventHandler(this.sGRToolStripButton_Click);
            // 
            // btnMTN
            // 
            this.btnMTN.Location = new System.Drawing.Point(544, 0);
            this.btnMTN.Name = "btnMTN";
            this.btnMTN.Size = new System.Drawing.Size(90, 23);
            this.btnMTN.TabIndex = 23;
            this.btnMTN.Text = "Mantenimiento";
            this.btnMTN.UseVisualStyleBackColor = true;
            this.btnMTN.Click += new System.EventHandler(this.mNTToolStripButton_Click);
            // 
            // btnCIS
            // 
            this.btnCIS.Location = new System.Drawing.Point(194, 0);
            this.btnCIS.Name = "btnCIS";
            this.btnCIS.Size = new System.Drawing.Size(260, 23);
            this.btnCIS.TabIndex = 22;
            this.btnCIS.Text = "Coordinación Ingresos propios y Servicios escolares";
            this.btnCIS.UseVisualStyleBackColor = true;
            this.btnCIS.Click += new System.EventHandler(this.coordinacionToolStripButton_Click);
            // 
            // btnITN
            // 
            this.btnITN.Location = new System.Drawing.Point(460, 0);
            this.btnITN.Name = "btnITN";
            this.btnITN.Size = new System.Drawing.Size(75, 23);
            this.btnITN.TabIndex = 21;
            this.btnITN.Text = "Intendencia";
            this.btnITN.UseVisualStyleBackColor = true;
            this.btnITN.Click += new System.EventHandler(this.intendenciaToolStripButton_Click);
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
            // tabInventario
            // 
            this.tabInventario.Controls.Add(this.tabAreasEditar);
            this.tabInventario.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabInventario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabInventario.Location = new System.Drawing.Point(0, 25);
            this.tabInventario.Name = "tabInventario";
            this.tabInventario.SelectedIndex = 0;
            this.tabInventario.Size = new System.Drawing.Size(1183, 969);
            this.tabInventario.TabIndex = 1;
            // 
            // tabAreasEditar
            // 
            this.tabAreasEditar.AutoScroll = true;
            this.tabAreasEditar.Controls.Add(this.inventarioDataGridView1);
            this.tabAreasEditar.Location = new System.Drawing.Point(4, 24);
            this.tabAreasEditar.Name = "tabAreasEditar";
            this.tabAreasEditar.Padding = new System.Windows.Forms.Padding(3);
            this.tabAreasEditar.Size = new System.Drawing.Size(1175, 941);
            this.tabAreasEditar.TabIndex = 5;
            this.tabAreasEditar.Text = "Áreas";
            this.tabAreasEditar.UseVisualStyleBackColor = true;
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
            this.inventarioDataGridView1.Size = new System.Drawing.Size(1169, 935);
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
            // inventarioBindingSource
            // 
            this.inventarioBindingSource.DataMember = "Inventario";
            this.inventarioBindingSource.DataSource = this.sCIDataSet;
            // 
            // sCIDataSet
            // 
            this.sCIDataSet.DataSetName = "SCIDataSet";
            this.sCIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
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
            // areasTableAdapter
            // 
            this.areasTableAdapter.ClearBeforeFill = true;
            // 
            // unidadMedidaTableAdapter
            // 
            this.unidadMedidaTableAdapter.ClearBeforeFill = true;
            // 
            // paneBtnlAMT
            // 
            this.paneBtnlAMT.Controls.Add(this.btnCancelar);
            this.paneBtnlAMT.Controls.Add(this.btnGuardar);
            this.paneBtnlAMT.Controls.Add(this.BtnEditar);
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
            this.paneBtnlAMT.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.paneBtnlAMT.Location = new System.Drawing.Point(0, 896);
            this.paneBtnlAMT.Name = "paneBtnlAMT";
            this.paneBtnlAMT.Size = new System.Drawing.Size(1183, 98);
            this.paneBtnlAMT.TabIndex = 5;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(1094, 17);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(70, 70);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardar.Location = new System.Drawing.Point(1018, 17);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(70, 70);
            this.btnGuardar.TabIndex = 19;
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEditar.Image = ((System.Drawing.Image)(resources.GetObject("BtnEditar.Image")));
            this.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnEditar.Location = new System.Drawing.Point(942, 17);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(70, 70);
            this.BtnEditar.TabIndex = 18;
            this.BtnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // numericoCritico
            // 
            this.numericoCritico.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.inventarioBindingSource, "CantidadCritica", true));
            this.numericoCritico.Location = new System.Drawing.Point(567, 75);
            this.numericoCritico.Name = "numericoCritico";
            this.numericoCritico.Size = new System.Drawing.Size(120, 20);
            this.numericoCritico.TabIndex = 17;
            // 
            // numericoNormal
            // 
            this.numericoNormal.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.inventarioBindingSource, "CantidadNormal", true));
            this.numericoNormal.Location = new System.Drawing.Point(314, 74);
            this.numericoNormal.Name = "numericoNormal";
            this.numericoNormal.Size = new System.Drawing.Size(120, 20);
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
            this.cbxMedida.Size = new System.Drawing.Size(121, 21);
            this.cbxMedida.TabIndex = 15;
            this.cbxMedida.ValueMember = "IdUnidadMedida";
            // 
            // tbxDescripcion
            // 
            this.tbxDescripcion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventarioBindingSource, "Descripcion", true));
            this.tbxDescripcion.Location = new System.Drawing.Point(90, 43);
            this.tbxDescripcion.Name = "tbxDescripcion";
            this.tbxDescripcion.Size = new System.Drawing.Size(597, 20);
            this.tbxDescripcion.TabIndex = 14;
            // 
            // tbxArticulo
            // 
            this.tbxArticulo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventarioBindingSource, "NombreArticulo", true));
            this.tbxArticulo.Location = new System.Drawing.Point(380, 14);
            this.tbxArticulo.Name = "tbxArticulo";
            this.tbxArticulo.Size = new System.Drawing.Size(307, 20);
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
            this.cbxArea.Size = new System.Drawing.Size(121, 21);
            this.cbxArea.TabIndex = 12;
            this.cbxArea.ValueMember = "IdArea";
            // 
            // tbxId
            // 
            this.tbxId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventarioBindingSource, "IdArticulo", true));
            this.tbxId.Enabled = false;
            this.tbxId.Location = new System.Drawing.Point(37, 12);
            this.tbxId.Name = "tbxId";
            this.tbxId.Size = new System.Drawing.Size(100, 20);
            this.tbxId.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 994);
            this.Controls.Add(this.paneBtnlAMT);
            this.Controls.Add(this.tabInventario);
            this.Controls.Add(this.panelTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabInventario.ResumeLayout(false);
            this.tabAreasEditar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inventarioDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCIDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidadMedidaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioBindingSource1)).EndInit();
            this.paneBtnlAMT.ResumeLayout(false);
            this.paneBtnlAMT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericoCritico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericoNormal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitulo;
        private SCIDataSet sCIDataSet;
        private System.Windows.Forms.TabControl tabInventario;
        private System.Windows.Forms.TabPage tabAreasEditar;
        //private SCIDataSetTableAdapters.vInventarioAMTTableAdapter vInventarioAMTTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private SCIDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.BindingSource inventarioBindingSource;
        private SCIDataSetTableAdapters.InventarioTableAdapter inventarioTableAdapter;
        private System.Windows.Forms.BindingSource inventarioBindingSource1;
        private System.Windows.Forms.DataGridView inventarioDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn33;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn34;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn35;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn37;
        private System.Windows.Forms.BindingSource areasBindingSource;
        private SCIDataSetTableAdapters.AreasTableAdapter areasTableAdapter;
        private System.Windows.Forms.BindingSource unidadMedidaBindingSource;
        private SCIDataSetTableAdapters.UnidadMedidaTableAdapter unidadMedidaTableAdapter;
        private System.Windows.Forms.Panel paneBtnlAMT;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.NumericUpDown numericoCritico;
        private System.Windows.Forms.NumericUpDown numericoNormal;
        private System.Windows.Forms.ComboBox cbxMedida;
        private System.Windows.Forms.TextBox tbxDescripcion;
        private System.Windows.Forms.TextBox tbxArticulo;
        private System.Windows.Forms.ComboBox cbxArea;
        private System.Windows.Forms.TextBox tbxId;
        private System.Windows.Forms.Button btnITN;
        private System.Windows.Forms.Button btnCIS;
        private System.Windows.Forms.Button btnAMT;
        private System.Windows.Forms.Button btnLBC;
        private System.Windows.Forms.Button btnSGR;
        private System.Windows.Forms.Button btnMTN;
    }
}

