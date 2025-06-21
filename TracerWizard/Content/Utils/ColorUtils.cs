using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Terraria.Chat;
using Terraria.Localization;

namespace TracerWizard.Content.Utils
{
    // Read the file name: "TracerUtils" before you read this
    public static partial class TracerUtils
    {
        public static void PrintTextInGreen(NetworkText text)
        {
            Color color = Microsoft.Xna.Framework.Color.Green;
            ChatHelper.BroadcastChatMessage(text, color);
        }
    }
}