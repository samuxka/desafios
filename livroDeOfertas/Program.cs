using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] array1 = {-1, 5, 10, 20, 28, 3, 7, 14, 22, 17};
        int[] array2 = {26, 134, 135, 15, 17, 18, 19, 25, 30, 6};

        int minDist = FindMinDistance(array1, array2);
        Console.WriteLine($"A menor distância é {minDist}");
    }

    static int FindMinDistance(int[] array1, int[] array2)
    {
        // Ordenar os arrays
        // Isso nos permite usar a técnica de dois ponteiros de forma eficiente
        Array.Sort(array1);
        Array.Sort(array2);
        
        // Inicializar ponteiros
        // i será o ponteiro para array1 e j para array2
        int i = 0, j = 0;
        // Inicializar a menor distância com um valor muito grande
        int minDistance = int.MaxValue;
        
        // Percorrer ambos os arrays até que um dos ponteiros atinja o final de seu respectivo array
        while (i < array1.Length && j < array2.Length)
        {
            // Calcular a distância atual entre os elementos apontados pelos ponteiros
            int currentDistance = Math.Abs(array1[i] - array2[j]);
            // Se a distância atual for menor que a menor distância conhecida, atualizá-la
            if (currentDistance < minDistance)
            {
                minDistance = currentDistance;
            }
        
            // Movimentar o ponteiro que aponta para o menor valor
            // Isso nos ajuda a encontrar uma potencial menor distância
            if (array1[i] < array2[j])
            {
                i++;  // Avançar o ponteiro de array1
            }
            else
            {
                j++;  // Avançar o ponteiro de array2
            }
        }
        
        // Retornar a menor distância encontrada
        return minDistance;
    }
}
