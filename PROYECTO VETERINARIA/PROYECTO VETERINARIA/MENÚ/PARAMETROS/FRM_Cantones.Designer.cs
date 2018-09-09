namespace PROYECTO_VETERINARIA
{
    partial class FRM_Cantones
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
            System.Windows.Forms.Label iD_CANTONLabel;
            System.Windows.Forms.Label iD_PROVINCIALabel;
            System.Windows.Forms.Label cANTONLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Cantones));
            this.panel1 = new System.Windows.Forms.Panel();
            this.iD_CANTONLabel1 = new System.Windows.Forms.Label();
            this.tAB_CANTONESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSveterinaria = new PROYECTO_VETERINARIA.DSveterinaria();
            this.iD_PROVINCIAComboBox = new System.Windows.Forms.ComboBox();
            this.tAB_PROVINCIASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cANTONTextBox = new System.Windows.Forms.TextBox();
            this.tABPROVINCIASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tAB_CANTONESTableAdapter = new PROYECTO_VETERINARIA.DSveterinariaTableAdapters.TAB_CANTONESTableAdapter();
            this.tableAdapterManager = new PROYECTO_VETERINARIA.DSveterinariaTableAdapters.TableAdapterManager();
            this.tAB_CANTONESBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.tAB_CANTONESDataGridView = new System.Windows.Forms.DataGridView();
            this.tAB_PROVINCIASTableAdapter = new PROYECTO_VETERINARIA.DSveterinariaTableAdapters.TAB_PROVINCIASTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            iD_CANTONLabel = new System.Windows.Forms.Label();
            iD_PROVINCIALabel = new System.Windows.Forms.Label();
            cANTONLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_CANTONESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSveterinaria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_PROVINCIASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tABPROVINCIASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_CANTONESBindingNavigator)).BeginInit();
            this.tAB_CANTONESBindingNavigator.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_CANTONESDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_CANTONLabel
            // 
            iD_CANTONLabel.AutoSize = true;
            iD_CANTONLabel.Location = new System.Drawing.Point(72, 37);
            iD_CANTONLabel.Name = "iD_CANTONLabel";
            iD_CANTONLabel.Size = new System.Drawing.Size(69, 13);
            iD_CANTONLabel.TabIndex = 0;
            iD_CANTONLabel.Text = "ID CANTON:";
            // 
            // iD_PROVINCIALabel
            // 
            iD_PROVINCIALabel.AutoSize = true;
            iD_PROVINCIALabel.Location = new System.Drawing.Point(72, 66);
            iD_PROVINCIALabel.Name = "iD_PROVINCIALabel";
            iD_PROVINCIALabel.Size = new System.Drawing.Size(82, 13);
            iD_PROVINCIALabel.TabIndex = 2;
            iD_PROVINCIALabel.Text = "ID PROVINCIA:";
            // 
            // cANTONLabel
            // 
            cANTONLabel.AutoSize = true;
            cANTONLabel.Location = new System.Drawing.Point(72, 93);
            cANTONLabel.Name = "cANTONLabel";
            cANTONLabel.Size = new System.Drawing.Size(55, 13);
            cANTONLabel.TabIndex = 4;
            cANTONLabel.Text = "CANTON:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(iD_CANTONLabel);
            this.panel1.Controls.Add(this.iD_CANTONLabel1);
            this.panel1.Controls.Add(iD_PROVINCIALabel);
            this.panel1.Controls.Add(this.iD_PROVINCIAComboBox);
            this.panel1.Controls.Add(cANTONLabel);
            this.panel1.Controls.Add(this.cANTONTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 130);
            this.panel1.TabIndex = 0;
            // 
            // iD_CANTONLabel1
            // 
            this.iD_CANTONLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAB_CANTONESBindingSource, "ID_CANTON", true));
            this.iD_CANTONLabel1.Location = new System.Drawing.Point(160, 37);
            this.iD_CANTONLabel1.Name = "iD_CANTONLabel1";
            this.iD_CANTONLabel1.Size = new System.Drawing.Size(121, 23);
            this.iD_CANTONLabel1.TabIndex = 1;
            this.iD_CANTONLabel1.Text = "label1";
            // 
            // tAB_CANTONESBindingSource
            // 
            this.tAB_CANTONESBindingSource.DataMember = "TAB_CANTONES";
            this.tAB_CANTONESBindingSource.DataSource = this.dSveterinaria;
            // 
            // dSveterinaria
            // 
            this.dSveterinaria.DataSetName = "DSveterinaria";
            this.dSveterinaria.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iD_PROVINCIAComboBox
            // 
            this.iD_PROVINCIAComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tAB_CANTONESBindingSource, "ID_PROVINCIA", true));
            this.iD_PROVINCIAComboBox.DataSource = this.tAB_PROVINCIASBindingSource;
            this.iD_PROVINCIAComboBox.DisplayMember = "PROVINCIA";
            this.iD_PROVINCIAComboBox.FormattingEnabled = true;
            this.iD_PROVINCIAComboBox.Location = new System.Drawing.Point(160, 63);
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
            // cANTONTextBox
            // 
            this.cANTONTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAB_CANTONESBindingSource, "CANTON", true));
            this.cANTONTextBox.Enabled = false;
            this.cANTONTextBox.Location = new System.Drawing.Point(160, 90);
            this.cANTONTextBox.Name = "cANTONTextBox";
            this.cANTONTextBox.Size = new System.Drawing.Size(175, 20);
            this.cANTONTextBox.TabIndex = 5;
            this.cANTONTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cANTONTextBox_KeyPress);
            // 
            // tABPROVINCIASBindingSource
            // 
            this.tABPROVINCIASBindingSource.DataMember = "TAB_PROVINCIAS";
            this.tABPROVINCIASBindingSource.DataSource = this.dSveterinaria;
            // 
            // tAB_CANTONESTableAdapter
            // 
            this.tAB_CANTONESTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TAB_CANTONESTableAdapter = this.tAB_CANTONESTableAdapter;
            this.tableAdapterManager.TAB_CLIENTESTableAdapter = null;
            this.tableAdapterManager.TAB_CONTROL_MASCOTATableAdapter = null;
            this.tableAdapterManager.TAB_FICHA_DE_INGRESOTableAdapter = null;
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
            // tAB_CANTONESBindingNavigator
            // 
            this.tAB_CANTONESBindingNavigator.AddNewItem = this.btnAgregar;
            this.tAB_CANTONESBindingNavigator.BindingSource = this.tAB_CANTONESBindingSource;
            this.tAB_CANTONESBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tAB_CANTONESBindingNavigator.DeleteItem = this.btnEliminar;
            this.tAB_CANTONESBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tAB_CANTONESBindingNavigator.Location = new System.Drawing.Point(0, 130);
            this.tAB_CANTONESBindingNavigator.MoveFirstItem = null;
            this.tAB_CANTONESBindingNavigator.MoveLastItem = null;
            this.tAB_CANTONESBindingNavigator.MoveNextItem = null;
            this.tAB_CANTONESBindingNavigator.MovePreviousItem = null;
            this.tAB_CANTONESBindingNavigator.Name = "tAB_CANTONESBindingNavigator";
            this.tAB_CANTONESBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tAB_CANTONESBindingNavigator.Size = new System.Drawing.Size(347, 25);
            this.tAB_CANTONESBindingNavigator.TabIndex = 1;
            this.tAB_CANTONESBindingNavigator.Text = "bindingNavigator1";
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
            this.btnGuardar.Click += new System.EventHandler(this.tAB_CANTONESBindingNavigatorSaveItem_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(23, 22);
            this.btnActualizar.Text = "btnActualizar";
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(23, 22);
            this.btnCancelar.Text = "btnCancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tAB_CANTONESDataGridView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 155);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(347, 120);
            this.panel2.TabIndex = 2;
            // 
            // tAB_CANTONESDataGridView
            // 
            this.tAB_CANTONESDataGridView.AllowUserToAddRows = false;
            this.tAB_CANTONESDataGridView.AllowUserToDeleteRows = false;
            this.tAB_CANTONESDataGridView.AutoGenerateColumns = false;
            this.tAB_CANTONESDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tAB_CANTONESDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.tAB_CANTONESDataGridView.DataSource = this.tAB_CANTONESBindingSource;
            this.tAB_CANTONESDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tAB_CANTONESDataGridView.Location = new System.Drawing.Point(0, 0);
            this.tAB_CANTONESDataGridView.Name = "tAB_CANTONESDataGridView";
            this.tAB_CANTONESDataGridView.ReadOnly = true;
            this.tAB_CANTONESDataGridView.Size = new System.Drawing.Size(347, 120);
            this.tAB_CANTONESDataGridView.TabIndex = 0;
            // 
            // tAB_PROVINCIASTableAdapter
            // 
            this.tAB_PROVINCIASTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_CANTON";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.Width = 50;
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CANTON";
            this.dataGridViewTextBoxColumn3.HeaderText = "CANTON";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // FRM_Cantones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 275);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tAB_CANTONESBindingNavigator);
            this.Controls.Add(this.panel1);
            this.Name = "FRM_Cantones";
            this.Text = "Cantones";
            this.Load += new System.EventHandler(this.FRM_Cantones_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_CANTONESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSveterinaria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_PROVINCIASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tABPROVINCIASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_CANTONESBindingNavigator)).EndInit();
            this.tAB_CANTONESBindingNavigator.ResumeLayout(false);
            this.tAB_CANTONESBindingNavigator.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tAB_CANTONESDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DSveterinaria dSveterinaria;
        private System.Windows.Forms.BindingSource tAB_CANTONESBindingSource;
        private DSveterinariaTableAdapters.TAB_CANTONESTableAdapter tAB_CANTONESTableAdapter;
        private DSveterinariaTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tAB_CANTONESBindingNavigator;
        private System.Windows.Forms.ToolStripButton btnAgregar;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.Label iD_CANTONLabel1;
        private System.Windows.Forms.ComboBox iD_PROVINCIAComboBox;
        private System.Windows.Forms.TextBox cANTONTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView tAB_CANTONESDataGridView;
        private System.Windows.Forms.BindingSource tABPROVINCIASBindingSource;
        private DSveterinariaTableAdapters.TAB_PROVINCIASTableAdapter tAB_PROVINCIASTableAdapter;
        private System.Windows.Forms.BindingSource tAB_PROVINCIASBindingSource;
        private System.Windows.Forms.ToolStripButton btnActualizar;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}