using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Alumnos
{
    public partial class FrmConsultar : Form
    {

        private DataTable tabla;
        public FrmConsultar()
        {
            InitializeComponent();
        }

        public FrmConsultar(List<ClsAlumnos> listaCliente)
        {
            InitializeComponent();

            tabla = new DataTable();
            tabla.Columns.Add("Rut", typeof(string));
            tabla.Columns.Add("Digito_Verificador", typeof(string));
            tabla.Columns.Add("Primer_Apellido", typeof(string));
            tabla.Columns.Add("Segundo_Apellido", typeof(string));
            tabla.Columns.Add("Primer_Nombre", typeof(string));
            tabla.Columns.Add("Segundo_Nombre", typeof(string));
            tabla.Columns.Add("Numero_Matricula", typeof(string));
            tabla.Columns.Add("Numero_Celular", typeof(string));
            tabla.Columns.Add("Fecha_Nacimiento", typeof(string));
            tabla.Columns.Add("Edad", typeof(string));



            for (int i = 0; i < listaCliente.Count; i++)
            {
                cboMatricula.Items.Add(listaCliente[i].Matricula);
                tabla.Rows.Add(listaCliente[i].Rut, listaCliente[i].Digito, listaCliente[i].Apellido1, listaCliente[i].Apellido2,
               listaCliente[i].Nombre1, listaCliente[i].Nombre2, listaCliente[i].Matricula, listaCliente[i].Celular, listaCliente[i].Fecha, listaCliente[i].Edad);
                dataGridView1.DataSource = tabla;
            }


        }

        private void cboMatricula_SelectedIndexChanged(object sender, EventArgs e)
        {


            DataView dv = tabla.DefaultView;
            dv.RowFilter = "Numero_Matricula LIKE '" + cboMatricula.Text + "'";
            dataGridView1.DataSource = dv;

        }
    }
}
