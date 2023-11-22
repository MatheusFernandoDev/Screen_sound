

using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuAvaliarAlbum  : Menu
{
    public override void ExecutarAsync(Dictionary<string, Banda> bandasRegistradas)
    {
        ExibirTituloDaOpcao("Avaliar Album");
        Console.Write("Digite o nome do banda que o album pertence: ");

        string nomeDaBanda = Console.ReadLine()!;

        

        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Banda banda = bandasRegistradas[nomeDaBanda];

            Console.Write("\nDigite o nome do Album que deseja avaliar: ");

            string tituloAlbum = Console.ReadLine()!;

            if (banda.Albuns.Any(a => a.Nome.Equals(tituloAlbum)))
            {
                Album album = banda.Albuns.First(a => a.Nome.Equals(tituloAlbum));

                Console.Write($"Qual a nota que o album {tituloAlbum} merece: ");


                Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
                
                album.AdicionarNota(nota);

                Console.WriteLine($"\nA nota {nota.Nota} foi registrada com sucesso para o album {tituloAlbum}");

                Thread.Sleep(2000);
                Console.Clear();
            }
            else
            {
                Console.WriteLine($"\nO album {tituloAlbum} não foi encontrado!");
                Console.WriteLine("Digite uma tecla para voltar ao menu principal");

                Console.ReadKey();
                Console.Clear();
            }
            

        }
        else
        {
            Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");

            Console.ReadKey();
            Console.Clear();

        }
    }
}
