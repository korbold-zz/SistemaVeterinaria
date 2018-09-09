namespace PROYECTO_VETERINARIA
{
    partial class FRM_Medicos
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
            System.Windows.Forms.Label iD_PERSONALabel;
            System.Windows.Forms.Label cARGOLabel;
            System.Windows.Forms.Label fECHA_REGISTROLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Medicos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iD_PERSONAComboBox = new System.Windows.Forms.ComboBox();
            this.tAB_MEDICOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSveterinaria = new PROYECTO_VETERINARIA.DSveterinaria();
            this.tAB_PERSONABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cARGOTextBox = new System.Windows.Forms.TextBox();
            this.fECHA_REGISTRODateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tAB_MEDICOSTableAdapter = new PROYECTO_VETERINARIA.DSveterinariaTableAdapters.TAB_MEDICOSTableAdapter();
            this.tableAdapterManager = new PROYECTO_VETERINARIA.DSveterinariaTableAdapters.TableAdapterManager();
            this.tAB_PERSONATableAdapter = new PROYECTO_VETERINARIA.DSveterinariaTableAdapters.TAB_PERSONATableAdapter();
            this.tAB_MEDICOSDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAgregar = new System.Windows.Forms.ToolStripButton();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnActualizar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.tAB_MEDICOSBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            iD_PERSONALabel = new System.Windows.Forms.Label();
            cARGOLabel = new System.Windows.Forms.Label();
            fECHA_REGISTROLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_MEDICOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSveterinaria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_PERSONABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_MEDICOSDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_MEDICOSBindingNavigator)).BeginInit();
            this.tAB_MEDICOSBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_PERSONALabel
            // 
            iD_PERSONALabel.AutoSize = true;
            iD_PERSONALabel.Location = new System.Drawing.Point(38, 50);
            iD_PERSONALabel.Name = "iD_PERSONALabel";
            iD_PERSONALabel.Size = new System.Drawing.Size(50, 13);
            iD_PERSONALabel.TabIndex = 0;
            iD_PERSONALabel.Text = "CÉDULA";
            // 
            // cARGOLabel
            // 
            cARGOLabel.AutoSize = true;
            cARGOLabel.Location = new System.Drawing.Point(38, 77);
            cARGOLabel.Name = "cARGOLabel";
            cARGOLabel.Size = new System.Drawing.Size(48, 13);
            cARGOLabel.TabIndex = 2;
            cARGOLabel.Text = "CARGO:";
            // 
            // fECHA_REGISTROLabel
            // 
            fECHA_REGISTROLabel.AutoSize = true;
            fECHA_REGISTROLabel.Location = new System.Drawing.Point(38, 104);
            fECHA_REGISTROLabel.Name = "fECHA_REGISTROLabel";
            fECHA_REGISTROLabel.Size = new System.Drawing.Size(104, 13);
            fECHA_REGISTROLabel.TabIndex = 4;
            fECHA_REGISTROLabel.Text = "FECHA REGISTRO:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(iD_PERSONALabel);
            this.panel1.Controls.Add(this.iD_PERSONAComboBox);
            this.panel1.Controls.Add(cARGOLabel);
            this.panel1.Controls.Add(this.cARGOTextBox);
            this.panel1.Controls.Add(fECHA_REGISTROLabel);
            this.panel1.Controls.Add(this.fECHA_REGISTRODateTimePicker);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(527, 158);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Location = new System.Drawing.Point(383, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(132, 129);
            this.panel2.TabIndex = 6;
            // 
            // iD_PERSONAComboBox
            // 
            this.iD_PERSONAComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tAB_MEDICOSBindingSource, "ID_PERSONA", true));
            this.iD_PERSONAComboBox.DataSource = this.tAB_PERSONABindingSource;
            this.iD_PERSONAComboBox.DisplayMember = "PRIMER_APELLIDO";
            this.iD_PERSONAComboBox.FormattingEnabled = true;
            this.iD_PERSONAComboBox.Location = new System.Drawing.Point(148, 47);
            this.iD_PERSONAComboBox.Name = "iD_PERSONAComboBox";
            this.iD_PERSONAComboBox.Size = new System.Drawing.Size(200, 21);
            this.iD_PERSONAComboBox.TabIndex = 1;
            this.iD_PERSONAComboBox.ValueMember = "ID_PERSONA";
            // 
            // tAB_MEDICOSBindingSource
            // 
            this.tAB_MEDICOSBindingSource.DataMember = "TAB_MEDICOS";
            this.tAB_MEDICOSBindingSource.DataSource = this.dSveterinaria;
            // 
            // dSveterinaria
            // 
            this.dSveterinaria.DataSetName = "DSveterinaria";
            this.dSveterinaria.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tAB_PERSONABindingSource
            // 
            this.tAB_PERSONABindingSource.DataMember = "TAB_PERSONA";
            this.tAB_PERSONABindingSource.DataSource = this.dSveterinaria;
            // 
            // cARGOTextBox
            // 
            this.cARGOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAB_MEDICOSBindingSource, "CARGO", true));
            this.cARGOTextBox.Location = new System.Drawing.Point(148, 74);
            this.cARGOTextBox.Name = "cARGOTextBox";
            this.cARGOTextBox.Size = new System.Drawing.Size(200, 20);
            this.cARGOTextBox.TabIndex = 3;
            this.cARGOTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cARGOTextBox_KeyPress);
            this.cARGOTextBox.Leave += new System.EventHandler(this.cARGOTextBox_Leave);
            this.cARGOTextBox.Validated += new System.EventHandler(this.cARGOTextBox_Validated);
            // 
            // fECHA_REGISTRODateTimePicker
            // 
            this.fECHA_REGISTRODateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tAB_MEDICOSBindingSource, "FECHA_REGISTRO", true));
            this.fECHA_REGISTRODateTimePicker.Location = new System.Drawing.Point(148, 100);
            this.fECHA_REGISTRODateTimePicker.Name = "fECHA_REGISTRODateTimePicker";
            this.fECHA_REGISTRODateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fECHA_REGISTRODateTimePicker.TabIndex = 5;
            // 
            // tAB_MEDICOSTableAdapter
            // 
            this.tAB_MEDICOSTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.TAB_MEDICOSTableAdapter = this.tAB_MEDICOSTableAdapter;
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
            // tAB_PERSONATableAdapter
            // 
            this.tAB_PERSONATableAdapter.ClearBeforeFill = true;
            // 
            // tAB_MEDICOSDataGridView
            // 
            this.tAB_MEDICOSDataGridView.AllowUserToAddRows = false;
            this.tAB_MEDICOSDataGridView.AllowUserToDeleteRows = false;
            this.tAB_MEDICOSDataGridView.AutoGenerateColumns = false;
            this.tAB_MEDICOSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tAB_MEDICOSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.tAB_MEDICOSDataGridView.DataSource = this.tAB_MEDICOSBindingSource;
            this.tAB_MEDICOSDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tAB_MEDICOSDataGridView.Location = new System.Drawing.Point(0, 183);
            this.tAB_MEDICOSDataGridView.Name = "tAB_MEDICOSDataGridView";
            this.tAB_MEDICOSDataGridView.ReadOnly = true;
            this.tAB_MEDICOSDataGridView.Size = new System.Drawing.Size(527, 81);
            this.tAB_MEDICOSDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_PERSONA";
            this.dataGridViewTextBoxColumn1.DataSource = this.tAB_PERSONABindingSource;
            this.dataGridViewTextBoxColumn1.DisplayMember = "CEDULA";
            this.dataGridViewTextBoxColumn1.HeaderText = "CÉDULA";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn1.ValueMember = "ID_PERSONA";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CARGO";
            this.dataGridViewTextBoxColumn2.HeaderText = "CARGO";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FECHA_REGISTRO";
            this.dataGridViewTextBoxColumn3.HeaderText = "FECHA REGISTRO";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnAgregar
            // 
            this.btnAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.RightToLeftAutoMirrorImage = true;
            this.btnAgregar.Size = new System.Drawing.Size(23, 22);
            this.btnAgregar.Text = "Agregar nuevo";
            this.btnAgregar.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
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
            // btnGuardar
            // 
            this.btnGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(23, 22);
            this.btnGuardar.Text = "Guardar datos";
            this.btnGuardar.Click += new System.EventHandler(this.tAB_MEDICOSBindingNavigatorSaveItem_Click);
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
            // tAB_MEDICOSBindingNavigator
            // 
            this.tAB_MEDICOSBindingNavigator.AddNewItem = this.btnAgregar;
            this.tAB_MEDICOSBindingNavigator.BindingSource = this.tAB_MEDICOSBindingSource;
            this.tAB_MEDICOSBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tAB_MEDICOSBindingNavigator.DeleteItem = this.btnEliminar;
            this.tAB_MEDICOSBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.btnAgregar,
            this.btnEliminar,
            this.btnGuardar,
            this.btnActualizar,
            this.btnCancelar});
            this.tAB_MEDICOSBindingNavigator.Location = new System.Drawing.Point(0, 158);
            this.tAB_MEDICOSBindingNavigator.MoveFirstItem = null;
            this.tAB_MEDICOSBindingNavigator.MoveLastItem = null;
            this.tAB_MEDICOSBindingNavigator.MoveNextItem = null;
            this.tAB_MEDICOSBindingNavigator.MovePreviousItem = null;
            this.tAB_MEDICOSBindingNavigator.Name = "tAB_MEDICOSBindingNavigator";
            this.tAB_MEDICOSBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tAB_MEDICOSBindingNavigator.Size = new System.Drawing.Size(527, 25);
            this.tAB_MEDICOSBindingNavigator.TabIndex = 1;
            this.tAB_MEDICOSBindingNavigator.Text = "bindingNavigator1";
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            this.errorProvider2.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider2.Icon")));
            // 
            // FRM_Medicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 264);
            this.Controls.Add(this.tAB_MEDICOSDataGridView);
            this.Controls.Add(this.tAB_MEDICOSBindingNavigator);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRM_Medicos";
            this.Text = "FRM_Medicos";
            this.Load += new System.EventHandler(this.FRM_Medicos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_MEDICOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSveterinaria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_PERSONABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_MEDICOSDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_MEDICOSBindingNavigator)).EndInit();
            this.tAB_MEDICOSBindingNavigator.ResumeLayout(false);
            this.tAB_MEDICOSBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DSveterinaria dSveterinaria;
        private System.Windows.Forms.BindingSource tAB_MEDICOSBindingSource;
        private DSveterinariaTableAdapters.TAB_MEDICOSTableAdapter tAB_MEDICOSTableAdapter;
        private DSveterinariaTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox iD_PERSONAComboBox;
        private System.Windows.Forms.TextBox cARGOTextBox;
        private System.Windows.Forms.DateTimePicker fECHA_REGISTRODateTimePicker;
        private DSveterinariaTableAdapters.TAB_PERSONATableAdapter tAB_PERSONATableAdapter;
        private System.Windows.Forms.BindingSource tAB_PERSONABindingSource;
        private System.Windows.Forms.DataGridView tAB_MEDICOSDataGridView;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.BindingNavigator tAB_MEDICOSBindingNavigator;
        private System.Windows.Forms.ToolStripButton btnAgregar;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton btnActualizar;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}