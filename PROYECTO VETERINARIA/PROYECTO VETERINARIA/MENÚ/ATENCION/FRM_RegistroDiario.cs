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
    public partial class FRM_RegistroDiario : Form
    {
        public FRM_RegistroDiario ( )
        {
            InitializeComponent ( );
        }

        private void tAB_REGISTRO_DIARIOBindingNavigatorSaveItem_Click ( object sender, EventArgs e )
        {
            try
            {
                this.Validate ( );
                this.tAB_REGISTRO_DIARIOBindingSource.EndEdit ( );
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

        private void FRM_RegistroDiario_Load ( object sender, EventArgs e )
        {
            // TODO: esta línea de código carga datos en la tabla 'dSveterinaria.TAB_REGISTRO_DIARIO' Puede moverla o quitarla según sea necesario.
            this.tAB_REGISTRO_DIARIOTableAdapter.Fill ( this.dSveterinaria.TAB_REGISTRO_DIARIO );
            Metodos.BotonLOAD ( btnActualizar, btnCancelar, btnGuardar, btnAgregar, btnEliminar );
            enabledFALSE ( );

        }

        private void btnAgregar_Click ( object sender, EventArgs e )
        {
            Metodos.BotonAGREGAR ( btnActualizar, btnCancelar, btnGuardar, btnAgregar, btnEliminar );
            enabledTRUE ( );
        }

        private void btnEliminar_Click ( object sender, EventArgs e )
        {
            DSveterinariaTableAdapters.TAB_REGISTRO_DIARIOTableAdapter obj = new DSveterinariaTableAdapters.TAB_REGISTRO_DIARIOTableAdapter ( );
            int n = int.Parse ( tAB_REGISTRO_DIARIODataGridView.CurrentRow.Cells [ 0 ].Value.ToString ( ) );
            string dato = tAB_REGISTRO_DIARIODataGridView.CurrentRow.Cells [ 1 ].Value.ToString ( );

            if ( tAB_REGISTRO_DIARIODataGridView.RowCount > 0 )
            {
                if ( MessageBox.Show ( dato + " ¿Está seguro de ELIMINAR?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Error ) == DialogResult.Yes )
                {

                    obj.DeleteQuery_REGISTRO_DIARIO ( n );
                }

            }
            else
            {
                if ( MessageBox.Show ( "NO HAY REGISTROS PARA ELIMINAR", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Stop ) == DialogResult.Yes )
                {

                }
            }
        }

        private void btnActualizar_Click ( object sender, EventArgs e )
        {
            if ( tAB_REGISTRO_DIARIODataGridView.RowCount > 0 )
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

        private void btnCancelar_Click ( object sender, EventArgs e )
        {
            this.tAB_REGISTRO_DIARIOTableAdapter.Fill ( this.dSveterinaria.TAB_REGISTRO_DIARIO );
            Metodos.BotonLOAD ( btnActualizar, btnCancelar, btnGuardar, btnAgregar, btnEliminar );
            enabledFALSE ( );
        }
        public void enabledFALSE ( )
        {
            iD_FICHA_INGRESOComboBox.Enabled = false;
            fECHADateTimePicker.Enabled = false;
            dIAGNOSTICOTextBox.Enabled = false;
            oBSERVACIONTextBox.Enabled = false;
            pESOTextBox.Enabled = false;
           
        }
        public void enabledTRUE ( )
        {
            iD_FICHA_INGRESOComboBox.Enabled = true;
            fECHADateTimePicker.Enabled = true;
            dIAGNOSTICOTextBox.Enabled = true;
            oBSERVACIONTextBox.Enabled = true;
            pESOTextBox.Enabled = true;
        }
    }
}
