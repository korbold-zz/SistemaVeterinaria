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
    public partial class FRM_Cantones : Form
    {
        public FRM_Cantones()
        {
            InitializeComponent();
        }

        private void tAB_CANTONESBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

            try
            {
                this.Validate();
                this.tAB_CANTONESBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dSveterinaria);
                Metodos.BotonGUARDAR ( btnActualizar, btnCancelar, btnGuardar, btnAgregar, btnEliminar );
                enabledFALSE ( );
            }
            catch ( Exception )
            {
                
                if (MessageBox.Show("Ingrese el Dato antes de GUARGAR", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Stop) == DialogResult.Yes)
                {

                }
            }

        }

        private void FRM_Cantones_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSveterinaria.TAB_PROVINCIAS' Puede moverla o quitarla según sea necesario.
            this.tAB_PROVINCIASTableAdapter.Fill(this.dSveterinaria.TAB_PROVINCIAS);
            // TODO: esta línea de código carga datos en la tabla 'dSveterinaria.TAB_CANTONES' Puede moverla o quitarla según sea necesario.
            this.tAB_CANTONESTableAdapter.Fill(this.dSveterinaria.TAB_CANTONES);

            cANTONTextBox.Text = ""; 
            enabledFALSE ( );
            Metodos.BotonLOAD ( btnActualizar, btnCancelar, btnGuardar, btnAgregar, btnEliminar );
        }

        private void bindingNavigatorAddNewItem_Click ( object sender, EventArgs e )
        {
            Metodos.BotonAGREGAR ( btnActualizar, btnCancelar, btnGuardar, btnAgregar, btnEliminar );
            enabledTRUE ( );
        }

        private void btnActualizar_Click ( object sender, EventArgs e )
        {
            if ( tAB_CANTONESDataGridView.RowCount > 0 )
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
            this.tAB_CANTONESTableAdapter.Fill ( this.dSveterinaria.TAB_CANTONES );
            Metodos.BotonLOAD ( btnActualizar, btnCancelar, btnGuardar, btnAgregar, btnEliminar );
            enabledFALSE ( );
        }

        private void cANTONTextBox_KeyPress ( object sender, KeyPressEventArgs e )
        {
            Metodos.SoloLetras(e);
           
        }
        public void enabledFALSE ( )
        {
            iD_PROVINCIAComboBox.Enabled = false;
            cANTONTextBox.Enabled = false;
           
        }
        public void enabledTRUE ( )
        {
            iD_PROVINCIAComboBox.Enabled = true;
            cANTONTextBox.Enabled = true;
           
        }

        private void btnEliminar_Click ( object sender, EventArgs e )
        {
            DSveterinariaTableAdapters.TAB_CANTONESTableAdapter obj = new DSveterinariaTableAdapters.TAB_CANTONESTableAdapter ( );
            int n = int.Parse ( tAB_CANTONESDataGridView.CurrentRow.Cells [ 0 ].Value.ToString ( ) );
            string dato = tAB_CANTONESDataGridView.CurrentRow.Cells [ 1 ].Value.ToString ( );

            if ( tAB_CANTONESDataGridView.RowCount > 0 )
            {
                if ( MessageBox.Show ( dato + " ¿Está seguro de ELIMINAR?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Error ) == DialogResult.Yes )
                {

                    obj.DeleteQuery_CANTONES ( n );
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
