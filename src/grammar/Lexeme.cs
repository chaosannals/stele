using System;
using System.Collections.Generic;
using System.Text;

namespace Stele.Grammar
{
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
