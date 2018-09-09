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
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
          
        }

        private void btnCancelar_Click ( object sender, EventArgs e )
        {
           
        }

        private void btnAceptar_Click_1 ( object sender, EventArgs e )
        {
            DSveterinariaTableAdapters.TAB_USUARIOSTableAdapter TB = new
              DSveterinariaTableAdapters.TAB_USUARIOSTableAdapter ( ); // acesso de la base de datos 
            DSveterinaria.TAB_USUARIOSDataTable dt = new DSveterinaria.TAB_USUARIOSDataTable ( );// almacenar los datos 

            TB.FillByUsuario ( dt, txtUsuario.Text, txtClave.Text );

            if ( dt.Rows.Count > 0 )
            {
                DSveterinaria.TAB_USUARIOSRow fila = dt [ 0 ];

                MDIMenu obj = new MDIMenu ( );


                obj.nom_usu = fila.NOMBRE_USUARIO;

                if ( MessageBox.Show ( "Bienvenido  " + fila.NOMBRE_USUARIO + "  ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information ) == DialogResult.Yes )
                {

                }

                obj.ShowDialog ( );
                Application.Exit ( );


            }
            else
            {
                if ( MessageBox.Show ( "Usuario y Contraseña no coinciden o no existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error ) == DialogResult.Yes )
                {

                }
            }
        }

        private void btnCancelar_Click_1 ( object sender, EventArgs e )
        {
            Application.Exit ( );
        }

        private void LOGIN_Load(object sender, EventArgs e)
        {

        }
    }
}
