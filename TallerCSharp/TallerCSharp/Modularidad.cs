namespace TallerCSharp;

public class Modularidad
{
    public int numero1, numero2;
    
    public void subMenuModularidad()
    {   
        int opcion;
        do
        {
        Console.WriteLine("\nMENU OPERACIONES LÓGICOS Y ESTRUCTURAS DE CONTROL");
        Console.WriteLine("1 - Suma con método simple.");
        Console.WriteLine("2 - Resta con paso de parámetros.");
        Console.WriteLine("3 - Multiplicación con retorno de valores.");
        Console.WriteLine("4 - División con paso de parámetros y retorno de valores.");
        Console.WriteLine("5 - Salir");
        Console.WriteLine("Elige una opción: ");
        opcion = int.Parse(Console.ReadLine());
        switch (opcion)
        {
            case 1: solicitarValores();
                Suma(); 
                break;
            case 2: solicitarValores();
                Resta(numero1, numero2);
                break;
            case 3: solicitarValores();
                Console.WriteLine(Multiplicacion());
                break;
            case 4: solicitarValores();
                decimal resDiv = Division(numero1, numero2);
                Console.WriteLine($"La división de {numero1} / {numero2} es: {resDiv}");
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

    public void solicitarValores()
    {
        Console.WriteLine("Escribe el primer numero:");
        numero1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Escribe el segundo numero:");
        numero2 = int.Parse(Console.ReadLine());
    }
    public void Suma() //método simple
    {
        Console.WriteLine("La suma es: "+(numero1 + numero2));
    }
    
    public void Resta(int num1, decimal num2) //método con paso de parametros
    {
        Console.WriteLine("La resta es: "+(num1 - num2));
    }

    public string Multiplicacion()//método con retorno de valor
    {
        return $"La multiplicación del {numero1} * {numero2} es: {(numero1*numero2)}";
    }

    public decimal Division(int num1, decimal num2)//método con paso de parametros y retorno de valores
    {
        return num1/num2;
    }
}