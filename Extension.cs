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
           
            Console.WriteLine();
            Console.WriteLine("*==================================================================*");
            Console.WriteLine($"|    Nombre: {estudiante.Nombre}                                                  ");
            Console.WriteLine("*==================================================================*");
            Console.WriteLine($"| Porcentaje de Asistencia: {porcentajeAsistencia:F2}%                                 ");
            Console.WriteLine($"| Sesiones Asistidas:     {sesionesAsistidas}                            ");
            Console.WriteLine($"| Total de Asistencia: {asistenciamax}                             ");
            Console.WriteLine($"| Cumple con el mínimo de asistencia: {(cumpleMinimo ? "Sí" : "No")}                            ");
            Console.WriteLine("*==================================================================*");
        }
    }
}

        
        

    
