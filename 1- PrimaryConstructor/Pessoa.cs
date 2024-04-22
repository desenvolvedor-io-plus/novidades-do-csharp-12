using Microsoft.Extensions.Logging;

namespace PrimaryConstructors
{
    /*Construtor tradicional
    public class Pessoa
    {
        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        public string Nome { get; }
        public string Sobrenome { get; }
    }
    */

    //Primary Constructor
    public class Pessoa(string nome, string sobrenome)
    {
        public string Nome { get; } = nome;
        public string Sobrenome { get; } = sobrenome;
        public string nomeCompleto()
        {
            return Nome + " " + Sobrenome;
        }
    }


    /*Injeção de dependencia
     * 
     * 
    public class Pessoa(ILogger<Pessoa> logger)
    {
        public void LogDeInformacoes()
        {
            logger.LogInformation("Log de informações");
        }
    }
    */
}
