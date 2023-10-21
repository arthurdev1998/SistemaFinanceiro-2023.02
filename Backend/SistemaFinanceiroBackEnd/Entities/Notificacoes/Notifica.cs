using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Notificacoes
{
    public class Notifica
    {
        public Notifica() 
        {
            new List<Notifica>(); // Inicializar a lista no construtor permite que outras instancias utilizem a mesma Lista
                                  // Inicializar a lisa na propriedade permite que cada instanciação do objeto tenha sua propria Lista
        }   
        public string NomePropriedade { get; set; }
        public string Mensagem { get; set; }
        public List<Notifica> notificacoes;


        public bool ValidarPropriedadeString(string valor, string nomePropriedade) 
        {
            if(string.IsNullOrEmpty(valor) || string.IsNullOrWhiteSpace(nomePropriedade))
            {
                notificacoes.Add(new Notifica
                {
                    Mensagem = "Campo Obrigatório",
                    NomePropriedade = nomePropriedade
                });
            return false;    
            }
            return true;
        }

        public bool ValidarPropriedadeInt(int valor, string nomePropriedade) 
        {
            if (valor < 1 || string.IsNullOrWhiteSpace(nomePropriedade)) 
            {
                notificacoes.Add(new Notifica
                {
                    Mensagem = "Campo Obrigatório",
                    NomePropriedade = nomePropriedade
                });
                return false;
            }
            return true;
        }

    }
}
