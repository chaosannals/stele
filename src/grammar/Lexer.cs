using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Stele.Grammar
{
    /// <summary>
    /// 
    /// </summary>
    public class Lexer
    {
        private StreamReader reader;
        private List<Lexeme> queue;

        public Lexer(StreamReader reader)
        {
            this.reader = reader;
            queue = new List<Lexeme>();
        }

        public Lexeme Poll()
        {
            return null;
        }

        public Lexeme Pull()
        {
            if (reader.EndOfStream)
            {
                return new Lexeme(Token.End, "");
            }
            while (Char.IsWhiteSpace((char)reader.Peek()))
            {
                reader.Read();
            }
            if (Char.IsDigit((char)reader.Peek()))
            {

            }
            if (Char.IsLetter((char)reader.Peek()))
            {

            }
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
