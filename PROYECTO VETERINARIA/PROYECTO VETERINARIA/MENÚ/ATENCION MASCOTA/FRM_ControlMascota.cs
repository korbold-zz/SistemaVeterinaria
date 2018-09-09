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
    public partial class FRM_ControlMascota : Form
    {
        public FRM_ControlMascota()
        {
            InitializeComponent();
        }

        private void tAB_CONTROL_MASCOTABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate ( );
                this.tAB_CONTROL_MASCOTABindingSource.EndEdit ( );
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

        private void FRM_ControlMascota_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSveterinaria.TAB_FICHA_DE_INGRESO' Puede moverla o quitarla según sea necesario.
            this.tAB_FICHA_DE_INGRESOTableAdapter.Fill(this.dSveterinaria.TAB_FICHA_DE_INGRESO);
            // TODO: esta línea de código carga datos en la tabla 'dSveterinaria.TAB_CONTROL_MASCOTA' Puede moverla o quitarla según sea necesario.
            this.tAB_CONTROL_MASCOTATableAdapter.Fill(this.dSveterinaria.TAB_CONTROL_MASCOTA);
            enabledFALSE ( );
            Metodos.BotonLOAD ( btnActualizar, btnCancelar, btnGuardar, btnAgregar,btnEliminar );

        }

        private void btnAgregar_Click ( object sender, EventArgs e )
        {
            Metodos.BotonAGREGAR ( btnActualizar, btnCancelar, btnGuardar, btnAgregar,btnEliminar );
            enabledTRUE ( );
        }

        private void btnActualizar_Click ( object sender, EventArgs e )
        {
            if ( tAB_CONTROL_MASCOTADataGridView.RowCount > 0 )
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
            this.tAB_CONTROL_MASCOTATableAdapter.Fill ( this.dSveterinaria.TAB_CONTROL_MASCOTA );
            Metodos.BotonLOAD ( btnActualizar, btnCancelar, btnGuardar, btnAgregar ,btnEliminar);
            enabledFALSE ( );
        }
        public  void enabledFALSE ( )
        {
            iD_FICHA_INGRESOComboBox.Enabled = false;
            tIPO_DE_CONTROLTextBox.Enabled = false;
            pARAMETROTextBox.Enabled = false;
            rESULTADOTextBox.Enabled = false;
        }
        public void enabledTRUE ( )
        {
            iD_FICHA_INGRESOComboBox.Enabled = true;
            tIPO_DE_CONTROLTextBox.Enabled = true;
            pARAMETROTextBox.Enabled = true;
            rESULTADOTextBox.Enabled = true;
        }

        private void bindingNavigatorDeleteItem_Click ( object sender, EventArgs e )
        {
            DSveterinariaTableAdapters.TAB_CONTROL_MASCOTATableAdapter obj = new DSveterinariaTableAdapters.TAB_CONTROL_MASCOTATableAdapter ( );
            int n = int.Parse ( tAB_CONTROL_MASCOTADataGridView.CurrentRow.Cells [ 0 ].Value.ToString ( ) );
            string dato = tAB_CONTROL_MASCOTADataGridView.CurrentRow.Cells [ 0 ].Value.ToString ( );

            if ( tAB_CONTROL_MASCOTADataGridView.RowCount > 0 )
            {
                if ( MessageBox.Show ( dato + " ¿Está seguro de ELIMINAR?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Error ) == DialogResult.Yes )
                {

                    obj.DeleteQuery_CONTROLMASCOTA ( n );
                }

            }
            else
            {
                if ( MessageBox.Show ( "NO HAY REGISTROS PARA ELIMINAR", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Stop ) == DialogResult.Yes )
                {

                }
            }
        }

        private void tIPO_DE_CONTROLTextBox_KeyPress ( object sender, KeyPressEventArgs e )
        {
            Metodos.SoloLetras ( e );
        }


        
    }
}
