using System.Collections.Generic;

namespace DioSeries.Interfaces
{
    public interface IRepositorio<T>
    {
        List<T> Lista();
        T RetornoPorId(int id);
        void Insere(T entidade);
        void Exclui(int id);
        void Atualiza(int id, T entidade);
        int ProximoId();
    }
}