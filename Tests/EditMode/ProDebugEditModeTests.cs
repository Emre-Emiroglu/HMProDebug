using CodeCatGames.HMProDebug.Runtime;
using NUnit.Framework;
using UnityEngine;

namespace CodeCatGames.HMProDebug.Tests.EditMode
{
    public sealed class ProDebugEditModeTests
    {
        [Test]
        public void CachedColor_ShouldReturnCorrectColor_WhenValidColorIsPassed()
        {
            string inputText = "Hello";
            
            Colorize color = Colorize.Red;

            string result = ProDebugUtilities.CachedColor(inputText, color);

            string expected = "<color=#FF0000>Hello</color>";
            
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void CachedColor_ShouldReturnCorrectColor_WhenDifferentColorIsPassed()
        {
            string inputText = "Hello";
            
            Colorize color = Colorize.Green;

            string result = ProDebugUtilities.CachedColor(inputText, color);

            string expected = "<color=#00FF00>Hello</color>";
            
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void CachedFormat_ShouldReturnBoldFormat_WhenBoldIsApplied()
        {
            string inputText = "Hello";
            
            TextFormat format = TextFormat.Bold;

            string result = ProDebugUtilities.CachedFormat(inputText, format);

            string expected = "<b>Hello</b>";
            
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void CachedFormat_ShouldReturnItalicFormat_WhenItalicIsApplied()
        {
            string inputText = "Hello";
            
            TextFormat format = TextFormat.Italic;

            string result = ProDebugUtilities.CachedFormat(inputText, format);

            string expected = "<i>Hello</i>";
            
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void CachedFormat_ShouldReturnCombinedFormat_WhenBothBoldAndItalicAreApplied()
        {
            string inputText = "Hello";

            string result = inputText;
            
            result = ProDebugUtilities.CachedFormat(result, TextFormat.Bold);
            result = ProDebugUtilities.CachedFormat(result, TextFormat.Italic);

            string expected = "<i><b>Hello</b></i>";
            
            Assert.AreEqual(expected, result);
        }
        
        [Test]
        public void FromCustomColor_ShouldReturnCorrectColor_WhenValidCustomColorIsPassed()
        {
            string inputText = "Hello";
            
            Color customColor = new Color(0.5f, 0.5f, 0.5f);

            string result = ProDebugUtilities.FromCustomColor(inputText, customColor);

            string expected = "<color=#808080>Hello</color>";
            
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void FromCustomHex_ShouldReturnCorrectColor_WhenValidHexIsPassed()
        {
            string inputText = "Hello";
            
            string customHex = "#FF5733";

            string result = ProDebugUtilities.FromCustomHex(inputText, customHex);

            string expected = "<color=#FF5733>Hello</color>";
            
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void FromCustomFormat_ShouldReturnCorrectFormat_WhenValidFormatIsPassed()
        {
            string inputText = "Hello";
            
            string customFormat = "u";

            string result = ProDebugUtilities.FromCustomFormat(inputText, customFormat);

            string expected = "<u>Hello</u>";
            
            Assert.AreEqual(expected, result);
        }
    }
}