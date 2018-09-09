namespace PROYECTO_VETERINARIA
{
    partial class FRM_RegistroDiario
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
            System.Windows.Forms.Label iD_REGISTRO_DIARIOLabel;
            System.Windows.Forms.Label iD_FICHA_INGRESOLabel;
            System.Windows.Forms.Label fECHALabel;
            System.Windows.Forms.Label dIAGNOSTICOLabel;
            System.Windows.Forms.Label oBSERVACIONLabel;
            System.Windows.Forms.Label pESOLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_RegistroDiario));
            this.panel1 = new System.Windows.Forms.Panel();
            this.iD_REGISTRO_DIARIOLabel1 = new System.Windows.Forms.Label();
            this.tAB_REGISTRO_DIARIOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSveterinaria = new PROYECTO_VETERINARIA.DSveterinaria();
            this.iD_FICHA_INGRESOComboBox = new System.Windows.Forms.ComboBox();
            this.fECHADateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dIAGNOSTICOTextBox = new System.Windows.Forms.TextBox();
            this.oBSERVACIONTextBox = new System.Windows.Forms.TextBox();
            this.pESOTextBox = new System.Windows.Forms.TextBox();
            this.tAB_REGISTRO_DIARIOTableAdapter = new PROYECTO_VETERINARIA.DSveterinariaTableAdapters.TAB_REGISTRO_DIARIOTableAdapter();
            this.tableAdapterManager = new PROYECTO_VETERINARIA.DSveterinariaTableAdapters.TableAdapterManager();
            this.tAB_REGISTRO_DIARIOBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tAB_REGISTRO_DIARIODataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            iD_REGISTRO_DIARIOLabel = new System.Windows.Forms.Label();
            iD_FICHA_INGRESOLabel = new System.Windows.Forms.Label();
            fECHALabel = new System.Windows.Forms.Label();
            dIAGNOSTICOLabel = new System.Windows.Forms.Label();
            oBSERVACIONLabel = new System.Windows.Forms.Label();
            pESOLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_REGISTRO_DIARIOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSveterinaria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_REGISTRO_DIARIOBindingNavigator)).BeginInit();
            this.tAB_REGISTRO_DIARIOBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_REGISTRO_DIARIODataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_REGISTRO_DIARIOLabel
            // 
            iD_REGISTRO_DIARIOLabel.AutoSize = true;
            iD_REGISTRO_DIARIOLabel.Location = new System.Drawing.Point(118, 23);
            iD_REGISTRO_DIARIOLabel.Name = "iD_REGISTRO_DIARIOLabel";
            iD_REGISTRO_DIARIOLabel.Size = new System.Drawing.Size(120, 13);
            iD_REGISTRO_DIARIOLabel.TabIndex = 0;
            iD_REGISTRO_DIARIOLabel.Text = "ID REGISTRO DIARIO:";
            // 
            // iD_FICHA_INGRESOLabel
            // 
            iD_FICHA_INGRESOLabel.AutoSize = true;
            iD_FICHA_INGRESOLabel.Location = new System.Drawing.Point(118, 52);
            iD_FICHA_INGRESOLabel.Name = "iD_FICHA_INGRESOLabel";
            iD_FICHA_INGRESOLabel.Size = new System.Drawing.Size(107, 13);
            iD_FICHA_INGRESOLabel.TabIndex = 2;
            iD_FICHA_INGRESOLabel.Text = "ID FICHA INGRESO:";
            // 
            // fECHALabel
            // 
            fECHALabel.AutoSize = true;
            fECHALabel.Location = new System.Drawing.Point(118, 80);
            fECHALabel.Name = "fECHALabel";
            fECHALabel.Size = new System.Drawing.Size(45, 13);
            fECHALabel.TabIndex = 4;
            fECHALabel.Text = "FECHA:";
            // 
            // dIAGNOSTICOLabel
            // 
            dIAGNOSTICOLabel.AutoSize = true;
            dIAGNOSTICOLabel.Location = new System.Drawing.Point(118, 105);
            dIAGNOSTICOLabel.Name = "dIAGNOSTICOLabel";
            dIAGNOSTICOLabel.Size = new System.Drawing.Size(84, 13);
            dIAGNOSTICOLabel.TabIndex = 6;
            dIAGNOSTICOLabel.Text = "DIAGNOSTICO:";
            // 
            // oBSERVACIONLabel
            // 
            oBSERVACIONLabel.AutoSize = true;
            oBSERVACIONLabel.Location = new System.Drawing.Point(118, 131);
            oBSERVACIONLabel.Name = "oBSERVACIONLabel";
            oBSERVACIONLabel.Size = new System.Drawing.Size(87, 13);
            oBSERVACIONLabel.TabIndex = 8;
            oBSERVACIONLabel.Text = "OBSERVACION:";
            // 
            // pESOLabel
            // 
            pESOLabel.AutoSize = true;
            pESOLabel.Location = new System.Drawing.Point(118, 157);
            pESOLabel.Name = "pESOLabel";
            pESOLabel.Size = new System.Drawing.Size(39, 13);
            pESOLabel.TabIndex = 10;
            pESOLabel.Text = "PESO:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(iD_REGISTRO_DIARIOLabel);
            this.panel1.Controls.Add(this.iD_REGISTRO_DIARIOLabel1);
            this.panel1.Controls.Add(iD_FICHA_INGRESOLabel);
            this.panel1.Controls.Add(this.iD_FICHA_INGRESOComboBox);
            this.panel1.Controls.Add(fECHALabel);
            this.panel1.Controls.Add(this.fECHADateTimePicker);
            this.panel1.Controls.Add(dIAGNOSTICOLabel);
            this.panel1.Controls.Add(this.dIAGNOSTICOTextBox);
            this.panel1.Controls.Add(oBSERVACIONLabel);
            this.panel1.Controls.Add(this.oBSERVACIONTextBox);
            this.panel1.Controls.Add(pESOLabel);
            this.panel1.Controls.Add(this.pESOTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(673, 189);
            this.panel1.TabIndex = 0;
            // 
            // iD_REGISTRO_DIARIOLabel1
            // 
            this.iD_REGISTRO_DIARIOLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAB_REGISTRO_DIARIOBindingSource, "ID_REGISTRO_DIARIO", true));
            this.iD_REGISTRO_DIARIOLabel1.Location = new System.Drawing.Point(244, 23);
            this.iD_REGISTRO_DIARIOLabel1.Name = "iD_REGISTRO_DIARIOLabel1";
            this.iD_REGISTRO_DIARIOLabel1.Size = new System.Drawing.Size(200, 23);
            this.iD_REGISTRO_DIARIOLabel1.TabIndex = 1;
            this.iD_REGISTRO_DIARIOLabel1.Text = "label1";
            // 
            // tAB_REGISTRO_DIARIOBindingSource
            // 
            this.tAB_REGISTRO_DIARIOBindingSource.DataMember = "TAB_REGISTRO_DIARIO";
            this.tAB_REGISTRO_DIARIOBindingSource.DataSource = this.dSveterinaria;
            // 
            // dSveterinaria
            // 
            this.dSveterinaria.DataSetName = "DSveterinaria";
            this.dSveterinaria.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iD_FICHA_INGRESOComboBox
            // 
            this.iD_FICHA_INGRESOComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAB_REGISTRO_DIARIOBindingSource, "ID_FICHA_INGRESO", true));
            this.iD_FICHA_INGRESOComboBox.FormattingEnabled = true;
            this.iD_FICHA_INGRESOComboBox.Location = new System.Drawing.Point(244, 49);
            this.iD_FICHA_INGRESOComboBox.Name = "iD_FICHA_INGRESOComboBox";
            this.iD_FICHA_INGRESOComboBox.Size = new System.Drawing.Size(200, 21);
            this.iD_FICHA_INGRESOComboBox.TabIndex = 3;
            // 
            // fECHADateTimePicker
            // 
            this.fECHADateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tAB_REGISTRO_DIARIOBindingSource, "FECHA", true));
            this.fECHADateTimePicker.Location = new System.Drawing.Point(244, 76);
            this.fECHADateTimePicker.Name = "fECHADateTimePicker";
            this.fECHADateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fECHADateTimePicker.TabIndex = 5;
            // 
            // dIAGNOSTICOTextBox
            // 
            this.dIAGNOSTICOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAB_REGISTRO_DIARIOBindingSource, "DIAGNOSTICO", true));
            this.dIAGNOSTICOTextBox.Location = new System.Drawing.Point(244, 102);
            this.dIAGNOSTICOTextBox.Name = "dIAGNOSTICOTextBox";
            this.dIAGNOSTICOTextBox.Size = new System.Drawing.Size(200, 20);
            this.dIAGNOSTICOTextBox.TabIndex = 7;
            // 
            // oBSERVACIONTextBox
            // 
            this.oBSERVACIONTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAB_REGISTRO_DIARIOBindingSource, "OBSERVACION", true));
            this.oBSERVACIONTextBox.Location = new System.Drawing.Point(244, 128);
            this.oBSERVACIONTextBox.Name = "oBSERVACIONTextBox";
            this.oBSERVACIONTextBox.Size = new System.Drawing.Size(200, 20);
            this.oBSERVACIONTextBox.TabIndex = 9;
            // 
            // pESOTextBox
            // 
            this.pESOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAB_REGISTRO_DIARIOBindingSource, "PESO", true));
            this.pESOTextBox.Location = new System.Drawing.Point(244, 154);
            this.pESOTextBox.Name = "pESOTextBox";
            this.pESOTextBox.Size = new System.Drawing.Size(200, 20);
            this.pESOTextBox.TabIndex = 11;
            // 
            // tAB_REGISTRO_DIARIOTableAdapter
            // 
            this.tAB_REGISTRO_DIARIOTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.TAB_REGISTRO_DIARIOTableAdapter = this.tAB_REGISTRO_DIARIOTableAdapter;
            this.tableAdapterManager.TAB_ROLESTableAdapter = null;
            this.tableAdapterManager.TAB_SALIDA_DE_MASCOTATableAdapter = null;
            this.tableAdapterManager.TAB_TIPO_DE_MASCOTATableAdapter = null;
            this.tableAdapterManager.TAB_USUARIOSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PROYECTO_VETERINARIA.DSveterinariaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tAB_REGISTRO_DIARIOBindingNavigator
            // 
            this.tAB_REGISTRO_DIARIOBindingNavigator.AddNewItem = this.btnAgregar;
            this.tAB_REGISTRO_DIARIOBindingNavigator.BindingSource = this.tAB_REGISTRO_DIARIOBindingSource;
            this.tAB_REGISTRO_DIARIOBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tAB_REGISTRO_DIARIOBindingNavigator.DeleteItem = this.btnEliminar;
            this.tAB_REGISTRO_DIARIOBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tAB_REGISTRO_DIARIOBindingNavigator.Location = new System.Drawing.Point(0, 189);
            this.tAB_REGISTRO_DIARIOBindingNavigator.MoveFirstItem = null;
            this.tAB_REGISTRO_DIARIOBindingNavigator.MoveLastItem = null;
            this.tAB_REGISTRO_DIARIOBindingNavigator.MoveNextItem = null;
            this.tAB_REGISTRO_DIARIOBindingNavigator.MovePreviousItem = null;
            this.tAB_REGISTRO_DIARIOBindingNavigator.Name = "tAB_REGISTRO_DIARIOBindingNavigator";
            this.tAB_REGISTRO_DIARIOBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tAB_REGISTRO_DIARIOBindingNavigator.Size = new System.Drawing.Size(673, 25);
            this.tAB_REGISTRO_DIARIOBindingNavigator.TabIndex = 1;
            this.tAB_REGISTRO_DIARIOBindingNavigator.Text = "bindingNavigator1";
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
            this.btnGuardar.Click += new System.EventHandler(this.tAB_REGISTRO_DIARIOBindingNavigatorSaveItem_Click);
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
            // tAB_REGISTRO_DIARIODataGridView
            // 
            this.tAB_REGISTRO_DIARIODataGridView.AllowUserToAddRows = false;
            this.tAB_REGISTRO_DIARIODataGridView.AllowUserToDeleteRows = false;
            this.tAB_REGISTRO_DIARIODataGridView.AutoGenerateColumns = false;
            this.tAB_REGISTRO_DIARIODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tAB_REGISTRO_DIARIODataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.tAB_REGISTRO_DIARIODataGridView.DataSource = this.tAB_REGISTRO_DIARIOBindingSource;
            this.tAB_REGISTRO_DIARIODataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tAB_REGISTRO_DIARIODataGridView.Location = new System.Drawing.Point(0, 214);
            this.tAB_REGISTRO_DIARIODataGridView.Name = "tAB_REGISTRO_DIARIODataGridView";
            this.tAB_REGISTRO_DIARIODataGridView.ReadOnly = true;
            this.tAB_REGISTRO_DIARIODataGridView.Size = new System.Drawing.Size(673, 305);
            this.tAB_REGISTRO_DIARIODataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_REGISTRO_DIARIO";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_REGISTRO_DIARIO";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ID_FICHA_INGRESO";
            this.dataGridViewTextBoxColumn2.HeaderText = "ID_FICHA_INGRESO";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FECHA";
            this.dataGridViewTextBoxColumn3.HeaderText = "FECHA";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DIAGNOSTICO";
            this.dataGridViewTextBoxColumn4.HeaderText = "DIAGNOSTICO";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "OBSERVACION";
            this.dataGridViewTextBoxColumn5.HeaderText = "OBSERVACION";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "PESO";
            this.dataGridViewTextBoxColumn6.HeaderText = "PESO";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // FRM_RegistroDiario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 519);
            this.Controls.Add(this.tAB_REGISTRO_DIARIODataGridView);
            this.Controls.Add(this.tAB_REGISTRO_DIARIOBindingNavigator);
            this.Controls.Add(this.panel1);
            this.Name = "FRM_RegistroDiario";
            this.Text = "FRM_RegistroDiario";
            this.Load += new System.EventHandler(this.FRM_RegistroDiario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_REGISTRO_DIARIOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSveterinaria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_REGISTRO_DIARIOBindingNavigator)).EndInit();
            this.tAB_REGISTRO_DIARIOBindingNavigator.ResumeLayout(false);
            this.tAB_REGISTRO_DIARIOBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_REGISTRO_DIARIODataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DSveterinaria dSveterinaria;
        private System.Windows.Forms.BindingSource tAB_REGISTRO_DIARIOBindingSource;
        private DSveterinariaTableAdapters.TAB_REGISTRO_DIARIOTableAdapter tAB_REGISTRO_DIARIOTableAdapter;
        private DSveterinariaTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tAB_REGISTRO_DIARIOBindingNavigator;
        private System.Windows.Forms.ToolStripButton btnAgregar;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.Label iD_REGISTRO_DIARIOLabel1;
        private System.Windows.Forms.ComboBox iD_FICHA_INGRESOComboBox;
        private System.Windows.Forms.DateTimePicker fECHADateTimePicker;
        private System.Windows.Forms.TextBox dIAGNOSTICOTextBox;
        private System.Windows.Forms.TextBox oBSERVACIONTextBox;
        private System.Windows.Forms.TextBox pESOTextBox;
        private System.Windows.Forms.DataGridView tAB_REGISTRO_DIARIODataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.ToolStripButton btnActualizar;
        private System.Windows.Forms.ToolStripButton btnCancelar;
    }
}