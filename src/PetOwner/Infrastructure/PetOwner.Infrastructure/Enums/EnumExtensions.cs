using System;
using System.Collections.Generic;
using System.Text;

namespace PetOwner.Infrastructure.Enums
{
    static class EnumExtensions
    {
        public static T Parse<T>(this string textRespresentation)
        {
            return (T)Enum.Parse(typeof(T), textRespresentation);
        }
    }
}
