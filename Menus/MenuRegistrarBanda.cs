using ScreenSound.Modelos;
namespace ScreenSound.Menus;

internal class MenuRegistrarBanda : Menu
{
    public override void ExecutarAsync(Dictionary<string, Banda> bandasRegistradas)
    {
        base.ExecutarAsync(bandasRegistradas);
        ExibirTituloDaOpcao("Registro das bandas");
        Console.Write("Digite o nome da banda que deseja registrar: ");

        string nomeDaBanda = Console.ReadLine()!;
        Banda banda = new(nomeDaBanda);
        bandasRegistradas.Add(nomeDaBanda, banda);

        Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");

        Thread.Sleep(4000);
        Console.Clear();
    }
}
