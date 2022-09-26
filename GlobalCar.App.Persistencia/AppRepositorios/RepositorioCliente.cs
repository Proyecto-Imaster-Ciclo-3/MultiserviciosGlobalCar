using System;
using System.Collections.Generic;
using System.Linq;
using GlobalCar.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace GlobalCar.App.Persistencia
{
    public class RepositorioCliente:IRepositorioCliente
    {
        private readonly AppContext _appContext;

        public RepositorioCliente(AppContext appContext){
            _appContext = appContext;
        }

        public IEnumerable<Cliente> GetAllClientes(){
            return GetAllClientes_();
        }

        public IEnumerable<Cliente> GetAllClientes_(){
            return _appContext.Clientes;
        }

        public Cliente AddCliente(Cliente cliente){
            var clienteAdicionado = _appContext.Clientes.Add(cliente);
            _appContext.SaveChanges();
            return clienteAdicionado.Entity;
        }

        public Cliente UpdateCliente(Cliente cliente){
            var clienteEncontrado = _appContext.Clientes.FirstOrDefault(d => d.Id == cliente.Id);
            if (clienteEncontrado != null)
            {   
                clienteEncontrado.Cedula = cliente.Cedula;
                clienteEncontrado.Nombre = cliente.Nombre;
                clienteEncontrado.Apellido = cliente.Apellido;
                clienteEncontrado.Telefono = cliente.Telefono;
                clienteEncontrado.Contrasena = cliente.Contrasena;
                clienteEncontrado.Direccion = cliente.Direccion;
                clienteEncontrado.Correo = cliente.Correo;
                
                _appContext.SaveChanges();

            }
            return clienteEncontrado;
        }

        public void DeleteCliente(int idCliente){
            var clienteEncontrado = _appContext.Clientes.FirstOrDefault(d => d.Id == idCliente);
            if (clienteEncontrado == null)
                return;
            _appContext.Clientes.Remove(clienteEncontrado);
            _appContext.SaveChanges();
        }

        public Cliente GetCliente(int idCliente){
            return _appContext.Clientes.FirstOrDefault(d => d.Id == idCliente);
        }

        public IEnumerable<Cliente> GetClientesPorFiltro(string filtro){
            var clientes = GetAllClientes(); // Obtiene todos los saludos
            if (clientes != null)  //Si se tienen saludos
            {
                if (!String.IsNullOrEmpty(filtro)) // Si el filtro tiene algun valor
                {
                    clientes = clientes.Where(s => s.Nombre.Contains(filtro));
                }
            }
            return clientes;
        }
        
    }
}