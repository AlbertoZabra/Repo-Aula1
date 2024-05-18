namespace ConsoleApp2 

{

    public class Smartphone : DispositivoEletronico
{
    // Atributos adicionais
    public string SistemaOperacional { get; set; }
    public int CapacidadeBateria { get; set; }

    // Construtor
    public Smartphone(string marca, string modelo, int anoDeFabricacao, string sistemaOperacional, int capacidadeBateria)
        : base(marca, modelo, anoDeFabricacao)
    {
        SistemaOperacional = sistemaOperacional;
        CapacidadeBateria = capacidadeBateria;
    }

    // Implementação do método Ligar() para smartphone
    public override void Ligar()
    {
        Console.WriteLine("Ligando o smartphone...");
        // Lógica específica para ligar um smartphone
    }

    // Implementação do método Desligar() para smartphone
    public override void Desligar()
    {
        Console.WriteLine("Desligando o smartphone...");
        // Lógica específica para desligar um smartphone
    }

    // Sobrescrita do método ObterDescricao()
    public override string ObterDescricao()
    {
        return $"{base.ObterDescricao()}, Sistema Operacional: {SistemaOperacional}, Bateria: {CapacidadeBateria}";
    }

    // Sobrescrita do método VerificarBateria()
    public override int VerificarBateria()
    {
        // Retorna a capacidade atual da bateria em porcentagem
        return CapacidadeBateria;
    }
}







}