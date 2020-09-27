namespace Core.Entities
{
    public class ErroArquivo
    {
        public int Linha { get; set; }
        public int Coluna { get; set; }
        public string Erro { get; set; }

        public ErroArquivo(int linha, int coluna, string erro = null)
        {
            Linha = linha;
            Coluna = coluna;
            Erro = erro ?? "Erro genérico.";
        }
    }
}