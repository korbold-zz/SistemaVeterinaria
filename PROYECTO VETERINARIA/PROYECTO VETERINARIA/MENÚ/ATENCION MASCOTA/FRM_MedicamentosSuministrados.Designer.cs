namespace PROYECTO_VETERINARIA
{
    partial class FRM_MedicamentosSuministrados
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
            System.Windows.Forms.Label iD_MEDIACAMENTO_SUMINISTRADOLabel;
            System.Windows.Forms.Label iD_MEDICAMENTOLabel;
            System.Windows.Forms.Label iD_FICHA_INGRESOLabel;
            System.Windows.Forms.Label fECHA_SUMINISTROLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_MedicamentosSuministrados));
            this.panel1 = new System.Windows.Forms.Panel();
            this.iD_MEDIACAMENTO_SUMINISTRADOLabel1 = new System.Windows.Forms.Label();
            this.tAB_MEDICAMENTOS_SUMINISTRADOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSveterinaria = new PROYECTO_VETERINARIA.DSveterinaria();
            this.iD_MEDICAMENTOComboBox = new System.Windows.Forms.ComboBox();
            this.tABMEDICAMENTOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iD_FICHA_INGRESOComboBox = new System.Windows.Forms.ComboBox();
            this.tABFICHADEINGRESOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fECHA_SUMINISTRODateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tAB_MEDICAMENTOS_SUMINISTRADOSTableAdapter = new PROYECTO_VETERINARIA.DSveterinariaTableAdapters.TAB_MEDICAMENTOS_SUMINISTRADOSTableAdapter();
            this.tableAdapterManager = new PROYECTO_VETERINARIA.DSveterinariaTableAdapters.TableAdapterManager();
            this.tAB_FICHA_DE_INGRESOTableAdapter = new PROYECTO_VETERINARIA.DSveterinariaTableAdapters.TAB_FICHA_DE_INGRESOTableAdapter();
            this.tAB_MEDICAMENTOSTableAdapter = new PROYECTO_VETERINARIA.DSveterinariaTableAdapters.TAB_MEDICAMENTOSTableAdapter();
            this.tAB_MEDICAMENTOS_SUMINISTRADOSBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tAB_MEDICAMENTOS_SUMINISTRADOSDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visualStyler1 = new SkinSoft.VisualStyler.VisualStyler(this.components);
            iD_MEDIACAMENTO_SUMINISTRADOLabel = new System.Windows.Forms.Label();
            iD_MEDICAMENTOLabel = new System.Windows.Forms.Label();
            iD_FICHA_INGRESOLabel = new System.Windows.Forms.Label();
            fECHA_SUMINISTROLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_MEDICAMENTOS_SUMINISTRADOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSveterinaria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tABMEDICAMENTOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tABFICHADEINGRESOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_MEDICAMENTOS_SUMINISTRADOSBindingNavigator)).BeginInit();
            this.tAB_MEDICAMENTOS_SUMINISTRADOSBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_MEDICAMENTOS_SUMINISTRADOSDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visualStyler1)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_MEDIACAMENTO_SUMINISTRADOLabel
            // 
            iD_MEDIACAMENTO_SUMINISTRADOLabel.AutoSize = true;
            iD_MEDIACAMENTO_SUMINISTRADOLabel.Location = new System.Drawing.Point(102, 27);
            iD_MEDIACAMENTO_SUMINISTRADOLabel.Name = "iD_MEDIACAMENTO_SUMINISTRADOLabel";
            iD_MEDIACAMENTO_SUMINISTRADOLabel.Size = new System.Drawing.Size(197, 13);
            iD_MEDIACAMENTO_SUMINISTRADOLabel.TabIndex = 0;
            iD_MEDIACAMENTO_SUMINISTRADOLabel.Text = "ID MEDIACAMENTO SUMINISTRADO:";
            // 
            // iD_MEDICAMENTOLabel
            // 
            iD_MEDICAMENTOLabel.AutoSize = true;
            iD_MEDICAMENTOLabel.Location = new System.Drawing.Point(102, 56);
            iD_MEDICAMENTOLabel.Name = "iD_MEDICAMENTOLabel";
            iD_MEDICAMENTOLabel.Size = new System.Drawing.Size(104, 13);
            iD_MEDICAMENTOLabel.TabIndex = 2;
            iD_MEDICAMENTOLabel.Text = "ID MEDICAMENTO:";
            // 
            // iD_FICHA_INGRESOLabel
            // 
            iD_FICHA_INGRESOLabel.AutoSize = true;
            iD_FICHA_INGRESOLabel.Location = new System.Drawing.Point(102, 83);
            iD_FICHA_INGRESOLabel.Name = "iD_FICHA_INGRESOLabel";
            iD_FICHA_INGRESOLabel.Size = new System.Drawing.Size(107, 13);
            iD_FICHA_INGRESOLabel.TabIndex = 4;
            iD_FICHA_INGRESOLabel.Text = "ID FICHA INGRESO:";
            // 
            // fECHA_SUMINISTROLabel
            // 
            fECHA_SUMINISTROLabel.AutoSize = true;
            fECHA_SUMINISTROLabel.Location = new System.Drawing.Point(102, 111);
            fECHA_SUMINISTROLabel.Name = "fECHA_SUMINISTROLabel";
            fECHA_SUMINISTROLabel.Size = new System.Drawing.Size(116, 13);
            fECHA_SUMINISTROLabel.TabIndex = 6;
            fECHA_SUMINISTROLabel.Text = "FECHA SUMINISTRO:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(iD_MEDIACAMENTO_SUMINISTRADOLabel);
            this.panel1.Controls.Add(this.iD_MEDIACAMENTO_SUMINISTRADOLabel1);
            this.panel1.Controls.Add(iD_MEDICAMENTOLabel);
            this.panel1.Controls.Add(this.iD_MEDICAMENTOComboBox);
            this.panel1.Controls.Add(iD_FICHA_INGRESOLabel);
            this.panel1.Controls.Add(this.iD_FICHA_INGRESOComboBox);
            this.panel1.Controls.Add(fECHA_SUMINISTROLabel);
            this.panel1.Controls.Add(this.fECHA_SUMINISTRODateTimePicker);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(591, 146);
            this.panel1.TabIndex = 0;
            // 
            // iD_MEDIACAMENTO_SUMINISTRADOLabel1
            // 
            this.iD_MEDIACAMENTO_SUMINISTRADOLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAB_MEDICAMENTOS_SUMINISTRADOSBindingSource, "ID_MEDIACAMENTO_SUMINISTRADO", true));
            this.iD_MEDIACAMENTO_SUMINISTRADOLabel1.Location = new System.Drawing.Point(305, 27);
            this.iD_MEDIACAMENTO_SUMINISTRADOLabel1.Name = "iD_MEDIACAMENTO_SUMINISTRADOLabel1";
            this.iD_MEDIACAMENTO_SUMINISTRADOLabel1.Size = new System.Drawing.Size(200, 23);
            this.iD_MEDIACAMENTO_SUMINISTRADOLabel1.TabIndex = 1;
            this.iD_MEDIACAMENTO_SUMINISTRADOLabel1.Text = "label1";
            // 
            // tAB_MEDICAMENTOS_SUMINISTRADOSBindingSource
            // 
            this.tAB_MEDICAMENTOS_SUMINISTRADOSBindingSource.DataMember = "TAB_MEDICAMENTOS_SUMINISTRADOS";
            this.tAB_MEDICAMENTOS_SUMINISTRADOSBindingSource.DataSource = this.dSveterinaria;
            // 
            // dSveterinaria
            // 
            this.dSveterinaria.DataSetName = "DSveterinaria";
            this.dSveterinaria.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iD_MEDICAMENTOComboBox
            // 
            this.iD_MEDICAMENTOComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAB_MEDICAMENTOS_SUMINISTRADOSBindingSource, "ID_MEDICAMENTO", true));
            this.iD_MEDICAMENTOComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tABMEDICAMENTOSBindingSource, "ID_MEDICAMENTO", true));
            this.iD_MEDICAMENTOComboBox.DataSource = this.tABMEDICAMENTOSBindingSource;
            this.iD_MEDICAMENTOComboBox.DisplayMember = "NOMBRE";
            this.iD_MEDICAMENTOComboBox.FormattingEnabled = true;
            this.iD_MEDICAMENTOComboBox.Location = new System.Drawing.Point(305, 53);
            this.iD_MEDICAMENTOComboBox.Name = "iD_MEDICAMENTOComboBox";
            this.iD_MEDICAMENTOComboBox.Size = new System.Drawing.Size(200, 21);
            this.iD_MEDICAMENTOComboBox.TabIndex = 3;
            this.iD_MEDICAMENTOComboBox.ValueMember = "ID_MEDICAMENTO";
            // 
            // tABMEDICAMENTOSBindingSource
            // 
            this.tABMEDICAMENTOSBindingSource.DataMember = "TAB_MEDICAMENTOS";
            this.tABMEDICAMENTOSBindingSource.DataSource = this.dSveterinaria;
            // 
            // iD_FICHA_INGRESOComboBox
            // 
            this.iD_FICHA_INGRESOComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAB_MEDICAMENTOS_SUMINISTRADOSBindingSource, "ID_FICHA_INGRESO", true));
            this.iD_FICHA_INGRESOComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tABFICHADEINGRESOBindingSource, "ID_FICHA_INGRESO", true));
            this.iD_FICHA_INGRESOComboBox.DataSource = this.tABFICHADEINGRESOBindingSource;
            this.iD_FICHA_INGRESOComboBox.DisplayMember = "ID_FICHA_INGRESO";
            this.iD_FICHA_INGRESOComboBox.FormattingEnabled = true;
            this.iD_FICHA_INGRESOComboBox.Location = new System.Drawing.Point(305, 80);
            this.iD_FICHA_INGRESOComboBox.Name = "iD_FICHA_INGRESOComboBox";
            this.iD_FICHA_INGRESOComboBox.Size = new System.Drawing.Size(200, 21);
            this.iD_FICHA_INGRESOComboBox.TabIndex = 5;
            this.iD_FICHA_INGRESOComboBox.ValueMember = "ID_FICHA_INGRESO";
            // 
            // tABFICHADEINGRESOBindingSource
            // 
            this.tABFICHADEINGRESOBindingSource.DataMember = "TAB_FICHA_DE_INGRESO";
            this.tABFICHADEINGRESOBindingSource.DataSource = this.dSveterinaria;
            // 
            // fECHA_SUMINISTRODateTimePicker
            // 
            this.fECHA_SUMINISTRODateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tAB_MEDICAMENTOS_SUMINISTRADOSBindingSource, "FECHA_SUMINISTRO", true));
            this.fECHA_SUMINISTRODateTimePicker.Location = new System.Drawing.Point(305, 107);
            this.fECHA_SUMINISTRODateTimePicker.Name = "fECHA_SUMINISTRODateTimePicker";
            this.fECHA_SUMINISTRODateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fECHA_SUMINISTRODateTimePicker.TabIndex = 7;
            // 
            // tAB_MEDICAMENTOS_SUMINISTRADOSTableAdapter
            // 
            this.tAB_MEDICAMENTOS_SUMINISTRADOSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TAB_CANTONESTableAdapter = null;
            this.tableAdapterManager.TAB_CLIENTESTableAdapter = null;
            this.tableAdapterManager.TAB_CONTROL_MASCOTATableAdapter = null;
            this.tableAdapterManager.TAB_FICHA_DE_INGRESOTableAdapter = this.tAB_FICHA_DE_INGRESOTableAdapter;
            this.tableAdapterManager.TAB_MASCOTATableAdapter = null;
            this.tableAdapterManager.TAB_MEDICAMENTOS_SUMINISTRADOSTableAdapter = this.tAB_MEDICAMENTOS_SUMINISTRADOSTableAdapter;
            this.tableAdapterManager.TAB_MEDICAMENTOSTableAdapter = this.tAB_MEDICAMENTOSTableAdapter;
            this.tableAdapterManager.TAB_MEDICOSTableAdapter = null;
            this.tableAdapterManager.TAB_PERSONATableAdapter = null;
            this.tableAdapterManager.TAB_PROVINCIASTableAdapter = null;
            this.tableAdapterManager.TAB_RAZATableAdapter = null;
            this.tableAdapterManager.TAB_REGISTRO_DIARIOTableAdapter = null;
            this.tableAdapterManager.TAB_ROLESTableAdapter = null;
            this.tableAdapterManager.TAB_SALIDA_DE_MASCOTATableAdapter = null;
            this.tableAdapterManager.TAB_TIPO_DE_MASCOTATableAdapter = null;
            this.tableAdapterManager.TAB_USUARIOSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PROYECTO_VETERINARIA.DSveterinariaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tAB_FICHA_DE_INGRESOTableAdapter
            // 
            this.tAB_FICHA_DE_INGRESOTableAdapter.ClearBeforeFill = true;
            // 
            // tAB_MEDICAMENTOSTableAdapter
            // 
            this.tAB_MEDICAMENTOSTableAdapter.ClearBeforeFill = true;
            // 
            // tAB_MEDICAMENTOS_SUMINISTRADOSBindingNavigator
            // 
            this.tAB_MEDICAMENTOS_SUMINISTRADOSBindingNavigator.AddNewItem = this.btnAgregar;
            this.tAB_MEDICAMENTOS_SUMINISTRADOSBindingNavigator.BindingSource = this.tAB_MEDICAMENTOS_SUMINISTRADOSBindingSource;
            this.tAB_MEDICAMENTOS_SUMINISTRADOSBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tAB_MEDICAMENTOS_SUMINISTRADOSBindingNavigator.DeleteItem = this.btnEliminar;
            this.tAB_MEDICAMENTOS_SUMINISTRADOSBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tAB_MEDICAMENTOS_SUMINISTRADOSBindingNavigator.Location = new System.Drawing.Point(0, 146);
            this.tAB_MEDICAMENTOS_SUMINISTRADOSBindingNavigator.MoveFirstItem = null;
            this.tAB_MEDICAMENTOS_SUMINISTRADOSBindingNavigator.MoveLastItem = null;
            this.tAB_MEDICAMENTOS_SUMINISTRADOSBindingNavigator.MoveNextItem = null;
            this.tAB_MEDICAMENTOS_SUMINISTRADOSBindingNavigator.MovePreviousItem = null;
            this.tAB_MEDICAMENTOS_SUMINISTRADOSBindingNavigator.Name = "tAB_MEDICAMENTOS_SUMINISTRADOSBindingNavigator";
            this.tAB_MEDICAMENTOS_SUMINISTRADOSBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tAB_MEDICAMENTOS_SUMINISTRADOSBindingNavigator.Size = new System.Drawing.Size(591, 25);
            this.tAB_MEDICAMENTOS_SUMINISTRADOSBindingNavigator.TabIndex = 1;
            this.tAB_MEDICAMENTOS_SUMINISTRADOSBindingNavigator.Text = "bindingNavigator1";
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
            this.btnGuardar.Click += new System.EventHandler(this.tAB_MEDICAMENTOS_SUMINISTRADOSBindingNavigatorSaveItem_Click);
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
            // tAB_MEDICAMENTOS_SUMINISTRADOSDataGridView
            // 
            this.tAB_MEDICAMENTOS_SUMINISTRADOSDataGridView.AllowUserToAddRows = false;
            this.tAB_MEDICAMENTOS_SUMINISTRADOSDataGridView.AllowUserToDeleteRows = false;
            this.tAB_MEDICAMENTOS_SUMINISTRADOSDataGridView.AutoGenerateColumns = false;
            this.tAB_MEDICAMENTOS_SUMINISTRADOSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tAB_MEDICAMENTOS_SUMINISTRADOSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.tAB_MEDICAMENTOS_SUMINISTRADOSDataGridView.DataSource = this.tAB_MEDICAMENTOS_SUMINISTRADOSBindingSource;
            this.tAB_MEDICAMENTOS_SUMINISTRADOSDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tAB_MEDICAMENTOS_SUMINISTRADOSDataGridView.Location = new System.Drawing.Point(0, 171);
            this.tAB_MEDICAMENTOS_SUMINISTRADOSDataGridView.Name = "tAB_MEDICAMENTOS_SUMINISTRADOSDataGridView";
            this.tAB_MEDICAMENTOS_SUMINISTRADOSDataGridView.ReadOnly = true;
            this.tAB_MEDICAMENTOS_SUMINISTRADOSDataGridView.Size = new System.Drawing.Size(591, 293);
            this.tAB_MEDICAMENTOS_SUMINISTRADOSDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_MEDIACAMENTO_SUMINISTRADO";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ID_MEDICAMENTO";
            this.dataGridViewTextBoxColumn2.HeaderText = "MEDICAMENTO";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ID_FICHA_INGRESO";
            this.dataGridViewTextBoxColumn3.HeaderText = "FICHA INGRESO";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "FECHA_SUMINISTRO";
            this.dataGridViewTextBoxColumn4.HeaderText = "FECHA SUMINISTRO";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // visualStyler1
            // 
            this.visualStyler1.HostForm = this;
            this.visualStyler1.License = ((SkinSoft.VisualStyler.Licensing.VisualStylerLicense)(resources.GetObject("visualStyler1.License")));
            this.visualStyler1.LoadVisualStyle(null, "OSX (Panther).vssf");
            // 
            // FRM_MedicamentosSuministrados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 464);
            this.Controls.Add(this.tAB_MEDICAMENTOS_SUMINISTRADOSDataGridView);
            this.Controls.Add(this.tAB_MEDICAMENTOS_SUMINISTRADOSBindingNavigator);
            this.Controls.Add(this.panel1);
            this.Name = "FRM_MedicamentosSuministrados";
            this.Text = "Medicamentos Suministrados";
            this.Load += new System.EventHandler(this.FRM_MedicamentosSuministrados_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_MEDICAMENTOS_SUMINISTRADOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSveterinaria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tABMEDICAMENTOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tABFICHADEINGRESOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_MEDICAMENTOS_SUMINISTRADOSBindingNavigator)).EndInit();
            this.tAB_MEDICAMENTOS_SUMINISTRADOSBindingNavigator.ResumeLayout(false);
            this.tAB_MEDICAMENTOS_SUMINISTRADOSBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_MEDICAMENTOS_SUMINISTRADOSDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visualStyler1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DSveterinaria dSveterinaria;
        private System.Windows.Forms.BindingSource tAB_MEDICAMENTOS_SUMINISTRADOSBindingSource;
        private DSveterinariaTableAdapters.TAB_MEDICAMENTOS_SUMINISTRADOSTableAdapter tAB_MEDICAMENTOS_SUMINISTRADOSTableAdapter;
        private DSveterinariaTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tAB_MEDICAMENTOS_SUMINISTRADOSBindingNavigator;
        private System.Windows.Forms.ToolStripButton btnAgregar;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.Label iD_MEDIACAMENTO_SUMINISTRADOLabel1;
        private System.Windows.Forms.ComboBox iD_MEDICAMENTOComboBox;
        private System.Windows.Forms.ComboBox iD_FICHA_INGRESOComboBox;
        private System.Windows.Forms.DateTimePicker fECHA_SUMINISTRODateTimePicker;
        private DSveterinariaTableAdapters.TAB_MEDICAMENTOSTableAdapter tAB_MEDICAMENTOSTableAdapter;
        private System.Windows.Forms.DataGridView tAB_MEDICAMENTOS_SUMINISTRADOSDataGridView;
        private System.Windows.Forms.BindingSource tABMEDICAMENTOSBindingSource;
        private DSveterinariaTableAdapters.TAB_FICHA_DE_INGRESOTableAdapter tAB_FICHA_DE_INGRESOTableAdapter;
        private System.Windows.Forms.BindingSource tABFICHADEINGRESOBindingSource;
        private SkinSoft.VisualStyler.VisualStyler visualStyler1;
        private System.Windows.Forms.ToolStripButton btnActualizar;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}