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
    public partial class FRM_Raza : Form
    {
        public FRM_Raza()
        {
            InitializeComponent();
        }

        private void tAB_RAZABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate ( );
                this.tAB_RAZABindingSource.EndEdit ( );
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

        private void FRM_Raza_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSveterinaria.TAB_TIPO_DE_MASCOTA' Puede moverla o quitarla según sea necesario.
            this.tAB_TIPO_DE_MASCOTATableAdapter.Fill(this.dSveterinaria.TAB_TIPO_DE_MASCOTA);
            // TODO: esta línea de código carga datos en la tabla 'dSveterinaria.TAB_RAZA' Puede moverla o quitarla según sea necesario.
            this.tAB_RAZATableAdapter.Fill(this.dSveterinaria.TAB_RAZA);
            Metodos.BotonLOAD ( btnActualizar, btnCancelar, btnGuardar, btnAgregar, btnEliminar );
            enabledFALSE ( );

        }

        private void bindingNavigatorAddNewItem_Click ( object sender, EventArgs e )
        {
            Metodos.BotonAGREGAR ( btnActualizar, btnCancelar, btnGuardar, btnAgregar, btnEliminar );
            enabledTRUE ( );
        }

        private void btnEliminar_Click ( object sender, EventArgs e )
        {
            DSveterinariaTableAdapters.TAB_RAZATableAdapter obj = new DSveterinariaTableAdapters.TAB_RAZATableAdapter ( );
            int n = int.Parse ( tAB_RAZADataGridView.CurrentRow.Cells [ 0 ].Value.ToString ( ) );
            string dato = tAB_RAZADataGridView.CurrentRow.Cells [ 1 ].Value.ToString ( );
            string dato2 = tAB_RAZADataGridView.CurrentRow.Cells [ 2 ].Value.ToString ( );


            if ( tAB_RAZADataGridView.RowCount > 0 )
            {
                if ( MessageBox.Show ( dato + " " + dato2 + " ¿Está seguro de ELIMINAR?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Error ) == DialogResult.Yes )
                {

                    obj.DeleteQuery_RAZA ( n );
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
            if ( tAB_RAZADataGridView.RowCount > 0 )
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
            this.tAB_RAZATableAdapter.Fill ( this.dSveterinaria.TAB_RAZA );
            Metodos.BotonLOAD ( btnActualizar, btnCancelar, btnGuardar, btnAgregar, btnEliminar );
            enabledFALSE ( );
        }
        public void enabledFALSE ( )
        {
            iD_TIPODEMASCOTAComboBox.Enabled = false;
            tIPO_RAZATextBox.Enabled = false;
            

        }
        public void enabledTRUE ( )
        {
            iD_TIPODEMASCOTAComboBox.Enabled = true;
            tIPO_RAZATextBox.Enabled = true;
        }

        private void tIPO_RAZATextBox_KeyPress ( object sender, KeyPressEventArgs e )
        {
            Metodos.SoloLetras ( e );
        }
    }
}
