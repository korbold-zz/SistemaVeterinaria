namespace PROYECTO_VETERINARIA
{
    partial class FRM_Cliente
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
            System.Windows.Forms.Label fECHA_REGISTROLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Cliente));
            this.panel1 = new System.Windows.Forms.Panel();
            this.iD_PERSONAComboBox = new System.Windows.Forms.ComboBox();
            this.tAB_CLIENTESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSveterinaria = new PROYECTO_VETERINARIA.DSveterinaria();
            this.tAB_PERSONABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fECHA_REGISTRODateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tAB_CLIENTESTableAdapter = new PROYECTO_VETERINARIA.DSveterinariaTableAdapters.TAB_CLIENTESTableAdapter();
            this.tableAdapterManager = new PROYECTO_VETERINARIA.DSveterinariaTableAdapters.TableAdapterManager();
            this.tAB_CLIENTESBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tAB_CLIENTESBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tAB_PERSONATableAdapter = new PROYECTO_VETERINARIA.DSveterinariaTableAdapters.TAB_PERSONATableAdapter();
            this.fillBy_UNION_PERSONA_CLIENTEToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillBy_UNION_PERSONA_CLIENTEToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.tAB_CLIENTESDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            iD_PERSONALabel = new System.Windows.Forms.Label();
            fECHA_REGISTROLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_CLIENTESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSveterinaria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_PERSONABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_CLIENTESBindingNavigator)).BeginInit();
            this.tAB_CLIENTESBindingNavigator.SuspendLayout();
            this.fillBy_UNION_PERSONA_CLIENTEToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_CLIENTESDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_PERSONALabel
            // 
            iD_PERSONALabel.AutoSize = true;
            iD_PERSONALabel.Location = new System.Drawing.Point(46, 31);
            iD_PERSONALabel.Name = "iD_PERSONALabel";
            iD_PERSONALabel.Size = new System.Drawing.Size(76, 13);
            iD_PERSONALabel.TabIndex = 0;
            iD_PERSONALabel.Text = "ID PERSONA:";
            // 
            // fECHA_REGISTROLabel
            // 
            fECHA_REGISTROLabel.AutoSize = true;
            fECHA_REGISTROLabel.Location = new System.Drawing.Point(46, 59);
            fECHA_REGISTROLabel.Name = "fECHA_REGISTROLabel";
            fECHA_REGISTROLabel.Size = new System.Drawing.Size(104, 13);
            fECHA_REGISTROLabel.TabIndex = 2;
            fECHA_REGISTROLabel.Text = "FECHA REGISTRO:";
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
            this.panel1.Size = new System.Drawing.Size(404, 100);
            this.panel1.TabIndex = 0;
            // 
            // iD_PERSONAComboBox
            // 
            this.iD_PERSONAComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tAB_CLIENTESBindingSource, "ID_PERSONA", true));
            this.iD_PERSONAComboBox.DataSource = this.tAB_PERSONABindingSource;
            this.iD_PERSONAComboBox.DisplayMember = "CEDULA";
            this.iD_PERSONAComboBox.FormattingEnabled = true;
            this.iD_PERSONAComboBox.Location = new System.Drawing.Point(156, 28);
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
            this.fECHA_REGISTRODateTimePicker.Location = new System.Drawing.Point(156, 55);
            this.fECHA_REGISTRODateTimePicker.Name = "fECHA_REGISTRODateTimePicker";
            this.fECHA_REGISTRODateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fECHA_REGISTRODateTimePicker.TabIndex = 3;
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
            // tAB_CLIENTESBindingNavigator
            // 
            this.tAB_CLIENTESBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tAB_CLIENTESBindingNavigator.BindingSource = this.tAB_CLIENTESBindingSource;
            this.tAB_CLIENTESBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tAB_CLIENTESBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tAB_CLIENTESBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tAB_CLIENTESBindingNavigatorSaveItem});
            this.tAB_CLIENTESBindingNavigator.Location = new System.Drawing.Point(0, 100);
            this.tAB_CLIENTESBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tAB_CLIENTESBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tAB_CLIENTESBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tAB_CLIENTESBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tAB_CLIENTESBindingNavigator.Name = "tAB_CLIENTESBindingNavigator";
            this.tAB_CLIENTESBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tAB_CLIENTESBindingNavigator.Size = new System.Drawing.Size(404, 25);
            this.tAB_CLIENTESBindingNavigator.TabIndex = 1;
            this.tAB_CLIENTESBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
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
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tAB_CLIENTESBindingNavigatorSaveItem
            // 
            this.tAB_CLIENTESBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tAB_CLIENTESBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tAB_CLIENTESBindingNavigatorSaveItem.Image")));
            this.tAB_CLIENTESBindingNavigatorSaveItem.Name = "tAB_CLIENTESBindingNavigatorSaveItem";
            this.tAB_CLIENTESBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tAB_CLIENTESBindingNavigatorSaveItem.Text = "Guardar datos";
            this.tAB_CLIENTESBindingNavigatorSaveItem.Click += new System.EventHandler(this.tAB_CLIENTESBindingNavigatorSaveItem_Click);
            // 
            // tAB_PERSONATableAdapter
            // 
            this.tAB_PERSONATableAdapter.ClearBeforeFill = true;
            // 
            // fillBy_UNION_PERSONA_CLIENTEToolStrip
            // 
            this.fillBy_UNION_PERSONA_CLIENTEToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillBy_UNION_PERSONA_CLIENTEToolStripButton});
            this.fillBy_UNION_PERSONA_CLIENTEToolStrip.Location = new System.Drawing.Point(0, 125);
            this.fillBy_UNION_PERSONA_CLIENTEToolStrip.Name = "fillBy_UNION_PERSONA_CLIENTEToolStrip";
            this.fillBy_UNION_PERSONA_CLIENTEToolStrip.Size = new System.Drawing.Size(404, 25);
            this.fillBy_UNION_PERSONA_CLIENTEToolStrip.TabIndex = 2;
            this.fillBy_UNION_PERSONA_CLIENTEToolStrip.Text = "fillBy_UNION_PERSONA_CLIENTEToolStrip";
            // 
            // fillBy_UNION_PERSONA_CLIENTEToolStripButton
            // 
            this.fillBy_UNION_PERSONA_CLIENTEToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillBy_UNION_PERSONA_CLIENTEToolStripButton.Name = "fillBy_UNION_PERSONA_CLIENTEToolStripButton";
            this.fillBy_UNION_PERSONA_CLIENTEToolStripButton.Size = new System.Drawing.Size(23, 23);
            this.fillBy_UNION_PERSONA_CLIENTEToolStripButton.Text = "FillBy_UNION_PERSONA_CLIENTE";
            this.fillBy_UNION_PERSONA_CLIENTEToolStripButton.Click += new System.EventHandler(this.fillBy_UNION_PERSONA_CLIENTEToolStripButton_Click);
            // 
            // tAB_CLIENTESDataGridView
            // 
            this.tAB_CLIENTESDataGridView.AutoGenerateColumns = false;
            this.tAB_CLIENTESDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tAB_CLIENTESDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.tAB_CLIENTESDataGridView.DataSource = this.tAB_CLIENTESBindingSource;
            this.tAB_CLIENTESDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tAB_CLIENTESDataGridView.Location = new System.Drawing.Point(0, 150);
            this.tAB_CLIENTESDataGridView.Name = "tAB_CLIENTESDataGridView";
            this.tAB_CLIENTESDataGridView.Size = new System.Drawing.Size(404, 289);
            this.tAB_CLIENTESDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_PERSONA";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_PERSONA";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FECHA_REGISTRO";
            this.dataGridViewTextBoxColumn2.HeaderText = "FECHA_REGISTRO";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // FRM_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 439);
            this.Controls.Add(this.tAB_CLIENTESDataGridView);
            this.Controls.Add(this.fillBy_UNION_PERSONA_CLIENTEToolStrip);
            this.Controls.Add(this.tAB_CLIENTESBindingNavigator);
            this.Controls.Add(this.panel1);
            this.Name = "FRM_Cliente";
            this.Text = "FRM_Cliente";
            this.Load += new System.EventHandler(this.FRM_Cliente_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_CLIENTESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSveterinaria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_PERSONABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_CLIENTESBindingNavigator)).EndInit();
            this.tAB_CLIENTESBindingNavigator.ResumeLayout(false);
            this.tAB_CLIENTESBindingNavigator.PerformLayout();
            this.fillBy_UNION_PERSONA_CLIENTEToolStrip.ResumeLayout(false);
            this.fillBy_UNION_PERSONA_CLIENTEToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_CLIENTESDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DSveterinaria dSveterinaria;
        private System.Windows.Forms.BindingSource tAB_CLIENTESBindingSource;
        private DSveterinariaTableAdapters.TAB_CLIENTESTableAdapter tAB_CLIENTESTableAdapter;
        private DSveterinariaTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tAB_CLIENTESBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tAB_CLIENTESBindingNavigatorSaveItem;
        private System.Windows.Forms.ComboBox iD_PERSONAComboBox;
        private System.Windows.Forms.DateTimePicker fECHA_REGISTRODateTimePicker;
        private System.Windows.Forms.BindingSource tAB_PERSONABindingSource;
        private DSveterinariaTableAdapters.TAB_PERSONATableAdapter tAB_PERSONATableAdapter;
        private System.Windows.Forms.ToolStrip fillBy_UNION_PERSONA_CLIENTEToolStrip;
        private System.Windows.Forms.ToolStripButton fillBy_UNION_PERSONA_CLIENTEToolStripButton;
        private System.Windows.Forms.DataGridView tAB_CLIENTESDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}