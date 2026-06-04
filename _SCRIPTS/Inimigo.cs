using System;
namespace MongeDoContestado._SCRIPTS
{
    public enum TipoInimigo
    {
        Goblin,
        Orc,
        Troll
    }
    public class Inimigo : Ser
    {
        public TipoInimigo Tipo { get; set; }

        public Inimigo(string _nome, int _hpMax, TipoInimigo _tipo) : base(_nome, _hpMax)
        {
            Tipo = _tipo;
        }

        // O "override" avisa que o Inimigo ataca de um jeito diferente!
        public override void Atacar(Ser _alvo)
        {
            _alvo.HpAtual -= 15; // O inimigo é bruto, tira 15!
            Console.WriteLine($"{Nome} dá um golpe brutal em {_alvo.Nome}!");
        }
    }

}