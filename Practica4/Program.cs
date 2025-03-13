using System;

class ReversionNumeros{
    public static void IngresarNumeros(int[] numeros, int n){
        for (int i=0; i<n; i++){
            Console.Write("Ingrese un número: ");
            numeros[i]=int.Parse(Console.ReadLine());
        }
    }
    public static void MostrarNumeros(int[] numeros, int n){
        Console.WriteLine("Numeros ingresados: ");
        for (int i=0; i<n; i++){
            Console.WriteLine(numeros[i]);
        }
    }

    public static void RevertirNumeros(int[] numeros, int n){
        Console.WriteLine("Numeros revertidos: ");
        for (int i=n-1; i>=0; i--){
            Console.WriteLine(numeros[i]);
        }
    }
    }
class Program{
    static void Main(){
        Console.Write("Ingrese el tamaño del arreglo: ");
        int n = int.Parse(Console.ReadLine());
        int[] numeros = new int[n];
        
        ReversionNumeros.IngresarNumeros(numeros, n);
        ReversionNumeros.MostrarNumeros(numeros, n);
        ReversionNumeros.RevertirNumeros(numeros, n);
    }
    
}