using Proyecto.Domain.Entities;

namespace Proyecto.Domain.Repository
{
    public interface IProductoRepository
    {
        Producto GetById(int id);
        IEnumerable<Producto> GetAll();
        void Add(Producto producto);
        void Update(Producto producto);
        void Delete(int id);
    }
}

