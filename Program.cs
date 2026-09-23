// Función de imprimir notas
static void ImprimirNotas(int[] notas)
{
    for (int i = 0; i < notas.Length; i++)
    {
        Console.WriteLine(notas[i]);
    }
}

static double CalcularPromedio(int[] notas)
{
    int suma = 0;

    for (int i = 0; i < notas.Length; i++)
    {
        suma += notas[i];
    }

    double promedio = (double)suma / notas.Length;

    return promedio;
}

int[] notas = { 15, 18, 12, 17, 20 };

ImprimirNotas(notas);

double promedio = CalcularPromedio(notas);

Console.WriteLine($"El promedio es: {promedio}");

//Imprimir la nota mayor y menor
int mayor = notas[0];
int menor = notas[0];
for(int i=1; i<notas.Length; i++)
{
    if(notas[i] > mayor)
    {
        mayor = notas[i];
    }
    if(notas[i] < menor)
    {
        menor = notas[i];
    }
}
Console.WriteLine($"La nota mayor es: {mayor}");
Console.WriteLine($"La nota menor es: {menor}");
