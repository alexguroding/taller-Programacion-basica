namespace TallerCSharp;

public class Diccionario
{
    //Declaración del diccionario para almacenar estudiantes NoControl, Nombre
    Dictionary<string, string> estudiantes = new Dictionary<string, string>();
    
     public void subMenuDiccionario(){
        
        string opcion;
        do
        {
            Console.WriteLine("\nMENU ESTRUCTURAS DE DATOS DICCIONARIO");
            Console.WriteLine("1 - Agregar elementos.");
            Console.WriteLine("2 - Buscar elemento.");
            Console.WriteLine("3 - Eliminar elemento.");
            Console.WriteLine("4 - Salir.");
            Console.WriteLine("Elige una opción: ");
            opcion = Console.ReadLine();

            if (string.IsNullOrEmpty(opcion) || string.IsNullOrWhiteSpace(opcion))
                Console.WriteLine("Error: No se introdujo ninguna opción, intente de nuevo.");
        
            switch (opcion)
            {
                case "1":
                    AgregarEstudiantes();
                    break;
                case "2":
                    Console.WriteLine("Escribe el Númer de control del estudiante que desea buscar: ");
                    string NoControl = Console.ReadLine();
                    bool existe = BuscarEstudiante(NoControl);

                    if (existe)
                        Console.WriteLine($"El número de control {NoControl} corresponde al estudiante {estudiantes[NoControl]}");
                    else
                        Console.WriteLine($"El número de control {NoControl} no se encuentra en el diccionario de estudiantes.");
                    break;
                case "3":
                    Console.WriteLine("Escribe el Número de control del estudiante que desea eliminar: ");
                    string NC= Console.ReadLine();
                    bool exist = BuscarEstudiante(NC);

                    if (exist)
                        EliminarEstidiante(NC);
                    else
                        Console.WriteLine($"El número de control {NC} no existe el diccionario de esudiantes.");
                    break;
                case "4": Console.WriteLine("Saliendo del menú..."); break;
                default: Console.WriteLine("Número invalido.");
                    break;
            }
            Console.WriteLine("\nPresiona Enter para continuar...");
            Console.ReadLine();
            Console.Clear();
            ImprimirListaEstudiantes();
            Console.WriteLine("");
        }while(opcion != "4");
    }

    public void AgregarEstudiantes()
    {
        Console.WriteLine("Escribe el número de control: ");
        string NoControl = Console.ReadLine();
        Console.WriteLine("Escribe el nombre del estudiante: ");
        string Nombre = Console.ReadLine();
        estudiantes.Add(NoControl, Nombre);
        ImprimirListaEstudiantes();
    }

    public void ImprimirListaEstudiantes()
    {
        Console.WriteLine("\nEstudiantes registrados: ");
        foreach (KeyValuePair<string, string> estudiante in estudiantes)
        {
            Console.WriteLine($"NoControl: {estudiante.Key} - Nombre: {estudiante.Value}");
        }
    }

    public bool BuscarEstudiante(string NoControl)
    {   
        if(estudiantes.ContainsKey(NoControl))
            return true;
        else 
            return false;
    }

    public void EliminarEstidiante(string NoControl)
    {
        estudiantes.Remove(NoControl);
        ImprimirListaEstudiantes();
    }
}