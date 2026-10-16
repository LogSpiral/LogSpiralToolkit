using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using SilkyUIFramework;
using SilkyUIFramework.Attributes;
using SilkyUIFramework.Elements;
using Terraria.GameContent;
using Terraria.ID;

namespace LogSpiralToolkit.UI.BrowsersPanel;

[RegisterUI]
public partial class BrowsersPanel : BaseBody
{
    public BrowsersPanel()
    {
        InitializeComponent();
    }
    public override bool Enabled { get => true; set => base.Enabled = value; }
    protected override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
    {
        base.Draw(gameTime, spriteBatch);
        Width = new(640);
        Height = new(480);
        Left = new(0, 0, 0.5f);
        Top = new(0, 0, 0.5f);
        BackgroundColor = SUIColor.Background * 0.5f;
        BorderRadius = new(8);
        // spriteBatch.Draw(TextureAssets.Item[ItemID.DiamondStaff].Value,new Rectangle((int)Bounds.X, (int)Bounds.Y, (int)Bounds.Width, (int)Bounds.Height),Color.White);
    }
}
