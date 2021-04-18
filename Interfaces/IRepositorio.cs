using System.Collections.Generic;

namespace DIOSeries.Interfaces
{
    public interface IRepositorio<T>
    {
        //CRUD
        List<T> Lista();
        void Inserir(T objeto);
        void Atualizar(int id, T objeto);
        void Excluir(int id);
        T RetornarPorId(int id);
        int ProximoId();                
    }
}