public class CartaoDebito : Cartao
{
    public override void Debitar(decimal valor)
    {
        Console.WriteLine("Chamado classe base");
        base.Debitar(valor);

        Console.WriteLine("Chamando sobrescrita");
        Console.WriteLine($"Débito de {valor:C} realizado no cartão débito.");
    }
}