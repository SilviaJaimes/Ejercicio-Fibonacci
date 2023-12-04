/* 
Reto 1: Fibonacci rusa: 
    -Escriba un programa que reciba como entrada un número entero n, y entregue como salida el n-
    ésimo número de Fibonacci.
    -Escriba un programa que reciba como entrada un número entero e indique si es o no un número
    de Fibonacci.
    -Escriba un programa que muestres los m primeros números de Fibonacci, donde m es un número
    ingresado por el usuario.
*/

while (true)
{
    Console.WriteLine("\nFIBONACCI\n");
    Console.WriteLine("1. Programa que reciba como entrada un número entero n, y entregue como salida el n-ésimo número de Fibonacci.");
    Console.WriteLine("2. Programa que reciba como entrada un número entero e indique si es o no un número de Fibonacci.");
    Console.WriteLine("3. Programa que muestres los m primeros números de Fibonacci, donde m es un número ingresado por el usuario.");
    Console.WriteLine("4. Salir.");

    Console.Write("\nIngrese el número de la opción que desea realizar: ");
    int opcion = Convert.ToInt32(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            Console.Write("Ingrese un número entero: ");
            Console.WriteLine();

            int n = Convert.ToInt32(Console.ReadLine());

            int numero = n-1;
            int F0 = 0;
            int Fprimero = 1;
            int sum = 0;

            Console.Write("El n-ésimo número Finacci es:");

            for (int i = 0; i < numero; i++)
            {
                sum = F0 + Fprimero;
                F0 = Fprimero;
                Fprimero = sum;
            }

            Console.WriteLine(sum);
            break;

        case 2:
            Console.Write("Ingrese un número entero: ");

            int num = Convert.ToInt32(Console.ReadLine());

            int resta = num-1;
            int numAnte = 0;
            int numAnte1 = 1;
            int suma = 0;

            for (int i = 0; i < resta; i++)
            {
                suma = numAnte + numAnte1;
                numAnte = numAnte1;
                numAnte1 = suma;
            }

            if (suma == num)
            {
                Console.WriteLine(num + " es número de Fibonacci");
                return;
            }
            else
            {
                Console.WriteLine(num + " no es número de Fibonacci");
                return;
            }

        case 3:
            Console.Write("Ingrese un número entero: ");
            Console.WriteLine();

            int m = Convert.ToInt32(Console.ReadLine());

            int F = 1;
            int F1 = 0;
            int Fn = 0;

            Console.WriteLine("Los " + m + " primeros números de Fibonacci son: ");

            for (int i = 0; i < m; i++)
            {
                Console.WriteLine(Fn);

                Fn = F + F1;
                F = F1;
                F1 = Fn;
            }
            break;

        case 4:
            Console.Write(opcion);
            break;

        default:
            Console.WriteLine("Seleccione una opción correcta.");
            break;
    }
} 
