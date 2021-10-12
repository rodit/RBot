using CodegenCS;

namespace RBot.BotConverters
{
    public interface ICodeGenerator
    {
        void GenerateCode(CodegenTextWriter code);
    }
}
