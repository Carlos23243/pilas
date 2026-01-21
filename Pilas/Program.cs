using System;
using System.Collections.Generic;

class TorresDehanoi
{
    static System.Collections.Generic.Stack<int> origen = new Stack<int>();
    static System.Collections.Generic.Stack<int> auxiliar = new System.Collections.Generic.Stack<int>();
    static System.Collections.Generic.Stack<int> destino = new System.Collections.Generic.Stack<int>();

    static void Main()
    {
        int discos = 3;
        for (int i = discos; i >= 1; i--)
        {
            origen.Push(i);
        }

        ResolverHanoi(discos, destino, auxiliar, "Origen", "Destino", "Auxiliar");

    }

    private static void ResolverHanoi(int discos, System.Collections.Generic.Stack<int> destino, System.Collections.Generic.Stack<int> auxiliar, string v1, string v2, string v3)
    {
        throw new NotImplementedException();
    }

    static void ResolverHanoi(int n, System.Collections.Generic.Stack<int> origen, System.Collections.Generic.Stack<int> auxiliar, System.Collections.Generic.Stack<int> origen1, string nombreOrigen, string nombreDestino, string nombreAuxiliar)
    {
        if (n == 1)
        {
            int disco = origen.Pop();
            destino.Push(disco);
            Console.WriteLine($"\n\nMover disco {disco} de {nombreOrigen} a {nombreDestino}");
            return;
        }

        ResolverHanoi(n - 1, origen, auxiliar, destino, nombreOrigen, nombreAuxiliar, nombreDestino);

        int discoActual = origen.Pop();
        destino.Push(discoActual);
        Console.WriteLine($"\n\nMover disco {discoActual} de {nombreOrigen} a {nombreDestino}");

        ResolverHanoi(n - 1, auxiliar, destino, origen, nombreAuxiliar, nombreDestino, nombreOrigen);
    }

}

internal class Stack<T> : System.Collections.Generic.Stack<int>
{
}