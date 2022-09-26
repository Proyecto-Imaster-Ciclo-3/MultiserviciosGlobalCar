using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using GlobalCar.App.Dominio;
namespace GlobalCar.App.Persistencia
{
    public interface IRepositorioVehiculo
    {
        IEnumerable<Vehiculo> GetAllVehiculos();
        Vehiculo AddVehiculo(Vehiculo vehiculo);
        Vehiculo UpdateVehiculo(Vehiculo vehiculo);
        void DeleteVehiculo(int idVehiculo);
        Vehiculo GetVehiculo(int idVehiculo);
        IEnumerable<Vehiculo> GetVehiculosPorFiltro(string filtro);

        Cliente AsignarCliente(int idVehiculo, int idCliente);
    }
}