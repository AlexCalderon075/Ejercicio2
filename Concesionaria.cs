using System;
namespace Ejercicio2{
class Concesionaria
{
    public List<Automovil>lista;
    public int Limite;
    public int noAutoAct;

     public Concesionaria(int Limite){
         this.Limite=Limite;
         lista=new List<Automovil>(Limite);
         noAutoAct=0;
     }
    public void AgregarAuto(Automovil autonuevo){
        if(autonuevo!=null &&noAutoAct!=Limite){
            Automovil? AutoEncontrado=lista.Find((autoenlista)=>autoenlista.id==autonuevo.id);
            if(AutoEncontrado==null){
                lista.Add(autonuevo);
                 noAutoAct++;

            }
           
        }

    }
    public void MostrarAuto(string id){
          Automovil? AutoEncontrado=lista.Find((a)=>a.id==id);
          if(AutoEncontrado!=null)
          Console.WriteLine(AutoEncontrado.ToString());
    }
    public void EliminarAuto(string id ){
        if(id!=""&&noAutoAct!=0){
            Automovil? AutoEncontrado=lista.Find((a)=>a.id==id);
            if(AutoEncontrado!=null){
                lista.Remove(AutoEncontrado);
                noAutoAct--;
            }
            
            

        }
    }
    public void MostrarAutos(){
        foreach(Automovil a in lista){
            Console.WriteLine(a.ToString());
        }

    }
    public void  VaciarConcesionara(){
     lista.Clear();
     noAutoAct=0;
    }



}

}