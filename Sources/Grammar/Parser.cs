using System;
using Stele.Program;

namespace Stele.Grammar
{
    /// <summary>
    /// 语法分析器
    /// </summary>
    public class Parser
    {
        public Statement Parse(Lexer lexer)
        {
            return new Pass();
        }
    }
}
