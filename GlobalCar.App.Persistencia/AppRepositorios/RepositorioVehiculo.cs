using System;
using System.Collections.Generic;
using System.Linq;
using GlobalCar.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace GlobalCar.App.Persistencia
{
    public class RepositorioVehiculo:IRepositorioVehiculo
    {
        private readonly AppContext _appContext;

        public RepositorioVehiculo(AppContext appContext){
            _appContext = appContext;
        }

        public IEnumerable<Vehiculo> GetAllVehiculos(){
            //return GetAllVehiculos_();
            return _appContext.Vehiculos.Include("Cliente");
        }

        public IEnumerable<Vehiculo> GetAllVehiculos_(){
            return _appContext.Vehiculos;
        }

        public Vehiculo AddVehiculo(Vehiculo vehiculo){
            var vehiculoAdicionado = _appContext.Vehiculos.Add(vehiculo);
            _appContext.SaveChanges();
            return vehiculoAdicionado.Entity;
        }

        public Vehiculo UpdateVehiculo(Vehiculo vehiculo){
            var vehiculoEncontrado = _appContext.Vehiculos.FirstOrDefault(d => d.Id == vehiculo.Id);
            if (vehiculoEncontrado != null)
            {   
                vehiculoEncontrado.Placa = vehiculo.Placa;
                vehiculoEncontrado.Tipo = vehiculo.Tipo;
                vehiculoEncontrado.Modelo = vehiculo.Modelo;
                vehiculoEncontrado.Color = vehiculo.Color;
                vehiculoEncontrado.Marca = vehiculo.Marca;
                vehiculoEncontrado.Membresia = vehiculo.Membresia;
                vehiculoEncontrado.Estado = vehiculo.Estado;
                
                _appContext.SaveChanges();

            }
            return vehiculoEncontrado;
        }

        public void DeleteVehiculo(int idVehiculo){
            var vehiculoEncontrado = _appContext.Vehiculos.FirstOrDefault(d => d.Id == idVehiculo);
            if (vehiculoEncontrado == null)
                return;
            _appContext.Vehiculos.Remove(vehiculoEncontrado);
            _appContext.SaveChanges();
        }

        public Vehiculo GetVehiculo(int idVehiculo){
            //return _appContext.Vehiculos.FirstOrDefault(d => d.Id == idVehiculo);
            return _appContext.Vehiculos.Include("Cliente").FirstOrDefault(d => d.Id == idVehiculo);
        }

        public IEnumerable<Vehiculo> GetVehiculosPorFiltro(string filtro){
            var vehiculos = GetAllVehiculos(); // Obtiene todos los saludos
            if (vehiculos != null)  //Si se tienen saludos
            {
                if (!String.IsNullOrEmpty(filtro)) // Si el filtro tiene algun valor
                {
                    vehiculos = vehiculos.Where(s => s.Placa.Contains(filtro));
                }
            }
            return vehiculos;
        }

        public Cliente AsignarCliente(int idVehiculo, int idCliente){
            var vehiculoEncontrado = _appContext.Vehiculos.FirstOrDefault(m => m.Id == idVehiculo);
            if (vehiculoEncontrado != null)
            {
                var clienteEncontrado = _appContext.Clientes.FirstOrDefault(v => v.Id == idCliente);
                if (clienteEncontrado != null)
                {
                    vehiculoEncontrado.DocCliente = clienteEncontrado;
                    _appContext.SaveChanges();
                }
                return clienteEncontrado;
            }
            return null;
        }  
        
    }
}