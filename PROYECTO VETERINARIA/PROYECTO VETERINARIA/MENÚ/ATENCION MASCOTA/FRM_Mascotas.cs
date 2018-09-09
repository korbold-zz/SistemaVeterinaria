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
    public partial class FRM_Mascotas : Form
    {
        public FRM_Mascotas()
        {
            InitializeComponent();
        }

        private void tAB_MASCOTABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate ( );
                this.tAB_MASCOTABindingSource.EndEdit ( );
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

        private void FRM_Mascotas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSveterinaria.TAB_RAZA' Puede moverla o quitarla según sea necesario.
            this.tAB_RAZATableAdapter.Fill(this.dSveterinaria.TAB_RAZA);
            // TODO: esta línea de código carga datos en la tabla 'dSveterinaria.TAB_TIPO_DE_MASCOTA' Puede moverla o quitarla según sea necesario.
            this.tAB_TIPO_DE_MASCOTATableAdapter.Fill(this.dSveterinaria.TAB_TIPO_DE_MASCOTA);
            // TODO: esta línea de código carga datos en la tabla 'dSveterinaria.TAB_PERSONA' Puede moverla o quitarla según sea necesario.
            this.tAB_PERSONATableAdapter.Fill(this.dSveterinaria.TAB_PERSONA);
            // TODO: esta línea de código carga datos en la tabla 'dSveterinaria.TAB_MASCOTA' Puede moverla o quitarla según sea necesario.
            this.tAB_MASCOTATableAdapter.Fill(this.dSveterinaria.TAB_MASCOTA);
            Metodos.BotonLOAD ( btnActualizar, btnCancelar, btnGuardar, btnAgregar, btnEliminar );
            enabledFALSE ( );

        }

        private void btnAgregar_Click ( object sender, EventArgs e )
        {
            Metodos.BotonAGREGAR ( btnActualizar, btnCancelar, btnGuardar, btnAgregar, btnEliminar );
            enabledTRUE ( );
        }

        private void bindingNavigatorDeleteItem_Click ( object sender, EventArgs e )
        {
            DSveterinariaTableAdapters.TAB_MASCOTATableAdapter obj = new DSveterinariaTableAdapters.TAB_MASCOTATableAdapter ( );
            int n = int.Parse ( tAB_MASCOTADataGridView.CurrentRow.Cells [ 0 ].Value.ToString ( ) );
            string dato = tAB_MASCOTADataGridView.CurrentRow.Cells [ 1 ].Value.ToString ( );
            string dato2 = tAB_MASCOTADataGridView.CurrentRow.Cells [ 2 ].Value.ToString ( );


            if ( tAB_MASCOTADataGridView.RowCount > 0 )
            {
                if ( MessageBox.Show ( dato+"  "+dato2 + " ¿Está seguro de ELIMINAR?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Error ) == DialogResult.Yes )
                {

                    obj.DeleteQuery_MASCOTAS ( n );
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
            if ( tAB_MASCOTADataGridView.RowCount > 0 )
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
            this.tAB_MASCOTATableAdapter.Fill ( this.dSveterinaria.TAB_MASCOTA );
            Metodos.BotonLOAD ( btnActualizar, btnCancelar, btnGuardar, btnAgregar, btnEliminar );
            enabledFALSE ( );

        }
        public void enabledFALSE ( )
        {
            iD_PERSONAComboBox.Enabled = false;
            iD_TIPODEMASCOTAComboBox.Enabled = false;
            iD_RAZAComboBox.Enabled = false;
            nOMBRETextBox.Enabled = false;
            cOLORTextBox.Enabled = false;

        }
        public void enabledTRUE ( )
        {
            iD_PERSONAComboBox.Enabled = true;
            iD_TIPODEMASCOTAComboBox.Enabled = true;
            iD_RAZAComboBox.Enabled = true;
            nOMBRETextBox.Enabled = true;
            cOLORTextBox.Enabled = true;

        }

        private void nOMBRETextBox_KeyPress ( object sender, KeyPressEventArgs e )
        {
            Metodos.SoloLetras ( e );
        }

        private void cOLORTextBox_KeyPress ( object sender, KeyPressEventArgs e )
        {
            Metodos.SoloLetras ( e );
        }

        private void iD_RAZALabel_Click ( object sender, EventArgs e )
        {

        }
    }
}
