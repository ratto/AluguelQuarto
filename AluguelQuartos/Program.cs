using System;

namespace AluguelQuartos {
    class Program {
        static void Main(string[] args) {
            // 10 vetores iniciados (quartos de 0 a 9)
            Quarto[] quarto = new Quarto[10];

            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());

            // depois de pegar a quantidade de pessoas que irão alugar o quarto...
            for (int i = 0; i < n; i++) {
                // ... registra cada um deles...
                Console.WriteLine("Aluguel n°" + (i + 1));
                Console.Write("Nome: ");
                String nome = Console.ReadLine();
                Console.Write("E-Mail: ");
                String email = Console.ReadLine();
                Console.Write("Quarto escolhido: ");
                int e = int.Parse(Console.ReadLine());
                Console.WriteLine();

                // ... no quarto que ele pedir
                quarto[e] = new Quarto { Nome = nome, Email = email };
            }

            // por fim é só exibir ordenadamente apenas os quartos ocupados
            Console.WriteLine("Quartos ocupados: ");
            for (int j = 0; j < 9; j++) {
                if (quarto[j] != null) {
                    Console.WriteLine(j + ": " + quarto[j]);
                }
            }
        }
    }
}
