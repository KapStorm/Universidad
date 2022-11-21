using MPS.Entidades;
using System.Collections.Generic;

namespace MPS.Datos
{
    public class DataBase
    {
        public List<Alumno> ObtenerAlumnos()
        {
            return new List<Alumno>
            {
                new Alumno("100", "Sebas", "Ing. en Sistemas"),
                new Alumno("101", "Syl", "Ing. Industrial"),
                new Alumno("102", "Kappa", "Ing. en Sistemas")
            };
        }
    }
}
