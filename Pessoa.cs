namespace CodigoUML
{
    public abstract class Pessoa
    {
        public string? nome { get; set; }
        public string? endereco { get; set; }
        public bool enderecoComercial { get; set; }
        public abstract void PagarImposto(float salario);
    }
}