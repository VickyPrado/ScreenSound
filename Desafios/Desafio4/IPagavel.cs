// 3. Criar uma interface chamada IPagavel com um método CalcularPagamento. Implemente essa interface em duas classes, Produto e Servico. O método CalcularPagamento deve retornar o valor total a ser pago, levando em consideração a quantidade para produtos e a taxa horária para serviços.

/*
public interface IPagavel
{
    decimal CalcularPagamento();
}

public class Produto : IPagavel
{
    public string Nome { get; set; }
    public decimal PrecoUnidade { get; set; }
    public int Quantidade {  get; set; }

    public decimal CalcularPagamento()
    {
        return PrecoUnidade * Quantidade;

    }
}

public class Servico : IPagavel
{
    public string Nome { get; set; }
    public decimal TaxaHora { get; set; }
    public int HorasTrabalhadas {  get; set; }

    public decimal CalcularPagamento()
    {
        return TaxaHora * HorasTrabalhadas;
    }
}
*/