
// É ASSIM QUE FAZ COMENTÁRIO EM BLOCO

//TESTE


using System;
using System.Collections.Generic; //biblioteca
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//  namespace é a área do projeto (nome do projeto)
namespace CATI9101
{
    internal class Program
    {
        /*
        //  atributos
        static int x;
        //  construtores - criam e inicialiam insância de classe

        //  métodos de acesso (get e set) - C# - Propriedades

        // métodos da classe - função/operação/ação do objeto

        static void Main(string[] args)
        {
            /*
             

            //  declaração de variáveis
            x = 5;         //  inteiro
            var nome = "Maria"; //  string
            var teste = true;   //  bool
            var valor = 12.89;  //  double
            var num = 15f;      //  float

            byte[] vetor = new byte[x]; //  matriz de bytes
            vetor[0] = 66;
            vetor[1] = 114;
            vetor[2] = 117;
            vetor[3] = 110;
            vetor[4] = 97;

            for (int i = 0; i < vetor.Length; i++)
            {
                //Console.WriteLine(vetor[i]);
            }

            //  variáveis de inteiros
            byte l = 255;   //byte só aceita valores de 0 até 255
            short s = 32767; //variável de 16 bits (até 32767)
            s = -32768;
            s = 0;
            s = 32767;
            ushort ss = 65535;  //valores positivos até 16 bits
            int w = 0;
            w = -2147483648; //só aceita valores até de -2147483648 até 2147483647 e não 2147483648;
            w = 2147483647;
            uint ww = 2147483648 + 2147483647;
            long t = 9223372036854775807; //só suporta até metade de 18446744073709551615, portanto até 9223372036854775807
            ulong tt = 18446744073709551615; //só suporta valores até 18446744073709551615
            t = -9223372036854775808;

            double A, B, C, D;
            A = 2.55;
            float c = 10.65f;
            string m = "teste";
            //m = m.Substring(2, 1); // letra "s"
            w++;
            bool chk = false;
            if (chk)
            {
                for (int i = 0; i < m.Length; i++)
                {
                    //Console.WriteLine(m.Substring(i, 1));
                }
                chk = true;
            }

            // a expressão w += 1; é a forma simplificada de w = w + 1



            */
        //--------------------------------------------------------------------------------
        /*
        Console.WriteLine("Digite seu nome:");
        string nome = Console.ReadLine();
        Console.WriteLine("Digite o ano de seu nascimento:");
        // EXERCÍCIO: fazer int ano = (int)Console.ReadLine();  funcionar com inteiro convertendo
        // int ano = (int)Console.ReadLine(); ñ foi possível a conversão
        // int ano = int.Parse(Console.ReadLine()); FUNCIONA, mas só trabalha com string
                    // PARSE: Converete uma cadeia de caracteres em outro tipo - em número
        //int ano = Convert.ToInt32(Console.ReadLine()); //classe convert
        //short ano = Convert.ToInt16(Console.ReadLine()); //ToInt16 é short
                                                         //ToInt8 não existe, é usado ToByte
        //byte idade = Convert.ToByte(DateTime.Now.Year - ano);    
        //outra forma
        //byte idade = (byte)(DateTime.Now.Year - (byte)ano);


        string ano = Console.ReadLine();
        int idade = DateTime.Now.Year - int.Parse(ano);
        Console.WriteLine("Olá, {0}, sua idade é {1} anos.",nome,idade);

        //  maneiras de conversões de tipos


        Console.WriteLine("Bem-vindo(a) as TABUADA DA NYRV'S");
        bool atende = false;
        int[] vnumero = new int[10];
        string sair = string.Empty;
        int cont = 10;
        while (sair != "s" && cont > 0)
        {

            Console.WriteLine("Digite um valor de 1 a 10: ");
            int numero = int.Parse(Console.ReadLine());

            do
            {
                if (numero > 0 && numero < 11)
                {
                    //só usa for se souber o limite
                    for (int i = 0; i < 10; i++)
                    {
                        //Console.WriteLine(i+1 + "º - {0} x {1} = {2}",numero,i+1,numero * (i+1));
                        Console.WriteLine($"{numero} x {i + 1} = {numero * (i + 1)}");
                        // Outra forma - Console.WriteLine((i + 1) + "° - " + numero + " x " + (i + 1) + " = " + numero * (i + 1));
                    }
                    atende = true;
                }

                else
                {
                    atende = false;
                    Console.WriteLine("Você deve digitar um valor entre 1 e 10:");
                    numero = int.Parse(Console.ReadLine());
                }

            } while (!atende); 
            cont--; // decrementa um número na variável contador
            vnumero[cont] = numero;

            Console.WriteLine();
            Console.WriteLine("Deseja sair? (s) ou enter para continuar:");
            sair = Console.ReadLine();
            Console.Clear(); // limpa o console 

        } //fim do while

        Console.WriteLine();
        Console.Write("Você consultou as tabuadas dos números: ");

        foreach (var item in vnumero)
        {
            Console.Write($"{item}, ");
        }


        //declaração de matrizes

        string[] jogadores = { "José", "Paulo", "Gabriel", "Júlio", "Marcos" };
        //int[,] pontos = { { 0, 2 }, { 1, 3 }, { 2, 5 }, { 3, 4 } }; 
        string[] times = new string[10];
        int [,] tabela = new int[5,6]; //matriz de 5 linhas e 6 colunas (ou o inverso)
        /*
        int [,] m = new int[4,2];
        m[0,0] = 0;
        m[1,0] = 1;
        m[2,0] = 2; 
        m[3,0] = 3;
        m[0,1] = 2;
        m[0,2] = 3;
        m[0,3] = 5;
        m[0,4] = 4;


        foreach (string jogador in jogadores)
        {
             Console.WriteLine(jogador);
            jogadores[i] = Console.ReadLine();
        }

        //Minipulação de Strings
        string nome = "  Wellington Vieira dos santos  ";
        Console.WriteLine(nome + " - " + nome.Length);
        // retorna o número de caracteres
        Console.WriteLine(nome.Length);
        // removendo espaços do começo e do fim (TRIM)
        nome = nome.Trim();
        Console.WriteLine(nome + " - " + nome.Length);
        // exibindo os primeiros 4 caracters de nome
        Console.WriteLine(nome.Substring(0, 4));
        // alterando a variável para manter apenas os primeiros 4 caracters
        // nome = nome.Substring(0,4);

        Console.WriteLine(nome.Remove(4));// mantém os 4 primeiros
        //string idade = "17";
        // Substituindo caracteres
        Console.WriteLine(nome.Replace(" ", "%"));
        // insere caracteres em uma string
        Console.WriteLine(nome.Insert(4, "ll"));
        // retorma a posição da 1ª ocorrencia da string
        Console.WriteLine(nome.IndexOf("i"));

        Console.WriteLine(nome.ToUpper());
        Console.WriteLine(nome.ToLower());
        // divide uma string em um vetor de strings
        string[] vnome;
        vnome = nome.Split(' ');
        for (int i = 0; i < vnome.Length; i++)
        {
            Console.WriteLine(vnome[i]);
        }

        string frase = "socorra-me subi no onibus em marrocos";
        Console.WriteLine(frase);
        string fraseinv = string.Empty;
        for (int i = frase.Length - 1; i > -1; i--)
        {
            fraseinv += frase.Substring(i, 1);
        }
        Console.WriteLine(fraseinv);

        // inverter texto convertendo para array
        char[] textoArray = frase.ToCharArray();
        Array.Reverse(textoArray);
        fraseinv = new string(textoArray);
        Console.WriteLine(fraseinv);
        Console.WriteLine();


        // Manipulação de Matrizes
        Console.WriteLine();
        int[] numeros = new int[6];
        Random random = new Random();
        for (int i = 0; i < numeros.Length; i++)
        {
            int sorteado = random.Next(1, 60);
            if (i == 0)
                numeros[i] = sorteado;
            else // a partir do segundo número sorteado
            {
                if (Array.BinarySearch(numeros, sorteado) < 0)
                    numeros[i] = sorteado;
            }
            if (i != numeros.Length - 1)
                Console.Write(numeros[i] + "-");
            else
                Console.Write(numeros[i]);
        }
        Console.WriteLine();
        Array.Sort(numeros);// ordena os números no vetor
        for (int i = 0; i < numeros.Length; i++)
        {
            if (i != numeros.Length - 1)
                Console.Write(numeros[i] + "-");
            else
                Console.Write(numeros[i]);
        }

        int p = 3; // número de cartões
        int j = 6; // quantidade de números por cartão
        int[,] vs = new int[p, j];
        for (int i = 0; i < p; i++)
        {
            for (int x = 0; x < j; x++)
            {
                vs[i, x] = Sortear();
                if (x > 0)
                {
                    while (verifica(vs, i, x, j, vs[i, x]))
                    {
                        vs[i, x] = Sortear();
                    }
                }


            }
        }// matriz carregada

        // ordenar 
        for (int l = 0; l < p; l++)
        {// percorrer pelas linhas da matriz
            for (int r = 0; r < (j - 1); r++)
            {
                for (int c = r + 1; c < j; c++)
                {
                    int t;
                    if (vs[l, r] >= vs[l, c])
                    {
                        t = vs[l, r];
                        vs[l, r] = vs[l, c];
                        vs[l, c] = t;
                    }
                }
            }
        }

        // exibe a matriz 
        Console.WriteLine();
        for (int i = 0; i < p; i++)
        {
            for (int x = 0; x < j; x++)
            {
                Console.Write(vs[i, x] + "-");
            }
            Console.WriteLine();
        }

        //List<string> list = new List<string>();
        //Queue<string> queue = new Queue<string>();
        //Stack<string> stack = new Stack<string>();
        //list.Add("oi");
        //Array.BinarySearch(vs, 5);


        Console.ReadKey();
    }
    static int Sortear()
    {
        Random random = new Random();
        return random.Next(1, 60);
    }
    static bool verifica(int[,] a, int linha, int l, int j, int valor)
    {
        bool teste = true;
        for (int i = l - 1; i < j; i++)
        {
            if (a[linha, i] == valor)
            {
                teste = false;
            }
        }
        return teste; 


        */

        // Struct

        struct Carro
        {
            public string Marca;
            public string Modelo;
            public string Cor;
            public string Placa;

            public Carro(string marca, string modelo, string cor, string placa) //
            {

                Marca = marca;
                Modelo = modelo;
                Cor = cor;
                Placa = placa;

            }

            public void ExibirDados()
            {
                Console.WriteLine($"Marca : {Marca} \nModelo: {Modelo} \nCor   : {Cor} \nPlaca : {Placa}");
            }
        }


        static void Main(string[] args)
        {
            //Carro carro = new Carro();
            //carro.Marca = "Honda";
            //carro.Modelo = "Fit";
            //carro.Cor = "Vermelho";
            //carro.Placa = "LPM4P98";

            //Carro carro2 = new Carro("Ford","Ka", "Azul","BGT8466");
            //Console.WriteLine("Marca: " + carro2.Marca);
            //Console.WriteLine("Modelo: {0}", carro2.Modelo);
            //Console.WriteLine($"Cor: {carro2.Cor} \nPlaca {carro2.Placa}");
            //carro2.ExibirDados()

            // Array - Matrizes

            // Queue - Filas

            // Stack - Pilhas

            // List - Listas
            List<Carro> carros = new List<Carro>();
            carros.Add(new Carro("Ford", "Ka", "Branco", "BGT7896"));
            carros.Add(new Carro("VW", "Fusca", "Azul", "ADE7985"));
            carros.Add(new Carro("Kia", "Soul", "Amarelo", "FLP4k52"));
            foreach (Carro carro in carros)
            {
                carro.ExibirDados();
                Console.WriteLine();
            }

            // carros.


            Console.ReadKey();



        }

    }
}