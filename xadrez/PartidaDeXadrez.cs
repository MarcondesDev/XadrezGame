using System;
using tabuleiro;
namespace xadrez
{
    public class PartidaDeXadrez
    {
        private Tabuleiro tab;
        private int turno;
        private Cor jogadorAtual;

        public PartidaDeXadrez() {
            tab = new Tabuleiro(8,8);
            turno = 1;
            jogadorAtual = Cor.Branca;
        }
        public void executarMovimento(Posicao origem, Posicao destino) {
            Peca p = tab.retirarPeca(origem);
            p.incrementarQteMovimentos();
            Peca pecaCapturada = tab.retirarPeca(destino);
            tab.colocarPeca(p, destino);
        }
        private void colocarPecas() {
            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0,0));
            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1,3));
            tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(2,4));
            
            tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(3,5));
        }
    }
}