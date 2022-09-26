using System;
using System.Collections.Generic;
using System.Linq;
using GlobalCar.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace GlobalCar.App.Persistencia
{
    public class RepositorioEspecialista:IRepositorioEspecialista
    {
        private readonly AppContext _appContext;

        public RepositorioEspecialista(AppContext appContext){
            _appContext = appContext;
        }

        public IEnumerable<Especialista> GetAllEspecialistas(){
            return GetAllEspecialistas_();
        }

        public IEnumerable<Especialista> GetAllEspecialistas_(){
            return _appContext.Especialistas;
        }

        public Especialista AddEspecialista(Especialista especialista){
            var especialistaAdicionado = _appContext.Especialistas.Add(especialista);
            _appContext.SaveChanges();
            return especialistaAdicionado.Entity;
        }

        public Especialista UpdateEspecialista(Especialista especialista){
            var especialistaEncontrado = _appContext.Especialistas.FirstOrDefault(d => d.Id == especialista.Id);
            if (especialistaEncontrado != null)
            {   
                especialistaEncontrado.Cedula = especialista.Cedula;
                especialistaEncontrado.Nombre = especialista.Nombre;
                especialistaEncontrado.Apellido = especialista.Apellido;
                especialistaEncontrado.Telefono = especialista.Telefono;
                especialistaEncontrado.Profesion = especialista.Profesion;
                
                _appContext.SaveChanges();

            }
            return especialistaEncontrado;
        }

        public void DeleteEspecialista(int idEspecialista){
            var especialistaEncontrado = _appContext.Especialistas.FirstOrDefault(d => d.Id == idEspecialista);
            if (especialistaEncontrado == null)
                return;
            _appContext.Especialistas.Remove(especialistaEncontrado);
            _appContext.SaveChanges();
        }

        public Especialista GetEspecialista(int idEspecialista){
            return _appContext.Especialistas.FirstOrDefault(d => d.Id == idEspecialista);
        }

        public IEnumerable<Especialista> GetEspecialistasPorFiltro(string filtro){
            var especialistas = GetAllEspecialistas(); // Obtiene todos los saludos
            if (especialistas != null)  //Si se tienen saludos
            {
                if (!String.IsNullOrEmpty(filtro)) // Si el filtro tiene algun valor
                {
                    especialistas = especialistas.Where(s => s.Nombre.Contains(filtro));
                }
            }
            return especialistas;
        }
        
    }
}