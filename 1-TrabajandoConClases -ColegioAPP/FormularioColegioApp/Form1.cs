using System;
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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btn_test_Click(object sender, EventArgs e)
        {
            var testLibreria = new Colegio();

            testLibreria.Nombre         = txtNombreColegio.Text;
            testLibreria.Direccion      = txtDireccion.Text;
            testLibreria.Ciudad         = txtCiudad.Text;
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

            MessageBox.Show(testLibreria.ToString());
        }

        private void btnTestProfesor_Click(object sender, EventArgs e)
        {
            var profesor         = new Profesor();
            var computarPromedio = profesor.ComputarPromedioDelCurso();
            MessageBox.Show("El promedio del profesor es de : " + computarPromedio);
        }

        private void btnTestAlumno_Click(object sender, EventArgs e)
        {
            var estudiante       = new Estudiante();
            var computarPromedio = estudiante.ComputarPromedioDelCurso();
            MessageBox.Show("El promedio de alumno es de : " + computarPromedio);

        }
    }
}