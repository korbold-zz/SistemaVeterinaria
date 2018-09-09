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
    public partial class FRM_Provincias : Form
    {
        public FRM_Provincias()
        {
            InitializeComponent();
            pROVINCIATextBox.Text = "";
        }

        private void tAB_PROVINCIASBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.tAB_PROVINCIASBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dSveterinaria);
                Metodos.BotonGUARDAR ( btnActualizar, btnCancelar, btnGuardar, btnAgregar, btnEliminar );
                enabledFALSE ( );
                
            }
            catch (Exception)
            {
                
                if (MessageBox.Show("Ingrese el Dato antes de GUARGAR", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Stop) == DialogResult.Yes)
                {

                }
            }

        }

        private void FRM_Provincias_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSveterinaria.TAB_PROVINCIAS' Puede moverla o quitarla según sea necesario.
            this.tAB_PROVINCIASTableAdapter.Fill ( this.dSveterinaria.TAB_PROVINCIAS );
            enabledFALSE ( );
            Metodos.BotonLOAD ( btnActualizar, btnCancelar, btnGuardar, btnAgregar, btnEliminar );

        }
       
       
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

            Metodos.BotonAGREGAR ( btnActualizar, btnCancelar, btnGuardar, btnAgregar, btnEliminar );
            enabledTRUE ( );
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.tAB_PROVINCIASTableAdapter.Fill ( this.dSveterinaria.TAB_PROVINCIAS );
            Metodos.BotonLOAD ( btnActualizar, btnCancelar, btnGuardar, btnAgregar, btnEliminar );
            enabledFALSE ( );
           
            
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            DSveterinariaTableAdapters.TAB_PROVINCIASTableAdapter obj = new DSveterinariaTableAdapters.TAB_PROVINCIASTableAdapter ( );

          int a=  tAB_PROVINCIASDataGridView.RowCount;

            if ( tAB_PROVINCIASDataGridView.RowCount > 0 )
            {
                int n = int.Parse ( tAB_PROVINCIASDataGridView.CurrentRow.Cells [ 0 ].Value.ToString ( ) );
                string dato = tAB_PROVINCIASDataGridView.CurrentRow.Cells [ 1 ].Value.ToString ( );
                if ( MessageBox.Show ( dato + " ¿Está seguro de ELIMINAR?", "Aviso", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question ) == DialogResult.Yes )
                {

                    obj.DeleteQuery_PROVINCIAS ( n );
                    this.tAB_PROVINCIASTableAdapter.Fill ( this.dSveterinaria.TAB_PROVINCIAS );
                }

            }
            else
            {
                if ( MessageBox.Show ( "NO HAY REGISTROS PARA ELIMINAR", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Stop ) == DialogResult.Yes )
                {

                }
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

            if ( tAB_PROVINCIASDataGridView.RowCount > 0 )
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

        private void pROVINCIATextBox_KeyPress ( object sender, KeyPressEventArgs e )
        {
            Metodos.SoloLetras(e);
        }
        public void enabledFALSE ( )
        {
            
            pROVINCIATextBox.Enabled = false;

        }
        public void enabledTRUE ( )
        {

            pROVINCIATextBox.Enabled = true;

        }

        private void txtBuscar_TextChanged ( object sender, EventArgs e )
        {
            this.tAB_PROVINCIASTableAdapter.FillBy_search_Provincias(this.dSveterinaria.TAB_PROVINCIAS);
        }
    }
}
