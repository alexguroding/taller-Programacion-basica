//Menu
namespace TallerCSharp;

    class Principal
    {
        public static void Main(string[] args)
        {
            menuPrincipal();
        }

        public static void menuPrincipal()
        {
            int opcion;
            do
            {
                Console.WriteLine("\n*** MENÚ DEL TALLER DE C# ***");
                Console.WriteLine("1 - Variables y tipos.");
                Console.WriteLine("2 - Operadores aritmeticos.");
                Console.WriteLine("3 - Operadores lógicos y estructuras de control");
                Console.WriteLine("4 - Estructuras de repetición.");
                Console.WriteLine("5 - Ejercicio práctico 1 - Calcular descuento.");
                Console.WriteLine("6 - Modularidad y funciones.");
                Console.WriteLine("7 - Ejercicio práctico 2 - Generador de secuencia par.");
                Console.WriteLine("8 - Estructura de datos.");
                Console.WriteLine("9 - Ejercicio práctico 3 - promedio de calificaciones.");
                Console.WriteLine("10 - Programación Orientada a Objetos.");
                Console.WriteLine("11 - Ejercicio práctico interfaces gráficas.");
                Console.WriteLine("12 - Salir.");
                Console.WriteLine("Elige una opción: ");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Variables ejemVariables = new Variables();
                        ejemVariables.imprimirVariables();
                        break;
                    case 2:
                        OperadoresAritmeticos OpArit = new OperadoresAritmeticos();
                        OpArit.subMenuOperadoresAritmeticos();
                        break;
                    case 3:
                        OperadoresLogicos opLogicos = new OperadoresLogicos();
                        opLogicos.subMenuOperadoresLogicos(); ;
                        break;
                    case 4:
                        EstructurasRepetir estRep = new EstructurasRepetir();
                        estRep.subMenuEstructurasRepetir();
                        break;
                    case 5: EjercicioPractico1 ep1= new EjercicioPractico1();
                        ep1.CalcularDescuento();
                        break;
                    case 6: Modularidad mod = new Modularidad();
                        mod.subMenuModularidad();
                        break;
                    case 7: EjercicioPractico2 ep2 = new EjercicioPractico2();
                        ep2.GenerarSecuenciaPar();
                        break;
                    case 8: EstructurasDatos ed = new EstructurasDatos();
                        ed.subMenuEstructurasDatos();
                        break;
                    case 9: EjercicioPractico3 ep3 = new EjercicioPractico3();
                        ep3.EjercicioCalificaciones();
                        break;
                    case 12: Console.WriteLine("Saliendo del menú..."); 
                        break;
                    default:
                        Console.WriteLine("Número invalido.");
                        break;
                }
                Console.WriteLine("\nPresiona Enter para continuar...");
                Console.ReadLine();
                Console.Clear();

            }while(opcion != 12);
        }
    }