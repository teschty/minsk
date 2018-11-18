﻿using System.Collections.Generic;

namespace Minsk.CodeAnalysis.Syntax
{
    public sealed class ParenthesizedExpressionSyntax : ExpressionSyntax
    {
        public ParenthesizedExpressionSyntax(SyntaxToken openParenToken, ExpressionSyntax expression, SyntaxToken closeParenToken)
        {
            OpenParenToken = openParenToken;
            Expression = expression;
            CloseParenToken = closeParenToken;
        }

        public override SyntaxKind Kind => SyntaxKind.ParenthesizedExpression;

        public SyntaxToken OpenParenToken { get; }
        public ExpressionSyntax Expression { get; }
        public SyntaxToken CloseParenToken { get; }

        public override IEnumerable<SyntaxNode> GetChildren()
        {
            yield return OpenParenToken;
            yield return Expression;
            yield return CloseParenToken;
        }
    }
}