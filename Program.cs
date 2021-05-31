using System;

namespace WineProject
{

    struct Wine
    {
        public String nome, tipo;
        public double peso, preco;

        public void info()
        {
            Console.WriteLine("Nome: {0}", this.nome + " Tipo:" + this.tipo + " Peso:"
                + this.peso + " R$:" + this.preco);
        }

    }
    class Winecomerce
    {
        static void Main(string[] args)
        {
            int numVinhos , numVinhosComprar, quantidade;
            double distancia, valorProduto, valorFrete, valorTotal;
            char adicionarVinho;

            Console.WriteLine("Vinhos a cadastar");
            numVinhos = int.Parse(Console.ReadLine());
            Wine[] wines = new Wine[numVinhos];

            //wines[0].nome = "V1"; wines[0].tipo = "Tinto";  wines[0].peso = 2;  wines[0].preco = 10;
            //wines[1].nome = "V2"; wines[1].tipo = "Branco"; wines[1].peso = 1 ; wines[1].preco = 20;

            for (int i = 0; i < wines.Length; i++)
            {
                Console.WriteLine("Item{0}", i + 1);
                Console.WriteLine("Nome do vinho");
                wines[i].nome = Console.ReadLine();

                Console.WriteLine("Tipo do vinho");
                wines[i].tipo = Console.ReadLine();

                Console.WriteLine("Peso do vinho");
                wines[i].peso = Double.Parse(Console.ReadLine());

                Console.WriteLine("Preço do vinho");
                wines[i].preco = Double.Parse(Console.ReadLine());
            }


            for (int i = 0; i < wines.Length; i++)
            {
                Console.WriteLine("Item{0}", i + 1);
                wines[i].info();
            }

            Console.WriteLine("Qual vinho deseja comprar? digite o número do item");   
            numVinhosComprar = int.Parse(Console.ReadLine());

            Console.WriteLine("Quantos vinhos deseja comprar?");
            quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual a sua distância em Km?");
            distancia = double.Parse(Console.ReadLine());

            valorProduto = wines[numVinhosComprar - 1].preco * quantidade;
            Console.WriteLine("Preço produto: {0}", (valorProduto.ToString("N2")));
            if (distancia > 100)
            {
                valorFrete = wines[numVinhosComprar - 1].peso * quantidade * 5 * (distancia / 100);
                Console.WriteLine("Frete: {0}", (valorFrete.ToString("N2")));
            }
            else
            {
                valorFrete = wines[numVinhosComprar - 1].peso * quantidade * 5;
                Console.WriteLine("Frete: {0}", (valorFrete.ToString("N2")));
            }
            valorTotal = valorProduto + valorFrete;
            Console.WriteLine("Valor total: {0}", (valorTotal.ToString("N2")));

            maisVinho:
            Console.WriteLine("Gostaria de adicionar outro vinho? [s/n]");
            adicionarVinho = char.Parse(Console.ReadLine());
            if(adicionarVinho == 's' || adicionarVinho == 'S')
            {
                Console.WriteLine("Qual vinho deseja comprar? digite o número do item");
                numVinhosComprar = int.Parse(Console.ReadLine());

                Console.WriteLine("Quantos vinhos deseja comprar?");
                quantidade = int.Parse(Console.ReadLine());

                /*Console.WriteLine("Qual a sua distância em Km?");
                distancia = double.Parse(Console.ReadLine());*/

                valorProduto = valorProduto + wines[numVinhosComprar - 1].preco * quantidade;
                Console.WriteLine("Preço produto: {0}", (valorProduto.ToString("N2")));
                if (distancia > 100)
                {
                    valorFrete = valorFrete + wines[numVinhosComprar - 1].peso * quantidade * 5 * (distancia / 100);
                    Console.WriteLine("Frete: {0}", (valorFrete.ToString("N2")));
                }
                else
                {
                    valorFrete = valorFrete + wines[numVinhosComprar - 1].peso * quantidade * 5;
                    Console.WriteLine("Frete: {0}", (valorFrete.ToString("N2")));
                }
                valorTotal = valorProduto + valorFrete;
                Console.WriteLine("Valor total: {0}", (valorTotal.ToString("N2")));
                goto maisVinho;
            }

            Console.WriteLine("Compra Finalizada");

            //wines[numVinhosComprar-1].info();
        }
    }
}
