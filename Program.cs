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
