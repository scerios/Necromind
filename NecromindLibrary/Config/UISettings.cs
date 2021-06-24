using System;
using System.Drawing;

namespace NecromindLibrary.Config
{
    public static class UISettings
    {
        public readonly static Color BackgroundColor = Color.FromArgb(23, 32, 42);
        public readonly static Color LabelColor = Color.FromArgb(191, 64, 50);
        public readonly static Color ValueColor = Color.FromArgb(211, 84, 0);
        public readonly static Color ErrorColor = Color.FromArgb(214, 48, 49);
        public readonly static Color SuccessColor = Color.FromArgb(106, 176, 76);
        public readonly static Color TextColorDefault = Color.FromArgb(229, 232, 232);
        public readonly static Color TextColorInfo = Color.FromArgb(127, 140, 141);
        public readonly static string FontStyle = "Courier New";

        public readonly static int BtnSizeBigX = 100;
        public readonly static int BtnSizeSmallX = 25;
        public readonly static int BtnSizeY = 25;
        public readonly static int BtnFontSizeBig = 12;
        public readonly static int BtnFontSizeSmall = 10;
    }
}