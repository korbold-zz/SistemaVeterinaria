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
    public partial class FRM_FichaIngreso : Form
    {
        public FRM_FichaIngreso()
        {
            InitializeComponent();
        }

        private void tAB_FICHA_DE_INGRESOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate ( );
                this.tAB_FICHA_DE_INGRESOBindingSource.EndEdit ( );
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

        private void FRM_FichaIngreso_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSveterinaria.TAB_PROVINCIAS' Puede moverla o quitarla según sea necesario.
            this.tAB_PROVINCIASTableAdapter.Fill ( this.dSveterinaria.TAB_PROVINCIAS );
            // TODO: esta línea de código carga datos en la tabla 'dSveterinaria.TAB_PERSONA' Puede moverla o quitarla según sea necesario.
            this.tAB_PERSONATableAdapter.Fill(this.dSveterinaria.TAB_PERSONA);
            // TODO: esta línea de código carga datos en la tabla 'dSveterinaria.TAB_MASCOTA' Puede moverla o quitarla según sea necesario.
            this.tAB_MASCOTATableAdapter.Fill(this.dSveterinaria.TAB_MASCOTA);
            // TODO: esta línea de código carga datos en la tabla 'dSveterinaria.TAB_FICHA_DE_INGRESO' Puede moverla o quitarla según sea necesario.
            this.tAB_FICHA_DE_INGRESOTableAdapter.Fill(this.dSveterinaria.TAB_FICHA_DE_INGRESO);
            enabledFALSE ( );
            Metodos.BotonLOAD ( btnActualizar, btnCancelar, btnGuardar, btnAgregar,btnEliminar );

        }

        private void btnAgregar_Click ( object sender, EventArgs e )
        {
            Metodos.BotonAGREGAR ( btnActualizar, btnCancelar, btnGuardar, btnAgregar, btnEliminar );
            enabledTRUE ( );
            btnAgregar.Enabled = false;
        }

        private void btnActualizar_Click ( object sender, EventArgs e )
        {
            if ( tAB_FICHA_DE_INGRESODataGridView.RowCount > 0 )
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
            this.tAB_FICHA_DE_INGRESOTableAdapter.Fill ( this.dSveterinaria.TAB_FICHA_DE_INGRESO );
            Metodos.BotonLOAD ( btnActualizar, btnCancelar, btnGuardar, btnAgregar,btnEliminar );
            enabledFALSE ( );
        }
        public void enabledFALSE ( )
        {
            iD_MASCOTAComboBox.Enabled = false;
            iD_PERSONAComboBox.Enabled = false;
            fECHADateTimePicker.Enabled = false;
            dESCRIPCIONTextBox.Enabled = false;
            dIAGNOSTICOTextBox.Enabled = false;
            eSTADOTextBox.Enabled = false;
            pESOTextBox.Enabled = false;
            tEMPERATURATextBox.Enabled = false;
        }
        public void enabledTRUE ( )
        {
            iD_MASCOTAComboBox.Enabled = true;
            iD_PERSONAComboBox.Enabled = true;
            fECHADateTimePicker.Enabled = true;
            dESCRIPCIONTextBox.Enabled = true;
            dIAGNOSTICOTextBox.Enabled = true;
            eSTADOTextBox.Enabled = true;
            pESOTextBox.Enabled = true;
            tEMPERATURATextBox.Enabled = true;
        }

        private void bindingNavigatorDeleteItem_Click ( object sender, EventArgs e )
        {
            DSveterinariaTableAdapters.TAB_FICHA_DE_INGRESOTableAdapter obj = new DSveterinariaTableAdapters.TAB_FICHA_DE_INGRESOTableAdapter ( );
            int n = int.Parse ( tAB_FICHA_DE_INGRESODataGridView.CurrentRow.Cells [ 0 ].Value.ToString ( ) );
            string dato = tAB_FICHA_DE_INGRESODataGridView.CurrentRow.Cells [ 0 ].Value.ToString ( );

            if ( tAB_FICHA_DE_INGRESODataGridView.RowCount > 0 )
            {
                if ( MessageBox.Show ( dato + " ¿Está seguro de ELIMINAR?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Error ) == DialogResult.Yes )
                {

                    obj.DeleteQuery_FICHA_DE_INGRESO ( n );
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
