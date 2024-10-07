namespace Sistema
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Universidad.Estudiante> estudiantes = new List<Universidad.Estudiante>();
            
            for (int i = 1; i <= 3; i++)
            {
                estudiantes.Add(RecopilarDatosEstudiante(i));
            }

            // Mostrar la información de cada estudiante
            foreach (var estudiante in estudiantes)
            {
                estudiante.MostrarInformacion();
                Console.WriteLine();
            }
        }

        // Método para recopilar los datos de un estudiante
        static Universidad.Estudiante RecopilarDatosEstudiante(int numeroEstudiante)
        {
            Console.WriteLine($"Ingrese el nombre del estudiante {numeroEstudiante}:");
            string nombre = Console.ReadLine();

            Console.WriteLine();
            int maxAsistencia;
            do
            {
                Console.Write("Ingresa el máximo de asistencias (hasta 50): ");
                maxAsistencia = int.Parse(Console.ReadLine());

                if (maxAsistencia > 50 || maxAsistencia < 0)
                {
                    Console.WriteLine("Error. Inténtelo nuevamente.");
                }
                Console.WriteLine();
            } while (maxAsistencia > 50 || maxAsistencia < 0);
            Console.WriteLine();

            int sesionesAsistidas;
            do
            {
                Console.Write($"Ingresa la cantidad de sesiones asistidas de {nombre}: ");
                sesionesAsistidas = int.Parse(Console.ReadLine());

                if (sesionesAsistidas > maxAsistencia || sesionesAsistidas < 0)
                {
                    Console.WriteLine("Error. Inténtelo nuevamente.");
                }
                Console.WriteLine();
            } while (sesionesAsistidas > maxAsistencia || sesionesAsistidas < 0);

            // Devolver un nuevo objeto Estudiante con los datos ingresados
            return new Universidad.Estudiante
            {
                Nombre = nombre,
                SesionesTotales = maxAsistencia,
                SesionesAsistidas = sesionesAsistidas
            };

//Finalizacion de cambios en GitHub y del codigo

        }



    }
}