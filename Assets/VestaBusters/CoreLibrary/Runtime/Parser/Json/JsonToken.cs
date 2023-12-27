using UnityEngine;
using System.Collections;

namespace VestaBusters.CoreLibrary.Parser
{
    public enum JsonToken
    {
        CurlyOpenBracket = 0,

        CurlyCloseBracket,

        SquareOpenBracket,

        SquareCloseBracket,

        Colon,

        Comma,

        String,

        Number,

        WhiteSpace,

        True,

        False,

        Null,

        None,
    }
}