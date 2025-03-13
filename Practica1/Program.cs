using System; 
public class Numeros{
  public static int[] IngresoNumeros(){
      int [] numeros= new int[10];
      for(int i=0; i<10;i++){
        Console.WriteLine($"Ingrese un numero:{i} ");
        numeros[i]=int.Parse(Console.ReadLine());
        }   
      return numeros;
  }
  public static void SumaPromedio(int[] numeros){
      double suma=0;
      double prom=0;
      for(int i=0; i<10;i++){
        suma+=numeros[i];
        }
      prom=suma/10;
      Console.WriteLine($"La suma de los numeros es: {suma}");
      Console.WriteLine($"El promedio de los numeros es: {prom}");
  }
}
class Program
{

    static void Main()
    {
        int[] numeros = Numeros.IngresoNumeros();
        Numeros.SumaPromedio(numeros);
    }
}
 
 