namespace TallerCSharp;

public class EstructurasDatos
{
    public void subMenuEstructurasDatos(){
        
     string opcion;
        do
        {
        Console.WriteLine("\nMENU ESTRUCTURAS DE DATOS");
        Console.WriteLine("1 - ARREGLOS.");
        Console.WriteLine("2 - LISTAS.");
        Console.WriteLine("3 - DICCIONARIOS.");
        Console.WriteLine("4 - SALIR");
        Console.WriteLine("Elige una opción: ");
        opcion = Console.ReadLine();

        if (string.IsNullOrEmpty(opcion) || string.IsNullOrWhiteSpace(opcion))
            Console.WriteLine("Error: No se introdujo ninguna opción, intente de nuevo.");
        
        switch (opcion)
        {
            case "1":
                Arreglos();
                break;
            case "2":
                Listas();
                break;
            case "3":
                Diccionarios();
                break;
            case "4": Console.WriteLine("Saliendo del menú..."); break;
            default: Console.WriteLine("Número invalido.");
                break;
        }
        Console.WriteLine("\nPresiona Enter para continuar...");
        Console.ReadLine();
        Console.Clear();
        }while(opcion != "4");
    }

    public void Arreglos()
    {
        Console.WriteLine("\nManejo de arreglos");
        //Declaración
        int[]numeros = new int[4];
        int[] numeros2 = { 233, 21, 45, 3 }; 
        
        //Agregar valores
        numeros[0] = 10;
        numeros[1] = 20;
        numeros[2] = 30;
        numeros[3] = 40;
        
        //Impresion de valores
        Console.WriteLine($"Impresion directa de Números: [0]={numeros[0]}, [1]={numeros[1]}, [2]={numeros[2]}, [3]={numeros[3]}");
        //Impresion con ciclo
        Console.WriteLine("Impresion con ciclo For de Números:");
        
        for(int indice = 0; indice < numeros.Length; indice++)
            Console.Write($"[{indice}]={numeros[indice]}, ");

        int ind = 0;
        Console.WriteLine("\nImpresion con ciclo while de Números:");
        while (ind < numeros2.Length)
        {
            Console.Write($"[{ind}]={numeros2[ind]}, ");
            ind = ind +1;
        }
        
        Console.WriteLine("\nImpresion con ciclo Foreach de Números:");
        int indic = 0;
        foreach (int num in numeros2)
        {
            Console.Write($"[{indic}]={num}");
            indic++;
        }
        
    }
    public void Listas()
    {
        Listas l1 = new Listas();
        l1.subMenuListas();
    }
    public void Diccionarios()
    {
        Diccionario d1 = new Diccionario();
        d1.subMenuDiccionario();
    }
}