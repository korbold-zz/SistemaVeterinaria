namespace PROYECTO_VETERINARIA
{
    partial class FRM_Roles
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
            System.Windows.Forms.Label iD_ROLLabel;
            System.Windows.Forms.Label rOLLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Roles));
            this.panel1 = new System.Windows.Forms.Panel();
            this.iD_ROLLabel1 = new System.Windows.Forms.Label();
            this.tAB_ROLESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSveterinaria = new PROYECTO_VETERINARIA.DSveterinaria();
            this.rOLTextBox = new System.Windows.Forms.TextBox();
            this.tAB_ROLESTableAdapter = new PROYECTO_VETERINARIA.DSveterinariaTableAdapters.TAB_ROLESTableAdapter();
            this.tableAdapterManager = new PROYECTO_VETERINARIA.DSveterinariaTableAdapters.TableAdapterManager();
            this.tAB_ROLESBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tAB_ROLESDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            iD_ROLLabel = new System.Windows.Forms.Label();
            rOLLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_ROLESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSveterinaria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_ROLESBindingNavigator)).BeginInit();
            this.tAB_ROLESBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_ROLESDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_ROLLabel
            // 
            iD_ROLLabel.AutoSize = true;
            iD_ROLLabel.Location = new System.Drawing.Point(75, 28);
            iD_ROLLabel.Name = "iD_ROLLabel";
            iD_ROLLabel.Size = new System.Drawing.Size(46, 13);
            iD_ROLLabel.TabIndex = 0;
            iD_ROLLabel.Text = "ID ROL:";
            // 
            // rOLLabel
            // 
            rOLLabel.AutoSize = true;
            rOLLabel.Location = new System.Drawing.Point(75, 57);
            rOLLabel.Name = "rOLLabel";
            rOLLabel.Size = new System.Drawing.Size(32, 13);
            rOLLabel.TabIndex = 2;
            rOLLabel.Text = "ROL:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(iD_ROLLabel);
            this.panel1.Controls.Add(this.iD_ROLLabel1);
            this.panel1.Controls.Add(rOLLabel);
            this.panel1.Controls.Add(this.rOLTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 100);
            this.panel1.TabIndex = 0;
            // 
            // iD_ROLLabel1
            // 
            this.iD_ROLLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAB_ROLESBindingSource, "ID_ROL", true));
            this.iD_ROLLabel1.Location = new System.Drawing.Point(127, 28);
            this.iD_ROLLabel1.Name = "iD_ROLLabel1";
            this.iD_ROLLabel1.Size = new System.Drawing.Size(100, 23);
            this.iD_ROLLabel1.TabIndex = 1;
            this.iD_ROLLabel1.Text = "label1";
            // 
            // tAB_ROLESBindingSource
            // 
            this.tAB_ROLESBindingSource.DataMember = "TAB_ROLES";
            this.tAB_ROLESBindingSource.DataSource = this.dSveterinaria;
            // 
            // dSveterinaria
            // 
            this.dSveterinaria.DataSetName = "DSveterinaria";
            this.dSveterinaria.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rOLTextBox
            // 
            this.rOLTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAB_ROLESBindingSource, "ROL", true));
            this.rOLTextBox.Location = new System.Drawing.Point(127, 54);
            this.rOLTextBox.Name = "rOLTextBox";
            this.rOLTextBox.Size = new System.Drawing.Size(100, 20);
            this.rOLTextBox.TabIndex = 3;
            this.rOLTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rOLTextBox_KeyPress);
            // 
            // tAB_ROLESTableAdapter
            // 
            this.tAB_ROLESTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.TAB_ROLESTableAdapter = this.tAB_ROLESTableAdapter;
            this.tableAdapterManager.TAB_SALIDA_DE_MASCOTATableAdapter = null;
            this.tableAdapterManager.TAB_TIPO_DE_MASCOTATableAdapter = null;
            this.tableAdapterManager.TAB_USUARIOSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PROYECTO_VETERINARIA.DSveterinariaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tAB_ROLESBindingNavigator
            // 
            this.tAB_ROLESBindingNavigator.AddNewItem = this.btnAgregar;
            this.tAB_ROLESBindingNavigator.BindingSource = this.tAB_ROLESBindingSource;
            this.tAB_ROLESBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tAB_ROLESBindingNavigator.DeleteItem = this.btnEliminar;
            this.tAB_ROLESBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tAB_ROLESBindingNavigator.Location = new System.Drawing.Point(0, 100);
            this.tAB_ROLESBindingNavigator.MoveFirstItem = null;
            this.tAB_ROLESBindingNavigator.MoveLastItem = null;
            this.tAB_ROLESBindingNavigator.MoveNextItem = null;
            this.tAB_ROLESBindingNavigator.MovePreviousItem = null;
            this.tAB_ROLESBindingNavigator.Name = "tAB_ROLESBindingNavigator";
            this.tAB_ROLESBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tAB_ROLESBindingNavigator.Size = new System.Drawing.Size(279, 25);
            this.tAB_ROLESBindingNavigator.TabIndex = 1;
            this.tAB_ROLESBindingNavigator.Text = "bindingNavigator1";
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
            this.btnGuardar.Click += new System.EventHandler(this.tAB_ROLESBindingNavigatorSaveItem_Click_2);
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
            // tAB_ROLESDataGridView
            // 
            this.tAB_ROLESDataGridView.AllowUserToAddRows = false;
            this.tAB_ROLESDataGridView.AllowUserToDeleteRows = false;
            this.tAB_ROLESDataGridView.AutoGenerateColumns = false;
            this.tAB_ROLESDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tAB_ROLESDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.tAB_ROLESDataGridView.DataSource = this.tAB_ROLESBindingSource;
            this.tAB_ROLESDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tAB_ROLESDataGridView.Location = new System.Drawing.Point(0, 125);
            this.tAB_ROLESDataGridView.Name = "tAB_ROLESDataGridView";
            this.tAB_ROLESDataGridView.ReadOnly = true;
            this.tAB_ROLESDataGridView.Size = new System.Drawing.Size(279, 294);
            this.tAB_ROLESDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_ROL";
            this.dataGridViewTextBoxColumn1.HeaderText = "ROL";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ROL";
            this.dataGridViewTextBoxColumn2.HeaderText = "ROL";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // FRM_Roles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 419);
            this.Controls.Add(this.tAB_ROLESDataGridView);
            this.Controls.Add(this.tAB_ROLESBindingNavigator);
            this.Controls.Add(this.panel1);
            this.Name = "FRM_Roles";
            this.Text = "Roles";
            this.Load += new System.EventHandler(this.FRM_Roles_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_ROLESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSveterinaria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_ROLESBindingNavigator)).EndInit();
            this.tAB_ROLESBindingNavigator.ResumeLayout(false);
            this.tAB_ROLESBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_ROLESDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DSveterinaria dSveterinaria;
        private System.Windows.Forms.BindingSource tAB_ROLESBindingSource;
        private DSveterinariaTableAdapters.TAB_ROLESTableAdapter tAB_ROLESTableAdapter;
        private DSveterinariaTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tAB_ROLESBindingNavigator;
        private System.Windows.Forms.ToolStripButton btnAgregar;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.Label iD_ROLLabel1;
        private System.Windows.Forms.TextBox rOLTextBox;
        private System.Windows.Forms.DataGridView tAB_ROLESDataGridView;
        private System.Windows.Forms.ToolStripButton btnActualizar;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}