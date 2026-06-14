//Hola SEBASTIAN COMO ESTAS?, mucho gusto

int a, b, c, d;
int n;

do
{
    Console.WriteLine("Elije una opcion:");
    Console.WriteLine("1. SUMA");
    Console.WriteLine("2. RESTA");
    Console.WriteLine("3. MULTIPLICACION");
    Console.WriteLine("4. DIVISION");

    n = Convert.ToInt32(Console.ReadLine());

    switch (n)
    {
        case 1:
            Console.WriteLine("Ingrese el primer numero:");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero:");
            b = Convert.ToInt32(Console.ReadLine());

            c = a + b;
            Console.WriteLine("El resultado de la suma es: " + c);
            break;

        case 2:
            Console.WriteLine("Ingrese el primer numero:");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero:");
            b = Convert.ToInt32(Console.ReadLine());

            d = a - b;
            Console.WriteLine("El resultado de la resta es: " + d);
            break;

        case 3:
            Console.WriteLine("Ingrese el primer numero:");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero:");
            b = Convert.ToInt32(Console.ReadLine());

            c = a * b;
            Console.WriteLine("El resultado de la multiplicacion es: " + c);
            break;

        case 4:
            Console.WriteLine("Ingrese el primer numero:");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero:");
            b = Convert.ToInt32(Console.ReadLine());

            if (b != 0)
            {
                d = a / b;
                Console.WriteLine("El resultado de la division es: " + d);
            }
            else
            {
                Console.WriteLine("No se puede dividir entre cero");
            }
            break;

        default:
            Console.WriteLine("Opcion no valida, intente nuevamente.");
            break;
    }

} while (n >= 1 && n <= 4);