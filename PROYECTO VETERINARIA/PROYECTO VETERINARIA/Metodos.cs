using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_VETERINARIA
{
    class Metodos
    {
        public static void textoVACIOS ( TextBox a, ErrorProvider b, String c )
        {

            if ( string.IsNullOrEmpty(a.Text)  )
            {
                b.Icon = Properties.Resources.error;
                b.SetError ( a, c );
                
            }
            else
            {
                b.Icon = Properties.Resources.bien;
                b.SetError ( a, c );
                
            }
    }
        public static void textoVACIObad ( TextBox a, ErrorProvider b, String c )
        {

            if ( string.IsNullOrEmpty ( a.Text ) )
            {
                b.Icon = Properties.Resources.error;
                b.SetError ( a, c );

            }
            else
            {
                b.Icon = Properties.Resources.bien;
                b.SetError ( a, c );

            }
        }

        public static void textoVACIObad1 ( TextBox a, ErrorProvider b, String c )
        {

            if ( string.IsNullOrEmpty ( a.Text ) )
            {
                b.Icon = Properties.Resources.bien;
                b.SetError ( a, c );

            }
            else
            {
                b.Icon = Properties.Resources.error;
                b.SetError ( a, c );

            }
        }
        public static void BotonAGREGAR (  ToolStripButton Actualizar , ToolStripButton Cancelar, ToolStripButton Guardar, ToolStripButton Agregar, ToolStripButton Eliminar )
        {
            try
            {

                    Agregar.Enabled = false;
                    Cancelar.Enabled = true;
                    Actualizar.Enabled = false;
                    Guardar.Enabled = true;
                    Eliminar.Enabled = false;

               
            }
            catch ( Exception )
            {
                if ( MessageBox.Show("Ingrese el Dato antes de AGREGAR OTRO", "AVISO", MessageBoxButtons.OK,
                    MessageBoxIcon.Stop) == DialogResult.Yes )
                {

                }
            }
        }


        public static void BotonCANCELAR ( TextBox a )
        {
            a.Text = "";
        }

        public static void BotonACTUALIZAR ( ToolStripButton Actualizar, ToolStripButton Cancelar, ToolStripButton Guardar, ToolStripButton Agregar, ToolStripButton Eliminar )
        {
           
            Actualizar.Enabled = false;
            Cancelar.Enabled = true;
            Agregar.Enabled = false;
            Guardar.Enabled = true;
            Eliminar.Enabled = true;
        }
        public static void BotonLOAD ( ToolStripButton Actualizar, ToolStripButton Cancelar, ToolStripButton Guardar, ToolStripButton Agregar ,ToolStripButton Eliminar)
        {

            Actualizar.Enabled = true;
            Cancelar.Enabled = false;
            Agregar.Enabled = true;
            Guardar.Enabled = false;
            Eliminar.Enabled = false;
        }
        public static void BotonGUARDAR ( ToolStripButton Actualizar, ToolStripButton Cancelar, ToolStripButton Guardar, ToolStripButton Agregar, ToolStripButton Eliminar )
        {

            Actualizar.Enabled = true;
            Cancelar.Enabled = false;
            Agregar.Enabled = true;
            Guardar.Enabled = false;
            Eliminar.Enabled = true;
        }


        public static void SoloNumeros ( KeyPressEventArgs pE )
        {
            if ( char.IsDigit(pE.KeyChar) )
            {
                pE.Handled = false;
            }
            else if ( char.IsControl(pE.KeyChar) )
            {
                pE.Handled = false;
            }
            else
            {
                pE.Handled = true;
            }
        }


        public static void SoloLetras ( KeyPressEventArgs pE )
        {
            if ( Char.IsLetter(pE.KeyChar) )
            {
                pE.Handled = false;
            }
            else if ( Char.IsControl(pE.KeyChar) )
            {
                pE.Handled = false;
            }
            else if ( Char.IsSeparator(pE.KeyChar) )
            {
                pE.Handled = false;
            }
            else
            {
                pE.Handled = true;
            }
        }

        public static int ValidarCedula (string cedula )
        {
            
            char[] vector = cedula.ToArray();
            int sumatotal = 0;
            
                for ( int i = 0; i < vector.Length - 1; i++ )
                {
                    int numero = Convert.ToInt32(vector [ i ].ToString());
                    if ( ( i + 1 ) % 2 == 1 )
                    {
                        numero = Convert.ToInt32(vector [ i ].ToString()) * 2;
                        if ( numero > 9 )
                        {
                            numero = numero - 9;
                        }
                    }
                    sumatotal += numero;
                }
                sumatotal = 10 - ( sumatotal % 10 );

                return sumatotal;
            
        }

        
    }
}
