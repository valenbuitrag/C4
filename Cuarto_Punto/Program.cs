using System;

//--------------------------SISTEMA DE INICIO DE SESIÓN---------------

class Program
{
    static void Main()
    {
        string usuarioP = "Valen20";
        string contraP = "ValeHermosa17";
        int contador = 3;
        do
        {
            Console.Write("\nIngrese el usuario: ");
            string usuario = Console.ReadLine();
            Console.Write("Ingrese la contraseña: ");
            string contraseña = Console.ReadLine();

            if (usuario == usuarioP && contraseña == contraP)
            {
                Console.Write("\n↔↔↔↔ACCESO CONCEDIDO↔↔↔↔");
                break;
            }
            else
            {
                Console.Write("Intentos: " + (contador - 1));
                contador--;
            }
        } while (contador != 0);
        if (contador == 0)
        {
            Console.Write("\n↔↔↔↔Acceso Denegado↔↔↔↔");
        }
    }
}