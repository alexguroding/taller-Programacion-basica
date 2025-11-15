namespace TallerCSharp;

public class EstructurasRepetir
{
    public void subMenuEstructurasRepetir()
    {   
        int opcion;
        do
        {
        Console.WriteLine("\nMENU ESTRUCTURAS DE REPETICIÓN");
        Console.WriteLine("1 - Ciclo FOR ");
        Console.WriteLine("2 - CICLO WHILE");
        Console.WriteLine("3 - CICLO DO WHILE");
        Console.WriteLine("4 - SALIR");
        Console.WriteLine("Elige una opción: ");
        opcion = int.Parse(Console.ReadLine());
        switch (opcion)
        {
            case 1: FOR(); break;
            case 2: WHILE(); break;
            case 3: DoWHILE(); break;
            case 4: Console.WriteLine("Saliendo del menú..."); break;
            default: Console.WriteLine("Número invalido.");
                break;
        }
        Console.WriteLine("\nPresiona Enter para continuar...");
        Console.ReadLine();
        Console.Clear();
        }while(opcion != 4);
    }

    public void FOR()
    {
        Console.WriteLine("imprimir números pares del 0 al 100 con FOR");
        for (int i = 0; i <= 100; i++)
        {
            if (i % 2 == 0) 
                Console.Write($" {i} ");
        }
    }

    public void WHILE()
    {
        Console.WriteLine("imprimir numeros pares del 0 al 100 con WHILE");
        int i = 0;
        while (i <= 100)
        {
            if (i % 2 == 0) 
                Console.Write($" {i} ");
            i=i+1;
        }
    }

    public void DoWHILE()
    {
        Console.WriteLine("imprimir numeros pares del 0 al 100 con DO WHILE");
        int i = 0;
        do
        {
            if (i % 2 == 0)
                Console.Write($" {i} ");
            i = i + 1;
        } while (i <= 100);
    }
}