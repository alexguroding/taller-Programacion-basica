namespace TallerCSharp;

public class EjercicioPractico1
{
    public void CalcularDescuento()
    {
        Console.WriteLine("\nCalcular descuentos en base a codigos de descuento. ");
        Console.WriteLine("Escribe el precio del producto a comprar:");
        double precio = double.Parse(Console.ReadLine());
        Console.WriteLine("Escribe el código de descuento anexo a tu factura de compra: INGE10, PROG20 o NO APLICA");
        string codigoDescuento = Console.ReadLine();
        
        if (codigoDescuento == "INGE10")
            Console.WriteLine($"Usted va a pagar {precio} - {precio * 0.10} = {precio - (precio*0.10)} aplicando el codigo de descuento {codigoDescuento}.");
        else if (codigoDescuento == "PROG20")
            Console.WriteLine($"Usted va a pagar {precio} - {precio * 0.20} = {precio - (precio*0.20)} aplicando el codigo de descuento {codigoDescuento}.");
        else if (codigoDescuento == "NO APLICA")
            Console.WriteLine("Su producto no cuenta con ningún descuento de la tienda.");
        else if (codigoDescuento != "INGE10" && codigoDescuento != "PROG20" && codigoDescuento != "NO APLICA")
            Console.WriteLine("El código de descuento que escribio no existe.");
    }
}