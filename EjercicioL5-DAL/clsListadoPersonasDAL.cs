using EjercicioL5_ENT;

namespace EjercicioL5_DAL
{
    // All the code in this file is included in all platforms.
    public class clsListadoPersonasDAL
    {
        /// <summary>
        /// 
        /// Función que devuelve un listado con todas las personas
        /// </summary>
        /// <returns></returns>
        public static List<clsPersona> GetListadoPersonas()
        {
            List<clsPersona> listaPersonas = [
                new clsPersona("Paco", "Martínez"),
                new clsPersona("Alex", "Hernández"),
                new clsPersona("Alejandro", "Gómez")
                ];
            return listaPersonas;
        }
    }
}
