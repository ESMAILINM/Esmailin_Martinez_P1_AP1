
using System.Linq.Expressions;
using Esmailin_Martinez_P1_AP1.DAL;
using Esmailin_Martinez_P1_AP1.Models;
using Microsoft.EntityFrameworkCore;



namespace Esmailin_Martinez_P1_AP1.Services
{
    public class Servicio(IDbContextFactory<Contexto> DbFactory)
    {  
        //1.Metodo Guardar
        public async Task<bool> Guardar()
        {
            return  true;
        }
        //2.Metodo Existe
        public async Task<bool> Existe()
        {
            return true;
        }
        //3.Insertar
        public async Task<bool> Insertar()
        {
            return false;
        }
        //4.Metodo Modificar
        public async Task<bool> Modificar()
        {
            return true;    
        }
        /// <summary>
        /// Buscar
        /// </summary>
        /// <param name="id"> </param>
        /// <returns></returns>
        public async Task<bool> Buscar(int id) { 
        
            return true;
        }
        //6.Eliminar
        public async Task<bool> Eliminar()
        {
            return true;
        }
        //7.Metodo Listar
        public async Task<bool> Listar()
        {
            return true;
        }
    }
}

