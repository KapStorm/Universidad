using MPS.Datos;
using MPS.Entidades;
using System.Collections.Generic;

namespace MPS.Negocios
{
    public class Manejador
    {
        private DataBase _datos;

        public Manejador()
        {
            _datos = new DataBase();
        }

        public List<Alumno> ObtenerAlumnos()
        {
            return _datos.ObtenerAlumnos();
        }
    }
}
