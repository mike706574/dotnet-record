using System;
using System.Linq;

namespace Mike.Data
{
    public class TypeMismatchException : Exception
    {
        private string Key { get; }
        private object Value { get; }
        private string TypeName { get; }
        private string ClassName { get; }

        public TypeMismatchException(string key, object value,
            string typeName,
            string className)
            : base(BuildMessage(key, value, typeName, className))
        {
            Key = key;
            Value = value;
            TypeName = typeName;
            ClassName = className;
        }

        private static string BuildMessage(string key, object value, string typeName, string className)
        {
            return
                $"Value \"{value}\" of class \"{className}\" for key \"{key}\" must be {aOrAn(typeName)} {typeName}.";
        }


        private static string aOrAn(String followingWord)
        {
            bool startsWithVowel = "aeiou".IndexOf(Char.ToLower(followingWord.ToCharArray().ElementAt(0))) != -1;
            return startsWithVowel ? "an" : "a";
        }
    }
}