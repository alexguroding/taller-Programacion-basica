namespace TallerCSharp;
public class OperadoresAritmeticos
{
    public int numero1, numero2;
    
    public void subMenuOperadoresAritmeticos()
    {   
        int opcion;
        do
        {
        Console.WriteLine("\nMENU OPERADORES ARITMÉTICOS");
        Console.WriteLine("1 - Suma.");
        Console.WriteLine("2 - Resta.");
        Console.WriteLine("3 - Multiplicación.");
        Console.WriteLine("4 - División.");
        Console.WriteLine("5 - Salir");
        Console.WriteLine("Elige una opción: ");
        opcion = int.Parse(Console.ReadLine());
        switch (opcion)
        {
            case 1: 
                Console.WriteLine("Escribe el primer numero:");
                numero1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Escribe el segundo numero:");
                numero2 = int.Parse(Console.ReadLine());
                Console.WriteLine("La suma es: "+(numero1 + numero2));
                break;
            case 2: 
                Console.WriteLine("Escribe el primer numero:");
                numero1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Escribe el segundo numero:");
                numero2 = int.Parse(Console.ReadLine());
                Console.WriteLine("La resta es: "+(numero1 - numero2));
                break;
            case 3: 
                Console.WriteLine("Escribe el primer numero:");
                numero1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Escribe el segundo numero:");
                numero2 = int.Parse(Console.ReadLine());
                Console.WriteLine($"La multiplicación del {numero1} * {numero2} es: {(numero1*numero2)}");
                break;
            case 4: 
                Console.WriteLine("Escribe el primer numero:");
                numero1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Escribe el segundo numero:");
                numero2 = int.Parse(Console.ReadLine());
                Console.WriteLine($"La división de {numero1} / {numero2} es: {numero1 / numero2}");
                break;
            case 5: Console.WriteLine("Saliendo del menú..."); break;
            default: Console.WriteLine("Número invalido.");
                break;
        }
        Console.WriteLine("\nPresiona Enter para continuar...");
        Console.ReadLine();
        Console.Clear();
        }while(opcion != 5);
    }
}