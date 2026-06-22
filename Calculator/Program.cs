using System;
using System.Collections.Generic;

int firstNumber, secondNumber, result, option;
PantallaConsola pantalla = new PantallaConsola();

// Registramos las operaciones usando polimorfismo (OCP)
Dictionary<int, IOperacion> operaciones = new Dictionary<int, IOperacion>
{
    { 1, new Suma() },
    { 2, new Resta() },
    { 3, new Multiplicacion() },
    { 4, new Division() }
};

do
{
    pantalla.MostrarMenu();
    option = pantalla.PedirNumero();

    if (!operaciones.ContainsKey(option))
    {
        Console.WriteLine("Opcion no valida, intente nuevamente.\n");
        continue;
    }

    firstNumber = pantalla.PedirEntrada("primer");
    secondNumber = pantalla.PedirEntrada("segundo");

    IOperacion operacionSeleccionada = operaciones[option];

    try
    {
        result = operacionSeleccionada.Calcular(firstNumber, secondNumber);
        pantalla.MostrarResultado(result);
    }
    catch (DivideByZeroException)
    {
        pantalla.MostrarMensaje("No se puede dividir entre cero");
    }

} while (option < 1 || option > 4);

public interface IOperacion
{
    int Calcular(int num1, int num2);
}

public class Suma : IOperacion
{
    public int Calcular(int num1, int num2) => num1 + num2;
}

public class Resta : IOperacion
{
    public int Calcular(int num1, int num2) => num1 - num2;
}

public class Multiplicacion : IOperacion
{
    public int Calcular(int num1, int num2) => num1 * num2;
}

public class Division : IOperacion
{
    public int Calcular(int num1, int num2)
    {
        if (num2 == 0)
        {
            throw new DivideByZeroException();
        }

        return num1 / num2;
    }
}

public class PantallaConsola
{
    public void MostrarMenu()
    {
        Console.WriteLine("Elije una opcion:");
        Console.WriteLine("1. SUMA");
        Console.WriteLine("2. RESTA");
        Console.WriteLine("3. MULTIPLICACION");
        Console.WriteLine("4. DIVISION");
    }

    public int PedirNumero() => Convert.ToInt32(Console.ReadLine());

    public int PedirEntrada(string orden)
    {
        Console.WriteLine($"Ingrese el {orden} numero:");
        return Convert.ToInt32(Console.ReadLine());
    }

    public void MostrarResultado(int valor)
    {
        Console.WriteLine($"El resultado es: {valor}\n");
    }
}