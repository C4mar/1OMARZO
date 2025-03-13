using System;
class BusquedaNombres{ 
    public static string[] IngresoNombres(){
        string [] nombre = new string[5];
        for (int i=0; i<5; i++){
            Console.WriteLine("Ingrese un nombre: "); 
            nombre[i]=Console.ReadLine();
            }
        return nombre;
    }
    public static void BuscarNombre(string[] nombre){
        Console.WriteLine("Ingresa el nombre a buscar: ");
        string buscar=Console.ReadLine();
        bool encontrado=false;
        int pos=0;
        for (int i=0; i<5; i++){
            if (nombre[i]==buscar){
                encontrado=true;
                pos=i;
                break;
                }
            }
        if (encontrado){
            Console.WriteLine($"El nombre {buscar} fue encontrado en la posicion {pos}");
            }
        else{
            Console.WriteLine($"El nombre {buscar} no fue encontrado");
        }
    } 
}
class program{
    static void Main(){
        string[]nombre=BusquedaNombres.IngresoNombres();
        BusquedaNombres.BuscarNombre(nombre);
    }
}