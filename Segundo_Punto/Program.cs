using System;

//---------------------------NÚMERO ESPECIAL---------------
class Program
{
    static void Main()
    {
        Console.Write("Ingrese el numero: ");
        int especial = int.Parse(Console.ReadLine());

        if(especial % 5 == 0 && especial % 2 != 0 && especial % 3 != 0){
            Console.Write("↔↔↔↔El numero es especial↔↔↔↔");
        }else{
            Console.Write("↔↔↔↔El numero no es especial↔↔↔↔");
        }
    }
}