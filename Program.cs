int [] notas={15,18,12,17,20};

//Imprimir notas
for(int i=0; i<notas.Length; i++)
{
    Console.WriteLine(notas[i]);
}

foreach (int nota in notas)
{
    Console.WriteLine(nota);
}