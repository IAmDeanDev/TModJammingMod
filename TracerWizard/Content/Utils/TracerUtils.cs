using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System.Configuration;

namespace TracerWizard.Content.Utils
{

    // Refer to the github wiki to learn about what static means, or continue reading on.
    //
    // "Partial" allows you to write inside of this script as per usual, but then if you want to organize anything, you can just
    // make a new script file with the same name, both having the "partial" feature in the class name. Partial means that this is
    // only part of the class, and the rest is in another script with the same name of "TracerUtils". I have made another script to show you: "UtilsTest.cs".

    public static partial class TracerUtils
    {
        public static int ConvertTicksIntoSeconds(int ticks)
        {
            int seconds = ticks / 60;
            return ticks / 60;  // Refer to the github wiki page to learn about "return"
            // Return is basically used in all functions that aren't "void" functions.
        }
    }
}