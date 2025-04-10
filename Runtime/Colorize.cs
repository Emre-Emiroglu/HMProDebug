using UnityEngine;

namespace CodeCatGames.HMProDebug.Runtime
{
    public sealed class Colorize
    {
        #region Colors
        public static readonly Colorize White = new(Color.white);
        public static readonly Colorize Red = new(Color.red);
        public static readonly Colorize Yellow = new(Color.yellow);
        public static readonly Colorize Green = new(Color.green);
        public static readonly Colorize Blue = new(Color.blue);
        public static readonly Colorize Cyan = new(Color.cyan);
        public static readonly Colorize Magenta = new(Color.magenta);
        public static readonly Colorize Gray = new(Color.gray);
        #endregion

        #region HexColors
        public static readonly Colorize Orange = new("#FFA500");
        public static readonly Colorize Olive = new("#808000");
        public static readonly Colorize Purple = new("#800080");
        public static readonly Colorize DarkRed = new("#8B0000");
        public static readonly Colorize DarkGreen = new("#006400");
        public static readonly Colorize DarkOrange = new("#FF8C00");
        public static readonly Colorize Gold = new("#FFD700");
        #endregion

        #region Constants
        private const string Suffix = "</color>";
        #endregion
        
        #region Fields
        private readonly string _prefix;
        #endregion

        #region Constructors
        private Colorize(Color color) => _prefix = $"<color=#{ColorUtility.ToHtmlStringRGB(color)}>";
        private Colorize(string hexColor) => _prefix = $"<color={hexColor}>";
        #endregion

        #region Operators
        public static string operator %(string text, Colorize color) => color._prefix + text + Suffix;
        #endregion

        #region StaticFactories
        public static Colorize FromCustomColor(Color color) => new(color);
        public static Colorize FromCustomHex(string hex) => new(hex);
        #endregion
    }
}