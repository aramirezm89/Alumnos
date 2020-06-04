using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Alumnos
{
    public partial class FrmAlumnos : Form
    {

        List<ClsAlumnos> listaAlumnos = new List<ClsAlumnos>();
        public FrmAlumnos()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtEdad.Enabled = false;

        }


        public void Solo_Numeros(KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {

                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Este campo solo permite numeros", "Alumnos", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        public void SoloLetras(KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;

            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
                MessageBox.Show("Este campo solo permite letras", "Alumnos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtRut_KeyPress(object sender, KeyPressEventArgs e)
        {
            Solo_Numeros(e);
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtDigverif.Focus();
            }
        }

        private void txtApellido1_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtApellido2.Focus();
            }
        }

        private void txtApellido2_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtNombre1.Focus();
            }
        }

        private void txtNombre1_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtNombre2.Focus();
            }
        }

        private void txtNombre2_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtMatricula.Focus();
            }
        }

        private void txtMatricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            Solo_Numeros(e);
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtCelu.Focus();
            }
        }

        private void txtCelu_KeyPress(object sender, KeyPressEventArgs e)
        {
            Solo_Numeros(e);

        }



        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaActual = DateTime.Today;

            int edad = fechaActual.Year - dateTimePicker1.Value.Year;

            if (fechaActual.Year < dateTimePicker1.Value.Year)
            {

                MessageBox.Show("Fecha mayor a la actual");
                txtEdad.Text = "0";
            }
            else
            {
                txtEdad.Text = edad.ToString();
            }

            //txtEdad.Text = edad(dateTimePicker1.Value).ToString();


        }

        private void txtDigverif_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtApellido1.Focus();
            }
        }

        private void ingresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((txtRut.Text.Equals("")) || (txtDigverif.Text.Equals("")) || (txtApellido1.Text.Equals("")) || (txtApellido2.Text.Equals("")) ||
               (txtNombre1.Text.Equals("")) || (txtNombre2.Text.Equals("")) || (txtMatricula.Text.Equals("")) || (txtCelu.Text.Equals("")))
            {
                MessageBox.Show("Todos los datos son necesarios", "Datos Alumnos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ClsAlumnos alumnos = new ClsAlumnos(int.Parse(txtRut.Text), txtDigverif.Text, txtApellido1.Text, txtApellido2.Text, txtNombre1.Text, txtNombre2.Text,
                                                int.Parse(txtMatricula.Text), int.Parse(txtCelu.Text), dateTimePicker1.Text, int.Parse(txtEdad.Text));
                listaAlumnos.Add(alumnos);
                MessageBox.Show("Datos ingresados", "Datos Alumnos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



        }

        private void buscarPorMatriculasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultar frm = new FrmConsultar(listaAlumnos);
            frm.Show();

        }

        private void limpiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("realmente desea salir de la aplicación", "datos alumno", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (opcion == DialogResult.Yes)
            {
                this.Close();
            }

        }



        //public static int edad(DateTime fecha_nacimiento)
        //{

        //    int calculo_edad;

        //    DateTime fechaactual = DateTime.Today;

        //    if (fecha_nacimiento > fechaactual)
        //    {
        //        return -1;
        //    }
        //    else
        //    {
        //        calculo_edad = fechaactual.Year - fecha_nacimiento.Year;

        //    }

        //    return calculo_edad;
        //}


        public void Limpiar()
        {
            txtRut.Clear();
            txtDigverif.Clear();
            txtApellido1.Clear();
            txtApellido2.Clear();
            txtNombre1.Clear();
            txtNombre2.Clear();
            txtMatricula.Clear();
            txtCelu.Clear();
        }

    }

}

