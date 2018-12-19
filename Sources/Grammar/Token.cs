using System;
using System.Collections.Generic;
using System.Text;

namespace Stele.Grammar
{
    /// <summary>
    /// 词素记号
    /// </summary>
    public enum Token
    {
        End,// 结束
        EndOfLine,// 行尾
        OpenParenthesis,// (
        CloseParenthesis,// )
        OpenBrace,// {
        CloseBrace,// }
        OpenBracket,// [
        CloseBracket,// ]
        Semicolon,// ;
        Colon,// :
        Dot,// .
        Identifier,// 标识符
        Number,// 数字
        Return,// return
        Nil,// nil
        Define,// ::
        Assign,// =
        Plus,// +
        Minus,// -
        Greater,// >
        Lesser,// <
    }
}
