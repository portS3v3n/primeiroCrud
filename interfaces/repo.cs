using System.Collections.Generic;

namespace primeiroCrud
{
    public interface repo<T> 
    {
        List<T> Lista();
        T retornaId(int id);
        void insere(T unidade);
        void exclui(int id);
        void atualiza(int id, T unidade);
        int proximoId();
    }
}