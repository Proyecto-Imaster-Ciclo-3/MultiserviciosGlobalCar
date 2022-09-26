using System;
using System.Collections.Generic;
namespace GlobalCar.App.Dominio
{
    public class Historial
    {
        public int Id{get;set;}
        public  DateTime Fecha{get; set;}
        public Vehiculo Placa{get; set;}
        public List<ServicioEspecialista> TipoServicioEspecialista{get;set;}
    }
}