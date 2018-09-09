namespace PROYECTO_VETERINARIA
{
    partial class FRM_TipoMascota
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
            System.Windows.Forms.Label tIPO_DE_MASCOTALabel;
            System.Windows.Forms.Label iD_TIPODEMASCOTALabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_TipoMascota));
            this.panel1 = new System.Windows.Forms.Panel();
            this.iD_TIPODEMASCOTALabel1 = new System.Windows.Forms.Label();
            this.tAB_TIPO_DE_MASCOTABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSveterinaria = new PROYECTO_VETERINARIA.DSveterinaria();
            this.tIPO_DE_MASCOTATextBox = new System.Windows.Forms.TextBox();
            this.tAB_TIPO_DE_MASCOTATableAdapter = new PROYECTO_VETERINARIA.DSveterinariaTableAdapters.TAB_TIPO_DE_MASCOTATableAdapter();
            this.tableAdapterManager = new PROYECTO_VETERINARIA.DSveterinariaTableAdapters.TableAdapterManager();
            this.tAB_TIPO_DE_MASCOTABindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tAB_TIPO_DE_MASCOTADataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            tIPO_DE_MASCOTALabel = new System.Windows.Forms.Label();
            iD_TIPODEMASCOTALabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_TIPO_DE_MASCOTABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSveterinaria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_TIPO_DE_MASCOTABindingNavigator)).BeginInit();
            this.tAB_TIPO_DE_MASCOTABindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_TIPO_DE_MASCOTADataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tIPO_DE_MASCOTALabel
            // 
            tIPO_DE_MASCOTALabel.AutoSize = true;
            tIPO_DE_MASCOTALabel.Location = new System.Drawing.Point(27, 54);
            tIPO_DE_MASCOTALabel.Name = "tIPO_DE_MASCOTALabel";
            tIPO_DE_MASCOTALabel.Size = new System.Drawing.Size(108, 13);
            tIPO_DE_MASCOTALabel.TabIndex = 2;
            tIPO_DE_MASCOTALabel.Text = "TIPO DE MASCOTA:";
            // 
            // iD_TIPODEMASCOTALabel
            // 
            iD_TIPODEMASCOTALabel.AutoSize = true;
            iD_TIPODEMASCOTALabel.Location = new System.Drawing.Point(27, 24);
            iD_TIPODEMASCOTALabel.Name = "iD_TIPODEMASCOTALabel";
            iD_TIPODEMASCOTALabel.Size = new System.Drawing.Size(116, 13);
            iD_TIPODEMASCOTALabel.TabIndex = 3;
            iD_TIPODEMASCOTALabel.Text = "ID TIPODEMASCOTA:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(iD_TIPODEMASCOTALabel);
            this.panel1.Controls.Add(this.iD_TIPODEMASCOTALabel1);
            this.panel1.Controls.Add(tIPO_DE_MASCOTALabel);
            this.panel1.Controls.Add(this.tIPO_DE_MASCOTATextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 100);
            this.panel1.TabIndex = 0;
            // 
            // iD_TIPODEMASCOTALabel1
            // 
            this.iD_TIPODEMASCOTALabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAB_TIPO_DE_MASCOTABindingSource, "ID_TIPODEMASCOTA", true));
            this.iD_TIPODEMASCOTALabel1.Location = new System.Drawing.Point(149, 24);
            this.iD_TIPODEMASCOTALabel1.Name = "iD_TIPODEMASCOTALabel1";
            this.iD_TIPODEMASCOTALabel1.Size = new System.Drawing.Size(100, 23);
            this.iD_TIPODEMASCOTALabel1.TabIndex = 4;
            this.iD_TIPODEMASCOTALabel1.Text = "label1";
            // 
            // tAB_TIPO_DE_MASCOTABindingSource
            // 
            this.tAB_TIPO_DE_MASCOTABindingSource.DataMember = "TAB_TIPO_DE_MASCOTA";
            this.tAB_TIPO_DE_MASCOTABindingSource.DataSource = this.dSveterinaria;
            // 
            // dSveterinaria
            // 
            this.dSveterinaria.DataSetName = "DSveterinaria";
            this.dSveterinaria.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tIPO_DE_MASCOTATextBox
            // 
            this.tIPO_DE_MASCOTATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAB_TIPO_DE_MASCOTABindingSource, "TIPO_DE_MASCOTA", true));
            this.tIPO_DE_MASCOTATextBox.Location = new System.Drawing.Point(149, 51);
            this.tIPO_DE_MASCOTATextBox.Name = "tIPO_DE_MASCOTATextBox";
            this.tIPO_DE_MASCOTATextBox.Size = new System.Drawing.Size(100, 20);
            this.tIPO_DE_MASCOTATextBox.TabIndex = 3;
            this.tIPO_DE_MASCOTATextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tIPO_DE_MASCOTATextBox_KeyPress);
            // 
            // tAB_TIPO_DE_MASCOTATableAdapter
            // 
            this.tAB_TIPO_DE_MASCOTATableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.TAB_RAZATableAdapter = null;
            this.tableAdapterManager.TAB_REGISTRO_DIARIOTableAdapter = null;
            this.tableAdapterManager.TAB_ROLESTableAdapter = null;
            this.tableAdapterManager.TAB_SALIDA_DE_MASCOTATableAdapter = null;
            this.tableAdapterManager.TAB_TIPO_DE_MASCOTATableAdapter = this.tAB_TIPO_DE_MASCOTATableAdapter;
            this.tableAdapterManager.TAB_USUARIOSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PROYECTO_VETERINARIA.DSveterinariaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tAB_TIPO_DE_MASCOTABindingNavigator
            // 
            this.tAB_TIPO_DE_MASCOTABindingNavigator.AddNewItem = this.btnAgregar;
            this.tAB_TIPO_DE_MASCOTABindingNavigator.BindingSource = this.tAB_TIPO_DE_MASCOTABindingSource;
            this.tAB_TIPO_DE_MASCOTABindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tAB_TIPO_DE_MASCOTABindingNavigator.DeleteItem = this.btnEliminar;
            this.tAB_TIPO_DE_MASCOTABindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tAB_TIPO_DE_MASCOTABindingNavigator.Location = new System.Drawing.Point(0, 100);
            this.tAB_TIPO_DE_MASCOTABindingNavigator.MoveFirstItem = null;
            this.tAB_TIPO_DE_MASCOTABindingNavigator.MoveLastItem = null;
            this.tAB_TIPO_DE_MASCOTABindingNavigator.MoveNextItem = null;
            this.tAB_TIPO_DE_MASCOTABindingNavigator.MovePreviousItem = null;
            this.tAB_TIPO_DE_MASCOTABindingNavigator.Name = "tAB_TIPO_DE_MASCOTABindingNavigator";
            this.tAB_TIPO_DE_MASCOTABindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tAB_TIPO_DE_MASCOTABindingNavigator.Size = new System.Drawing.Size(330, 25);
            this.tAB_TIPO_DE_MASCOTABindingNavigator.TabIndex = 1;
            this.tAB_TIPO_DE_MASCOTABindingNavigator.Text = "bindingNavigator1";
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
            this.btnGuardar.Click += new System.EventHandler(this.tAB_TIPO_DE_MASCOTABindingNavigatorSaveItem_Click);
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
            // tAB_TIPO_DE_MASCOTADataGridView
            // 
            this.tAB_TIPO_DE_MASCOTADataGridView.AllowUserToAddRows = false;
            this.tAB_TIPO_DE_MASCOTADataGridView.AllowUserToDeleteRows = false;
            this.tAB_TIPO_DE_MASCOTADataGridView.AutoGenerateColumns = false;
            this.tAB_TIPO_DE_MASCOTADataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tAB_TIPO_DE_MASCOTADataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.tAB_TIPO_DE_MASCOTADataGridView.DataSource = this.tAB_TIPO_DE_MASCOTABindingSource;
            this.tAB_TIPO_DE_MASCOTADataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tAB_TIPO_DE_MASCOTADataGridView.Location = new System.Drawing.Point(0, 125);
            this.tAB_TIPO_DE_MASCOTADataGridView.Name = "tAB_TIPO_DE_MASCOTADataGridView";
            this.tAB_TIPO_DE_MASCOTADataGridView.ReadOnly = true;
            this.tAB_TIPO_DE_MASCOTADataGridView.Size = new System.Drawing.Size(330, 410);
            this.tAB_TIPO_DE_MASCOTADataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_TIPODEMASCOTA";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TIPO_DE_MASCOTA";
            this.dataGridViewTextBoxColumn2.HeaderText = "TIPO DE MASCOTA";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // FRM_TipoMascota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 535);
            this.Controls.Add(this.tAB_TIPO_DE_MASCOTADataGridView);
            this.Controls.Add(this.tAB_TIPO_DE_MASCOTABindingNavigator);
            this.Controls.Add(this.panel1);
            this.Name = "FRM_TipoMascota";
            this.Text = "FRM_TipoMascota";
            this.Load += new System.EventHandler(this.FRM_TipoMascota_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_TIPO_DE_MASCOTABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSveterinaria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_TIPO_DE_MASCOTABindingNavigator)).EndInit();
            this.tAB_TIPO_DE_MASCOTABindingNavigator.ResumeLayout(false);
            this.tAB_TIPO_DE_MASCOTABindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_TIPO_DE_MASCOTADataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DSveterinaria dSveterinaria;
        private System.Windows.Forms.BindingSource tAB_TIPO_DE_MASCOTABindingSource;
        private DSveterinariaTableAdapters.TAB_TIPO_DE_MASCOTATableAdapter tAB_TIPO_DE_MASCOTATableAdapter;
        private DSveterinariaTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tAB_TIPO_DE_MASCOTABindingNavigator;
        private System.Windows.Forms.ToolStripButton btnAgregar;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.TextBox tIPO_DE_MASCOTATextBox;
        private System.Windows.Forms.Label iD_TIPODEMASCOTALabel1;
        private System.Windows.Forms.DataGridView tAB_TIPO_DE_MASCOTADataGridView;
        private System.Windows.Forms.ToolStripButton btnActualizar;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}