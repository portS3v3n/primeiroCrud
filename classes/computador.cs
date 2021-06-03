using System;


namespace primeiroCrud

    

{
        public class computador : indiceBase 
        {
            private equipamentoTipo equipamento { get; set; }
            private string Marca { get; set; }
            private string Descricao { get; set; }
            private int AnoFabricacao { get; set; }
            private double Peso { get; set; }
            private bool Excluido { get; set; }
    
        public computador(int id, equipamentoTipo equipamento, string marca, string descricao, int anoFabricacao, double peso) 
                      {
                          this.ID = id;
                          this.equipamento = equipamento;
                          this.Marca = marca;
                          this.Descricao = descricao;
                          this.AnoFabricacao = anoFabricacao;
                          this.Peso = peso;
                          this.Excluido = false; 

                      }
    
        public override string ToString()
        {
            string retorno = "";
            retorno += "Equipamento: " + this.equipamento + Environment.NewLine;
            retorno += "Marca: " + this.Marca + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de Fabricação: " + this.AnoFabricacao + Environment.NewLine;
            retorno += "Peso: " + this.Peso + Environment.NewLine;
            retorno += "Excluido: " + this.Excluido;
			return retorno;
        
        }
        
        public string retornaMarca()
        {
            return this.Marca;
        }

        public int retornaId()
        {
            return this.ID;
        }
        
        public bool retornaExcluido()
        {
            return this.Excluido;
        }

        public void exclui() 
        {
            this.Excluido = true;
        }

    }
}