using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_VETERINARIA
{
    public partial class FRM_Medicamentos : Form
    {
        public FRM_Medicamentos()
        {
            InitializeComponent();
        }

        private void tAB_MEDICAMENTOSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate ( );
                this.tAB_MEDICAMENTOSBindingSource.EndEdit ( );
                this.tableAdapterManager.UpdateAll ( this.dSveterinaria );
                Metodos.BotonGUARDAR ( btnActualizar, btnCancelar, btnGuardar, btnAgregar, btnEliminar );
                enabledFALSE ( );
            }
            catch ( Exception )
            {
                
               if (MessageBox.Show("Ingrese los Datos antes de GUARGAR", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Stop) == DialogResult.Yes)
                {

                }
            }

        }

        private void FRM_Medicamentos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSveterinaria.TAB_MEDICAMENTOS' Puede moverla o quitarla según sea necesario.
            this.tAB_MEDICAMENTOSTableAdapter.Fill(this.dSveterinaria.TAB_MEDICAMENTOS);
            enabledFALSE ( );
            Metodos.BotonLOAD ( btnActualizar, btnCancelar, btnGuardar, btnAgregar, btnEliminar );
        }

        private void bindingNavigatorAddNewItem_Click ( object sender, EventArgs e )
        {
            Metodos.BotonAGREGAR ( btnActualizar, btnCancelar, btnGuardar, btnAgregar, btnEliminar );
            enabledTRUE ( );
        }

        

        private void toolStripButton1_Click ( object sender, EventArgs e )
        {
            if ( tAB_MEDICAMENTOSDataGridView.RowCount > 0 )
            {
                Metodos.BotonACTUALIZAR ( btnActualizar, btnCancelar, btnGuardar, btnAgregar, btnEliminar );
                enabledTRUE ( );
            }
            else
            {
                if ( MessageBox.Show ( "NO HAY REGISTROS PARA ACTUALIZAR", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Stop ) == DialogResult.Yes )
                {

                }
            }
        }

        private void toolStripButton2_Click ( object sender, EventArgs e )
        {
            this.tAB_MEDICAMENTOSTableAdapter.Fill ( this.dSveterinaria.TAB_MEDICAMENTOS );
            Metodos.BotonLOAD ( btnActualizar, btnCancelar, btnGuardar, btnAgregar, btnEliminar );
            enabledFALSE ( );
        }
        public void enabledFALSE ( )
        {
            nOMBRETextBox.Enabled = false;
            pRECIOTextBox.Enabled = false;
            
        }
        public void enabledTRUE ( )
        {
            nOMBRETextBox.Enabled = true;
            pRECIOTextBox.Enabled = true;
        }

        private void pRECIOTextBox_KeyPress ( object sender, KeyPressEventArgs e )
        {
            Metodos.SoloNumeros ( e );
        }

        private void toolStripButton1_Click_1 ( object sender, EventArgs e )
        {
            DSveterinariaTableAdapters.TAB_MEDICAMENTOSTableAdapter obj = new DSveterinariaTableAdapters.TAB_MEDICAMENTOSTableAdapter ( );

            int n = int.Parse ( tAB_MEDICAMENTOSDataGridView.CurrentRow.Cells [ 0 ].Value.ToString ( ) );
            string dato = tAB_MEDICAMENTOSDataGridView.CurrentRow.Cells [ 1 ].Value.ToString ( );
            if ( tAB_MEDICAMENTOSDataGridView.RowCount > 0 )
            {
               
                if ( MessageBox.Show ( dato + " ¿Está seguro de ELIMINAR?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Error ) == DialogResult.Yes )
                {

                    obj.DeleteQuery_MEDICAMENTOS ( n );
                }

            }
            else
            {
                if ( MessageBox.Show ( "NO HAY REGISTROS PARA ELIMINAR", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Stop ) == DialogResult.Yes )
                {

                }
            }
        }
    }
}
