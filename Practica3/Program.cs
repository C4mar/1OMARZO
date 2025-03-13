using System;

public class OrdenarNumeros{
    public static void IngresarNumeros(int[] numeros, int n){
        for (int i=0; i<n; i++){
            Console.Write("Ingrese un número: ");
            numeros[i]=int.Parse(Console.ReadLine());
        }
    }
    public static void OrdenamientoBurbuja(int[] numeros, int n){
        for (int i=0; i<n-1; i++){
            for (int j=0; j<n-1; j++){
                if (numeros[j]>numeros[j+1]){
                    int aux=numeros[j];
                    numeros[j]=numeros[j+1];
                    numeros[j+1]=aux;
                    }
                }
            }
        Console.WriteLine("Numeros ordenados: ");
        for (int i=0; i<n; i++){
            Console.WriteLine(numeros[i]);
            }
    }

}
class Program{
    static void Main(){
        Console.Write("Ingrese el tamaño del arreglo: ");
        int n = int.Parse(Console.ReadLine());
        int[] numeros = new int[n];
        
        OrdenarNumeros.IngresarNumeros(numeros, n);
        OrdenarNumeros.OrdenamientoBurbuja(numeros, n);
    }
    
}