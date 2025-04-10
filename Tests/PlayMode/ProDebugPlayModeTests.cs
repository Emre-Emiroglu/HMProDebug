using System.Collections;
using CodeCatGames.HMProDebug.Runtime;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace CodeCatGames.HMProDebug.Tests.PlayMode
{
    public sealed class ProDebugPlayModeTests
    {
        [UnityTest]
        public IEnumerator CachedColor_ShouldReturnCorrectColor_WhenValidColorIsPassed()
        {
            string inputText = "Hello";
            
            Colorize color = Colorize.Blue;

            string result = ProDebugUtilities.CachedColor(inputText, color);

            string expected = "<color=#0000FF>Hello</color>";

            yield return null;
            
            Assert.AreEqual(expected, result);
        }

        [UnityTest]
        public IEnumerator CachedColor_ShouldReturnCorrectColor_WhenDifferentColorIsPassed()
        {
            string inputText = "Hello";
            
            Colorize color = Colorize.Yellow;

            string result = ProDebugUtilities.CachedColor(inputText, color);

            string expected = "<color=#FFEB04>Hello</color>";
            
            yield return null;
            
            Assert.AreEqual(expected, result);
        }

        [UnityTest]
        public IEnumerator CachedFormat_ShouldReturnBoldFormat_WhenBoldIsApplied()
        {
            string inputText = "Hello";
            
            TextFormat format = TextFormat.Bold;

            string result = ProDebugUtilities.CachedFormat(inputText, format);

            string expected = "<b>Hello</b>";
            
            yield return null;
            
            Assert.AreEqual(expected, result);
        }

        [UnityTest]
        public IEnumerator CachedFormat_ShouldReturnItalicFormat_WhenItalicIsApplied()
        {
            string inputText = "Hello";
            
            TextFormat format = TextFormat.Italic;

            string result = ProDebugUtilities.CachedFormat(inputText, format);

            string expected = "<i>Hello</i>";
            
            yield return null;
            
            Assert.AreEqual(expected, result);
        }

        [UnityTest]
        public IEnumerator CachedFormat_ShouldReturnCombinedFormat_WhenBothBoldAndItalicAreApplied()
        {
            string inputText = "Hello";

            string result = inputText;
            
            result = ProDebugUtilities.CachedFormat(result, TextFormat.Bold);
            result = ProDebugUtilities.CachedFormat(result, TextFormat.Italic);

            string expected = "<i><b>Hello</b></i>";
            
            yield return null;
            
            Assert.AreEqual(expected, result);
        }
        
        [UnityTest]
        public IEnumerator FromCustomColor_ShouldReturnCorrectColor_WhenValidCustomColorIsPassed()
        {
            string inputText = "Hello";
            
            Color customColor = new Color(0.5f, 0.5f, 0.5f);

            string result = ProDebugUtilities.FromCustomColor(inputText, customColor);

            string expected = "<color=#808080>Hello</color>";
            
            yield return null;
            
            Assert.AreEqual(expected, result);
        }

        [UnityTest]
        public IEnumerator FromCustomHex_ShouldReturnCorrectColor_WhenValidHexIsPassed()
        {
            string inputText = "Hello";
            
            string customHex = "#64191e";

            string result = ProDebugUtilities.FromCustomHex(inputText, customHex);

            string expected = "<color=#64191e>Hello</color>";
            
            yield return null;
            
            Assert.AreEqual(expected, result);
        }

        [UnityTest]
        public IEnumerator FromCustomFormat_ShouldReturnCorrectFormat_WhenValidFormatIsPassed()
        {
            string inputText = "Hello";
            
            string customFormat = "k";

            string result = ProDebugUtilities.FromCustomFormat(inputText, customFormat);

            string expected = "<k>Hello</k>";
            
            yield return null;
            
            Assert.AreEqual(expected, result);
        }
    }
}