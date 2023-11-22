using ScreenSound.Modelos;

namespace ScreenSound.Menus;

public class MenuMostrarBandasRegistradas : Menu
{
    public override void ExecutarAsync(Dictionary<string, Banda> bandasRegistradas)
    {
        base.ExecutarAsync(bandasRegistradas);
        ExibirTituloDaOpcao("Exibindo todas as bandas registradas na nossa aplicação");

        foreach (string banda in bandasRegistradas.Keys)
        {
            Console.WriteLine($"Banda: {banda}");
        }

        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        
    }
}
