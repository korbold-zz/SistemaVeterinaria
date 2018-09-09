namespace PROYECTO_VETERINARIA
{
    partial class FRM_Persona
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
                components.Dispose ( );
            }
            base.Dispose ( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ( )
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label iD_PERSONALabel;
            System.Windows.Forms.Label iD_PROVINCIALabel;
            System.Windows.Forms.Label iD_CANTONLabel;
            System.Windows.Forms.Label cEDULALabel;
            System.Windows.Forms.Label pRIMER_NOMBRELabel;
            System.Windows.Forms.Label sEGUNDO_NOMBRELabel;
            System.Windows.Forms.Label pRIMER_APELLIDOLabel;
            System.Windows.Forms.Label sEGUNDO_APELLIDOLabel;
            System.Windows.Forms.Label dIRECCION_CALLELabel;
            System.Windows.Forms.Label dIRECCION_NUMEROLabel;
            System.Windows.Forms.Label nUMERO_TELEFONOLabel;
            System.Windows.Forms.Label nUMERO_CELULARLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Persona));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tAB_PERSONABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSveterinaria = new PROYECTO_VETERINARIA.DSveterinaria();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.iD_PERSONALabel1 = new System.Windows.Forms.Label();
            this.iD_PROVINCIAComboBox = new System.Windows.Forms.ComboBox();
            this.tAB_PROVINCIASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iD_CANTONComboBox = new System.Windows.Forms.ComboBox();
            this.tAB_CANTONESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cEDULATextBox = new System.Windows.Forms.TextBox();
            this.pRIMER_NOMBRETextBox = new System.Windows.Forms.TextBox();
            this.sEGUNDO_NOMBRETextBox = new System.Windows.Forms.TextBox();
            this.pRIMER_APELLIDOTextBox = new System.Windows.Forms.TextBox();
            this.sEGUNDO_APELLIDOTextBox = new System.Windows.Forms.TextBox();
            this.dIRECCION_CALLETextBox = new System.Windows.Forms.TextBox();
            this.dIRECCION_NUMEROTextBox = new System.Windows.Forms.TextBox();
            this.nUMERO_TELEFONOTextBox = new System.Windows.Forms.TextBox();
            this.nUMERO_CELULARTextBox = new System.Windows.Forms.TextBox();
            this.tAB_PERSONATableAdapter = new PROYECTO_VETERINARIA.DSveterinariaTableAdapters.TAB_PERSONATableAdapter();
            this.tableAdapterManager = new PROYECTO_VETERINARIA.DSveterinariaTableAdapters.TableAdapterManager();
            this.tAB_PERSONABindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.btnAgregar = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnActualizar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.tAB_PERSONADataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tABCANTONESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tAB_PROVINCIASTableAdapter = new PROYECTO_VETERINARIA.DSveterinariaTableAdapters.TAB_PROVINCIASTableAdapter();
            this.tAB_CANTONESTableAdapter = new PROYECTO_VETERINARIA.DSveterinariaTableAdapters.TAB_CANTONESTableAdapter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            iD_PERSONALabel = new System.Windows.Forms.Label();
            iD_PROVINCIALabel = new System.Windows.Forms.Label();
            iD_CANTONLabel = new System.Windows.Forms.Label();
            cEDULALabel = new System.Windows.Forms.Label();
            pRIMER_NOMBRELabel = new System.Windows.Forms.Label();
            sEGUNDO_NOMBRELabel = new System.Windows.Forms.Label();
            pRIMER_APELLIDOLabel = new System.Windows.Forms.Label();
            sEGUNDO_APELLIDOLabel = new System.Windows.Forms.Label();
            dIRECCION_CALLELabel = new System.Windows.Forms.Label();
            dIRECCION_NUMEROLabel = new System.Windows.Forms.Label();
            nUMERO_TELEFONOLabel = new System.Windows.Forms.Label();
            nUMERO_CELULARLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_PERSONABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSveterinaria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_PROVINCIASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_CANTONESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_PERSONABindingNavigator)).BeginInit();
            this.tAB_PERSONABindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_PERSONADataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tABCANTONESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_PERSONALabel
            // 
            iD_PERSONALabel.AutoSize = true;
            iD_PERSONALabel.Location = new System.Drawing.Point(136, 27);
            iD_PERSONALabel.Name = "iD_PERSONALabel";
            iD_PERSONALabel.Size = new System.Drawing.Size(76, 13);
            iD_PERSONALabel.TabIndex = 0;
            iD_PERSONALabel.Text = "ID PERSONA:";
            // 
            // iD_PROVINCIALabel
            // 
            iD_PROVINCIALabel.AutoSize = true;
            iD_PROVINCIALabel.Location = new System.Drawing.Point(136, 210);
            iD_PROVINCIALabel.Name = "iD_PROVINCIALabel";
            iD_PROVINCIALabel.Size = new System.Drawing.Size(68, 13);
            iD_PROVINCIALabel.TabIndex = 2;
            iD_PROVINCIALabel.Text = "PROVINCIA:";
            // 
            // iD_CANTONLabel
            // 
            iD_CANTONLabel.AutoSize = true;
            iD_CANTONLabel.Location = new System.Drawing.Point(413, 213);
            iD_CANTONLabel.Name = "iD_CANTONLabel";
            iD_CANTONLabel.Size = new System.Drawing.Size(55, 13);
            iD_CANTONLabel.TabIndex = 4;
            iD_CANTONLabel.Text = "CANTON:";
            // 
            // cEDULALabel
            // 
            cEDULALabel.AutoSize = true;
            cEDULALabel.Location = new System.Drawing.Point(136, 56);
            cEDULALabel.Name = "cEDULALabel";
            cEDULALabel.Size = new System.Drawing.Size(53, 13);
            cEDULALabel.TabIndex = 6;
            cEDULALabel.Text = "CEDULA:";
            // 
            // pRIMER_NOMBRELabel
            // 
            pRIMER_NOMBRELabel.AutoSize = true;
            pRIMER_NOMBRELabel.Location = new System.Drawing.Point(136, 80);
            pRIMER_NOMBRELabel.Name = "pRIMER_NOMBRELabel";
            pRIMER_NOMBRELabel.Size = new System.Drawing.Size(102, 13);
            pRIMER_NOMBRELabel.TabIndex = 8;
            pRIMER_NOMBRELabel.Text = "PRIMER NOMBRE:";
            // 
            // sEGUNDO_NOMBRELabel
            // 
            sEGUNDO_NOMBRELabel.AutoSize = true;
            sEGUNDO_NOMBRELabel.Location = new System.Drawing.Point(413, 80);
            sEGUNDO_NOMBRELabel.Name = "sEGUNDO_NOMBRELabel";
            sEGUNDO_NOMBRELabel.Size = new System.Drawing.Size(114, 13);
            sEGUNDO_NOMBRELabel.TabIndex = 10;
            sEGUNDO_NOMBRELabel.Text = "SEGUNDO NOMBRE:";
            // 
            // pRIMER_APELLIDOLabel
            // 
            pRIMER_APELLIDOLabel.AutoSize = true;
            pRIMER_APELLIDOLabel.Location = new System.Drawing.Point(136, 106);
            pRIMER_APELLIDOLabel.Name = "pRIMER_APELLIDOLabel";
            pRIMER_APELLIDOLabel.Size = new System.Drawing.Size(107, 13);
            pRIMER_APELLIDOLabel.TabIndex = 12;
            pRIMER_APELLIDOLabel.Text = "PRIMER APELLIDO:";
            // 
            // sEGUNDO_APELLIDOLabel
            // 
            sEGUNDO_APELLIDOLabel.AutoSize = true;
            sEGUNDO_APELLIDOLabel.Location = new System.Drawing.Point(413, 106);
            sEGUNDO_APELLIDOLabel.Name = "sEGUNDO_APELLIDOLabel";
            sEGUNDO_APELLIDOLabel.Size = new System.Drawing.Size(119, 13);
            sEGUNDO_APELLIDOLabel.TabIndex = 14;
            sEGUNDO_APELLIDOLabel.Text = "SEGUNDO APELLIDO:";
            // 
            // dIRECCION_CALLELabel
            // 
            dIRECCION_CALLELabel.AutoSize = true;
            dIRECCION_CALLELabel.Location = new System.Drawing.Point(136, 132);
            dIRECCION_CALLELabel.Name = "dIRECCION_CALLELabel";
            dIRECCION_CALLELabel.Size = new System.Drawing.Size(105, 13);
            dIRECCION_CALLELabel.TabIndex = 16;
            dIRECCION_CALLELabel.Text = "DIRECCION CALLE:";
            // 
            // dIRECCION_NUMEROLabel
            // 
            dIRECCION_NUMEROLabel.AutoSize = true;
            dIRECCION_NUMEROLabel.Location = new System.Drawing.Point(136, 158);
            dIRECCION_NUMEROLabel.Name = "dIRECCION_NUMEROLabel";
            dIRECCION_NUMEROLabel.Size = new System.Drawing.Size(120, 13);
            dIRECCION_NUMEROLabel.TabIndex = 18;
            dIRECCION_NUMEROLabel.Text = "DIRECCION NUMERO:";
            // 
            // nUMERO_TELEFONOLabel
            // 
            nUMERO_TELEFONOLabel.AutoSize = true;
            nUMERO_TELEFONOLabel.Location = new System.Drawing.Point(136, 184);
            nUMERO_TELEFONOLabel.Name = "nUMERO_TELEFONOLabel";
            nUMERO_TELEFONOLabel.Size = new System.Drawing.Size(118, 13);
            nUMERO_TELEFONOLabel.TabIndex = 20;
            nUMERO_TELEFONOLabel.Text = "NUMERO TELEFONO:";
            // 
            // nUMERO_CELULARLabel
            // 
            nUMERO_CELULARLabel.AutoSize = true;
            nUMERO_CELULARLabel.Location = new System.Drawing.Point(413, 187);
            nUMERO_CELULARLabel.Name = "nUMERO_CELULARLabel";
            nUMERO_CELULARLabel.Size = new System.Drawing.Size(110, 13);
            nUMERO_CELULARLabel.TabIndex = 22;
            nUMERO_CELULARLabel.Text = "NUMERO CELULAR:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(iD_PERSONALabel);
            this.panel1.Controls.Add(this.iD_PERSONALabel1);
            this.panel1.Controls.Add(iD_PROVINCIALabel);
            this.panel1.Controls.Add(this.iD_PROVINCIAComboBox);
            this.panel1.Controls.Add(iD_CANTONLabel);
            this.panel1.Controls.Add(this.iD_CANTONComboBox);
            this.panel1.Controls.Add(cEDULALabel);
            this.panel1.Controls.Add(this.cEDULATextBox);
            this.panel1.Controls.Add(pRIMER_NOMBRELabel);
            this.panel1.Controls.Add(this.pRIMER_NOMBRETextBox);
            this.panel1.Controls.Add(sEGUNDO_NOMBRELabel);
            this.panel1.Controls.Add(this.sEGUNDO_NOMBRETextBox);
            this.panel1.Controls.Add(pRIMER_APELLIDOLabel);
            this.panel1.Controls.Add(this.pRIMER_APELLIDOTextBox);
            this.panel1.Controls.Add(sEGUNDO_APELLIDOLabel);
            this.panel1.Controls.Add(this.sEGUNDO_APELLIDOTextBox);
            this.panel1.Controls.Add(dIRECCION_CALLELabel);
            this.panel1.Controls.Add(this.dIRECCION_CALLETextBox);
            this.panel1.Controls.Add(dIRECCION_NUMEROLabel);
            this.panel1.Controls.Add(this.dIRECCION_NUMEROTextBox);
            this.panel1.Controls.Add(nUMERO_TELEFONOLabel);
            this.panel1.Controls.Add(this.nUMERO_TELEFONOTextBox);
            this.panel1.Controls.Add(nUMERO_CELULARLabel);
            this.panel1.Controls.Add(this.nUMERO_CELULARTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1205, 252);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBuscar);
            this.groupBox1.Location = new System.Drawing.Point(803, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 91);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar";
            // 
            // tAB_PERSONABindingSource
            // 
            this.tAB_PERSONABindingSource.DataMember = "TAB_PERSONA";
            this.tAB_PERSONABindingSource.DataSource = this.dSveterinaria;
            // 
            // dSveterinaria
            // 
            this.dSveterinaria.DataSetName = "DSveterinaria";
            this.dSveterinaria.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtBuscar
            // 
            this.txtBuscar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtBuscar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.txtBuscar.Location = new System.Drawing.Point(40, 45);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(209, 20);
            this.txtBuscar.TabIndex = 24;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // iD_PERSONALabel1
            // 
            this.iD_PERSONALabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAB_PERSONABindingSource, "ID_PERSONA", true));
            this.iD_PERSONALabel1.Location = new System.Drawing.Point(262, 27);
            this.iD_PERSONALabel1.Name = "iD_PERSONALabel1";
            this.iD_PERSONALabel1.Size = new System.Drawing.Size(121, 23);
            this.iD_PERSONALabel1.TabIndex = 1;
            this.iD_PERSONALabel1.Text = "label1";
            // 
            // iD_PROVINCIAComboBox
            // 
            this.iD_PROVINCIAComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tAB_PERSONABindingSource, "ID_PROVINCIA", true));
            this.iD_PROVINCIAComboBox.DataSource = this.tAB_PROVINCIASBindingSource;
            this.iD_PROVINCIAComboBox.DisplayMember = "PROVINCIA";
            this.iD_PROVINCIAComboBox.FormattingEnabled = true;
            this.iD_PROVINCIAComboBox.Location = new System.Drawing.Point(262, 207);
            this.iD_PROVINCIAComboBox.Name = "iD_PROVINCIAComboBox";
            this.iD_PROVINCIAComboBox.Size = new System.Drawing.Size(121, 21);
            this.iD_PROVINCIAComboBox.TabIndex = 3;
            this.iD_PROVINCIAComboBox.ValueMember = "ID_PROVINCIA";
            // 
            // tAB_PROVINCIASBindingSource
            // 
            this.tAB_PROVINCIASBindingSource.DataMember = "TAB_PROVINCIAS";
            this.tAB_PROVINCIASBindingSource.DataSource = this.dSveterinaria;
            // 
            // iD_CANTONComboBox
            // 
            this.iD_CANTONComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tAB_PERSONABindingSource, "ID_CANTON", true));
            this.iD_CANTONComboBox.DataSource = this.tAB_CANTONESBindingSource;
            this.iD_CANTONComboBox.DisplayMember = "CANTON";
            this.iD_CANTONComboBox.FormattingEnabled = true;
            this.iD_CANTONComboBox.Location = new System.Drawing.Point(539, 210);
            this.iD_CANTONComboBox.Name = "iD_CANTONComboBox";
            this.iD_CANTONComboBox.Size = new System.Drawing.Size(121, 21);
            this.iD_CANTONComboBox.TabIndex = 5;
            this.iD_CANTONComboBox.ValueMember = "ID_CANTON";
            // 
            // tAB_CANTONESBindingSource
            // 
            this.tAB_CANTONESBindingSource.DataMember = "FK_TAB_CANT_REFERENCE_TAB_PROV";
            this.tAB_CANTONESBindingSource.DataSource = this.tAB_PROVINCIASBindingSource;
            // 
            // cEDULATextBox
            // 
            this.cEDULATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAB_PERSONABindingSource, "CEDULA", true));
            this.cEDULATextBox.Location = new System.Drawing.Point(262, 53);
            this.cEDULATextBox.Name = "cEDULATextBox";
            this.cEDULATextBox.Size = new System.Drawing.Size(121, 20);
            this.cEDULATextBox.TabIndex = 7;
            // 
            // pRIMER_NOMBRETextBox
            // 
            this.pRIMER_NOMBRETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAB_PERSONABindingSource, "PRIMER_NOMBRE", true));
            this.pRIMER_NOMBRETextBox.Location = new System.Drawing.Point(262, 77);
            this.pRIMER_NOMBRETextBox.Name = "pRIMER_NOMBRETextBox";
            this.pRIMER_NOMBRETextBox.Size = new System.Drawing.Size(121, 20);
            this.pRIMER_NOMBRETextBox.TabIndex = 9;
            // 
            // sEGUNDO_NOMBRETextBox
            // 
            this.sEGUNDO_NOMBRETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAB_PERSONABindingSource, "SEGUNDO_NOMBRE", true));
            this.sEGUNDO_NOMBRETextBox.Location = new System.Drawing.Point(539, 77);
            this.sEGUNDO_NOMBRETextBox.Name = "sEGUNDO_NOMBRETextBox";
            this.sEGUNDO_NOMBRETextBox.Size = new System.Drawing.Size(121, 20);
            this.sEGUNDO_NOMBRETextBox.TabIndex = 11;
            // 
            // pRIMER_APELLIDOTextBox
            // 
            this.pRIMER_APELLIDOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAB_PERSONABindingSource, "PRIMER_APELLIDO", true));
            this.pRIMER_APELLIDOTextBox.Location = new System.Drawing.Point(262, 103);
            this.pRIMER_APELLIDOTextBox.Name = "pRIMER_APELLIDOTextBox";
            this.pRIMER_APELLIDOTextBox.Size = new System.Drawing.Size(121, 20);
            this.pRIMER_APELLIDOTextBox.TabIndex = 13;
            // 
            // sEGUNDO_APELLIDOTextBox
            // 
            this.sEGUNDO_APELLIDOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAB_PERSONABindingSource, "SEGUNDO_APELLIDO", true));
            this.sEGUNDO_APELLIDOTextBox.Location = new System.Drawing.Point(539, 103);
            this.sEGUNDO_APELLIDOTextBox.Name = "sEGUNDO_APELLIDOTextBox";
            this.sEGUNDO_APELLIDOTextBox.Size = new System.Drawing.Size(121, 20);
            this.sEGUNDO_APELLIDOTextBox.TabIndex = 15;
            // 
            // dIRECCION_CALLETextBox
            // 
            this.dIRECCION_CALLETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAB_PERSONABindingSource, "DIRECCION_CALLE", true));
            this.dIRECCION_CALLETextBox.Location = new System.Drawing.Point(262, 129);
            this.dIRECCION_CALLETextBox.Name = "dIRECCION_CALLETextBox";
            this.dIRECCION_CALLETextBox.Size = new System.Drawing.Size(398, 20);
            this.dIRECCION_CALLETextBox.TabIndex = 17;
            // 
            // dIRECCION_NUMEROTextBox
            // 
            this.dIRECCION_NUMEROTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAB_PERSONABindingSource, "DIRECCION_NUMERO", true));
            this.dIRECCION_NUMEROTextBox.Location = new System.Drawing.Point(262, 155);
            this.dIRECCION_NUMEROTextBox.Name = "dIRECCION_NUMEROTextBox";
            this.dIRECCION_NUMEROTextBox.Size = new System.Drawing.Size(121, 20);
            this.dIRECCION_NUMEROTextBox.TabIndex = 19;
            // 
            // nUMERO_TELEFONOTextBox
            // 
            this.nUMERO_TELEFONOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAB_PERSONABindingSource, "NUMERO_TELEFONO", true));
            this.nUMERO_TELEFONOTextBox.Location = new System.Drawing.Point(262, 181);
            this.nUMERO_TELEFONOTextBox.Name = "nUMERO_TELEFONOTextBox";
            this.nUMERO_TELEFONOTextBox.Size = new System.Drawing.Size(121, 20);
            this.nUMERO_TELEFONOTextBox.TabIndex = 21;
            // 
            // nUMERO_CELULARTextBox
            // 
            this.nUMERO_CELULARTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAB_PERSONABindingSource, "NUMERO_CELULAR", true));
            this.nUMERO_CELULARTextBox.Location = new System.Drawing.Point(539, 184);
            this.nUMERO_CELULARTextBox.Name = "nUMERO_CELULARTextBox";
            this.nUMERO_CELULARTextBox.Size = new System.Drawing.Size(121, 20);
            this.nUMERO_CELULARTextBox.TabIndex = 23;
            // 
            // tAB_PERSONATableAdapter
            // 
            this.tAB_PERSONATableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.TAB_ROLESTableAdapter = null;
            this.tableAdapterManager.TAB_SALIDA_DE_MASCOTATableAdapter = null;
            this.tableAdapterManager.TAB_TIPO_DE_MASCOTATableAdapter = null;
            this.tableAdapterManager.TAB_USUARIOSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PROYECTO_VETERINARIA.DSveterinariaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tAB_PERSONABindingNavigator
            // 
            this.tAB_PERSONABindingNavigator.AddNewItem = this.btnAgregar;
            this.tAB_PERSONABindingNavigator.BindingSource = this.tAB_PERSONABindingSource;
            this.tAB_PERSONABindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tAB_PERSONABindingNavigator.DeleteItem = null;
            this.tAB_PERSONABindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tAB_PERSONABindingNavigator.Location = new System.Drawing.Point(0, 252);
            this.tAB_PERSONABindingNavigator.MoveFirstItem = null;
            this.tAB_PERSONABindingNavigator.MoveLastItem = null;
            this.tAB_PERSONABindingNavigator.MoveNextItem = null;
            this.tAB_PERSONABindingNavigator.MovePreviousItem = null;
            this.tAB_PERSONABindingNavigator.Name = "tAB_PERSONABindingNavigator";
            this.tAB_PERSONABindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tAB_PERSONABindingNavigator.Size = new System.Drawing.Size(1205, 25);
            this.tAB_PERSONABindingNavigator.TabIndex = 1;
            this.tAB_PERSONABindingNavigator.Text = "bindingNavigator1";
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
            // btnEliminar
            // 
            this.btnEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(23, 22);
            this.btnEliminar.Text = "toolStripButton1";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // btnGuardar
            // 
            this.btnGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(23, 22);
            this.btnGuardar.Text = "Guardar datos";
            this.btnGuardar.Click += new System.EventHandler(this.tAB_PERSONABindingNavigatorSaveItem_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(23, 22);
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(23, 22);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // tAB_PERSONADataGridView
            // 
            this.tAB_PERSONADataGridView.AllowUserToAddRows = false;
            this.tAB_PERSONADataGridView.AllowUserToDeleteRows = false;
            this.tAB_PERSONADataGridView.AutoGenerateColumns = false;
            this.tAB_PERSONADataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tAB_PERSONADataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.tAB_PERSONADataGridView.DataSource = this.tAB_PERSONABindingSource;
            this.tAB_PERSONADataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tAB_PERSONADataGridView.Location = new System.Drawing.Point(0, 277);
            this.tAB_PERSONADataGridView.Name = "tAB_PERSONADataGridView";
            this.tAB_PERSONADataGridView.ReadOnly = true;
            this.tAB_PERSONADataGridView.Size = new System.Drawing.Size(1205, 361);
            this.tAB_PERSONADataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_PERSONA";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CEDULA";
            this.dataGridViewTextBoxColumn4.HeaderText = "CEDULA";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PRIMER_NOMBRE";
            this.dataGridViewTextBoxColumn5.HeaderText = "PRIMER NOMBRE";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "SEGUNDO_NOMBRE";
            this.dataGridViewTextBoxColumn6.HeaderText = "SEGUNDO NOMBRE";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "PRIMER_APELLIDO";
            this.dataGridViewTextBoxColumn7.HeaderText = " PRIMER APELLIDO";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "SEGUNDO_APELLIDO";
            this.dataGridViewTextBoxColumn8.HeaderText = "SEGUNDO APELLIDO";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "DIRECCION_CALLE";
            this.dataGridViewTextBoxColumn9.HeaderText = "DIRECCION CALLE";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "DIRECCION_NUMERO";
            this.dataGridViewTextBoxColumn10.HeaderText = "DIRECCION NUMERO";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ID_PROVINCIA";
            this.dataGridViewTextBoxColumn2.DataSource = this.tAB_PROVINCIASBindingSource;
            this.dataGridViewTextBoxColumn2.DisplayMember = "PROVINCIA";
            this.dataGridViewTextBoxColumn2.HeaderText = "PROVINCIA";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "ID_PROVINCIA";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ID_CANTON";
            this.dataGridViewTextBoxColumn3.DataSource = this.tABCANTONESBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "CANTON";
            this.dataGridViewTextBoxColumn3.HeaderText = "CANTON";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "ID_CANTON";
            // 
            // tABCANTONESBindingSource
            // 
            this.tABCANTONESBindingSource.DataMember = "TAB_CANTONES";
            this.tABCANTONESBindingSource.DataSource = this.dSveterinaria;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "NUMERO_TELEFONO";
            this.dataGridViewTextBoxColumn11.HeaderText = "NUMERO TELEFONO";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "NUMERO_CELULAR";
            this.dataGridViewTextBoxColumn12.HeaderText = "NUMERO CELULAR";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // tAB_PROVINCIASTableAdapter
            // 
            this.tAB_PROVINCIASTableAdapter.ClearBeforeFill = true;
            // 
            // tAB_CANTONESTableAdapter
            // 
            this.tAB_CANTONESTableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FRM_Persona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 638);
            this.Controls.Add(this.tAB_PERSONADataGridView);
            this.Controls.Add(this.tAB_PERSONABindingNavigator);
            this.Controls.Add(this.panel1);
            this.Name = "FRM_Persona";
            this.Text = "FRM_Persona";
            this.Load += new System.EventHandler(this.FRM_Persona_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_PERSONABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSveterinaria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_PROVINCIASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_CANTONESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_PERSONABindingNavigator)).EndInit();
            this.tAB_PERSONABindingNavigator.ResumeLayout(false);
            this.tAB_PERSONABindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_PERSONADataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tABCANTONESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DSveterinaria dSveterinaria;
        private System.Windows.Forms.BindingSource tAB_PERSONABindingSource;
        private DSveterinariaTableAdapters.TAB_PERSONATableAdapter tAB_PERSONATableAdapter;
        private DSveterinariaTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tAB_PERSONABindingNavigator;
        private System.Windows.Forms.ToolStripButton btnAgregar;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.Label iD_PERSONALabel1;
        private System.Windows.Forms.ComboBox iD_PROVINCIAComboBox;
        private System.Windows.Forms.ComboBox iD_CANTONComboBox;
        private System.Windows.Forms.TextBox cEDULATextBox;
        private System.Windows.Forms.TextBox pRIMER_NOMBRETextBox;
        private System.Windows.Forms.TextBox sEGUNDO_NOMBRETextBox;
        private System.Windows.Forms.TextBox pRIMER_APELLIDOTextBox;
        private System.Windows.Forms.TextBox sEGUNDO_APELLIDOTextBox;
        private System.Windows.Forms.TextBox dIRECCION_CALLETextBox;
        private System.Windows.Forms.TextBox dIRECCION_NUMEROTextBox;
        private System.Windows.Forms.TextBox nUMERO_TELEFONOTextBox;
        private System.Windows.Forms.TextBox nUMERO_CELULARTextBox;
        private System.Windows.Forms.DataGridView tAB_PERSONADataGridView;
        private System.Windows.Forms.BindingSource tAB_PROVINCIASBindingSource;
        private DSveterinariaTableAdapters.TAB_PROVINCIASTableAdapter tAB_PROVINCIASTableAdapter;
        private System.Windows.Forms.BindingSource tAB_CANTONESBindingSource;
        private DSveterinariaTableAdapters.TAB_CANTONESTableAdapter tAB_CANTONESTableAdapter;
        private System.Windows.Forms.ToolStripButton btnActualizar;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.BindingSource tABCANTONESBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBuscar;
    }
}