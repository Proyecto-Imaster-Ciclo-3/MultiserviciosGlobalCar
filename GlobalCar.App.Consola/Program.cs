using System;
using GlobalCar.App.Dominio;
using GlobalCar.App.Persistencia;
using System.Collections.Generic;

namespace GlobalCar.App.Consola
{
    class Program
    {
        private static IRepositorioCliente _repoCliente = new RepositorioCliente(new Persistencia.AppContext());
        private static IRepositorioEspecialista _repoEspecialista = new RepositorioEspecialista(new Persistencia.AppContext());
        private static IRepositorioVehiculo _repoVehiculo = new RepositorioVehiculo(new Persistencia.AppContext());

        static void Main(string[] args){
            Console.WriteLine("Bienvenidos a GlobalCar Consola");
            //AddCliente();
            //ListarClientes();
            //DeleteCliente();
            //BuscarCliente(2);

            //AddEspecialista();
            //ListarEspecialistas();
            //DeleteEspecialista();
            //BuscarEspecailista(5);

            //AddVehiculo();
            //ListarVehiculos();
            //DeleteVehiculo();
            //BuscarVehiculo(3);

            //AsignarCliente();

            
        }

        private static void AddCliente(){
            var cliente = new Cliente
            {
                Cedula="9876543",
                Nombre="Eduardo",
                Apellido="Koe",
                Telefono="3503320223",
                Contrasena="clave123",
                Direccion="Prados",
                Correo="Edukoe@gmail.com"
            };
            _repoCliente.AddCliente(cliente);
            Console.WriteLine("Usuario agregado, id: "+ cliente.Id);
        }

        private static void ListarClientes(){
            var clientes = _repoCliente.GetAllClientes();
            foreach (Cliente d in clientes)
            {
                Console.WriteLine(d.Cedula+ " " +d.Nombre + " " + d.Apellido);
            }
        }

        private static void DeleteCliente(){
            _repoCliente.DeleteCliente(3);
            Console.WriteLine("Cliente eliminado");
        }

        private static void BuscarCliente(int idCliente){
            var cliente = _repoCliente.GetCliente(idCliente);
            Console.WriteLine(cliente.Cedula + " " + cliente.Nombre + " " + cliente.Apellido + " " + cliente.Direccion + " " + cliente.Telefono + " " + cliente.Correo);
        }

        private static void AddEspecialista(){
            var especialista = new Especialista
            {
                Cedula="20343434",
                Nombre="Gullermo",
                Apellido="Toro",
                Telefono="320345343",
                Profesion="Abogado"
            };
            _repoEspecialista.AddEspecialista(especialista);
            Console.WriteLine("Especialista agregado, id: "+ especialista.Id);
        }

        private static void ListarEspecialistas(){
            var especialistas = _repoEspecialista.GetAllEspecialistas();
            foreach (Especialista d in especialistas)
            {
                Console.WriteLine(d.Cedula+ " " +d.Nombre + " " + d.Apellido+ " profesion: "+d.Profesion);
            }
        }

        private static void DeleteEspecialista(){
            _repoEspecialista.DeleteEspecialista(7);
            Console.WriteLine("Especialista eliminado");
        }

        private static void BuscarEspecailista(int idEspecialista){
            var especialista = _repoEspecialista.GetEspecialista(idEspecialista);
            Console.WriteLine(especialista.Cedula + " " + especialista.Nombre + " " + especialista.Apellido + " " + especialista.Profesion );
        }

        
        private static void AddVehiculo(){
            var vehiculo = new Vehiculo
            {
                Placa="ADA333",
                Tipo=4,
                Modelo="2015",
                Color="Gris",
                Marca="Toyota",
                Membresia=12,
                Estado=true
                
            };
            _repoVehiculo.AddVehiculo(vehiculo);
            Console.WriteLine("Vehiculo agregado, id: "+ vehiculo.Id);
        }
        
        private static void ListarVehiculos(){
            var vehiculo = _repoVehiculo.GetAllVehiculos();
            foreach (Vehiculo d in vehiculo)
            {
                Console.WriteLine(d.Placa+ " " +d.Tipo + " " + d.Modelo+" "+ d.Marca);
            }
        }

        private static void DeleteVehiculo(){
            _repoVehiculo.DeleteVehiculo(1);
            Console.WriteLine("Vehiculo eliminado");
        }

        private static void BuscarVehiculo(int idVehiculo){
            var vehiculo = _repoVehiculo.GetVehiculo(idVehiculo);
            Console.WriteLine(vehiculo.Placa + " " + vehiculo.Tipo + " " + vehiculo.Modelo + " " + vehiculo.Color + " " + vehiculo.Marca);
        }

        private static void AsignarCliente(){
            var cliente = _repoVehiculo.AsignarCliente(4, 2);
            Console.WriteLine(cliente.Nombre + " " + cliente.Apellido);
        }

    }
}
