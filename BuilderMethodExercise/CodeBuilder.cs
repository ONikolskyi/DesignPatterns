using System.Text.RegularExpressions;
using System.Text;

namespace BuilderMethodExercise.MySolution
{
    public class CodeBuilder
    {
        public StringBuilder code = new StringBuilder();
        private const int indentSize = 2;

        public CodeBuilder(string className)
        {
            code.AppendLine($"public class {className}" + "\n{\n}");
        }

        public CodeBuilder AddField(string fieldName, string fieldType)
        {
            string pattern = @"(\{\n)|(\w+\;\n)";

            var matches = Regex.Matches(code.ToString(), pattern);
            int replacementIndex = matches.Last().Index + matches.Last().Length;
            code.Insert(replacementIndex, $"{new string(' ', indentSize)}public {fieldType} {fieldName};\n");

            return this;
        }

        public override string ToString() => code.ToString();

    }
}