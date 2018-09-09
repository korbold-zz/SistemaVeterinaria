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
    public partial class FRM_Roles : Form
    {
        public FRM_Roles()
        {
            InitializeComponent();
        }

        private void tAB_ROLESBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tAB_ROLESBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSveterinaria);

        }

        private void tAB_ROLESBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.tAB_ROLESBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSveterinaria);

        }

        private void tAB_ROLESBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.tAB_ROLESBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dSveterinaria);
                Metodos.BotonGUARDAR ( btnActualizar, btnCancelar, btnGuardar, btnAgregar, btnEliminar );
                rOLTextBox.Enabled = false;
            }
            catch ( Exception )
            {
                
                 if (MessageBox.Show("Ingrese los Datos antes de GUARGAR", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Stop) == DialogResult.Yes)
                {

                }
            }

        }

        private void FRM_Roles_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSveterinaria.TAB_ROLES' Puede moverla o quitarla según sea necesario.
            this.tAB_ROLESTableAdapter.Fill(this.dSveterinaria.TAB_ROLES);
            rOLTextBox.Enabled = false;
            Metodos.BotonLOAD(btnActualizar, btnCancelar, btnGuardar, btnAgregar,btnEliminar);

        }

        private void bindingNavigatorAddNewItem_Click ( object sender, EventArgs e )
        {
            Metodos.BotonAGREGAR ( btnActualizar, btnCancelar, btnGuardar, btnAgregar, btnEliminar );
            rOLTextBox.Enabled = true;
        }

        private void btnActualizar_Click ( object sender, EventArgs e )
        {
            if ( tAB_ROLESDataGridView.RowCount > 0 )
            {
                Metodos.BotonACTUALIZAR ( btnActualizar, btnCancelar, btnGuardar, btnAgregar, btnEliminar );
                rOLTextBox.Enabled = true;
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
            this.tAB_ROLESTableAdapter.Fill ( this.dSveterinaria.TAB_ROLES );
            Metodos.BotonLOAD(btnActualizar, btnCancelar, btnGuardar, btnAgregar,btnEliminar);
            rOLTextBox.Enabled = false;
        }

        private void bindingNavigatorDeleteItem_Click ( object sender, EventArgs e )
        {
            DSveterinariaTableAdapters.TAB_ROLESTableAdapter obj = new DSveterinariaTableAdapters.TAB_ROLESTableAdapter();
            int n = int.Parse(tAB_ROLESDataGridView.CurrentRow.Cells [ 0 ].Value.ToString());
            string dato = tAB_ROLESDataGridView.CurrentRow.Cells [ 0 ].Value.ToString();

            if ( tAB_ROLESDataGridView.RowCount > 0 )
            {
                if ( MessageBox.Show(dato + " ¿Está seguro de ELIMINAR?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes )
                {

                    obj.DeleteQuery_ROL(n);
                }

            }
            else
            {
                if ( MessageBox.Show("NO HAY REGISTROS PARA ELIMINAR", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Stop) == DialogResult.Yes )
                {

                }
            }
        }

        private void rOLTextBox_KeyPress ( object sender, KeyPressEventArgs e )
        {
            Metodos.SoloLetras ( e );
        }
    }
}
