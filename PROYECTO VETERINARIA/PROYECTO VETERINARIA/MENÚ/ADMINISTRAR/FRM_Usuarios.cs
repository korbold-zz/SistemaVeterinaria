﻿using System;
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
    public partial class FRM_Usuarios : Form
    {
        public FRM_Usuarios ( )
        {
            InitializeComponent();
        }

        private void tAB_USUARIOSBindingNavigatorSaveItem_Click ( object sender, EventArgs e )
        {
            try
            {
                this.Validate ( );
                this.tAB_USUARIOSBindingSource.EndEdit ( );
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

        private void FRM_Usuarios_Load ( object sender, EventArgs e )
        {
            // TODO: esta línea de código carga datos en la tabla 'dSveterinaria.TAB_PERSONA' Puede moverla o quitarla según sea necesario.
            this.tAB_PERSONATableAdapter.Fill(this.dSveterinaria.TAB_PERSONA);
            // TODO: esta línea de código carga datos en la tabla 'dSveterinaria.TAB_ROLES' Puede moverla o quitarla según sea necesario.
            this.tAB_ROLESTableAdapter.Fill(this.dSveterinaria.TAB_ROLES);
            // TODO: esta línea de código carga datos en la tabla 'dSveterinaria.TAB_USUARIOS' Puede moverla o quitarla según sea necesario.
            this.tAB_USUARIOSTableAdapter.Fill(this.dSveterinaria.TAB_USUARIOS);
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
            DSveterinariaTableAdapters.TAB_USUARIOSTableAdapter obj = new DSveterinariaTableAdapters.TAB_USUARIOSTableAdapter ( );
            int n = int.Parse ( tAB_USUARIOSDataGridView.CurrentRow.Cells [ 0 ].Value.ToString ( ) );
            string dato = tAB_USUARIOSDataGridView.CurrentRow.Cells [ 1 ].Value.ToString ( );



            if ( tAB_USUARIOSDataGridView.RowCount > 0 )
            {
                if ( MessageBox.Show ( dato + " ¿Está seguro de ELIMINAR?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Error ) == DialogResult.Yes )
                {

                    obj.DeleteQuery_USUARIOS ( n );
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
            if ( tAB_USUARIOSDataGridView.RowCount > 0 )
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
            this.tAB_USUARIOSTableAdapter.Fill ( this.dSveterinaria.TAB_USUARIOS );
            Metodos.BotonLOAD ( btnActualizar, btnCancelar, btnGuardar, btnAgregar, btnEliminar );
            enabledFALSE ( );
        }
        public void enabledFALSE ( )
        {
            iD_ROLComboBox.Enabled = false;
            iD_PERSONAComboBox.Enabled = false;
            nOMBRE_USUARIOTextBox.Enabled = false;
            cLAVETextBox.Enabled = false;
            

        }
        public void enabledTRUE ( )
        {
            iD_ROLComboBox.Enabled = true;
            iD_PERSONAComboBox.Enabled = true;
            nOMBRE_USUARIOTextBox.Enabled = true;
            cLAVETextBox.Enabled = true;

        }
    }
}
