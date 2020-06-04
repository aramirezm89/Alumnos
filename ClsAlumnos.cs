namespace Alumnos
{
    public class ClsAlumnos
    {
        private int rut;
        private string digito;
        private string apellido1;
        private string apellido2;
        private string nombre1;
        private string nombre2;
        private int matricula;
        private int celular;
        private string fecha;
        private int edad;

        public int Rut { get => rut; set => rut = value; }
        public string Digito { get => digito; set => digito = value; }
        public string Apellido1 { get => apellido1; set => apellido1 = value; }
        public string Apellido2 { get => apellido2; set => apellido2 = value; }
        public string Nombre1 { get => nombre1; set => nombre1 = value; }
        public string Nombre2 { get => nombre2; set => nombre2 = value; }
        public int Matricula { get => matricula; set => matricula = value; }
        public int Celular { get => celular; set => celular = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public int Edad { get => edad; set => edad = value; }

        public ClsAlumnos()
        {
            Rut = 0;
            digito = string.Empty;
            Apellido1 = string.Empty;
            Apellido2 = string.Empty;
            Nombre1 = string.Empty;
            Nombre2 = string.Empty;
            Matricula = 0;
            Celular = 0;
            Fecha = string.Empty;
            edad = 0;



        }

        public ClsAlumnos(int r, string d, string ap1, string ap2, string n1, string n2, int mat, int cel, string fec, int ed)
        {
            Rut = r;
            digito = d;
            Apellido1 = ap1;
            Apellido2 = ap2;
            Nombre1 = n1;
            Nombre2 = n2;
            Matricula = mat;
            Celular = cel;
            Fecha = fec;
            edad = ed;

        }



    }
}
