using System;

namespace MongeDoContestado._SCRIPTS
{
	public abstract class Ser 
{
    public string Nome { get;  set; }
    public int HpMax { get;  set; }
    public int HpAtual { get;  set; }   
    public bool Defendendo { get; set; }

    // CORREÇÃO 2: Adicionado o construtor obrigatório para os filhos usarem
        public Ser(string _nome, int _hpMax)
        {
            Nome = _nome;
            HpMax = _hpMax;
            HpAtual = _hpMax; // Começa o jogo com a vida cheia!
            Defendendo = false; // Começa a batalha sem estar defendendo
        }

    // O "virtual" dá permissão para os filhos mudarem o método
    public virtual void Atacar(Ser _alvo)
    {
        int danoFinal = 10;

        // 1. Define o dano com base na defesa do alvo
        if (_alvo.Defendendo == true)
        {
            danoFinal = 5;
        }

        // 2. Aplica o dano direto no HP do alvo!
        _alvo.HpAtual -= danoFinal;
        Console.WriteLine($"{Nome} atacou {_alvo.Nome} e causou {danoFinal} de dano!");

        // 3. Checa se o alvo morreu após o golpe
        if (_alvo.HpAtual <= 0)
        {
            _alvo.HpAtual = 0; // Para a vida não ficar negativa (ex: -3)
            Console.WriteLine($"{_alvo.Nome} morreu!!");
        }
        else
        {
            Console.WriteLine($"{_alvo.Nome} agora tem {_alvo.HpAtual} de HP.");
        }
    }

    public void Defender()
    {
        Defendendo = true;
        Console.WriteLine($"{Nome} entrou em postura de defesa!");
    }
}
}
