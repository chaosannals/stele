using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Stele.Grammar
{
    /// <summary>
    /// 词法分析器
    /// </summary>
    public class Lexer
    {
        private StreamReader reader;
        private List<Lexeme> queue;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="reader"></param>
        public Lexer(StreamReader reader)
        {
            this.reader = reader;
            queue = new List<Lexeme>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="stream"></param>
        public Lexer(FileStream stream)
            :this(new StreamReader(stream)){}

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Lexeme Poll()
        {
            return null;
        }

        public Lexeme Pull()
        {
            // 忽略掉所有空格换行符等不间隔符号。
            while (Char.IsWhiteSpace((char)reader.Peek()))
            {
                reader.Read();
            }

            // 检测文件是否结束。
            if (reader.EndOfStream)
            {
                return new Lexeme(Token.End, "[EOF]");
            }

            // 数字词素。
            if (Char.IsDigit((char)reader.Peek()))
            {

            }

            // 标识词素。
            if (Char.IsLetter((char)reader.Peek()))
            {

            }

            // 符号词素。
            switch (reader.Peek())
            {
                case '=':
                    break;
                case '+':
                    break;
                case '-':
                    break;
                case '<':
                    break;
                case '>':
                    break;
                case '(':
                    break;
                case ')':
                    break;
                case '{':
                    break;
                case '}':
                    break;
                case '[':
                    break;
                case ']':
                    break;
                case ';':
                    break;
                case ':':
                    break;
                case ',':
                    break;
                case '.':
                    break;
            }
            throw new LexiconException();
        }
    }
}
