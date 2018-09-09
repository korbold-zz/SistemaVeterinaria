namespace PROYECTO_VETERINARIA
{
    partial class FRM_ControlMascota
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
            System.Windows.Forms.Label iD_CONTROL_DE_MASCOTALabel;
            System.Windows.Forms.Label iD_FICHA_INGRESOLabel;
            System.Windows.Forms.Label tIPO_DE_CONTROLLabel;
            System.Windows.Forms.Label pARAMETROLabel;
            System.Windows.Forms.Label rESULTADOLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_ControlMascota));
            this.panel1 = new System.Windows.Forms.Panel();
            this.iD_CONTROL_DE_MASCOTALabel1 = new System.Windows.Forms.Label();
            this.tAB_CONTROL_MASCOTABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSveterinaria = new PROYECTO_VETERINARIA.DSveterinaria();
            this.iD_FICHA_INGRESOComboBox = new System.Windows.Forms.ComboBox();
            this.tABFICHADEINGRESOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tIPO_DE_CONTROLTextBox = new System.Windows.Forms.TextBox();
            this.pARAMETROTextBox = new System.Windows.Forms.TextBox();
            this.rESULTADOTextBox = new System.Windows.Forms.TextBox();
            this.tAB_CONTROL_MASCOTATableAdapter = new PROYECTO_VETERINARIA.DSveterinariaTableAdapters.TAB_CONTROL_MASCOTATableAdapter();
            this.tableAdapterManager = new PROYECTO_VETERINARIA.DSveterinariaTableAdapters.TableAdapterManager();
            this.tAB_FICHA_DE_INGRESOTableAdapter = new PROYECTO_VETERINARIA.DSveterinariaTableAdapters.TAB_FICHA_DE_INGRESOTableAdapter();
            this.tAB_CONTROL_MASCOTABindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tAB_CONTROL_MASCOTADataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visualStyler1 = new SkinSoft.VisualStyler.VisualStyler(this.components);
            this.visualStyler2 = new SkinSoft.VisualStyler.VisualStyler(this.components);
            iD_CONTROL_DE_MASCOTALabel = new System.Windows.Forms.Label();
            iD_FICHA_INGRESOLabel = new System.Windows.Forms.Label();
            tIPO_DE_CONTROLLabel = new System.Windows.Forms.Label();
            pARAMETROLabel = new System.Windows.Forms.Label();
            rESULTADOLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_CONTROL_MASCOTABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSveterinaria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tABFICHADEINGRESOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_CONTROL_MASCOTABindingNavigator)).BeginInit();
            this.tAB_CONTROL_MASCOTABindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_CONTROL_MASCOTADataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visualStyler1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visualStyler2)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_CONTROL_DE_MASCOTALabel
            // 
            iD_CONTROL_DE_MASCOTALabel.AutoSize = true;
            iD_CONTROL_DE_MASCOTALabel.Location = new System.Drawing.Point(64, 26);
            iD_CONTROL_DE_MASCOTALabel.Name = "iD_CONTROL_DE_MASCOTALabel";
            iD_CONTROL_DE_MASCOTALabel.Size = new System.Drawing.Size(149, 13);
            iD_CONTROL_DE_MASCOTALabel.TabIndex = 0;
            iD_CONTROL_DE_MASCOTALabel.Text = "ID CONTROL DE MASCOTA:";
            // 
            // iD_FICHA_INGRESOLabel
            // 
            iD_FICHA_INGRESOLabel.AutoSize = true;
            iD_FICHA_INGRESOLabel.Location = new System.Drawing.Point(64, 55);
            iD_FICHA_INGRESOLabel.Name = "iD_FICHA_INGRESOLabel";
            iD_FICHA_INGRESOLabel.Size = new System.Drawing.Size(107, 13);
            iD_FICHA_INGRESOLabel.TabIndex = 2;
            iD_FICHA_INGRESOLabel.Text = "ID FICHA INGRESO:";
            // 
            // tIPO_DE_CONTROLLabel
            // 
            tIPO_DE_CONTROLLabel.AutoSize = true;
            tIPO_DE_CONTROLLabel.Location = new System.Drawing.Point(64, 82);
            tIPO_DE_CONTROLLabel.Name = "tIPO_DE_CONTROLLabel";
            tIPO_DE_CONTROLLabel.Size = new System.Drawing.Size(108, 13);
            tIPO_DE_CONTROLLabel.TabIndex = 4;
            tIPO_DE_CONTROLLabel.Text = "TIPO DE CONTROL:";
            // 
            // pARAMETROLabel
            // 
            pARAMETROLabel.AutoSize = true;
            pARAMETROLabel.Location = new System.Drawing.Point(64, 108);
            pARAMETROLabel.Name = "pARAMETROLabel";
            pARAMETROLabel.Size = new System.Drawing.Size(78, 13);
            pARAMETROLabel.TabIndex = 6;
            pARAMETROLabel.Text = "PARAMETRO:";
            // 
            // rESULTADOLabel
            // 
            rESULTADOLabel.AutoSize = true;
            rESULTADOLabel.Location = new System.Drawing.Point(64, 134);
            rESULTADOLabel.Name = "rESULTADOLabel";
            rESULTADOLabel.Size = new System.Drawing.Size(76, 13);
            rESULTADOLabel.TabIndex = 8;
            rESULTADOLabel.Text = "RESULTADO:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(iD_CONTROL_DE_MASCOTALabel);
            this.panel1.Controls.Add(this.iD_CONTROL_DE_MASCOTALabel1);
            this.panel1.Controls.Add(iD_FICHA_INGRESOLabel);
            this.panel1.Controls.Add(this.iD_FICHA_INGRESOComboBox);
            this.panel1.Controls.Add(tIPO_DE_CONTROLLabel);
            this.panel1.Controls.Add(this.tIPO_DE_CONTROLTextBox);
            this.panel1.Controls.Add(pARAMETROLabel);
            this.panel1.Controls.Add(this.pARAMETROTextBox);
            this.panel1.Controls.Add(rESULTADOLabel);
            this.panel1.Controls.Add(this.rESULTADOTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(566, 248);
            this.panel1.TabIndex = 0;
            // 
            // iD_CONTROL_DE_MASCOTALabel1
            // 
            this.iD_CONTROL_DE_MASCOTALabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAB_CONTROL_MASCOTABindingSource, "ID_CONTROL_DE_MASCOTA", true));
            this.iD_CONTROL_DE_MASCOTALabel1.Location = new System.Drawing.Point(219, 26);
            this.iD_CONTROL_DE_MASCOTALabel1.Name = "iD_CONTROL_DE_MASCOTALabel1";
            this.iD_CONTROL_DE_MASCOTALabel1.Size = new System.Drawing.Size(121, 23);
            this.iD_CONTROL_DE_MASCOTALabel1.TabIndex = 1;
            this.iD_CONTROL_DE_MASCOTALabel1.Text = "label1";
            // 
            // tAB_CONTROL_MASCOTABindingSource
            // 
            this.tAB_CONTROL_MASCOTABindingSource.DataMember = "TAB_CONTROL_MASCOTA";
            this.tAB_CONTROL_MASCOTABindingSource.DataSource = this.dSveterinaria;
            // 
            // dSveterinaria
            // 
            this.dSveterinaria.DataSetName = "DSveterinaria";
            this.dSveterinaria.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iD_FICHA_INGRESOComboBox
            // 
            this.iD_FICHA_INGRESOComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAB_CONTROL_MASCOTABindingSource, "ID_FICHA_INGRESO", true));
            this.iD_FICHA_INGRESOComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tABFICHADEINGRESOBindingSource, "ID_FICHA_INGRESO", true));
            this.iD_FICHA_INGRESOComboBox.DataSource = this.tABFICHADEINGRESOBindingSource;
            this.iD_FICHA_INGRESOComboBox.DisplayMember = "ID_FICHA_INGRESO";
            this.iD_FICHA_INGRESOComboBox.FormattingEnabled = true;
            this.iD_FICHA_INGRESOComboBox.Location = new System.Drawing.Point(219, 52);
            this.iD_FICHA_INGRESOComboBox.Name = "iD_FICHA_INGRESOComboBox";
            this.iD_FICHA_INGRESOComboBox.Size = new System.Drawing.Size(121, 21);
            this.iD_FICHA_INGRESOComboBox.TabIndex = 3;
            this.iD_FICHA_INGRESOComboBox.ValueMember = "ID_FICHA_INGRESO";
            // 
            // tABFICHADEINGRESOBindingSource
            // 
            this.tABFICHADEINGRESOBindingSource.DataMember = "TAB_FICHA_DE_INGRESO";
            this.tABFICHADEINGRESOBindingSource.DataSource = this.dSveterinaria;
            // 
            // tIPO_DE_CONTROLTextBox
            // 
            this.tIPO_DE_CONTROLTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAB_CONTROL_MASCOTABindingSource, "TIPO_DE_CONTROL", true));
            this.tIPO_DE_CONTROLTextBox.Location = new System.Drawing.Point(219, 79);
            this.tIPO_DE_CONTROLTextBox.Name = "tIPO_DE_CONTROLTextBox";
            this.tIPO_DE_CONTROLTextBox.Size = new System.Drawing.Size(177, 20);
            this.tIPO_DE_CONTROLTextBox.TabIndex = 5;
            this.tIPO_DE_CONTROLTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tIPO_DE_CONTROLTextBox_KeyPress);
            // 
            // pARAMETROTextBox
            // 
            this.pARAMETROTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAB_CONTROL_MASCOTABindingSource, "PARAMETRO", true));
            this.pARAMETROTextBox.Location = new System.Drawing.Point(219, 105);
            this.pARAMETROTextBox.Name = "pARAMETROTextBox";
            this.pARAMETROTextBox.Size = new System.Drawing.Size(177, 20);
            this.pARAMETROTextBox.TabIndex = 7;
            // 
            // rESULTADOTextBox
            // 
            this.rESULTADOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAB_CONTROL_MASCOTABindingSource, "RESULTADO", true));
            this.rESULTADOTextBox.Location = new System.Drawing.Point(219, 131);
            this.rESULTADOTextBox.Multiline = true;
            this.rESULTADOTextBox.Name = "rESULTADOTextBox";
            this.rESULTADOTextBox.Size = new System.Drawing.Size(300, 98);
            this.rESULTADOTextBox.TabIndex = 9;
            // 
            // tAB_CONTROL_MASCOTATableAdapter
            // 
            this.tAB_CONTROL_MASCOTATableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TAB_CANTONESTableAdapter = null;
            this.tableAdapterManager.TAB_CLIENTESTableAdapter = null;
            this.tableAdapterManager.TAB_CONTROL_MASCOTATableAdapter = this.tAB_CONTROL_MASCOTATableAdapter;
            this.tableAdapterManager.TAB_FICHA_DE_INGRESOTableAdapter = this.tAB_FICHA_DE_INGRESOTableAdapter;
            this.tableAdapterManager.TAB_MASCOTATableAdapter = null;
            this.tableAdapterManager.TAB_MEDICAMENTOS_SUMINISTRADOSTableAdapter = null;
            this.tableAdapterManager.TAB_MEDICAMENTOSTableAdapter = null;
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
            // tAB_CONTROL_MASCOTABindingNavigator
            // 
            this.tAB_CONTROL_MASCOTABindingNavigator.AddNewItem = this.btnAgregar;
            this.tAB_CONTROL_MASCOTABindingNavigator.BindingSource = this.tAB_CONTROL_MASCOTABindingSource;
            this.tAB_CONTROL_MASCOTABindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tAB_CONTROL_MASCOTABindingNavigator.DeleteItem = this.btnEliminar;
            this.tAB_CONTROL_MASCOTABindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tAB_CONTROL_MASCOTABindingNavigator.Location = new System.Drawing.Point(0, 248);
            this.tAB_CONTROL_MASCOTABindingNavigator.MoveFirstItem = null;
            this.tAB_CONTROL_MASCOTABindingNavigator.MoveLastItem = null;
            this.tAB_CONTROL_MASCOTABindingNavigator.MoveNextItem = null;
            this.tAB_CONTROL_MASCOTABindingNavigator.MovePreviousItem = null;
            this.tAB_CONTROL_MASCOTABindingNavigator.Name = "tAB_CONTROL_MASCOTABindingNavigator";
            this.tAB_CONTROL_MASCOTABindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tAB_CONTROL_MASCOTABindingNavigator.Size = new System.Drawing.Size(566, 25);
            this.tAB_CONTROL_MASCOTABindingNavigator.TabIndex = 1;
            this.tAB_CONTROL_MASCOTABindingNavigator.Text = "bindingNavigator1";
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
            this.btnGuardar.Click += new System.EventHandler(this.tAB_CONTROL_MASCOTABindingNavigatorSaveItem_Click);
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
            // tAB_CONTROL_MASCOTADataGridView
            // 
            this.tAB_CONTROL_MASCOTADataGridView.AllowUserToAddRows = false;
            this.tAB_CONTROL_MASCOTADataGridView.AllowUserToDeleteRows = false;
            this.tAB_CONTROL_MASCOTADataGridView.AutoGenerateColumns = false;
            this.tAB_CONTROL_MASCOTADataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tAB_CONTROL_MASCOTADataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.tAB_CONTROL_MASCOTADataGridView.DataSource = this.tAB_CONTROL_MASCOTABindingSource;
            this.tAB_CONTROL_MASCOTADataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.tAB_CONTROL_MASCOTADataGridView.Location = new System.Drawing.Point(0, 273);
            this.tAB_CONTROL_MASCOTADataGridView.Name = "tAB_CONTROL_MASCOTADataGridView";
            this.tAB_CONTROL_MASCOTADataGridView.ReadOnly = true;
            this.tAB_CONTROL_MASCOTADataGridView.Size = new System.Drawing.Size(566, 220);
            this.tAB_CONTROL_MASCOTADataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_CONTROL_DE_MASCOTA";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ID_FICHA_INGRESO";
            this.dataGridViewTextBoxColumn2.HeaderText = "ID FICHA DE INGRESO";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TIPO_DE_CONTROL";
            this.dataGridViewTextBoxColumn3.HeaderText = "TIPO DE CONTROL";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PARAMETRO";
            this.dataGridViewTextBoxColumn4.HeaderText = "PARÁMETRO";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "RESULTADO";
            this.dataGridViewTextBoxColumn5.HeaderText = "RESULTADO";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // visualStyler1
            // 
            this.visualStyler1.HostForm = this;
            this.visualStyler1.License = ((SkinSoft.VisualStyler.Licensing.VisualStylerLicense)(resources.GetObject("visualStyler1.License")));
            this.visualStyler1.LoadVisualStyle(null, "OSX (Panther).vssf");
            // 
            // visualStyler2
            // 
            this.visualStyler2.HostForm = this;
            this.visualStyler2.License = ((SkinSoft.VisualStyler.Licensing.VisualStylerLicense)(resources.GetObject("visualStyler2.License")));
            this.visualStyler2.LoadVisualStyle(null, "OSX (Panther).vssf");
            // 
            // FRM_ControlMascota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 508);
            this.Controls.Add(this.tAB_CONTROL_MASCOTADataGridView);
            this.Controls.Add(this.tAB_CONTROL_MASCOTABindingNavigator);
            this.Controls.Add(this.panel1);
            this.Name = "FRM_ControlMascota";
            this.Text = "Controles de Mascotas";
            this.Load += new System.EventHandler(this.FRM_ControlMascota_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_CONTROL_MASCOTABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSveterinaria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tABFICHADEINGRESOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_CONTROL_MASCOTABindingNavigator)).EndInit();
            this.tAB_CONTROL_MASCOTABindingNavigator.ResumeLayout(false);
            this.tAB_CONTROL_MASCOTABindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_CONTROL_MASCOTADataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visualStyler1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visualStyler2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DSveterinaria dSveterinaria;
        private System.Windows.Forms.BindingSource tAB_CONTROL_MASCOTABindingSource;
        private DSveterinariaTableAdapters.TAB_CONTROL_MASCOTATableAdapter tAB_CONTROL_MASCOTATableAdapter;
        private DSveterinariaTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tAB_CONTROL_MASCOTABindingNavigator;
        private System.Windows.Forms.ToolStripButton btnAgregar;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.Label iD_CONTROL_DE_MASCOTALabel1;
        private System.Windows.Forms.ComboBox iD_FICHA_INGRESOComboBox;
        private System.Windows.Forms.TextBox tIPO_DE_CONTROLTextBox;
        private System.Windows.Forms.TextBox pARAMETROTextBox;
        private System.Windows.Forms.TextBox rESULTADOTextBox;
        private DSveterinariaTableAdapters.TAB_FICHA_DE_INGRESOTableAdapter tAB_FICHA_DE_INGRESOTableAdapter;
        private System.Windows.Forms.BindingSource tABFICHADEINGRESOBindingSource;
        private System.Windows.Forms.DataGridView tAB_CONTROL_MASCOTADataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private SkinSoft.VisualStyler.VisualStyler visualStyler1;
        private SkinSoft.VisualStyler.VisualStyler visualStyler2;
        private System.Windows.Forms.ToolStripButton btnActualizar;
        private System.Windows.Forms.ToolStripButton btnCancelar;
    }
}