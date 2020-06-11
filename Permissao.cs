using System;

namespace Aula_15_TryCatch
{
    public class Permissao
    {
        private bool permitir { get; set; }

        public void Autorizar(){
            try{

            Console.WriteLine("Permitir? True/False");
            permitir = Boolean.Parse(Console.ReadLine());   


            }catch(Exception){

                Console.WriteLine("Erro gerado...");

            }
        }
    }
}