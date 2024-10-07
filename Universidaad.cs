using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema
{
    public class Universidad
    {
        public class Estudiante //Clase anidada denominada "Estudiante"
        {
            public string Nombre { get; set; }
            public int SesionesTotales { get; set; }        //Propiedades
            public int SesionesAsistidas { get; set; }

            internal class Asistencia 
            {
                public static double CalcularPorcentaje(int sesionesTotales, int sesionesAsistidas)
                {
                    return (double)sesionesAsistidas / sesionesTotales * 100;
                }

                public static bool CumpleMinimoAsistencia(int sesionesTotales, int sesionesAsistidas)
                {
                    return CalcularPorcentaje(sesionesTotales, sesionesAsistidas) >= 75;
                }
                public static int CumpMax(int sesionesTotales, int sesionesAsistidas)
                {
                    return (sesionesTotales);
                }
                public static int SA(int sesionesTotales, int sesionesAsistidas)
                {
                    return (sesionesAsistidas);
                }
            }
        }
    }
}
