using System;

namespace ClasesUdemy
{
    class Program
    {
        static void Main(string[] args)
        {
            //EJERCICIO 1 de for
            //variables 
            //byte i, numAlumnos;
            //double calificacion, sumaCalif = 0, promedio;

            //Console.WriteLine("ingrese numero de alumnos: ");
            //numAlumnos = Convert.ToByte(Console.ReadLine());

            //for(i=1; i<= numAlumnos; i++)
            //{
            //    Console.WriteLine("Ingresa la calificación: ");
            //    calificacion = Convert.ToDouble(Console.ReadLine());

            //    sumaCalif += calificacion;
            //}

            //promedio = sumaCalif / numAlumnos;
            //Console.WriteLine("El promedio es: {0}", promedio);

            //EJERCICIO 2 DE FOR

            //ulong i, numero, factorial = 1;

            //Console.Write("Ingresa el número para calcular su factorial: ");
            //numero = Convert.ToUInt64(Console.ReadLine());

            //for (i = numero; i >= 1; i--)
            //{
            //    factorial *= i;
            //}

            //Console.WriteLine("El factorial de {0}, es: {1}", numero, factorial);


            //WHILE

            //string contraseña1, contraseña2 = "";
            //Console.WriteLine("escribe tu contraseña: ");
            //contraseña1 = Console.ReadLine();

            //while (contraseña1 != contraseña2)
            //{
            //    Console.WriteLine("confirma tu contraseña: ");
            //    contraseña2 = Console.ReadLine();
            //}

            //Console.WriteLine("contraseña guardada");

            //DO
            //     int uno = 1;

            //    do
            //    {
            //        Console.WriteLine(uno);
            //        uno++;
            //    }
            //    while (uno <= 10);

            //Ejercicio DO WHILE

            //decimal num1, num2, resultado =0;
            //int opcion;


            //do
            //{

            //    Console.WriteLine("1. Suma");
            //    Console.WriteLine("2. Resta");
            //    Console.WriteLine("3. Multiplicación");
            //    Console.WriteLine("4. División");

            //    Console.Write("Escoge una opción: ");
            //    opcion = Convert.ToInt32(Console.ReadLine());

            //} while ((opcion < 1) || (opcion > 4));

            ////Pedimos los dos números
            //Console.Write("Dame el primer número: ");
            //num1 = Convert.ToDecimal(Console.ReadLine());

            //Console.Write("Dame el segundo número: ");
            //num2 = Convert.ToDecimal(Console.ReadLine());

            ////Hacer la operación según la opción escogida
            //switch (opcion)
            //{
            //    case 1:
            //        resultado = num1 + num2;
            //        break;
            //    case 2:
            //        resultado = num1 - num2;
            //        break;
            //    case 3:
            //        resultado = num1 * num2;
            //        break;
            //    case 4:
            //        if (num2 != 0)
            //        {
            //            resultado = num1 / num2;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Divisor no es valido");
            //        }
            //        break;
            //}

            ////Mostramos el resultado
            //Console.WriteLine("El resultado es: {0}", resultado);

            //Iteraciones anidadas
            int i, j, resultado;

            for (i = 1; i <= 10; i++){

                Console.WriteLine("Tabla de multiplicar del {0}", i);
                
                for(j=1; j<=10; j++)
                {
                    resultado = i * j;

                    Console.WriteLine("{0} x {1} = {2}", i, j, resultado);
                }

            }

        }

    }
}
