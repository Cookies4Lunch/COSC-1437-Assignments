using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// Written by Spencer Johnson
/// </summary>

namespace CoreLibrary.Extensions
{
    public static class StringExtensions
    {
        /// <summary>
        /// Returns true if string is null, empty, or contains all whitepace characters
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        public static bool IsNullOrWhiteSpace(this string content)
        {
            return string.IsNullOrWhiteSpace(content);
        }

        /// <summary>
        /// Returns true if the specified string is null or an empty string.
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        public static bool IsNullOrEmpty (this string content)
        {
            return string.IsNullOrEmpty(content);
        }

        /// <summary>
        /// Return the first quantity of numCharacters in a given string, will return entire string if its total length is less than specified numCharacters
        /// </summary>
        /// <param name="content"></param>
        /// <param name="numCharacters"></param>
        /// <returns></returns>
        public static string Left(this string content, int numCharacters)
        {
            if (content == null) return null;

            if (content.Length < numCharacters) return content;

            return content.Substring(
                startIndex: 0,
                length: numCharacters);
        }

        /// <summary>
        /// Return the last quantity of numCharacters in a given string, will return entire string if its total length is less than specified numCharacters
        /// </summary>
        /// <param name="content"></param>
        /// <param name="numCharacters"></param>
        /// <returns></returns>
        public static string Right(this string content, int numCharacters)
        {
            if (content == null) return null;

            if (content.Length < numCharacters) return content;

            return content.Substring(
                startIndex: content.Length - numCharacters,
                length: numCharacters);
        }
    }

    
}
