using System.Text;

namespace System.Text
{
    public class IndentedStringBuilder
    {
        StringBuilder stringBuilder;
        int indentCount;

        public IndentedStringBuilder()
        {
            stringBuilder = new StringBuilder();
        }

        public void IncreaseIndent()
        {
            IncreaseIndent(1);
        }

        public void IncreaseIndent(int count)
        {
            indentCount += count;
        }

        public void DecreaseIndent()
        {
            DecreaseIndent(1);
        }

        public void DecreaseIndent(int count)
        {
            indentCount -= count;
        }

        public void AppendIndent()
        {
            string indent = string.Empty;

            for (int i = 0; i < indentCount; i++)
                indent = "\t" + indent;

            stringBuilder.Append(indent);
        }

        public void Append(string value)
        {
            stringBuilder.Append(value);
        }

        public void AppendLine()
        {
            AppendLine(string.Empty);
        }

        public void AppendLine(string value)
        {
            string line = value;

            for (int i = 0; i < indentCount; i++)
                line = "\t" + line;

            stringBuilder.AppendLine(line);
        }

        public override string ToString()
        {
            return stringBuilder.ToString();
        }
    }
}
