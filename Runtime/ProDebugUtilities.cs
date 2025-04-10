using UnityEngine;

namespace CodeCatGames.HMProDebug.Runtime
{
    public static class ProDebugUtilities
    {
        #region Executes
        public static string CachedColor(string text, Colorize color) => text % color;
        public static string CachedFormat(string text, TextFormat format) => text % format;
        public static string FromCustomHex(string text, string hex) => text % Colorize.FromCustomHex(hex);
        public static string FromCustomColor(string text, Color color) => text % Colorize.FromCustomColor(color);
        public static string FromCustomFormat(string text, string format) => text % TextFormat.FromCustomFormat(format);
        #endregion
    }
}