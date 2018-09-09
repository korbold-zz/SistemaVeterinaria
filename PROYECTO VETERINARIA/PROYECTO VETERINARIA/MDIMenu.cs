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
    public partial class MDIMenu : Form
    {
        public string nom_usu;

        public MDIMenu()
        {
            InitializeComponent();
           
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            cargarFormulario(new FRM_Nuevo(), "Nuevo");
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        //Invocacion a cualquier formulario
        private void cargarFormulario(Form childForm, String Titulo)
        {

            childForm.MdiParent = this;
            childForm.Text = Titulo;
            childForm.Show();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cargarFormulario(new FRM_Usuarios(),"Usuarios");
        }

        private void rolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cargarFormulario(new FRM_Roles(), "Roles");
        }

        private void M_médicos_Click(object sender, EventArgs e)
        {
            cargarFormulario(new FRM_Medicos(), "Médicos");
        }

        private void provinciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cargarFormulario(new FRM_Provincias(), "Provincias");
        }

        private void P_cantones_Click(object sender, EventArgs e)
        {
            cargarFormulario(new FRM_Cantones(), "Cantones");
        }

        private void ADMIN_personas_Click(object sender, EventArgs e)
        {
            cargarFormulario(new FRM_Persona(), "Personas");

        }

        private void ADMIN_clientes_Click(object sender, EventArgs e)
        {
            cargarFormulario(new FRM_Cliente(), "Clientes");
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void ADMIN_fichaIngreso_Click(object sender, EventArgs e)
        {
            cargarFormulario(new FRM_FichaIngreso(), "Ficha de Ingreso");
        }

        private void P_raza_Click(object sender, EventArgs e)
        {
            cargarFormulario(new FRM_Raza(), "Razas");
        }

        private void P_tipoRaza_Click(object sender, EventArgs e)
        {
            cargarFormulario(new FRM_TipoMascota(), "Tipo Mascota");
        }

        private void P_medicamentos_Click(object sender, EventArgs e)
        {
            cargarFormulario(new FRM_Medicamentos(), "Medicamentos");
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void A_clientes_Click(object sender, EventArgs e)
        {
            cargarFormulario(new FRM_Clientes(), "Clientes");
        }

        private void BtnClientes_Click ( object sender, EventArgs e )
        {
            cargarFormulario(new FRM_Clientes(), "Clientes");
        }

        private void btnFichaIngreso_Click ( object sender, EventArgs e )
        {
            cargarFormulario(new FRM_FichaIngreso(), "FichaIngreso");
        }

        private void ATE_mascota_Click ( object sender, EventArgs e )
        {
            cargarFormulario(new FRM_Mascotas(), "Mascotas");
        }

        private void ATE_controlMascota_Click ( object sender, EventArgs e )
        {
            cargarFormulario(new FRM_ControlMascota(), "Control Mascota");
        }

        private void ATE_registroDiario_Click ( object sender, EventArgs e )
        {
            cargarFormulario(new FRM_RegistroDiario(), "Registro Diario");
        }

        private void ATE_medicamentosSumistrados_Click ( object sender, EventArgs e )
        {
            cargarFormulario(new FRM_MedicamentosSuministrados(), "Medicamentos Suministrados");
        }

        private void ATE_salidaMascota_Click ( object sender, EventArgs e )
        {
            cargarFormulario(new FRM_SalidaMascota(), "Salida Mascota");
        }

        private void MDIMenu_Load ( object sender, EventArgs e )
        {
            label1.Text = nom_usu;
        }

        private void undoToolStripMenuItem_Click ( object sender, EventArgs e )
        {

        }
    }
}
