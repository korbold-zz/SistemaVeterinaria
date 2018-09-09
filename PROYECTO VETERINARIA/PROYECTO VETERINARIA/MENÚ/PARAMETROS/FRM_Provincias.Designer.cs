namespace PROYECTO_VETERINARIA
{
    partial class FRM_Provincias
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
            System.Windows.Forms.Label iD_PROVINCIALabel;
            System.Windows.Forms.Label pROVINCIALabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Provincias));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.iD_PROVINCIALabel1 = new System.Windows.Forms.Label();
            this.tAB_PROVINCIASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSveterinaria = new PROYECTO_VETERINARIA.DSveterinaria();
            this.pROVINCIATextBox = new System.Windows.Forms.TextBox();
            this.tAB_PROVINCIASTableAdapter = new PROYECTO_VETERINARIA.DSveterinariaTableAdapters.TAB_PROVINCIASTableAdapter();
            this.tableAdapterManager = new PROYECTO_VETERINARIA.DSveterinariaTableAdapters.TableAdapterManager();
            this.tAB_PROVINCIASBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tAB_PROVINCIASDataGridView = new System.Windows.Forms.DataGridView();
            this.visualStyler1 = new SkinSoft.VisualStyler.VisualStyler(this.components);
            this.taB_CANTONESTableAdapter1 = new PROYECTO_VETERINARIA.DSveterinariaTableAdapters.TAB_CANTONESTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            iD_PROVINCIALabel = new System.Windows.Forms.Label();
            pROVINCIALabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_PROVINCIASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSveterinaria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_PROVINCIASBindingNavigator)).BeginInit();
            this.tAB_PROVINCIASBindingNavigator.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_PROVINCIASDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visualStyler1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // iD_PROVINCIALabel
            // 
            iD_PROVINCIALabel.AutoSize = true;
            iD_PROVINCIALabel.Location = new System.Drawing.Point(35, 29);
            iD_PROVINCIALabel.Name = "iD_PROVINCIALabel";
            iD_PROVINCIALabel.Size = new System.Drawing.Size(82, 13);
            iD_PROVINCIALabel.TabIndex = 0;
            iD_PROVINCIALabel.Text = "ID PROVINCIA:";
            // 
            // pROVINCIALabel
            // 
            pROVINCIALabel.AutoSize = true;
            pROVINCIALabel.Location = new System.Drawing.Point(35, 58);
            pROVINCIALabel.Name = "pROVINCIALabel";
            pROVINCIALabel.Size = new System.Drawing.Size(68, 13);
            pROVINCIALabel.TabIndex = 2;
            pROVINCIALabel.Text = "PROVINCIA:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(iD_PROVINCIALabel);
            this.panel1.Controls.Add(this.iD_PROVINCIALabel1);
            this.panel1.Controls.Add(pROVINCIALabel);
            this.panel1.Controls.Add(this.pROVINCIATextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(671, 100);
            this.panel1.TabIndex = 0;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(21, 29);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(173, 20);
            this.txtBuscar.TabIndex = 4;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // iD_PROVINCIALabel1
            // 
            this.iD_PROVINCIALabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAB_PROVINCIASBindingSource, "ID_PROVINCIA", true));
            this.iD_PROVINCIALabel1.Location = new System.Drawing.Point(123, 29);
            this.iD_PROVINCIALabel1.Name = "iD_PROVINCIALabel1";
            this.iD_PROVINCIALabel1.Size = new System.Drawing.Size(100, 23);
            this.iD_PROVINCIALabel1.TabIndex = 1;
            this.iD_PROVINCIALabel1.Text = "label1";
            // 
            // tAB_PROVINCIASBindingSource
            // 
            this.tAB_PROVINCIASBindingSource.DataMember = "TAB_PROVINCIAS";
            this.tAB_PROVINCIASBindingSource.DataSource = this.dSveterinaria;
            // 
            // dSveterinaria
            // 
            this.dSveterinaria.DataSetName = "DSveterinaria";
            this.dSveterinaria.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pROVINCIATextBox
            // 
            this.pROVINCIATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAB_PROVINCIASBindingSource, "PROVINCIA", true));
            this.pROVINCIATextBox.Enabled = false;
            this.pROVINCIATextBox.Location = new System.Drawing.Point(123, 55);
            this.pROVINCIATextBox.Name = "pROVINCIATextBox";
            this.pROVINCIATextBox.Size = new System.Drawing.Size(215, 20);
            this.pROVINCIATextBox.TabIndex = 3;
            this.pROVINCIATextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pROVINCIATextBox_KeyPress);
            // 
            // tAB_PROVINCIASTableAdapter
            // 
            this.tAB_PROVINCIASTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.TAB_PROVINCIASTableAdapter = this.tAB_PROVINCIASTableAdapter;
            this.tableAdapterManager.TAB_RAZATableAdapter = null;
            this.tableAdapterManager.TAB_REGISTRO_DIARIOTableAdapter = null;
            this.tableAdapterManager.TAB_ROLESTableAdapter = null;
            this.tableAdapterManager.TAB_SALIDA_DE_MASCOTATableAdapter = null;
            this.tableAdapterManager.TAB_TIPO_DE_MASCOTATableAdapter = null;
            this.tableAdapterManager.TAB_USUARIOSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PROYECTO_VETERINARIA.DSveterinariaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tAB_PROVINCIASBindingNavigator
            // 
            this.tAB_PROVINCIASBindingNavigator.AddNewItem = this.btnAgregar;
            this.tAB_PROVINCIASBindingNavigator.BindingSource = this.tAB_PROVINCIASBindingSource;
            this.tAB_PROVINCIASBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tAB_PROVINCIASBindingNavigator.DeleteItem = this.btnEliminar;
            this.tAB_PROVINCIASBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tAB_PROVINCIASBindingNavigator.Location = new System.Drawing.Point(0, 100);
            this.tAB_PROVINCIASBindingNavigator.MoveFirstItem = null;
            this.tAB_PROVINCIASBindingNavigator.MoveLastItem = null;
            this.tAB_PROVINCIASBindingNavigator.MoveNextItem = null;
            this.tAB_PROVINCIASBindingNavigator.MovePreviousItem = null;
            this.tAB_PROVINCIASBindingNavigator.Name = "tAB_PROVINCIASBindingNavigator";
            this.tAB_PROVINCIASBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tAB_PROVINCIASBindingNavigator.Size = new System.Drawing.Size(671, 25);
            this.tAB_PROVINCIASBindingNavigator.TabIndex = 1;
            this.tAB_PROVINCIASBindingNavigator.Text = "bindingNavigator1";
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
            this.btnGuardar.Click += new System.EventHandler(this.tAB_PROVINCIASBindingNavigatorSaveItem_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(23, 22);
            this.btnActualizar.Text = "toolStripButton2";
            this.btnActualizar.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(23, 22);
            this.btnCancelar.Text = "toolStripBtn_Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tAB_PROVINCIASDataGridView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 125);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(671, 272);
            this.panel2.TabIndex = 2;
            // 
            // tAB_PROVINCIASDataGridView
            // 
            this.tAB_PROVINCIASDataGridView.AllowUserToAddRows = false;
            this.tAB_PROVINCIASDataGridView.AllowUserToDeleteRows = false;
            this.tAB_PROVINCIASDataGridView.AutoGenerateColumns = false;
            this.tAB_PROVINCIASDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tAB_PROVINCIASDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.tAB_PROVINCIASDataGridView.DataSource = this.tAB_PROVINCIASBindingSource;
            this.tAB_PROVINCIASDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tAB_PROVINCIASDataGridView.Location = new System.Drawing.Point(0, 0);
            this.tAB_PROVINCIASDataGridView.Name = "tAB_PROVINCIASDataGridView";
            this.tAB_PROVINCIASDataGridView.ReadOnly = true;
            this.tAB_PROVINCIASDataGridView.Size = new System.Drawing.Size(671, 272);
            this.tAB_PROVINCIASDataGridView.TabIndex = 0;
            // 
            // visualStyler1
            // 
            this.visualStyler1.HostForm = this;
            this.visualStyler1.License = ((SkinSoft.VisualStyler.Licensing.VisualStylerLicense)(resources.GetObject("visualStyler1.License")));
            this.visualStyler1.LoadVisualStyle(null, "OSX (Panther).vssf");
            // 
            // taB_CANTONESTableAdapter1
            // 
            this.taB_CANTONESTableAdapter1.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBuscar);
            this.groupBox1.Location = new System.Drawing.Point(388, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 74);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_PROVINCIA";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PROVINCIA";
            this.dataGridViewTextBoxColumn2.HeaderText = "PROVINCIA";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // FRM_Provincias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 397);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tAB_PROVINCIASBindingNavigator);
            this.Controls.Add(this.panel1);
            this.Name = "FRM_Provincias";
            this.Text = "Provincias";
            this.Load += new System.EventHandler(this.FRM_Provincias_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_PROVINCIASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSveterinaria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_PROVINCIASBindingNavigator)).EndInit();
            this.tAB_PROVINCIASBindingNavigator.ResumeLayout(false);
            this.tAB_PROVINCIASBindingNavigator.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tAB_PROVINCIASDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visualStyler1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DSveterinaria dSveterinaria;
        private System.Windows.Forms.BindingSource tAB_PROVINCIASBindingSource;
        private DSveterinariaTableAdapters.TAB_PROVINCIASTableAdapter tAB_PROVINCIASTableAdapter;
        private DSveterinariaTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tAB_PROVINCIASBindingNavigator;
        private System.Windows.Forms.ToolStripButton btnAgregar;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.Label iD_PROVINCIALabel1;
        private System.Windows.Forms.TextBox pROVINCIATextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.ToolStripButton btnActualizar;
        private SkinSoft.VisualStyler.VisualStyler visualStyler1;
        private System.Windows.Forms.DataGridView tAB_PROVINCIASDataGridView;
        private System.Windows.Forms.TextBox txtBuscar;
        private DSveterinariaTableAdapters.TAB_CANTONESTableAdapter taB_CANTONESTableAdapter1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}