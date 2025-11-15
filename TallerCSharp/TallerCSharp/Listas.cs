namespace TallerCSharp;

public class Listas
{
    //Declaración
    //List<int> decenas = new List<int>();
    private List<string> nombres = new List<string>();
    
    public void subMenuListas(){
        
        string opcion;
        do
        {
            Console.WriteLine("\nMENU ESTRUCTURAS DE DATOS LISTA");
            Console.WriteLine("1 - Agregar elementos.");
            Console.WriteLine("2 - Buscar elemento.");
            Console.WriteLine("3 - Ordenar Lista.");
            Console.WriteLine("4 - Eliminar elemento.");
            Console.WriteLine("5 - Salir.");
            Console.WriteLine("Elige una opción: ");
            opcion = Console.ReadLine();

            if (string.IsNullOrEmpty(opcion) || string.IsNullOrWhiteSpace(opcion))
                Console.WriteLine("Error: No se introdujo ninguna opción, intente de nuevo.");
        
            switch (opcion)
            {
                case "1":
                    AgregarNombres();
                    break;
                case "2":
                    Console.WriteLine("Escribe el nombre que desea buscar: ");
                    string nombreABuscar = Console.ReadLine();
                    int index = BuscarNombre(nombreABuscar);

                    if (index >= 0)
                        Console.WriteLine($"El nombre {nombreABuscar} si se encuentra en la lista en el indice {index}");
                    else
                        Console.WriteLine($"El nombre {nombreABuscar} no existe en la lista");
                    break;
                case "3":
                    OrdenarNombres();
                    break;
                case "4":
                    Console.WriteLine("Escribe el nombre que desea eliminar: ");
                    string nombreAEliminar = Console.ReadLine();
                    int indice = BuscarNombre(nombreAEliminar);

                    if (indice >= 0)
                        EliminarNombres(nombreAEliminar);
                    else
                        Console.WriteLine($"El nombre {nombreAEliminar} no existe en la lista");
                    break;
                case "5": Console.WriteLine("Saliendo del menú..."); break;
                default: Console.WriteLine("Número invalido.");
                    break;
            }
            Console.WriteLine("\nPresiona Enter para continuar...");
            Console.ReadLine();
            Console.Clear();
            ImprimirListaNombres();
            Console.WriteLine("");
        }while(opcion != "5");
    }

    public void AgregarNombres()
    {   
        Console.Write("Ingresa un nombre: ");
        string nombre = Console.ReadLine();

        if (string.IsNullOrEmpty(nombre) || string.IsNullOrWhiteSpace(nombre))
            Console.WriteLine("Error: No se introdujo ningún nombre, intente de nuevo.");
        
        nombres.Add(nombre);
        ImprimirListaNombres();
    }

    public void ImprimirListaNombres()
    {

        Console.WriteLine("\nNúmero de elementos de la lista: "+nombres.Count);
        Console.WriteLine("Nombres: ");
        foreach (var nombre in nombres)
            Console.WriteLine(nombre);
    }

    public int BuscarNombre(string nombreABuscar)
    {   
        //Buscar un nombre en la lista de nombres
        int index = nombres.IndexOf(nombreABuscar);
        return index;
    }
    public void OrdenarNombres()
    {   
        ImprimirListaNombres();
        nombres.Sort();
        Console.WriteLine("Lista ordenada A-Z: ");
        ImprimirListaNombres();
    }
    public void EliminarNombres(string nombreAEliminar)
    {   
        nombres.Remove(nombreAEliminar);
        ImprimirListaNombres();
    }
}