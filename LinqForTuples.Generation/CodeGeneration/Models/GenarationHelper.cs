using System;
using CodeGeneration.Language;
using Common;

namespace CodeGeneration.Models
{
    class GenarationHelper
    {
        public static Access Access(string text)
        {
            return (Access)Enum.Parse(typeof(Access), text.FirstToUpper());
        }
        public static MethodModifiers MethodModifiers(string text)
        {
            return (MethodModifiers)Enum.Parse(typeof(MethodModifiers), text.FirstToUpper());
        }
    }
}
