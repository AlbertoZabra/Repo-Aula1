namespace ConsoleApp2 
{

// Classe abstrata DispositivoEletronico
public abstract class DispositivoEletronico
{
    // Atributos comuns
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int AnoDeFabricacao { get; set; }

    // Construtor
    public DispositivoEletronico(string marca, string modelo, int anoDeFabricacao)
    {
        Marca = marca;
        Modelo = modelo;
        AnoDeFabricacao = anoDeFabricacao;
    }

    // Método abstrato Ligar()
    public abstract void Ligar();

    // Método abstrato Desligar()
    public abstract void Desligar();

    // Método virtual para obter descrição
    public virtual string ObterDescricao()
    {
        return $"Marca: {Marca}, Modelo: {Modelo}";
    }

    // Método virtual para verificar bateria
    public virtual int VerificarBateria()
    {
        // Retorna -1 para indicar status desconhecido
        return -1;
    }
}



























}