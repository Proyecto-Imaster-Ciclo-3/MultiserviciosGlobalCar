using System;
namespace GlobalCar.App.Dominio
{
    public class ServicioEspecialista
    {
        public int Id{get;set;}
        public Servicio IdServicio{get;set;}
        public Especialista DocumentoEspecialista{get;set;}
    }
}
