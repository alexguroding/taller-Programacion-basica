namespace TallerCSharp;

public class EjercicioPractico3
{
    private decimal[] calificaciones = new decimal[5];

    public void EjercicioCalificaciones()
    {
        ingresarCalificaciones();
        decimal promedio = CalcularPromedio();
        Console.WriteLine("\nEl promedio de calificaciones es: " + promedio);
        Console.WriteLine("La nota más alta es: " + ObtenerNotaMasAlta());
        Console.WriteLine(ResultadoEvaluacion(promedio));
    }

    //Almacenar 5 calificaciones en un arreglo
    public void ingresarCalificaciones()
    {
        for (int indice = 0; indice < calificaciones.Length; indice++)
        {
            Console.WriteLine($"Ingres la calificación {indice + 1}:");
            calificaciones[indice] = decimal.Parse(Console.ReadLine());

        }

        imprimirCalifiaciones();
    }

    public void imprimirCalifiaciones()
    {
        foreach (var calificacion in calificaciones)
        {
            Console.Write(calificacion + " ");
        }
    }

    //Crea una función para calcular y retornar el pormedio.
    private decimal CalcularPromedio()
    {
        decimal promedio = 0, sumaCalificaciones = 0;
        foreach (var calificacion in calificaciones)
        {
            sumaCalificaciones += calificacion;
        }

        return promedio = sumaCalificaciones / calificaciones.Length;
    }

    //Crear una función para encontrar y retornar la nota más alta.
    public decimal ObtenerNotaMasAlta()
    {
        decimal NotaMasAlta = 0;

        foreach (decimal calificacion in calificaciones)
        {
            NotaMasAlta = calificacion >= NotaMasAlta ? calificacion : NotaMasAlta;
        }

        return NotaMasAlta;
    }

    //Imprimir el prmedio, la nota alta y el estado de cada alumno ("Aprobado" >= 70 sino Reprobado.)
    public string ResultadoEvaluacion(decimal promedio)
    {
        if (promedio >= 70)
            return "El estudiante aprobo la asigantura.";
        else
            return "Lamentablemente el estudiante reprobo la asignatura.";
    }
    
}