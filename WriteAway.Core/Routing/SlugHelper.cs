using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace WriteAway.Core.Routing
{
    public static class SlugHelper
    {
        /// <summary>
        /// Creates a new slug.
        /// </summary>
        /// <param name="phrase"></param>
        /// <returns></returns>
        public static string CreateNewSlug(this string text)
        {
            string str = text.RemoveAccent().ToLower();
            // Replaces non-letters/numbers with nothing
            str = Regex.Replace(str, @"[^a-z0-9\s-]", "");

            // More than two spaces back to back become one
            str = Regex.Replace(str, @"\s+", " ").Trim();

            // Replace this with a custom length, not just 45
            str = str.Substring(0, str.Length <= 45 ? str.Length : 45).Trim();

            // Turns remaining spaces to hyphens
            str = Regex.Replace(str, @"\s", "-");
            return str;
        }

        private static string RemoveAccent(this string text)
        {
            byte[] bytes = System.Text.Encoding.GetEncoding("Cyrillic").GetBytes(text);
            return System.Text.Encoding.ASCII.GetString(bytes);
        }
    }
}
