using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema
{
    static class EstudiantesExtension
    {
        public static void MostrarInformacion(this Sistema.Universidad.Estudiante estudiante)
        {
            double porcentajeAsistencia = Sistema.Universidad.Estudiante.Asistencia.CalcularPorcentaje
                           (estudiante.SesionesTotales, estudiante.SesionesAsistidas);

            bool cumpleMinimo = Sistema.Universidad.Estudiante.Asistencia.CumpleMinimoAsistencia
                (estudiante.SesionesTotales, estudiante.SesionesAsistidas);

            int asistenciamax = Sistema.Universidad.Estudiante.Asistencia.CumpMax
                (estudiante.SesionesTotales, estudiante.SesionesAsistidas);

            int sesionesAsistidas = Sistema.Universidad.Estudiante.Asistencia.SA
                 (estudiante.SesionesTotales, estudiante.SesionesAsistidas);
        }
    }
}