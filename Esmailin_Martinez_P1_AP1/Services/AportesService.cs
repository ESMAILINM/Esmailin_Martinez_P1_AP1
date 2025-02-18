
using System.Linq.Expressions;
using Esmailin_Martinez_P1_AP1.DAL;
using Esmailin_Martinez_P1_AP1.Models;
using Microsoft.EntityFrameworkCore;




namespace Esmailin_Martinez_P1_AP1.Services
{
    public class AportesService(IDbContextFactory<Contexto> DbFactory)
    {  
        /// <summary>
        /// 1.Metodo Guardar
        /// </summary>
        /// <param name="aportes"></param>
        /// <returns></returns>
        public async Task<bool> Guardar(Aportes aportes)
        {
          if(!await Existe(aportes.AporteId))
            {
                return await Insertar(aportes);
            }
            else
            {
                return await Modificar(aportes);
            }

        }
        /// <summary>
        /// 2.Metodo Existe
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<bool> Existe(int id)
        {
            await using var contexto = await DbFactory.CreateDbContextAsync();
            return await contexto.Aportes
                .AnyAsync(x => x.AporteId == id);
        }
        /// <summary>
        /// 3.Insertar
        /// </summary>
        /// <param name="aportes"></param>
        /// <returns></returns>
        public async Task<bool> Insertar(Aportes aportes)
        {
            await using var contexto = await DbFactory.CreateDbContextAsync();
            contexto.Aportes.Add(aportes);
            return await contexto.SaveChangesAsync() > 0;
        }
        /// <summary>
        /// 4.Metodo Modificar
        /// </summary>
        /// <param name="aportes"></param>
        /// <returns></returns>
        public async Task<bool> Modificar(Aportes aportes)
        {
            await using var contexto = await DbFactory.CreateDbContextAsync();
            contexto.Aportes.Update(aportes);
            return await contexto.SaveChangesAsync() > 0;
        }
        
        /// <summary>
        /// Buscar
        /// </summary>
        /// <param name="id"> </param>
        /// <returns></returns>
        public async Task<Aportes?> Buscar(int id) {

            await using var contexto = await DbFactory.CreateDbContextAsync();
            return await contexto.Aportes
                .FindAsync(id);
        }

        /// <summary>
        /// 6.Eliminar
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<bool> Eliminar(int id)
        {
            await using var contexto = await DbFactory.CreateDbContextAsync();
            return await contexto.Aportes
                .Where(x => x.AporteId == id)
            .ExecuteDeleteAsync() > 0;
        }
        /// <summary>
        /// 7.Metodo Listar
        /// </summary>
        /// <param name="criterio"></param>
        /// <returns></returns>
        public async Task<List<Aportes>> Listar(Expression<Func<Aportes, bool>> criterio)
        {
            await using var contexto = await DbFactory.CreateDbContextAsync();
            return await contexto.Aportes
                .Where(criterio)
                .ToListAsync();
        }
    }
}

