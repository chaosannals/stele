using System;
using System.Collections.Generic;
using System.Text;

namespace Stele.Grammar
{
    public enum Token
    {
        End,
        EndOfLine,
        LeftParenthesis,
        RightParenthesis,
        LeftCurly,
        RightCurly,
        LeftBracket,
        RightBracket,
        Semicolon,// ;
        Colon,// :
        Dot,// .
        Identifier,
        Number,
        Return,// return
        Nil,// nil
        Define,// =>
        Assign,// =
        Plus,// +
        Minus,// -
        Greater,// >
        Lesser,// <
    }
}
