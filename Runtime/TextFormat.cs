namespace CodeCatGames.HMProDebug.Runtime
{
    public sealed class TextFormat
    {
        #region Fields
        public static readonly TextFormat Bold = new("b");
        public static readonly TextFormat Italic = new("i");
        private readonly string _prefix;
        private readonly string _suffix;
        #endregion

        #region Constructor
        private TextFormat(string format)
        {
            _prefix = $"<{format}>";
            _suffix = $"</{format}>";
        }
        #endregion

        #region Operators
        public static string operator %(string text, TextFormat textFormat) =>
            textFormat._prefix + text + textFormat._suffix;
        #endregion

        #region StaticFactories
        public static TextFormat FromCustomFormat(string format) => new(format);
        #endregion
    }
}