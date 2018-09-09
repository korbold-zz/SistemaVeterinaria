namespace PROYECTO_VETERINARIA
{
    partial class FRM_Usuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing )
        {
            if ( disposing && ( components != null ) )
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
        private void InitializeComponent ( )
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label iD_USUARIOLabel;
            System.Windows.Forms.Label iD_ROLLabel;
            System.Windows.Forms.Label iD_PERSONALabel;
            System.Windows.Forms.Label nOMBRE_USUARIOLabel;
            System.Windows.Forms.Label cLAVELabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Usuarios));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iD_USUARIOLabel1 = new System.Windows.Forms.Label();
            this.tAB_USUARIOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSveterinaria = new PROYECTO_VETERINARIA.DSveterinaria();
            this.iD_ROLComboBox = new System.Windows.Forms.ComboBox();
            this.tAB_ROLESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iD_PERSONAComboBox = new System.Windows.Forms.ComboBox();
            this.tAB_PERSONABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nOMBRE_USUARIOTextBox = new System.Windows.Forms.TextBox();
            this.cLAVETextBox = new System.Windows.Forms.TextBox();
            this.tAB_USUARIOSTableAdapter = new PROYECTO_VETERINARIA.DSveterinariaTableAdapters.TAB_USUARIOSTableAdapter();
            this.tableAdapterManager = new PROYECTO_VETERINARIA.DSveterinariaTableAdapters.TableAdapterManager();
            this.tAB_PERSONATableAdapter = new PROYECTO_VETERINARIA.DSveterinariaTableAdapters.TAB_PERSONATableAdapter();
            this.tAB_ROLESTableAdapter = new PROYECTO_VETERINARIA.DSveterinariaTableAdapters.TAB_ROLESTableAdapter();
            this.tAB_USUARIOSBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.btnAgregar = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnActualizar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.tAB_USUARIOSDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tABPERSONABindingSource = new System.Windows.Forms.BindingSource(this.components);
            iD_USUARIOLabel = new System.Windows.Forms.Label();
            iD_ROLLabel = new System.Windows.Forms.Label();
            iD_PERSONALabel = new System.Windows.Forms.Label();
            nOMBRE_USUARIOLabel = new System.Windows.Forms.Label();
            cLAVELabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_USUARIOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSveterinaria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_ROLESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_PERSONABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_USUARIOSBindingNavigator)).BeginInit();
            this.tAB_USUARIOSBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_USUARIOSDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tABPERSONABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_USUARIOLabel
            // 
            iD_USUARIOLabel.AutoSize = true;
            iD_USUARIOLabel.Location = new System.Drawing.Point(36, 22);
            iD_USUARIOLabel.Name = "iD_USUARIOLabel";
            iD_USUARIOLabel.Size = new System.Drawing.Size(73, 13);
            iD_USUARIOLabel.TabIndex = 0;
            iD_USUARIOLabel.Text = "ID USUARIO:";
            // 
            // iD_ROLLabel
            // 
            iD_ROLLabel.AutoSize = true;
            iD_ROLLabel.Location = new System.Drawing.Point(36, 51);
            iD_ROLLabel.Name = "iD_ROLLabel";
            iD_ROLLabel.Size = new System.Drawing.Size(46, 13);
            iD_ROLLabel.TabIndex = 2;
            iD_ROLLabel.Text = "ID ROL:";
            // 
            // iD_PERSONALabel
            // 
            iD_PERSONALabel.AutoSize = true;
            iD_PERSONALabel.Location = new System.Drawing.Point(36, 78);
            iD_PERSONALabel.Name = "iD_PERSONALabel";
            iD_PERSONALabel.Size = new System.Drawing.Size(53, 13);
            iD_PERSONALabel.TabIndex = 4;
            iD_PERSONALabel.Text = "CÉDULA:";
            // 
            // nOMBRE_USUARIOLabel
            // 
            nOMBRE_USUARIOLabel.AutoSize = true;
            nOMBRE_USUARIOLabel.Location = new System.Drawing.Point(36, 105);
            nOMBRE_USUARIOLabel.Name = "nOMBRE_USUARIOLabel";
            nOMBRE_USUARIOLabel.Size = new System.Drawing.Size(109, 13);
            nOMBRE_USUARIOLabel.TabIndex = 6;
            nOMBRE_USUARIOLabel.Text = "NOMBRE USUARIO:";
            // 
            // cLAVELabel
            // 
            cLAVELabel.AutoSize = true;
            cLAVELabel.Location = new System.Drawing.Point(36, 131);
            cLAVELabel.Name = "cLAVELabel";
            cLAVELabel.Size = new System.Drawing.Size(44, 13);
            cLAVELabel.TabIndex = 8;
            cLAVELabel.Text = "CLAVE:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(iD_USUARIOLabel);
            this.panel1.Controls.Add(this.iD_USUARIOLabel1);
            this.panel1.Controls.Add(iD_ROLLabel);
            this.panel1.Controls.Add(this.iD_ROLComboBox);
            this.panel1.Controls.Add(iD_PERSONALabel);
            this.panel1.Controls.Add(this.iD_PERSONAComboBox);
            this.panel1.Controls.Add(nOMBRE_USUARIOLabel);
            this.panel1.Controls.Add(this.nOMBRE_USUARIOTextBox);
            this.panel1.Controls.Add(cLAVELabel);
            this.panel1.Controls.Add(this.cLAVETextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(517, 171);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Location = new System.Drawing.Point(364, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(131, 130);
            this.panel2.TabIndex = 10;
            // 
            // iD_USUARIOLabel1
            // 
            this.iD_USUARIOLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAB_USUARIOSBindingSource, "ID_USUARIO", true));
            this.iD_USUARIOLabel1.Location = new System.Drawing.Point(151, 22);
            this.iD_USUARIOLabel1.Name = "iD_USUARIOLabel1";
            this.iD_USUARIOLabel1.Size = new System.Drawing.Size(121, 23);
            this.iD_USUARIOLabel1.TabIndex = 1;
            this.iD_USUARIOLabel1.Text = "label1";
            // 
            // tAB_USUARIOSBindingSource
            // 
            this.tAB_USUARIOSBindingSource.DataMember = "TAB_USUARIOS";
            this.tAB_USUARIOSBindingSource.DataSource = this.dSveterinaria;
            // 
            // dSveterinaria
            // 
            this.dSveterinaria.DataSetName = "DSveterinaria";
            this.dSveterinaria.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iD_ROLComboBox
            // 
            this.iD_ROLComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tAB_USUARIOSBindingSource, "ID_ROL", true));
            this.iD_ROLComboBox.DataSource = this.tAB_ROLESBindingSource;
            this.iD_ROLComboBox.DisplayMember = "ROL";
            this.iD_ROLComboBox.FormattingEnabled = true;
            this.iD_ROLComboBox.Location = new System.Drawing.Point(151, 48);
            this.iD_ROLComboBox.Name = "iD_ROLComboBox";
            this.iD_ROLComboBox.Size = new System.Drawing.Size(121, 21);
            this.iD_ROLComboBox.TabIndex = 3;
            this.iD_ROLComboBox.ValueMember = "ID_ROL";
            // 
            // tAB_ROLESBindingSource
            // 
            this.tAB_ROLESBindingSource.DataMember = "TAB_ROLES";
            this.tAB_ROLESBindingSource.DataSource = this.dSveterinaria;
            // 
            // iD_PERSONAComboBox
            // 
            this.iD_PERSONAComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tAB_USUARIOSBindingSource, "ID_PERSONA", true));
            this.iD_PERSONAComboBox.DataSource = this.tABPERSONABindingSource;
            this.iD_PERSONAComboBox.DisplayMember = "CEDULA";
            this.iD_PERSONAComboBox.FormattingEnabled = true;
            this.iD_PERSONAComboBox.Location = new System.Drawing.Point(151, 75);
            this.iD_PERSONAComboBox.Name = "iD_PERSONAComboBox";
            this.iD_PERSONAComboBox.Size = new System.Drawing.Size(121, 21);
            this.iD_PERSONAComboBox.TabIndex = 5;
            this.iD_PERSONAComboBox.ValueMember = "ID_PERSONA";
            // 
            // tAB_PERSONABindingSource
            // 
            this.tAB_PERSONABindingSource.DataMember = "TAB_PERSONA";
            this.tAB_PERSONABindingSource.DataSource = this.dSveterinaria;
            // 
            // nOMBRE_USUARIOTextBox
            // 
            this.nOMBRE_USUARIOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAB_USUARIOSBindingSource, "NOMBRE_USUARIO", true));
            this.nOMBRE_USUARIOTextBox.Location = new System.Drawing.Point(151, 102);
            this.nOMBRE_USUARIOTextBox.Name = "nOMBRE_USUARIOTextBox";
            this.nOMBRE_USUARIOTextBox.Size = new System.Drawing.Size(121, 20);
            this.nOMBRE_USUARIOTextBox.TabIndex = 7;
            // 
            // cLAVETextBox
            // 
            this.cLAVETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAB_USUARIOSBindingSource, "CLAVE", true));
            this.cLAVETextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLAVETextBox.Location = new System.Drawing.Point(151, 128);
            this.cLAVETextBox.Name = "cLAVETextBox";
            this.cLAVETextBox.PasswordChar = '•';
            this.cLAVETextBox.Size = new System.Drawing.Size(121, 24);
            this.cLAVETextBox.TabIndex = 9;
            // 
            // tAB_USUARIOSTableAdapter
            // 
            this.tAB_USUARIOSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TAB_CANTONESTableAdapter = null;
            this.tableAdapterManager.TAB_CLIENTESTableAdapter = null;
            this.tableAdapterManager.TAB_CONTROL_MASCOTATableAdapter = null;
            this.tableAdapterManager.TAB_FICHA_DE_INGRESOTableAdapter = null;
            this.tableAdapterManager.TAB_MASCOTATableAdapter = null;
            this.tableAdapterManager.TAB_MEDICAMENTOS_SUMINISTRADOSTableAdapter = null;
            this.tableAdapterManager.TAB_MEDICAMENTOSTableAdapter = null;
            this.tableAdapterManager.TAB_MEDICOSTableAdapter = null;
            this.tableAdapterManager.TAB_PERSONATableAdapter = this.tAB_PERSONATableAdapter;
            this.tableAdapterManager.TAB_PROVINCIASTableAdapter = null;
            this.tableAdapterManager.TAB_RAZATableAdapter = null;
            this.tableAdapterManager.TAB_REGISTRO_DIARIOTableAdapter = null;
            this.tableAdapterManager.TAB_ROLESTableAdapter = this.tAB_ROLESTableAdapter;
            this.tableAdapterManager.TAB_SALIDA_DE_MASCOTATableAdapter = null;
            this.tableAdapterManager.TAB_TIPO_DE_MASCOTATableAdapter = null;
            this.tableAdapterManager.TAB_USUARIOSTableAdapter = this.tAB_USUARIOSTableAdapter;
            this.tableAdapterManager.UpdateOrder = PROYECTO_VETERINARIA.DSveterinariaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tAB_PERSONATableAdapter
            // 
            this.tAB_PERSONATableAdapter.ClearBeforeFill = true;
            // 
            // tAB_ROLESTableAdapter
            // 
            this.tAB_ROLESTableAdapter.ClearBeforeFill = true;
            // 
            // tAB_USUARIOSBindingNavigator
            // 
            this.tAB_USUARIOSBindingNavigator.AddNewItem = this.btnAgregar;
            this.tAB_USUARIOSBindingNavigator.BindingSource = this.tAB_USUARIOSBindingSource;
            this.tAB_USUARIOSBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tAB_USUARIOSBindingNavigator.DeleteItem = this.btnEliminar;
            this.tAB_USUARIOSBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorSeparator2,
            this.btnAgregar,
            this.btnEliminar,
            this.btnGuardar,
            this.btnActualizar,
            this.btnCancelar});
            this.tAB_USUARIOSBindingNavigator.Location = new System.Drawing.Point(0, 171);
            this.tAB_USUARIOSBindingNavigator.MoveFirstItem = null;
            this.tAB_USUARIOSBindingNavigator.MoveLastItem = null;
            this.tAB_USUARIOSBindingNavigator.MoveNextItem = null;
            this.tAB_USUARIOSBindingNavigator.MovePreviousItem = null;
            this.tAB_USUARIOSBindingNavigator.Name = "tAB_USUARIOSBindingNavigator";
            this.tAB_USUARIOSBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tAB_USUARIOSBindingNavigator.Size = new System.Drawing.Size(517, 25);
            this.tAB_USUARIOSBindingNavigator.TabIndex = 1;
            this.tAB_USUARIOSBindingNavigator.Text = "bindingNavigator1";
            // 
            // btnAgregar
            // 
            this.btnAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.RightToLeftAutoMirrorImage = true;
            this.btnAgregar.Size = new System.Drawing.Size(23, 22);
            this.btnAgregar.Text = "Agregar nuevo";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // btnEliminar
            // 
            this.btnEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.RightToLeftAutoMirrorImage = true;
            this.btnEliminar.Size = new System.Drawing.Size(23, 22);
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnGuardar
            // 
            this.btnGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(23, 22);
            this.btnGuardar.Text = "Guardar datos";
            this.btnGuardar.Click += new System.EventHandler(this.tAB_USUARIOSBindingNavigatorSaveItem_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(23, 22);
            this.btnActualizar.Text = "toolStripButton1";
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(23, 22);
            this.btnCancelar.Text = "toolStripButton2";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // tAB_USUARIOSDataGridView
            // 
            this.tAB_USUARIOSDataGridView.AllowUserToAddRows = false;
            this.tAB_USUARIOSDataGridView.AllowUserToDeleteRows = false;
            this.tAB_USUARIOSDataGridView.AutoGenerateColumns = false;
            this.tAB_USUARIOSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tAB_USUARIOSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.tAB_USUARIOSDataGridView.DataSource = this.tAB_USUARIOSBindingSource;
            this.tAB_USUARIOSDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tAB_USUARIOSDataGridView.Location = new System.Drawing.Point(0, 196);
            this.tAB_USUARIOSDataGridView.Name = "tAB_USUARIOSDataGridView";
            this.tAB_USUARIOSDataGridView.ReadOnly = true;
            this.tAB_USUARIOSDataGridView.Size = new System.Drawing.Size(517, 311);
            this.tAB_USUARIOSDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_USUARIO";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ID_ROL";
            this.dataGridViewTextBoxColumn2.DataSource = this.tAB_ROLESBindingSource;
            this.dataGridViewTextBoxColumn2.DisplayMember = "ROL";
            this.dataGridViewTextBoxColumn2.HeaderText = "ROL";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "ID_ROL";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ID_PERSONA";
            this.dataGridViewTextBoxColumn3.DataSource = this.tAB_PERSONABindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "CEDULA";
            this.dataGridViewTextBoxColumn3.HeaderText = "CÉDULA";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "ID_PERSONA";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NOMBRE_USUARIO";
            this.dataGridViewTextBoxColumn4.HeaderText = "NOMBRE USUARIO";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // tABPERSONABindingSource
            // 
            this.tABPERSONABindingSource.DataMember = "TAB_PERSONA";
            this.tABPERSONABindingSource.DataSource = this.dSveterinaria;
            // 
            // FRM_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 507);
            this.Controls.Add(this.tAB_USUARIOSDataGridView);
            this.Controls.Add(this.tAB_USUARIOSBindingNavigator);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRM_Usuarios";
            this.Text = "FRM_Usuarios";
            this.Load += new System.EventHandler(this.FRM_Usuarios_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_USUARIOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSveterinaria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_ROLESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_PERSONABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_USUARIOSBindingNavigator)).EndInit();
            this.tAB_USUARIOSBindingNavigator.ResumeLayout(false);
            this.tAB_USUARIOSBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_USUARIOSDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tABPERSONABindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DSveterinaria dSveterinaria;
        private System.Windows.Forms.BindingSource tAB_USUARIOSBindingSource;
        private DSveterinariaTableAdapters.TAB_USUARIOSTableAdapter tAB_USUARIOSTableAdapter;
        private DSveterinariaTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tAB_USUARIOSBindingNavigator;
        private System.Windows.Forms.ToolStripButton btnAgregar;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.Label iD_USUARIOLabel1;
        private System.Windows.Forms.ComboBox iD_ROLComboBox;
        private System.Windows.Forms.ComboBox iD_PERSONAComboBox;
        private System.Windows.Forms.TextBox nOMBRE_USUARIOTextBox;
        private System.Windows.Forms.TextBox cLAVETextBox;
        private DSveterinariaTableAdapters.TAB_ROLESTableAdapter tAB_ROLESTableAdapter;
        private System.Windows.Forms.DataGridView tAB_USUARIOSDataGridView;
        private System.Windows.Forms.BindingSource tAB_ROLESBindingSource;
        private DSveterinariaTableAdapters.TAB_PERSONATableAdapter tAB_PERSONATableAdapter;
        private System.Windows.Forms.BindingSource tAB_PERSONABindingSource;
        private System.Windows.Forms.ToolStripButton btnActualizar;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.BindingSource tABPERSONABindingSource;
    }
}