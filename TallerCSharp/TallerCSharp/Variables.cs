namespace TallerCSharp;

public class Variables
{
    //Declaracion de variables
    int numero1 = 20;
    double numero2 = 10; //Declaración con inicialización
    float numero3;
    public decimal numero4 = 3.1416m;// se agrega la m para especificar que el valor es un decimal
    private char simbolo = '&';
    protected bool activo = true;
    DateTime fecha = DateTime.Now;
    
    public void imprimirVariables()
    {
        Console.WriteLine("\n*** Variables y tipos.");
        Console.WriteLine("El valor de la variable numero1 es : " + numero1);
        Console.WriteLine("Double numero2 = " + numero2);
        numero3 = 34.56f;// se agrega la f para especificar que el valor es un float
        Console.WriteLine($"Los valores de float numero3 es: {numero3} y decimal numero4 es: {numero4} ");
        Console.WriteLine("El valor de char simbolo es: " + simbolo);
        Console.WriteLine("El valor de bool activo es: " + activo);
        Console.WriteLine("El valor de fecha es: " + fecha);
    }
    
}