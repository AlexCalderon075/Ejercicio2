namespace Ejercicio2{
class Program
{
    static void Main(string[] args)
    {
        bool MostrarMenu=true;
        while(MostrarMenu){
            MostrarMenu=Menu();
        }
    }
    public static bool Menu(){
        Console.Clear();
        Console.WriteLine("Seleccione una opcion");
        Console.WriteLine("1.- Agregar Automovil");
        Console.WriteLine("2.- Eliminar Automovil");
        Console.WriteLine("3.- Buscar Automovil  ");
        Console.WriteLine("4._Listar todos");
        Console.WriteLine("5.-Salir");
        Console.Write("Opcion:");

        switch(Console.ReadLine())
        {
             case "1":
             Console.WriteLine("Selecionastes 1");
             Console.ReadLine();
             return true;

             case "2":
              Console.WriteLine("Selecionastes 2");
             Console.ReadLine();
             return true;
             case "3":
              Console.WriteLine("Selecionastes 3");
             Console.ReadLine();
             return true;
             case"4":
              Console.WriteLine("Selecionastes 4");
             Console.ReadLine();
             return true;
             case "5":
             return false;
             default:
             return true;
            
        }
        
    }
}
}
