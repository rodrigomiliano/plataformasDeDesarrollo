using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Refit;

namespace BlazorApp1.Data
{
    public interface IRemoteService
    {
        [Get("/Detalle")]
        Task<List<Detalle>> GetAllDetalle();

        [Post("/Detalle")]
        Task<Detalle> GuardarDetalle(Detalle valor);



        [Get("/Recurso")]
        Task<List<Recurso>> GetAllRecurso();

        [Post("/Recurso")]
        Task<Recurso> GuardarRecurso(Recurso valor);



        [Get("/Tarea")]
        Task<List<Tarea>> GetAllTarea();

        [Post("/Tarea")]
        Task<Tarea> GuardarTarea(Tarea valor);



        [Get("/Usuario")]
        Task<List<Usuario>> GetAllUsuario(); 

        [Post("/Usuario")]
        Task<Usuario> GuardarUsuario(Usuario valor);
    }
}
