using Terraria.ModLoader;

namespace LogSpiralToolkit;

public class LogSpiralToolkit : Mod
{
    public override void Load()
    {
        var m = ModLoader.Mods;
        SilkyUIFramework.DllRefSupport.AddContents(this, "Assets/SilkyUIFramework/");
    }
}
