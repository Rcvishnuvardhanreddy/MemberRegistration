using System.Text.RegularExpressions;

namespace DAL.Extensions
{
    public static class StringExtensions
    {
        public static Regex Regex => new("^[a-zA-Z0-9]+(?:[_-])*$");

        /// <summary>
        /// Determines whether [is valid identifier] [the specified source].
        /// </summary>
        /// <param name="src">The source.</param>
        /// <returns>
        ///   <c>true</c> if [is valid identifier] [the specified source]; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsValidIdentifier(this string src)
        {
            return Regex.IsMatch(src);
        }
    }
}
