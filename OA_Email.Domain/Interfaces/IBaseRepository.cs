using System.Linq.Expressions;

namespace OA_Email.Domain.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        Task<T> BuscarEntidadePorId(Guid id);
        Task<T> BuscarEntidade(Expression<Func<T, bool>> expression);
        Task<IEnumerable<T>> BuscarEntidades();
        Task<IEnumerable<T>> BuscarEntidades(Expression<Func<T, bool>> expression);
        Task CriarEntidade(T item);
        Task DeletarEntidade(T item);
        Task EditarEntidade(T item);
    }
}
