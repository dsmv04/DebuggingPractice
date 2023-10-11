// Challenge 1
// Debe ser un booleano, no una cadena
//bool amProgrammer = true;
// Los enteros no pueden ser decimales
//int Age = 27;

List<string> Names = new List<string>();
// No se puede sobrescribir una lista completa con una cadena
Names.Add("Monica");
Dictionary<string, string> MyDictionary = new Dictionary<string, string>();
MyDictionary.Add("Hello", "0");
// No se puede poner un número entero donde se esperaba una cadena
MyDictionary.Add("Hi there", "0");
// Las comillas simples se utilizan para indicar caracteres, no cadenas, en C#
//string MyName = "MyName";

// Challenge 2
// i comenzó fuera de los límites, lo que no permite que comience el ciclo
List<int> Numbers = new List<int>() {2,3,6,7,1,5};
for(int i = Numbers.Count-1; i >= 0; i--)
{
    Console.WriteLine(Numbers[i]);
}

// Challenge 3
/* MoreNumbers[i] estaría extrayendo valores como MoreNumbers[12] que está fuera de los límites.
Los bucles Foreach ya toman el valor en un índice y no necesitamos hacer referencia al índice. */
List<int> MoreNumbers = new List<int>() {12,7,10,-3,9};
foreach(int i in MoreNumbers)
{
    Console.WriteLine(MoreNumbers);
}

// Challenge 4
/* No se puede asignar un valor a una variable de iteración foreach.
Una mejor opción sería utilizar un bucle for estándar en su lugar. */
List<int> EvenMoreNumbers = new List<int> {3,6,9,12,14};
// foreach(int num in EvenMoreNumbers)
// {
//     if(num % 3 == 0)
//     {
//         num = 0;
//     }
// }
for(int num = 0; num < EvenMoreNumbers.Count; num++)
{
    if(EvenMoreNumbers[num] % 3 == 0)
    {
        EvenMoreNumbers[num] = 0;
    }
}

// Challenge 5
// ¿Qué podemos aprender de este mensaje de error?
/* No podemos editar cadenas usando valores de índice de la misma manera que podemos
editar una matriz o una lista porque las cadenas son valores de solo lectura.
Este fragmento de código no se puede ejecutar. */
//string MyString = "superduberawesome";
// MyString[7] = "p";

// Challenge 6
// Sugerencia: algunos errores no vienen con mensajes de error
// En este caso, Random solo generará valores entre 0 y 11, lo que significa que nunca alcanzaremos la declaración if.
Random rand = new Random();
int randomNum = rand.Next(12);
if(randomNum < 12)
{
    Console.WriteLine("Hello");
}