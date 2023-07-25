using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula12Atividade
{
    internal class produtos
    {
        public string nome;
        public string descricao;
        public double quantidade;
        public double preco;
        public bool status;
        
        public void mostra()
        {
            Console.WriteLine("Confirmação de seu produto:");
            Console.WriteLine($"produto escolhido: {nome}, ");
            Console.WriteLine($"descrição deste produto: {descricao}");
            Console.WriteLine($"Temos: {quantidade} quantidades.");
            Console.WriteLine($"no valor de {preco}");
            Console.WriteLine($"{status}\n\n");
        }
        public void desativa()
        {
            quantidade = 0;
            status = false;
        }



    }
}
