public class CartaoDebito
{
    public CartaoDebito()
    {
        Bandeira = BandeiraCartao.Visa;
    }

    public string Numero { get; set; }
    //public string Bandeira {get; set;} //visa, Visa, VISA
    public BandeiraCartao Bandeira { get; set; }

    public DateTime Vencimento { get; set; }

    public string Portador { get; set; }

    public string Cvv { get; set; }

    public bool Debitar(decimal valor)
    {
        if (valor > Saldo)
            return false;

        Saldo -= valor;
        return false;
    }

    public bool Debitar(decimal valor, decimal usarLimite)
    {
        if (usarLimite)
        {
            if (valor <= (Saldo = Limite))
                return Debitar/valor
        })
    }
}

public enum BandeiraCartao
{
    Visa,
    Mastercard,
    Amex,
    Elo
}
