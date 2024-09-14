 public class vendedor
{
    private static void Main(string[]args)
    {
        
        double sueldoBase = 2000000;
        double comisionVenta1, comisionVenta2, comisionVenta3, comisionTotal;
        
        // ingresamos por pantalla cada venta

        Console.Write("Ingrese el valor de la primera venta: ");
        double venta1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el valor de la segunda venta: ");
        double venta2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el valor de la tercera venta: ");
        double venta3 = Convert.ToDouble(Console.ReadLine());

        // calculamos el valor de comision de cada venta
         comisionVenta1 = venta1 * 0.10;
         
         comisionVenta2 = venta2 * 0.10; 

         comisionVenta3 = venta3 * 0.10;

         comisionTotal = comisionVenta1 + comisionVenta2 + comisionVenta3;

        // Total sueldo recibido
        double totalsueldoRecibido = sueldoBase + comisionTotal;

        // Venta con mayor comisión
        double mayorComision = Math.Max(comisionVenta1,Math.Max( comisionVenta2, comisionVenta3));

        // Promedio de comisiones
        double promedioComisiones = comisionTotal / 3;

        // Beneficio extra
        double beneficioExtrasalario = 0;
        if (venta1 + venta2 + venta3 >= 1000000)
        {
            beneficioExtrasalario = 100000;
            Console.WriteLine("Ganó el beneficio extra de $100.000");
        }
        else
        {
            Console.WriteLine("No ganó el beneficio extra");
        }

        //  resultados en pantalla

        Console.WriteLine("Comisión por primera venta: " + comisionVenta1);
        Console.WriteLine("Comisión por segunda venta: " + comisionVenta2);
        Console.WriteLine("Comisión por tercera venta: " + comisionVenta3);
        Console.WriteLine("Comisión total: " + comisionTotal);
        Console.WriteLine("Total recibido: " + totalsueldoRecibido);
        Console.WriteLine("Venta con mayor comisión: " + mayorComision);
        Console.WriteLine("Promedio de comisiones: " + promedioComisiones);
    }
}


