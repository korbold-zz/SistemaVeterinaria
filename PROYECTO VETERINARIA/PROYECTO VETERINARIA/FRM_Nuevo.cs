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
    public partial class FRM_Nuevo : Form
    {
        public FRM_Nuevo()
        {
            InitializeComponent();
        }

        private void tAB_FICHA_DE_INGRESOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }
        public void LOADtext ( )
        {
           cEDULATextBox.Text="";
           pRIMER_NOMBRETextBox.Text = "";
           pRIMER_APELLIDOTextBox.Text = "";
           sEGUNDO_NOMBRETextBox.Text = "";
           sEGUNDO_APELLIDOTextBox.Text = "";
           dIRECCION_CALLETextBox.Text = "";
           dIRECCION_NUMEROTextBox.Text = "";
           nUMERO_CELULARTextBox.Text = "";
           nUMERO_TELEFONOTextBox.Text = "";
        }
        public void enabledFALSE ( )
        {
            iD_PERSONAComboBox.Enabled = false;
            iD_TIPODEMASCOTAComboBox.Enabled = false;
            iD_RAZAComboBox.Enabled = false;
            nOMBRETextBox.Enabled = false;
            cOLORTextBox.Enabled = false;
            btnGuardarMascota.Enabled = false;

        }
        public void enabledTRUE ( )
        {
            iD_PERSONAComboBox.Enabled = true;
            iD_TIPODEMASCOTAComboBox.Enabled = true;
            iD_RAZAComboBox.Enabled = true;
            nOMBRETextBox.Enabled = true;
            cOLORTextBox.Enabled = true;
            btnGuardarMascota.Enabled = true;

        }
        public void enabledFALSEcedula ( )
        {
            iD_PROVINCIAComboBox.Enabled = false;
            iD_CANTONComboBox.Enabled = false;
            btn_Guardar.Enabled = false;

            sEGUNDO_NOMBRETextBox.Enabled = false;
            pRIMER_APELLIDOTextBox.Enabled = false;
            sEGUNDO_APELLIDOTextBox.Enabled = false;
            dIRECCION_CALLETextBox.Enabled = false;
            dIRECCION_NUMEROTextBox.Enabled = false;
            nUMERO_TELEFONOTextBox.Enabled = false;
            nUMERO_CELULARTextBox.Enabled = false;
        }
        public void enabledTRUEcedula ( )
        {
            btn_Guardar.Enabled = true;
            iD_PROVINCIAComboBox.Enabled = true;
            iD_CANTONComboBox.Enabled = true;
            cEDULATextBox.Enabled = true;
            pRIMER_NOMBRETextBox.Enabled = true;
            sEGUNDO_NOMBRETextBox.Enabled = true;
            pRIMER_APELLIDOTextBox.Enabled = true;
            sEGUNDO_APELLIDOTextBox.Enabled = true;
            dIRECCION_CALLETextBox.Enabled = true;
            dIRECCION_NUMEROTextBox.Enabled = true;
            nUMERO_TELEFONOTextBox.Enabled = true;
            nUMERO_CELULARTextBox.Enabled = true;
        }
      
        public void enabledFALSE_FICHA ( )
        {
            iD_MASCOTAComboBox.Enabled = false;
            iD_PERSONAComboBox.Enabled = false;
            fECHADateTimePicker.Enabled = false;
            dESCRIPCIONTextBox.Enabled = false;
            dIAGNOSTICOTextBox.Enabled = false;
            eSTADOTextBox.Enabled = false;
            pESOTextBox.Enabled = false;
            tEMPERATURATextBox.Enabled = false;
            btnGuardar_Ficha.Enabled = false;
        }
        public void enabledTRUE_FICHA ( )
        {
            iD_MASCOTAComboBox.Enabled = true;
          iD_PERSONAComboBox.Enabled = true;
            fECHADateTimePicker.Enabled = true;
            dESCRIPCIONTextBox.Enabled = true;
            dIAGNOSTICOTextBox.Enabled = true;
            eSTADOTextBox.Enabled = true;
            pESOTextBox.Enabled = true;
            tEMPERATURATextBox.Enabled = true;
            btnGuardar_Ficha.Enabled = true;
        }

        private void FRM_Nuevo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSveterinaria.TAB_FICHA_DE_INGRESO' Puede moverla o quitarla según sea necesario.
            this.tAB_FICHA_DE_INGRESOTableAdapter.Fill ( this.dSveterinaria.TAB_FICHA_DE_INGRESO );
            // TODO: esta línea de código carga datos en la tabla 'dSveterinaria.TAB_MASCOTA' Puede moverla o quitarla según sea necesario.
            this.tAB_MASCOTATableAdapter.Fill ( this.dSveterinaria.TAB_MASCOTA );
            // TODO: esta línea de código carga datos en la tabla 'dSveterinaria.TAB_RAZA' Puede moverla o quitarla según sea necesario.
            this.tAB_RAZATableAdapter.Fill(this.dSveterinaria.TAB_RAZA);
            // TODO: esta línea de código carga datos en la tabla 'dSveterinaria.TAB_TIPO_DE_MASCOTA' Puede moverla o quitarla según sea necesario.
            this.tAB_TIPO_DE_MASCOTATableAdapter.Fill(this.dSveterinaria.TAB_TIPO_DE_MASCOTA);
            // TODO: esta línea de código carga datos en la tabla 'dSveterinaria.TAB_PERSONA' Puede moverla o quitarla según sea necesario.
            this.tAB_PERSONATableAdapter.Fill(this.dSveterinaria.TAB_PERSONA);
            // TODO: esta línea de código carga datos en la tabla 'dSveterinaria.TAB_CANTONES' Puede moverla o quitarla según sea necesario.
            this.tAB_CANTONESTableAdapter.Fill(this.dSveterinaria.TAB_CANTONES);
            // TODO: esta línea de código carga datos en la tabla 'dSveterinaria.TAB_PROVINCIAS' Puede moverla o quitarla según sea necesario.
            this.tAB_PROVINCIASTableAdapter.Fill(this.dSveterinaria.TAB_PROVINCIAS);
            LOADtext ( );
            enabledFALSE();
            enabledFALSE_FICHA ( );

        }

        

        private void btn_Guardar_Click(object sender, EventArgs e)
     
        {
            FRM_Clientes frm = new FRM_Clientes ( );
           
            try
            {

                string a =cEDULATextBox.Text;
                if ( cEDULATextBox.Text.Length == 10 )
                {
                    string c = Metodos.ValidarCedula ( a ).ToString ( );
                    if ( c == cEDULATextBox.Text.Substring ( 9, 1 ) )
                    {

                        Metodos.textoVACIOS ( cEDULATextBox, errorProvider1, "Correcto" );
                        if ( pRIMER_APELLIDOTextBox.Text.Length > 0 || sEGUNDO_APELLIDOTextBox.Text.Length > 0 || pRIMER_NOMBRETextBox.Text.Length > 0 || sEGUNDO_NOMBRETextBox.Text.Length > 0 || dIRECCION_NUMEROTextBox.Text.Length > 0 || dIRECCION_CALLETextBox.Text.Length > 0 || nUMERO_CELULARTextBox.Text.Length > 0 || nUMERO_TELEFONOTextBox.Text.Length > 0 )
                        {
                            guardarDATOS_PERSONAS ( );
                            if ( MessageBox.Show ( "GUARDADO CON EXITO", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information ) == DialogResult.Yes )
                            {

                            }
                            frm.ShowDialog ( );
                           
                            enabledTRUE ( );

                        }
                        else
                        {
                            if ( MessageBox.Show ( "Hay campos vacios", "AVISO", MessageBoxButtons.OK,
                       MessageBoxIcon.Stop ) == DialogResult.Yes )
                            {

                            }
                            Metodos.textoVACIObad ( cEDULATextBox, errorProvider1, "Ingrese la cédula" );
                        }  
                    }
                    else
                    { 
                        if ( MessageBox.Show ( "No existe su numero de cédula: " + cEDULATextBox.Text, "AVISO", MessageBoxButtons.OK,
                        MessageBoxIcon.Stop ) == DialogResult.Yes )
                        {

                        }
                    }
                }
                else
                {
                    if ( MessageBox.Show ( "Hay campos vacios", "AVISO", MessageBoxButtons.OK,
                        MessageBoxIcon.Stop ) == DialogResult.Yes )
                    {

                    }
                    Metodos.textoVACIObad ( cEDULATextBox, errorProvider1, "Ingrese la cédula" );
                }      
                
            }
            catch ( Exception )
            {
                
                 if ( MessageBox.Show("Hay campos vacios", "AVISO", MessageBoxButtons.OK,
                        MessageBoxIcon.Stop) == DialogResult.Yes )
                    {

                    }
                 Metodos.textoVACIObad ( cEDULATextBox, errorProvider1, "Ingrese la cédula" );
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DSveterinariaTableAdapters.TAB_MASCOTATableAdapter Mascota = new DSveterinariaTableAdapters.TAB_MASCOTATableAdapter ( );
                int ID_PERSONA = int.Parse ( iD_PERSONAComboBox.SelectedValue.ToString ( ) );
                int ID_TIPOMASCOTA = int.Parse ( iD_TIPODEMASCOTAComboBox.SelectedValue.ToString ( ) );
                int ID_raza = int.Parse ( iD_RAZAComboBox.SelectedValue.ToString ( ) );
                Mascota.InsertQuery_MASCOTA ( ID_PERSONA, ID_TIPOMASCOTA, ID_raza, nOMBRETextBox.Text, cOLORTextBox.Text );
                if ( MessageBox.Show ( "GUARDADO CON EXITO", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information ) == DialogResult.Yes )
                {

                }
                enabledTRUE_FICHA ( );
            }
            catch ( Exception )
            {
                
                 if ( MessageBox.Show ( "Campos Vacíos ", "AVISO", MessageBoxButtons.OK,
                    MessageBoxIcon.Stop ) == DialogResult.Yes )
                    {
                        
                    }
            }
           
        }

        private void cEDULATextBox_Validated ( object sender, EventArgs e )
        {
            string a =cEDULATextBox.Text;
            if ( cEDULATextBox.Text.Length == 10 )
            {
                string c = Metodos.ValidarCedula ( a ).ToString ( );
                if ( c == cEDULATextBox.Text.Substring ( 9, 1 ) )
                {
                    if ( validar_existencia(cEDULATextBox)== cEDULATextBox.Text)
                    {
                        enabledFALSEcedula ( );
                        Metodos.textoVACIObad1 ( cEDULATextBox, errorProvider1, "Cédula ya existe" );

                    }
                    else
                    {
                        Metodos.textoVACIOS ( cEDULATextBox, errorProvider1, "Correcto" );
                        enabledTRUEcedula ( );
                    }

                   
                    
                }
                else
                {
                    Metodos.textoVACIObad ( cEDULATextBox, errorProvider1, "Cédula no existe" );
                    enabledFALSEcedula ( );
                    if ( MessageBox.Show ( "No existe su numero de cédula: " + cEDULATextBox.Text, "AVISO", MessageBoxButtons.OK,
                    MessageBoxIcon.Stop ) == DialogResult.Yes )
                    {
                        
                    }
                }
            }
            else
            {
                enabledFALSEcedula ( );
                Metodos.textoVACIObad ( cEDULATextBox, errorProvider1, "La cédula es corta o excedio\n Verifique" );
                if ( MessageBox.Show ( "La cédula es corta o excedio la cantidad\n Verifique " + cEDULATextBox.Text, "AVISO", MessageBoxButtons.OK,
                    MessageBoxIcon.Stop ) == DialogResult.Yes )
                {
                   
                }
            }
        }

        private void cEDULATextBox_KeyPress ( object sender, KeyPressEventArgs e )
        {
            Metodos.SoloNumeros ( e );
        }
        public void guardarDATOS_PERSONAS ( )
        {
            DSveterinariaTableAdapters.TAB_PERSONATableAdapter Personas = new DSveterinariaTableAdapters.TAB_PERSONATableAdapter ( );
            int provincia = int.Parse ( iD_PROVINCIAComboBox.SelectedValue.ToString ( ) );
            int canton = int.Parse ( iD_CANTONComboBox.SelectedValue.ToString ( ) );
           
                Personas.InsertQuery_PERSONAS ( provincia, canton, cEDULATextBox.Text, pRIMER_NOMBRETextBox.Text, sEGUNDO_NOMBRETextBox.Text
                , pRIMER_APELLIDOTextBox.Text, sEGUNDO_APELLIDOTextBox.Text, dIRECCION_CALLETextBox.Text, dIRECCION_NUMEROTextBox.Text, nUMERO_TELEFONOTextBox.Text
                , nUMERO_CELULARTextBox.Text );
            
            

            this.tAB_PERSONATableAdapter.Fill ( this.dSveterinaria.TAB_PERSONA );
        }
        public void guardarDATOS_FICHA ( )
        {
            DSveterinariaTableAdapters.TAB_FICHA_DE_INGRESOTableAdapter obj = new DSveterinariaTableAdapters.TAB_FICHA_DE_INGRESOTableAdapter ( );
            int id_mascota = int.Parse ( iD_MASCOTAComboBox.SelectedValue.ToString ( ) );
            int id_persona = int.Parse ( iD_PERSONAComboBox.SelectedValue.ToString ( ) );
            DateTime date = fECHADateTimePicker.Value.Date;
            decimal peso = decimal.Parse(pESOTextBox.Text);
            decimal temperatura = decimal.Parse ( tEMPERATURATextBox.Text );
                obj.InsertQuery_FICHA_INGRESO (id_mascota,id_persona,date,dESCRIPCIONTextBox.Text,dIAGNOSTICOTextBox.Text,eSTADOTextBox.Text,peso,temperatura );
                this.tAB_MASCOTATableAdapter.Fill ( this.dSveterinaria.TAB_MASCOTA );
        }

        public  string validar_existencia ( TextBox cedula)
        {
            DSveterinariaTableAdapters.TAB_PERSONATableAdapter TB = new
                DSveterinariaTableAdapters.TAB_PERSONATableAdapter ( ); // acesso de la base de datos 
            DSveterinaria.TAB_PERSONADataTable dt = new DSveterinaria.TAB_PERSONADataTable ( );// almacenar los datos 

            TB.FillBy_SELECT_PERSONA ( dt, cedula.Text );
             DSveterinaria.TAB_PERSONARow fila;
             string a="";
            if ( dt.Rows.Count > 0 )
            {
                fila= dt [ 0 ];
                a = fila.CEDULA;
                if ( MessageBox.Show ( "Ya está Registrado\n Intente con otro número de cédula ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning ) == DialogResult.Yes )
                {

                }

            }
            
            return a;
           
        }

        private void iD_PROVINCIAComboBox_SelectedIndexChanged ( object sender, EventArgs e )
        {
            
        }

        private void iD_PROVINCIAComboBox_Click ( object sender, EventArgs e )
        {
           
        }

        private void iD_PROVINCIAComboBox_MouseClick ( object sender, MouseEventArgs e )
        {
           
        }

        private void pRIMER_NOMBRETextBox_KeyPress ( object sender, KeyPressEventArgs e )
        {
            Metodos.SoloLetras ( e );
        }

        private void sEGUNDO_NOMBRETextBox_KeyPress ( object sender, KeyPressEventArgs e )
        {
            Metodos.SoloLetras ( e );
        }

        private void pRIMER_APELLIDOTextBox_KeyPress ( object sender, KeyPressEventArgs e )
        {
            Metodos.SoloLetras ( e );
        }

        private void sEGUNDO_APELLIDOTextBox_KeyPress ( object sender, KeyPressEventArgs e )
        {
            Metodos.SoloLetras ( e );
        }

        private void dIRECCION_CALLETextBox_KeyPress ( object sender, KeyPressEventArgs e )
        {
            Metodos.SoloLetras ( e );
        }

        private void nOMBRETextBox_KeyPress ( object sender, KeyPressEventArgs e )
        {
            Metodos.SoloLetras ( e );
        }

        private void cOLORTextBox_KeyPress ( object sender, KeyPressEventArgs e )
        {
            Metodos.SoloLetras ( e );
        }

        private void dIRECCION_NUMEROTextBox_KeyPress ( object sender, KeyPressEventArgs e )
        {
            Metodos.SoloNumeros ( e );
        }

        private void nUMERO_TELEFONOTextBox_KeyPress ( object sender, KeyPressEventArgs e )
        {
            Metodos.SoloNumeros ( e );
        }

        private void nUMERO_CELULARTextBox_KeyPress ( object sender, KeyPressEventArgs e )
        {
            Metodos.SoloNumeros ( e );
        }

        private void btnGuardar_Ficha_Click ( object sender, EventArgs e )
        {
            
        }

        private void cEDULATextBox_TextChanged ( object sender, EventArgs e )
        {

        }

        private void btnGuardar_Ficha_Click_1 ( object sender, EventArgs e )
        {
            try
            {
                guardarDATOS_FICHA ( );
            }
            catch ( Exception )
            {
                if ( MessageBox.Show ( "Hay campos vacíos", "AVISO", MessageBoxButtons.OK,
                       MessageBoxIcon.Stop ) == DialogResult.Yes )
                {

                }

            }
        }
    }
}

