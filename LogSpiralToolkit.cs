using Terraria.ModLoader;

namespace LogSpiralToolkit;

public class LogSpiralToolkit : Mod
{
    public override void Load()
    {
        SilkyUIFramework.DllRefSupport.AddContents(this, "Assets/SilkyUIFramework/");
    }
}
