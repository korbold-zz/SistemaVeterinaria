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
    public partial class FRM_Cliente : Form
    {
        public FRM_Cliente ( )
        {
            InitializeComponent ( );
        }

        private void tAB_CLIENTESBindingNavigatorSaveItem_Click ( object sender, EventArgs e )
        {
            this.Validate ( );
            this.tAB_CLIENTESBindingSource.EndEdit ( );
            this.tableAdapterManager.UpdateAll ( this.dSveterinaria );

        }

        private void FRM_Cliente_Load ( object sender, EventArgs e )
        {
            // TODO: esta línea de código carga datos en la tabla 'dSveterinaria.TAB_PERSONA' Puede moverla o quitarla según sea necesario.
            this.tAB_PERSONATableAdapter.Fill ( this.dSveterinaria.TAB_PERSONA );
            // TODO: esta línea de código carga datos en la tabla 'dSveterinaria.TAB_CLIENTES' Puede moverla o quitarla según sea necesario.
            this.tAB_CLIENTESTableAdapter.Fill ( this.dSveterinaria.TAB_CLIENTES );

        }

        private void fillBy_UNION_PERSONA_CLIENTEToolStripButton_Click ( object sender, EventArgs e )
        {
            try
            {
                this.tAB_CLIENTESTableAdapter.FillBy_UNION_PERSONA_CLIENTE ( this.dSveterinaria.TAB_CLIENTES );
            }
            catch ( System.Exception ex )
            {
                System.Windows.Forms.MessageBox.Show ( ex.Message );
            }

        }
    }
}
