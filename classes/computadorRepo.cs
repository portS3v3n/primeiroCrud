using System.Collections.Generic;
using primeiroCrud;

namespace primeiroCrud
{
    public class computadorRepo : repo<computador>
    {
        private List<computador> listaPecas = new List<computador>(); 
    
    public void atualiza(int id, computador pecas)
		{
			listaPecas[id] = pecas;
		}

		public void exclui(int id)
		{
			listaPecas[id].exclui();
		}

		public void insere(computador pecas)
		{
			listaPecas.Add(pecas);
		}

		public List<computador> Lista()
		{
			return listaPecas;
		}

		public int proximoId()
		{
			return listaPecas.Count;
		}

		public computador retornaId(int id)
		{
			return listaPecas[id];
		}
    }
}