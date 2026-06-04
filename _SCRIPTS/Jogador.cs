using System;
namespace MongeDoContestado._SCRIPTS
{

public class Jogador : Ser
{
    public int XpAtual { get; set; }

    public Jogador(string _nome, int _hpMax) : base(_nome, _hpMax) {
        XpAtual = 0; // O jogador começa com 0 XP
    }    

    // O "override" avisa que o Jogador ataca de um jeito diferente!
    public override void Atacar(Ser _alvo) 
    {
        _alvo.HpAtual -= 20; // O inimigo é bruto, tira 20!
        Console.WriteLine($"{Nome} dá um golpe brutal em {_alvo.Nome}!");
    }
    public void ReceberXp(int _xp) 
    {
        XpAtual += _xp;
        Console.WriteLine($"{Nome} ganhou {_xp} XP!");
    }
}
}