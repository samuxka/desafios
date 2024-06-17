using System;

public class Program{
    public static void Main(){
        // Criação dos arrays
        int[] array1 = {1, 2, 3, 5, 7};
        int[] array2 = {10, 20, 30, 40};

        int menorDistancia = MenorDistanciaEntreElementos(array1, array2);
        Console.WriteLine("A menor distancia entre elementos dos arrays é: " + menorDistancia);
    }
    // Função para encontrar a menor distância
    public static int MenorDistanciaEntreElementos(int[] array1, int[] array2){

        int menorDistancia = int.MaxValue;

        foreach (int a in array1){
            foreach(int b in array2){
                int distancia = Math.Abs(a - b);
                if (distancia < menorDistancia){
                    menorDistancia = distancia;
                }
            }
        }
        return menorDistancia;
    }
}