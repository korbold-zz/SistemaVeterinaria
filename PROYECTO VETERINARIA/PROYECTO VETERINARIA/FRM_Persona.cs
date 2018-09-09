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
    public partial class FRM_Persona : Form
    {
        public FRM_Persona ( )
        {
            InitializeComponent ( );
        }
        public void enabledFALSEcedula ( )
        {
            iD_PROVINCIAComboBox.Enabled = false;
            iD_CANTONComboBox.Enabled = false;
            
           
            sEGUNDO_NOMBRETextBox.Enabled = false;
            pRIMER_APELLIDOTextBox.Enabled = false;
            sEGUNDO_APELLIDOTextBox.Enabled = false;
            dIRECCION_CALLETextBox.Enabled = false;
            dIRECCION_NUMEROTextBox.Enabled = false;
            nUMERO_TELEFONOTextBox.Enabled = false;
            nUMERO_CELULARTextBox.Enabled = false;
        }
        public void enabledFALSE ( )
        {
            iD_PROVINCIAComboBox.Enabled = false;
            iD_CANTONComboBox.Enabled = false;
            cEDULATextBox.Enabled = false;
            pRIMER_NOMBRETextBox.Enabled = false;
            sEGUNDO_NOMBRETextBox.Enabled = false;
            pRIMER_APELLIDOTextBox.Enabled = false;
            sEGUNDO_APELLIDOTextBox.Enabled = false;
            dIRECCION_CALLETextBox.Enabled = false;
            dIRECCION_NUMEROTextBox.Enabled = false;
            nUMERO_TELEFONOTextBox.Enabled = false;
            nUMERO_CELULARTextBox.Enabled = false;
        }
        public void enabledTRUE ( )
        {
            iD_PROVINCIAComboBox.Enabled = true;
            iD_CANTONComboBox.Enabled = true;
           
            pRIMER_NOMBRETextBox.Enabled = true;
            sEGUNDO_NOMBRETextBox.Enabled = true;
            pRIMER_APELLIDOTextBox.Enabled = true;
            sEGUNDO_APELLIDOTextBox.Enabled = true;
            dIRECCION_CALLETextBox.Enabled = true;
            dIRECCION_NUMEROTextBox.Enabled = true;
            nUMERO_TELEFONOTextBox.Enabled = true;
            nUMERO_CELULARTextBox.Enabled = true;
        }
        private void tAB_PERSONABindingNavigatorSaveItem_Click ( object sender, EventArgs e )
        {
            try
            {
                this.Validate ( );
                this.tAB_PERSONABindingSource.EndEdit ( );
                this.tableAdapterManager.UpdateAll ( this.dSveterinaria );
                Metodos.BotonGUARDAR ( btnActualizar, btnCancelar, btnGuardar, btnAgregar, btnEliminar );
                enabledFALSE ( );
            }
            catch ( Exception )
            {

                if ( MessageBox.Show ( "Ingrese los Datos antes de GUARGAR", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Stop ) == DialogResult.Yes )
                {

                }
            }
           

        }


        private void FRM_Persona_Load ( object sender, EventArgs e )
        {
            // TODO: esta línea de código carga datos en la tabla 'dSveterinaria.TAB_CANTONES' Puede moverla o quitarla según sea necesario.
            this.tAB_CANTONESTableAdapter.Fill ( this.dSveterinaria.TAB_CANTONES );
            // TODO: esta línea de código carga datos en la tabla 'dSveterinaria.TAB_PROVINCIAS' Puede moverla o quitarla según sea necesario.
            this.tAB_PROVINCIASTableAdapter.Fill ( this.dSveterinaria.TAB_PROVINCIAS );
            // TODO: esta línea de código carga datos en la tabla 'dSveterinaria.TAB_PERSONA' Puede moverla o quitarla según sea necesario.
            this.tAB_PERSONATableAdapter.Fill ( this.dSveterinaria.TAB_PERSONA );
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
           
        }

        private void btnActualizar_Click ( object sender, EventArgs e )
        {
            if ( tAB_PERSONADataGridView.RowCount > 0 )
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
            this.tAB_PERSONATableAdapter.Fill ( this.dSveterinaria.TAB_PERSONA );
            Metodos.BotonLOAD ( btnActualizar, btnCancelar, btnGuardar, btnAgregar, btnEliminar );
            enabledFALSE ( );
        }

        private void btnEliminar_Click_1 ( object sender, EventArgs e )
        {
            DSveterinariaTableAdapters.TAB_PERSONATableAdapter obj = new DSveterinariaTableAdapters.TAB_PERSONATableAdapter ( );

           
            if ( tAB_PERSONADataGridView.RowCount > 0 )
            {
                int n = int.Parse ( tAB_PERSONADataGridView.CurrentRow.Cells [ 0 ].Value.ToString ( ) );
                string dato = tAB_PERSONADataGridView.CurrentRow.Cells [ 1 ].Value.ToString ( );
                if ( MessageBox.Show ( dato + " ¿Está seguro de ELIMINAR?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Error ) == DialogResult.Yes )
                {
                    
                    
                    obj.DeleteQuery_PERSONAS ( n );
                    this.tAB_PERSONATableAdapter.Fill ( this.dSveterinaria.TAB_PERSONA );
                }

            }
            else
            {
                if ( MessageBox.Show ( "NO HAY REGISTROS PARA ELIMINAR", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Stop ) == DialogResult.Yes )
                {

                }
            }
        }

     


        public string validar_existencia ( TextBox cedula )
        {
            DSveterinariaTableAdapters.TAB_PERSONATableAdapter TB = new
                DSveterinariaTableAdapters.TAB_PERSONATableAdapter ( ); // acesso de la base de datos 
            DSveterinaria.TAB_PERSONADataTable dt = new DSveterinaria.TAB_PERSONADataTable ( );// almacenar los datos 

            TB.FillBy_SELECT_PERSONA ( dt, cedula.Text );
            DSveterinaria.TAB_PERSONARow fila;
            string a="";
            if ( dt.Rows.Count > 0 )
            {
                fila = dt [ 0 ];
                a = fila.CEDULA;
                if ( MessageBox.Show ( "Ya está Registrado\n Intente con otro número de cédula ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning ) == DialogResult.Yes )
                {

                }

            }
            else
            {


            }
            return a;

        }

        private void txtBuscar_TextChanged ( object sender, EventArgs e )
        {
            this.tAB_PERSONATableAdapter.FillBy_search_PERSONA ( this.dSveterinaria.TAB_PERSONA, "%" + txtBuscar.Text + "%" );
        }

        
    }
}
