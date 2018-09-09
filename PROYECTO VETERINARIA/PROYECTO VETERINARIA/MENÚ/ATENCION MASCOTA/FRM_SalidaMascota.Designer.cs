namespace PROYECTO_VETERINARIA
{
    partial class FRM_SalidaMascota
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
            System.Windows.Forms.Label iD_FICHA_INGRESOLabel;
            System.Windows.Forms.Label fECHA_DE_ALTALabel;
            System.Windows.Forms.Label eSTADOLabel;
            System.Windows.Forms.Label oBSERVACIONLabel;
            System.Windows.Forms.Label cITALabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_SalidaMascota));
            this.panel1 = new System.Windows.Forms.Panel();
            this.iD_FICHA_INGRESOComboBox = new System.Windows.Forms.ComboBox();
            this.tAB_SALIDA_DE_MASCOTABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSveterinaria = new PROYECTO_VETERINARIA.DSveterinaria();
            this.tABFICHADEINGRESOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fECHA_DE_ALTATextBox = new System.Windows.Forms.TextBox();
            this.eSTADOTextBox = new System.Windows.Forms.TextBox();
            this.oBSERVACIONTextBox = new System.Windows.Forms.TextBox();
            this.cITATextBox = new System.Windows.Forms.TextBox();
            this.tAB_SALIDA_DE_MASCOTATableAdapter = new PROYECTO_VETERINARIA.DSveterinariaTableAdapters.TAB_SALIDA_DE_MASCOTATableAdapter();
            this.tableAdapterManager = new PROYECTO_VETERINARIA.DSveterinariaTableAdapters.TableAdapterManager();
            this.tAB_FICHA_DE_INGRESOTableAdapter = new PROYECTO_VETERINARIA.DSveterinariaTableAdapters.TAB_FICHA_DE_INGRESOTableAdapter();
            this.tAB_SALIDA_DE_MASCOTABindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tAB_SALIDA_DE_MASCOTADataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visualStyler1 = new SkinSoft.VisualStyler.VisualStyler(this.components);
            iD_FICHA_INGRESOLabel = new System.Windows.Forms.Label();
            fECHA_DE_ALTALabel = new System.Windows.Forms.Label();
            eSTADOLabel = new System.Windows.Forms.Label();
            oBSERVACIONLabel = new System.Windows.Forms.Label();
            cITALabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_SALIDA_DE_MASCOTABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSveterinaria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tABFICHADEINGRESOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_SALIDA_DE_MASCOTABindingNavigator)).BeginInit();
            this.tAB_SALIDA_DE_MASCOTABindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_SALIDA_DE_MASCOTADataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visualStyler1)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_FICHA_INGRESOLabel
            // 
            iD_FICHA_INGRESOLabel.AutoSize = true;
            iD_FICHA_INGRESOLabel.Location = new System.Drawing.Point(68, 25);
            iD_FICHA_INGRESOLabel.Name = "iD_FICHA_INGRESOLabel";
            iD_FICHA_INGRESOLabel.Size = new System.Drawing.Size(107, 13);
            iD_FICHA_INGRESOLabel.TabIndex = 0;
            iD_FICHA_INGRESOLabel.Text = "ID FICHA INGRESO:";
            // 
            // fECHA_DE_ALTALabel
            // 
            fECHA_DE_ALTALabel.AutoSize = true;
            fECHA_DE_ALTALabel.Location = new System.Drawing.Point(68, 52);
            fECHA_DE_ALTALabel.Name = "fECHA_DE_ALTALabel";
            fECHA_DE_ALTALabel.Size = new System.Drawing.Size(93, 13);
            fECHA_DE_ALTALabel.TabIndex = 2;
            fECHA_DE_ALTALabel.Text = "FECHA DE ALTA:";
            // 
            // eSTADOLabel
            // 
            eSTADOLabel.AutoSize = true;
            eSTADOLabel.Location = new System.Drawing.Point(68, 78);
            eSTADOLabel.Name = "eSTADOLabel";
            eSTADOLabel.Size = new System.Drawing.Size(54, 13);
            eSTADOLabel.TabIndex = 4;
            eSTADOLabel.Text = "ESTADO:";
            // 
            // oBSERVACIONLabel
            // 
            oBSERVACIONLabel.AutoSize = true;
            oBSERVACIONLabel.Location = new System.Drawing.Point(68, 130);
            oBSERVACIONLabel.Name = "oBSERVACIONLabel";
            oBSERVACIONLabel.Size = new System.Drawing.Size(87, 13);
            oBSERVACIONLabel.TabIndex = 6;
            oBSERVACIONLabel.Text = "OBSERVACION:";
            // 
            // cITALabel
            // 
            cITALabel.AutoSize = true;
            cITALabel.Location = new System.Drawing.Point(68, 104);
            cITALabel.Name = "cITALabel";
            cITALabel.Size = new System.Drawing.Size(34, 13);
            cITALabel.TabIndex = 8;
            cITALabel.Text = "CITA:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(iD_FICHA_INGRESOLabel);
            this.panel1.Controls.Add(this.iD_FICHA_INGRESOComboBox);
            this.panel1.Controls.Add(fECHA_DE_ALTALabel);
            this.panel1.Controls.Add(this.fECHA_DE_ALTATextBox);
            this.panel1.Controls.Add(eSTADOLabel);
            this.panel1.Controls.Add(this.eSTADOTextBox);
            this.panel1.Controls.Add(oBSERVACIONLabel);
            this.panel1.Controls.Add(this.oBSERVACIONTextBox);
            this.panel1.Controls.Add(cITALabel);
            this.panel1.Controls.Add(this.cITATextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(615, 227);
            this.panel1.TabIndex = 0;
            // 
            // iD_FICHA_INGRESOComboBox
            // 
            this.iD_FICHA_INGRESOComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAB_SALIDA_DE_MASCOTABindingSource, "ID_FICHA_INGRESO", true));
            this.iD_FICHA_INGRESOComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tABFICHADEINGRESOBindingSource, "ID_FICHA_INGRESO", true));
            this.iD_FICHA_INGRESOComboBox.DataSource = this.tABFICHADEINGRESOBindingSource;
            this.iD_FICHA_INGRESOComboBox.DisplayMember = "ID_FICHA_INGRESO";
            this.iD_FICHA_INGRESOComboBox.FormattingEnabled = true;
            this.iD_FICHA_INGRESOComboBox.Location = new System.Drawing.Point(181, 22);
            this.iD_FICHA_INGRESOComboBox.Name = "iD_FICHA_INGRESOComboBox";
            this.iD_FICHA_INGRESOComboBox.Size = new System.Drawing.Size(121, 21);
            this.iD_FICHA_INGRESOComboBox.TabIndex = 1;
            this.iD_FICHA_INGRESOComboBox.ValueMember = "ID_FICHA_INGRESO";
            // 
            // tAB_SALIDA_DE_MASCOTABindingSource
            // 
            this.tAB_SALIDA_DE_MASCOTABindingSource.DataMember = "TAB_SALIDA_DE_MASCOTA";
            this.tAB_SALIDA_DE_MASCOTABindingSource.DataSource = this.dSveterinaria;
            // 
            // dSveterinaria
            // 
            this.dSveterinaria.DataSetName = "DSveterinaria";
            this.dSveterinaria.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tABFICHADEINGRESOBindingSource
            // 
            this.tABFICHADEINGRESOBindingSource.DataMember = "TAB_FICHA_DE_INGRESO";
            this.tABFICHADEINGRESOBindingSource.DataSource = this.dSveterinaria;
            // 
            // fECHA_DE_ALTATextBox
            // 
            this.fECHA_DE_ALTATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAB_SALIDA_DE_MASCOTABindingSource, "FECHA_DE_ALTA", true));
            this.fECHA_DE_ALTATextBox.Location = new System.Drawing.Point(181, 49);
            this.fECHA_DE_ALTATextBox.Name = "fECHA_DE_ALTATextBox";
            this.fECHA_DE_ALTATextBox.Size = new System.Drawing.Size(121, 20);
            this.fECHA_DE_ALTATextBox.TabIndex = 3;
            // 
            // eSTADOTextBox
            // 
            this.eSTADOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAB_SALIDA_DE_MASCOTABindingSource, "ESTADO", true));
            this.eSTADOTextBox.Location = new System.Drawing.Point(181, 75);
            this.eSTADOTextBox.Name = "eSTADOTextBox";
            this.eSTADOTextBox.Size = new System.Drawing.Size(121, 20);
            this.eSTADOTextBox.TabIndex = 5;
            // 
            // oBSERVACIONTextBox
            // 
            this.oBSERVACIONTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAB_SALIDA_DE_MASCOTABindingSource, "OBSERVACION", true));
            this.oBSERVACIONTextBox.Location = new System.Drawing.Point(181, 127);
            this.oBSERVACIONTextBox.Multiline = true;
            this.oBSERVACIONTextBox.Name = "oBSERVACIONTextBox";
            this.oBSERVACIONTextBox.Size = new System.Drawing.Size(330, 85);
            this.oBSERVACIONTextBox.TabIndex = 7;
            // 
            // cITATextBox
            // 
            this.cITATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAB_SALIDA_DE_MASCOTABindingSource, "CITA", true));
            this.cITATextBox.Location = new System.Drawing.Point(181, 101);
            this.cITATextBox.Name = "cITATextBox";
            this.cITATextBox.Size = new System.Drawing.Size(121, 20);
            this.cITATextBox.TabIndex = 9;
            // 
            // tAB_SALIDA_DE_MASCOTATableAdapter
            // 
            this.tAB_SALIDA_DE_MASCOTATableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TAB_CANTONESTableAdapter = null;
            this.tableAdapterManager.TAB_CLIENTESTableAdapter = null;
            this.tableAdapterManager.TAB_CONTROL_MASCOTATableAdapter = null;
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
            this.tableAdapterManager.TAB_SALIDA_DE_MASCOTATableAdapter = this.tAB_SALIDA_DE_MASCOTATableAdapter;
            this.tableAdapterManager.TAB_TIPO_DE_MASCOTATableAdapter = null;
            this.tableAdapterManager.TAB_USUARIOSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PROYECTO_VETERINARIA.DSveterinariaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tAB_FICHA_DE_INGRESOTableAdapter
            // 
            this.tAB_FICHA_DE_INGRESOTableAdapter.ClearBeforeFill = true;
            // 
            // tAB_SALIDA_DE_MASCOTABindingNavigator
            // 
            this.tAB_SALIDA_DE_MASCOTABindingNavigator.AddNewItem = this.btnAgregar;
            this.tAB_SALIDA_DE_MASCOTABindingNavigator.BindingSource = this.tAB_SALIDA_DE_MASCOTABindingSource;
            this.tAB_SALIDA_DE_MASCOTABindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tAB_SALIDA_DE_MASCOTABindingNavigator.DeleteItem = this.btnEliminar;
            this.tAB_SALIDA_DE_MASCOTABindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tAB_SALIDA_DE_MASCOTABindingNavigator.Location = new System.Drawing.Point(0, 227);
            this.tAB_SALIDA_DE_MASCOTABindingNavigator.MoveFirstItem = null;
            this.tAB_SALIDA_DE_MASCOTABindingNavigator.MoveLastItem = null;
            this.tAB_SALIDA_DE_MASCOTABindingNavigator.MoveNextItem = null;
            this.tAB_SALIDA_DE_MASCOTABindingNavigator.MovePreviousItem = null;
            this.tAB_SALIDA_DE_MASCOTABindingNavigator.Name = "tAB_SALIDA_DE_MASCOTABindingNavigator";
            this.tAB_SALIDA_DE_MASCOTABindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tAB_SALIDA_DE_MASCOTABindingNavigator.Size = new System.Drawing.Size(615, 25);
            this.tAB_SALIDA_DE_MASCOTABindingNavigator.TabIndex = 1;
            this.tAB_SALIDA_DE_MASCOTABindingNavigator.Text = "bindingNavigator1";
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
            this.btnGuardar.Click += new System.EventHandler(this.tAB_SALIDA_DE_MASCOTABindingNavigatorSaveItem_Click_1);
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
            // tAB_SALIDA_DE_MASCOTADataGridView
            // 
            this.tAB_SALIDA_DE_MASCOTADataGridView.AllowUserToAddRows = false;
            this.tAB_SALIDA_DE_MASCOTADataGridView.AllowUserToDeleteRows = false;
            this.tAB_SALIDA_DE_MASCOTADataGridView.AutoGenerateColumns = false;
            this.tAB_SALIDA_DE_MASCOTADataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tAB_SALIDA_DE_MASCOTADataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn4});
            this.tAB_SALIDA_DE_MASCOTADataGridView.DataSource = this.tAB_SALIDA_DE_MASCOTABindingSource;
            this.tAB_SALIDA_DE_MASCOTADataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tAB_SALIDA_DE_MASCOTADataGridView.Location = new System.Drawing.Point(0, 252);
            this.tAB_SALIDA_DE_MASCOTADataGridView.Name = "tAB_SALIDA_DE_MASCOTADataGridView";
            this.tAB_SALIDA_DE_MASCOTADataGridView.ReadOnly = true;
            this.tAB_SALIDA_DE_MASCOTADataGridView.Size = new System.Drawing.Size(615, 227);
            this.tAB_SALIDA_DE_MASCOTADataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_FICHA_INGRESO";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FECHA_DE_ALTA";
            this.dataGridViewTextBoxColumn2.HeaderText = "FECHA DE ALTA";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ESTADO";
            this.dataGridViewTextBoxColumn3.HeaderText = "ESTADO";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CITA";
            this.dataGridViewTextBoxColumn5.HeaderText = "CITA";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "OBSERVACION";
            this.dataGridViewTextBoxColumn4.HeaderText = "OBSERVACION";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // visualStyler1
            // 
            this.visualStyler1.HostForm = this;
            this.visualStyler1.License = ((SkinSoft.VisualStyler.Licensing.VisualStylerLicense)(resources.GetObject("visualStyler1.License")));
            this.visualStyler1.LoadVisualStyle(null, "OSX (Panther).vssf");
            // 
            // FRM_SalidaMascota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 479);
            this.Controls.Add(this.tAB_SALIDA_DE_MASCOTADataGridView);
            this.Controls.Add(this.tAB_SALIDA_DE_MASCOTABindingNavigator);
            this.Controls.Add(this.panel1);
            this.Name = "FRM_SalidaMascota";
            this.Text = "Salida Mascota";
            this.Load += new System.EventHandler(this.FRM_SalidaMascota_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_SALIDA_DE_MASCOTABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSveterinaria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tABFICHADEINGRESOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_SALIDA_DE_MASCOTABindingNavigator)).EndInit();
            this.tAB_SALIDA_DE_MASCOTABindingNavigator.ResumeLayout(false);
            this.tAB_SALIDA_DE_MASCOTABindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_SALIDA_DE_MASCOTADataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visualStyler1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DSveterinaria dSveterinaria;
        private System.Windows.Forms.BindingSource tAB_SALIDA_DE_MASCOTABindingSource;
        private DSveterinariaTableAdapters.TAB_SALIDA_DE_MASCOTATableAdapter tAB_SALIDA_DE_MASCOTATableAdapter;
        private DSveterinariaTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tAB_SALIDA_DE_MASCOTABindingNavigator;
        private System.Windows.Forms.ToolStripButton btnAgregar;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ComboBox iD_FICHA_INGRESOComboBox;
        private System.Windows.Forms.TextBox fECHA_DE_ALTATextBox;
        private System.Windows.Forms.TextBox eSTADOTextBox;
        private System.Windows.Forms.TextBox oBSERVACIONTextBox;
        private System.Windows.Forms.TextBox cITATextBox;
        private DSveterinariaTableAdapters.TAB_FICHA_DE_INGRESOTableAdapter tAB_FICHA_DE_INGRESOTableAdapter;
        private System.Windows.Forms.BindingSource tABFICHADEINGRESOBindingSource;
        private System.Windows.Forms.DataGridView tAB_SALIDA_DE_MASCOTADataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private SkinSoft.VisualStyler.VisualStyler visualStyler1;
        private System.Windows.Forms.ToolStripButton btnActualizar;
        private System.Windows.Forms.ToolStripButton btnCancelar;
    }
}