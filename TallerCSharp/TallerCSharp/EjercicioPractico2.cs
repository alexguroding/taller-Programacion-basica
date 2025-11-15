namespace TallerCSharp;

public class EjercicioPractico2
{
    
    public void GenerarSecuenciaPar()
    {
        Console.WriteLine("Escribe el número hasta donde desea que se genere la secuencia de números pares.");
        int numMax = int.Parse(Console.ReadLine());
      
        for (int indice = 1; indice <= numMax; indice++)
        {
            if (esPar(indice))
                Console.WriteLine($"El numero {indice} es Par");
        }
    }

    private bool esPar(int numero)
    {
        if(numero % 2==0)
        {
            return true;
        }else{
            return false;
        }
    }
}