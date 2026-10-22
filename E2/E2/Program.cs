using System; 
namespace E2
{
    class Program
    {
        static void Main(string[]args)
        {
            //1. Sintaxis para definir una funcion 
            // tipo_dato_devuelto identificador_funcion(parametros, no siempre se incluyen)
            // { 
            //bloque de instrucciones 
            //}
            // identificador_funcion(argumentos, si es que hay parametros)

            //2.Definir un ciclo para imprimir la siguiente secuencia 2, 4, 6, 9, 12, 15, 19, 23, 27 
            int[] secuencia = { 2, 4, 6, 9, 12, 15, 19, 23, 27 };
            for (int i = 0; i < secuencia.Length; i++)
            {
                Console.WriteLine(secuencia[i]);
            }

            //3. Declarar e inicializar dos variables: inicio, limite. Si el producto de inicio y limite es menor que 8 e inicio es mayor que limite, definir ciclo descendente de 9 ejecuciones. En cualquier otro caso, definir un ciclo ascendente 
            int inicio = 5;
            int limite = 3;
            if (inicio * limite < 8 && inicio > limite)
            {
                for (int p = 0; p >= 9; p--)
                {
                    Console.WriteLine(p);
                }
            }
            else
            {
                for (int p = 0; p <= 9; p++)
                {
                    Console.WriteLine(p);
                }

                //4. Definir e invocar una funcion para determinar si un numero es multiplo de 5. Si el numero es multiplo de 5, devolver true; en caso contrario, false. Imprimir la devolucion utilizando interpolacion 
                
                int numero = 10;
                bool resultado = Multiplo(numero);
                Console.WriteLine($"El numero {numero} es multiplo de 5: {resultado}");

                bool Multiplo(int numero)
                {
                    return numero % 5 == 0;
                }
                

                //5. Definir e invocar una funcion vacia para imprimir : "Examen de programacion III", donde "Programacion III" corresponde a un argumento 

                void ImprimirMensaje(string mensaje)
                {
                    Console.WriteLine($"Examen de {mensaje}");
                }   
                ImprimirMensaje("Programacion III"); 
            }
        }
    }
}
