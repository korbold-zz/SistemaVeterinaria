namespace PROYECTO_VETERINARIA
{
    partial class FRM_Raza
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
            System.Windows.Forms.Label iD_RAZALabel;
            System.Windows.Forms.Label iD_TIPODEMASCOTALabel;
            System.Windows.Forms.Label tIPO_RAZALabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Raza));
            this.panel1 = new System.Windows.Forms.Panel();
            this.iD_RAZALabel1 = new System.Windows.Forms.Label();
            this.tAB_RAZABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSveterinaria = new PROYECTO_VETERINARIA.DSveterinaria();
            this.iD_TIPODEMASCOTAComboBox = new System.Windows.Forms.ComboBox();
            this.tAB_TIPO_DE_MASCOTABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tIPO_RAZATextBox = new System.Windows.Forms.TextBox();
            this.tABTIPODEMASCOTABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tAB_RAZATableAdapter = new PROYECTO_VETERINARIA.DSveterinariaTableAdapters.TAB_RAZATableAdapter();
            this.tableAdapterManager = new PROYECTO_VETERINARIA.DSveterinariaTableAdapters.TableAdapterManager();
            this.tAB_TIPO_DE_MASCOTATableAdapter = new PROYECTO_VETERINARIA.DSveterinariaTableAdapters.TAB_TIPO_DE_MASCOTATableAdapter();
            this.tAB_RAZABindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tAB_RAZADataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            iD_RAZALabel = new System.Windows.Forms.Label();
            iD_TIPODEMASCOTALabel = new System.Windows.Forms.Label();
            tIPO_RAZALabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_RAZABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSveterinaria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_TIPO_DE_MASCOTABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tABTIPODEMASCOTABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_RAZABindingNavigator)).BeginInit();
            this.tAB_RAZABindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_RAZADataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_RAZALabel
            // 
            iD_RAZALabel.AutoSize = true;
            iD_RAZALabel.Location = new System.Drawing.Point(54, 22);
            iD_RAZALabel.Name = "iD_RAZALabel";
            iD_RAZALabel.Size = new System.Drawing.Size(53, 13);
            iD_RAZALabel.TabIndex = 0;
            iD_RAZALabel.Text = "ID RAZA:";
            // 
            // iD_TIPODEMASCOTALabel
            // 
            iD_TIPODEMASCOTALabel.AutoSize = true;
            iD_TIPODEMASCOTALabel.Location = new System.Drawing.Point(54, 51);
            iD_TIPODEMASCOTALabel.Name = "iD_TIPODEMASCOTALabel";
            iD_TIPODEMASCOTALabel.Size = new System.Drawing.Size(116, 13);
            iD_TIPODEMASCOTALabel.TabIndex = 2;
            iD_TIPODEMASCOTALabel.Text = "ID TIPODEMASCOTA:";
            // 
            // tIPO_RAZALabel
            // 
            tIPO_RAZALabel.AutoSize = true;
            tIPO_RAZALabel.Location = new System.Drawing.Point(54, 78);
            tIPO_RAZALabel.Name = "tIPO_RAZALabel";
            tIPO_RAZALabel.Size = new System.Drawing.Size(67, 13);
            tIPO_RAZALabel.TabIndex = 4;
            tIPO_RAZALabel.Text = "TIPO RAZA:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(iD_RAZALabel);
            this.panel1.Controls.Add(this.iD_RAZALabel1);
            this.panel1.Controls.Add(iD_TIPODEMASCOTALabel);
            this.panel1.Controls.Add(this.iD_TIPODEMASCOTAComboBox);
            this.panel1.Controls.Add(tIPO_RAZALabel);
            this.panel1.Controls.Add(this.tIPO_RAZATextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(474, 111);
            this.panel1.TabIndex = 0;
            // 
            // iD_RAZALabel1
            // 
            this.iD_RAZALabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAB_RAZABindingSource, "ID_RAZA", true));
            this.iD_RAZALabel1.Location = new System.Drawing.Point(176, 22);
            this.iD_RAZALabel1.Name = "iD_RAZALabel1";
            this.iD_RAZALabel1.Size = new System.Drawing.Size(121, 23);
            this.iD_RAZALabel1.TabIndex = 1;
            this.iD_RAZALabel1.Text = "label1";
            // 
            // tAB_RAZABindingSource
            // 
            this.tAB_RAZABindingSource.DataMember = "TAB_RAZA";
            this.tAB_RAZABindingSource.DataSource = this.dSveterinaria;
            // 
            // dSveterinaria
            // 
            this.dSveterinaria.DataSetName = "DSveterinaria";
            this.dSveterinaria.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iD_TIPODEMASCOTAComboBox
            // 
            this.iD_TIPODEMASCOTAComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tAB_RAZABindingSource, "ID_TIPODEMASCOTA", true));
            this.iD_TIPODEMASCOTAComboBox.DataSource = this.tAB_TIPO_DE_MASCOTABindingSource;
            this.iD_TIPODEMASCOTAComboBox.DisplayMember = "TIPO_DE_MASCOTA";
            this.iD_TIPODEMASCOTAComboBox.FormattingEnabled = true;
            this.iD_TIPODEMASCOTAComboBox.Location = new System.Drawing.Point(176, 48);
            this.iD_TIPODEMASCOTAComboBox.Name = "iD_TIPODEMASCOTAComboBox";
            this.iD_TIPODEMASCOTAComboBox.Size = new System.Drawing.Size(121, 21);
            this.iD_TIPODEMASCOTAComboBox.TabIndex = 3;
            this.iD_TIPODEMASCOTAComboBox.ValueMember = "ID_TIPODEMASCOTA";
            // 
            // tAB_TIPO_DE_MASCOTABindingSource
            // 
            this.tAB_TIPO_DE_MASCOTABindingSource.DataMember = "TAB_TIPO_DE_MASCOTA";
            this.tAB_TIPO_DE_MASCOTABindingSource.DataSource = this.dSveterinaria;
            // 
            // tIPO_RAZATextBox
            // 
            this.tIPO_RAZATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAB_RAZABindingSource, "TIPO_RAZA", true));
            this.tIPO_RAZATextBox.Location = new System.Drawing.Point(176, 75);
            this.tIPO_RAZATextBox.Name = "tIPO_RAZATextBox";
            this.tIPO_RAZATextBox.Size = new System.Drawing.Size(268, 20);
            this.tIPO_RAZATextBox.TabIndex = 5;
            this.tIPO_RAZATextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tIPO_RAZATextBox_KeyPress);
            // 
            // tABTIPODEMASCOTABindingSource
            // 
            this.tABTIPODEMASCOTABindingSource.DataMember = "TAB_TIPO_DE_MASCOTA";
            this.tABTIPODEMASCOTABindingSource.DataSource = this.dSveterinaria;
            // 
            // tAB_RAZATableAdapter
            // 
            this.tAB_RAZATableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.TAB_PERSONATableAdapter = null;
            this.tableAdapterManager.TAB_PROVINCIASTableAdapter = null;
            this.tableAdapterManager.TAB_RAZATableAdapter = this.tAB_RAZATableAdapter;
            this.tableAdapterManager.TAB_REGISTRO_DIARIOTableAdapter = null;
            this.tableAdapterManager.TAB_ROLESTableAdapter = null;
            this.tableAdapterManager.TAB_SALIDA_DE_MASCOTATableAdapter = null;
            this.tableAdapterManager.TAB_TIPO_DE_MASCOTATableAdapter = this.tAB_TIPO_DE_MASCOTATableAdapter;
            this.tableAdapterManager.TAB_USUARIOSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PROYECTO_VETERINARIA.DSveterinariaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tAB_TIPO_DE_MASCOTATableAdapter
            // 
            this.tAB_TIPO_DE_MASCOTATableAdapter.ClearBeforeFill = true;
            // 
            // tAB_RAZABindingNavigator
            // 
            this.tAB_RAZABindingNavigator.AddNewItem = this.btnAgregar;
            this.tAB_RAZABindingNavigator.BindingSource = this.tAB_RAZABindingSource;
            this.tAB_RAZABindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tAB_RAZABindingNavigator.DeleteItem = this.btnEliminar;
            this.tAB_RAZABindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tAB_RAZABindingNavigator.Location = new System.Drawing.Point(0, 111);
            this.tAB_RAZABindingNavigator.MoveFirstItem = null;
            this.tAB_RAZABindingNavigator.MoveLastItem = null;
            this.tAB_RAZABindingNavigator.MoveNextItem = null;
            this.tAB_RAZABindingNavigator.MovePreviousItem = null;
            this.tAB_RAZABindingNavigator.Name = "tAB_RAZABindingNavigator";
            this.tAB_RAZABindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tAB_RAZABindingNavigator.Size = new System.Drawing.Size(474, 25);
            this.tAB_RAZABindingNavigator.TabIndex = 1;
            this.tAB_RAZABindingNavigator.Text = "bindingNavigator1";
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
            this.btnGuardar.Click += new System.EventHandler(this.tAB_RAZABindingNavigatorSaveItem_Click);
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
            // tAB_RAZADataGridView
            // 
            this.tAB_RAZADataGridView.AllowUserToAddRows = false;
            this.tAB_RAZADataGridView.AllowUserToDeleteRows = false;
            this.tAB_RAZADataGridView.AutoGenerateColumns = false;
            this.tAB_RAZADataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tAB_RAZADataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.tAB_RAZADataGridView.DataSource = this.tAB_RAZABindingSource;
            this.tAB_RAZADataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tAB_RAZADataGridView.Location = new System.Drawing.Point(0, 136);
            this.tAB_RAZADataGridView.Name = "tAB_RAZADataGridView";
            this.tAB_RAZADataGridView.ReadOnly = true;
            this.tAB_RAZADataGridView.Size = new System.Drawing.Size(474, 386);
            this.tAB_RAZADataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_RAZA";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ID_TIPODEMASCOTA";
            this.dataGridViewTextBoxColumn2.DataSource = this.tAB_TIPO_DE_MASCOTABindingSource;
            this.dataGridViewTextBoxColumn2.DisplayMember = "TIPO_DE_MASCOTA";
            this.dataGridViewTextBoxColumn2.HeaderText = "TIPO DE MASCOTA";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "ID_TIPODEMASCOTA";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TIPO_RAZA";
            this.dataGridViewTextBoxColumn3.HeaderText = "TIPO DE RAZA";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // FRM_Raza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 522);
            this.Controls.Add(this.tAB_RAZADataGridView);
            this.Controls.Add(this.tAB_RAZABindingNavigator);
            this.Controls.Add(this.panel1);
            this.Name = "FRM_Raza";
            this.Text = "Razas";
            this.Load += new System.EventHandler(this.FRM_Raza_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_RAZABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSveterinaria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_TIPO_DE_MASCOTABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tABTIPODEMASCOTABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_RAZABindingNavigator)).EndInit();
            this.tAB_RAZABindingNavigator.ResumeLayout(false);
            this.tAB_RAZABindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_RAZADataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DSveterinaria dSveterinaria;
        private System.Windows.Forms.BindingSource tAB_RAZABindingSource;
        private DSveterinariaTableAdapters.TAB_RAZATableAdapter tAB_RAZATableAdapter;
        private DSveterinariaTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tAB_RAZABindingNavigator;
        private System.Windows.Forms.ToolStripButton btnAgregar;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.Label iD_RAZALabel1;
        private System.Windows.Forms.ComboBox iD_TIPODEMASCOTAComboBox;
        private System.Windows.Forms.TextBox tIPO_RAZATextBox;
        private System.Windows.Forms.DataGridView tAB_RAZADataGridView;
        private DSveterinariaTableAdapters.TAB_TIPO_DE_MASCOTATableAdapter tAB_TIPO_DE_MASCOTATableAdapter;
        private System.Windows.Forms.BindingSource tABTIPODEMASCOTABindingSource;
        private System.Windows.Forms.BindingSource tAB_TIPO_DE_MASCOTABindingSource;
        private System.Windows.Forms.ToolStripButton btnActualizar;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}