class ArchivoTexto{
    private static string[] nombres;
    private static int n=5;
    
    public static void ListaNombres(){
        nombres = new string[n];
        for (int i=0; i<n; i++){
            Console.Write("Ingrese un nombre: ");
            string nombre = Console.ReadLine();
            while (string.IsNullOrEmpty(nombre)){
                Console.WriteLine("El nombre no puede estar vacío");
                Console.Write("Ingrese un nombre: ");
                nombre = Console.ReadLine();
            }
            nombres[i] = nombre;
        }
    }
    public static void CrearArchivo(){
        if (nombres = null){
            Console.WriteLine("No se ha ingresado ningún nombre");
        }
        try{
            using(){
                StreamWriter sw = new StreamWriter("nombres.txt");
                for (int i=0; i<n; i++){
                    sw.WriteLine(nombres[i]);
                }
                sw.Close();
            }
        }
    }
}

class Programa{
    static void Main(){
        ArchivoTexto.ListaNombres();
        ArchivoTexto.CrearArchivo();
    }
}