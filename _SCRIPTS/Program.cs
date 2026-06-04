using System;
// Avisa o programa para olhar a pasta onde estão suas classes
using MongeDoContestado._SCRIPTS; 

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== SEJA BEM-VINDO AO MONGE DO CONTESTADO ===");
        Console.WriteLine("=============================================\n");

        // 1. Criando os personagens (Nome, Vida Máxima)
        Jogador monge = new Jogador("Monge João", 100);
        Inimigo goblin = new Inimigo("Goblin Saqueador", 40, TipoInimigo.Goblin);

        // 2. Turno 1: O Goblin tenta atacar o Monge
        Console.WriteLine("[TURNO 1] O Goblin corre em sua direção!");
        goblin.Atacar(monge); 
        Console.WriteLine("---------------------------------------------\n");

        // 3. Turno 2: O Monge decide se DEFENDER
        Console.WriteLine("[TURNO 2] Você prevê o próximo golpe!");
        monge.Defender(); // Ativa a postura de defesa (reduz dano pela metade)
        
        // O Goblin ataca o Monge defendendo
        goblin.Atacar(monge); 
        Console.WriteLine("---------------------------------------------\n");

        // 4. Turno 3: Contra-ataque do Monge!
        Console.WriteLine("[TURNO 3] Seu turno de revidar!");
        monge.Atacar(goblin);
        Console.WriteLine("---------------------------------------------\n");

        // 5. Final da simulação
        Console.WriteLine("[FIM DA BATALHA EM TURNOS]");
        monge.ReceberXp(30);
    }
}