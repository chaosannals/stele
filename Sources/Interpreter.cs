using System.IO;
using Stele.Grammar;
using Stele.Program;
using Stele.Runtime;

namespace Stele
{
    /// <summary>
    /// 解释器
    /// </summary>
    public class Interpreter
    {
        public Scope Global { get; private set; }

        /// <summary>
        /// 初始化
        /// </summary>
        public Interpreter()
        {
            Global = new Scope();
        }

        /// <summary>
        /// 解释执行
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        public object Interpret(StreamReader reader)
        {
            Lexer lexer = new Lexer(reader);
            Parser parser = new Parser();
            Statement statement = parser.Parse(lexer);
            return statement.Evaluate(Global);
        }

        public object Interpret(FileStream stream)
        {
            return Interpret(new StreamReader(stream));
        }
    }
}
