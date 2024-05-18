namespace ConsoleApp2

{

    public class Tablet : DispositivoEletronico 
{
    // Atributos adicionais
    public double TamanhoTela { get; set; }
    public int CapacidadeBateria { get; set; }

    // Construtor
    public Tablet(string marca, string modelo, int anoDeFabricacao, double tamanhoTela, int capacidadeBateria)
        : base(marca, modelo, anoDeFabricacao)
    {
        TamanhoTela = tamanhoTela;
        CapacidadeBateria = capacidadeBateria;
    }

    // Implementação do método Ligar() para tablet
    public override void Ligar()
    {
        Console.WriteLine("Ligando o tablet...");
        // Lógica específica para ligar um tablet
    }

    // Implementação do método Desligar() para tablet
    public override void Desligar()
    {
        Console.WriteLine("Desligando o tablet...");
        // Lógica específica para desligar um tablet
    }

    // Sobrescrita do método ObterDescricao()
    public override string ObterDescricao()
    {
        return $"{base.ObterDescricao()}, Tamanho da Tela: {TamanhoTela} polegadas, Bateria: {CapacidadeBateria}";
    }

    // Sobrescrita do método VerificarBateria()
    public override int VerificarBateria()
    {
        // Retorna a capacidade atual da bateria em porcentagem
        return CapacidadeBateria;
    }
}









}    