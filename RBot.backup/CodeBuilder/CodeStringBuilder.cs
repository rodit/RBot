using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBot
{
    public static class BotConverter
    {
        public static StringBuilder AppendTabs(this StringBuilder sb, int count, int size = 4)
        {
            return sb.Append(Enumerable.Range(0, count * size).Select(i => ' ').ToArray());
        }
    }

    public class CodeStringBuilder
    {
        private StringBuilder _sb = new StringBuilder();

        public int IndentLevel = 0;
        public bool? NextCondition = null;
        public bool InIf = false;

        public CodeStringBuilder Indent()
        {
            IndentLevel++;
            return this;
        }

        public CodeStringBuilder UnIndent()
        {
            IndentLevel--;
            return this;
        }

        public CodeStringBuilder Append(string s)
        {
            _sb.Append(s);
            return this;
        }

        public CodeStringBuilder AppendLine(string line = "")
        {
            if (InIf)
            {
                _sb.AppendTabs(1);
                InIf = false;
            }
            if (NextCondition == null || NextCondition.Value)
            {
                _sb.AppendTabs(IndentLevel);
                _sb.AppendLine(line);
            }
            return this;
        }

        public CodeStringBuilder If(bool condition)
        {
            NextCondition = condition;
            return this;
        }

        public CodeStringBuilder EndIf()
        {
            NextCondition = null;
            return this;
        }

        public CodeStringBuilder AppendIf(string condition)
        {
            AppendLine($"if ({condition})");
            InIf = true;
            return this;
        }

        public CodeStringBuilder ForEach<T>(IEnumerable<T> enumerable, Func<T, string> func)
        {
            foreach (T t in enumerable)
                AppendLine(func(t));
            return this;
        }

        public override string ToString()
        {
            return _sb.ToString();
        }


    }
}
