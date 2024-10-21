using EjercicioL5_ENT;

namespace EjercicioL5_DAL
{
    // All the code in this file is included in all platforms.
    public class clsListadoPersonasDAL
    {
        public static List<clsPersona> getListadoPersonas()
        {
            List<clsPersona> listaPersonas = [
                new clsPersona("Paco")
                ];
        }
    }
}
