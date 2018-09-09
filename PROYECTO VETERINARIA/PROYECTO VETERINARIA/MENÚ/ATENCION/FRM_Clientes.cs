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
    public partial class FRM_Clientes : Form
    {
        public FRM_Clientes()
        {
            InitializeComponent();
        }

        private void tAB_CLIENTESBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate ( );
                this.tAB_CLIENTESBindingSource.EndEdit ( );
                this.tableAdapterManager.UpdateAll ( this.dSveterinaria );
                Metodos.BotonGUARDAR ( btnActualizar, btnCancelar, btnGuardar, btnAgregar, btnEliminar );
                iD_PERSONAComboBox.Enabled = false;
                fECHA_REGISTRODateTimePicker.Enabled = false;
            }
            catch ( Exception )
            {
                
                if (MessageBox.Show("Ingrese los Datos antes de GUARGAR", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Stop) == DialogResult.Yes)
                {

                }
            }

        }

        private void FRM_Clientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSveterinaria.TAB_PERSONA' Puede moverla o quitarla según sea necesario.
            this.tAB_PERSONATableAdapter.Fill(this.dSveterinaria.TAB_PERSONA);
            // TODO: esta línea de código carga datos en la tabla 'dSveterinaria.TAB_CLIENTES' Puede moverla o quitarla según sea necesario.
            this.tAB_CLIENTESTableAdapter.Fill(this.dSveterinaria.TAB_CLIENTES);
            Metodos.BotonLOAD(btnActualizar, btnCancelar, btnGuardar, btnAgregar,btnEliminar);
            iD_PERSONAComboBox.Enabled = false;
            fECHA_REGISTRODateTimePicker.Enabled = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Metodos.BotonAGREGAR ( btnActualizar, btnCancelar, btnGuardar, btnAgregar, btnEliminar );
            iD_PERSONAComboBox.Enabled = true;
            fECHA_REGISTRODateTimePicker.Enabled = true;
        }

       private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (tAB_CLIENTESDataGridView.RowCount > 0)
            {
                Metodos.BotonACTUALIZAR ( btnActualizar, btnCancelar, btnGuardar, btnAgregar, btnEliminar );
                    iD_PERSONAComboBox.Enabled = true;
                    fECHA_REGISTRODateTimePicker.Enabled = true;
            }
            else
            {
                if (MessageBox.Show("NO HAY REGISTROS PARA ACTUALIZAR", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Stop) == DialogResult.Yes)
                {

                }
            }
           
        }

        private void btnCancelar_Click ( object sender, EventArgs e )
        {
            this.tAB_CLIENTESTableAdapter.Fill ( this.dSveterinaria.TAB_CLIENTES );
            Metodos.BotonLOAD ( btnActualizar, btnCancelar, btnGuardar, btnAgregar ,btnGuardar);
            iD_PERSONAComboBox.Enabled = false;
            fECHA_REGISTRODateTimePicker.Enabled = false;
        }

        private void bindingNavigatorDeleteItem_Click ( object sender, EventArgs e )
        {
            DSveterinariaTableAdapters.TAB_CLIENTESTableAdapter obj = new DSveterinariaTableAdapters.TAB_CLIENTESTableAdapter ( );
            int n = int.Parse ( tAB_CLIENTESDataGridView.CurrentRow.Cells [ 0 ].Value.ToString ( ) );
           
            string dato = tAB_CLIENTESDataGridView.CurrentRow.Cells [ 0 ].Value.ToString ( );

            if ( tAB_CLIENTESDataGridView.RowCount > 0 )
            {
                if ( MessageBox.Show ( dato + " ¿Está seguro de ELIMINAR?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Error ) == DialogResult.Yes )
                {

                    obj.DeleteQuery_CLIENTES ( n+1 );
                    this.tAB_CLIENTESTableAdapter.Fill ( this.dSveterinaria.TAB_CLIENTES );
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
