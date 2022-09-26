using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using GlobalCar.App.Dominio;
namespace GlobalCar.App.Persistencia
{
    public interface IRepositorioEspecialista
    {
        IEnumerable<Especialista> GetAllEspecialistas();
        Especialista AddEspecialista(Especialista especialista);
        Especialista UpdateEspecialista(Especialista especialista);
        void DeleteEspecialista(int idEspecialista);
        Especialista GetEspecialista(int idEspecialista);
        IEnumerable<Especialista> GetEspecialistasPorFiltro(string filtro);
    }
}