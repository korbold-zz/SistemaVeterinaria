namespace PROYECTO_VETERINARIA
{
    partial class FRM_Medicamentos
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
            System.Windows.Forms.Label iD_MEDICAMENTOLabel;
            System.Windows.Forms.Label nOMBRELabel;
            System.Windows.Forms.Label pRECIOLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Medicamentos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.iD_MEDICAMENTOLabel1 = new System.Windows.Forms.Label();
            this.tAB_MEDICAMENTOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSveterinaria = new PROYECTO_VETERINARIA.DSveterinaria();
            this.nOMBRETextBox = new System.Windows.Forms.TextBox();
            this.pRECIOTextBox = new System.Windows.Forms.TextBox();
            this.tAB_MEDICAMENTOSTableAdapter = new PROYECTO_VETERINARIA.DSveterinariaTableAdapters.TAB_MEDICAMENTOSTableAdapter();
            this.tableAdapterManager = new PROYECTO_VETERINARIA.DSveterinariaTableAdapters.TableAdapterManager();
            this.tAB_MEDICAMENTOSBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.btnAgregar = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnActualizar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.tAB_MEDICAMENTOSDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visualStyler1 = new SkinSoft.VisualStyler.VisualStyler(this.components);
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            iD_MEDICAMENTOLabel = new System.Windows.Forms.Label();
            nOMBRELabel = new System.Windows.Forms.Label();
            pRECIOLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_MEDICAMENTOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSveterinaria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_MEDICAMENTOSBindingNavigator)).BeginInit();
            this.tAB_MEDICAMENTOSBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_MEDICAMENTOSDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visualStyler1)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_MEDICAMENTOLabel
            // 
            iD_MEDICAMENTOLabel.AutoSize = true;
            iD_MEDICAMENTOLabel.Location = new System.Drawing.Point(39, 29);
            iD_MEDICAMENTOLabel.Name = "iD_MEDICAMENTOLabel";
            iD_MEDICAMENTOLabel.Size = new System.Drawing.Size(104, 13);
            iD_MEDICAMENTOLabel.TabIndex = 0;
            iD_MEDICAMENTOLabel.Text = "ID MEDICAMENTO:";
            // 
            // nOMBRELabel
            // 
            nOMBRELabel.AutoSize = true;
            nOMBRELabel.Location = new System.Drawing.Point(39, 58);
            nOMBRELabel.Name = "nOMBRELabel";
            nOMBRELabel.Size = new System.Drawing.Size(57, 13);
            nOMBRELabel.TabIndex = 2;
            nOMBRELabel.Text = "NOMBRE:";
            // 
            // pRECIOLabel
            // 
            pRECIOLabel.AutoSize = true;
            pRECIOLabel.Location = new System.Drawing.Point(39, 84);
            pRECIOLabel.Name = "pRECIOLabel";
            pRECIOLabel.Size = new System.Drawing.Size(50, 13);
            pRECIOLabel.TabIndex = 4;
            pRECIOLabel.Text = "PRECIO:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(iD_MEDICAMENTOLabel);
            this.panel1.Controls.Add(this.iD_MEDICAMENTOLabel1);
            this.panel1.Controls.Add(nOMBRELabel);
            this.panel1.Controls.Add(this.nOMBRETextBox);
            this.panel1.Controls.Add(pRECIOLabel);
            this.panel1.Controls.Add(this.pRECIOTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 129);
            this.panel1.TabIndex = 0;
            // 
            // iD_MEDICAMENTOLabel1
            // 
            this.iD_MEDICAMENTOLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAB_MEDICAMENTOSBindingSource, "ID_MEDICAMENTO", true));
            this.iD_MEDICAMENTOLabel1.Location = new System.Drawing.Point(149, 29);
            this.iD_MEDICAMENTOLabel1.Name = "iD_MEDICAMENTOLabel1";
            this.iD_MEDICAMENTOLabel1.Size = new System.Drawing.Size(100, 23);
            this.iD_MEDICAMENTOLabel1.TabIndex = 1;
            this.iD_MEDICAMENTOLabel1.Text = "label1";
            // 
            // tAB_MEDICAMENTOSBindingSource
            // 
            this.tAB_MEDICAMENTOSBindingSource.DataMember = "TAB_MEDICAMENTOS";
            this.tAB_MEDICAMENTOSBindingSource.DataSource = this.dSveterinaria;
            // 
            // dSveterinaria
            // 
            this.dSveterinaria.DataSetName = "DSveterinaria";
            this.dSveterinaria.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nOMBRETextBox
            // 
            this.nOMBRETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAB_MEDICAMENTOSBindingSource, "NOMBRE", true));
            this.nOMBRETextBox.Location = new System.Drawing.Point(149, 55);
            this.nOMBRETextBox.Name = "nOMBRETextBox";
            this.nOMBRETextBox.Size = new System.Drawing.Size(100, 20);
            this.nOMBRETextBox.TabIndex = 3;
            // 
            // pRECIOTextBox
            // 
            this.pRECIOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAB_MEDICAMENTOSBindingSource, "PRECIO", true));
            this.pRECIOTextBox.Location = new System.Drawing.Point(149, 81);
            this.pRECIOTextBox.Name = "pRECIOTextBox";
            this.pRECIOTextBox.Size = new System.Drawing.Size(100, 20);
            this.pRECIOTextBox.TabIndex = 5;
            this.pRECIOTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pRECIOTextBox_KeyPress);
            // 
            // tAB_MEDICAMENTOSTableAdapter
            // 
            this.tAB_MEDICAMENTOSTableAdapter.ClearBeforeFill = true;
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
            // tAB_MEDICAMENTOSBindingNavigator
            // 
            this.tAB_MEDICAMENTOSBindingNavigator.AddNewItem = this.btnAgregar;
            this.tAB_MEDICAMENTOSBindingNavigator.BindingSource = this.tAB_MEDICAMENTOSBindingSource;
            this.tAB_MEDICAMENTOSBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tAB_MEDICAMENTOSBindingNavigator.DeleteItem = null;
            this.tAB_MEDICAMENTOSBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tAB_MEDICAMENTOSBindingNavigator.Location = new System.Drawing.Point(0, 129);
            this.tAB_MEDICAMENTOSBindingNavigator.MoveFirstItem = null;
            this.tAB_MEDICAMENTOSBindingNavigator.MoveLastItem = null;
            this.tAB_MEDICAMENTOSBindingNavigator.MoveNextItem = null;
            this.tAB_MEDICAMENTOSBindingNavigator.MovePreviousItem = null;
            this.tAB_MEDICAMENTOSBindingNavigator.Name = "tAB_MEDICAMENTOSBindingNavigator";
            this.tAB_MEDICAMENTOSBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tAB_MEDICAMENTOSBindingNavigator.Size = new System.Drawing.Size(380, 25);
            this.tAB_MEDICAMENTOSBindingNavigator.TabIndex = 1;
            this.tAB_MEDICAMENTOSBindingNavigator.Text = "bindingNavigator1";
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
            this.btnGuardar.Click += new System.EventHandler(this.tAB_MEDICAMENTOSBindingNavigatorSaveItem_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(23, 22);
            this.btnActualizar.Text = "toolStripButton1";
            this.btnActualizar.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(23, 22);
            this.btnCancelar.Text = "toolStripButton2";
            this.btnCancelar.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // tAB_MEDICAMENTOSDataGridView
            // 
            this.tAB_MEDICAMENTOSDataGridView.AllowUserToAddRows = false;
            this.tAB_MEDICAMENTOSDataGridView.AllowUserToDeleteRows = false;
            this.tAB_MEDICAMENTOSDataGridView.AutoGenerateColumns = false;
            this.tAB_MEDICAMENTOSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tAB_MEDICAMENTOSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.tAB_MEDICAMENTOSDataGridView.DataSource = this.tAB_MEDICAMENTOSBindingSource;
            this.tAB_MEDICAMENTOSDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tAB_MEDICAMENTOSDataGridView.Location = new System.Drawing.Point(0, 154);
            this.tAB_MEDICAMENTOSDataGridView.Name = "tAB_MEDICAMENTOSDataGridView";
            this.tAB_MEDICAMENTOSDataGridView.ReadOnly = true;
            this.tAB_MEDICAMENTOSDataGridView.Size = new System.Drawing.Size(380, 334);
            this.tAB_MEDICAMENTOSDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_MEDICAMENTO";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NOMBRE";
            this.dataGridViewTextBoxColumn2.HeaderText = "NOMBRE";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PRECIO";
            this.dataGridViewTextBoxColumn3.HeaderText = "PRECIO";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // visualStyler1
            // 
            this.visualStyler1.HookVisualStyles = true;
            this.visualStyler1.HostForm = this;
            this.visualStyler1.License = ((SkinSoft.VisualStyler.Licensing.VisualStylerLicense)(resources.GetObject("visualStyler1.License")));
            this.visualStyler1.LoadVisualStyle(null, "OSX (Panther).vssf");
            // 
            // btnEliminar
            // 
            this.btnEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(23, 22);
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // FRM_Medicamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 488);
            this.Controls.Add(this.tAB_MEDICAMENTOSDataGridView);
            this.Controls.Add(this.tAB_MEDICAMENTOSBindingNavigator);
            this.Controls.Add(this.panel1);
            this.Name = "FRM_Medicamentos";
            this.Text = "FRM_Medicamentos";
            this.Load += new System.EventHandler(this.FRM_Medicamentos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_MEDICAMENTOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSveterinaria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_MEDICAMENTOSBindingNavigator)).EndInit();
            this.tAB_MEDICAMENTOSBindingNavigator.ResumeLayout(false);
            this.tAB_MEDICAMENTOSBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_MEDICAMENTOSDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visualStyler1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DSveterinaria dSveterinaria;
        private System.Windows.Forms.BindingSource tAB_MEDICAMENTOSBindingSource;
        private DSveterinariaTableAdapters.TAB_MEDICAMENTOSTableAdapter tAB_MEDICAMENTOSTableAdapter;
        private DSveterinariaTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tAB_MEDICAMENTOSBindingNavigator;
        private System.Windows.Forms.ToolStripButton btnAgregar;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.Label iD_MEDICAMENTOLabel1;
        private System.Windows.Forms.TextBox nOMBRETextBox;
        private System.Windows.Forms.TextBox pRECIOTextBox;
        private System.Windows.Forms.DataGridView tAB_MEDICAMENTOSDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private SkinSoft.VisualStyler.VisualStyler visualStyler1;
        private System.Windows.Forms.ToolStripButton btnActualizar;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.ToolStripButton btnEliminar;
    }
}