namespace PROYECTO_VETERINARIA
{
    partial class FRM_Clientes
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
            System.Windows.Forms.Label iD_PERSONALabel;
            System.Windows.Forms.Label fECHA_REGISTROLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Clientes));
            this.visualStyler1 = new SkinSoft.VisualStyler.VisualStyler(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.iD_PERSONAComboBox = new System.Windows.Forms.ComboBox();
            this.tAB_CLIENTESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSveterinaria = new PROYECTO_VETERINARIA.DSveterinaria();
            this.tAB_PERSONABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fECHA_REGISTRODateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tABPERSONABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tAB_CLIENTESTableAdapter = new PROYECTO_VETERINARIA.DSveterinariaTableAdapters.TAB_CLIENTESTableAdapter();
            this.tableAdapterManager = new PROYECTO_VETERINARIA.DSveterinariaTableAdapters.TableAdapterManager();
            this.tAB_PERSONATableAdapter = new PROYECTO_VETERINARIA.DSveterinariaTableAdapters.TAB_PERSONATableAdapter();
            this.tAB_CLIENTESBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tAB_CLIENTESDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            iD_PERSONALabel = new System.Windows.Forms.Label();
            fECHA_REGISTROLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.visualStyler1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_CLIENTESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSveterinaria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_PERSONABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tABPERSONABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_CLIENTESBindingNavigator)).BeginInit();
            this.tAB_CLIENTESBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_CLIENTESDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_PERSONALabel
            // 
            iD_PERSONALabel.AutoSize = true;
            iD_PERSONALabel.Location = new System.Drawing.Point(35, 23);
            iD_PERSONALabel.Name = "iD_PERSONALabel";
            iD_PERSONALabel.Size = new System.Drawing.Size(53, 13);
            iD_PERSONALabel.TabIndex = 0;
            iD_PERSONALabel.Text = "CEDULA:";
            // 
            // fECHA_REGISTROLabel
            // 
            fECHA_REGISTROLabel.AutoSize = true;
            fECHA_REGISTROLabel.Location = new System.Drawing.Point(35, 51);
            fECHA_REGISTROLabel.Name = "fECHA_REGISTROLabel";
            fECHA_REGISTROLabel.Size = new System.Drawing.Size(104, 13);
            fECHA_REGISTROLabel.TabIndex = 2;
            fECHA_REGISTROLabel.Text = "FECHA REGISTRO:";
            // 
            // visualStyler1
            // 
            this.visualStyler1.HostForm = this;
            this.visualStyler1.License = ((SkinSoft.VisualStyler.Licensing.VisualStylerLicense)(resources.GetObject("visualStyler1.License")));
            this.visualStyler1.LoadVisualStyle(null, "OSX (Panther).vssf");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(iD_PERSONALabel);
            this.panel1.Controls.Add(this.iD_PERSONAComboBox);
            this.panel1.Controls.Add(fECHA_REGISTROLabel);
            this.panel1.Controls.Add(this.fECHA_REGISTRODateTimePicker);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(493, 100);
            this.panel1.TabIndex = 0;
            // 
            // iD_PERSONAComboBox
            // 
            this.iD_PERSONAComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tAB_CLIENTESBindingSource, "ID_PERSONA", true));
            this.iD_PERSONAComboBox.DataSource = this.tAB_PERSONABindingSource;
            this.iD_PERSONAComboBox.DisplayMember = "PRIMER_APELLIDO";
            this.iD_PERSONAComboBox.FormattingEnabled = true;
            this.iD_PERSONAComboBox.Location = new System.Drawing.Point(145, 20);
            this.iD_PERSONAComboBox.Name = "iD_PERSONAComboBox";
            this.iD_PERSONAComboBox.Size = new System.Drawing.Size(200, 21);
            this.iD_PERSONAComboBox.TabIndex = 1;
            this.iD_PERSONAComboBox.ValueMember = "ID_PERSONA";
            // 
            // tAB_CLIENTESBindingSource
            // 
            this.tAB_CLIENTESBindingSource.DataMember = "TAB_CLIENTES";
            this.tAB_CLIENTESBindingSource.DataSource = this.dSveterinaria;
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
            // fECHA_REGISTRODateTimePicker
            // 
            this.fECHA_REGISTRODateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tAB_CLIENTESBindingSource, "FECHA_REGISTRO", true));
            this.fECHA_REGISTRODateTimePicker.Location = new System.Drawing.Point(145, 47);
            this.fECHA_REGISTRODateTimePicker.Name = "fECHA_REGISTRODateTimePicker";
            this.fECHA_REGISTRODateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fECHA_REGISTRODateTimePicker.TabIndex = 3;
            // 
            // tABPERSONABindingSource
            // 
            this.tABPERSONABindingSource.DataMember = "TAB_PERSONA";
            this.tABPERSONABindingSource.DataSource = this.dSveterinaria;
            // 
            // tAB_CLIENTESTableAdapter
            // 
            this.tAB_CLIENTESTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TAB_CANTONESTableAdapter = null;
            this.tableAdapterManager.TAB_CLIENTESTableAdapter = this.tAB_CLIENTESTableAdapter;
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
            // tAB_PERSONATableAdapter
            // 
            this.tAB_PERSONATableAdapter.ClearBeforeFill = true;
            // 
            // tAB_CLIENTESBindingNavigator
            // 
            this.tAB_CLIENTESBindingNavigator.AddNewItem = this.btnAgregar;
            this.tAB_CLIENTESBindingNavigator.BindingSource = this.tAB_CLIENTESBindingSource;
            this.tAB_CLIENTESBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tAB_CLIENTESBindingNavigator.DeleteItem = this.btnEliminar;
            this.tAB_CLIENTESBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tAB_CLIENTESBindingNavigator.Location = new System.Drawing.Point(0, 100);
            this.tAB_CLIENTESBindingNavigator.MoveFirstItem = null;
            this.tAB_CLIENTESBindingNavigator.MoveLastItem = null;
            this.tAB_CLIENTESBindingNavigator.MoveNextItem = null;
            this.tAB_CLIENTESBindingNavigator.MovePreviousItem = null;
            this.tAB_CLIENTESBindingNavigator.Name = "tAB_CLIENTESBindingNavigator";
            this.tAB_CLIENTESBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tAB_CLIENTESBindingNavigator.Size = new System.Drawing.Size(493, 25);
            this.tAB_CLIENTESBindingNavigator.TabIndex = 1;
            this.tAB_CLIENTESBindingNavigator.Text = "bindingNavigator1";
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
            this.btnGuardar.Click += new System.EventHandler(this.tAB_CLIENTESBindingNavigatorSaveItem_Click);
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
            // tAB_CLIENTESDataGridView
            // 
            this.tAB_CLIENTESDataGridView.AllowUserToAddRows = false;
            this.tAB_CLIENTESDataGridView.AllowUserToDeleteRows = false;
            this.tAB_CLIENTESDataGridView.AutoGenerateColumns = false;
            this.tAB_CLIENTESDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tAB_CLIENTESDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.tAB_CLIENTESDataGridView.DataSource = this.tAB_CLIENTESBindingSource;
            this.tAB_CLIENTESDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tAB_CLIENTESDataGridView.Location = new System.Drawing.Point(0, 125);
            this.tAB_CLIENTESDataGridView.Name = "tAB_CLIENTESDataGridView";
            this.tAB_CLIENTESDataGridView.ReadOnly = true;
            this.tAB_CLIENTESDataGridView.Size = new System.Drawing.Size(493, 353);
            this.tAB_CLIENTESDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_PERSONA";
            this.dataGridViewTextBoxColumn1.DataSource = this.tABPERSONABindingSource;
            this.dataGridViewTextBoxColumn1.DisplayMember = "CEDULA";
            this.dataGridViewTextBoxColumn1.HeaderText = "CEDULA";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn1.ValueMember = "ID_PERSONA";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FECHA_REGISTRO";
            this.dataGridViewTextBoxColumn2.HeaderText = "FECHA DE REGISTRO";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // FRM_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 478);
            this.Controls.Add(this.tAB_CLIENTESDataGridView);
            this.Controls.Add(this.tAB_CLIENTESBindingNavigator);
            this.Controls.Add(this.panel1);
            this.Name = "FRM_Clientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.FRM_Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.visualStyler1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_CLIENTESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSveterinaria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_PERSONABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tABPERSONABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_CLIENTESBindingNavigator)).EndInit();
            this.tAB_CLIENTESBindingNavigator.ResumeLayout(false);
            this.tAB_CLIENTESBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_CLIENTESDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SkinSoft.VisualStyler.VisualStyler visualStyler1;
        private System.Windows.Forms.BindingNavigator tAB_CLIENTESBindingNavigator;
        private System.Windows.Forms.ToolStripButton btnAgregar;
        private System.Windows.Forms.BindingSource tAB_CLIENTESBindingSource;
        private DSveterinaria dSveterinaria;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.Panel panel1;
        private DSveterinariaTableAdapters.TAB_CLIENTESTableAdapter tAB_CLIENTESTableAdapter;
        private DSveterinariaTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView tAB_CLIENTESDataGridView;
        private System.Windows.Forms.ComboBox iD_PERSONAComboBox;
        private System.Windows.Forms.DateTimePicker fECHA_REGISTRODateTimePicker;
        private DSveterinariaTableAdapters.TAB_PERSONATableAdapter tAB_PERSONATableAdapter;
        private System.Windows.Forms.BindingSource tABPERSONABindingSource;
        private System.Windows.Forms.BindingSource tAB_PERSONABindingSource;
        private System.Windows.Forms.ToolStripButton btnActualizar;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}