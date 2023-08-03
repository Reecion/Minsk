using System;
using Minsk.CodeAnalysis.Syntax;
using Xunit;

namespace Minsk.Tests.CodeAnalysis.Syntax;

public class LexerTest
{
    [Theory]
    public void Lexer_Lexes_Token(SyntaxKind kind, string text)
    {
        var tokens = SyntaxTree.Parse(text);
    }

    private static IEnumerable<(SyntaxKind kind1, string text)> GetTokens()
    {
        return new[] {
            (SyntaxKind.)
        }
    }
}