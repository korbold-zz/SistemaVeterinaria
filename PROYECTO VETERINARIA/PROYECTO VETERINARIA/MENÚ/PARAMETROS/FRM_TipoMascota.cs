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
    public partial class FRM_TipoMascota : Form
    {
        public FRM_TipoMascota()
        {
            InitializeComponent();
        }

        private void tAB_TIPO_DE_MASCOTABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate ( );
                this.tAB_TIPO_DE_MASCOTABindingSource.EndEdit ( );
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

        private void FRM_TipoMascota_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSveterinaria.TAB_TIPO_DE_MASCOTA' Puede moverla o quitarla según sea necesario.
            this.tAB_TIPO_DE_MASCOTATableAdapter.Fill(this.dSveterinaria.TAB_TIPO_DE_MASCOTA);
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
            DSveterinariaTableAdapters.TAB_TIPO_DE_MASCOTATableAdapter obj = new DSveterinariaTableAdapters.TAB_TIPO_DE_MASCOTATableAdapter ( );
            int n = int.Parse ( tAB_TIPO_DE_MASCOTADataGridView.CurrentRow.Cells [ 0 ].Value.ToString ( ) );
            string dato = tAB_TIPO_DE_MASCOTADataGridView.CurrentRow.Cells [ 1 ].Value.ToString ( );
          

            if ( tAB_TIPO_DE_MASCOTADataGridView.RowCount > 0 )
            {
                if ( MessageBox.Show ( dato + " ¿Está seguro de ELIMINAR?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Error ) == DialogResult.Yes )
                {

                    obj.DeleteQuery_TIPO_MASCOTA ( n );
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
            if ( tAB_TIPO_DE_MASCOTADataGridView.RowCount > 0 )
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
            this.tAB_TIPO_DE_MASCOTATableAdapter.Fill ( this.dSveterinaria.TAB_TIPO_DE_MASCOTA );
            Metodos.BotonLOAD ( btnActualizar, btnCancelar, btnGuardar, btnAgregar, btnEliminar );
            enabledFALSE ( );
        }
        public void enabledFALSE ( )
        {
            tIPO_DE_MASCOTATextBox.Enabled = false;
            
        }
        public void enabledTRUE ( )
        {
            tIPO_DE_MASCOTATextBox.Enabled = true;
           
        }

        private void tIPO_DE_MASCOTATextBox_KeyPress ( object sender, KeyPressEventArgs e )
        {
            Metodos.SoloLetras ( e );
        }
    }
}
