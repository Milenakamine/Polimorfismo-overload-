namespace Polimorfismo_overload_
{
    public class Calculo
    {
//overload sobrecarga, precisa apenas de uma classe trbalhar com quantidade e tipos 

public string Calcular(){
    return "Não houve nenhum calculo a ser aplicado";
}

public string Calcular(int vida){
    return "A vida do jogador está com"+vida;
}

public string Calcular(int vida, int escudo){
    return "A vida do jogador com escudo"+ (vida+escudo);
}

public string Calcular(string nome, string sobrenome){
    return $"O nome completo do jogador é {nome} {sobrenome}";
}
//juntar o nome completo do jogador 



 }

}
