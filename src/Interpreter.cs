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
        private Status status;

        /// <summary>
        /// 初始化
        /// </summary>
        public Interpreter()
        {
            status = new Status();
        }

        public object Interpret(StreamReader reader)
        {
            Lexer lexer = new Lexer(reader);
            Parser parser = new Parser();
            Statement statement = parser.Parse(lexer);
            return statement.Evaluate(status.Global);
        }

        public object Interpret(FileStream stream)
        {
            return Interpret(new StreamReader(stream));
        }
    }
}
