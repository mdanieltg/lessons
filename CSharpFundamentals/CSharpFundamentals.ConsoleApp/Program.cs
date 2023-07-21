// Primitivos - Tamaño asignado fijo en memoria (administrada)
// short, int, long, bool, float, decimal, double, char, byte, ptr, uint, ushort, ulong

// Valor
// struct

// Referencia (clase) - Tamaño asignado variable en memoria (no administrada), y además,
//   una dirección de memoria asignada para referencia
// object, string, dynamic


// Estructuras de control - Cambiar el flujo de ejecución del programa

// for, while, foreach, do-while - bucles

// 1 - 10
int iterador = 1; // Declaración & inicialización
while (iterador <= 10)
{
    Console.WriteLine(iterador);
    iterador++; // iterador = iterador + 1; // iterador += 1;
    // continue - continuar a la siguiente iteración
    // break - detener el bucle
}

//   iterador[es]     ; condicion[es]  ; incremento[s] (decremento)
for (int iterador1 = 1; iterador1 <= 10; iterador1++)
{
    Console.WriteLine(iterador1);
}

// 1 - 10
int iterador2 = 1;
do
{
    Console.WriteLine(iterador2);
    iterador2++;
}
while (iterador2 <= 10);
// 1 2 3 4 5 6 7 8 9 10

foreach (int num in new int[] { 1, 2, 3, 4 })
{
    Console.WriteLine(num);
}

// estructuras de decisión
// if, switch, if-else

bool condicion = false;
if (condicion == true)
{
    // ...
}
else if (condicion == true && condicion == false) // nunca se cumple
{
    // ...
}
else
{
    // ...
}

// switch statement
int num1 = 0;
switch (num1)
{
    case <= 0:
    case 10:
        Console.WriteLine("caso menor o igual a cero, o igual a 10");
        //Console.WriteLine("Caso 0");
        break;
    case 1:
        Console.WriteLine("caso 1");
        break;
    default:
        Console.WriteLine("caso predeterminado");
        break;
}

//switch expression
bool resultado = num1 switch
{
    <= 0 => true,
    10 => true,
    1 => true,
    _ => false
};


// control de flujo
// break, continue, return, goto
