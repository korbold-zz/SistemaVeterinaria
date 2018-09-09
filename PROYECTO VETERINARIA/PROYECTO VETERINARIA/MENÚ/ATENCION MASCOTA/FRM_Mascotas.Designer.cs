namespace PROYECTO_VETERINARIA
{
    partial class FRM_Mascotas
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
            System.Windows.Forms.Label iD_MASCOTALabel;
            System.Windows.Forms.Label iD_PERSONALabel;
            System.Windows.Forms.Label iD_TIPODEMASCOTALabel;
            System.Windows.Forms.Label nOMBRELabel;
            System.Windows.Forms.Label cOLORLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Mascotas));
            System.Windows.Forms.Label iD_RAZALabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iD_MASCOTALabel1 = new System.Windows.Forms.Label();
            this.tAB_MASCOTABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSveterinaria = new PROYECTO_VETERINARIA.DSveterinaria();
            this.iD_PERSONAComboBox = new System.Windows.Forms.ComboBox();
            this.tABPERSONABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iD_TIPODEMASCOTAComboBox = new System.Windows.Forms.ComboBox();
            this.tABTIPODEMASCOTABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tABRAZABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nOMBRETextBox = new System.Windows.Forms.TextBox();
            this.cOLORTextBox = new System.Windows.Forms.TextBox();
            this.tAB_MASCOTATableAdapter = new PROYECTO_VETERINARIA.DSveterinariaTableAdapters.TAB_MASCOTATableAdapter();
            this.tableAdapterManager = new PROYECTO_VETERINARIA.DSveterinariaTableAdapters.TableAdapterManager();
            this.tAB_PERSONATableAdapter = new PROYECTO_VETERINARIA.DSveterinariaTableAdapters.TAB_PERSONATableAdapter();
            this.tAB_RAZATableAdapter = new PROYECTO_VETERINARIA.DSveterinariaTableAdapters.TAB_RAZATableAdapter();
            this.tAB_TIPO_DE_MASCOTATableAdapter = new PROYECTO_VETERINARIA.DSveterinariaTableAdapters.TAB_TIPO_DE_MASCOTATableAdapter();
            this.tAB_MASCOTABindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tAB_MASCOTADataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tAB_RAZABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iD_RAZAComboBox = new System.Windows.Forms.ComboBox();
            this.tAB_RAZABindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tAB_RAZABindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            iD_MASCOTALabel = new System.Windows.Forms.Label();
            iD_PERSONALabel = new System.Windows.Forms.Label();
            iD_TIPODEMASCOTALabel = new System.Windows.Forms.Label();
            nOMBRELabel = new System.Windows.Forms.Label();
            cOLORLabel = new System.Windows.Forms.Label();
            iD_RAZALabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_MASCOTABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSveterinaria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tABPERSONABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tABTIPODEMASCOTABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tABRAZABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_MASCOTABindingNavigator)).BeginInit();
            this.tAB_MASCOTABindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_MASCOTADataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_RAZABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_RAZABindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_RAZABindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_MASCOTALabel
            // 
            iD_MASCOTALabel.AutoSize = true;
            iD_MASCOTALabel.Location = new System.Drawing.Point(80, 24);
            iD_MASCOTALabel.Name = "iD_MASCOTALabel";
            iD_MASCOTALabel.Size = new System.Drawing.Size(76, 13);
            iD_MASCOTALabel.TabIndex = 0;
            iD_MASCOTALabel.Text = "ID MASCOTA:";
            // 
            // iD_PERSONALabel
            // 
            iD_PERSONALabel.AutoSize = true;
            iD_PERSONALabel.Location = new System.Drawing.Point(80, 53);
            iD_PERSONALabel.Name = "iD_PERSONALabel";
            iD_PERSONALabel.Size = new System.Drawing.Size(53, 13);
            iD_PERSONALabel.TabIndex = 2;
            iD_PERSONALabel.Text = "CÉDULA:";
            // 
            // iD_TIPODEMASCOTALabel
            // 
            iD_TIPODEMASCOTALabel.AutoSize = true;
            iD_TIPODEMASCOTALabel.Location = new System.Drawing.Point(80, 80);
            iD_TIPODEMASCOTALabel.Name = "iD_TIPODEMASCOTALabel";
            iD_TIPODEMASCOTALabel.Size = new System.Drawing.Size(102, 13);
            iD_TIPODEMASCOTALabel.TabIndex = 4;
            iD_TIPODEMASCOTALabel.Text = "TIPODEMASCOTA:";
            // 
            // nOMBRELabel
            // 
            nOMBRELabel.AutoSize = true;
            nOMBRELabel.Location = new System.Drawing.Point(80, 134);
            nOMBRELabel.Name = "nOMBRELabel";
            nOMBRELabel.Size = new System.Drawing.Size(57, 13);
            nOMBRELabel.TabIndex = 8;
            nOMBRELabel.Text = "NOMBRE:";
            // 
            // cOLORLabel
            // 
            cOLORLabel.AutoSize = true;
            cOLORLabel.Location = new System.Drawing.Point(80, 160);
            cOLORLabel.Name = "cOLORLabel";
            cOLORLabel.Size = new System.Drawing.Size(47, 13);
            cOLORLabel.TabIndex = 10;
            cOLORLabel.Text = "COLOR:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(iD_RAZALabel);
            this.panel1.Controls.Add(this.iD_RAZAComboBox);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(iD_MASCOTALabel);
            this.panel1.Controls.Add(this.iD_MASCOTALabel1);
            this.panel1.Controls.Add(iD_PERSONALabel);
            this.panel1.Controls.Add(this.iD_PERSONAComboBox);
            this.panel1.Controls.Add(iD_TIPODEMASCOTALabel);
            this.panel1.Controls.Add(this.iD_TIPODEMASCOTAComboBox);
            this.panel1.Controls.Add(nOMBRELabel);
            this.panel1.Controls.Add(this.nOMBRETextBox);
            this.panel1.Controls.Add(cOLORLabel);
            this.panel1.Controls.Add(this.cOLORTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(613, 264);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Location = new System.Drawing.Point(332, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(261, 244);
            this.panel2.TabIndex = 12;
            // 
            // iD_MASCOTALabel1
            // 
            this.iD_MASCOTALabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAB_MASCOTABindingSource, "ID_MASCOTA", true));
            this.iD_MASCOTALabel1.Location = new System.Drawing.Point(202, 24);
            this.iD_MASCOTALabel1.Name = "iD_MASCOTALabel1";
            this.iD_MASCOTALabel1.Size = new System.Drawing.Size(121, 23);
            this.iD_MASCOTALabel1.TabIndex = 1;
            this.iD_MASCOTALabel1.Text = "label1";
            // 
            // tAB_MASCOTABindingSource
            // 
            this.tAB_MASCOTABindingSource.DataMember = "TAB_MASCOTA";
            this.tAB_MASCOTABindingSource.DataSource = this.dSveterinaria;
            // 
            // dSveterinaria
            // 
            this.dSveterinaria.DataSetName = "DSveterinaria";
            this.dSveterinaria.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iD_PERSONAComboBox
            // 
            this.iD_PERSONAComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAB_MASCOTABindingSource, "ID_PERSONA", true));
            this.iD_PERSONAComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tABPERSONABindingSource, "ID_PERSONA", true));
            this.iD_PERSONAComboBox.DataSource = this.tABPERSONABindingSource;
            this.iD_PERSONAComboBox.DisplayMember = "CEDULA";
            this.iD_PERSONAComboBox.FormattingEnabled = true;
            this.iD_PERSONAComboBox.Location = new System.Drawing.Point(202, 50);
            this.iD_PERSONAComboBox.Name = "iD_PERSONAComboBox";
            this.iD_PERSONAComboBox.Size = new System.Drawing.Size(121, 21);
            this.iD_PERSONAComboBox.TabIndex = 3;
            this.iD_PERSONAComboBox.ValueMember = "ID_PERSONA";
            // 
            // tABPERSONABindingSource
            // 
            this.tABPERSONABindingSource.DataMember = "TAB_PERSONA";
            this.tABPERSONABindingSource.DataSource = this.dSveterinaria;
            // 
            // iD_TIPODEMASCOTAComboBox
            // 
            this.iD_TIPODEMASCOTAComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAB_MASCOTABindingSource, "ID_TIPODEMASCOTA", true));
            this.iD_TIPODEMASCOTAComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tABTIPODEMASCOTABindingSource, "ID_TIPODEMASCOTA", true));
            this.iD_TIPODEMASCOTAComboBox.DataSource = this.tABTIPODEMASCOTABindingSource;
            this.iD_TIPODEMASCOTAComboBox.DisplayMember = "TIPO_DE_MASCOTA";
            this.iD_TIPODEMASCOTAComboBox.FormattingEnabled = true;
            this.iD_TIPODEMASCOTAComboBox.Location = new System.Drawing.Point(202, 77);
            this.iD_TIPODEMASCOTAComboBox.Name = "iD_TIPODEMASCOTAComboBox";
            this.iD_TIPODEMASCOTAComboBox.Size = new System.Drawing.Size(121, 21);
            this.iD_TIPODEMASCOTAComboBox.TabIndex = 5;
            this.iD_TIPODEMASCOTAComboBox.ValueMember = "ID_TIPODEMASCOTA";
            // 
            // tABTIPODEMASCOTABindingSource
            // 
            this.tABTIPODEMASCOTABindingSource.DataMember = "TAB_TIPO_DE_MASCOTA";
            this.tABTIPODEMASCOTABindingSource.DataSource = this.dSveterinaria;
            // 
            // tABRAZABindingSource
            // 
            this.tABRAZABindingSource.DataMember = "TAB_RAZA";
            this.tABRAZABindingSource.DataSource = this.dSveterinaria;
            // 
            // nOMBRETextBox
            // 
            this.nOMBRETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAB_MASCOTABindingSource, "NOMBRE", true));
            this.nOMBRETextBox.Location = new System.Drawing.Point(202, 131);
            this.nOMBRETextBox.Name = "nOMBRETextBox";
            this.nOMBRETextBox.Size = new System.Drawing.Size(121, 20);
            this.nOMBRETextBox.TabIndex = 9;
            this.nOMBRETextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nOMBRETextBox_KeyPress);
            // 
            // cOLORTextBox
            // 
            this.cOLORTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAB_MASCOTABindingSource, "COLOR", true));
            this.cOLORTextBox.Location = new System.Drawing.Point(202, 157);
            this.cOLORTextBox.Name = "cOLORTextBox";
            this.cOLORTextBox.Size = new System.Drawing.Size(121, 20);
            this.cOLORTextBox.TabIndex = 11;
            this.cOLORTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cOLORTextBox_KeyPress);
            // 
            // tAB_MASCOTATableAdapter
            // 
            this.tAB_MASCOTATableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TAB_CANTONESTableAdapter = null;
            this.tableAdapterManager.TAB_CLIENTESTableAdapter = null;
            this.tableAdapterManager.TAB_CONTROL_MASCOTATableAdapter = null;
            this.tableAdapterManager.TAB_FICHA_DE_INGRESOTableAdapter = null;
            this.tableAdapterManager.TAB_MASCOTATableAdapter = this.tAB_MASCOTATableAdapter;
            this.tableAdapterManager.TAB_MEDICAMENTOS_SUMINISTRADOSTableAdapter = null;
            this.tableAdapterManager.TAB_MEDICAMENTOSTableAdapter = null;
            this.tableAdapterManager.TAB_MEDICOSTableAdapter = null;
            this.tableAdapterManager.TAB_PERSONATableAdapter = this.tAB_PERSONATableAdapter;
            this.tableAdapterManager.TAB_PROVINCIASTableAdapter = null;
            this.tableAdapterManager.TAB_RAZATableAdapter = this.tAB_RAZATableAdapter;
            this.tableAdapterManager.TAB_REGISTRO_DIARIOTableAdapter = null;
            this.tableAdapterManager.TAB_ROLESTableAdapter = null;
            this.tableAdapterManager.TAB_SALIDA_DE_MASCOTATableAdapter = null;
            this.tableAdapterManager.TAB_TIPO_DE_MASCOTATableAdapter = this.tAB_TIPO_DE_MASCOTATableAdapter;
            this.tableAdapterManager.TAB_USUARIOSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PROYECTO_VETERINARIA.DSveterinariaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tAB_PERSONATableAdapter
            // 
            this.tAB_PERSONATableAdapter.ClearBeforeFill = true;
            // 
            // tAB_RAZATableAdapter
            // 
            this.tAB_RAZATableAdapter.ClearBeforeFill = true;
            // 
            // tAB_TIPO_DE_MASCOTATableAdapter
            // 
            this.tAB_TIPO_DE_MASCOTATableAdapter.ClearBeforeFill = true;
            // 
            // tAB_MASCOTABindingNavigator
            // 
            this.tAB_MASCOTABindingNavigator.AddNewItem = this.btnAgregar;
            this.tAB_MASCOTABindingNavigator.BindingSource = this.tAB_MASCOTABindingSource;
            this.tAB_MASCOTABindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tAB_MASCOTABindingNavigator.DeleteItem = this.btnEliminar;
            this.tAB_MASCOTABindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tAB_MASCOTABindingNavigator.Location = new System.Drawing.Point(0, 264);
            this.tAB_MASCOTABindingNavigator.MoveFirstItem = null;
            this.tAB_MASCOTABindingNavigator.MoveLastItem = null;
            this.tAB_MASCOTABindingNavigator.MoveNextItem = null;
            this.tAB_MASCOTABindingNavigator.MovePreviousItem = null;
            this.tAB_MASCOTABindingNavigator.Name = "tAB_MASCOTABindingNavigator";
            this.tAB_MASCOTABindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tAB_MASCOTABindingNavigator.Size = new System.Drawing.Size(613, 25);
            this.tAB_MASCOTABindingNavigator.TabIndex = 1;
            this.tAB_MASCOTABindingNavigator.Text = "bindingNavigator1";
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
            this.btnEliminar.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
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
            this.btnGuardar.Click += new System.EventHandler(this.tAB_MASCOTABindingNavigatorSaveItem_Click);
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
            // tAB_MASCOTADataGridView
            // 
            this.tAB_MASCOTADataGridView.AllowUserToAddRows = false;
            this.tAB_MASCOTADataGridView.AllowUserToDeleteRows = false;
            this.tAB_MASCOTADataGridView.AutoGenerateColumns = false;
            this.tAB_MASCOTADataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tAB_MASCOTADataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.tAB_MASCOTADataGridView.DataSource = this.tAB_MASCOTABindingSource;
            this.tAB_MASCOTADataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tAB_MASCOTADataGridView.Location = new System.Drawing.Point(0, 289);
            this.tAB_MASCOTADataGridView.Name = "tAB_MASCOTADataGridView";
            this.tAB_MASCOTADataGridView.ReadOnly = true;
            this.tAB_MASCOTADataGridView.Size = new System.Drawing.Size(613, 202);
            this.tAB_MASCOTADataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_MASCOTA";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ID_PERSONA";
            this.dataGridViewTextBoxColumn2.DataSource = this.tABPERSONABindingSource;
            this.dataGridViewTextBoxColumn2.DisplayMember = "CEDULA";
            this.dataGridViewTextBoxColumn2.HeaderText = "CÉDULA";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "ID_PERSONA";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ID_TIPODEMASCOTA";
            this.dataGridViewTextBoxColumn3.DataSource = this.tABTIPODEMASCOTABindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "TIPO_DE_MASCOTA";
            this.dataGridViewTextBoxColumn3.HeaderText = "TIPO DE MASCOTA";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "ID_TIPODEMASCOTA";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ID_RAZA";
            this.dataGridViewTextBoxColumn4.DataSource = this.tABRAZABindingSource;
            this.dataGridViewTextBoxColumn4.DisplayMember = "TIPO_RAZA";
            this.dataGridViewTextBoxColumn4.HeaderText = "RAZA";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn4.ValueMember = "ID_RAZA";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "NOMBRE";
            this.dataGridViewTextBoxColumn5.HeaderText = "NOMBRE";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "COLOR";
            this.dataGridViewTextBoxColumn6.HeaderText = "COLOR";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // tAB_RAZABindingSource
            // 
            this.tAB_RAZABindingSource.DataMember = "TAB_RAZA";
            this.tAB_RAZABindingSource.DataSource = this.dSveterinaria;
            // 
            // iD_RAZALabel
            // 
            iD_RAZALabel.AutoSize = true;
            iD_RAZALabel.Location = new System.Drawing.Point(84, 107);
            iD_RAZALabel.Name = "iD_RAZALabel";
            iD_RAZALabel.Size = new System.Drawing.Size(53, 13);
            iD_RAZALabel.TabIndex = 12;
            iD_RAZALabel.Text = "ID RAZA:";
            iD_RAZALabel.Click += new System.EventHandler(this.iD_RAZALabel_Click);
            // 
            // iD_RAZAComboBox
            // 
            this.iD_RAZAComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tAB_MASCOTABindingSource, "ID_RAZA", true));
            this.iD_RAZAComboBox.DataSource = this.tAB_RAZABindingSource2;
            this.iD_RAZAComboBox.DisplayMember = "TIPO_RAZA";
            this.iD_RAZAComboBox.FormattingEnabled = true;
            this.iD_RAZAComboBox.Location = new System.Drawing.Point(202, 104);
            this.iD_RAZAComboBox.Name = "iD_RAZAComboBox";
            this.iD_RAZAComboBox.Size = new System.Drawing.Size(121, 21);
            this.iD_RAZAComboBox.TabIndex = 13;
            this.iD_RAZAComboBox.ValueMember = "ID_RAZA";
            // 
            // tAB_RAZABindingSource1
            // 
            this.tAB_RAZABindingSource1.DataMember = "TAB_RAZA";
            this.tAB_RAZABindingSource1.DataSource = this.dSveterinaria;
            // 
            // tAB_RAZABindingSource2
            // 
            this.tAB_RAZABindingSource2.DataMember = "FK_TAB_RAZA_REFERENCE_TAB_TIPO";
            this.tAB_RAZABindingSource2.DataSource = this.tABTIPODEMASCOTABindingSource;
            // 
            // FRM_Mascotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 491);
            this.Controls.Add(this.tAB_MASCOTADataGridView);
            this.Controls.Add(this.tAB_MASCOTABindingNavigator);
            this.Controls.Add(this.panel1);
            this.Name = "FRM_Mascotas";
            this.Text = "Mascotas";
            this.Load += new System.EventHandler(this.FRM_Mascotas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_MASCOTABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSveterinaria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tABPERSONABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tABTIPODEMASCOTABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tABRAZABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_MASCOTABindingNavigator)).EndInit();
            this.tAB_MASCOTABindingNavigator.ResumeLayout(false);
            this.tAB_MASCOTABindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_MASCOTADataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_RAZABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_RAZABindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_RAZABindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DSveterinaria dSveterinaria;
        private System.Windows.Forms.BindingSource tAB_MASCOTABindingSource;
        private DSveterinariaTableAdapters.TAB_MASCOTATableAdapter tAB_MASCOTATableAdapter;
        private DSveterinariaTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tAB_MASCOTABindingNavigator;
        private System.Windows.Forms.ToolStripButton btnAgregar;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.Label iD_MASCOTALabel1;
        private System.Windows.Forms.ComboBox iD_PERSONAComboBox;
        private System.Windows.Forms.ComboBox iD_TIPODEMASCOTAComboBox;
        private System.Windows.Forms.TextBox nOMBRETextBox;
        private System.Windows.Forms.TextBox cOLORTextBox;
        private DSveterinariaTableAdapters.TAB_PERSONATableAdapter tAB_PERSONATableAdapter;
        private System.Windows.Forms.DataGridView tAB_MASCOTADataGridView;
        private System.Windows.Forms.BindingSource tABPERSONABindingSource;
        private DSveterinariaTableAdapters.TAB_TIPO_DE_MASCOTATableAdapter tAB_TIPO_DE_MASCOTATableAdapter;
        private System.Windows.Forms.BindingSource tABTIPODEMASCOTABindingSource;
        private DSveterinariaTableAdapters.TAB_RAZATableAdapter tAB_RAZATableAdapter;
        private System.Windows.Forms.BindingSource tABRAZABindingSource;
        private System.Windows.Forms.ToolStripButton btnActualizar;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.BindingSource tAB_RAZABindingSource;
        private System.Windows.Forms.ComboBox iD_RAZAComboBox;
        private System.Windows.Forms.BindingSource tAB_RAZABindingSource1;
        private System.Windows.Forms.BindingSource tAB_RAZABindingSource2;
    }
}