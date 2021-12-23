using tabuleiro;

namespace xadrez
{
    class PosicaoXadrez
    {
        public char coluna { get; set; }
        public int linha { get; set; }

        public PosicaoXadrez(char coluna, int linha)
        {
            this.coluna = coluna;
            this.linha = linha;
        }

        public Posicao toPosicao()
        {
            return new Posicao(8 - linha, coluna - 'a'); // coluna -'a' esta contando com o valor do caracter que sao seguidos 
        }
        public override string ToString()
        {
            return ""+coluna+linha; 
        }
    }
}
