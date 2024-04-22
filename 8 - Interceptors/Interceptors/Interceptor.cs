using interceptors;
using System.Runtime.CompilerServices;


namespace Interceptors
{
    public static class Interceptor
    {
        [InterceptsLocation("TROQUE_PELO_SEU_CAMINHO", line: 7, character: 7)]
        public static void InterceptorExibirNome(this Aluno aluno, string nome)
        {
            Console.WriteLine("Olááá caro aluno: " + nome);
        }
    }
}
