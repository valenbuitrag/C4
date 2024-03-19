using System;

//---------------------------CALCULADORA DE FRACCIONES---------------

class Program
{
    static void Main()
    {
        Console.Write("↔↔↔↔Calculadora de Fracciones↔↔↔↔ \n");

        Console.Write("Ingrese el numerador de la fracción 1: ");
        int numerador1 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el denominador de la fracción 1: ");
        int denominador1 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el operador (+, -, *, /): ");
        char operador = char.Parse(Console.ReadLine());

        Console.Write("Ingrese el numerador de la fracción 2: ");
        int numerador2 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el denominador de la fracción 2: ");
        int denominador2 = int.Parse(Console.ReadLine());

        switch (operador)
        {
            case '+':
                SumarFracciones(numerador1, denominador1, numerador2, denominador2);
                break;
            case '-':
                RestarFracciones(numerador1, denominador1, numerador2, denominador2);
                break;
            case '*':
                MultiplicarFracciones(numerador1, denominador1, numerador2, denominador2);
                break;
            case '/':
                DividirFracciones(numerador1, denominador1, numerador2, denominador2);
                break;
            default:
                Console.WriteLine("↔↔↔↔Operador no válido.↔↔↔↔");
                break;
        }
    }

    static void SumarFracciones(int numerador1, int denominador1, int numerador2, int denominador2)
    {
        int nuevoDenominador = denominador1 * denominador2;
        int nuevoNumerador = (numerador1 * denominador2) + (numerador2 * denominador1);
        MostrarResultado(nuevoNumerador, nuevoDenominador);
    }

    static void RestarFracciones(int numerador1, int denominador1, int numerador2, int denominador2)
    {
        int nuevoDenominador = denominador1 * denominador2;
        int nuevoNumerador = (numerador1 * denominador2) - (numerador2 * denominador1);
        MostrarResultado(nuevoNumerador, nuevoDenominador);
    }

    static void MultiplicarFracciones(int numerador1, int denominador1, int numerador2, int denominador2)
    {
        int nuevoNumerador = numerador1 * numerador2;
        int nuevoDenominador = denominador1 * denominador2;
        MostrarResultado(nuevoNumerador, nuevoDenominador);
    }

    static void DividirFracciones(int numerador1, int denominador1, int numerador2, int denominador2)
    {
        if (numerador2 == 0)
        {
            Console.WriteLine("↔↔↔↔Error: No se puede dividir por cero.↔↔↔↔");
        }
        else
        {
            int nuevoNumerador = numerador1 * denominador2;
            int nuevoDenominador = denominador1 * numerador2;
            MostrarResultado(nuevoNumerador, nuevoDenominador);
        }
    }

    static void MostrarResultado(int numerador, int denominador)
    {
        Console.WriteLine($"↔↔↔↔Resultado: {numerador}/{denominador}↔↔↔↔");
    }
}