using Minsk.CodeAnalysis.Symbols;

namespace Minsk.CodeAnalysis.Binding
{
    internal sealed class BoundConversionExpression : BoundExpression
    {
        public BoundConversionExpression(TypeSymbol type, BoundExpression expression)
        {
            Type = type;
            Expression = expression;
        }

        public override TypeSymbol Type { get; }
        public BoundExpression Expression { get; }

        public override BoundNodeKind Kind => BoundNodeKind.ConversionExpression;
    }
}