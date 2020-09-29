using System.Globalization;
namespace Ex_Produtos_Estoque
{
    class Produto
    {   
        //ATRIBUTOS DA CLASSE Produto
        public string Nome;
        public double Preco;
        public int Quantidade;

       
        //CONTABILIZA O ESTOQUE
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;

        }

        //ADICIONA PRODUTOS AO ESTOQUE
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;

        }
        
        //REMOVE PRODUTOS DO ESTOQUE
        public void RemoverProdutos(int quantidade)
        {
            Quantidade = Quantidade -= quantidade; 
        }



       
        //SOBREPOSIÇÃO OVERRIDE.ToString    TRANSFORMA UM PRODUTO EM STRING. QUANDO O OBJETO É COLOCADO DENTRO DE UM CW , ELE CHAMA O MÉTODO ToString JA COM A FORMATAÇÃO.
        public override string ToString()
        {
            return Nome + ", $" + Preco.ToString("F2",CultureInfo.InvariantCulture) 
                + ", " + Quantidade + " unidade, Total: $ "  
                +ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture); 
        }
    }
}
