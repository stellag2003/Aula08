using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula08ListasERepeticao
{
    class Program

    {
        

        static void Main(string[] args)
        {

            List<string> nomes = new List <string>();

            nomes.Add("Stella");
            nomes.Add("William");
            nomes.Add("Luis");
            nomes.Add("Kethely");
            nomes.Add("Emily");
            nomes.Add("Bianca");


            int contador = 0;

            while(contador< nomes.Count)
            {
                Console.WriteLine("O nome é " +nomes [contador]);
                contador++;
            }

            Console.ReadKey();








        }

        void RepeticaoWhile()
        {

            //Repetições (loop)

            int contador = 0;

            while (contador < 5)
            {
                Console.WriteLine("Ola");
                contador = contador + 1;
            }

            // Para acumular valores em uma variável
            contador = contador + 1;// Repete o valor que tinha antes + o novo valor
            contador += 1; // acrescenta um valor na variável que já existe
            contador++;// adiciona 1; mas apenas 1

            // Também é possível usar outros operadores matemáticos ANTES do igual
            contador = contador / 2;
            contador /= 2;
            contador -= 2;
            contador *= 2;





            Console.ReadKey();







        }
        void Atividade()
            {

             List<string> nomes = new List<string>(2);

            string opção;
            nomes[0] = "Pedro";
            int posição;

            Console.WriteLine("Cadastro de usuários:");
            Console.WriteLine("1-Cadastrar");
            Console.WriteLine("2-Buscar");
            Console.WriteLine("Digite uma opção");
            opção = Console.ReadLine();

            if (opção == "1")
            {
                Console.WriteLine("Digite o seu nome");
                
                Console.WriteLine("Nome cadastrado com sucesso");

            }

            Console.WriteLine("Digite a posição que quer buscar");
            posição = int.Parse(Console.ReadLine());

            if (posição > 2)
            {
                Console.WriteLine("Essa posição não existe");
                Main(null);
                return;











            }
            


            







        }
        void Listas()
        {
            List<string> nomes = new List<string>();


            nomes.Add("Conrado");
            nomes.Add("Harry");
            nomes.Add("Zayn");

            Console.WriteLine("A primeira posição é:" + nomes[0]);
            Console.WriteLine("A segunda posição é:" + nomes[1]);
            Console.WriteLine("A terceira posição é:" + nomes[2]);

            nomes.Remove("Harry");
            nomes.RemoveAt(1);
            // removem da lista


            int quantidade = nomes.Count;
            Console.WriteLine($"Existem {quantidade} itens dentro da lista");

            Console.ReadKey();

            /*
              
             
            ARRAYS E LISTAS:

            Tanto um como o outro servem para guardar um conjunto de dados dentro de uma mesma variável C#.

            Os Arrays são limitados. É preciso definir um tamanho limite ao criar um novo array, eemplo:

            */
            string[] nomes1 = new string[3];
            //OU
            int[] idades = { 1, 2, 3, 4, 5 };

            /* 
             * As listas funcionam como os arrays, a diferença é que uma lista não tem um tamanho definido e pode 
             * crescer para sempre, exemplo:
             * 
             */

            List<string> nomes2 = new List<string>();


            nomes.Add("Conrado");
            nomes.Add("Harry");
            nomes.Add("Zayn");









        }
        void Arrays()
        {

            string[] nomes = new string[3];
            int[] idades = { 1, 2, 3, 4, 5 };

            nomes[0] = "Conrado";
            nomes[1] = "Stella";
            nomes[2] = "Outro";
            
            Console.WriteLine("O nome da primeira posição é" + nomes[0]);
            Console.WriteLine("O nome da segunda posição é" + nomes[1]);
            Console.WriteLine("O nome da terceira posição é" + nomes[2]);


            Console.ReadKey();


        }
    }
}



