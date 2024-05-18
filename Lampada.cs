using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1
{       
    // A estrutura recomendada é:
    // 1 - Classe
    //      Dentro da classe são colocados os atributos dessa classe
    // 2 - Construtores
    //      Os construtores são responsáveis por definir como o objeto será criado, pode ser vazio
    // 3 - Metodos
    //      Os Métodos são responsáveis por conter as linhas de código que modificarão os atributos,
    // executarão ações retornando ou não informações.


    //Classe:
    public class Lampada
    {
        //Atributos
        public bool Ligada { get; set; } = false;
        public int Intensidade { get; set; } = 1;
        
    //Construtor vazio
        public Lampada() 
        {

        }
        //Construtor com parametros
        public Lampada(bool ligada, int intensidade) 
        {
            Ligada = ligada;
            Intensidade = intensidade;
        }

    //Metodo - Sempre inicia com Maiusculo, sempre tem comandos entre as
    // chaves
        public string LampadaLigada(){
            if (Ligada){
                return ($"A lampada esta ligada {Intensidade}");
            }else{
                return ($"A lampada esta desligada {Intensidade}");
            }
        }
        // public void LigarDesligar (bool NovoEstado)  
        // {
        //     this.Estado = NovoEstado;
        // }
        // public bool RetornaEstado (){
        //     return Estado;
        // }
        // public void AjustarIntensidade (int NovaInt)
        // {
        //     this.Intensidade = NovaInt;
        // }
    }
}