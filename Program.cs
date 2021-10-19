using System;
using tabuleiro;
using xadrez;

namespace Xadrex
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                PartidaDeXadrez partida = new PartidaDeXadrez();            
                while(!partida.terminada) {
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);
                    System.Console.WriteLine();
                    System.Console.WriteLine("Turno: " + partida.turno);
                    System.Console.WriteLine("Aguardando jogada: " + partida.jogadorAtual);
                    
                    System.Console.WriteLine();
                    System.Console.Write("Origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                    
                    
                    bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();

                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab, posicoesPossiveis);
                    
                    System.Console.WriteLine();
                    System.Console.Write("Destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                    partida.executarMovimento(origem, destino);
                }
            }catch(TabuleiroException e) {
                System.Console.WriteLine(e.Message);
            }
            
            
            Console.ReadLine();
        }
    }
}