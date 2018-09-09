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
    public partial class FRM_SalidaMascota : Form
    {
        public FRM_SalidaMascota()
        {
            InitializeComponent();
        }

        private void tAB_SALIDA_DE_MASCOTABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tAB_SALIDA_DE_MASCOTABindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSveterinaria);

        }

        private void tAB_SALIDA_DE_MASCOTABindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.Validate ( );
                this.tAB_SALIDA_DE_MASCOTABindingSource.EndEdit ( );
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

        private void FRM_SalidaMascota_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSveterinaria.TAB_FICHA_DE_INGRESO' Puede moverla o quitarla según sea necesario.
            this.tAB_FICHA_DE_INGRESOTableAdapter.Fill(this.dSveterinaria.TAB_FICHA_DE_INGRESO);
            // TODO: esta línea de código carga datos en la tabla 'dSveterinaria.TAB_SALIDA_DE_MASCOTA' Puede moverla o quitarla según sea necesario.
            this.tAB_SALIDA_DE_MASCOTATableAdapter.Fill(this.dSveterinaria.TAB_SALIDA_DE_MASCOTA);
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
            DSveterinariaTableAdapters.TAB_SALIDA_DE_MASCOTATableAdapter obj = new DSveterinariaTableAdapters.TAB_SALIDA_DE_MASCOTATableAdapter ( );
            int n = int.Parse ( tAB_SALIDA_DE_MASCOTADataGridView.CurrentRow.Cells [ 0 ].Value.ToString ( ) );
            string dato = tAB_SALIDA_DE_MASCOTADataGridView.CurrentRow.Cells [ 1 ].Value.ToString ( );
           


            if ( tAB_SALIDA_DE_MASCOTADataGridView.RowCount > 0 )
            {
                if ( MessageBox.Show ( dato +  " ¿Está seguro de ELIMINAR?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Error ) == DialogResult.Yes )
                {

                    obj.DeleteQuery_SALIDAMASCOTA ( n );
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
            if ( tAB_SALIDA_DE_MASCOTADataGridView.RowCount > 0 )
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
            this.tAB_SALIDA_DE_MASCOTATableAdapter.Fill ( this.dSveterinaria.TAB_SALIDA_DE_MASCOTA );
            Metodos.BotonLOAD ( btnActualizar, btnCancelar, btnGuardar, btnAgregar, btnEliminar );
            enabledFALSE ( );
        }
        public void enabledFALSE ( )
        {
            iD_FICHA_INGRESOComboBox.Enabled = false;
            fECHA_DE_ALTATextBox.Enabled = false;
            eSTADOTextBox.Enabled = false;
            cITATextBox.Enabled = false;
            oBSERVACIONTextBox.Enabled = false;

        }
        public void enabledTRUE ( )
        {
            iD_FICHA_INGRESOComboBox.Enabled = true;
            fECHA_DE_ALTATextBox.Enabled = true;
            eSTADOTextBox.Enabled = true;
            cITATextBox.Enabled = true;
            oBSERVACIONTextBox.Enabled = true;

        }
    }
}
