using System;
using System.Collections.Generic;
using System.Text;

namespace PetOwner.Infrastructure.Enums
{
    /// <summary>
    /// Contains extension methods for enumerations
    /// </summary>
    static class EnumExtensions
    {
        /// <summary>
        /// Parse the string representation 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="textRespresentation"></param>
        /// <returns></returns>
        public static T Parse<T>(this string textRespresentation)
        {
            return (T)Enum.Parse(typeof(T), textRespresentation);
        }
    }
}
