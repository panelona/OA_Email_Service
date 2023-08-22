using Microsoft.EntityFrameworkCore;
using OA_Email.Domain.Interfaces;
using OA_Email.Repository.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OA_Email.Repository.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly AppDbContext _context;

        public BaseRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<T> BuscarEntidadePorId(Guid id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<T> BuscarEntidade(Expression<Func<T, bool>> expression)
        {
            return await _context.Set<T>().FirstOrDefaultAsync(expression);
        }


        public async Task<IEnumerable<T>> BuscarEntidades()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<IEnumerable<T>> BuscarEntidades(Expression<Func<T, bool>> expression)
        {
            return await _context.Set<T>().Where(expression).ToListAsync();
        }

        public async Task CriarEntidade(T item)
        {
            await _context.Set<T>().AddAsync(item);
            await _context.SaveChangesAsync();
        }

        public async Task DeletarEntidade(T item)
        {
            _context.Set<T>().Remove(item);
            await _context.SaveChangesAsync();
        }

        public async Task EditarEntidade(T item)
        {
            _context.Set<T>().Update(item);
            await _context.SaveChangesAsync();
        }
    }
}
