namespace EjercicioL5_ENT
{
    // All the code in this file is included in all platforms.
    public class clsPersona
    {
        public String nombre {  get; set; }

        public clsPersona(string Nombre) {
            if(!String.IsNullOrEmpty(Nombre))
            {
                nombre = Nombre;
            }
        }
    }
}
