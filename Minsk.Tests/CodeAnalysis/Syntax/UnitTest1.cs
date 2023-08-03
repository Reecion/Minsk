using System;
using System.Collection.Generic;
using Minsk.CodeAnalysis.Syntax;

namespace Minsk.Tests.CodeAnalysis.Syntax;

public class LexerTest
{
    [Theory]
    public void Lexer_Lexes_Token(SyntaxKind kind, string text)
    {
        var tokens = SyntaxTree.ParseTokens(text);

        var token = Assert.Single(tokens);
        Assert.Equals(kind, token.Kind);
        Assert.Equals(text, token.Text);
    }

    public static IEnumerable<object[]> GetTokensData()
    {
        foreach (vat t in GetTokens())
            yield return new object[] {t.Kind, t.text };
    }

    private static IEnumerable<(SyntaxKind kind1, string text)> GetTokens()
    {
        return new[] {
            (SyntaxKind.IdentifierToken, "a"),
            (SyntaxKind.IdentifierToken, "abc")
        }
    }
}