﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ColegioLibreria;

namespace FormularioColegioApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_test_Click(object sender, EventArgs e)
        {
            var testLibreria = new Colegio();

            testLibreria.Nombre         = txtNombreColegio.Text;
            testLibreria.Direccion      = txtDireccion.Text;
            testLibreria.Ciudad         = txtDireccion.Text;
            testLibreria.Provincia      = txtProvincia.Text;
            testLibreria.CodPostal      = txtCodPostal.Text;
            testLibreria.NumeroTelefono = txtTelefono.Text;
            try
            {
                testLibreria.Twitterlink    = txtTwitter.Text;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
            
        }
    }
}
