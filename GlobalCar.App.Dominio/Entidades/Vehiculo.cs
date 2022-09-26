using System;
namespace GlobalCar.App.Dominio
{
    public class Vehiculo
    {
        public int Id{get;set;}
        public string Placa {get;set;}
        public  int Tipo{get; set;}
        public string Modelo{get; set;}
        public string Color{get; set;}
        public string Marca{get; set;}
        public int Membresia{get; set;}
        public bool Estado{get; set;}
        public Cliente DocCliente{get; set;}
    }
}
