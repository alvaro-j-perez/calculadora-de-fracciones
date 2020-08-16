using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {    //
             //VARIABLES DE ENTRADA
             //DEL NUMERADOR Y EL DENOMINADOR
             //

            int denominador1 = 0;
            int denominador2 = 0;
            int numerador1 = 0;      
            int numerador2 = 0;
            int rdenominador = 0;
            int rnumerador = 0;

            //DEFINICIONES DE DIALOGO DE LA CALCULADORA

            Console.WriteLine("BIENVENIDO A LA CALCULADORA DEL SPACEX." );
            Console.WriteLine();
            Console.WriteLine("¿Que operación deseas realizar?");

            Console.WriteLine("1. Suma de Fracciones");
            Console.WriteLine("2. Resta de Fracciones");
            Console.WriteLine("3. Multiplicación de Fracciones");
            Console.WriteLine("4. División de Fracciones");
            int opcion = Convert.ToInt32 ( Console.ReadLine());

            //FUNCIONES DE LA SUMA DE FRACCIONES
            //EN ESTA FUNCION APARECERA SI DESEA OPERAR FRACCION CON IGUAL O DISTINTO DENOMINADOR

            switch(opcion){

                case 1:
                    Console.WriteLine("Suma de Fracciones");
                    Console.WriteLine();

                    Console.WriteLine("Selecciona que tipo de suma de Fracciones quieres trabajar");
                    Console.WriteLine("1. Con igual denominador");
                    Console.WriteLine("2. Con distinto denominador");
                    int opcion2 = Convert.ToInt32(Console.ReadLine());

                    //
                    //FUNCION PARA DATOS DE ENTRADA DE LA SUMA DE FRACCIONES CON IGUAL DENOMINADOR
                    //
                    switch(opcion2){
                        case 1:
                            Console.WriteLine("Suma de Fracciones con igual denominador: ");
                            Console.WriteLine("Primera Fracción:");
                            numerador1 = Convert.ToInt32 ( Console.ReadLine());
                            Console.WriteLine("-");
                            denominador1 = Convert.ToInt32 ( Console.ReadLine());

                            Console.WriteLine("Segunda Fracción:");
                            numerador2 = Convert.ToInt32 ( Console.ReadLine());
                            Console.WriteLine("-");
                            denominador2 = Convert.ToInt32 ( Console.ReadLine());

                            Console.WriteLine();

                            rnumerador = numerador1 + numerador2;
                            rdenominador = denominador1;

                            Console.WriteLine("El resultado es: ");

                            if(rdenominador == 0){
                                Console.WriteLine("INDETERMINACIÓN");
                            }
                            else{
                            Console.WriteLine(numerador1 + "/" + denominador1 + " + " + numerador2 + "/" + denominador2 + " = " + rnumerador + "/" + rdenominador);
                            Console.WriteLine();
                            }

                            break;

                            //FUNCION PARA LA SUMA DE FRACCIONES CON DISTINTO DENOMINADOR

                        case 2:
                            Console.WriteLine("Suma de Fracciones con distinto denominador: ");
                            Console.WriteLine("Primera Fracción:");
                            numerador1 = Convert.ToInt32 ( Console.ReadLine());
                            Console.WriteLine("-");
                            denominador1 = Convert.ToInt32 ( Console.ReadLine());

                            Console.WriteLine("Segunda Fracción:");
                            numerador2 = Convert.ToInt32 ( Console.ReadLine());
                            Console.WriteLine("-");
                            denominador2 = Convert.ToInt32 ( Console.ReadLine());

                            Console.WriteLine();

                            rnumerador = (numerador1 * denominador2) + (numerador2 * denominador1);
                            rdenominador = denominador1 * denominador2;

                            if(rdenominador == 0){
                                Console.WriteLine("INDETERMINACIÓN");
                            }
                            else{
                            Console.WriteLine(numerador1 + "/" + denominador1 + " + " + numerador2 + "/" + denominador2 + " = " + rnumerador + "/" + rdenominador);
                            Console.WriteLine();
                            }

                            // ESTA FUNCION ES POR SI SE LE INGRESA UN DATO NO VALIDO AL PROGRAMA
                            // SE SALE Y PROGRAMA Y DEJA DE EJECUTAR


                            break;

                        default:
                            Console.WriteLine("La opción seleccionada esta fuera de rango");
                            break;

                    }

                    break;

                    // FUNCION DE LA RESTA DE FRACCIONES
                    // Y LAS FUNCIONES CON LAS QUE SE PUEDE TRABAJAR

                case 2:
                    Console.WriteLine("Resta de Fracciones");
                    Console.WriteLine();
                    Console.WriteLine("Selecciona que tipo de resta de Fracciones quieres trabajar");
                    Console.WriteLine("1. Con igual denominador");
                    Console.WriteLine("2. Con distinto denominador");
                    opcion2 = Convert.ToInt32(Console.ReadLine());

                    //FUNCION DE LA RESTA CON IGUAL DENOMINADOR
                    //Y DATOS DE ENTRA DE LA PRIMERA FRACCION Y LA SEGUNDA FRACCION
                    
                    switch(opcion2){
                        case 1:
                            Console.WriteLine("Resta de Fracciones con igual denominador: ");
                            Console.WriteLine("Primera Fracción:");
                            numerador1 = Convert.ToInt32 ( Console.ReadLine());
                            Console.WriteLine("-");
                            denominador1 = Convert.ToInt32 ( Console.ReadLine());

                            Console.WriteLine("Segunda Fracción:");
                            numerador2 = Convert.ToInt32 ( Console.ReadLine());
                            Console.WriteLine("-");
                            denominador2 = Convert.ToInt32 ( Console.ReadLine());

                            Console.WriteLine();

                            rnumerador = numerador1 - numerador2;
                            rdenominador = denominador1;

                            Console.WriteLine("El resultado es: ");

                            if(rdenominador == 0){
                                Console.WriteLine("INDETERMINACIÓN");
                            }
                            else{
                            Console.WriteLine(numerador1 + "/" + denominador1 + " - " + numerador2 + "/" + denominador2 + " = " + rnumerador + "/" + rdenominador);
                            Console.WriteLine();
                            }

                            break;

                            // RESTA DE FRACCIONES CON DISTINTO DENOMINADOR
                            //DATOS DE ENTRA DE LA PRIMERA FRACCION Y LA SEGUNDA FRACCION
                            // Y LA CONVERSION A NUMEROS ENTEROS 

                        case 2:
                            Console.WriteLine("Resta de Fracciones con distinto denominador: ");
                            Console.WriteLine("Primera Fracción:");
                            numerador1 = Convert.ToInt32 ( Console.ReadLine());
                            Console.WriteLine("-");
                            denominador1 = Convert.ToInt32 ( Console.ReadLine());

                            Console.WriteLine("Segunda Fracción:");
                            numerador2 = Convert.ToInt32 ( Console.ReadLine());
                            Console.WriteLine("-");
                            denominador2 = Convert.ToInt32 ( Console.ReadLine());

                            Console.WriteLine();

                            rnumerador = (numerador1 * denominador2) - (numerador2 * denominador1);
                            rdenominador = denominador1 * denominador2;

                            if(rdenominador == 0){
                                Console.WriteLine("INDETERMINACIÓN");
                            }
                            else{
                            Console.WriteLine(numerador1 + "/" + denominador1 + " - " + numerador2 + "/" + denominador2 + " = " + rnumerador + "/" + rdenominador);
                            Console.WriteLine();
                            }

                            break;

                            //SI LOS DATOS DE ENTRADA SON ERRONEOS SE SALDRA DEL PROGRAMA

                        default:
                            Console.WriteLine("La opción seleccionada esta fuera de rango");
                            break;

                    }
                    break;

                    //MULTIPLICACION DE FRACCIONES 
                    //CONVERSION PARA LOS DATOS DE ENTRADA
                    //DE LA PRIMERA FRACCION Y LA SEGUNDA FRACCION.

                case 3:
                    Console.WriteLine("Multiplicación de Fracciones: ");
                    Console.WriteLine("Primera Fracción:");
                    numerador1 = Convert.ToInt32 ( Console.ReadLine());
                    Console.WriteLine("-");
                    denominador1 = Convert.ToInt32 ( Console.ReadLine());

                    Console.WriteLine("Segunda Fracción:");
                    numerador2 = Convert.ToInt32 ( Console.ReadLine());
                    Console.WriteLine("-");
                    denominador2 = Convert.ToInt32 ( Console.ReadLine());

                    Console.WriteLine();

                    rnumerador = numerador1 * numerador2;
                    rdenominador = denominador1 * denominador2;

                    if(rdenominador == 0){
                        Console.WriteLine("INDETERMINACIÓN");
                    }
                    else{
                        Console.WriteLine(numerador1 + "/" + denominador1 + " * " + numerador2 + "/" + denominador2 + " = " + rnumerador + "/" + rdenominador);
                        Console.WriteLine();
                        }

                    break;

                    //DIVISION DE FRACCION
                    //DATOS DE ENTRADA DE LA PRIMERA FRACCION Y LA SEGUNDA FRACCION

                case 4:
                    Console.WriteLine("Dvisión de Fracciones: ");
                    Console.WriteLine("Primera Fracción:");
                    numerador1 = Convert.ToInt32 ( Console.ReadLine());
                    Console.WriteLine("-");
                    denominador1 = Convert.ToInt32 ( Console.ReadLine());

                    Console.WriteLine("Segunda Fracción:");
                    numerador2 = Convert.ToInt32 ( Console.ReadLine());
                    Console.WriteLine("-");
                    denominador2 = Convert.ToInt32 ( Console.ReadLine());

                    Console.WriteLine();

                    rnumerador = numerador1 * denominador2;
                    rdenominador = denominador1 * numerador2;

                    //SI EN DADO CASO SE INGRESARA DATOS QUE SON INVALIDOS

                    if(rdenominador == 0){
                        Console.WriteLine("INDETERMINACIÓN");
                    }
                    else{
                        Console.WriteLine(numerador1 + "/" + denominador1 + " / " + numerador2 + "/" + denominador2 + " = " + rnumerador + "/" + rdenominador);
                        Console.WriteLine();
                        }
                    break;

                default:
                    Console.WriteLine("La opción seleccionada esta fuera de rango");
                    break;
            }
        }
    }
}
