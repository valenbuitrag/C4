using System;

//---------------------------DÍAS Y SEMANAS---------------
class Program
{
    static void Main()
    {
        Console.Write("Ingrese su edad: ");
        if (int.TryParse(Console.ReadLine(), out int edad))
        {
            DateTime fechaActual = DateTime.Now;

            DateTime fechaNacimiento = fechaActual.AddYears(-edad);

            int diasTranscurridos = (int)(fechaActual - fechaNacimiento).TotalDays;
            int semanasTranscurridas = diasTranscurridos / 7;

            Console.WriteLine($"Han transcurrido {diasTranscurridos} días desde su nacimiento.");
            Console.WriteLine($"Han transcurrido {semanasTranscurridas} semanas desde su nacimiento.");
        }
        else
        {
            Console.WriteLine("↔↔↔↔Entrada inválida. Ingrese un número entero para la edad.↔↔↔↔");
        }
    }
}