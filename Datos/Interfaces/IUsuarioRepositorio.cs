using Modelos;

namespace Datos.Interfaces
{
    public interface IUsuarioRepositorio
    {
        Task<Usuario> GetPorCodigo(string Codigo);
        Task<bool> Nuevo(Usuario usuario);
        Task<bool> Actualizar(Usuario usuario);
        Task<bool> Eliminar(string Codigo);
        Task<IEnumerable<Usuario>> GetLista();
    }
}
