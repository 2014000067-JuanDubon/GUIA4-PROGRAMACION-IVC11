internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nombre: Juan Dubón\n Grado: IV C\n Clave:11 " +
            "===CONVERSIONES==");
        double metros, resultado;
        Console.WriteLine("Dame una medida en metros: ");
        metros= double.Parse(Console.ReadLine());

        Console.WriteLine("Menú Principal");
        Console.WriteLine("1- Milimetros\n" +
            "2- Centimetros\n" +
            "3- Decimetros \n" +
            "4- Hectómetros \n" +
            "5- Kilometros \n" +
            "6- Salir\n" +
            "Seleccione una Opcion []:");
        int opc = Convert.ToInt32(Console.ReadLine());

        switch (opc)
        {
            case 1: 
                Console.Clear();
                Console.WriteLine("CONVERSION A MILIMETROS");
                resultado = metros * 1000;
                Console.WriteLine("Los metros " + metros + "en Milimetros es: " + resultado);
                break;
            case 2:
                Console.Clear();
                Console.WriteLine("CONVERSION A CENTIMETROS");
                resultado = metros * 100;
                Console.WriteLine("Los metros " + metros + "en Centimetros es: " + resultado);
                break;
            case 3:
                Console.Clear();
                Console.WriteLine("CONVERSION A DECIMETROS");
                resultado = metros * 10;
                Console.WriteLine("Los metros " + metros + "en Decimetros es: " + resultado);
                break;
            case 4:
                Console.Clear();
                Console.WriteLine("CONVERSION A HECTOMETROS");
                resultado = metros / 100;
                Console.WriteLine("Los metros " + metros + "en Hectometros es: " + resultado);
                break;
            case 5:
                Console.Clear();
                Console.WriteLine("CONVERSION A KILOMETROS");
                resultado = metros / 1000;
                Console.WriteLine("Los metros " + metros + "en Kilometros es: " + resultado);
                break;
            case 6:
                Console.Clear();
                Console.WriteLine("Para salir presione una tecla...");
                Console.ReadKey();
                break;
            default: Console.WriteLine("Opción Invalida...");
                break ;
        }
    }
}