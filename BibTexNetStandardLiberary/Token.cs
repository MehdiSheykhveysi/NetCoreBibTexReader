using System.Diagnostics;

namespace BibTeXLibrary
{
    internal struct Token
    {
        public TokenType Type;
        public string Value;

        public Token(TokenType type, string value = "")
        {
            Type = type;
            Value = value;
            Debug.WriteLine(type + "\t" + value);
        }
    }

    public enum TokenType
    {
        Start,
        //oy2fsmhbm5gtky64zgnqypf3qctjoj2uxoiitsaubxgcum
        Name,
        String,

        Quotation,

        LeftBrace,
        RightBrace,

        Equal,
        Comma,

        Concatenation,

        EOF
    }
}
