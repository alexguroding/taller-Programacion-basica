namespace TallerCSharp;

public class OperadoresLogicos
{
    //Operadores lógicos AND - && , OR - ||, NOT !
    /*AND 
        V - V = V
        V - F = F
        F - V = F
        F - F = F 
        
        OR 
        V - V = V
        V - F = V
        F - V = V
        F - F = F
        */

    public void subMenuOperadoresLogicos()
    {   
        int opcion;
        do
        {
        Console.WriteLine("\nMENU OPERACIONES LÓGICOS Y ESTRUCTURAS DE CONTROL");
        Console.WriteLine("1 - Operador AND, IF, ELSE ");
        Console.WriteLine("2 - Operador OR, IF, ELSE IF");
        Console.WriteLine("3 - Operador NOT o Negación");
        Console.WriteLine("4 - Salir");
        Console.WriteLine("Elige una opción: ");
        opcion = int.Parse(Console.ReadLine());
        switch (opcion)
        {
            case 1: AND(); break;
            case 2: OR(); break;
            case 3: Negacion(); break;
            case 4: Console.WriteLine("Saliendo del menú..."); break;
            default: Console.WriteLine("Número invalido.");
                break;
        }
        Console.WriteLine("\nPresiona Enter para continuar...");
        Console.ReadLine();
        Console.Clear();
        }while(opcion != 4);
    }
    public void AND()
    {
        Console.WriteLine("Cálcular apoyo de 70 o más para adultos mayores.");
        Console.WriteLine("Escribe tu edad:");
        int edad = int.Parse(Console.ReadLine());
        Console.WriteLine("Escribe tu nacionalidad: 1 - Mexicana, 2 - Otra.");
        string nacionalidad = int.Parse(Console.ReadLine()) == 1 ? "Mexicana" : "Otra"; //operador ternario
        if (edad >= 70  && nacionalidad == "Mexicana")
        {
            Console.WriteLine("Puedes iniciar el trámite para el apoyo de 70 y más.");
        }
        else
        {
            Console.WriteLine("No eres candidato para el trámite de 70 y más.");
        }
    }

    public void OR()
    {
        Console.WriteLine("Imprimir si una persona tiene derecho a la salud.");
        Console.WriteLine("Escribe tu nacionalidad:  1 - Mexicana, 2 - Otra.");
        string nacionalidad = int.Parse(Console.ReadLine()) == 1 ? "Mexicana" : "Otra"; //operador ternario
        Console.WriteLine("¿Cuentas con seguro médico laboral? 1 - Si, 2 - No ");
        bool seguro = int.Parse(Console.ReadLine()) == 1 ? true: false;
        
        if (nacionalidad == "Mexicana" || seguro )
        {
            Console.WriteLine("Tienes de seguro médico laboral.");
        }else if (nacionalidad == "Otra" || !seguro)
        {
            Console.WriteLine("No cuentas con apoyo de salud pública.");
        }
    }
    public void Negacion()
    {
        Console.WriteLine("Imprimir si una persona tiene suscripción de Netflix.");
        Console.WriteLine("¿Cuentas con suscripción de Netflix? 1 - Si, 2 - No. ");
        bool sucripNetflix = int.Parse(Console.ReadLine()) == 1 ? true : false;
        
        if (!sucripNetflix)
            Console.WriteLine("No puedes ver tus series favoritas en Netflix");
        else 
            Console.WriteLine("Si puedes ver tus series favoritas en Netflix");
    }
}