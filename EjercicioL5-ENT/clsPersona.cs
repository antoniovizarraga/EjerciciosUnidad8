namespace EjercicioL5_ENT
{
    // All the code in this file is included in all platforms.
    public class clsPersona
    {
        public String Nombre {  get; set; }

        public String Apellido { get; set; }

        public clsPersona(string Nombre, string Apellido) {
            if(!String.IsNullOrEmpty(Nombre))
            {
                this.Nombre = Nombre;
            }

            if (!String.IsNullOrEmpty(Apellido))
            {
                this.Apellido = Apellido;
            }
        }
    }
}
