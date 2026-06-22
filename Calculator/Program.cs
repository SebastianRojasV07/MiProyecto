int firstNumber, secondNumber, result, option;

CalculadoraMatematica calculadora = new CalculadoraMatematica();
PantallaConsola pantalla = new PantallaConsola();

do
{
    pantalla.MostrarMenu();
    option = pantalla.PedirNumero();

    if (option < 1 || option > 4)
    {
        Console.WriteLine("Opcion no valida, intente nuevamente.\n");
        continue;
    }

    firstNumber = pantalla.PedirEntrada("primer");
    secondNumber = pantalla.PedirEntrada("segundo");

    switch (option)
    {
        case 1:
            result = calculadora.Sumar(firstNumber, secondNumber);
            pantalla.MostrarResultado("suma", result);
            break;

        case 2:
            result = calculadora.Restar(firstNumber, secondNumber);
            pantalla.MostrarResultado("resta", result);
            break;

        case 3:
            result = calculadora.Multiplicar(firstNumber, secondNumber);
            pantalla.MostrarResultado("multiplicacion", result);
            break;

        case 4:
            if (secondNumber != 0)
            {
                result = calculadora.Dividir(firstNumber, secondNumber);
                pantalla.MostrarResultado("division", result);
            }
            else
            {
                Console.WriteLine("No se puede dividir entre cero");
            }
            break;
    }

} while (option < 1 || option > 4);


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

    public int PedirNumero()
    {
        return Convert.ToInt32(Console.ReadLine());
    }

    public int PedirEntrada(string orden)
    {
        Console.WriteLine($"Ingrese el {orden} numero:");
        return Convert.ToInt32(Console.ReadLine());
    }

    public void MostrarResultado(string operacion, int valor)
    {
        Console.WriteLine($"El resultado de la {operacion} es: {valor}\n");
    }
}

public class CalculadoraMatematica
{
    // Su único trabajo: Hacer matemáticas puras
    public int Sumar(int num1, int num2) => num1 + num2;
    public int Restar(int num1, int num2) => num1 - num2;
    public int Multiplicar(int num1, int num2) => num1 * num2;
    public int Dividir(int num1, int num2) => num1 / num2;
}