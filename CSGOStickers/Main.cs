using CounterStrikeSharp.API.Core;
using CounterStrikeSharp.API.Core.Attributes.Registration;
using CounterStrikeSharp.API.Modules.Commands;

namespace CSGOStickers;
public class CSGOStickers : BasePlugin
{
    public override string ModuleName => "Stickers Plugin";

    public override string ModuleVersion => "0.0.1";

    public override void Load(bool hotReload)
    {
        Console.WriteLine("Skript napisal damik pre StayFragged!");
    }

    [ConsoleCommand("!stickers", "Tento prikaz zobrazi menu pre stickers")] 
    public void OnCommand(CCSPlayerController? player, CommandInfo command)
    {
        if (player == null)
        {
            Console.WriteLine("Vyber si nalepku");
            Console.WriteLine("!1 | 360 No Scope");
            Console.WriteLine("!2 | Abalone Strafe (Holo)");
            Console.WriteLine("!3 | Ace Clutch Co. (Holo)");
            Console.WriteLine("!4 | Ace Devil (Foil)");
            Console.WriteLine("!5 | Aces High");
            Console.WriteLine("!6 | Aces High (Holo)");
            Console.WriteLine("!7 | Adepta Sororitas");
            Console.WriteLine("!8 | Aeldari Avatar");
            Console.WriteLine("!9 | Ďalšia strána");
            return;
        }
    }
}


