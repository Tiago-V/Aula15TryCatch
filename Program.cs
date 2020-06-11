using System;

namespace Aula_15_TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Permissao perm = new Permissao();
            perm.Autorizar();

            try{
                Console.WriteLine("");
            }
            catch{
                Console.WriteLine("");
            }
        }
    }
}
