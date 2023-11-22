

using OpenAI_API;
using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuExibirDetalhes : Menu
{

    public override async Task ExecutarAsync(Dictionary<string, Banda> bandasRegistradas)
    {
        base.ExecutarAsync(bandasRegistradas);

        ExibirTituloDaOpcao("Exibir detalhes da banda");
        Console.Write("Digite o nome da banda que deseja conhecer melhor: ");

        string nomeDaBanda = Console.ReadLine()!;

        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Banda banda = bandasRegistradas[nomeDaBanda];

            var client = new OpenAIAPI("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");

            var chat = client.Chat.CreateConversation();

            chat.AppendSystemMessage($"Resuma a banda {banda} em um paragrafo. adote um estilo um pouco informal informal.");

            string resposta = await chat.GetResponseFromChatbotAsync();

            Console.WriteLine(resposta);

            Console.WriteLine($"\nA média da banda {nomeDaBanda} é {banda.Media}.");

            Console.WriteLine("\nDiscografia:");

            foreach (Album  album in banda.Albuns)
            {
                Console.WriteLine($"{album.Nome} -> {album.Media}");
            }
            Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");

            Console.ReadKey();
            Console.Clear();
            

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
