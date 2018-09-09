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
    public partial class FRM_Medicos : Form
    {
        public FRM_Medicos ( )
        {
            InitializeComponent();
        }

        private void tAB_MEDICOSBindingNavigatorSaveItem_Click ( object sender, EventArgs e )
        {
            try
            {
                this.Validate();
                this.tAB_MEDICOSBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dSveterinaria);
                btnAgregar.Enabled = true;
                iD_PERSONAComboBox.Enabled = false;
                cARGOTextBox.Enabled = false;
                fECHA_REGISTRODateTimePicker.Enabled = false;
                Metodos.BotonGUARDAR(btnActualizar, btnCancelar, btnGuardar, btnAgregar,btnEliminar);

               
            }
            catch ( Exception )
            {
                
                if (MessageBox.Show("Ingrese los Datos antes de GUARGAR", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Stop) == DialogResult.Yes)
                {

                }
            }

        }

        private void FRM_Medicos_Load ( object sender, EventArgs e )
        {
            // TODO: esta línea de código carga datos en la tabla 'dSveterinaria.TAB_PERSONA' Puede moverla o quitarla según sea necesario.
            this.tAB_PERSONATableAdapter.Fill(this.dSveterinaria.TAB_PERSONA);
            // TODO: esta línea de código carga datos en la tabla 'dSveterinaria.TAB_MEDICOS' Puede moverla o quitarla según sea necesario.
            this.tAB_MEDICOSTableAdapter.Fill(this.dSveterinaria.TAB_MEDICOS);

            iD_PERSONAComboBox.Enabled = false;
            cARGOTextBox.Enabled = false;
            fECHA_REGISTRODateTimePicker.Enabled = false;
            Metodos.BotonLOAD(btnActualizar, btnCancelar, btnGuardar, btnAgregar,btnEliminar);
        }
        Metodos operar = new Metodos();
        private void cARGOTextBox_Validated ( object sender, EventArgs e )
        {
            Metodos.textoVACIOS(cARGOTextBox, errorProvider1, "Ingrese el CARGO"); 
        }

        private void bindingNavigatorAddNewItem_Click ( object sender, EventArgs e )
        {
            Metodos.BotonAGREGAR ( btnActualizar, btnCancelar, btnGuardar, btnAgregar, btnEliminar );
            iD_PERSONAComboBox.Enabled = true;
            fECHA_REGISTRODateTimePicker.Enabled = true;
            cARGOTextBox.Enabled = true;
           
        }

        private void btnCancelar_Click ( object sender, EventArgs e )
        {
            this.tAB_MEDICOSTableAdapter.Fill ( this.dSveterinaria.TAB_MEDICOS );
            Metodos.BotonCANCELAR(cARGOTextBox);
            Metodos.BotonLOAD(btnActualizar, btnCancelar, btnGuardar, btnAgregar,btnEliminar);
            iD_PERSONAComboBox.Enabled = false;
            cARGOTextBox.Enabled = false;
            fECHA_REGISTRODateTimePicker.Enabled = false;
        }

        private void panel1_Paint ( object sender, PaintEventArgs e )
        {

        }

        private void bindingNavigatorDeleteItem_Click ( object sender, EventArgs e )
        {
            DSveterinariaTableAdapters.TAB_MEDICOSTableAdapter obj = new DSveterinariaTableAdapters.TAB_MEDICOSTableAdapter();
            int n = int.Parse(tAB_MEDICOSDataGridView.CurrentRow.Cells [ 0 ].Value.ToString());
            string dato = tAB_MEDICOSDataGridView.CurrentRow.Cells [ 0 ].Value.ToString();

            if (  tAB_MEDICOSDataGridView.RowCount>0 )
            {
                if ( MessageBox.Show(dato+" ¿Está seguro de ELIMINAR?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes )
                {
                    
                    obj.DeleteQuery_MEDICOS(n);
                }
                
            }
            else
            {
                if ( MessageBox.Show("NO HAY REGISTROS PARA ELIMINAR", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Stop) == DialogResult.Yes )
                {

                }
            }
        }

        private void btnActualizar_Click ( object sender, EventArgs e )
        {
            if ( tAB_MEDICOSDataGridView.RowCount > 0 )
            {
                iD_PERSONAComboBox.Enabled = true;
                fECHA_REGISTRODateTimePicker.Enabled = true;
                cARGOTextBox.Enabled = true;
                Metodos.BotonACTUALIZAR ( btnActualizar, btnCancelar, btnGuardar, btnAgregar, btnEliminar );
            }
            else
            {
                if ( MessageBox.Show ( "NO HAY REGISTROS PARA ACTUALIZAR", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Stop ) == DialogResult.Yes )
                {

                }
            }
            
            
        }

        private void cARGOTextBox_KeyPress ( object sender, KeyPressEventArgs e )
        {
            Metodos.SoloLetras ( e );
        }

        private void cARGOTextBox_Leave ( object sender, EventArgs e )
        {
           
        }

       
    }
}
