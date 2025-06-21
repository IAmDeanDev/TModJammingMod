using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;


namespace TracerWizard.Content.Utils
{
    public class UtilsTest : ModPlayer  // This code "ModPlayer" will run for each player individually. Refer to the github wiki to understand this.
    {


        // Refer to "ColorsUtils.cs" before reading this
        // Refer to "ColorsUtils.cs" before reading this
        // Refer to "ColorsUtils.cs" before reading this
        // Refer to "ColorsUtils.cs" before reading this


        // Variables can also be static
        private static int amountOfTicks = 2159;
        private static int amountOfSeconds = TracerUtils.ConvertTicksIntoSeconds(amountOfTicks);


        // NetworkText is complicated. I don't understand it because I just had to use it without any knowledge prior. But it's basically "string". You can just ignore this and assume it's just a "string" message
        // Specifically, NetworkText is just a string that is required (probably by the server instead of the standard game on the client) by "ChatHelper.BroadcastChatMessage(text);".
        // I used "ChatHelper.BroadcastChatMessage(text, color);" instead of "Main.NewText(text)" so that it displays in the chat on ALL clients and not just the local one. You can ignore this easily.
        private NetworkText text1 = NetworkText.FromLiteral("This is text from the file: 'UtilsTest.cs'. You can remove this when you want to.");
        private NetworkText text2 = NetworkText.FromLiteral("Text is being printed in green because of TracerUtils/ColorUtils");
        private NetworkText text3 = NetworkText.FromLiteral("Ticks converted to seconds (TracerUtils) " + amountOfSeconds);



        public override void OnEnterWorld()
        {
            TracerUtils.PrintTextInGreen(text1);
            TracerUtils.PrintTextInGreen(text2);
            TracerUtils.PrintTextInGreen(text3);
        }


        public override void PlayerConnect()
        {
            TracerUtils.PrintTextInGreen(text1);
            TracerUtils.PrintTextInGreen(text2);
            TracerUtils.PrintTextInGreen(text3);
        }
    }
}