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
    public partial class FRM_MedicamentosSuministrados : Form
    {
        public FRM_MedicamentosSuministrados()
        {
            InitializeComponent();
        }

        private void tAB_MEDICAMENTOS_SUMINISTRADOSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate ( );
                this.tAB_MEDICAMENTOS_SUMINISTRADOSBindingSource.EndEdit ( );
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

        private void FRM_MedicamentosSuministrados_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSveterinaria.TAB_FICHA_DE_INGRESO' Puede moverla o quitarla según sea necesario.
            this.tAB_FICHA_DE_INGRESOTableAdapter.Fill(this.dSveterinaria.TAB_FICHA_DE_INGRESO);
            // TODO: esta línea de código carga datos en la tabla 'dSveterinaria.TAB_MEDICAMENTOS' Puede moverla o quitarla según sea necesario.
            this.tAB_MEDICAMENTOSTableAdapter.Fill(this.dSveterinaria.TAB_MEDICAMENTOS);
            // TODO: esta línea de código carga datos en la tabla 'dSveterinaria.TAB_MEDICAMENTOS_SUMINISTRADOS' Puede moverla o quitarla según sea necesario.
            this.tAB_MEDICAMENTOS_SUMINISTRADOSTableAdapter.Fill(this.dSveterinaria.TAB_MEDICAMENTOS_SUMINISTRADOS);
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
            DSveterinariaTableAdapters.TAB_MEDICAMENTOS_SUMINISTRADOSTableAdapter obj = new DSveterinariaTableAdapters.TAB_MEDICAMENTOS_SUMINISTRADOSTableAdapter ( );
            int n = int.Parse ( tAB_MEDICAMENTOS_SUMINISTRADOSDataGridView.CurrentRow.Cells [ 0 ].Value.ToString ( ) );
            string dato = tAB_MEDICAMENTOS_SUMINISTRADOSDataGridView.CurrentRow.Cells [ 1 ].Value.ToString ( );


            if ( tAB_MEDICAMENTOS_SUMINISTRADOSDataGridView.RowCount > 0 )
            {
                if ( MessageBox.Show ( dato + " ¿Está seguro de ELIMINAR?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Error ) == DialogResult.Yes )
                {

                    obj.DeleteQuery_MEDICAMENTOS_SUM ( n );
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
            if ( tAB_MEDICAMENTOS_SUMINISTRADOSDataGridView.RowCount > 0 )
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
            this.tAB_MEDICAMENTOS_SUMINISTRADOSTableAdapter.Fill ( this.dSveterinaria.TAB_MEDICAMENTOS_SUMINISTRADOS );
            Metodos.BotonLOAD ( btnActualizar, btnCancelar, btnGuardar, btnAgregar, btnEliminar );
            enabledFALSE ( );
        }

        public void enabledFALSE ( )
        {
            iD_MEDICAMENTOComboBox.Enabled = false;
            iD_FICHA_INGRESOComboBox.Enabled = false;
            fECHA_SUMINISTRODateTimePicker.Enabled = false;

        }
        public void enabledTRUE ( )
        {
            iD_MEDICAMENTOComboBox.Enabled = true;
            iD_FICHA_INGRESOComboBox.Enabled = true;
            fECHA_SUMINISTRODateTimePicker.Enabled = true;

        }
    }
}
