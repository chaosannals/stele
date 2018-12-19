using System;
using System.Collections.Generic;
using System.Text;

namespace Stele.Grammar
{
    /// <summary>
    /// 词素
    /// </summary>
    public class Lexeme
    {
        public Token Token { get; private set; }
        public string Text { get; private set; }

        public Lexeme(Token token, string text)
        {
            Token = token;
            Text = text;
        }

        public bool Is(Token token)
        {
            return Token == token;
        }

        public override string ToString()
        {
            return Text;
        }
    }
}
