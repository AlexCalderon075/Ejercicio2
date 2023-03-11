using System;
namespace Ejercicio2{
class Automovil
{
    

       

    public string id;
    public string Marca;
    public int KM;
    public  double Precio;
    public string Modelo;

        public Automovil(string id, string marca, int kM, double precio, string modelo)
        {
            this.id = id;
            Marca = marca;
            KM = kM;
            Precio = precio;
            Modelo = modelo;
        }

        public override string ToString()
    {
        return $"ID: {this.id}, Marca: {this.Marca}, Modelo: {this.Modelo}, Km: {this.KM}, Precio: {this.Precio}";
    }
    
}

    

}

